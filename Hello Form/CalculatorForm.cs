using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        CalcModel model;
        public CalculatorForm()
        {
            model = new CalcModel();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            model.reset();
        }

        private void buttonPress(object sender, EventArgs e)
        {
            Console.WriteLine("BUTTON PRESSED!");
            Console.WriteLine("TEXT: " + textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(model.Operation == '0')
            {
                model.X += "1";
                textBox1.Text += "1";
            }else
            {
                model.Y += "1";
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (model.Operation == '0')
            {
                model.X += "2";
                textBox1.Text += "2";
            }
            else
            {
                model.Y += "2";
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (model.Operation == '0')
            {
                model.X += "3";
                textBox1.Text += "3";
            }
            else
            {
                model.Y += "3";
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (model.Operation == '0')
            {
                model.X += "4";
                textBox1.Text += "4";
            }
            else
            {
                model.Y += "4";
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (model.Operation == '0')
            {
                model.X += "5";
                textBox1.Text += "5";
            }
            else
            {
                model.Y += "5";
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (model.Operation == '0')
            {
                model.X += "6";
                textBox1.Text += "6";
            }
            else
            {
                model.Y += "6";
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (model.Operation == '0')
            {
                model.X += "7";
                textBox1.Text += "7";
            }
            else
            {
                model.Y += "7";
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (model.Operation == '0')
            {
                model.X += "8";
                textBox1.Text += "8";
            }
            else
            {
                model.Y += "8";
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (model.Operation == '0')
            {
                model.X += "9";
                textBox1.Text += "9";
            }
            else
            {
                model.Y += "9";
                textBox1.Text += "9";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (model.Operation == '0')
            {
                model.parseX();
                model.Operation = '+';
                textBox1.Text += " + ";
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (model.Operation == '0')
            {
                model.parseX();
                model.Operation = '-';
                textBox1.Text += " - ";
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (model.Operation == '0')
            {
                model.parseX();
                model.Operation = '*';
                textBox1.Text += " * ";
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (model.Operation == '0')
            {
                model.parseX();
                model.Operation = '/';
                textBox1.Text += " / ";
            }
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            model.parseY();
            int result = model.performOperation();
            textBox1.Text = result.ToString() + " ";
            model.reset();
            model.X = result.ToString();
            model.parseX();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            model.reset();
            textBox1.Text = "";
        }
    }
}
