using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            decimal test1;
            decimal test2;
            decimal test3;
            decimal test4;
            decimal test5;
            decimal 

            test1 = Convert.ToDecimal(txtScore1.Text);
            test2 = Convert.ToDecimal(txtScore2.Text);
            test3 = Convert.ToDecimal(txtScore3.Text);
            test4 = Convert.ToDecimal(txtScore4.Text);
            test5 = Convert.ToDecimal(txtScore5.Text);


        }
    }
}
