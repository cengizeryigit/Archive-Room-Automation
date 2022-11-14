using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsiv_Projesi._7Document
{
    public partial class SearchDocument : Form
    {
        public SearchDocument()
        {
            InitializeComponent();
        }

        private void SearchDocument_Load(object sender, EventArgs e)
        {
            ArchiveRoomComboBox.DataSource = Crud.List("Select oda_id,oda_adi from odatablosu");
            ArchiveRoomComboBox.ValueMember = "oda_id";
            ArchiveRoomComboBox.DisplayMember = "oda_adi";

            ArchiveDataGridView.DataSource = Crud.List("Select evrak_adi,evrak_islem_tarihi,dosya_adi,gelengidenevrak_adi from evraktablosu inner join dosyatablosu ON dosyatablosu.dosya_id=evraktablosu.dosya_id inner join gelengidenevraktablosu ON evraktablosu.gelengidenevrak_id=gelengidenevraktablosu.gelengidenevrak_id");

        }

        private void ArchiveRoomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SectionComboBox.Text = "";
            int val;
            Int32.TryParse(ArchiveRoomComboBox.SelectedValue.ToString(), out val);
            string komut = "Select bolum_id,bolum_adi from bolumtablosu where oda_id =" + val;
            SectionComboBox.DataSource = Crud.List(komut);
            SectionComboBox.ValueMember = "bolum_id";
            SectionComboBox.DisplayMember = "bolum_adi";
        }

        private void SectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShelfComboBox.Text = "";
            int val;
            Int32.TryParse(SectionComboBox.SelectedValue.ToString(), out val);
            string komut = "Select raf_id,raf_adi from raftablosu where bolum_id =" + val;
            ShelfComboBox.DataSource = Crud.List(komut);
            ShelfComboBox.ValueMember = "raf_id";
            ShelfComboBox.DisplayMember = "raf_adi";
        }

        private void ShelfComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FolderComboBox.Text = "";
            int val;
            Int32.TryParse(ShelfComboBox.SelectedValue.ToString(), out val);
            string komut = "Select klasor_id,klasor_adi from klasortablosu where raf_id =" + val;
            FolderComboBox.DataSource = Crud.List(komut);
            FolderComboBox.ValueMember = "klasor_id";
            FolderComboBox.DisplayMember = "klasor_adi";
        }

        private void FolderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileComboBox.Text = "";
            int val;
            Int32.TryParse(FolderComboBox.SelectedValue.ToString(), out val);
            string komut = "Select dosya_id,dosya_adi from dosyatablosu where klasor_id =" + val;
            FileComboBox.DataSource = Crud.List(komut);
            FileComboBox.ValueMember = "dosya_id";
            FileComboBox.DisplayMember = "dosya_adi";
        }

        private void FileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocumentComboBox.Text = "";
            int val;
            Int32.TryParse(FileComboBox.SelectedValue.ToString(), out val);
            string komut = "Select evrak_id,evrak_adi from evraktablosu where dosya_id =" + val;
            DocumentComboBox.DataSource = Crud.List(komut);
            DocumentComboBox.ValueMember = "evrak_id";
            DocumentComboBox.DisplayMember = "evrak_adi";
        }

        private void SearchDocumentButton_Click(object sender, EventArgs e)
        {
            ArchiveDataGridView.DataSource = Crud.List("Select evrak_adi,evrak_islem_tarihi,dosya_adi,gelengidenevrak_adi from evraktablosu inner join dosyatablosu ON dosyatablosu.dosya_id=evraktablosu.dosya_id inner join gelengidenevraktablosu ON evraktablosu.gelengidenevrak_id=gelengidenevraktablosu.gelengidenevrak_id where evrak_adi like '%" + SearchDocumentTextBox.Text + "%'");

        }
    }
}
