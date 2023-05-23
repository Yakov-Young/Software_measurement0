using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_measurement
{
    public partial class Task1Decision4 : Form
    {
        public static double salaryMain;
        public static double salaryAlt;
        public static double amorMain;
        public static double amorAlt;
        public static double energyMain;
        public static double energyAlt;
        public static double remMain;
        public static double remAlt;
        public static double materialCostMain = 0;
        public static double materialCostAlt = 0;
        public static double energyCost = double.MaxValue;

        public Task1Decision4()
        {
            if (Task1.DataGridOZP == null)
            {
                MessageBox.Show("Сначала выполните 3е задание");
                this.Close();

                return;
            }
            InitializeComponent();
        }

        private void Task1Decision4_Load(object sender, EventArgs e)
        {
            //dataGridView1 = Task1.DataGridOZP;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(0, 14);
            dataGridView1.Width = this.Width - 35;
            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[0].HeaderText = "Должность";
            dataGridView1.Columns[1].HeaderText = "Должностной оклад, руб.";
            dataGridView1.Columns[2].HeaderText = "Средняя дневная ставка руб./день";
            dataGridView1.Columns[3].HeaderText = "Затраты времени на эксплуатацию, человеко-дней";
            dataGridView1.Columns[4].HeaderText = "Фонд заработной платы, руб.";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;


            for (int row = 0; Task1.DataGridOZP[0, row].Value.ToString() != "Итого, руб."; row++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, row].Value = Task1.DataGridOZP[0, row].Value;
                dataGridView1[1, row].Value = Task1.DataGridOZP[1, row].Value;
                dataGridView1[2, row].Value = Task1.DataGridOZP[2, row].Value;
                dataGridView1[3, row].Value = Task1.DataGridOZP[3, row].Value;
            }

            SetZp(dataGridView1);

            textBox1.Text = Task1.Wd.ToString();
            textBox2.Text = Task1.Wc.ToString();

            label2.Location = new Point(20, dataGridView1.Bottom + 23);
            label3.Location = new Point(20, label2.Location.Y + 26);
            textBox1.Location = new Point(50, dataGridView1.Bottom + 20);
            textBox2.Location = new Point(50, textBox1.Location.Y + 26);

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;



            dataGridView2.Width = this.Width - 35;
            dataGridView2.ColumnCount = 5;

            dataGridView2.Columns[0].HeaderText = "Должность";
            dataGridView2.Columns[1].HeaderText = "Должностной оклад, руб.";
            dataGridView2.Columns[2].HeaderText = "Средняя дневная ставка руб./день";
            dataGridView2.Columns[3].HeaderText = "Затраты времени на эксплуатацию, человеко-дней";
            dataGridView2.Columns[4].HeaderText = "Фонд заработной платы, руб.";

            dataGridView2.Columns[4].ReadOnly = true;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;


            dataGridView3.Width = this.Width - 35;
            dataGridView3.ColumnCount = 7;

            dataGridView3.Columns[0].HeaderText = "Оборудование";
            dataGridView3.Columns[1].HeaderText = "Балансовая стоимость, руб.";
            dataGridView3.Columns[2].HeaderText = "Количество, ед.";
            dataGridView3.Columns[3].HeaderText = "Эффективный годовой фонд, час/год";
            dataGridView3.Columns[4].HeaderText = "Время работы тех. ср-ва, час/год";
            dataGridView3.Columns[5].HeaderText = "Норма годовых амортизационных отчислений, руб.";
            dataGridView3.Columns[6].HeaderText = "Сумма, руб.";

            for (int row = 0; Task1.DataGridMaterials[0, row].Value.ToString() != "Итого, руб."; row++)
            {
                dataGridView3.Rows.Add();
                dataGridView3[0, row].Value = Task1.DataGridOZP[0, row].Value;
                dataGridView3[1, row].Value = Task1.DataGridOZP[1, row].Value;
                dataGridView3[2, row].Value = Task1.DataGridOZP[2, row].Value;
                dataGridView3[3, row].Value = Task1.DataGridOZP[3, row].Value;
                dataGridView3[4, row].Value = Task1.DataGridOZP[4, row].Value;
            }

            dataGridView3.Columns[0].ReadOnly = true;
            dataGridView3.Columns[1].ReadOnly = true;
            dataGridView3.Columns[2].ReadOnly = true;
            dataGridView3.Columns[3].ReadOnly = true;
            dataGridView3.Columns[4].ReadOnly = true;
            dataGridView3.Columns[6].ReadOnly = true;

            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;


            dataGridView4.Width = this.Width - 35;
            dataGridView4.ColumnCount = 7;

            dataGridView4.Columns[0].HeaderText = "Оборудование";
            dataGridView4.Columns[1].HeaderText = "Балансовая стоимость, руб.";
            dataGridView4.Columns[2].HeaderText = "Количество, ед.";
            dataGridView4.Columns[3].HeaderText = "Эффективный годовой фонд, час/год";
            dataGridView4.Columns[4].HeaderText = "Время работы тех. ср-ва, час/год";
            dataGridView4.Columns[5].HeaderText = "Норма годовых амортизационных отчислений, руб.";
            dataGridView4.Columns[6].HeaderText = "Сумма, руб.";

            dataGridView4.Columns[6].ReadOnly = true;

            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;



            dataGridView5.Width = this.Width - 35;
            dataGridView5.ColumnCount = 6;

            dataGridView5.Columns[0].HeaderText = "Техническое средство";
            dataGridView5.Columns[1].HeaderText = "Время работы, час";
            dataGridView5.Columns[2].HeaderText = "Коэффициент использования установленной мощности оборудования";
            dataGridView5.Columns[3].HeaderText = "Тариф на электроэнергию, руб./кВт час";
            dataGridView5.Columns[4].HeaderText = "Мощность, кВт";
            dataGridView5.Columns[5].HeaderText = "Сумма, руб.";

            dataGridView5.Columns[3].ReadOnly = true;
            dataGridView5.Columns[5].ReadOnly = true;

            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView5.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;



            dataGridView6.Width = this.Width - 35;
            dataGridView6.ColumnCount = 6;

            dataGridView6.Columns[0].HeaderText = "Техническое средство";
            dataGridView6.Columns[1].HeaderText = "Время работы, час";
            dataGridView6.Columns[2].HeaderText = "Коэффициент использования установленной мощности оборудования";
            dataGridView6.Columns[3].HeaderText = "Тариф на электроэнергию, руб./кВт час";
            dataGridView6.Columns[4].HeaderText = "Мощность, кВт";
            dataGridView6.Columns[5].HeaderText = "Сумма, руб.";

            dataGridView6.Columns[3].ReadOnly = true;
            dataGridView6.Columns[5].ReadOnly = true;

            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView6.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;



            dataGridView7.Width = this.Width - 35;
            dataGridView7.ColumnCount = 6;

            dataGridView7.Columns[0].HeaderText = "Оборудование";
            dataGridView7.Columns[1].HeaderText = "Эффективный годовой фонд, час/год";
            dataGridView7.Columns[2].HeaderText = "Время работы тех. ср-ва, час/год";
            dataGridView7.Columns[3].HeaderText = "Тариф на электроэнергию, руб./кВт час";
            dataGridView7.Columns[4].HeaderText = "Затраты на текущий ремонт оборудования (коэф.)";
            dataGridView7.Columns[5].HeaderText = "Сумма, руб.";

            dataGridView7.Columns[3].ReadOnly = true;
            dataGridView7.Columns[5].ReadOnly = true;

            dataGridView7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView7.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            for (int row = 0; Task1.DataGridMaterials[0, row].Value.ToString() != "Итого, руб."; row++)
            {
                dataGridView7.Rows.Add();
                dataGridView7[0, row].Value = Task1.DataGridOZP[0, row].Value;
                dataGridView7[1, row].Value = Task1.DataGridOZP[3, row].Value;
                dataGridView7[2, row].Value = Task1.DataGridOZP[4, row].Value;
            }



            dataGridView8.Width = this.Width - 35;
            dataGridView8.ColumnCount = 6;

            dataGridView8.Columns[0].HeaderText = "Оборудование";
            dataGridView8.Columns[1].HeaderText = "Эффективный годовой фонд, час/год";
            dataGridView8.Columns[2].HeaderText = "Время работы тех. ср-ва, час/год";
            dataGridView8.Columns[3].HeaderText = "Тариф на электроэнергию, руб./кВт час";
            dataGridView8.Columns[4].HeaderText = "Затраты на текущий ремонт оборудования (коэф.)";
            dataGridView8.Columns[5].HeaderText = "Сумма, руб.";

            dataGridView8.Columns[3].ReadOnly = true;
            dataGridView8.Columns[5].ReadOnly = true;

            dataGridView8.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView8.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;



            dataGridView9.Width = this.Width - 35;
            dataGridView9.ColumnCount = 2;
            dataGridView9.RowCount = 7;

            dataGridView9.TopLeftHeaderCell.Value = "Статьи затрат";
            dataGridView9.Columns[0].HeaderText = "Затраты на проект, руб.";
            dataGridView9.Columns[1].HeaderText = "Затраты на аналог, руб.";

            dataGridView9.Rows[0].HeaderCell.Value = "Основная и дополнительная зарплата";
            dataGridView9.Rows[1].HeaderCell.Value = "Амортизационные отчисления";
            dataGridView9.Rows[2].HeaderCell.Value = "Затраты на электроэнергию";
            dataGridView9.Rows[3].HeaderCell.Value = "Затраты на текущий ремонт";
            dataGridView9.Rows[4].HeaderCell.Value = "Затраты на материалы";
            dataGridView9.Rows[5].HeaderCell.Value = "Накладные расходы";
            dataGridView9.Rows[6].HeaderCell.Value = "Итого";

            dataGridView9.RowHeadersWidth = dataGridView9.Width / 3;
            dataGridView9.Height = dataGridView9.Rows[0].Height * (dataGridView9.RowCount + 1);

            dataGridView9.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView9.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            for (int i = 0; i < dataGridView9.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView9.RowCount; j++)
                {
                    dataGridView9[i, j].Value = 0.ToString();
                }
            }


            dataGridView9[0, 0].Value = salaryMain.ToString();



            dataGridView2.Location = new Point(0, label3.Bottom + 40);
            label1.Location = new Point(0, 0);
            label4.Location = new Point(0, dataGridView2.Location.Y - 14);
            button1.Location = new Point(this.Width - button1.Width - 50, dataGridView2.Bottom + 20);
            button2.Location = new Point(button1.Location.X - button1.Width - 20, dataGridView2.Bottom + 20);

            dataGridView3.Location = new Point(0, button2.Bottom + 40);
            label5.Location = new Point(0, dataGridView3.Location.Y - 14);
            button4.Location = new Point(this.Width - button3.Width - 50, dataGridView3.Bottom + 20);
            button3.Location = new Point(button4.Location.X - button3.Width - 20, dataGridView3.Bottom + 20);

            dataGridView4.Location = new Point(0, button4.Bottom + 40);
            label6.Location = new Point(0, dataGridView4.Location.Y - 14);
            button6.Location = new Point(this.Width - button3.Width - 50, dataGridView4.Bottom + 20);
            button5.Location = new Point(button4.Location.X - button3.Width - 20, dataGridView4.Bottom + 20);

            dataGridView5.Location = new Point(0, button5.Bottom + 40);
            label7.Location = new Point(0, dataGridView5.Location.Y - 14);
            button8.Location = new Point(this.Width - button3.Width - 50, dataGridView5.Bottom + 20);
            button7.Location = new Point(button4.Location.X - button3.Width - 20, dataGridView5.Bottom + 20);

            dataGridView6.Location = new Point(0, button7.Bottom + 40);
            label8.Location = new Point(0, dataGridView6.Location.Y - 14);
            button10.Location = new Point(this.Width - button3.Width - 50, dataGridView6.Bottom + 20);
            button9.Location = new Point(button4.Location.X - button3.Width - 20, dataGridView6.Bottom + 20);

            dataGridView7.Location = new Point(0, button9.Bottom + 40);
            label9.Location = new Point(0, dataGridView7.Location.Y - 14);
            button12.Location = new Point(this.Width - button3.Width - 50, dataGridView7.Bottom + 20);
            button11.Location = new Point(button4.Location.X - button3.Width - 20, dataGridView7.Bottom + 20);

            dataGridView8.Location = new Point(0, button11.Bottom + 40);
            label10.Location = new Point(0, dataGridView8.Location.Y - 14);
            button14.Location = new Point(this.Width - button3.Width - 50, dataGridView8.Bottom + 20);
            button13.Location = new Point(button4.Location.X - button3.Width - 20, dataGridView8.Bottom + 20);

            dataGridView9.Location = new Point(0, button14.Bottom + 40);
            label11.Location = new Point(0, dataGridView9.Location.Y - 14);
            button15.Location = new Point(this.Width / 2 + button15.Width / 2, dataGridView9.Bottom + 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Enabled != false)
            {
                SetZp(dataGridView2);

                dataGridView9[1, 0].Value = salaryAlt.ToString();
            }
        }

        private void SetZp(DataGridView dataGridView)
        {
            try
            {

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
                    double days = double.Parse(row.Cells[3].Value.ToString());

                    double ozp = rate * days * (Task1.Wd + 1) * (Task1.Wc + 1);
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

            sum = Math.Round(sum, 3);

            cells[0].Value = "Итого, руб.";
            cells[countColumns - 1].Value = sum.ToString();

            for (int i = 0; i < countColumns; i++)
            {
                totalRow.Cells.Add(cells[i]);
            }

            dataGridView.Rows.Add(totalRow);


            if (dataGridView.Name == dataGridView1.Name)
            {
                salaryMain = sum;
            }
            else if (dataGridView.Name == dataGridView2.Name)
            {
                salaryAlt = sum;
            }
            else if (dataGridView.Name == dataGridView3.Name)
            {
                amorMain = sum;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    materialCostMain += Convert.ToDouble(row.Cells[1].Value);
                }
            }
            else if (dataGridView.Name == dataGridView4.Name)
            {
                amorAlt = sum;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    materialCostAlt += Convert.ToDouble(row.Cells[1].Value);
                }
            }
            else if (dataGridView.Name == dataGridView5.Name)
            {
                energyMain = sum;
            }
            else if (dataGridView.Name == dataGridView6.Name)
            {
                energyAlt = sum;
            }
            else if (dataGridView.Name == dataGridView7.Name)
            {
                remMain = sum;
            }
            else if (dataGridView.Name == dataGridView8.Name)
            {
                remAlt = sum;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            dataGridView2.Enabled = true;

            dataGridView9[1, 0].Value = 0.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Enabled != false)
            {
                SetSumAmor(dataGridView3);

                dataGridView9[0, 1].Value = amorMain.ToString();
                dataGridView9[0, 4].Value = (materialCostMain * 0.01).ToString();
            }
        }

        private void SetSumAmor(DataGridView dataGridView)
        {
            try
            {
                int countRow = dataGridView.RowCount - 1;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (countRow == row.Index && row.Index != 0)
                    {
                        continue;
                    }

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null || row.Cells[3].Value == null || row.Cells[4].Value == null || row.Cells[5].Value == null)
                    {
                        throw new Exception();
                    }

                    double res = Math.Round(Convert.ToDouble(row.Cells[1].Value)
                        * Convert.ToDouble(row.Cells[2].Value)
                        * Convert.ToDouble(row.Cells[4].Value)
                        * Convert.ToDouble(row.Cells[5].Value)
                        / Convert.ToDouble(row.Cells[3].Value), 3);
                    row.Cells[6].Value = res;
                }


                AddTotalRow(dataGridView);

                dataGridView.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка в {dataGridView.Name}. Обнаружены пустые значения");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells[0].Value.ToString() == "Итого, руб.")
                {
                    dataGridView3.Rows.Remove(row);

                }

                row.Cells[5].Value = null;
                row.Cells[6].Value = null;

                dataGridView3.Enabled = true;

                dataGridView9[0, 1].Value = 0.ToString();
                dataGridView9[0, 4].Value = 0.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView4.Enabled != false)
            {
                SetSumAmor(dataGridView4);

                dataGridView9[1, 1].Value = amorAlt.ToString();
                dataGridView9[1, 4].Value = (materialCostAlt * 0.01).ToString();
            }
        }

        private void SetSumEnergy(DataGridView dataGridView)
        {
            try
            {
                int countRow = dataGridView.RowCount - 1;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (countRow == row.Index && row.Index != 0)
                    {
                        continue;
                    }

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null || row.Cells[4].Value == null)
                    {
                        throw new Exception();
                    }

                    double res = Math.Round(Convert.ToDouble(row.Cells[1].Value)
                        * Convert.ToDouble(row.Cells[2].Value)
                        * Convert.ToDouble(row.Cells[4].Value)
                        * energyCost, 3);

                    row.Cells[5].Value = res;
                }


                AddTotalRow(dataGridView);
                dataGridView.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка в {dataGridView.Name}. Обнаружены пустые значения");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();

            dataGridView4.Enabled = true;

            dataGridView9[1, 1].Value = 0.ToString();
            dataGridView9[1, 4].Value = 0.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView5.Enabled != false)
            {
                if (energyCost == double.MaxValue)
                {
                    Form newForm = new EnergyCost();
                    newForm.ShowDialog();

                    dataGridView5[3, 0].Value = energyCost;
                    dataGridView6[3, 0].Value = energyCost;
                    dataGridView7[3, 0].Value = energyCost;
                    dataGridView8[3, 0].Value = energyCost;
                }

                SetSumEnergy(dataGridView5);

                dataGridView9[0, 2].Value = energyMain.ToString();
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            var tmp = dataGridView5[3, 0].Value;
            dataGridView5.Rows.Clear();

            dataGridView5[3, 0].Value = tmp;

            dataGridView5.Enabled = true;

            dataGridView9[0, 2].Value = 0.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView6.Enabled != false)
            {
                if (energyCost == double.MaxValue)
                {
                    Form newForm = new EnergyCost();
                    newForm.ShowDialog();

                    dataGridView5[3, 0].Value = energyCost;
                    dataGridView6[3, 0].Value = energyCost;
                    dataGridView7[3, 0].Value = energyCost;
                    dataGridView8[3, 0].Value = energyCost;
                }

                SetSumEnergy(dataGridView6);

                dataGridView9[1, 2].Value = energyMain.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var tmp = dataGridView6[3, 0].Value;
            dataGridView6.Rows.Clear();

            dataGridView6[3, 0].Value = tmp;

            dataGridView6.Enabled = true;

            dataGridView9[1, 2].Value = 0.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (dataGridView7.Enabled != false)
            {
                if (energyCost == double.MaxValue)
                {
                    Form newForm = new EnergyCost();
                    newForm.ShowDialog();

                    dataGridView5[3, 0].Value = energyCost;
                    dataGridView6[3, 0].Value = energyCost;
                    dataGridView7[3, 0].Value = energyCost;
                    dataGridView8[3, 0].Value = energyCost;
                }

                SetRem(dataGridView7);

                dataGridView9[0, 3].Value = remMain.ToString();
            }
        }

        private void SetRem(DataGridView dataGridView)
        {
            try
            {
                int countRow = dataGridView.RowCount - 1;

                foreach (DataGridViewRow row in dataGridView.Rows)
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
                        * Convert.ToDouble(row.Cells[3].Value)
                        * energyCost
                        / Convert.ToDouble(row.Cells[0].Value), 3);
                    row.Cells[5].Value = res;
                }


                AddTotalRow(dataGridView);
                dataGridView.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка в {dataGridView.Name}. Обнаружены пустые значения");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var tmp = dataGridView7[3, 0].Value;
            dataGridView7.Rows.Clear();

            dataGridView7[3, 0].Value = tmp;

            dataGridView7.Enabled = true;

            dataGridView9[0, 3].Value = 0.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (dataGridView8.Enabled != false)
            {
                if (energyCost == double.MaxValue)
                {
                    Form newForm = new EnergyCost();
                    newForm.ShowDialog();

                    dataGridView5[3, 0].Value = energyCost;
                    dataGridView6[3, 0].Value = energyCost;
                    dataGridView7[3, 0].Value = energyCost;
                    dataGridView8[3, 0].Value = energyCost;
                }

                SetRem(dataGridView8);

                dataGridView9[1, 3].Value = remAlt.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var tmp = dataGridView8[3, 0].Value;
            dataGridView8.Rows.Clear();

            dataGridView8[3, 0].Value = tmp;

            dataGridView8.Enabled = true;

            dataGridView9[1, 3].Value = 0.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView9[0, 5].Value = Convert.ToDouble(dataGridView9[0, 0].Value)
                    + Convert.ToDouble(dataGridView9[0, 1].Value)
                    + Convert.ToDouble(dataGridView9[0, 2].Value)
                    + Convert.ToDouble(dataGridView9[0, 3].Value)
                    + Convert.ToDouble(dataGridView9[0, 4].Value);

                dataGridView9[1, 5].Value = Convert.ToDouble(dataGridView9[1, 0].Value)
                    + Convert.ToDouble(dataGridView9[1, 1].Value)
                    + Convert.ToDouble(dataGridView9[1, 2].Value)
                    + Convert.ToDouble(dataGridView9[1, 3].Value)
                    + Convert.ToDouble(dataGridView9[1, 4].Value);

                double mainCost = 0;
                double altCost = 0;
                foreach (DataGridViewRow row in dataGridView9.Rows)
                {
                    mainCost += Convert.ToDouble(row.Cells[0].Value);
                    altCost += Convert.ToDouble(row.Cells[1].Value);
                }

                dataGridView9[0, 6].Value = mainCost * 0.2;
                dataGridView9[1, 6].Value = altCost * 0.2;
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка в {dataGridView9.Name}. Обнаружены пустые значения");
            }
        }

        private void dataGridView1and2_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            var value = dataGridView2[e.ColumnIndex, e.RowIndex].Value;

            if (e.ColumnIndex == 0 || e.ColumnIndex == 4 || value == null)
            {
                return;
            }

            string valueNeNull = value.ToString();

            if (e.ColumnIndex == 3)
            {
                int outValue;

                if (!int.TryParse(valueNeNull, out outValue) || outValue <= 0)
                {
                    //MessageBox.Show("Введите натуральное число!");
                    dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                }
            }
            else
            {
                double outValue;

                if (!double.TryParse(valueNeNull.Replace(".", ","), out outValue) || outValue < 0)
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

            if (e.ColumnIndex != 5 || value == null)
            {
                return;
            }

            string valueNeNull = value.ToString();

            double outValue;

            if (!double.TryParse(valueNeNull.Replace(".", ","), out outValue) || outValue < 0)
            {
                //MessageBox.Show("Введите положительное число!");
                dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;

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
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                int outValue;

                if (!int.TryParse(valueNeNull, out outValue) || outValue <= 0)
                {
                    //MessageBox.Show("Введите натуральное число!");
                    dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                }
            }
            else
            {
                double outValue;

                if (!double.TryParse(valueNeNull.Replace(".", ","), out outValue) || outValue < 0)
                {
                    //MessageBox.Show("Введите положительное число!");
                    dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;

                    return;
                }

                dataGridView4[e.ColumnIndex, e.RowIndex].Value = outValue;
            }

        }

        private void dataGridView5and6_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            var value = dataGridView[e.ColumnIndex, e.RowIndex].Value;

            if (e.ColumnIndex == 0 || e.ColumnIndex == 5 || value == null)
            {
                return;
            }

            string valueNeNull = value.ToString();

            if (e.ColumnIndex == 1)
            {
                int outValue;

                if (!int.TryParse(valueNeNull, out outValue) || outValue <= 0)
                {
                    //MessageBox.Show("Введите натуральное число!");
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                }
            }
            else if (e.ColumnIndex == 2)
            {
                double outValue;

                if (!double.TryParse(valueNeNull.Replace(".", ","), out outValue) || outValue <= 0 || outValue > 1)
                {
                    //MessageBox.Show("Введите натуральное число!");
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = .1f;

                    return;
                }

                dataGridView[e.ColumnIndex, e.RowIndex].Value = outValue;
            }
            else if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                double outValue;

                if (!double.TryParse(valueNeNull.Replace(".", ","), out outValue) || outValue < 0)
                {
                    //MessageBox.Show("Введите положительное число!");
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = .1f;

                    return;
                }

                dataGridView[e.ColumnIndex, e.RowIndex].Value = outValue;
            }
        }

        private void dataGridView5and6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Form newForm = new EnergyCost();

                newForm.ShowDialog();

                dataGridView5[3, 0].Value = energyCost;
                dataGridView6[3, 0].Value = energyCost;
                dataGridView7[3, 0].Value = energyCost;
                dataGridView8[3, 0].Value = energyCost;
            }
        }

        private void dataGridView7and8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Form newForm = new EnergyCost();

                newForm.ShowDialog();

                dataGridView5[3, 0].Value = energyCost;
                dataGridView6[3, 0].Value = energyCost;
                dataGridView7[3, 0].Value = energyCost;
                dataGridView8[3, 0].Value = energyCost;
            }
        }

        private void dataGridView7and8_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            var value = dataGridView[e.ColumnIndex, e.RowIndex].Value;

            if (e.ColumnIndex != 4 || value == null)
            {
                return;
            }

            string valueNeNull = value.ToString();

            double outValue;

            if (!double.TryParse(valueNeNull.Replace(".", ","), out outValue) || outValue <= 0 || outValue > 1)
            {
                //MessageBox.Show("Введите натуральное число!");
                dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = .1f;

                return;
            }

            dataGridView[e.ColumnIndex, e.RowIndex].Value = outValue;

        }
    }
}

