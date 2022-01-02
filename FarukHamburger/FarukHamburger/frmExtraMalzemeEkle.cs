using FarukHamburger.Helpers;
using FarukHamburger.ORM.Context;
using FarukHamburger.ORM.Entity;
using System;
using System.Windows.Forms;

namespace FarukHamburger
{
    public partial class frmExtraMalzemeEkle : Form
    {
        public frmExtraMalzemeEkle()
        {
            InitializeComponent();
        }
        DataContext db = new DataContext();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Extra extra = new Extra()
            {
                ExtraAdi = txtAdi.Text,
                Fiyati = nmFiyat.Value
            };

            db.Extralar.Add(extra);
            db.SaveChanges();
            MessageBox.Show("Menu Ekleme Başarılı");
            Tools.Clean(this.Controls);
        }
    }
}
