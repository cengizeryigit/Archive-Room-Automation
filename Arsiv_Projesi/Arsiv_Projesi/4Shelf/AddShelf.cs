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

namespace Arsiv_Projesi.Shelf
{
    public partial class AddShelf : Form
    {
        public AddShelf()
        {
            InitializeComponent();
        }

        private void AddShelf_Load(object sender, EventArgs e)
        {
            ArchiveRoomComboBox.DataSource = Crud.List("Select oda_id,oda_adi from odatablosu");
            ArchiveRoomComboBox.ValueMember = "oda_id";
            ArchiveRoomComboBox.DisplayMember = "oda_adi";

            ArchiveDataGridView.DataSource = Crud.List("Select raf_adi,bolum_adi from raftablosu inner join bolumtablosu ON raftablosu.bolum_id=bolumtablosu.bolum_id");

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

        private void AddShelfButton_Click(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(SectionComboBox.SelectedValue.ToString(), out val);
            SqlCommand komut;
            string sql = "insert into raftablosu(raf_adi,bolum_id) values('" + AddShelfTextBox.Text + "'," + val + ")";
            komut = new SqlCommand();
            Crud.ESG(sql, komut);


            string komut2 = "Select raf_id,raf_adi from raftablosu where bolum_id =" + val;
            ShelfComboBox.DataSource = Crud.List(komut2);
            ShelfComboBox.ValueMember = "raf_id";
            ShelfComboBox.DisplayMember = "raf_adi";

            ArchiveDataGridView.DataSource = Crud.List("Select raf_adi,bolum_adi from raftablosu inner join bolumtablosu ON raftablosu.bolum_id=bolumtablosu.bolum_id");
            AddShelfTextBox.Text = "";
        }
    }
}
