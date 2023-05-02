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
    public partial class Task1Decision2 : Form
    {
        public Task1Decision2()
        {
            InitializeComponent();
        }

        private void Task1Decision2_Load(object sender, EventArgs e)
        {
            SetTable();
        }

        private void SetTable()
        {
            SetSetting();

            const int CountColumns = 4;
            const int CountRows = 17;
            int countActor = 3;

            dataGridView1.ColumnCount = CountColumns;
            dataGridView1.RowCount = CountRows * countActor;

            dataGridView1.RowHeadersWidth = 180;

            string[] headNameColunms = new string[CountColumns] {
                "Исполнители",
                "Длительность, дни",
                "Начало работ",
                "Конец работ"
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
                while (countActor - 1 >= i)
                {

                    headNameRows.Insert(i + index, "");
                    i++;
                }
                index += countActor + 1;
            }


            dataGridView1.TopLeftHeaderCell.Value = "Содержание работы";
            for (int i = 0; i < CountColumns; i++)
            {
                dataGridView1.Columns[i].HeaderText = headNameColunms[i];
            }


            for (int i = 0; i < CountRows * countActor; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = headNameRows[i];
            }

            dataGridView1.Height = 400 + dataGridView1.ColumnHeadersHeight;
        }

        private void SetSetting()
        {
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
        }
    }
}
