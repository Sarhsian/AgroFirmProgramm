using AgroFirmProgramm.Entity;
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
        private Context context = new Context();
        public AddPeople()
        {
            InitializeComponent();
            radioButtonClient.Checked = true;
            radioButtonWorker.Enabled = false;
            radioButtonUser.Enabled = false;
            
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
            txtPassword.ReadOnly = true;          
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            Accessibility();
            txtWage.ReadOnly = true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButtonWorker.Checked == true)
            {
                Worker Workers = new Worker
                {                       
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    MiddleName = txtMiddleName.Text,
                    RoleId = Int32.Parse(txtRoleid.Text),
                    DateBirdth = DateTime.Parse(txtDBirdth.Text),
                    StartDate = DateTime.Parse(txtStartDate.Text),
                    PhoneNumber = Int32.Parse(txtPhonenum.Text),
                    Addres = txtAddres.Text,
                    Wage = Int32.Parse(txtWage.Text)
                };
                context.Workers.Add(Workers);
                context.SaveChanges();
            }
            if(radioButtonClient.Checked == true)
            {
                Client Clients = new Client
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    MiddleName = txtMiddleName.Text,
                    Addres = txtAddres.Text,
                    PhoneNumber = Int32.Parse(txtPhonenum.Text),
                    DateBirdth = DateTime.Parse(txtDBirdth.Text)
                };
                context.Clients.Add(Clients);
            }
            if(radioButtonUser.Checked == true)
            {
                User Users = new User
                {
                    Login = txtLogin.Text,
                    Password = txtPassword.Text,
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    MiddleName = txtMiddleName.Text,
                    RoleId = Int32.Parse(txtRoleid.Text),
                    DateBirdth = DateTime.Parse(txtDBirdth.Text),
                    StartDate = DateTime.Parse(txtStartDate.Text)
                };
                context.Users.Add(Users);
            }
            context.SaveChanges();
        }
    }
}
