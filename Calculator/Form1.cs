using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblPrinter.Text = string.Empty;

        }
        string FirstValue;
        string SecondValue;
        char sign = ' ';

        private void btn7_Click(object sender, EventArgs e)
        {
            Formula(7);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Formula(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Formula(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Formula(3);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            sign = '+';
            lblPrinter.Text = string.Empty;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            sign = '-';
            lblPrinter.Text = string.Empty;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Formula(6);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Formula(5);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Formula(4);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Formula(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Formula(9);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (sign)
            {
                case('+'):
                    lblPrinter.Text = (int.Parse(FirstValue) + int.Parse(SecondValue)).ToString();
                    break;

                case ('-'):
                    lblPrinter.Text = (int.Parse(FirstValue) - int.Parse(SecondValue)).ToString();
                    break;
            }
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            FirstValue = string.Empty;
            SecondValue = string.Empty;
            sign = ' ';
            lblPrinter.Text = string.Empty;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Formula(0);
        }

        private void Formula(int number)
        {
            if (sign == ' ')
            {
                FirstValue += number;
                lblPrinter.Text = FirstValue;
            }
            else
            {
                SecondValue += number;
                lblPrinter.Text = SecondValue;
            }
           
        }
    }
}