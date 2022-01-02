using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarukHamburger.ORM.Entity
{
    [Table("Extralar")]
    public class Extra
    {
        public Extra()
        {
            Extralar = new List<SiparisExtra>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string ExtraAdi { get; set; }
        [Required]
        public decimal Fiyati { get; set; }
        public List<SiparisExtra> Extralar { get; set; }
    }
}
