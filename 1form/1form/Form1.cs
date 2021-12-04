using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1form
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
                Result.Text = "Результат: ";
                double x = Convert.ToDouble(textBox1.Text);
                Result.Text += ($"{func(x, 2) + func(x, 4) + func(x, 6)}");
            } catch (Exception)
            {
                Result.Text += " Ошибка ввода числа";
                MessageBox.Show(
                      "Число имеет некорректное значение!",
                      "Предупреждение",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning,
                      MessageBoxDefaultButton.Button3);
            }
        }

        static double func(double x, double n)
        {
            return (Math.Pow(x, n)) / n;
        }
    }
}
