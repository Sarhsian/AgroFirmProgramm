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
        User Users = new User();
        Client Clients = new Client();
        Worker Workers = new Worker();
        User eUser = new User();
        bool Update;
        int CurrId;
        public Form2() 
        {
            InitializeComponent();
            radioButtonClient.Checked = true;
            btnDelete.Enabled = false;
        }
        public Form2(bool Manager)
        {
            if(Manager == false)
            {
                InitializeComponent();
                radioButtonClient.Checked = true;
                radioButtonUser.Visible = false;
                btnDelete.Visible = false;
                btnUsers.Visible = false;
                label1.Text = "Manager Menu";
            }
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
            ShowWorkers();
            btnWorkers.BackColor = Color.DodgerBlue;
            btnClients.BackColor = Color.SteelBlue;
            btnUsers.BackColor = Color.SteelBlue;
            txtClear();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ShowClients();
            btnWorkers.BackColor = Color.SteelBlue;
            btnClients.BackColor = Color.DodgerBlue;
            btnUsers.BackColor = Color.SteelBlue;
            txtClear();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ShowUsers();
            btnWorkers.BackColor = Color.SteelBlue;
            btnClients.BackColor = Color.SteelBlue;
            btnUsers.BackColor = Color.DodgerBlue;
            txtClear();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                if (radioButtonWorker.Checked == true)
                {
                    Workers = new Worker
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
                }
                if (radioButtonClient.Checked == true)
                {
                    Clients = new Client
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
                    Users = new User
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
            }
            else
            {
                UpdateInfo();
            }

            context.SaveChanges();
            if (radioButtonClient.Checked == true) ShowClients();
            if (radioButtonUser.Checked == true) ShowUsers();
            if (radioButtonWorker.Checked == true) ShowWorkers();
            txtClear();

            MessageBox.Show("Submitted Successfully");
        }

        private void ShowWorkers()
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
        private void ShowClients()
        {
            dataGridView1.DataSource = context.Clients.ToList();
        }
        private void ShowUsers()
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtClear();
        }
        
        private void txtClear()
        {
            txtAddres.Text = txtDBirdth.Text = txtLogin.Text = txtMiddleName.Text = txtName.Text = txtSurname.Text =
                txtPassword.Text = txtStartDate.Text = txtPhonenum.Text = txtRoleid.Text = txtWage.Text = "";
            btnCreate.Text = "Create";
            btnDelete.Enabled = false;
            Update = false;
            radioButtonWorker.Enabled = true;
            radioButtonClient.Enabled = true;
            radioButtonUser.Enabled = true;
        }
        private void UpdateInfo()
        {
            if (radioButtonUser.Checked == true)
            {
                var User = context.Users.Where(u => u.Id == CurrId).FirstOrDefault();
                User.Login = txtLogin.Text;
                User.Password = txtPassword.Text;
                User.Name = txtName.Text;
                User.Surname = txtSurname.Text;
                User.MiddleName = txtMiddleName.Text;
                User.RoleId = Int32.Parse(txtRoleid.Text);
                User.StartDate = DateTime.Parse(txtStartDate.Text);
                User.DateBirdth = DateTime.Parse(txtDBirdth.Text);
            }
            if(radioButtonWorker.Checked == true)
            {
                var Worker = context.Workers.Where(w => w.Id == CurrId).FirstOrDefault();
                Worker.Name = txtName.Text;
                Worker.Surname = txtSurname.Text;
                Worker.MiddleName = txtMiddleName.Text;
                Worker.RoleId = Int32.Parse(txtRoleid.Text);
                Worker.Addres = txtAddres.Text;
                Worker.DateBirdth = DateTime.Parse(txtDBirdth.Text);
                Worker.StartDate = DateTime.Parse(txtStartDate.Text);
                Worker.Wage = Int32.Parse(txtWage.Text);
            }
            if(radioButtonClient.Checked == true)
            {
                var Client = context.Clients.Where(c => c.Id == CurrId).FirstOrDefault();
                Client.Name = txtName.Text;
                Client.Surname = txtSurname.Text;
                Client.MiddleName = txtMiddleName.Text;
                Client.PhoneNumber = Int32.Parse(txtPhonenum.Text);
                Client.Addres = txtAddres.Text;
                Client.DateBirdth = DateTime.Parse(txtAddres.Text);       
            }
            
            context.SaveChanges();

        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Index != -1)
            {
                CurrId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                if (dataGridView1[1,0].Value.ToString() == context.Users.ToList()[0].Name)
                {
                    var EditUser = context.Users.Select(t => new
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
                    }).Where(x => x.Id == CurrId).FirstOrDefault();
                    
                    txtName.Text = EditUser.Name.ToString();
                    txtSurname.Text = EditUser.Surname.ToString();
                    txtMiddleName.Text = EditUser.Middlename.ToString();
                    txtRoleid.Text = EditUser.RoleId.ToString();
                    txtDBirdth.Text = EditUser.DateBidrth.ToString();
                    txtStartDate.Text = EditUser.StartDate.ToString();
                    txtLogin.Text = EditUser.Login.ToString();
                    txtPassword.Text = EditUser.Password.ToString();

                    radioButtonUser.Checked = true;
                    radioButtonWorker.Enabled = false;
                    radioButtonClient.Enabled = false;
                }
                if (dataGridView1[1, 0].Value.ToString() == context.Workers.ToList()[0].Name.ToString())
                {
                    
                    var editWorker = context.Workers.Select(t => new
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
                    }).Where(x => x.Id == CurrId).FirstOrDefault();

                    txtName.Text = editWorker.Name.ToString();
                    txtSurname.Text = editWorker.Surname.ToString();
                    txtMiddleName.Text = editWorker.Middlename.ToString();
                    txtRoleid.Text = editWorker.RoleId.ToString();
                    txtDBirdth.Text = editWorker.DateBidrth.ToString();
                    txtStartDate.Text = editWorker.StartDate.ToString();
                    txtPhonenum.Text = editWorker.PhoneNumber.ToString();
                    txtAddres.Text = editWorker.Addres.ToString();
                    txtWage.Text = editWorker.Wage.ToString();

                    
                    radioButtonWorker.Checked = true;
                    radioButtonClient.Enabled = false;
                    radioButtonUser.Enabled = false;
                }
                if (dataGridView1[1, 0].Value.ToString() == context.Clients.ToList()[0].Name)
                {
                    var editClient = context.Clients.ToList().Where(x => x.Id == CurrId).FirstOrDefault();

                    txtName.Text = editClient.Name.ToString();
                    txtSurname.Text = editClient.Surname.ToString();
                    txtMiddleName.Text = editClient.MiddleName.ToString();
                    txtDBirdth.Text = editClient.DateBirdth.ToString();
                    txtPhonenum.Text = editClient.PhoneNumber.ToString();
                    txtAddres.Text = editClient.Addres.ToString();
                    
                    radioButtonWorker.Enabled = false;
                    radioButtonClient.Checked = true;
                    radioButtonUser.Enabled = false;
                }
                btnCreate.Text = "Update";
                btnDelete.Enabled = true;
                Update = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to delete this record ? ", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(radioButtonClient.Checked == true)
                {
                    context.Clients.Remove(context.Clients.Where(c => c.Id == CurrId).FirstOrDefault());
                    context.SaveChanges();
                    ShowClients();
                }
                if(radioButtonWorker.Checked == true)
                {
                    context.Workers.Remove(context.Workers.Where(c => c.Id == CurrId).FirstOrDefault());
                    context.SaveChanges();
                    ShowWorkers();
                }
                if (radioButtonUser.Checked == true)
                {
                    context.Users.Remove(context.Users.Where(c => c.Id == CurrId).FirstOrDefault());
                    context.SaveChanges();
                    ShowUsers();
                }
                txtClear();
                MessageBox.Show("Deleted Successfully");
            }
        }
    }
}
