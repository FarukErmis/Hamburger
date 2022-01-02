using FarukHamburger.Enums;
using FarukHamburger.Helpers;
using FarukHamburger.ORM.Context;
using FarukHamburger.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = FarukHamburger.ORM.Entity.Menu;

namespace FarukHamburger
{
    public partial class frmSiparisOlustur : Form
    {
        public frmSiparisOlustur()
        {
            InitializeComponent();
        }
        List<Siparis> siparisler = new List<Siparis>();
        DataContext db = new DataContext();
        decimal ToplamFiyat = 0;

        public void MenuEkle()
        {
            db.Menuler.Add(new Menu { MenuAdi = "SteackHouse", Fiyati = 30.00M });
            db.Menuler.Add(new Menu { MenuAdi = "McFish", Fiyati = 24.00M });
            db.Menuler.Add(new Menu { MenuAdi = "Whooper", Fiyati = 26.00M });
            db.Menuler.Add(new Menu { MenuAdi = "BigKing", Fiyati = 23.00M });
            db.Menuler.Add(new Menu { MenuAdi = "ChickenRoyal", Fiyati = 22.00M });
            db.Menuler.Add(new Menu { MenuAdi = "King Chicken", Fiyati = 21.00M });
            db.Menuler.Add(new Menu { MenuAdi = "Kral Burger", Fiyati = 30.00M });
            db.SaveChanges();
        }
        public void ExtraEkle()
        {
            db.Extralar.Add(new Extra { ExtraAdi = "Hardal", Fiyati = 1.00M });
            db.Extralar.Add(new Extra { ExtraAdi = "Ketçap", Fiyati = 1.00M });
            db.Extralar.Add(new Extra { ExtraAdi = "Ranch", Fiyati = 1.00M });
            db.Extralar.Add(new Extra { ExtraAdi = "BBQ", Fiyati = 1.00M });
            db.Extralar.Add(new Extra { ExtraAdi = "Mayonez", Fiyati = 1.00M });
            db.Extralar.Add(new Extra { ExtraAdi = "Acı Sos", Fiyati = 1.00M });
            db.Extralar.Add(new Extra { ExtraAdi = "Barbekü", Fiyati = 1.00M });
            db.SaveChanges();
        }
        public Boyut GetBoyut()
        {
            if (rbBuyuk.Checked)
                return Boyut.Normal;
            else if (rbNormal.Checked)
                return Boyut.Normal;
            else
                return Boyut.Küçük;
        }
        public decimal DbHesapla()
        {
            decimal ToplamTutar = 0;
            var secilenMenu = cmbMenuler.SelectedItem;
            var secilenMenuFiyati = db.Menuler.Where(x => x.MenuAdi == secilenMenu.ToString()).Select(x => x.Fiyati).Single();
            ToplamTutar += secilenMenuFiyati;

            if (rbBuyuk.Checked)
                ToplamTutar += ToplamTutar * 0.25M;
            else if (rbNormal.Checked)
                ToplamTutar += ToplamTutar * 0.12M;


            foreach (CheckBox item in flpExtraMalzemeler.Controls)
            {
                if (item.Checked)
                {
                    var secilenExtra = item.Text;
                    var secilenExtraFiyati = db.Extralar.Where(x => x.ExtraAdi == item.Text).Select(x => x.Fiyati).Single();
                    ToplamTutar += secilenExtraFiyati;
                }
            }
            ToplamTutar += ToplamTutar * nmAdet.Value;
            ToplamFiyat += ToplamTutar;
            return ToplamTutar;

        }

        public void SiparisEkle()
        {
            Siparis siparis = new Siparis()
            {
                MenuId = cmbMenuler.SelectedIndex + 1,
                
                //db.Menuler.Where(x => x.MenuAdi == cmbMenuler.SelectedItem.ToString()).Select(x => x.Id).First(),
                Adet = (int)nmAdet.Value,
                Boyutu = GetBoyut(),
                ToplamTutar = DbHesapla()
            };

            Extra ex = new Extra();

            foreach (CheckBox item in flpExtraMalzemeler.Controls)
            {
                var extra = db.Extralar.Where(x => x.ExtraAdi == item.Text).Select(x => x.Id).ToList();
                if (item.Checked)
                {
                    siparis.Extralar.Add(new SiparisExtra { SiparisId = siparis.Id, ExtraId = extra[0]});
                    ex = new Extra { ExtraAdi = item.Text };
                }
            }
            siparisler.Add(siparis);
            lstSiparisler.Items.Add(siparis);
        }
        
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            if (cmbMenuler.SelectedIndex != -1)
            {
                SiparisEkle();
                if (db.Siparisler.Count() > 0)
                    lblToplamTutar.Text = db.Siparisler.Select(x => x.ToplamTutar).Sum().ToString("C2");
                Tools.Clean(this.Controls);
            }
            lblToplamTutar.Text = ToplamFiyat.ToString();
        }

        private void frmSiparisOlustur_Load(object sender, EventArgs e)
        {
            if (!db.Extralar.Any(x => x.Id > 0))
            {
                MenuEkle();
                ExtraEkle();
            }
            
            cmbMenuler.Items.AddRange(db.Menuler.Select(x => x.MenuAdi).ToArray());
            foreach (var ex in db.Extralar.Select(x => x.ExtraAdi))
                flpExtraMalzemeler.Controls.Add(new CheckBox() { Text = ex, Tag = ex });

            
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Toplam Sipariş Ücreti: {ToplamFiyat.ToString("C2")}, Satın almayı tamamlamak istermisiniz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Siparisler.AddRange(siparisler);
                db.SaveChanges();
                lstSiparisler.Items.Clear();
                siparisler.Clear();
                MessageBox.Show("Sipariş Tamamlandı!....");
                Tools.Clean(this.Controls);
            }
        }
    }
}
