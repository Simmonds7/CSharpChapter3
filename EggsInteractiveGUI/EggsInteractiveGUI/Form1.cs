using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int chik1;
            int chik2;
            int chik3;
            int chik4;
            int chik5;
            int total;
            int dozens;
            int remain;


            chik1 = Convert.ToInt32(txtChik1.Text);
            chik2 = Convert.ToInt32(txtChik2.Text);
            chik3 = Convert.ToInt32(txtChik3.Text);
            chik4 = Convert.ToInt32(txtChik4.Text);
            chik5 = Convert.ToInt32(txtChik5.Text);
            total = chik1 + chik2 + chik3 + chik4 + chik5;
            dozens = total / 12;
            remain = total % 12;

            lblTotal.Text = "Oh lawd! Thats a lotta eggs! \n" + total + " eggs is " + dozens + " dozen with " + remain + " eggs remaining";
        }
    }
}
