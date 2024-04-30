using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedItem == null) || (comboBox2.SelectedItem == null))
            {
                MessageBox.Show("Please enter values");
            }

            else
            {
                float p;
                float T;
                if ((float.TryParse(comboBox1.SelectedItem.ToString(), out T)) & (float.TryParse(comboBox2.SelectedItem.ToString(), out p)))
                {
                    float n = F1(T, p);
                    listBox1.Items.Add($"n = {n}");
                }
                else
                {
                    MessageBox.Show("Convertation error");
                }

            }
        }

        float F1(float T, float p)
        {
            return (float)(Math.Exp(-1.528 + 0.00153 * p + (763.67999 + 2.30351 * p - 0.00261 * p * p) / (T - 175.93506)));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
