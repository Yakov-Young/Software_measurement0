using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_measurement
{
    public partial class EnergyCost : Form
    {
        public EnergyCost()
        {
            InitializeComponent();
        }

        private void textBox_ValidatedDouble(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            textBox.Text = textBox.Text.Replace(".", ",");

            double outValue;

            if (!double.TryParse(textBox.Text, out outValue) || outValue < 0)
            {
                //MessageBox.Show("Введите положительное число!");
                textBox.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var value = double.Parse(textBox1.Text);
            if (value != double.MaxValue)
            {
                Task1Decision4.energyCost = value;
            }
            else
            {
                Task1Decision4.energyCost = 1;
            }
            this.Close();
        }
    }
}
