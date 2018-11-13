using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            double days;
            double miles;
            double total;

            days = 20 * Convert.ToDouble(txtDays.Text);
            miles = .25 * Convert.ToDouble(txtMiles.Text);
            total = days + miles;

            lblReciept.Text = "Thank you for renting a car from Frank's car rentals! \n Your total is $" + total;


            


        }
    }
}
