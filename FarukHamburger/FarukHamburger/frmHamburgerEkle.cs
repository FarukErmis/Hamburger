using FarukHamburger.Helpers;
using FarukHamburger.ORM.Context;
using System;
using System.Windows.Forms;
using Menu = FarukHamburger.ORM.Entity.Menu;

namespace FarukHamburger
{
    public partial class frmHamburgerEkle : Form
    {
        public frmHamburgerEkle()
        {
            InitializeComponent();
        }
        DataContext db = new DataContext();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu()
            {
                MenuAdi = txtMenuAdi.Text,
                Fiyati = nmFiyat.Value
            };
            db.Menuler.Add(menu);
            db.SaveChanges();
            MessageBox.Show("Menu Ekleme Başarılı");
            Tools.Clean(this.Controls);
        }
    }
}
