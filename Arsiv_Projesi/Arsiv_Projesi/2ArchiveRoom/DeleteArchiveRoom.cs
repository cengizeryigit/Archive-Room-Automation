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
    public partial class DeleteArchiveRoom : Form
    {
        public DeleteArchiveRoom()
        {
            InitializeComponent();
        }
        
        private void DeleteArchiveRoomButton_Click(object sender, EventArgs e)
        {
            /* Select * From odatablosu
            inner join bolumtablosu ON odatablosu.oda_id = bolumtablosu.oda_id
            inner join raftablosu ON bolumtablosu.bolum_id = raftablosu.bolum_id
            inner join klasortablosu ON raftablosu.raf_id = klasortablosu.raf_id
            inner join dosyatablosu ON klasortablosu.klasor_id = dosyatablosu.klasor_id
            inner join evraktablosu ON dosyatablosu.dosya_id = evraktablosu.dosya_id
            inner join gelengidenevraktablosu ON evraktablosu.gelengidenevrak_id = gelengidenevraktablosu.gelengidenevrak_id
            Where odatablosu.oda_id =
            */

            //inner join bolumtablosu ON odatablosu.oda_id = bolumtablosu.oda_id inner join raftablosu ON bolumtablosu.bolum_id = raftablosu.bolum_id inner join klasortablosu ON raftablosu.raf_id = klasortablosu.raf_id inner join dosyatablosu ON klasortablosu.klasor_id = dosyatablosu.klasor_id inner join evraktablosu ON dosyatablosu.dosya_id = evraktablosu.dosya_id inner join gelengidenevraktablosu ON evraktablosu.gelengidenevrak_id = gelengidenevraktablosu.gelengidenevrak_id 
            SqlCommand komut;
            string sql = "Delete from odatablosu Where odatablosu.oda_id ='"+ ArchiveRoomComboBox.SelectedValue.ToString() + "'";
            komut = new SqlCommand();
            Crud.ESG(sql, komut);
            ArchiveDataGridView.DataSource = Crud.List("Select oda_adi from odatablosu");
            DeleteArchiveTextBox.Text = "";



            ArchiveRoomComboBox.DataSource = Crud.List("Select oda_id,oda_adi from odatablosu");
            ArchiveRoomComboBox.ValueMember = "oda_id";
            ArchiveRoomComboBox.DisplayMember = "oda_adi";
            ArchiveDataGridView.DataSource = Crud.List("Select oda_adi from odatablosu");



        }

        private void DeleteArchiveRoom_Load(object sender, EventArgs e)
        {
           
            ArchiveRoomComboBox.DataSource = Crud.List("Select oda_id,oda_adi from odatablosu");
            ArchiveRoomComboBox.ValueMember = "oda_id";   
            ArchiveRoomComboBox.DisplayMember = "oda_adi";
            ArchiveDataGridView.DataSource = Crud.List("Select oda_adi from odatablosu");

        }
    }
}
