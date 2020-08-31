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
    public partial class Logasuser : Form
    {
        public Logasuser()
        {
            InitializeComponent();
        }

        private void Logasuser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txt_Username.Text == "Casa" && txt_Userpassword.Text == "1981")
            {
                Lista_de_cumparaturi f5 = new Lista_de_cumparaturi();
                this.Hide();
                f5.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Userpassword_TextChanged(object sender, EventArgs e)
        {
            txt_Userpassword.PasswordChar = '☆';
        }

        private void Logasuser_Load(object sender, EventArgs e)
        {
            txt_Username.Focus();
        }
    }
}
