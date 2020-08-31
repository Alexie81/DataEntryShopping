using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Cumparaturi
{
    public partial class Logasadmin : Form
    {
        public Logasadmin()
        {
            InitializeComponent();
        }

        private void Logasadmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //(Owner as Lista_de_cumparaturi).toolStripLabel1.Text = "";
            if (txt_Adminname.Text == "Alexie01" && txt_Adminpassword.Text == "Alexie1981")
            {
                Lista_de_cumparaturi f4 = new Lista_de_cumparaturi();
                this.Hide();
                f4.ShowDialog();
            } else
            {
                if (MessageBox.Show("Username or password incorrect !",
                   "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                {
                    Application.ExitThread();

                }
            }
        }

        private void txt_Adminpassword_TextChanged(object sender, EventArgs e)
        {
            txt_Adminpassword.PasswordChar = '☆';
        }

        private void Logasadmin_Load(object sender, EventArgs e)
        {
            txt_Adminname.Focus();
        }
    }
}
