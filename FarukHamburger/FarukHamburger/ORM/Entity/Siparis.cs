using FarukHamburger.Enums;
using FarukHamburger.ORM.Context;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace FarukHamburger.ORM.Entity
{
    [Table("Siparisler")]
    public class Siparis
    {
        public Siparis()
        {
            Extralar = new List<SiparisExtra>();
        }
        [Key]
        public int Id { get; set; }
        [ForeignKey("Menu")]
        public int MenuId { get; set; }
        public Boyut Boyutu { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        public List<SiparisExtra> Extralar { get; set; }
        public Menu Menu { get; set; }

        DataContext db = new DataContext();
        public override string ToString()
        {
            List<string> menuAdi = new List<string>();
            
            string ex = "";

            menuAdi = db.Menuler.Where(x => x.Id == MenuId).Select(x => x.MenuAdi).ToList();
            if (Extralar.Count < 1)
                return string.Format("{0} Menü, X {1} Adet, {2} Boy, Toplam Tutar {3}",
                    menuAdi[0],
                    Adet.ToString(),
                    Boyutu.ToString(),
                    ToplamTutar.ToString("C2"));
            
            else
            {
                for (int i = 0; i < Extralar.Count; i++)
                {
                    int a = Extralar[i].ExtraId;
                    ex += db.Extralar.Where(x => x.Id == a).Select(x => x.ExtraAdi).FirstOrDefault() + ",";
                }
                
                ex.Trim(',');

                return string.Format("{0} Menü, X {1} Adet, {2} Boy, Extralar {3},  Toplam Tutar {4}",
                    menuAdi[0].ToString(),
                    Adet.ToString(),
                    Boyutu.ToString(),
                    ex,
                    ToplamTutar.ToString("C2"));
            }
        }
    }
}
