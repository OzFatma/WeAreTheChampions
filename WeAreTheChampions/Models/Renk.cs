using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Renkler")]
    public class Renk
    {
        public Renk()
        {
            this.Takimlar = new HashSet<Takim>();
        }
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string RenkAd { get; set; }
        [Range(0,255,ErrorMessage ="0-255 arasında bir değer giriniz.",ErrorMessageResourceName ="Uyarı !")]
        public byte Red { get; set; }
        [Range(0, 255, ErrorMessage = "0-255 arasında bir değer giriniz.", ErrorMessageResourceName = "Uyarı !")]
        public byte Green { get; set; }
        [Range(0, 255, ErrorMessage = "0-255 arasında bir değer giriniz.", ErrorMessageResourceName = "Uyarı !")]
        public byte Blue { get; set; }

        public virtual ICollection<Takim> Takimlar { get; set; }

        public override string ToString()
        {
            return RenkAd;
        }
    }
}
