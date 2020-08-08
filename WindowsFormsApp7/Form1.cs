using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(textBox1.Text);
                if (num > 99)
                {
                    MessageBox.Show("The Number You Have Entered Is Too Large. Please Enter A Value Less Than 99", "Multiplication Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    listBox1.Items.Clear();
                }
                else
                {
                    listBox1.Items.Clear();
                    int x = 0;

                    while (x <= 12)
                    {
                        listBox1.Items.Add(num + "x " + x + " = " + (num * x));
                        x++;
                    }
                }
            }


             catch (Exception num)
            {
                MessageBox.Show("Please provide numarical value lower than 99", "Multiplication Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
        }
    }
}
