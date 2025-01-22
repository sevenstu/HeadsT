using System;
using System.Windows.Forms;

namespace HeadsTailsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowHeads_Click(object sender, EventArgs e)
        {
            // Display the heads image
            pictureBoxCoin.ImageLocation = @"Images/Heads1.bmp"; // Update path if necessary
        }

        private void btnShowTails_Click(object sender, EventArgs e)
        {
            // Display the tails image
            pictureBoxCoin.ImageLocation = @"Images/Tails1.bmp"; // Update path if necessary
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }
    }
}
