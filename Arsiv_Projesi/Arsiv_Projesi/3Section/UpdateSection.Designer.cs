namespace Arsiv_Projesi.Section
{
    partial class UpdateSection
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
            this.SectionComboBox = new System.Windows.Forms.ComboBox();
            this.ArchiveRoomComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateSectionTextBox = new System.Windows.Forms.TextBox();
            this.LoginPanel1 = new System.Windows.Forms.Panel();
            this.UpdateSectionButton = new System.Windows.Forms.Button();
            this.ArchiveDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SectionComboBox);
            this.panel1.Controls.Add(this.ArchiveRoomComboBox);
            this.panel1.Controls.Add(this.UpdateSectionTextBox);
            this.panel1.Controls.Add(this.LoginPanel1);
            this.panel1.Controls.Add(this.UpdateSectionButton);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 473);
            this.panel1.TabIndex = 6;
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
            // UpdateSectionTextBox
            // 
            this.UpdateSectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpdateSectionTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateSectionTextBox.ForeColor = System.Drawing.Color.Black;
            this.UpdateSectionTextBox.Location = new System.Drawing.Point(59, 122);
            this.UpdateSectionTextBox.Multiline = true;
            this.UpdateSectionTextBox.Name = "UpdateSectionTextBox";
            this.UpdateSectionTextBox.Size = new System.Drawing.Size(203, 24);
            this.UpdateSectionTextBox.TabIndex = 4;
            // 
            // LoginPanel1
            // 
            this.LoginPanel1.BackColor = System.Drawing.Color.Black;
            this.LoginPanel1.Location = new System.Drawing.Point(59, 146);
            this.LoginPanel1.Name = "LoginPanel1";
            this.LoginPanel1.Size = new System.Drawing.Size(203, 1);
            this.LoginPanel1.TabIndex = 5;
            // 
            // UpdateSectionButton
            // 
            this.UpdateSectionButton.BackColor = System.Drawing.Color.Black;
            this.UpdateSectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSectionButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateSectionButton.ForeColor = System.Drawing.Color.White;
            this.UpdateSectionButton.Location = new System.Drawing.Point(40, 402);
            this.UpdateSectionButton.Name = "UpdateSectionButton";
            this.UpdateSectionButton.Size = new System.Drawing.Size(235, 31);
            this.UpdateSectionButton.TabIndex = 3;
            this.UpdateSectionButton.Text = "UPDATE SECTION ";
            this.UpdateSectionButton.UseVisualStyleBackColor = false;
            this.UpdateSectionButton.Click += new System.EventHandler(this.UpdateSectionButton_Click);
            // 
            // ArchiveDataGridView
            // 
            this.ArchiveDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ArchiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArchiveDataGridView.Location = new System.Drawing.Point(324, 0);
            this.ArchiveDataGridView.Name = "ArchiveDataGridView";
            this.ArchiveDataGridView.Size = new System.Drawing.Size(472, 470);
            this.ArchiveDataGridView.TabIndex = 7;
            // 
            // UpdateSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 468);
            this.Controls.Add(this.ArchiveDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateSection";
            this.Load += new System.EventHandler(this.UpdateSection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox SectionComboBox;
        private System.Windows.Forms.ComboBox ArchiveRoomComboBox;
        private System.Windows.Forms.TextBox UpdateSectionTextBox;
        private System.Windows.Forms.Panel LoginPanel1;
        public System.Windows.Forms.Button UpdateSectionButton;
        private System.Windows.Forms.DataGridView ArchiveDataGridView;
    }
}