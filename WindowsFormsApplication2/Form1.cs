using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            button1.Visible = false;
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked & checkBox2.Checked & checkBox3.Checked & checkBox4.Checked & checkBox5.Checked & checkBox6.Checked & checkBox7.Checked & checkBox8.Checked) {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked & checkBox2.Checked & checkBox3.Checked & checkBox4.Checked & checkBox5.Checked & checkBox6.Checked & checkBox7.Checked & checkBox8.Checked)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked & checkBox2.Checked & checkBox3.Checked & checkBox4.Checked & checkBox5.Checked & checkBox6.Checked & checkBox7.Checked & checkBox8.Checked)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked & checkBox2.Checked & checkBox3.Checked & checkBox4.Checked & checkBox5.Checked & checkBox6.Checked & checkBox7.Checked & checkBox8.Checked)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked & checkBox2.Checked & checkBox3.Checked & checkBox4.Checked & checkBox5.Checked & checkBox6.Checked & checkBox7.Checked & checkBox8.Checked)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked & checkBox2.Checked & checkBox3.Checked & checkBox4.Checked & checkBox5.Checked & checkBox6.Checked & checkBox7.Checked & checkBox8.Checked)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked & checkBox2.Checked & checkBox3.Checked & checkBox4.Checked & checkBox5.Checked & checkBox6.Checked & checkBox7.Checked & checkBox8.Checked)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked & checkBox2.Checked & checkBox3.Checked & checkBox4.Checked & checkBox5.Checked & checkBox6.Checked & checkBox7.Checked & checkBox8.Checked)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
    }
}
