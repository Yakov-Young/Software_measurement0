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
            label1.Location = new Point(0, 0);
            dataGridView1.Location = new Point(0, 14);
            dataGridView1.Width = this.Width - 35;
            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[0].HeaderText = "Должность";
            dataGridView1.Columns[1].HeaderText = "Должностной оклад, руб.";
            dataGridView1.Columns[2].HeaderText = "Средняя дневная ставка руб.";
            dataGridView1.Columns[3].HeaderText = "Затраты времени на разработку, час/день";
            dataGridView1.Columns[4].HeaderText = "ОЗП, руб.";

            dataGridView1.Columns[4].ReadOnly = true;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;


            dataGridView2.Width = this.Width - 35;
            dataGridView2.ColumnCount = 5;

            dataGridView2.Columns[0].HeaderText = "Материалы";
            dataGridView2.Columns[1].HeaderText = "Единица измерения";
            dataGridView2.Columns[2].HeaderText = "Требуемое количество";
            dataGridView2.Columns[3].HeaderText = "Цена за единицу, руб.";
            dataGridView2.Columns[4].HeaderText = "Сумма, руб.";

            dataGridView2.Columns[4].ReadOnly = true;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;


            dataGridView3.Width = this.Width - 35;
            dataGridView3.ColumnCount = 1;
            dataGridView3.RowCount = 7;

            dataGridView3.TopLeftHeaderCell.Value = "Статьи затрат";
            dataGridView3.Columns[0].HeaderText = "Сумма, руб.";

            dataGridView3.Rows[0].HeaderCell.Value = "Основная заработная плата, руб.";
            dataGridView3.Rows[1].HeaderCell.Value = "Затраты на материалы, руб.";
            dataGridView3.Rows[2].HeaderCell.Value = "Затраты на машинное время, руб.";
            dataGridView3.Rows[3].HeaderCell.Value = "Дополнительная заработная плата(коэф.)";
            dataGridView3.Rows[4].HeaderCell.Value = "Отчисления на социальные нужды(коэф.)";
            dataGridView3.Rows[5].HeaderCell.Value = "Накладные расходы организации(коэф.)";
            dataGridView3.Rows[6].HeaderCell.Value = "Итого, руб.";
            
            dataGridView3[0, 0].Value = 0.ToString();
            dataGridView3[0, 1].Value = 0.ToString();
            dataGridView3[0, 2].Value = 0.ToString();
            dataGridView3[0, 3].Value = 0.ToString();
            dataGridView3[0, 4].Value = 0.ToString();
            dataGridView3[0, 5].Value = 0.ToString();

            dataGridView3.Rows[0].ReadOnly = true;
            dataGridView3.Rows[1].ReadOnly = true;
            dataGridView3.Rows[2].ReadOnly = true;
            dataGridView3.Rows[6].ReadOnly = true;

            dataGridView3.RowHeadersWidth = 400;
            dataGridView3.Height = dataGridView3.Rows[0].Height * (dataGridView3.RowCount + 1);

            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;


            dataGridView4.Width = this.Width - 35;
            dataGridView4.ColumnCount = 6;

            dataGridView4.Columns[0].HeaderText = "Оборудование";
            dataGridView4.Columns[1].HeaderText = "Балансовая стоимость, руб.";
            dataGridView4.Columns[2].HeaderText = "Количество, ед.";
            dataGridView4.Columns[3].HeaderText = "Эффективный годовой фонд, час/год";
            dataGridView4.Columns[4].HeaderText = "Время работы тех. ср-ва, час/год";
            dataGridView4.Columns[5].HeaderText = "Сумма, руб.";

            dataGridView4.Columns[5].ReadOnly = true;

            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;



            dataGridView5.Width = this.Width - 35;
            dataGridView5.ColumnCount = 4;

            dataGridView5.Columns[0].HeaderText = "Техническое средство";
            dataGridView5.Columns[1].HeaderText = "Трудоемкость однократной обработки информации, час";
            dataGridView5.Columns[2].HeaderText = "Частота (периодичность) решения к-й задачи, дней /год";
            dataGridView5.Columns[3].HeaderText = "Сумма, руб.";

            dataGridView5.Columns[3].ReadOnly = true;

            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView5.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;



            dataGridView6.Width = this.Width - 35;
            dataGridView6.ColumnCount = 1;
            dataGridView6.RowCount = 7;

            dataGridView6.TopLeftHeaderCell.Value = "Статьи затрат";
            dataGridView6.Columns[0].HeaderText = "Сумма, руб.";

            dataGridView6.Rows[0].HeaderCell.Value = "Затраты на основное и вспомогательное оборудование, руб.";
            dataGridView6.Rows[1].HeaderCell.Value = "Затраты на строительство, реконструкцию здания и помещений, руб.";
            dataGridView6.Rows[2].HeaderCell.Value = "Затраты на приобретение типовых разработок, пакетов, руб.";
            dataGridView6.Rows[3].HeaderCell.Value = "Затраты на прокладку линий связи, руб.";
            dataGridView6.Rows[4].HeaderCell.Value = "Затраты на создание информационной базы, руб.";
            dataGridView6.Rows[5].HeaderCell.Value = "Затраты на подготовку и переподготовку кадров, руб.";
            dataGridView6.Rows[6].HeaderCell.Value = "Итого, руб.";

            dataGridView6[0, 0].Value = 0.ToString();

            dataGridView6.Rows[0].ReadOnly = true;
            dataGridView6.Rows[6].ReadOnly = true;

            dataGridView6.RowHeadersWidth = 400;
            dataGridView6.Height = dataGridView6.Rows[0].Height * (dataGridView3.RowCount + 1);

            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView6.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView6.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;



            button1.Location = new Point(this.Width - button1.Width - 50, dataGridView1.Bottom + 20);
            button2.Location = new Point(button1.Location.X - button1.Width - 20, dataGridView1.Bottom + 20);

            dataGridView2.Location = new Point(0, button1.Bottom + 40);
            label2.Location = new Point(0, dataGridView2.Location.Y - 14);
            button3.Location = new Point(button1.Location.X, dataGridView2.Bottom + 20);
            button4.Location = new Point(button3.Location.X - button3.Width - 20, dataGridView2.Bottom + 20);

            dataGridView5.Location = new Point(0, button3.Bottom + 40);
            label9.Location = new Point(0, dataGridView5.Location.Y - 14);
            button13.Location = new Point(button1.Location.X, dataGridView5.Bottom + 20);
            button12.Location = new Point(button3.Location.X - button3.Width - 20, dataGridView5.Bottom + 20);

            dataGridView3.Location = new Point(0, button13.Bottom + 40);
            label3.Location = new Point(0, dataGridView3.Location.Y - 14);
            button6.Location = new Point(button1.Location.X, dataGridView3.Bottom + 20);
            button5.Location = new Point(button3.Location.X - button3.Width - 20, dataGridView3.Bottom + 20);

            dataGridView4.Location = new Point(0, button5.Bottom + 40);
            label4.Location = new Point(0, dataGridView4.Location.Y - 14);
            button8.Location = new Point(button1.Location.X, dataGridView4.Bottom + 20);
            button7.Location = new Point(button3.Location.X - button3.Width - 20, dataGridView4.Bottom + 20);

            dataGridView6.Location = new Point(0, button7.Bottom + 40);
            label5.Location = new Point(0, dataGridView6.Location.Y - 14);
            button10.Location = new Point(button1.Location.X, dataGridView6.Bottom + 20);
            button9.Location = new Point(button3.Location.X - button3.Width - 20, dataGridView6.Bottom + 20);

            groupBox1.Location = new Point(this.Width / 2 - groupBox1.Width / 2, button10.Bottom + 40);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Enabled != false)
            {
                SetOZP();

                Task1.DataGridOZP = dataGridView1;

                dataGridView1.Enabled = false;
            }
        }

        private void SetOZP()
        {
            try
            {

                int countRow = dataGridView1.RowCount - 1;

                foreach (DataGridViewRow row in dataGridView1.Rows)
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
                    double days = double.Parse(row.Cells[3].Value.ToString());

                    double ozp = rate * days;
                    row.Cells[4].Value = ozp;
                }


                AddTotalRow(dataGridView1);
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка в {dataGridView1.Name}. Обнаружены пустые значения");
            }
        }

        private void AddTotalRow(DataGridView dataGridView)
        {
            DataGridViewRow totalRow = new DataGridViewRow
            {
                ReadOnly = true
            };

            int countColumns = dataGridView.ColumnCount;
            List<DataGridViewCell> cells = new List<DataGridViewCell>(countColumns);

            for (int i = 0; i < countColumns; i++)
            {
                cells.Add(new DataGridViewTextBoxCell());
            }

            double sum = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                sum += Convert.ToDouble(row.Cells[countColumns - 1].Value);
            }

            cells[0].Value = "Итого, руб.";
            cells[countColumns - 1].Value = Math.Round(sum, 3).ToString();

            for (int i = 0; i < countColumns; i++)
            {
                totalRow.Cells.Add(cells[i]);
            }

            dataGridView.Rows.Add(totalRow);


            if (dataGridView.Name == dataGridView1.Name)
            {
                dataGridView3[0, 0].Value = sum.ToString();
            }
            else if (dataGridView.Name == dataGridView2.Name)
            {
                dataGridView3[0, 1].Value = sum.ToString();
            }
            else if (dataGridView.Name == dataGridView4.Name)
            {
                dataGridView6[0, 0].Value = sum.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            dataGridView1.Enabled = true;
            dataGridView3[0, 0].Value = 0.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Enabled != false)
            {
                SetSumOnMaterials();

                dataGridView2.Enabled = false;
            }
        }

        private void SetSumOnMaterials()
        {
            try
            {

                int countRow = dataGridView2.RowCount - 1;

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (countRow == row.Index && row.Index != 0)
                    {
                        continue;
                    }

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null || row.Cells[3].Value == null)
                    {
                        throw new Exception();
                    }

                    double required = double.Parse(row.Cells[2].Value.ToString());
                    double cost = double.Parse(row.Cells[3].Value.ToString());

                    double sum = required * cost;
                    row.Cells[4].Value = sum;
                }

                AddTotalRow(dataGridView2);
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка в {dataGridView2.Name}. Обнаружены пустые значения");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            dataGridView2.Enabled = true;
            dataGridView3[0, 1].Value = 0.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Enabled != false)
            {
                SetKp();

                dataGridView3.Enabled = false;
            }
        }

        private void SetKp()
        {
            try
            {
                double res = Math.Round((Convert.ToDouble(dataGridView3[0, 0].Value)
                    + Convert.ToDouble(dataGridView3[0, 1].Value)
                    + Convert.ToDouble(dataGridView3[0, 2].Value))
                    * ((Convert.ToDouble(dataGridView3[0, 3].Value) + 1)
                    * (Convert.ToDouble(dataGridView3[0, 4].Value) + 1)
                    + Convert.ToDouble(dataGridView3[0, 5].Value)), 3);

                dataGridView3[0, 6].Value = res;
                textBox1.Text = res.ToString();

                Task1.Wc = Convert.ToDouble(dataGridView3[0, 3].Value);
                Task1.Wd = Convert.ToDouble(dataGridView3[0, 4].Value);
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка в {dataGridView3.Name}. Обнаружены пустые значения");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView3[0, 3].Value = "";
            dataGridView3[0, 4].Value = "";
            dataGridView3[0, 5].Value = "";
            dataGridView3[0, 6].Value = "";

            textBox1.Text = 0.ToString();

            dataGridView3.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView4.Enabled != false)
            {
                SetSumOnEquipment();

                dataGridView4.Enabled = false;
            }
        }

        private void SetSumOnEquipment()
        {
            try
            {
                int countRow = dataGridView4.RowCount - 1;

                foreach (DataGridViewRow row in dataGridView4.Rows)
                {
                    if (countRow == row.Index && row.Index != 0)
                    {
                        continue;
                    }

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null || row.Cells[3].Value == null || row.Cells[4].Value == null)
                    {
                        throw new Exception();
                    }

                    double res = Math.Round(Convert.ToDouble(row.Cells[1].Value)
                        * Convert.ToDouble(row.Cells[2].Value)
                        * (Convert.ToDouble(row.Cells[4].Value) / Convert.ToDouble(row.Cells[3].Value)), 3);
                    row.Cells[5].Value = res;
                }


                AddTotalRow(dataGridView4);

                Task1.DataGridMaterials = dataGridView4;


            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка в {dataGridView4.Name}. Обнаружены пустые значения");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();

            dataGridView4.Enabled = true;
            dataGridView6[0, 0].Value = 0.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView6.Enabled != false)
            {
                SetKr();

                dataGridView6.Enabled = false;
            }
        }

        private void SetKr()
        {
            try
            {
                double res = Math.Round(Convert.ToDouble(dataGridView6[0, 0].Value)
                    + Convert.ToDouble(dataGridView6[0, 1].Value)
                    + Convert.ToDouble(dataGridView6[0, 2].Value)
                    + Convert.ToDouble(dataGridView6[0, 3].Value)
                    + Convert.ToDouble(dataGridView6[0, 4].Value)
                    + Convert.ToDouble(dataGridView6[0, 5].Value), 3);

                dataGridView6[0, 6].Value = res;
                textBox2.Text = res.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка в {dataGridView6.Name}. Обнаружены пустые значения");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView6[0, 6].Value = null;
            dataGridView6[0, 1].Value = null;
            dataGridView6[0, 2].Value = null;
            dataGridView6[0, 3].Value = null;
            dataGridView6[0, 4].Value = null;
            dataGridView6[0, 5].Value = null;

            textBox2.Text = 0.ToString();

            dataGridView6.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (dataGridView5.Enabled != false)
            {
                SetSumMachineTime();

                Task1.DataGridMachineTime = dataGridView5;

                dataGridView5.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView5.Rows.Clear();

            dataGridView5.Enabled = true;
            dataGridView3[0, 2].Value = 0.ToString();
        }

        private void SetSumMachineTime()
        {
            try
            {
                int countRow = dataGridView5.RowCount - 1;

                foreach (DataGridViewRow row in dataGridView5.Rows)
                {
                    if (countRow == row.Index && row.Index != 0)
                    {
                        continue;
                    }

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null)
                    {
                        throw new Exception();
                    }

                    double res = Math.Round(Convert.ToDouble(row.Cells[1].Value)
                        * Convert.ToDouble(row.Cells[2].Value), 3);

                    row.Cells[3].Value = res;
                    dataGridView3[0, 2].Value = res;
                }


                AddTotalRow(dataGridView5);

            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка в {dataGridView5.Name}. Обнаружены пустые значения");
            }
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            var value = dataGridView1[e.ColumnIndex, e.RowIndex].Value;

            if (e.ColumnIndex == 0 || value == null)
            {
                return;
            }

            string valueNeNull = value.ToString();


            if (e.ColumnIndex == 1 || e.ColumnIndex == 2) // проверка для второго и третьего столбца
            {
                double outValue;

                if (!double.TryParse(valueNeNull.Replace(".", ","), out outValue) || outValue <= 0)
                {
                    //MessageBox.Show("Введите положительное число!");
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;

                    return;
                }

                dataGridView1[e.ColumnIndex, e.RowIndex].Value = outValue;
            }
            else if (e.ColumnIndex == 3) // проверка для четвертого столбца
            {
                int outValue;

                if (!int.TryParse(valueNeNull.ToString(), out outValue) || outValue <= 0)
                {
                    //MessageBox.Show("Введите натуральное число!");
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                }
            }
        }

        private void dataGridView2_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            var value = dataGridView2[e.ColumnIndex, e.RowIndex].Value;

            if (e.ColumnIndex == 0 || e.ColumnIndex == 1 || value == null)
            {
                return;
            }

            string valueNeNull = value.ToString();

            if (e.ColumnIndex == 2 || e.ColumnIndex == 3) // проверка для четвертого столбца
            {
                double outValue;
                if (!double.TryParse(valueNeNull.Replace(".", ","), out outValue) || outValue <= 0)
                {
                    //MessageBox.Show("Введите положительное число!");
                    dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = .1f;

                    return;
                }

                dataGridView2[e.ColumnIndex, e.RowIndex].Value = outValue;
            }
        }

        private void dataGridView3_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

            var value = dataGridView3[e.ColumnIndex, e.RowIndex].Value;

            if (e.RowIndex == 0 || e.RowIndex == 1 || e.RowIndex == 2 || e.RowIndex == 6 || value == null)
            {
                return;
            }

            string valueNeNull = value.ToString();

            double outValue;
            if (!double.TryParse(valueNeNull.Replace(".", ","), out outValue) || outValue < 0 || outValue > 1)
            {
                //MessageBox.Show("Введите положительное число!");
                dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = .1f;

                return;
            }

            dataGridView3[e.ColumnIndex, e.RowIndex].Value = outValue;
        }

        private void dataGridView4_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            var value = dataGridView4[e.ColumnIndex, e.RowIndex].Value;

            if (e.ColumnIndex == 0 || value == null)
            {
                return;
            }

            string valueNeNull = value.ToString();


            if (e.ColumnIndex == 1) // проверка для второго и третьего столбца
            {
                double outValue;

                if (!double.TryParse(valueNeNull.Replace(".", ","), out outValue) || outValue <= 0)
                {
                    //MessageBox.Show("Введите положительное число!");
                    dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;

                    return;
                }

                dataGridView4[e.ColumnIndex, e.RowIndex].Value = outValue;
            }
            else if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4) // проверка для четвертого столбца
            {
                int outValue;

                if (!int.TryParse(valueNeNull.ToString(), out outValue) || outValue <= 0)
                {
                    //MessageBox.Show("Введите натуральное число!");
                    dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                }
            }
        }

        private void dataGridView5_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            var value = dataGridView6[e.ColumnIndex, e.RowIndex].Value;

            if (e.RowIndex == 0 || e.RowIndex == 6 || value == null)
            {
                return;
            }

            string valueNeNull = value.ToString();

            double outValue;
            if (!double.TryParse(valueNeNull.Replace(".", ","), out outValue) || outValue < 0)
            {
                //MessageBox.Show("Введите положительное число!");
                dataGridView6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = .1f;

                return;
            }
        }

        private void dataGridView5_CellValidated_1(object sender, DataGridViewCellEventArgs e)
        {
            var value = dataGridView5[e.ColumnIndex, e.RowIndex].Value;

            if (e.ColumnIndex == 0 || e.ColumnIndex == 3  || value == null)
            {
                return;
            }

            string valueNeNull = value.ToString();

            if (e.ColumnIndex == 1)
            {
                double outValue;

                if (!double.TryParse(valueNeNull.Replace(".", ","), out outValue) || outValue < 0)
                {
                    //MessageBox.Show("Введите положительное число!");
                    dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = .1f;

                    return;
                }
            }
            else if (e.ColumnIndex == 2) // проверка для четвертого столбца
            {
                int outValue;

                if (!int.TryParse(valueNeNull.ToString(), out outValue) || outValue <= 0)
                {
                    //MessageBox.Show("Введите натуральное число!");
                    dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                }
            }
        }
    }
}
