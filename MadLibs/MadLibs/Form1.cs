using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string color;
            string wordEst;
            string bodyPlural;
            string animal;
            string noun;
            string nounPlural;
            int num1;
            int num2;
            int num3;



            color = txtColor.Text;
            wordEst = txtWordEst.Text;
            bodyPlural = txtBodyPlural.Text;
            animal = txtAnimal.Text;
            noun = txtNoun.Text;
            nounPlural = txtPluralNoun.Text;

            num1 = Convert.ToInt32(txtNum1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);
            num3 = num1 - num2;

            lblStory.Text = "The " + color + " dragon is the " + wordEst + " dragon of all. It has " + num3 + " " + bodyPlural + ", and a " + animal + " shaped like a " + noun + ". It loves to eat " + nounPlural + ", although it will feast on nearly anything.";

            this.BackColor = Color.FromName(color);



        }
    }
}
