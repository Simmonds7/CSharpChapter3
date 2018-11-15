using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double oldContest;
            double newContest;
            double revenue;

            oldContest = Convert.ToDouble(txtContest1.Text);
            newContest = Convert.ToDouble(txtContest2.Text);
            revenue = newContest * 25;

            if (newContest > oldContest)
            {
                lblResult.Text = "Your expected Revenue is $" + revenue + ".\n This years number of contestants is greater than last years.";
            } 
            else
            {
                lblResult.Text = "Your expected Revenue is $" + revenue + ".\n This years number of contestants is less than last years.";
            }
        }
    }
}
