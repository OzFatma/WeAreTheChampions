using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Oyuncular")]
    public class Oyuncu
    {
        public int Id { get; set; }

        [Required,MaxLength(25)]
        public string OyuncuAd { get; set; }
        [Required, MaxLength(25)]
        public string OyuncuSoyad { get; set; }

        //[ForeignKey("Takim")]
        public int TakimId { get; set; }

        public virtual Takim Takim { get; set; }

        public override string ToString()
        {
            return OyuncuAd+" "+OyuncuSoyad;
        }
    }
}

