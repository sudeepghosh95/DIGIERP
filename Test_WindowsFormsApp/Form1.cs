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

        //Save Button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string x;

                if (radioButton1.Checked)
                    x = "M";
                else
                    x = "F";
                DB obj = new DB();
               // obj.InsertUpdateDelete(String.Format("insert into tbl_Cus_details values ( " + textBox8.Text.ToString() + "," + textBox2.Text.ToString() + "," + textBox6.Text.ToString() + "," + textBox7.Text.ToString() + "," + textBox5.Text.ToString() + "," + textBox10.Text.ToString() + "," + textBox1.Text.ToString() + "," + textBox13.Text.ToString() + "," + textBox14.Text.ToString() + "," + dateTimePicker1.Value.ToShortDateString() + "," + dateTimePicker1.Value.ToShortDateString() + "," + textBox3.Text.ToString() + "," + x.ToString() + ") "));
                obj.InsertUpdateDelete(String.Format("insert into bill values(" + textBox8.Text.ToString() + "," + textBox9.Text.ToString() + "," + textBox11.Text.ToString() + "," + dateTimePicker1.Value + "," + textBox13.Text.ToString() + "," + textBox14.Text.ToString() + ") "));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
        
        //Clear Button.
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox10.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox11.Clear();
            textBox13.Clear();
            textBox14.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
