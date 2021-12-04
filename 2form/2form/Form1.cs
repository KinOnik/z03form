using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = "Результат:";
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double h = double.Parse(textBoxH.Text);
                for (double i = a; i <= b; i += h)
                    result.Text += ($"\nf({i:f2})={f(Math.Abs(i)):f4}");
            }
            catch (Exception)
            {
                result.Text = "Результат: ошибка ввода";
                MessageBox.Show(
                      "Одно или более чисел имеет некорректное значение!",
                      "Предупреждение",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning,
                      MessageBoxDefaultButton.Button3);
            }
        }
        static double f(double x)
        { 
            if (x <= 1) return x * x - 1;
            else if (x <= 2) return 2 * x - 1;
            else return Math.Pow(x, 5) - 1;
        }
    }
}
