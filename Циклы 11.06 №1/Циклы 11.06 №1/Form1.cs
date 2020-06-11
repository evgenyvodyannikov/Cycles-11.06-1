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
            double s = Math.Sin(x);
            double right = 0, u = 1, dife;
            int n = 1;
            do
            {
                n++;
                right += u;
                u *= 1 - x * x / Math.Pow(n - 1, 2) * Math.PI * Math.PI;
                dife = s - right;
            }
            while (Math.Abs(dife) > E);
            MessageBox.Show("" + s + "  " + right + " " + n);
        }
	}
}
