using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Циклы_11._06__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double x);
            double.TryParse(textBox2.Text, out double E);
            double right = 1, element = 1;
            int n = 0;
            do
            {
                if (n != 1)
                {
                    right *= element;
                    //element = 1 - x * x / (Math.Pow(n - 1, 2) * Math.PI * Math.PI);
                    element = Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / Factorial(2*n + 1);
                }
                n++;
            }
            while (E <= Math.Abs(Math.Sin(x) - right) || n <= 150);
            MessageBox.Show("" + Math.Sin(x).ToString("f4") + "  " + right.ToString("f4") + " " + n);
        }
	}
}
