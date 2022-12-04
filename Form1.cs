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
        public Form1()
        {
            InitializeComponent();
        }



        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {

        }
    }
}
