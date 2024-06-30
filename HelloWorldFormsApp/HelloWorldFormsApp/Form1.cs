/*
 * Lindsey DeDecker
 * CST - 150
 * June 30, 2024
 * Activity 1 Part 2
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

namespace HelloWorldFormsApp
{
    public partial class HelloWorldApp : Form
    {
        public HelloWorldApp()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Create an event handler for the click here button
        /// Method name must be ParscalCasing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOnClick(object sender, EventArgs e)
        {
            lblHelloWorldLabel.Text = "Hello World!!!";
        }
    }
}
