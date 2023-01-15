using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VacaationPlanner
{
    public partial class Form1 : Form
    {
        private int CITYPRICE;
        private int ROOMPRICE;
        private int MEALPRICE;
        private int total;
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CITYPRICE = 175;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CITYPRICE = 150;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            CITYPRICE = 100;
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ROOMPRICE = 360;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ROOMPRICE = 420;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ROOMPRICE = 600;
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            MEALPRICE = 180;
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            MEALPRICE = 120;
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            MEALPRICE = 60;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            total = MEALPRICE + CITYPRICE + ROOMPRICE;

            Display.Visible = true;
            Display.Text = total.ToString("C");
        }
    }
}
