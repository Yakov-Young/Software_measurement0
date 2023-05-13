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
    public partial class Task1Decision3 : Form
    {
        public Task1Decision3()
        {
            InitializeComponent();
        }

        private void Task1Decision3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Width = this.Width - 35;
            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[0].HeaderText = "Должность";
            dataGridView1.Columns[1].HeaderText = "Должностной оклад, руб.";
            dataGridView1.Columns[2].HeaderText = "Средняя дневная ставка руб.";
            dataGridView1.Columns[3].HeaderText = "Затраты времени на разработку, ч./день.";
            dataGridView1.Columns[4].HeaderText = "ОЗП, руб.";

            dataGridView1.Columns[4].ReadOnly = true;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;


            dataGridView3.Width = this.Width - 35;
            dataGridView3.ColumnCount = 5;

            dataGridView3.Columns[0].HeaderText = "Материалы";
            dataGridView3.Columns[1].HeaderText = "Единица измерения";
            dataGridView3.Columns[2].HeaderText = "Требуемое количество";
            dataGridView3.Columns[3].HeaderText = "Цена за единицу, руб";
            dataGridView3.Columns[4].HeaderText = "Сумма, руб.";

            dataGridView3.Columns[4].ReadOnly = true;

            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;


            button1.Location = new Point(this.Width - button1.Width - 50, dataGridView1.Bottom + 20);
            button2.Location = new Point(button1.Location.X - button1.Width - 20, dataGridView1.Bottom + 20);
            dataGridView3.Location = new Point(0, button1.Bottom + 40);
            button3.Location = new Point(button1.Location.X, dataGridView3.Bottom + 20);
            button4.Location = new Point(button3.Location.X - button3.Width - 20, dataGridView3.Bottom + 20);
            groupBox1.Location = new Point(0, button4.Bottom + 40);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetOZP(dataGridView1);


        }

        private void SetOZP(DataGridView dataGridView)
        {
            try
            {
                if (dataGridView.Enabled == false)
                {
                    return;
                }

                int countRow = dataGridView.RowCount - 1;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (countRow == row.Index && row.Index != 0)
                    {
                        continue;
                    }

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null || row.Cells[3].Value == null)
                    {
                        throw new Exception();
                    }

                    double rate = double.Parse(row.Cells[2].Value.ToString());
                    double days = int.Parse(row.Cells[3].Value.ToString());

                    double ozp = rate * days;
                    row.Cells[4].Value = ozp;
                }


                AddTotalRow(dataGridView);
                dataGridView.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка в {dataGridView.Name}. Обнаружены пустые значения");
            }
        }

        private void AddTotalRow(DataGridView dataGridView)
        {
            DataGridViewRow totalRow = new DataGridViewRow();
            totalRow.ReadOnly = true;

            DataGridViewCell cell0 = new DataGridViewTextBoxCell();
            DataGridViewCell cell1 = new DataGridViewTextBoxCell();
            DataGridViewCell cell2 = new DataGridViewTextBoxCell();
            DataGridViewCell cell3 = new DataGridViewTextBoxCell();
            DataGridViewCell cell4 = new DataGridViewTextBoxCell();

            double sum = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                sum += Convert.ToDouble(row.Cells[4].Value);
            }
            cell0.Value = "Итого";
            cell4.Value = sum.ToString();

            totalRow.Cells.Add(cell0);
            totalRow.Cells.Add(cell1);
            totalRow.Cells.Add(cell2);
            totalRow.Cells.Add(cell3);
            totalRow.Cells.Add(cell4);

            dataGridView.Rows.Add(totalRow);

            if (dataGridView.Name == "dataGridView1")
            {
                textBoxZoi.Text = sum.ToString();
            }
            else if (true)
            {
                textBoxCm.Text = sum.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            dataGridView1.Enabled = true;
        }
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {


            if (e.ColumnIndex == 1 || e.ColumnIndex == 2) // проверка для второго и третьего столбца
            {
                double value;
                if (!double.TryParse(e.FormattedValue.ToString().Replace(".", ","), out value) || value <= 0)
                {
                    //MessageBox.Show("Введите положительное число!");
                    e.Cancel = true;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = .1f;
                }
            }
            else if (e.ColumnIndex == 3) // проверка для четвертого столбца
            {
                int value;
                if (!int.TryParse(e.FormattedValue.ToString(), out value) || value <= 0)
                {
                    //MessageBox.Show("Введите натуральное число!");
                    e.Cancel = true;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                }
            }
        }

        private void dataGridView3_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.ColumnIndex == 3) // проверка для четвертого столбца
            {
                double value;
                if (!double.TryParse(e.FormattedValue.ToString().Replace(".", ","), out value) || value <= 0)
                {
                    //MessageBox.Show("Введите положительное число!");
                    e.Cancel = true;
                    dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = .1f;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetSum();
        }

        private void SetSum()
        {
            try
            {
                if (dataGridView3.Enabled == false)
                {
                    return;
                }

                int countRow = dataGridView3.RowCount - 1;

                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (countRow == row.Index && row.Index != 0)
                    {
                        continue;
                    }

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null || row.Cells[3].Value == null)
                    {
                        throw new Exception();
                    }

                    double rate = double.Parse(row.Cells[2].Value.ToString());
                    double days = int.Parse(row.Cells[3].Value.ToString());

                    double sum = rate * days;
                    row.Cells[4].Value = sum;
                }

                AddTotalRow(dataGridView3);
                dataGridView3.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка в {dataGridView3.Name}. Обнаружены пустые значения");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();

            dataGridView3.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double tmp1 = Convert.ToDouble(textBox1.Text);
            double tmp2 = Convert.ToDouble(textBox2.Text);
            double tmp3 = Convert.ToDouble(textBox3.Text);
            textBoxMb.Text = (tmp1* tmp2 * tmp3).ToString();
        }

        private void TextBox_CoefValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            double value;
            if (!double.TryParse(textBox.Text.Replace(".", ","), out value) || value < 0.0001 || value > 1)
            {
                MessageBox.Show("Введите коэффициент");
                textBox.Text = "0,001";
            }
        }

        private void TextBox_DoublePlusValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            double value;
            if (!double.TryParse(textBox.Text.Replace(".", ","), out value) || value <= 0)
            {
                MessageBox.Show("Введите коэффициент");
                textBox.Text = "0.001";
            }
        }
    }
}
