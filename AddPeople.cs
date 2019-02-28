using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroFirmProgramm
{
    public partial class AddPeople : Form
    {
        public AddPeople()
        {
            InitializeComponent();
            radioButtonClient.Checked = true;
            
        }

        private void Accessibility()
        {
            txtStartDate.ReadOnly = false;
            txtRoleid.ReadOnly = false;
            txtLogin.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtWage.ReadOnly = false;

        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {            
        }

        private void radioButtonClient_CheckedChanged(object sender, EventArgs e)
        {
            Accessibility();
            txtStartDate.ReadOnly = true;
            txtRoleid.ReadOnly = true;
            txtLogin.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtWage.ReadOnly = true;
        }

        private void radioButtonWorker_CheckedChanged(object sender, EventArgs e)
        {
            Accessibility();
            txtLogin.ReadOnly = true;
            txtLogin.ReadOnly = true;
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
