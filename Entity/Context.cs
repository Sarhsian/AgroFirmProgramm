using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroFirmProgramm.Entity
{
    public class Context:DbContext
    {
        public Context():base("AgrofirmDb")
        {

        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Client> Clients { get; set; }


    }
}
