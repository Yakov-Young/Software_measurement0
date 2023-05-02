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
    public partial class Task1Decision1 : Form
    {
        public Task1Decision1()
        {
            InitializeComponent();
        }

        private void Task1_Load(object sender, EventArgs e)
        {

            SetTable();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CoeffCollValidator())
            {
                MessageBox.Show("Сумма в столбце \"Коэффициент\" != 1.0");
                return;
            }

            double j1 = 0;
            double j2 = 0;

            double BjXj;
            int length = dataGridView1.RowCount;
            for (int i = 0; i < length; i++)
            {
                BjXj = Convert.ToDouble(dataGridView1[0, i].Value) * Convert.ToDouble(dataGridView1[1, i].Value);
                dataGridView1[3, i].Value = BjXj;
                j1 += BjXj;

                BjXj = Convert.ToDouble(dataGridView1[0, i].Value) * Convert.ToDouble(dataGridView1[2, i].Value);
                dataGridView1[4, i].Value = BjXj;
                j2 += BjXj;
            }

            textBox1.Text = j1.ToString();
            textBox2.Text = j2.ToString();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1 || dataGridView1[e.ColumnIndex, e.RowIndex].Value == null)
            {
                return;
            }

            var strValue = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString().Replace(".", ",");
            double value;
            
            bool isDouble = double.TryParse(strValue, out value);
            string error = "";

            if (isDouble)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = value;
            }
            else
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = null;
                error = "Значение не является числом";
                
            }
            
            if (e.ColumnIndex == 0 && value > 1)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = 0;
                error = "Коэффициент больше 1";
            }

            ShowError(error, e);
        }

        private void SetTable()
        {
            SetSetting();

            const int CountColumns = 5;
            const int CountRows = 9;

            dataGridView1.ColumnCount = CountColumns;
            dataGridView1.RowCount = CountRows;

            dataGridView1.RowHeadersWidth = 180;

            string[] headNameColunms = new string[CountColumns] {
                "Коэффициент весомости, Bj",
                "Проект, Xj",
                "Проект, Bj*Xj",
                "Аналог, Xj",
                "Аналог, Bj*Xj"
            };

            string[] headNameRows = new string[CountRows] {
                "Удобство работы",
                "Новизна",
                "Соответствие профилю деятельности",
                "Ресурсная эффективность",
                "Надежность",
                "Скорость доступа к данным",
                "Гибкость настройки",
                "Обучаемость персонала",
                "Соотношение стоимость/возможности"
            };


            dataGridView1.TopLeftHeaderCell.Value = "Показатель качества";
            for (int i = 0; i < CountColumns; i++)
            {
                dataGridView1.Columns[i].HeaderText = headNameColunms[i];
            }


            int height = 0;
            for (int i = 0; i < CountRows; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = headNameRows[i];

                height += dataGridView1.Rows[i].Height;
            }

            dataGridView1.Height = height + dataGridView1.ColumnHeadersHeight;
        }

        private void SetSetting()
        {
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
        }

        private bool CoeffCollValidator()
        {
            int length = dataGridView1.RowCount;
            double coeff = 0d;

            for (int i = 0; i < length; i++)
            {
                coeff += Convert.ToDouble(dataGridView1[0, i].Value);
            }

            if (coeff != 1)
            {
                return true;
            }

            return false;
        }

        private void ShowError(string error, DataGridViewCellEventArgs e)
        {
            if (error != "")
            {
                MessageBox.Show(error + $"({e.ColumnIndex}, {e.RowIndex})");
            }
        }
    }

    
}
