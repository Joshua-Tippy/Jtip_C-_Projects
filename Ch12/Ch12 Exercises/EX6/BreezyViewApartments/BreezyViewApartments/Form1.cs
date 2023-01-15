using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreezyViewApartments
{
    public partial class Form1 : Form
    {
        private int BASEPRICE;
        private int BATHPRICE = 0;
        private int LAKEPRICE = 0;
        private int total;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            
            if (index == 0)
            {
                checkedListBox1.SetItemChecked(1, false);
                checkedListBox1.SetItemChecked(2, false);
                BASEPRICE = 450;
            }
            else if (index == 1)
            {
                checkedListBox1.SetItemChecked(2, false);
                checkedListBox1.SetItemChecked(0, false);
                BASEPRICE = 550;
            }
            else if (index == 2)
            {
                checkedListBox1.SetItemChecked(1, false);
                checkedListBox1.SetItemChecked(0, false);
                BASEPRICE = 700;
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox2.SelectedIndex;

            if (index == 0)
            {
                checkedListBox2.SetItemChecked(1, false);
                checkedListBox2.SetItemChecked(2, false);
                BATHPRICE = 0;
            }
            else if (index == 1)
            {
                checkedListBox2.SetItemChecked(2, false);
                checkedListBox2.SetItemChecked(0, false);
                BATHPRICE = 75;
            }
            else if (index == 2)
            {
                checkedListBox2.SetItemChecked(1, false);
                checkedListBox2.SetItemChecked(0, false);
                BATHPRICE = 75;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                LAKEPRICE = 50;
            else
                LAKEPRICE = 0;

            total = BASEPRICE + BATHPRICE + LAKEPRICE;
            Display.Visible = true;
            Display.Text = total.ToString("C");
        }
    }
}
