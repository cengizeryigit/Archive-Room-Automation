using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsiv_Projesi._5Folder
{
    public partial class SearchFolder : Form
    {
        public SearchFolder()
        {
            InitializeComponent();
        }

        private void SearchFolder_Load(object sender, EventArgs e)
        {

            ArchiveRoomComboBox.DataSource = Crud.List("Select oda_id,oda_adi from odatablosu");
            ArchiveRoomComboBox.ValueMember = "oda_id";
            ArchiveRoomComboBox.DisplayMember = "oda_adi";

            ArchiveDataGridView.DataSource = Crud.List("Select klasor_adi,raf_adi from klasortablosu inner join raftablosu ON klasortablosu.raf_id=raftablosu.raf_id");

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

        private void SearchFolderButton_Click(object sender, EventArgs e)
        {
            ArchiveDataGridView.DataSource = Crud.List("Select klasor_adi,raf_adi from klasortablosu inner join raftablosu ON klasortablosu.raf_id=raftablosu.raf_id where klasor_adi like '%" + SearchFolderTextBox.Text + "%'");

        }
    }
}
