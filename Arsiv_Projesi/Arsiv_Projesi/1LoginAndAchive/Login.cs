using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsiv_Projesi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButtonLogin_Click(object sender, EventArgs e)
        {
            if (LoginTextBoxUsername.Text=="admin" && LoginTextBoxPassword.Text=="admin")
            {
                Archive archive = new Archive();
                archive.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The user name or password you entered is incorrect, try again");
                LoginTextBoxUsername.Clear();
                LoginTextBoxPassword.Clear();
                LoginTextBoxUsername.Focus();
            }
        }

        private void LoginLabelClearFields_Click(object sender, EventArgs e)
        {
            LoginTextBoxUsername.Clear();
            LoginTextBoxPassword.Clear();
            LoginTextBoxUsername.Focus();
            
            
        }

        private void LoginLabelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
