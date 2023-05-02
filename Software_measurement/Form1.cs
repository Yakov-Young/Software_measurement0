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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            Form newForm = new Task2();
            newForm.ShowDialog();
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            Form newForm = new Task1();
            newForm.ShowDialog();
        }
    }
}
