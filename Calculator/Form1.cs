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

        int FirstValue;
        int SecondValue;
        int plus;
        int minus;

        private void BtnNumberClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            lblPrinter.Text += button.Text;
            FirstValue = int.Parse(lblPrinter.Text);            
        }

        private void BtnOperationClick(object sender, EventArgs e)
        {
            var operation = sender as Button;
            lblPrinter.Text = string.Empty;

           
            SecondValue = int.Parse(lblPrinter.Text);

            if (operation.Text == "+")
            {
                plus = FirstValue + SecondValue;
            }
          

        }

        private void BtnClick()
        {
            Button[] buttons = new Button[10];
            buttons[0] = btn1;
            buttons[1] = btn2;
            buttons[2] = btn3;
            buttons[3] = btn4;
            buttons[4] = btn5;
            buttons[5] = btn6;
            buttons[6] = btn7;
            buttons[7] = btn8;
            buttons[8] = btn9;
            buttons[9] = btn0;

          
          
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            var equals = sender as Button;

         

            equals.Text = plus.ToString();

        }
    }
}
