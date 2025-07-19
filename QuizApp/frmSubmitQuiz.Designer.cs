namespace QuizApp
{
    partial class frmSubmitQuiz
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
            this.rdbd = new System.Windows.Forms.RadioButton();
            this.rdbc = new System.Windows.Forms.RadioButton();
            this.rdbb = new System.Windows.Forms.RadioButton();
            this.rdba = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblopa = new System.Windows.Forms.Label();
            this.lblques = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.txtques = new System.Windows.Forms.TextBox();
            this.submitquiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbd
            // 
            this.rdbd.AutoSize = true;
            this.rdbd.Location = new System.Drawing.Point(139, 455);
            this.rdbd.Name = "rdbd";
            this.rdbd.Size = new System.Drawing.Size(14, 13);
            this.rdbd.TabIndex = 29;
            this.rdbd.TabStop = true;
            this.rdbd.UseVisualStyleBackColor = true;
            // 
            // rdbc
            // 
            this.rdbc.AutoSize = true;
            this.rdbc.Location = new System.Drawing.Point(139, 407);
            this.rdbc.Name = "rdbc";
            this.rdbc.Size = new System.Drawing.Size(14, 13);
            this.rdbc.TabIndex = 28;
            this.rdbc.TabStop = true;
            this.rdbc.UseVisualStyleBackColor = true;
            // 
            // rdbb
            // 
            this.rdbb.AutoSize = true;
            this.rdbb.Location = new System.Drawing.Point(139, 365);
            this.rdbb.Name = "rdbb";
            this.rdbb.Size = new System.Drawing.Size(14, 13);
            this.rdbb.TabIndex = 27;
            this.rdbb.TabStop = true;
            this.rdbb.UseVisualStyleBackColor = true;
            // 
            // rdba
            // 
            this.rdba.AutoSize = true;
            this.rdba.Location = new System.Drawing.Point(139, 325);
            this.rdba.Name = "rdba";
            this.rdba.Size = new System.Drawing.Size(14, 13);
            this.rdba.TabIndex = 26;
            this.rdba.TabStop = true;
            this.rdba.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Option D :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Option C :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Option B :";
            // 
            // lblopa
            // 
            this.lblopa.AutoSize = true;
            this.lblopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblopa.Location = new System.Drawing.Point(44, 320);
            this.lblopa.Name = "lblopa";
            this.lblopa.Size = new System.Drawing.Size(79, 20);
            this.lblopa.TabIndex = 18;
            this.lblopa.Text = "Option A :";
            // 
            // lblques
            // 
            this.lblques.AutoSize = true;
            this.lblques.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblques.Location = new System.Drawing.Point(43, 106);
            this.lblques.Name = "lblques";
            this.lblques.Size = new System.Drawing.Size(81, 20);
            this.lblques.TabIndex = 30;
            this.lblques.Text = "Question :";
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(48, 539);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 31;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click_1);
            // 
            // txtques
            // 
            this.txtques.Location = new System.Drawing.Point(47, 143);
            this.txtques.Multiline = true;
            this.txtques.Name = "txtques";
            this.txtques.Size = new System.Drawing.Size(896, 129);
            this.txtques.TabIndex = 32;
            // 
            // submitquiz
            // 
            this.submitquiz.Location = new System.Drawing.Point(186, 539);
            this.submitquiz.Name = "submitquiz";
            this.submitquiz.Size = new System.Drawing.Size(75, 23);
            this.submitquiz.TabIndex = 33;
            this.submitquiz.Text = "Submit";
            this.submitquiz.UseVisualStyleBackColor = true;
            this.submitquiz.Click += new System.EventHandler(this.submitquiz_Click);
            // 
            // frmSubmitQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 600);
            this.Controls.Add(this.submitquiz);
            this.Controls.Add(this.txtques);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.lblques);
            this.Controls.Add(this.rdbd);
            this.Controls.Add(this.rdbc);
            this.Controls.Add(this.rdbb);
            this.Controls.Add(this.rdba);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblopa);
            this.Name = "frmSubmitQuiz";
            this.Text = "SubmitQuiz";
            this.Load += new System.EventHandler(this.frmSubmitQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbd;
        private System.Windows.Forms.RadioButton rdbc;
        private System.Windows.Forms.RadioButton rdbb;
        private System.Windows.Forms.RadioButton rdba;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblopa;
        private System.Windows.Forms.Label lblques;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.TextBox txtques;
        private System.Windows.Forms.Button submitquiz;
    }
}