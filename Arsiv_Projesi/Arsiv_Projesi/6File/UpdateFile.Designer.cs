namespace Arsiv_Projesi._6File
{
    partial class UpdateFile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FileComboBox = new System.Windows.Forms.ComboBox();
            this.FolderComboBox = new System.Windows.Forms.ComboBox();
            this.ShelfComboBox = new System.Windows.Forms.ComboBox();
            this.SectionComboBox = new System.Windows.Forms.ComboBox();
            this.ArchiveRoomComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateFileTextBox = new System.Windows.Forms.TextBox();
            this.LoginPanel1 = new System.Windows.Forms.Panel();
            this.UpdateFileButton = new System.Windows.Forms.Button();
            this.ArchiveDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.FileComboBox);
            this.panel1.Controls.Add(this.FolderComboBox);
            this.panel1.Controls.Add(this.ShelfComboBox);
            this.panel1.Controls.Add(this.SectionComboBox);
            this.panel1.Controls.Add(this.ArchiveRoomComboBox);
            this.panel1.Controls.Add(this.UpdateFileTextBox);
            this.panel1.Controls.Add(this.LoginPanel1);
            this.panel1.Controls.Add(this.UpdateFileButton);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 473);
            this.panel1.TabIndex = 23;
            // 
            // FileComboBox
            // 
            this.FileComboBox.BackColor = System.Drawing.Color.White;
            this.FileComboBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileComboBox.FormattingEnabled = true;
            this.FileComboBox.Location = new System.Drawing.Point(59, 186);
            this.FileComboBox.Name = "FileComboBox";
            this.FileComboBox.Size = new System.Drawing.Size(203, 26);
            this.FileComboBox.TabIndex = 6;
            // 
            // FolderComboBox
            // 
            this.FolderComboBox.BackColor = System.Drawing.Color.White;
            this.FolderComboBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderComboBox.FormattingEnabled = true;
            this.FolderComboBox.Location = new System.Drawing.Point(59, 146);
            this.FolderComboBox.Name = "FolderComboBox";
            this.FolderComboBox.Size = new System.Drawing.Size(203, 26);
            this.FolderComboBox.TabIndex = 6;
            this.FolderComboBox.SelectedIndexChanged += new System.EventHandler(this.FolderComboBox_SelectedIndexChanged);
            // 
            // ShelfComboBox
            // 
            this.ShelfComboBox.BackColor = System.Drawing.Color.White;
            this.ShelfComboBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShelfComboBox.FormattingEnabled = true;
            this.ShelfComboBox.Location = new System.Drawing.Point(59, 106);
            this.ShelfComboBox.Name = "ShelfComboBox";
            this.ShelfComboBox.Size = new System.Drawing.Size(203, 26);
            this.ShelfComboBox.TabIndex = 6;
            this.ShelfComboBox.SelectedIndexChanged += new System.EventHandler(this.ShelfComboBox_SelectedIndexChanged);
            // 
            // SectionComboBox
            // 
            this.SectionComboBox.BackColor = System.Drawing.Color.White;
            this.SectionComboBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionComboBox.FormattingEnabled = true;
            this.SectionComboBox.Location = new System.Drawing.Point(59, 66);
            this.SectionComboBox.Name = "SectionComboBox";
            this.SectionComboBox.Size = new System.Drawing.Size(203, 26);
            this.SectionComboBox.TabIndex = 6;
            this.SectionComboBox.SelectedIndexChanged += new System.EventHandler(this.SectionComboBox_SelectedIndexChanged);
            // 
            // ArchiveRoomComboBox
            // 
            this.ArchiveRoomComboBox.BackColor = System.Drawing.Color.White;
            this.ArchiveRoomComboBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchiveRoomComboBox.FormattingEnabled = true;
            this.ArchiveRoomComboBox.Location = new System.Drawing.Point(59, 26);
            this.ArchiveRoomComboBox.Name = "ArchiveRoomComboBox";
            this.ArchiveRoomComboBox.Size = new System.Drawing.Size(203, 26);
            this.ArchiveRoomComboBox.TabIndex = 6;
            this.ArchiveRoomComboBox.SelectedIndexChanged += new System.EventHandler(this.ArchiveRoomComboBox_SelectedIndexChanged);
            // 
            // UpdateFileTextBox
            // 
            this.UpdateFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpdateFileTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateFileTextBox.ForeColor = System.Drawing.Color.Black;
            this.UpdateFileTextBox.Location = new System.Drawing.Point(59, 242);
            this.UpdateFileTextBox.Multiline = true;
            this.UpdateFileTextBox.Name = "UpdateFileTextBox";
            this.UpdateFileTextBox.Size = new System.Drawing.Size(203, 24);
            this.UpdateFileTextBox.TabIndex = 4;
            // 
            // LoginPanel1
            // 
            this.LoginPanel1.BackColor = System.Drawing.Color.Black;
            this.LoginPanel1.Location = new System.Drawing.Point(59, 266);
            this.LoginPanel1.Name = "LoginPanel1";
            this.LoginPanel1.Size = new System.Drawing.Size(203, 1);
            this.LoginPanel1.TabIndex = 5;
            // 
            // UpdateFileButton
            // 
            this.UpdateFileButton.BackColor = System.Drawing.Color.Black;
            this.UpdateFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateFileButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateFileButton.ForeColor = System.Drawing.Color.White;
            this.UpdateFileButton.Location = new System.Drawing.Point(40, 402);
            this.UpdateFileButton.Name = "UpdateFileButton";
            this.UpdateFileButton.Size = new System.Drawing.Size(235, 31);
            this.UpdateFileButton.TabIndex = 3;
            this.UpdateFileButton.Text = "UPDATE FILE ";
            this.UpdateFileButton.UseVisualStyleBackColor = false;
            this.UpdateFileButton.Click += new System.EventHandler(this.UpdateFileButton_Click);
            // 
            // ArchiveDataGridView
            // 
            this.ArchiveDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ArchiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArchiveDataGridView.Location = new System.Drawing.Point(324, 0);
            this.ArchiveDataGridView.Name = "ArchiveDataGridView";
            this.ArchiveDataGridView.Size = new System.Drawing.Size(472, 470);
            this.ArchiveDataGridView.TabIndex = 24;
            // 
            // UpdateFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 468);
            this.Controls.Add(this.ArchiveDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateFile";
            this.Load += new System.EventHandler(this.UpdateFile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox FileComboBox;
        private System.Windows.Forms.ComboBox FolderComboBox;
        private System.Windows.Forms.ComboBox ShelfComboBox;
        private System.Windows.Forms.ComboBox SectionComboBox;
        private System.Windows.Forms.ComboBox ArchiveRoomComboBox;
        private System.Windows.Forms.TextBox UpdateFileTextBox;
        private System.Windows.Forms.Panel LoginPanel1;
        public System.Windows.Forms.Button UpdateFileButton;
        private System.Windows.Forms.DataGridView ArchiveDataGridView;
    }
}