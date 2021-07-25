using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Takimlar")]
    public class Takim
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(75)]
        public string TakimAd { get; set; }
        //public int Takim1Id { get; set; }
        //public int Takim2Id { get; set; }

        public virtual ICollection<Oyuncu> Oyuncular { get; set; }
        public virtual ICollection<Renk> Renkler { get; set; }

        [InverseProperty("Takim1")]
        public virtual ICollection<Mac> Maclar1 { get; set; }
        [InverseProperty("Takim2")]
        public virtual ICollection<Mac> Maclar2 { get; set; }
        public override string ToString()
        {
            return TakimAd;
        }

    }
}
