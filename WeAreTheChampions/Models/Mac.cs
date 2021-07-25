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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime MacZamani { get; set; }
        public DateTime MacSaati { get; set; }

        public int? Skor1 { get; set; }
        public int? Skor2 { get; set; }
        public Sonuc? Sonuc { get; set; }
     
        [ForeignKey("Takim1")]
        public int Takim1Id { get; set; }
        public virtual Takim Takim1 { get; set; }

        [ForeignKey("Takim2")]
        public int Takim2Id { get; set; }
        public virtual Takim Takim2 { get; set; }

    }
}
