using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarukHamburger.ORM.Entity
{
    [Table("Menuler")]
    public class Menu
    {
        public Menu()
        {
            Siparisler = new List<Siparis>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string MenuAdi { get; set; }
        [Required]
        public decimal Fiyati { get; set; }
        public List<Siparis> Siparisler { get; set; }


        public override string ToString()
        {
            return MenuAdi + " Menu";
        }
    }
}
