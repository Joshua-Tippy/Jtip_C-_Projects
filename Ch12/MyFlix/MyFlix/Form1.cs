using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFlix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //vatriables
            double total;

            //constants
            const double PRICE = 1.99;

            //calculate
            total = MoviesShowsListBox.SelectedItems.Count * PRICE;

            //set visibility
            lblDisplay.Visible = true;

            //display
            lblDisplay.Text = "The price for " + MoviesShowsListBox.SelectedItems.Count + " items is $" + total;

        }
    }
}
