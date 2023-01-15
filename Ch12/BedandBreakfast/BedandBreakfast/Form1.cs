using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedandBreakfast
{
    public partial class BaileysForm : Form
    {
        public BaileysForm()
        {
            InitializeComponent();
        }

        

        private void belleAireCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (belleAireCheckbox.Checked)
            {
                BelleAireForm bellAireForm = new BelleAireForm();
                bellAireForm.ShowDialog();
                belleAireCheckbox.Checked = false;
            }
        }

        private void lincolnCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (lincolnCheckbox.Checked)
            {
                LincolnForm lincolnForm = new LincolnForm();
                lincolnForm.ShowDialog();
                lincolnCheckbox.Checked = false;
            }
        }

        private void mealButton_Click(object sender, EventArgs e)
        {
            BreakfastOptionForm breakfastOptionForm = new BreakfastOptionForm();
            breakfastOptionForm.ShowDialog();
        }
    }
}
