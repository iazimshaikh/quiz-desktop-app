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

    public partial class frmEditQuiz : Form
    {
        public class Question
        {
            public string QuestionText { get; set; }
            public string OptionA { get; set; }
            public string OptionB { get; set; }
            public string OptionC { get; set; }
            public string OptionD { get; set; }
            public string CorrectOption { get; set; }
        }

        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=Y:\\.Net_Projects\\QuizApp\\QuizApp.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        int quizId;
        private List<Question> questionlist;
        private int currqueindex = 0;
        public frmEditQuiz(int quizid)
        {
            InitializeComponent();
            this.quizId = quizid;
        }

        private void frmEditQuiz_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = constr;
            conn.Open();
            /*loadquizzes(quizId);*/
            LoadQuizQuestions(quizId);
        }
        private void LoadQuizQuestions(int quizid)
        {
            string query = "SELECT * FROM Questions WHERE Quizid=@Quizid";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Quizid", quizid);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    questionlist = new List<Question>();
                    while (reader.Read())
                    {
                        Question question = new Question
                        {
                            QuestionText = reader["Question"].ToString(),
                            OptionA = reader["Opa"].ToString(),
                            OptionB = reader["Opb"].ToString(),
                            OptionC = reader["Opc"].ToString(),
                            OptionD = reader["Opd"].ToString(),
                            CorrectOption = reader["Opcorr"].ToString()
                        };
                        questionlist.Add(question);
                    }
                }
            }
            if (questionlist.Count > 0)
            {
                DisplayQuestion(currqueindex);
            }

        }

        private void loadquizzes(int quizid)
        {

            string query = "SELECT TOP 1 * FROM Questions WHERE Quizid = @QuizId ORDER BY Qid DESC";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@QuizId", quizid);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtquestion.Text = reader["Question"].ToString();
                        txtopa.Text = reader["Opa"].ToString();
                        txtopb.Text = reader["Opb"].ToString();
                        txtopc.Text = reader["Opc"].ToString();
                        txtopd.Text = reader["Opd"].ToString();

                        string correctOption = reader["Opcorr"].ToString();
                        if (correctOption == "A") rdba.Checked = true;
                        else if (correctOption == "B") rdbb.Checked = true;
                        else if (correctOption == "C") rdbc.Checked = true;
                        else if (correctOption == "D") rdbd.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("No questions found for this quiz. You can start adding new questions.");
                    }
                }
            }
        }
        private void DisplayQuestion(int index)
        {
            if (index >= 0 && index < questionlist.Count)
            {
                Question question = questionlist[index];
                txtquestion.Text = question.QuestionText;
                txtopa.Text = question.OptionA;
                txtopb.Text = question.OptionB;
                txtopc.Text = question.OptionC;
                txtopd.Text = question.OptionD;

                // Check the correct option radio button
                if (question.CorrectOption == "A")
                    rdba.Checked = true;
                else if (question.CorrectOption == "B")
                    rdbb.Checked = true;
                else if (question.CorrectOption == "C")
                    rdbc.Checked = true;
                else if (question.CorrectOption == "D")
                    rdbd.Checked = true;
            }
        }
        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (currqueindex > 0)
            {
                currqueindex--;  // Decrease the index
                DisplayQuestion(currqueindex);  // Display the previous question
            }
            else
            {
                MessageBox.Show("This is the first question.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnnext_Click(object sender, EventArgs e)
        {
            if (currqueindex < questionlist.Count - 1) 
            {
                currqueindex++;  // Increase the index
                DisplayQuestion(currqueindex);  // Display the next question
            }
            else
            {
                MessageBox.Show("This is the last question.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (btnadd.Text.Equals("Add Question"))
            {
                btnadd.Text = "Add";

                txtquestion.Clear();
                txtopa.Clear();
                txtopb.Clear();
                txtopc.Clear();
                txtopd.Clear();
            }
            else if (btnadd.Text.Equals("Add"))
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
                    cmd.Parameters.AddWithValue("@QuizId", quizId);  // Assuming currentQuizId is the ID of the quiz you're creating
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

                btnadd.Text = "Add Question";
                LoadQuizQuestions(quizId);




            }
        }

        private void btneditquiz_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }
    }
}
