using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarBudgetPlanner
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnExpandMenu_Click(object sender, EventArgs e)
        {
            if (pnlMainMenu.Visible)
            {
                pnlMainMenu.Visible = false;
                btnExpandMenu.Text = ">";
            }
            else
            {
                pnlMainMenu.Visible = true;
                btnExpandMenu.Text = "<";
            }
        }
    }
}
