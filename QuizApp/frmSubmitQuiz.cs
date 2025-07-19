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
  
    public partial class frmSubmitQuiz : Form
    {
        int quizid;
        string curstuid;
        int currqueind=0;
        private List<Question> quelist=new List<Question>();
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=Y:\\.Net_Projects\\QuizApp\\QuizApp.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        

        public class Question
        {
            public string qid { get; set; }
            public string QuestionText { get; set; }
            public string opa { get; set; }
            public string opb { get; set; }
            public string opc { get; set; }
            public string opd { get; set; }
            public string corrop { get; set; }
            public string answer { get; set; }

        }
        public frmSubmitQuiz(int quizId,string currstuid)
        {
            this.curstuid = currstuid;
            this.quizid = quizId;
            InitializeComponent();
        }

       
        private void frmSubmitQuiz_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = constr;
            conn.Open();
            loadquizquestions(quizid);


        }
        private void loadquizquestions(int quizid)
        {
            
            string query = "SELECT * FROM Questions WHERE Quizid=@quizid";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@quizid", quizid);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Question que = new Question
                    {
                        qid = reader["Qid"].ToString(),
                        QuestionText = reader["Question"].ToString(),
                        opa = reader["Opa"].ToString(),
                        opb = reader["Opb"].ToString(),
                        opc = reader["Opc"].ToString(),
                        opd = reader["Opd"].ToString(),
                        corrop = reader["Opcorr"].ToString()
                    };
                    quelist.Add(que);

                }
            }

            dispcurrques();
        }

        private void dispcurrques()
        {
            if (currqueind >= 0 && currqueind < quelist.Count)
            {
                var currentQuestion = quelist[currqueind];

                // Update the UI elements with the current question and options
                lblques.Text = "Q."+currentQuestion.qid;
                txtques.Text = currentQuestion.QuestionText;
                rdba.Text = currentQuestion.opa;
                rdbb.Text = currentQuestion.opb;
                rdbc.Text = currentQuestion.opc;
                rdbd.Text = currentQuestion.opd;
            }
        }
       

        private void btnnext_Click_1(object sender, EventArgs e)
        {
            if (rdba.Checked) quelist[currqueind].answer = "A";
            else if (rdbb.Checked) quelist[currqueind].answer = "B";
            else if (rdbc.Checked) quelist[currqueind].answer = "C";
            else if (rdbd.Checked) quelist[currqueind].answer = "D";

            if (currqueind < quelist.Count - 1)
            {
                currqueind++;
                dispcurrques();
            }
            else
            {
                MessageBox.Show("No Next Questions..");
            }
        }

        private void displayscore()
        {
            int score = 0;
            foreach(var ques in quelist)
            {
                if (ques.answer == ques.corrop)
                {
                    score++;
                }
            }
            MessageBox.Show($"Quiz Completed. You score {score} out of {quelist.Count}");
            saveresult(score);
        }

        private void saveresult(int score)
        {
            string query = "INSERT INTO Quizresult (Studentid,Quizid,Score,Questions,Submittime) VALUES (@stuid,@quizid,@sc,@ques,@subt)";
            int curstid = Convert.ToInt32(curstuid);
            using(SqlCommand cmd=new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@stuid", curstid);
                cmd.Parameters.AddWithValue("@quizid",quizid);
                cmd.Parameters.AddWithValue("@sc",score);
                cmd.Parameters.AddWithValue("@ques",quelist.Count);
                cmd.Parameters.AddWithValue("@subt",DateTime.Now);

                cmd.ExecuteNonQuery();

            }
        }

        private void submitquiz_Click(object sender, EventArgs e)
        {
            displayscore();
            conn.Close();
            this.Close();

        }
    }
}
