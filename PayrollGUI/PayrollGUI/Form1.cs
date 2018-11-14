using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string name;
            double socialSecure;
            double hourlyPay;
            double hours;
            double gross;
            double fedWithhold;
            double stateWithhold;
            double netPay;


            name = txtName.Text;
            socialSecure = Convert.ToDouble(txtSocialSecure.Text);
            hourlyPay = Convert.ToDouble(txtHourlyPayRate.Text);
            hours = Convert.ToDouble(txtHours.Text);

            gross = hourlyPay * hours;
            fedWithhold = .15 * gross;
            stateWithhold = .05 * gross;
            netPay = gross - fedWithhold - stateWithhold;

            lblPrint.Text = "" + name + "\n SSN: " + socialSecure + "\n Hourly Pay Rate is $" + hourlyPay + "\n Work Time was " + hours + "\n Your Gross Pay is $" + Math.Round(gross, 2) + "\n Your Federal Withholding Tax is $" + Math.Round(fedWithhold, 2) + "\n Your State Withholding Tax is $" + Math.Round(stateWithhold, 2) + "\n Your Net Pay is $" + Math.Round(netPay, 2);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
