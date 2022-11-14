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

namespace Arsiv_Projesi.Section
{
    public partial class AddSection : Form
    {
        public AddSection()
        {
            InitializeComponent();
        }

        private void AddSection_Load(object sender, EventArgs e)
        {
            ArchiveRoomComboBox.DataSource = Crud.List("Select oda_id,oda_adi from odatablosu");
            ArchiveRoomComboBox.ValueMember = "oda_id";
            ArchiveRoomComboBox.DisplayMember = "oda_adi";


            ArchiveDataGridView.DataSource = Crud.List("Select bolum_adi,oda_adi from odatablosu inner join bolumtablosu ON odatablosu.oda_id=bolumtablosu.oda_id");

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

        private void AddSectionButton_Click(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(ArchiveRoomComboBox.SelectedValue.ToString(), out val);
            SqlCommand komut;
            string sql = "insert into bolumtablosu(bolum_adi,oda_id) values('" + AddSectionTextBox.Text + "',"+val+")";
            komut = new SqlCommand();
            Crud.ESG(sql, komut);

            

            string komut2 = "Select bolum_id,bolum_adi from bolumtablosu where oda_id =" + val;
            SectionComboBox.DataSource = Crud.List(komut2);
            SectionComboBox.ValueMember = "bolum_id";
            SectionComboBox.DisplayMember = "bolum_adi";

            ArchiveDataGridView.DataSource = Crud.List("Select bolum_adi,oda_adi from odatablosu inner join bolumtablosu ON odatablosu.oda_id=bolumtablosu.oda_id");
            AddSectionTextBox.Text = "";

        }
    }
}
