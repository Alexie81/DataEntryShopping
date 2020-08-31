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
    public partial class LoginConsole : Form
    {
        public LoginConsole()
        {
            InitializeComponent();
        }

        private void LoginConsole_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form1 f7 = new Form1();
            //f7.ShowDialog();
        }

        private void LoginConsole_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Loginasadmin(Alexie01, Alexie1981) = true" || textBox1.Text == "Loginasuser(Casa, 1981) = true")
            {
                Lista_de_cumparaturi f8 = new Lista_de_cumparaturi();
                //ActiveForm.Hide();
                this.Hide();
                Hide();
                f8.ShowDialog();
            } else if(textBox1.Text == "EXIT" || textBox1.Text == "exit" || textBox1.Text == "Exit") {
                this.Hide();
            } else {
                if (MessageBox.Show("Unkwon command !",
                   "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                {
                    Application.ExitThread();

                }
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
