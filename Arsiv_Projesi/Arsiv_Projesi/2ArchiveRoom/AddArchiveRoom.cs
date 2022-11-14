using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsiv_Projesi.ArchiveRoom
{
    public partial class AddArchiveRoom : Form
    {
        public AddArchiveRoom()
        {
            InitializeComponent();
            
        }
         
        private void AddArchiveRoomButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            string sql = "insert into odatablosu(oda_adi) values('"+AddArchiveTextBox.Text+"')";
            komut = new SqlCommand();
            Crud.ESG(sql,komut);
            ArchiveDataGridView.DataSource = Crud.List("Select oda_adi from odatablosu");
            AddArchiveTextBox.Text ="";
            

            ArchiveRoomComboBox.DataSource = Crud.List("Select oda_id,oda_adi from odatablosu");
            ArchiveRoomComboBox.ValueMember = "oda_id";
            ArchiveRoomComboBox.DisplayMember = "oda_adi";
            ArchiveDataGridView.DataSource = Crud.List("Select oda_adi from odatablosu");
           

        }

        private void AddArchiveRoom_Load(object sender, EventArgs e)
        {
            ArchiveRoomComboBox.DataSource = Crud.List("Select oda_id,oda_adi from odatablosu");
            ArchiveRoomComboBox.ValueMember = "oda_id";
            ArchiveRoomComboBox.DisplayMember = "oda_adi";          
            ArchiveDataGridView.DataSource = Crud.List("Select oda_adi from odatablosu");
            
        }
    }
}
