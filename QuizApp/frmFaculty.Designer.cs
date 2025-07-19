namespace QuizApp
{
    partial class frmFaculty
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeQuizLiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnlogout = new System.Windows.Forms.Button();
            this.dgquiz = new System.Windows.Forms.DataGridView();
            this.lblyourquiz = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgquiz)).BeginInit();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(415, 38);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(82, 20);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "Welcome";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createQuizToolStripMenuItem,
            this.makeQuizLiveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createQuizToolStripMenuItem
            // 
            this.createQuizToolStripMenuItem.Name = "createQuizToolStripMenuItem";
            this.createQuizToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.createQuizToolStripMenuItem.Text = "Create Quiz";
            this.createQuizToolStripMenuItem.Click += new System.EventHandler(this.createQuizToolStripMenuItem_Click);
            // 
            // makeQuizLiveToolStripMenuItem
            // 
            this.makeQuizLiveToolStripMenuItem.Name = "makeQuizLiveToolStripMenuItem";
            this.makeQuizLiveToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.makeQuizLiveToolStripMenuItem.Text = "Delete Quiz";
            this.makeQuizLiveToolStripMenuItem.Click += new System.EventHandler(this.makeQuizLiveToolStripMenuItem_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(874, 1);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // dgquiz
            // 
            this.dgquiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgquiz.Location = new System.Drawing.Point(0, 163);
            this.dgquiz.Name = "dgquiz";
            this.dgquiz.Size = new System.Drawing.Size(957, 389);
            this.dgquiz.TabIndex = 5;
            this.dgquiz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgquiz_CellContentClick);
            // 
            // lblyourquiz
            // 
            this.lblyourquiz.AutoSize = true;
            this.lblyourquiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyourquiz.Location = new System.Drawing.Point(403, 131);
            this.lblyourquiz.Name = "lblyourquiz";
            this.lblyourquiz.Size = new System.Drawing.Size(107, 20);
            this.lblyourquiz.TabIndex = 6;
            this.lblyourquiz.Text = "Your Quizes";
            // 
            // frmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 635);
            this.Controls.Add(this.lblyourquiz);
            this.Controls.Add(this.dgquiz);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFaculty";
            this.Text = "Faculty";
            this.Load += new System.EventHandler(this.frmFaculty_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgquiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeQuizLiveToolStripMenuItem;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.DataGridView dgquiz;
        private System.Windows.Forms.Label lblyourquiz;
    }
}