using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //loop counter, initialized with 1
            int count = 1;

            //term is the number of times the user enters (number of iterations)

            int terms;

            decimal pi = 0;

            decimal sum;

            decimal negative = 1;

            decimal denominator = 1;

            if (int.TryParse(termsTextBox.Text, out terms))
            {
                while (count <= terms)
                {
                    sum = pi + negative * (4 / denominator);

                    pi = sum;

                    denominator += 2;
                    negative = negative * (-1);
                    count += 1;
                }
                outputLabel2.Text = "=" + " " + pi.ToString();
                termsLabel.Text = terms.ToString() + " " + "terms";
            }

            else
            {
                MessageBox.Show("Invalid value for terms");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
