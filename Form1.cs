using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectOOP_Calculator
{
    public partial class Form1 : Form
    {
        Double resultNum = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }



        private void button_click(object sender, EventArgs e)
        {
            if( txtDisplay.Text == "0" || (isOperationPerformed))
            {
                txtDisplay.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + button.Text;
                }
            }
            else
            {
                txtDisplay.Text += button.Text;
            }

        }

        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(resultNum != 0)
            {
                btnEquals.PerformClick();
                operationPerformed = button.Text;
                resultNum = Double.Parse(txtDisplay.Text);
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultNum = Double.Parse(txtDisplay.Text);
                isOperationPerformed = true; 
            }

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            resultNum = 0;

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    txtDisplay.Text = (resultNum + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (resultNum - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "x":
                    txtDisplay.Text = (resultNum * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (resultNum / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                default:
                    break;


            }
            resultNum = Double.Parse(txtDisplay.Text);

        }
    }
}
