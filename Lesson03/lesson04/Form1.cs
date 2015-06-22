using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (comboBox1.Text == "Stevj")
            //{
            //    MessageBox.Show("You picked Stevj");
            //    comboBox1.Text = "";
            //}
            //if (comboBox1.Text == "Speth")
            //{
            //    MessageBox.Show("You picked Speth");
            //}
            if (comboBox1.Text != "Ste")
            {
                if (comboBox1.Text == "Stevj")
                {
                    MessageBox.Show("You picked Stevj");
                }
                else
                {
                    MessageBox.Show("I'm not sure who you picked.");
                }
            }
            else
            {
                MessageBox.Show("You picked Ste");
            }
        }
    }
}
