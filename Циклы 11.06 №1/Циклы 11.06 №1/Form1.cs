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

		private void button1_Click(object sender, EventArgs e)
		{
            double.TryParse(textBox1.Text, out double x);
            double.TryParse(textBox2.Text, out double E);
            double right = 1, u = 1, dife;
            int n = 0;
            do
            {
                right *= u;
                if (n != 1)
                {
                    u *= 1 - x * x / (Math.Pow(n - 1, 2) * Math.PI * Math.PI);
                }
                n++;
            }
            while (E <= Math.Abs(Math.Sin(x) - right));
            MessageBox.Show("" + Math.Sin(x).ToString("f4") + "  " + right.ToString("f4") + " " + n);
        }
	}
}
