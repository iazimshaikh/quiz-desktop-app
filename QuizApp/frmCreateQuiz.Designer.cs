namespace QuizApp
{
    partial class frmCreateQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.quiztitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtquestion = new System.Windows.Forms.TextBox();
            this.lblopa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtopa = new System.Windows.Forms.TextBox();
            this.txtopb = new System.Windows.Forms.TextBox();
            this.txtopc = new System.Windows.Forms.TextBox();
            this.txtopd = new System.Windows.Forms.TextBox();
            this.rdba = new System.Windows.Forms.RadioButton();
            this.rdbb = new System.Windows.Forms.RadioButton();
            this.rdbc = new System.Windows.Forms.RadioButton();
            this.rdbd = new System.Windows.Forms.RadioButton();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.lblqtitle = new System.Windows.Forms.Label();
            this.btnsavequiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New Quiz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // quiztitle
            // 
            this.quiztitle.AutoSize = true;
            this.quiztitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiztitle.Location = new System.Drawing.Point(365, 68);
            this.quiztitle.Name = "quiztitle";
            this.quiztitle.Size = new System.Drawing.Size(82, 20);
            this.quiztitle.TabIndex = 1;
            this.quiztitle.Text = "Quiz Title :";
            this.quiztitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Question :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtquestion
            // 
            this.txtquestion.Location = new System.Drawing.Point(35, 169);
            this.txtquestion.Multiline = true;
            this.txtquestion.Name = "txtquestion";
            this.txtquestion.Size = new System.Drawing.Size(903, 158);
            this.txtquestion.TabIndex = 4;
            // 
            // lblopa
            // 
            this.lblopa.AutoSize = true;
            this.lblopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblopa.Location = new System.Drawing.Point(32, 360);
            this.lblopa.Name = "lblopa";
            this.lblopa.Size = new System.Drawing.Size(79, 20);
            this.lblopa.TabIndex = 5;
            this.lblopa.Text = "Option A :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Option B :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Option C :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Option D :";
            // 
            // txtopa
            // 
            this.txtopa.Location = new System.Drawing.Point(163, 362);
            this.txtopa.Name = "txtopa";
            this.txtopa.Size = new System.Drawing.Size(241, 20);
            this.txtopa.TabIndex = 9;
            // 
            // txtopb
            // 
            this.txtopb.Location = new System.Drawing.Point(163, 402);
            this.txtopb.Name = "txtopb";
            this.txtopb.Size = new System.Drawing.Size(241, 20);
            this.txtopb.TabIndex = 10;
            // 
            // txtopc
            // 
            this.txtopc.Location = new System.Drawing.Point(163, 444);
            this.txtopc.Name = "txtopc";
            this.txtopc.Size = new System.Drawing.Size(241, 20);
            this.txtopc.TabIndex = 11;
            // 
            // txtopd
            // 
            this.txtopd.Location = new System.Drawing.Point(163, 492);
            this.txtopd.Name = "txtopd";
            this.txtopd.Size = new System.Drawing.Size(241, 20);
            this.txtopd.TabIndex = 12;
            // 
            // rdba
            // 
            this.rdba.AutoSize = true;
            this.rdba.Location = new System.Drawing.Point(127, 365);
            this.rdba.Name = "rdba";
            this.rdba.Size = new System.Drawing.Size(14, 13);
            this.rdba.TabIndex = 13;
            this.rdba.TabStop = true;
            this.rdba.UseVisualStyleBackColor = true;
            // 
            // rdbb
            // 
            this.rdbb.AutoSize = true;
            this.rdbb.Location = new System.Drawing.Point(127, 405);
            this.rdbb.Name = "rdbb";
            this.rdbb.Size = new System.Drawing.Size(14, 13);
            this.rdbb.TabIndex = 14;
            this.rdbb.TabStop = true;
            this.rdbb.UseVisualStyleBackColor = true;
            // 
            // rdbc
            // 
            this.rdbc.AutoSize = true;
            this.rdbc.Location = new System.Drawing.Point(127, 447);
            this.rdbc.Name = "rdbc";
            this.rdbc.Size = new System.Drawing.Size(14, 13);
            this.rdbc.TabIndex = 15;
            this.rdbc.TabStop = true;
            this.rdbc.UseVisualStyleBackColor = true;
            // 
            // rdbd
            // 
            this.rdbd.AutoSize = true;
            this.rdbd.Location = new System.Drawing.Point(127, 495);
            this.rdbd.Name = "rdbd";
            this.rdbd.Size = new System.Drawing.Size(14, 13);
            this.rdbd.TabIndex = 16;
            this.rdbd.TabStop = true;
            this.rdbd.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(35, 540);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(131, 23);
            this.btnadd.TabIndex = 17;
            this.btnadd.Text = "Add Question";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(209, 540);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(34, 23);
            this.btnprevious.TabIndex = 18;
            this.btnprevious.Text = "<";
            this.btnprevious.UseVisualStyleBackColor = true;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(260, 540);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(34, 23);
            this.btnnext.TabIndex = 19;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            // 
            // lblqtitle
            // 
            this.lblqtitle.AutoSize = true;
            this.lblqtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtitle.Location = new System.Drawing.Point(465, 68);
            this.lblqtitle.Name = "lblqtitle";
            this.lblqtitle.Size = new System.Drawing.Size(82, 20);
            this.lblqtitle.TabIndex = 20;
            this.lblqtitle.Text = "Quiz Title :";
            this.lblqtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnsavequiz
            // 
            this.btnsavequiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavequiz.Location = new System.Drawing.Point(383, 108);
            this.btnsavequiz.Name = "btnsavequiz";
            this.btnsavequiz.Size = new System.Drawing.Size(140, 30);
            this.btnsavequiz.TabIndex = 21;
            this.btnsavequiz.Text = "Save Quiz";
            this.btnsavequiz.UseVisualStyleBackColor = true;
            this.btnsavequiz.Click += new System.EventHandler(this.btnsavequiz_Click);
            // 
            // frmCreateQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 575);
            this.Controls.Add(this.btnsavequiz);
            this.Controls.Add(this.lblqtitle);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.rdbd);
            this.Controls.Add(this.rdbc);
            this.Controls.Add(this.rdbb);
            this.Controls.Add(this.rdba);
            this.Controls.Add(this.txtopd);
            this.Controls.Add(this.txtopc);
            this.Controls.Add(this.txtopb);
            this.Controls.Add(this.txtopa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblopa);
            this.Controls.Add(this.txtquestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quiztitle);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateQuiz";
            this.Text = "CreateQuiz";
            this.Load += new System.EventHandler(this.frmCreateQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quiztitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtquestion;
        private System.Windows.Forms.Label lblopa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtopa;
        private System.Windows.Forms.TextBox txtopb;
        private System.Windows.Forms.TextBox txtopc;
        private System.Windows.Forms.TextBox txtopd;
        private System.Windows.Forms.RadioButton rdba;
        private System.Windows.Forms.RadioButton rdbb;
        private System.Windows.Forms.RadioButton rdbc;
        private System.Windows.Forms.RadioButton rdbd;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label lblqtitle;
        private System.Windows.Forms.Button btnsavequiz;
    }
}