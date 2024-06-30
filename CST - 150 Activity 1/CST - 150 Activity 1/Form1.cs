/*
 * Lindsey DeDecker
 * CST - 150
 * Activity 1 Part 3
 * June 30. 2024
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

namespace CST___150_Activity_1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //Hide the weight on mars labels
            lblMars.Visible = false;
            lblMarsWeight.Visible = false;
        }

        private void lblMars_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        /// <summary>
        /// Click Event for Convert Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertButtonClickEvent(object sender, EventArgs e)
        {
            //Declare and initialize
            decimal earthWeight = 0.0M;
            decimal finalValue = 0.0M;
            decimal gravAccEarth = 9.81M;
            decimal gravAccMars = 3.711M;

            //Reas in the earth weight
            earthWeight = Convert.ToDecimal(txtEarthWeight.Text);

            //Calculate the final value
            finalValue = (earthWeight / gravAccEarth) * gravAccMars;

            //Display the results
            //Use string format to format the string and show only 2 decimal places.
            //This is a string argument
            lblMarsWeight.Text = string.Format("{0:.##} lbs", finalValue);


            //Make sure to show the mars value and Label
            lblMars.Visible = true;
            lblMarsWeight.Visible = true;


        }
    }
}
