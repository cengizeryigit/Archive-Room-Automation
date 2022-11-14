namespace Arsiv_Projesi._5Folder
{
    partial class SearchFolder
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
            this.FolderComboBox = new System.Windows.Forms.ComboBox();
            this.ShelfComboBox = new System.Windows.Forms.ComboBox();
            this.SectionComboBox = new System.Windows.Forms.ComboBox();
            this.ArchiveRoomComboBox = new System.Windows.Forms.ComboBox();
            this.SearchFolderTextBox = new System.Windows.Forms.TextBox();
            this.LoginPanel1 = new System.Windows.Forms.Panel();
            this.SearchFolderButton = new System.Windows.Forms.Button();
            this.ArchiveDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.FolderComboBox);
            this.panel1.Controls.Add(this.ShelfComboBox);
            this.panel1.Controls.Add(this.SectionComboBox);
            this.panel1.Controls.Add(this.ArchiveRoomComboBox);
            this.panel1.Controls.Add(this.SearchFolderTextBox);
            this.panel1.Controls.Add(this.LoginPanel1);
            this.panel1.Controls.Add(this.SearchFolderButton);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 473);
            this.panel1.TabIndex = 17;
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
            // SearchFolderTextBox
            // 
            this.SearchFolderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchFolderTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchFolderTextBox.ForeColor = System.Drawing.Color.Black;
            this.SearchFolderTextBox.Location = new System.Drawing.Point(59, 202);
            this.SearchFolderTextBox.Multiline = true;
            this.SearchFolderTextBox.Name = "SearchFolderTextBox";
            this.SearchFolderTextBox.Size = new System.Drawing.Size(203, 24);
            this.SearchFolderTextBox.TabIndex = 4;
            // 
            // LoginPanel1
            // 
            this.LoginPanel1.BackColor = System.Drawing.Color.Black;
            this.LoginPanel1.Location = new System.Drawing.Point(59, 226);
            this.LoginPanel1.Name = "LoginPanel1";
            this.LoginPanel1.Size = new System.Drawing.Size(203, 1);
            this.LoginPanel1.TabIndex = 5;
            // 
            // SearchFolderButton
            // 
            this.SearchFolderButton.BackColor = System.Drawing.Color.Black;
            this.SearchFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchFolderButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchFolderButton.ForeColor = System.Drawing.Color.White;
            this.SearchFolderButton.Location = new System.Drawing.Point(40, 402);
            this.SearchFolderButton.Name = "SearchFolderButton";
            this.SearchFolderButton.Size = new System.Drawing.Size(235, 31);
            this.SearchFolderButton.TabIndex = 3;
            this.SearchFolderButton.Text = "SEARCH FOLDER ";
            this.SearchFolderButton.UseVisualStyleBackColor = false;
            this.SearchFolderButton.Click += new System.EventHandler(this.SearchFolderButton_Click);
            // 
            // ArchiveDataGridView
            // 
            this.ArchiveDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ArchiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArchiveDataGridView.Location = new System.Drawing.Point(324, 0);
            this.ArchiveDataGridView.Name = "ArchiveDataGridView";
            this.ArchiveDataGridView.Size = new System.Drawing.Size(472, 470);
            this.ArchiveDataGridView.TabIndex = 18;
            // 
            // SearchFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 468);
            this.Controls.Add(this.ArchiveDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchFolder";
            this.Load += new System.EventHandler(this.SearchFolder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox FolderComboBox;
        private System.Windows.Forms.ComboBox ShelfComboBox;
        private System.Windows.Forms.ComboBox SectionComboBox;
        private System.Windows.Forms.ComboBox ArchiveRoomComboBox;
        private System.Windows.Forms.TextBox SearchFolderTextBox;
        private System.Windows.Forms.Panel LoginPanel1;
        public System.Windows.Forms.Button SearchFolderButton;
        private System.Windows.Forms.DataGridView ArchiveDataGridView;
    }
}