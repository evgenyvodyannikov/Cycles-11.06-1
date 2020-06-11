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
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Член ряда", "Член ряда");
            double.TryParse(textBox1.Text, out double x);
            double.TryParse(textBox2.Text, out double E);
            double right = 1, element = 1;
            int n = 0, k = 0;
            do
            {
                if (n == 1)
                    n = 2;
                element = 1 - x * x / (Math.Pow(n - 1, 2) * Math.PI * Math.PI);
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[k].Cells[0].Value = element;
                n++;
                k++;
            }
            while (E <= Math.Abs(Math.Sin(x)) - element);
            MessageBox.Show("Sin(x) = " + Math.Sin(x).ToString("f4") + "\nБлижайший член ряда: " + element.ToString("f4") + "\nКол-во итераций: " + k);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (tb.Text.Length == 3 && tb.Text.Length <= 3)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == ',')
            {
                if ((tb.Text.IndexOf(',') != -1) || (tb.Text.Length == 0)) 
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = true;
            }
            else
            { button1.Enabled = false; }
        }
    }
}
