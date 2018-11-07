using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
            num1 = Convert.ToInt32(txtInput1.Text);
            num2 = Convert.ToInt32(txtInput2.Text);

            sum = num1 + num2;
            lblResult.Text = "The sum is " + sum;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sub;
            num1 = Convert.ToInt32(txtInput1.Text);
            num2 = Convert.ToInt32(txtInput2.Text);

            sub = num1 - num2;
            lblSub.Text = "The answer is " + sub;

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int multi;
            num1 = Convert.ToInt32(txtInput1.Text);
            num2 = Convert.ToInt32(txtInput2.Text);

            multi = num1 * num2;
            lblMulti.Text = "The product is " + multi;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int div;
            num1 = Convert.ToInt32(txtInput1.Text);
            num2 = Convert.ToInt32(txtInput2.Text);

            div = num1 / num2;
            lblDiv.Text = "The quotient is " + div;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int mod;
            num1 = Convert.ToInt32(txtInput1.Text);
            num2 = Convert.ToInt32(txtInput2.Text);

            mod = num1 % num2;
            lblMod.Text = "The remainder is " + mod;
        }
    }
}
