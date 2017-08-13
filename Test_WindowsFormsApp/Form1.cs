using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string s1;
                DB obj = new DB();
                if (radioButton3.Checked)
                {
                    s1 = textBox12.Text;
                    dataGridView1.DataSource = obj.getData2("select * from tbl_Cus_details where mobile ='" + s1 + "'");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
