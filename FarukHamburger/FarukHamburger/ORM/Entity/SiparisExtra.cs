using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarukHamburger.ORM.Entity
{
    public class SiparisExtra
    {
        public int Id { get; set; }
        [ForeignKey("Siparis")]
        public int SiparisId { get; set; }
        [ForeignKey("Extra")]
        public int ExtraId { get; set; }
        public Siparis Siparis { get; set; }
        public Extra Extra { get; set; }
    }
}
