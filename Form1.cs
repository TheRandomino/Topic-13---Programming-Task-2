using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_13___Programming_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radQ1A1.Checked)
            {
                grpQ1.Visible = false;
                lblQ1Result.Visible = true;
                lblQ1Result.Text = "Answer: X";
                grpQ2.Visible = true;
                lblInvalid.Visible = false;
            }
            else if (radQ1A2.Checked)
            {
                grpQ1.Visible = false;
                lblQ1Result.Visible = true;
                lblQ1Result.Text = "Answer: X";
                grpQ2.Visible = true;
                lblInvalid.Visible = false;
            }
            else if (radQ1A3.Checked)
            {
                grpQ1.Visible = false;
                lblQ1Result.Visible = true;
                lblQ1Result.Text = "Answer: ✓";
                grpQ2.Visible = true;
                lblInvalid.Visible = false;
            }
            else
            {
                lblInvalid.Visible = true;
            }
        }
    }
}
