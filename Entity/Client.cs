using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroFirmProgramm.Entity
{   [Table("tbl_Client")]
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string MiddleName { get; set; }
               
        public DateTime? DateBirdth { get; set; }
       
        public int? PhoneNumber { get; set; }
        
        public string Addres { get; set; }
        


    }
}
