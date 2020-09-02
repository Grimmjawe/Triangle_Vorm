using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VytasTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            Triangle triangle;
            listView1.Items.Clear();
            double a, b, c;
            a = Convert.ToDouble(((txtA.Text.Trim() != "") ? txtA.Text : "0"));
            b = Convert.ToDouble(((txtB.Text.Trim() != "") ? txtB.Text : "0"));
            if(txtC.Visible)
            {
                c = Convert.ToDouble(txtC.Text);
                triangle = new Triangle(a, b, c);
                listView1.Items.Add("Сторона a");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона c");
                listView1.Items.Add("Периметр");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Вожможен");
                listView1.Items.Add("Тип");
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());
                listView1.Items[2].SubItems.Add(triangle.outputC());
                listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Permimeter()));
                listView1.Items[4].SubItems.Add(Convert.ToString(Math.Round(triangle.Surface(), 2)));
                if (triangle.ExistTriangle)
                    listView1.Items[5].SubItems.Add("Да");
                else
                    listView1.Items[5].SubItems.Add("Нет");

                if(triangle.GetType() == 1)
                {
                    listView1.Items[6].SubItems.Add("равносторонний");
                    pictureBox1.Image = Image.FromFile(AppContext.BaseDirectory + "ravnostorpng.png");
                }
                else if (triangle.GetType() == 2)
                {
                    listView1.Items[6].SubItems.Add("равнобедренный");
                    pictureBox1.Image = Image.FromFile(AppContext.BaseDirectory + "ravnobedpng.png");
                }
            }
            else
            {
                triangle = new Triangle(a, b);
                listView1.Items.Add("Сторона a");
                listView1.Items.Add("Высота h");
                listView1.Items.Add("Площадь");
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputH());
                listView1.Items[2].SubItems.Add(Convert.ToString(Math.Round(triangle.Surface(), 2)));
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Visible = true;
            label3.Visible = true;
            label2.Text = "Сторона B";
            if (!radioButton1.Checked)
                radioButton2.Checked = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Высота H";
            txtC.Visible = false;
            label3.Visible = false;
            if (!radioButton2.Checked)
                radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
