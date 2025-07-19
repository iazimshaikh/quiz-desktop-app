namespace QuizApp
{
    partial class frmEditQuiz
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
            this.btneditquiz = new System.Windows.Forms.Button();
            this.lblqtitle = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.rdbd = new System.Windows.Forms.RadioButton();
            this.rdbc = new System.Windows.Forms.RadioButton();
            this.rdbb = new System.Windows.Forms.RadioButton();
            this.rdba = new System.Windows.Forms.RadioButton();
            this.txtopd = new System.Windows.Forms.TextBox();
            this.txtopc = new System.Windows.Forms.TextBox();
            this.txtopb = new System.Windows.Forms.TextBox();
            this.txtopa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblopa = new System.Windows.Forms.Label();
            this.txtquestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quiztitle = new System.Windows.Forms.Label();
            this.lbleditquiz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btneditquiz
            // 
            this.btneditquiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditquiz.Location = new System.Drawing.Point(416, 87);
            this.btneditquiz.Name = "btneditquiz";
            this.btneditquiz.Size = new System.Drawing.Size(140, 30);
            this.btneditquiz.TabIndex = 42;
            this.btneditquiz.Text = "Update Quiz";
            this.btneditquiz.UseVisualStyleBackColor = true;
            this.btneditquiz.Click += new System.EventHandler(this.btneditquiz_Click);
            // 
            // lblqtitle
            // 
            this.lblqtitle.AutoSize = true;
            this.lblqtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtitle.Location = new System.Drawing.Point(498, 47);
            this.lblqtitle.Name = "lblqtitle";
            this.lblqtitle.Size = new System.Drawing.Size(82, 20);
            this.lblqtitle.TabIndex = 41;
            this.lblqtitle.Text = "Quiz Title :";
            this.lblqtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(293, 519);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(34, 23);
            this.btnnext.TabIndex = 40;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(242, 519);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(34, 23);
            this.btnprevious.TabIndex = 39;
            this.btnprevious.Text = "<";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(68, 519);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(131, 23);
            this.btnadd.TabIndex = 38;
            this.btnadd.Text = "Add Question";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // rdbd
            // 
            this.rdbd.AutoSize = true;
            this.rdbd.Location = new System.Drawing.Point(160, 474);
            this.rdbd.Name = "rdbd";
            this.rdbd.Size = new System.Drawing.Size(14, 13);
            this.rdbd.TabIndex = 37;
            this.rdbd.TabStop = true;
            this.rdbd.UseVisualStyleBackColor = true;
            // 
            // rdbc
            // 
            this.rdbc.AutoSize = true;
            this.rdbc.Location = new System.Drawing.Point(160, 426);
            this.rdbc.Name = "rdbc";
            this.rdbc.Size = new System.Drawing.Size(14, 13);
            this.rdbc.TabIndex = 36;
            this.rdbc.TabStop = true;
            this.rdbc.UseVisualStyleBackColor = true;
            // 
            // rdbb
            // 
            this.rdbb.AutoSize = true;
            this.rdbb.Location = new System.Drawing.Point(160, 384);
            this.rdbb.Name = "rdbb";
            this.rdbb.Size = new System.Drawing.Size(14, 13);
            this.rdbb.TabIndex = 35;
            this.rdbb.TabStop = true;
            this.rdbb.UseVisualStyleBackColor = true;
            // 
            // rdba
            // 
            this.rdba.AutoSize = true;
            this.rdba.Location = new System.Drawing.Point(160, 344);
            this.rdba.Name = "rdba";
            this.rdba.Size = new System.Drawing.Size(14, 13);
            this.rdba.TabIndex = 34;
            this.rdba.TabStop = true;
            this.rdba.UseVisualStyleBackColor = true;
            // 
            // txtopd
            // 
            this.txtopd.Location = new System.Drawing.Point(196, 471);
            this.txtopd.Name = "txtopd";
            this.txtopd.Size = new System.Drawing.Size(241, 20);
            this.txtopd.TabIndex = 33;
            // 
            // txtopc
            // 
            this.txtopc.Location = new System.Drawing.Point(196, 423);
            this.txtopc.Name = "txtopc";
            this.txtopc.Size = new System.Drawing.Size(241, 20);
            this.txtopc.TabIndex = 32;
            // 
            // txtopb
            // 
            this.txtopb.Location = new System.Drawing.Point(196, 381);
            this.txtopb.Name = "txtopb";
            this.txtopb.Size = new System.Drawing.Size(241, 20);
            this.txtopb.TabIndex = 31;
            // 
            // txtopa
            // 
            this.txtopa.Location = new System.Drawing.Point(196, 341);
            this.txtopa.Name = "txtopa";
            this.txtopa.Size = new System.Drawing.Size(241, 20);
            this.txtopa.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Option D :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Option C :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Option B :";
            // 
            // lblopa
            // 
            this.lblopa.AutoSize = true;
            this.lblopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblopa.Location = new System.Drawing.Point(65, 339);
            this.lblopa.Name = "lblopa";
            this.lblopa.Size = new System.Drawing.Size(79, 20);
            this.lblopa.TabIndex = 26;
            this.lblopa.Text = "Option A :";
            // 
            // txtquestion
            // 
            this.txtquestion.Location = new System.Drawing.Point(68, 148);
            this.txtquestion.Multiline = true;
            this.txtquestion.Name = "txtquestion";
            this.txtquestion.Size = new System.Drawing.Size(903, 158);
            this.txtquestion.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Add Question :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quiztitle
            // 
            this.quiztitle.AutoSize = true;
            this.quiztitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiztitle.Location = new System.Drawing.Point(398, 47);
            this.quiztitle.Name = "quiztitle";
            this.quiztitle.Size = new System.Drawing.Size(82, 20);
            this.quiztitle.TabIndex = 23;
            this.quiztitle.Text = "Quiz Title :";
            this.quiztitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbleditquiz
            // 
            this.lbleditquiz.AutoSize = true;
            this.lbleditquiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleditquiz.Location = new System.Drawing.Point(435, 9);
            this.lbleditquiz.Name = "lbleditquiz";
            this.lbleditquiz.Size = new System.Drawing.Size(108, 25);
            this.lbleditquiz.TabIndex = 22;
            this.lbleditquiz.Text = "Edit Quiz";
            this.lbleditquiz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmEditQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 550);
            this.Controls.Add(this.btneditquiz);
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
            this.Controls.Add(this.lbleditquiz);
            this.Name = "frmEditQuiz";
            this.Text = "EditQuiz";
            this.Load += new System.EventHandler(this.frmEditQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneditquiz;
        private System.Windows.Forms.Label lblqtitle;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.RadioButton rdbd;
        private System.Windows.Forms.RadioButton rdbc;
        private System.Windows.Forms.RadioButton rdbb;
        private System.Windows.Forms.RadioButton rdba;
        private System.Windows.Forms.TextBox txtopd;
        private System.Windows.Forms.TextBox txtopc;
        private System.Windows.Forms.TextBox txtopb;
        private System.Windows.Forms.TextBox txtopa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblopa;
        private System.Windows.Forms.TextBox txtquestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label quiztitle;
        private System.Windows.Forms.Label lbleditquiz;
    }
}