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
        DbSet<Role> Roles { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Worker> Workers { get; set; }


    }
}
