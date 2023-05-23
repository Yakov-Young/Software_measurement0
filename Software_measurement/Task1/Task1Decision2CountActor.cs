using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Software_measurement
{
    public partial class Task1Decision2CountActor : Form
    {
        List<TextBox> actors = new List<TextBox>();
        string[] actorsValues;
        public Task1Decision2CountActor()
        {
            InitializeComponent();
            this.AutoSize = true;

            Label actorLabel = new Label();

            actorLabel.Text = "Исполнители";
            actorLabel.Location = new Point(57, 159);
            actorLabel.Size = new Size(120, 20);
            actorLabel.Font = label1.Font;
            this.Controls.Add(actorLabel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckValue())
            {
                int countActor = int.Parse(textBox1.Text);

                RemoveTextBox();

                Point locationTxtBox = new Point(62, 199);

                for (int i = 0; i < countActor; i++)
                {
                    TextBox actor = new TextBox();

                    actor.Location = locationTxtBox;
                    actor.Size = textBox1.Size;

                    locationTxtBox.Y += 26;

                    actors.Add(actor);
                    this.Controls.Add(actors[i]);
                    actors[i].Show();
                }

                ChangeLocationButton2();
            }
            else
            {
                MessageBox.Show("Значение равно 0");
                textBox1.Text = "1";
            }
            
            

            /*Form newForm = new Task1Decision2(countActor);
            
            this.Close();
            newForm.ShowDialog();*/

        }

        private void ChangeLocationButton2()
        {
            Point locationButton = button1.Location;
            locationButton.Y = actors[actors.Count - 1].Location.Y + 41;

            button2.Text = "Далее";
            button2.Location = locationButton;
            button2.Size = button1.Size;
            button2.Visible = true;
        }

        private bool CheckValue()
        {
            int tmp = int.Parse(textBox1.Text);
            if (tmp == 0)
            {
                return false;
            }
            return true;
        }

        private void RemoveTextBox()
        {
            for (int i = actors.Count - 1; i >= 0; i--)
            {
                this.Controls.Remove(actors[i]);
                actors.RemoveAt(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckValueOnEmpty())
            {
                Form newForm = new Task1Decision2(actorsValues);

                this.Close();
                newForm.ShowDialog();
            }
            else
            {

                MessageBox.Show("Одно или более поле не содержит значения");
            }
        }

        private bool CheckValueOnEmpty()
        {
            int length = actors.Count;
            actorsValues = new string[length];
            for (int i = 0; i < length; i++)
            {
                actorsValues[i] = actors[i].Text;
            }
            if (actorsValues.Contains(""))
            {
                return false;
            }
            return true;
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
                return;
            }

            var strValue = textBox1.Text;
            bool isInt = int.TryParse(strValue, out _);

            if (!isInt)
            {
                textBox1.Text = "1";
            }
        }
    }
}
