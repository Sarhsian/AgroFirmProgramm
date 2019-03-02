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
    public partial class Form2 : Form
    {
        Context context = new Context();
        public Form2()
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
        private void btnWorkers_Click(object sender, EventArgs e)
        {

            var Workers = context.Workers.Select(t => new
            {
                Id = t.Id,
                Name = t.Name,
                Surname = t.Surname,
                Middlename = t.MiddleName,
                RoleId = t.RoleId,
                DateBidrth = t.DateBirdth,
                StartDate = t.StartDate,
                EndDate = t.EndDate,
                PhoneNumber = t.PhoneNumber,
                Addres = t.Addres,
                Wage = t.Wage
            });
            dataGridView1.DataSource = Workers.ToList();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = context.Clients.ToList();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var Users = context.Users.Select(t => new
            {
                Id = t.Id,
                Name = t.Name,
                Surname = t.Surname,
                Middlename = t.MiddleName,
                RoleId = t.RoleId,
                Login = t.Login,
                Password = t.Password,
                DateBidrth = t.DateBirdth,
                StartDate = t.StartDate,
                EndDate = t.EndDate
            });
            dataGridView1.DataSource = Users.ToList();            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            

            if (radioButtonWorker.Checked == true)
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
            if (radioButtonClient.Checked == true)
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
            if (radioButtonUser.Checked == true)
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
    }
}
