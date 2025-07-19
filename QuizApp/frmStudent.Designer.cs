namespace QuizApp
{
    partial class frmStudent
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
            this.lblwelcome = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.dgquiz = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgquiz)).BeginInit();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(330, 19);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(65, 16);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "Welcome";
            this.lblwelcome.Click += new System.EventHandler(this.lblwelcome_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(713, 12);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 1;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // dgquiz
            // 
            this.dgquiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgquiz.Location = new System.Drawing.Point(1, 86);
            this.dgquiz.Name = "dgquiz";
            this.dgquiz.Size = new System.Drawing.Size(799, 362);
            this.dgquiz.TabIndex = 2;
            this.dgquiz.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgquiz_CellClick);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgquiz);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.lblwelcome);
            this.Name = "frmStudent";
            this.Text = " Student";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.Shown += new System.EventHandler(this.frmStudent_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgquiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.DataGridView dgquiz;
    }
}