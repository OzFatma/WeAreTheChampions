using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreTheChampions.Enums;

namespace WeAreTheChampions.Models
{
    [Table("Maclar")]
    public class Mac
    {
        public int Id { get; set; }
        public DateTime? MacZamani { get; set; }

        //public DateTime MacSaati { get; set; }
        public int TakimA_Id { get; set; }
        public int TakimB_Id { get; set; }
        public int? SkorA { get; set; }
        public int? SkorB { get; set; }
        public Sonuc? Sonuc { get; set; }

       // https://www.entityframeworktutorial.net/code-first/inverseproperty-dataannotations-attribute-in-code-first.aspx
     
        public virtual Takim TakimA { get; set; }

        public virtual Takim TakimB { get; set; }

        //[ForeignKey("Takim1")]
        //[ForeignKey("Takim2")]
    }
}
