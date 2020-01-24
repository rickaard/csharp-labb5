using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bounce
{
    public partial class dialogForm : Form
    {
        public dialogForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (easyCheckBox.Checked)
            {
                Ball.easyWind = true;
                
            }
            else if (hardCheckBox.Checked)
            {
                Ball.easyWind = false;
                
            }
            else
            {
                MessageBox.Show("Du måste välja någon!");
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void easyCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (easyCheckBox.Checked)
            {
                hardCheckBox.Checked = false;
            }

        }

        private void hardCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (hardCheckBox.Checked)
            {
                easyCheckBox.Checked = false;
            }
                

        }

        private void dialogForm_Load(object sender, EventArgs e)
        {
            if (Ball.easyWind == true)
            {
                easyCheckBox.Checked = true;
                hardCheckBox.Checked = false;
            }
            else if (Ball.easyWind == false)
            {
                hardCheckBox.Checked = true;
                easyCheckBox.Checked = false;
            }
        }
    }
}
