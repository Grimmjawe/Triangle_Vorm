using System;
using System.Drawing;
using System.Windows.Forms;

namespace VytasTriangle
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 form)
        {
            form1 = form;
            InitializeComponent();
            this.FormClosed += (e, s) =>
            {
                form1.Close();
            };
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            Triangle triangle;
            double a, b, c;
            a = Convert.ToDouble((txtA.Text.Trim() != "") ? txtA.Text : "0");
            b = Convert.ToDouble((txtB.Text.Trim() != "") ? txtB.Text : "0");
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            if (txtC.Visible)
            {
                c = Convert.ToDouble((txtC.Text.Trim() != "") ? txtC.Text : "0");
                triangle = new Triangle(a, b, c);

                label4.Text = "Сторона a:";
                label5.Text = "Сторона b:";
                label6.Text = "Сторона c:";
                label7.Text = "Периметр:";
                label8.Text = "Площадь:";
                label9.Text = "Вожможен:";
                label10.Text = "Тип:";

                label17.Text = triangle.outputA();
                label16.Text = triangle.outputB();
                label15.Text = triangle.outputC();
                label14.Text = Convert.ToString(triangle.Permimeter());
                label13.Text = Convert.ToString(Math.Round(triangle.Surface(), 2));

                if (triangle.ExistTriangle)
                    label12.Text = "Да";
                else
                    label12.Text = "Нет";

                if (triangle.GetType() == 1)
                {
                    label11.Text = "равносторонний";
                    pictureBox1.Image = Image.FromFile(AppContext.BaseDirectory + "ravnostorpng.png");
                }
                else if (triangle.GetType() == 2)
                {
                    label11.Text = "равнобедренный";
                    pictureBox1.Image = Image.FromFile(AppContext.BaseDirectory + "ravnobedpng.png");
                }
            }
            else
            {
                triangle = new Triangle(a, b);

                label4.Text = "Сторона a:";
                label5.Text = "Высота h:";
                label6.Text = "Площадь:";

                label17.Text = triangle.outputA();
                label16.Text = triangle.outputH();
                label15.Text = Convert.ToString(Math.Round(triangle.Surface(), 2));
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://kilinskas19.thkit.ee");
        }
    }
}
