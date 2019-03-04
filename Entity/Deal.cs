using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroFirmProgramm.Entity
{   [Table("tbl_Deal")]
    public class Deal
    {
        [Key]
        public int Id { get; set; }
        [Required, ForeignKey("GroatsOf")]
        public int GroatsId { get; set; }
        [Required, ForeignKey("ClientOf")]
        public int ClientId { get; set; }
        [Required]
        public int GroatClass { get; set; }
        [Required]
        public double GroatWhite { get; set; }
        [Required]
        public double GroatHumidity { get; set; }
        [Required]
        public int Kilogram { get; set; }
        [Required]
        public int TotalPrice { get; set; }

        public virtual Groats GroatsOf { get; set; }
        public virtual Client ClientOf { get; set; }

    }
}
