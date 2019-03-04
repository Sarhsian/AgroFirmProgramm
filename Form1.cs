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
    public partial class Form1 : Form
    {

        public Context context = new Context();
        public User enteredUser { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var Users = context.Users.ToList();
            int UserInd = 0;
            string CheckLog = "null";
            string CheckPas = "null";
            bool Passed = false;
            for (int i = 0; i < Users.Count(); i++)
            {
                if (txtLogin.Text == Users[i].Login && txtPassword.Text == Users[i].Password)
                {
                    CheckLog = Users[i].Login;
                    CheckPas = Users[i].Password;
                    UserInd = i;
                    Passed = true;
                    enteredUser = context.Users.FirstOrDefault(u => u.Id == i);
                    break;
                }
            }
            if (Passed == true)
            {
                if (Users[UserInd].RoleId == 1)
                {
                    MessageBox.Show(Users[UserInd].Name + " " + Users[UserInd].MiddleName + ", you entered the system!");

                    Form2 MenuWind = new Form2();
                    this.Hide();
                    MenuWind.ShowDialog();
                    this.Close();
                }else
                {
                    MessageBox.Show(Users[UserInd].Name + " " + Users[UserInd].MiddleName + ", you entered the system!");

                    ManagerMenu managerMenu = new ManagerMenu();
                    this.Hide();
                    managerMenu.ShowDialog();
                    this.Close();
                }
               
            }
            else
            {
                MessageBox.Show("Wrong Login or Password!");
            }

            
        }
    }
}
