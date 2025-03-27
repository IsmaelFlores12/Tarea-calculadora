using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txbNum1.Text);
            int num2=Convert.ToInt32(txbnum2.Text);
            int suma = num1 + num2;

            MessageBox.Show($"La suma es {suma}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txbNum1.Text);
            int num2 = Convert.ToInt32(txbnum2.Text);
            int resta = num1 - num2;

            MessageBox.Show($"La resta es {resta}");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(txbNum1.Text);
            int num2 = Convert.ToInt32(txbnum2.Text);
            int multi = num1 * num2;

            MessageBox.Show($"La multiplicación es {multi}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txbNum1.Text);
            double num2=Convert.ToDouble(txbnum2.Text);
            double multi = num1 / num2;

            MessageBox.Show($"La división es {multi}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txbNum1.Text);
            int num2 = Convert.ToInt32(txbnum2.Text);
            int multi = num1 % num2;

            MessageBox.Show($" es {multi}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txbNum1.Text = "";
            txbnum2 .Text= "";
        }
    }
}
