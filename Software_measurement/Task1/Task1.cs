using System;
using System.Windows.Forms;

namespace Software_measurement
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form newForm = new Task1Decision1();
            newForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form newForm = new Task1Decision2CountActor();
            newForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form newForm = new Task1Decision3();
            newForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form newForm = new Task1Decision4();
            newForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form newForm = new Task1Decision5();
            newForm.ShowDialog();
        }
    }
}
