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
        String operationDone = "";
        bool OperationDone = false;

        public Form1()
        {
            InitializeComponent();
        }



        private void button_click(object sender, EventArgs e)
        {
            

            Button number = (Button)sender;
            if (txtPreview.Text.Contains("="))
            {
                txtPreview.Clear();
                txtDisplay.Clear();
                resultNum = 0;
            }
            if (txtDisplay.Text == "0" || OperationDone)
            {
                txtDisplay.Clear();
            }
            OperationDone = false;
            if (number.Text == ".")
            {
                if (txtDisplay.Text.Contains(".") == false)
                {
                    txtDisplay.Text += ".";
                    
                }
            }
            else
            {
                txtDisplay.Text += number.Text;
                
            }

                

            
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button operation = (Button)sender;
            txtPreview.Text = txtDisplay.Text;
            txtPreview.Text += operation.Text;
            if (resultNum != 0)
            {
                btnEquals.PerformClick();
                operationDone = operation.Text;
                resultNum = Double.Parse(txtDisplay.Text);
                OperationDone = true;
            }
            else
            {
                operationDone = operation.Text;
                resultNum = Double.Parse(txtDisplay.Text);
                OperationDone = true;
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtPreview.Text = "";
            resultNum = 0;

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            
            txtPreview.Text += txtDisplay.Text + "=";
            switch (operationDone)
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