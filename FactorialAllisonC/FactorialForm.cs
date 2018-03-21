/*
 * Created by: Allison Cook
 * Created on: 20 march, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program calculates the answer of the factorial of a given number
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialAllisonC
{
    public partial class frmFactorial : Form
    {
        //variables
        double factorialAnswer, factorialNumber, Counter;

        public frmFactorial()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //set counter to 0
            Counter = 0;

            //set answer to one
            factorialAnswer = 1;

            //clear list
            this.lstIncrements.Items.Clear();

            //see if they input a number
            try
            {
                factorialNumber = Convert.ToDouble(txtUserNumber.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number.");
            }

            if (factorialNumber > 0)
            {
                do
                {
                    //increment counter by one
                    Counter = Counter + 1;

                    //show the counter number to show number of increments
                    lstIncrements.Items.Add(Counter);

                    //multiply the counter by the answer
                    factorialAnswer = factorialAnswer * Counter;

                } while (Counter < factorialNumber);

                //convert answer to string
                lblanswer.Text = txtUserNumber.Text + "! = " + Convert.ToString(factorialAnswer);
            }
            else
            {
                MessageBox.Show("Please enter a positive number.");
            }

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program when clicked
            this.Close();
        }
    }
}
