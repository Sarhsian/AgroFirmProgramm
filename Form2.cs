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
           
            dataGridView1.DataSource = context.Workers.ToList();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Clients.ToList();

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Users.ToList();
        }
    }
}
