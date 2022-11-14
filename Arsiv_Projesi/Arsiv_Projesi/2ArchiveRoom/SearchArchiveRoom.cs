using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsiv_Projesi.ArchiveRoom
{
    public partial class SearchArchiveRoom : Form
    {
        public SearchArchiveRoom()
        {
            InitializeComponent();
        }

        private void SearchArchiveRoomButton_Click(object sender, EventArgs e)
        {
            ArchiveDataGridView.DataSource = Crud.List("Select oda_adi from odatablosu where oda_adi like '%"+SearchArchiveTextBox.Text+"%'");
           
        }

        private void SearchArchiveRoom_Load(object sender, EventArgs e)
        {
            ArchiveRoomComboBox.DataSource = Crud.List("Select oda_id,oda_adi from odatablosu");
            ArchiveRoomComboBox.ValueMember = "oda_id";
            ArchiveRoomComboBox.DisplayMember = "oda_adi";
            ArchiveDataGridView.DataSource = Crud.List("Select oda_adi from odatablosu");
        }
    }
}
