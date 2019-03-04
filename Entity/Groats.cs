using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroFirmProgramm.Entity
{
    [Table("tbl_Groats")]
    public class Groats
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Class { get; set; }
        [Required]
        public double White { get; set; }
        [Required]
        public double Humidity { get; set; }
    }
}
