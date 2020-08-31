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
    public partial class Lista_de_cumparaturi : Form
    {
        public Lista_de_cumparaturi()
        {
            InitializeComponent();
        }

        private void Lista_de_cumparaturi_Load(object sender, EventArgs e)
        {
            //if(toolStripLabel1.Text == "Log as User")
           // {
           //     button5.Visible = false;
           // } else
           // {
           //     button5.Visible = true;
          //  }
            Total.Text = "0";
            total__lei_TextBox.Text = "0";
            // TODO: This line of code loads data into the 'modelDataSet.Database' table. You can move, or remove it, as needed.
            this.databaseTableAdapter.Fill(this.modelDataSet.Database);

        }

        private void Lista_de_cumparaturi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void databaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.databaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);
            
            
            double sum = 0;
            for(int i = 0; i< databaseDataGridView.Rows.Count -1; ++i)
            {
                try
                {
                    if (bindingNavigatorDeleteItem.Enabled == false)
                    {
                        Total.Text= "0";
                    }
                    else
                    {
                        sum = sum + double.Parse(databaseDataGridView.Rows[i].Cells[5].Value.ToString());
                        Total.Text = sum.ToString("0");
                    }
                }
                catch {

                    MessageBox.Show("Invalid Value !!!");
                }
            }
            

            //Total.Text = "0";
            //for (int i = 0; i < databaseDataGridView.Rows.Count; i++)
            //{

            //    Total.Text = Convert.ToString(double.Parse(Total.Text) + double.Parse(databaseDataGridView.Rows[i].Cells[5].Value.ToString()));

            //}

            //label2.Text = "0";
            //int A = 0, B = 0, C = 0;
            //for( A = 0; A<databaseDataGridView.Rows.Count; ++A)
            //{
            // label2.Text = Convert.ToString(double.Parse(label2.Text) + double.Parse(databaseDataGridView.Rows[A].Cells[5].Value.ToString()));
            // B += Convert.ToInt32(databaseDataGridView.Rows[A].Cells[5].Value);

            // }
            // label2.Text = B.ToString();
            // //label2.Text = "0";
            // for (int i = 0; i < databaseDataGridView.Rows.Count; i++)
            // {

            //  label2.Text = Convert.ToString(double.Parse(label2.Text) + double.Parse(databaseDataGridView.Rows[i].Cells[5].Value.ToString()));

            // }
        }

        private void pret__lei_Label_Click(object sender, EventArgs e)
        {

        }

        private void pret__lei_TextBox_TextChanged(object sender, EventArgs e)
        {
            cantitateTextBox.Focus();
            pret__lei_TextBox.Focus();
        }

        private void cantitateTextBox_Leave(object sender, EventArgs e)
        {
            float a = 0;
            float b = 0;
            float c = 0;
            if (float.TryParse(cantitateTextBox.Text, out a) & float.TryParse(pret__lei_TextBox.Text, out b))
            {
                c = a * b;
                total__lei_TextBox.Text = c.ToString();
            }
            //cantitateTextBox.Text = string.Format("{0:n0}", cantitateTextBox.Text);
        }

        private void cantitateTextBox_TextChanged(object sender, EventArgs e)
        {
            cantitateTextBox.Focus();
            pret__lei_TextBox.Focus();
            cantitateTextBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //this.databaseDataGridView.BackgroundColor = Color.DarkRed;
            Total.Text = "0";
            float sum = 0;
            for (int i = 0; i < databaseDataGridView.Rows.Count - 1; ++i)
            {
                sum = sum + float.Parse(databaseDataGridView.Rows[i].Cells[5].Value.ToString());
                if (sum == 0)
                {
                    if (bindingNavigatorDeleteItem.Enabled == false)
                    {
                        sum = 0;
                        Total.Text = sum.ToString();
                    }
                }
                else
                {
                    //sum += double.Parse(databaseDataGridView.Rows[i].Cells[5].Value.ToString());
                    Total.Text = sum.ToString("0");
                }
            }
            //Total.Text = "0";
            //for (int i = 0; i < databaseDataGridView.Rows.Count; i++)
            //{

            //   Total.Text = Convert.ToString(double.Parse(Total.Text) + double.Parse(databaseDataGridView.Rows[i].Cells[5].Value.ToString()));

            // }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void databaseDataGridView_TabIndexChanged(object sender, EventArgs e)
        {
            float sum = 0;
            for (int i = 0; i < databaseDataGridView.Rows.Count - 1; ++i)
            {
                sum = sum + float.Parse(databaseDataGridView.Rows[i].Cells[5].Value.ToString());
                if (sum == 0)
                {
                    if (bindingNavigatorDeleteItem.Enabled == false)
                    {
                        //sum = 0;
                        Total.Text = "0";
                    }
                }
                else
                {
                    //sum += double.Parse(databaseDataGridView.Rows[i].Cells[5].Value.ToString());
                    Total.Text = sum.ToString("0");
                }
            }
        }

        private void databaseDataGridView_BackgroundColorChanged(object sender, EventArgs e)
        {
            float sum = 0;
            for (int i = 0; i < databaseDataGridView.Rows.Count - 1; ++i)
            {
                sum = sum + float.Parse(databaseDataGridView.Rows[i].Cells[5].Value.ToString());
                if (sum == 0)
                {
                    if (bindingNavigatorDeleteItem.Enabled == false)
                    {
                        //sum = 0;
                        Total.Text = "0";
                    }
                }
                else
                {
                    //sum += double.Parse(databaseDataGridView.Rows[i].Cells[5].Value.ToString());
                    Total.Text = sum.ToString("0");
                }
            }
        }

        private void databaseDataGridView_DragOver(object sender, DragEventArgs e)
        {
          
        }
    }
}
