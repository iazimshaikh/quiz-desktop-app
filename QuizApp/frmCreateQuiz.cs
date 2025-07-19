using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class frmCreateQuiz : Form
    {
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=Y:\\.Net_Projects\\QuizApp\\QuizApp.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        int quizId;
        private string creator;
        public frmCreateQuiz(string usname)
        {
            InitializeComponent();
            this.creator = usname;
 

        }
        private void loadquestions(int quizid)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCreateQuiz_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = constr;
            conn.Open();
            string quiztitle = Microsoft.VisualBasic.Interaction.InputBox("Enter Quiz title:");
            if (string.IsNullOrEmpty(quiztitle))
            {
                MessageBox.Show("Quiz title cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            lblqtitle.Text = quiztitle;
            quizId = SaveQuizToDatabase(quiztitle, creator);

        }
        private int SaveQuizToDatabase(string quizTitle, string creator)
        {
            string query = "INSERT INTO Quizzes (Title, Creator) VALUES (@Title, @Creator); SELECT SCOPE_IDENTITY();";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Title", quizTitle);
                cmd.Parameters.AddWithValue("@Creator", creator);

                int quizId = Convert.ToInt32(cmd.ExecuteScalar());
                return quizId;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string question = txtquestion.Text;
            string opa = txtopa.Text;
            string opb = txtopb.Text;
            string opc = txtopc.Text;
            string opd = txtopd.Text;

            string opcorr = "";

            if (rdba.Checked) opcorr = "A";
            else if (rdbb.Checked) opcorr = "B";
            else if (rdbc.Checked) opcorr = "C";
            else if (rdbd.Checked) opcorr = "D";

            if (string.IsNullOrEmpty(question) || string.IsNullOrEmpty(opa) || string.IsNullOrEmpty(opb) ||
               string.IsNullOrEmpty(opc) || string.IsNullOrEmpty(opd) || string.IsNullOrEmpty(opcorr)
               )
            {
                MessageBox.Show("Write options and select the correct option");
            }

            string query = "INSERT INTO Questions (Quizid, Question, Opa, Opb, Opc, Opd, Opcorr) " +
                              "VALUES (@QuizId, @QuestionText, @OptionA, @OptionB, @OptionC, @OptionD, @CorrectOption)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@QuizId",quizId);  // Assuming currentQuizId is the ID of the quiz you're creating
                cmd.Parameters.AddWithValue("@QuestionText", question);
                cmd.Parameters.AddWithValue("@OptionA", opa);
                cmd.Parameters.AddWithValue("@OptionB", opb);
                cmd.Parameters.AddWithValue("@OptionC", opc);
                cmd.Parameters.AddWithValue("@OptionD", opd);
                cmd.Parameters.AddWithValue("@CorrectOption", opcorr);

                cmd.ExecuteNonQuery();

            }
            txtquestion.Clear();
            txtopa.Clear();
            txtopb.Clear();
            txtopc.Clear();
            txtopd.Clear();
        }

        private void btnsavequiz_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }
    }
}
