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
        // https://www.entityframeworktutorial.net/code-first/configure-many-to-many-relationship-in-code-first.aspx
        public Takim()
        {
            this.Renkler = new HashSet<Renk>();
        }
        public int Id { get; set; }

        [Required, MaxLength(75)]
        public string TakimAd { get; set; }

        public virtual ICollection<Oyuncu> Oyuncular { get; set; }
        public virtual ICollection<Renk> Renkler { get; set; }

        // https://www.entityframeworktutorial.net/code-first/inverseproperty-dataannotations-attribute-in-code-first.aspx 

        [InverseProperty ("TakimA")]
        public virtual ICollection<Mac> MaclarA { get; set; }
        [InverseProperty("TakimB")]
        public virtual ICollection<Mac> MaclarB { get; set; }

        public override string ToString()
        {
            return TakimAd;
        }

    }
}
