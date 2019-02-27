using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroFirmProgramm.Entity
{
    [Table("tbl_User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required, ForeignKey("RoleOf")]
        public int RoleId { get; set; }
        [Required]
        public string Login { get; set; }
        [Required] 
        public string Password { get; set; }
        [Required]
        public DateTime DateBirdth { get; set; }
        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        

        public virtual Role RoleOf { get; set; }
    }
}
