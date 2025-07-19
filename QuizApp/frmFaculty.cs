using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualBasic;

namespace QuizApp
{
    public partial class frmFaculty : Form
    {
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=Y:\\.Net_Projects\\QuizApp\\QuizApp.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        string usname;
        public frmFaculty(string usname)
        {
            InitializeComponent();
            lblwelcome.Text = "Welcome "+usname;
            this.usname = usname;


        }

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = constr;
            conn.Open();
            loadquizzes();

            dgquiz.CellValueChanged += dgquiz_CellValueChanged;
            dgquiz.CurrentCellDirtyStateChanged += dgquiz_CurrentCellDirtyStateChanged;
 

            DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
            btnedit.HeaderText = "Edit Quiz";
            btnedit.Name = "btnEdit";
            btnedit.Text = "Edit";
            btnedit.UseColumnTextForButtonValue = true;  // This shows the text "Edit" on the button
            dgquiz.Columns.Add(btnedit);

            DataGridViewButtonColumn btnresult = new DataGridViewButtonColumn();
            btnresult.HeaderText = "Results";
            btnresult.Text = "View Result";
            btnresult.Name = "result";
            btnresult.UseColumnTextForButtonValue = true;
            dgquiz.Columns.Add(btnresult);

            loadquizzes();

            /*dgquiz.CellClick += dgquiz_CellClick;*/

        }
        public void loadquizzes()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * from Quizzes WHERE Creator=@creator";
            string creator = usname;
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@creator", creator);
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dt);
            }

            dgquiz.DataSource = dt; // Bind the DataGridView
        }
        private void createQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string username = lblwelcome.Text;
            frmCreateQuiz createQuiz = new frmCreateQuiz(username);
            createQuiz.Show();
            loadquizzes();
            
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
            conn.Close();
            frmLogin frmLog = new frmLogin();
            frmLog.Show();
            
        }

        private void editquiz_Click(object sender, EventArgs e)
        {
            
           
        }

        private void dgquiz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                // Check if the clicked cell is from the Edit button column
                if (e.ColumnIndex == dgquiz.Columns["btnEdit"].Index && e.RowIndex >= 0)
                {
                    // Get the QuizId from the selected row
                    int quizId = Convert.ToInt32(dgquiz.Rows[e.RowIndex].Cells["Quizid"].Value);

                    // Open the frmEditQuiz form and pass the QuizId for editing
                    frmEditQuiz editQuizForm = new frmEditQuiz(quizId);
                    editQuizForm.Show();

                    // After editing, you can refresh the DataGridView if needed
                    loadquizzes();
                }

            if (e.ColumnIndex == dgquiz.Columns["result"].Index  && e.RowIndex >= 0)
            {
                //Taking the quiz id of that row for displaying only result of that quiz
                int quizId = Convert.ToInt32(dgquiz.Rows[e.RowIndex].Cells["Quizid"].Value);

                frmShowresult frmshowres = new frmShowresult(quizId);
                frmshowres.Show();
            }
            

        }
        
        private void dgquiz_CellValueChanged(object sender,DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && dgquiz.Columns[e.ColumnIndex].Name == "Live")
            {
                int quizId = Convert.ToInt32(dgquiz.Rows[e.RowIndex].Cells["Quizid"].Value);
                bool isLive = Convert.ToBoolean(dgquiz.Rows[e.RowIndex].Cells["Live"].Value);

                // Update the IsLive status in the database
                UpdateLive(quizId, isLive);

            }
        }
        private void dgquiz_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgquiz.Columns[e.ColumnIndex].Name == "Live")
            {
                dgquiz_CellValueChanged(sender, e);  // Call the same logic for updating IsLive
            }
        }
        private void UpdateLive(int quizId, bool isLive)
        {
            string query = "UPDATE Quizzes SET Live = @IsLive WHERE Quizid = @QuizId";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IsLive", isLive);
                cmd.Parameters.AddWithValue("@QuizId", quizId);
                cmd.ExecuteNonQuery();


            }
            MessageBox.Show("Quiz live status updated!");
        }
        private void dgquiz_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgquiz.IsCurrentCellDirty)
            {
                dgquiz.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void makeQuizLiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string inpid = Microsoft.VisualBasic.Interaction.InputBox("Enter QuizId to delete:");
            if (int.TryParse(inpid , out int quizId))
            {
                // Step 3: Confirm with the user before deletion
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the quiz with QuizId {quizId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Step 4: Call the method to delete the quiz
                    string query = "DELETE FROM Quizzes WHERE Quizid=@quizid";
                    using(SqlCommand cmd=new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@quizid", quizId);
                        int deleted=cmd.ExecuteNonQuery();

                        if(deleted > 0)
                        {
                            string qu = "DELETE FROM Questions WHERE Quizid=@quizid";
                            using(SqlCommand deleteques=new SqlCommand(qu, conn))
                            {
                                deleteques.Parameters.AddWithValue("quizid", quizId);
                                deleteques.ExecuteNonQuery();
                            }
                            MessageBox.Show("Quiz Deleted Successfully");
                            loadquizzes();
                        }
                        else
                        {
                            MessageBox.Show("No such quiz found , Please check QuizId");
                        }
                    }
                    
              }
            }
            else
            {
                MessageBox.Show("Invalid QuizId entered. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
