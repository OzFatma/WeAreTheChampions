using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("TakimRenkler")]
    public class TakimRenk
    {

        public int TakimId { get; set; }
        public int RenkId { get; set; }

        public virtual Takim Takim { get; set; }
        public virtual Renk Renk { get; set; }



    }
}
