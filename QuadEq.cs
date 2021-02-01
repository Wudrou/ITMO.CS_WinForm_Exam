using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class QuadEq : Form
    {
        public QuadEq()
        {
            InitializeComponent();
            this.Size = new Size(400, 150);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(400, 200);

            try
            {
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                double c = Convert.ToDouble(textBoxC.Text);
                double d = b * b - 4 * a * c;

                if (d < 0)
                {
                    textBoxDecision.Text = "Дискриминант меньше нуля. Корней нет.";
                }

                if (d == 0)
                {
                    double x = (-b / (2 * a));
                    textBoxDecision.Text = "Дискриминант равен нулю. x = " + Math.Round(x, 2) + "";
                }

                if (d > 0)
                {
                    double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                    double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                    textBoxDecision.Text = "Дискриминант равен " + Math.Round(d, 2) + ". x₁ = " + Math.Round(x1, 2) + ". x₂ = " + Math.Round(x2, 2) + ".";
                }
            }
            catch
            {
                MessageBox.Show("ОШИБКА!!! Введенные Вами коэффициенты квадратного уравнения некорректны. Подсказка: квадратное уравнение имеет вид ax²+bx+c=0, где x - неизвестное, a,b,c - коэффициенты, причем a ≠ 0");
            }

        }

        private void textBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (key != 8) && (key != 44) && (key != 45))
            {
                e.Handled = true;
            }
        }

        private void textBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (key != 8) && (key != 44) && (key != 45))
            {
                e.Handled = true;
            }
        }

        private void textBoxC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (key != 8) && (key != 44) && (key != 45))
            {
                e.Handled = true;
            }
        }
    }
}
