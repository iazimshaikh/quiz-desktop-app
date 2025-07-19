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
    public partial class frmShowresult : Form
    {
        int quizid;
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=Y:\\.Net_Projects\\QuizApp\\QuizApp.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        public frmShowresult(int quizId)
        {
       
            InitializeComponent();
            this.quizid = quizId;
        }

        private void frmShowresult_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = constr;
            conn.Open();

            string query = "SELECT qr.Studentid, s.Username, qr.Score, qr.Questions, qr.Submittime FROM Quizresult qr INNER JOIN Users s ON qr.Studentid=s.Id WHERE qr.Quizid=@quizid"; 
                           
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@quizid", quizid);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }

            dgresult.DataSource = dt;
        }
    }
}
