using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Software_measurement
{

    public partial class Task1Decision2 : Form
    {
        string[] actorsName;
        public int countActor;

        List<double> workload = new List<double>();
        List<DateTime> startDates = new List<DateTime>();
        List<DateTime> endDates = new List<DateTime>();
        public Task1Decision2(string[] actorsValues)
        {
            InitializeComponent();
            this.actorsName = actorsValues;
            this.countActor = actorsValues.Length;
        }

        private void Task1Decision2_Load(object sender, EventArgs e)
        {
            SetTable();
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void SetTable()
        {
            SetSetting();

            const int CountColumns = 5;
            const int CountRows = 17;

            dataGridView1.ColumnCount = CountColumns;
            dataGridView1.RowCount = CountRows * countActor;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;


            dataGridView1.RowHeadersWidth = 180;

            string[] headNameColunms = new string[CountColumns] {
                "Исполнители",
                "Длительность, дни",
                "Начало работ",
                "Конец работ",
                "Загрузка"
            };

            List<string> headNameRows = new List<string> {
                "1. Постановка задачи",
                "2 Сбор исходных данных",
                "3 Анализ существующих методов решения задачи и программных средств",
                "4 Обоснование принципиальной необходимости разработки",
                "5 Определение и анализ требований к программе",
                "6 Определение структуры входных и выходных данных",
                "7 Выбор технических средств и программных средств реализации",
                "8 Согласование и утверждение технического задания",
                "9 Проектирование программной архитектуры",
                "10 Техническое проектирование компонентов программы",
                "11 Программирование модулей в выбранной среде программирования",
                "12 Тестирование программных модулей",
                "13 Сборка и испытание программы",
                "14 Анализ результатов испытаний",
                "15 Проведение расчетов показателей безопасности жизнедеятельности",
                "16 Проведение экономических расчетов",
                "17 Оформление пояснительной записки"
            };

            int index = 1;
            while (CountRows * countActor >= index)
            {
                int i = 0;
                while (countActor - 2 >= i)
                {

                    headNameRows.Insert(i + index, "");
                    i++;
                }
                index += i + 1;
            }

            dataGridView1.TopLeftHeaderCell.Value = "Содержание работы";
            for (int i = 0; i < CountColumns; i++)
            {
                dataGridView1.Columns[i].HeaderText = headNameColunms[i];
            }


            for (int i = 0; i < CountRows * countActor; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = headNameRows[i];
                dataGridView1[0, i].Value = actorsName[i % countActor];
                dataGridView1[1, i].Value = 1;
            }

            for (int i = 0; i < countActor; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, dataGridView1.RowCount - 1].Value = actorsName[i];
            }
            dataGridView1.Rows[dataGridView1.RowCount - countActor].HeaderCell.Value = "Итого по проекту";

            dataGridView1.Height = 400 + dataGridView1.ColumnHeadersHeight;
        }

        private void SetSetting()
        {
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }

            DataGridViewCell cell = dataGridView1[e.ColumnIndex, e.RowIndex];

            if (e.ColumnIndex == 1)
            {
                СheckInt(cell);
                return;
            }
        }

        private void СheckInt(DataGridViewCell cell)
        {
            var cellValue = cell.Value.ToString();
            bool isInt = int.TryParse(cellValue, out int value);

            if (!isInt)
            {
                cell.Value = "0";
                MessageBox.Show($"Значение ({cell.ColumnIndex}, {cell.RowIndex}) не является целочисленным");
            }
            else if (value < 0)
            {
                cell.Value = "0";
                MessageBox.Show($"Значение ({cell.ColumnIndex}, {cell.RowIndex}) не является положительным");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isDate = СheckDate();

            if (isDate)
            {
                List<int> dateDiff = new List<int>();
                List<int> duration = new List<int>();

                startDates.Clear();
                endDates.Clear();
                workload.Clear();

                DateTime startDate;
                startDate = DateTime.Parse(textBox1.Text);

                DateTime endDate;

                for (int i = 0; i < dataGridView1.RowCount - countActor; i++)
                {
                    startDates.Add(startDate);

                    endDate = startDate.AddDays(double.Parse(dataGridView1[1, i].Value.ToString()));
                    endDates.Add(endDate);

                    dateDiff.Add(Convert.ToInt32((endDate - startDate).TotalDays));


                    if (i % countActor == countActor - 1)
                    {
                        startDate = endDates.Max();
                        List<int> tmp = new List<int>();

                        for (int j = 0; j < countActor; j++)
                        {
                            tmp.Add(int.Parse(dataGridView1[1, i - j].Value.ToString()));
                        }

                        duration.Add(tmp.Max());
                    }
                }

                int v = 0;
                for (int i = 0; i < dataGridView1.RowCount - countActor; ++i)
                {
                    workload.Add(dateDiff[i] / Convert.ToDouble(duration[v]));

                    if (i % countActor == countActor - 1 && i != dataGridView1.RowCount - 1)
                    {
                        v += 1;
                    }
                }

                FillTable();

                for (int i = 0; i < countActor; ++i)
                {
                    double itemOfstaffWorkload = 0;

                    for (int j = 0; j < dataGridView1.RowCount - countActor; j += countActor)
                    {
                        itemOfstaffWorkload += Convert.ToDouble(dataGridView1[1, i + j].Value);
                    }

                    dataGridView1[4, dataGridView1.RowCount - countActor + i].Value = Math.Round(itemOfstaffWorkload / duration.Sum(), 3);
                    dataGridView1[1, dataGridView1.RowCount - countActor + i].Value = itemOfstaffWorkload;
                }

                textBox2.Text = duration.Sum().ToString();


                AddTotalRow();
            }
            else
            {
                MessageBox.Show("Начальная дата не распознана");
            }
        }

        private void FillTable()
        {
            for (int i = 0; i < dataGridView1.RowCount - countActor; i++)
            {
                dataGridView1[2, i].Value = startDates[i];
                dataGridView1[3, i].Value = endDates[i];
                dataGridView1[4, i].Value = workload[i];
            }
        }

        private bool СheckDate()
        {
            DateTime date;
            bool isDate = DateTime.TryParse(textBox1.Text, out date);

            if (!isDate)
            {
                return false;
            }

            return true;
        }

        private void AddTotalRow()
        {

        }
    }
}
