namespace Arsiv_Projesi.ArchiveRoom
{
     partial class ListArchiveRoom 
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
            this.ArchiveRoomComboBox = new System.Windows.Forms.ComboBox();
            this.ListArchiveTextBox = new System.Windows.Forms.TextBox();
            this.LoginPanel1 = new System.Windows.Forms.Panel();
            this.ListArchiveRoomButton = new System.Windows.Forms.Button();
            this.ArchiveDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ArchiveRoomComboBox);
            this.panel1.Controls.Add(this.ListArchiveTextBox);
            this.panel1.Controls.Add(this.LoginPanel1);
            this.panel1.Controls.Add(this.ListArchiveRoomButton);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 473);
            this.panel1.TabIndex = 2;
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
            // 
            // ListArchiveTextBox
            // 
            this.ListArchiveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListArchiveTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListArchiveTextBox.ForeColor = System.Drawing.Color.Black;
            this.ListArchiveTextBox.Location = new System.Drawing.Point(59, 82);
            this.ListArchiveTextBox.Multiline = true;
            this.ListArchiveTextBox.Name = "ListArchiveTextBox";
            this.ListArchiveTextBox.Size = new System.Drawing.Size(203, 24);
            this.ListArchiveTextBox.TabIndex = 4;
            // 
            // LoginPanel1
            // 
            this.LoginPanel1.BackColor = System.Drawing.Color.Black;
            this.LoginPanel1.Location = new System.Drawing.Point(59, 106);
            this.LoginPanel1.Name = "LoginPanel1";
            this.LoginPanel1.Size = new System.Drawing.Size(203, 1);
            this.LoginPanel1.TabIndex = 5;
            // 
            // ListArchiveRoomButton
            // 
            this.ListArchiveRoomButton.BackColor = System.Drawing.Color.Black;
            this.ListArchiveRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListArchiveRoomButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListArchiveRoomButton.ForeColor = System.Drawing.Color.White;
            this.ListArchiveRoomButton.Location = new System.Drawing.Point(40, 402);
            this.ListArchiveRoomButton.Name = "ListArchiveRoomButton";
            this.ListArchiveRoomButton.Size = new System.Drawing.Size(235, 31);
            this.ListArchiveRoomButton.TabIndex = 3;
            this.ListArchiveRoomButton.Text = "LIST ARCHIVE ROOM";
            this.ListArchiveRoomButton.UseVisualStyleBackColor = false;
            this.ListArchiveRoomButton.Click += new System.EventHandler(this.ListArchiveRoomButton_Click);
            // 
            // ArchiveDataGridView
            // 
            this.ArchiveDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ArchiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArchiveDataGridView.Location = new System.Drawing.Point(324, 0);
            this.ArchiveDataGridView.Name = "ArchiveDataGridView";
            this.ArchiveDataGridView.Size = new System.Drawing.Size(472, 470);
            this.ArchiveDataGridView.TabIndex = 3;
            // 
            // ListArchiveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 468);
            this.Controls.Add(this.ArchiveDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListArchiveRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListArchiveRoom";
            this.Load += new System.EventHandler(this.ListArchiveRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveDataGridView)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ArchiveRoomComboBox;
        private System.Windows.Forms.TextBox ListArchiveTextBox;
        private System.Windows.Forms.Panel LoginPanel1;
        public System.Windows.Forms.Button ListArchiveRoomButton;
        private System.Windows.Forms.DataGridView ArchiveDataGridView;
    }
}