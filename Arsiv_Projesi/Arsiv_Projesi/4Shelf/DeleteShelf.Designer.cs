namespace Arsiv_Projesi.Shelf
{
    partial class DeleteShelf
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
            this.ArchiveDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShelfComboBox = new System.Windows.Forms.ComboBox();
            this.SectionComboBox = new System.Windows.Forms.ComboBox();
            this.ArchiveRoomComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteShelfTextBox = new System.Windows.Forms.TextBox();
            this.LoginPanel1 = new System.Windows.Forms.Panel();
            this.DeleteShelfButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArchiveDataGridView
            // 
            this.ArchiveDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ArchiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArchiveDataGridView.Location = new System.Drawing.Point(324, 0);
            this.ArchiveDataGridView.Name = "ArchiveDataGridView";
            this.ArchiveDataGridView.Size = new System.Drawing.Size(472, 470);
            this.ArchiveDataGridView.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ShelfComboBox);
            this.panel1.Controls.Add(this.SectionComboBox);
            this.panel1.Controls.Add(this.ArchiveRoomComboBox);
            this.panel1.Controls.Add(this.DeleteShelfTextBox);
            this.panel1.Controls.Add(this.LoginPanel1);
            this.panel1.Controls.Add(this.DeleteShelfButton);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 473);
            this.panel1.TabIndex = 10;
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
            // DeleteShelfTextBox
            // 
            this.DeleteShelfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeleteShelfTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteShelfTextBox.ForeColor = System.Drawing.Color.Black;
            this.DeleteShelfTextBox.Location = new System.Drawing.Point(59, 162);
            this.DeleteShelfTextBox.Multiline = true;
            this.DeleteShelfTextBox.Name = "DeleteShelfTextBox";
            this.DeleteShelfTextBox.Size = new System.Drawing.Size(203, 24);
            this.DeleteShelfTextBox.TabIndex = 4;
            // 
            // LoginPanel1
            // 
            this.LoginPanel1.BackColor = System.Drawing.Color.Black;
            this.LoginPanel1.Location = new System.Drawing.Point(59, 186);
            this.LoginPanel1.Name = "LoginPanel1";
            this.LoginPanel1.Size = new System.Drawing.Size(203, 1);
            this.LoginPanel1.TabIndex = 5;
            // 
            // DeleteShelfButton
            // 
            this.DeleteShelfButton.BackColor = System.Drawing.Color.Black;
            this.DeleteShelfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteShelfButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteShelfButton.ForeColor = System.Drawing.Color.White;
            this.DeleteShelfButton.Location = new System.Drawing.Point(40, 402);
            this.DeleteShelfButton.Name = "DeleteShelfButton";
            this.DeleteShelfButton.Size = new System.Drawing.Size(235, 31);
            this.DeleteShelfButton.TabIndex = 3;
            this.DeleteShelfButton.Text = "DELETE SHELF ";
            this.DeleteShelfButton.UseVisualStyleBackColor = false;
            this.DeleteShelfButton.Click += new System.EventHandler(this.DeleteShelfButton_Click);
            // 
            // DeleteShelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ArchiveDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteShelf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteShelf";
            this.Load += new System.EventHandler(this.DeleteShelf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ArchiveDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ShelfComboBox;
        private System.Windows.Forms.ComboBox SectionComboBox;
        private System.Windows.Forms.ComboBox ArchiveRoomComboBox;
        private System.Windows.Forms.TextBox DeleteShelfTextBox;
        private System.Windows.Forms.Panel LoginPanel1;
        public System.Windows.Forms.Button DeleteShelfButton;
    }
}