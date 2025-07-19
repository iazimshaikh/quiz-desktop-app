namespace QuizApp
{
    partial class frmShowresult
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
            this.dgresult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgresult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgresult
            // 
            this.dgresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgresult.Location = new System.Drawing.Point(1, 42);
            this.dgresult.Name = "dgresult";
            this.dgresult.Size = new System.Drawing.Size(798, 404);
            this.dgresult.TabIndex = 0;
            // 
            // frmShowresult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgresult);
            this.Name = "frmShowresult";
            this.Text = "Showresult";
            this.Load += new System.EventHandler(this.frmShowresult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgresult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgresult;
    }
}