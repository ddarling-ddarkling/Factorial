using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class FactorialForm : Form
    {
        public FactorialForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = System.Convert.ToInt16(textBox1.Text);
            int f = 1;                                                   // где f - факториал числа а

            if ( a > 0)
            {
                for (int i = 1; i < a; i++)
                {
                    f = f * (i + 1);
                }
            label2.Text = "Факториал от " + textBox1.Text + " = " + System.Convert.ToString(f);
            }
            else
            {
                label2.Text = "Ошибка! Введите другое число!";
            }         
        }
    }
}
