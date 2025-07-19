using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class frmStudent : Form
    {
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=Y:\\.Net_Projects\\QuizApp\\QuizApp.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        string currusname;
        string curstuid;
        public frmStudent(string usname)
        {
            InitializeComponent();
            this.currusname=usname;
/*            lblwelcome.Text="Welcome "+curstuid;
*/      }

        private void lblwelcome_Click(object sender, EventArgs e)
        {
            
            
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = constr;
            conn.Open();
            string getstuid = "SELECT Id FROM Users WHERE Username=@usname";
            using(SqlCommand cmd=new SqlCommand(getstuid, conn))
            {
                cmd.Parameters.AddWithValue("@usname", currusname);
                string stuid = cmd.ExecuteScalar().ToString();
                this.curstuid = stuid;
            }
            lblwelcome.Text = "Welcome " + currusname;

            /*DataGridViewButtonColumn btngivequiz = new DataGridViewButtonColumn();
            btngivequiz.HeaderText = "Give Quiz";
            btngivequiz.Name = "givequiz";
            btngivequiz.Text = "Give Quiz";
            dgquiz.Columns.Add(btngivequiz);*/

            DataTable tbl = new DataTable();
            string query = "SELECT Quizid,Title,Creator,Date from Quizzes WHERE Live=1";
            using(SqlCommand cmd=new SqlCommand(query, conn))
            {
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(tbl);

            }
            dgquiz.DataSource = tbl;

            DataGridViewButtonColumn btngivequiz = new DataGridViewButtonColumn();
            btngivequiz.HeaderText = "Give Quiz";
            btngivequiz.Name = "givequiz";
            btngivequiz.Text = "Give Quiz";
            btngivequiz.UseColumnTextForButtonValue = true;  
            dgquiz.Columns.Add(btngivequiz);

        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
            frmLogin frmlog = new frmLogin();
            frmlog.Show();
        }

        private void dgquiz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgquiz.Columns["givequiz"].Index && e.RowIndex >= 0)
            {
                int quizid = Convert.ToInt32(dgquiz.Rows[e.RowIndex].Cells["Quizid"].Value);
                frmSubmitQuiz frmsubquiz = new frmSubmitQuiz(quizid,curstuid);
                frmsubquiz.Show();
            }
        }

        private void frmStudent_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Right now , only quiz 'my_f1' contains questions");
        }
    }
}
