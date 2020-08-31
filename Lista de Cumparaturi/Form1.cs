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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logasadmin f2 = new Logasadmin();
            this.Hide();
            f2.ShowDialog();
            //Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Logasuser f3 = new Logasuser();
            this.Hide();
            f3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginConsole f6 = new LoginConsole();
            //.Hide();
            f6.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
        }
    }
}
