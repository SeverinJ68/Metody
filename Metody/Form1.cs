using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double vzdalenost(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));
        }

        private double Mocnina(double x, double y)
        {
            if (y < 0)
            {
                double x2 = Math.Abs(y);
                double mocnina2 = 1;
                for (int i = 0; i < x2; ++i)
                {
                    mocnina2 = mocnina2 * x;
                }
                return 1 / mocnina2;
            }
            else if (y == 0)
            {
                return 1;
            }
            else
            {
                double mocnina2 = 1;
                for (int i = 0; i < y; ++i)
                {
                    mocnina2 = mocnina2 * x;
                }
                return mocnina2;
            }

        }

        private double faktorial(double x)
        {
            double fak = 1;
            while (x > 0)
            {
                fak *= x;
                x--;
            }
            return fak;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);
            MessageBox.Show("Vzdalenost bodu je " + vzdalenost(x1, y1, x2, y2));
            MessageBox.Show("Mocnina prvnich dvou cisel je " + Mocnina(x1, y1));
            MessageBox.Show("Faktorial prvniho cisla je " + faktorial(x1));
        }
    }
}
