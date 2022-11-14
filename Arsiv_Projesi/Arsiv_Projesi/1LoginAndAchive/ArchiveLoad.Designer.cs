namespace Arsiv_Projesi._1LoginAndAchive
{
    partial class ArchiveLoad
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
            this.Welcome = new System.Windows.Forms.Label();
            this.ArchivePictureboxArchive = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArchivePictureboxArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Welcome.ForeColor = System.Drawing.Color.Black;
            this.Welcome.Location = new System.Drawing.Point(317, 137);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(166, 32);
            this.Welcome.TabIndex = 4;
            this.Welcome.Text = "WELCOME";
            // 
            // ArchivePictureboxArchive
            // 
            this.ArchivePictureboxArchive.Image = global::Arsiv_Projesi.Properties.Resources.Archive_logo;
            this.ArchivePictureboxArchive.Location = new System.Drawing.Point(220, 172);
            this.ArchivePictureboxArchive.Name = "ArchivePictureboxArchive";
            this.ArchivePictureboxArchive.Size = new System.Drawing.Size(360, 142);
            this.ArchivePictureboxArchive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ArchivePictureboxArchive.TabIndex = 3;
            this.ArchivePictureboxArchive.TabStop = false;
            // 
            // ArchiveLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 468);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.ArchivePictureboxArchive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArchiveLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchiveLoad";
            ((System.ComponentModel.ISupportInitialize)(this.ArchivePictureboxArchive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.PictureBox ArchivePictureboxArchive;
    }
}