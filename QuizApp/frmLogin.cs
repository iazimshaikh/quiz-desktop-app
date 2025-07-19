using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuizApp
{
    public partial class frmLogin : Form
    {
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=Y:\\.Net_Projects\\QuizApp\\QuizApp.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
      
        }

        private void btnlogin_Click(object sender, EventArgs e)

        {
            conn.ConnectionString = constr;
            conn.Open();
            string usname = txtuname.Text;
            string pass = txtpass.Text;

            if (ValidateLogin(usname, pass)) 
            {

                string qry = "SELECT Role from Users WHERE Username=@usname AND Password=@pass";
                using (SqlCommand cmd = new SqlCommand(qry, conn))
                {
                    cmd.Parameters.AddWithValue("@usname", usname);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    string role = cmd.ExecuteScalar().ToString();

                    if (role.Contains("faculty") || role.Contains("student"))
                    {
                        if (role == "faculty")
                        {
                            frmFaculty frmFac = new frmFaculty(usname);
                            frmFac.Show();
                            this.Hide();
                        }
                        else if (role == "student")
                        {
                            frmStudent frmstu = new frmStudent(usname);
                            frmstu.Show();
                            this.Hide();
                        }
                    }

                }

            }
            else

            {
                MessageBox.Show("Invalid Username OR Password");
            }
            conn.Close();
            

           
        }

        private bool ValidateLogin(string username, string password)
        {
            // Database connection and login validation logic

            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0; // Return true if user is found
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    

