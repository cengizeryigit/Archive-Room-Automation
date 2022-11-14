using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsiv_Projesi.Section
{
    public partial class SearchSectioncs : Form
    {
        public SearchSectioncs()
        {
            InitializeComponent();
        }

        private void SearchSectioncs_Load(object sender, EventArgs e)
        {
            ArchiveDataGridView.DataSource = Crud.List("Select bolum_id, bolum_adi,oda_adi from odatablosu inner join bolumtablosu ON odatablosu.oda_id=bolumtablosu.oda_id");

            ArchiveRoomComboBox.DataSource = Crud.List("Select oda_id,oda_adi from odatablosu");
            ArchiveRoomComboBox.ValueMember = "oda_id";
            ArchiveRoomComboBox.DisplayMember = "oda_adi";
        }

        private void SearchSectionButton_Click(object sender, EventArgs e)
        {
            ArchiveDataGridView.DataSource = Crud.List("Select bolum_adi,oda_adi from odatablosu inner join bolumtablosu ON odatablosu.oda_id=bolumtablosu.oda_id where bolum_adi like '%"+SearchSectionTextBox.Text+"%'");

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
    }
}
