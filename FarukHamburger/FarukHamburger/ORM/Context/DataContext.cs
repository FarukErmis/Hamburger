using FarukHamburger.ORM.Entity;
using System.Data.Entity;

namespace FarukHamburger.ORM.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=Hamburger")
        {
        }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<Menu> Menuler { get; set; }
        public DbSet<Extra> Extralar { get; set; }
        public DbSet<SiparisExtra> SiparisExtralar { get; set; }


    }
}
