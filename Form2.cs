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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
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
           
            
            this.Hide();
            AddPeople addPeople = new AddPeople();
            addPeople.ShowDialog();
            this.Close();
            
        }
    }
}
