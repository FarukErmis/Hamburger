using FarukHamburger.ORM.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarukHamburger
{
    public partial class frmSiparisBilgileri : Form
    {
        public frmSiparisBilgileri()
        {
            InitializeComponent();
        }
        DataContext db = new DataContext();
        private void frmSiparisBilgileri_Load(object sender, EventArgs e)
        {
            dgvTümSiparisler.Rows.Clear();
            var result = from s in db.SiparisExtralar
                         select new
                         {
                             s.Siparis.Menu.MenuAdi,
                             s.Siparis.Boyutu,
                             s.Extra.ExtraAdi,
                             s.Siparis.Adet,
                             s.Siparis.ToplamTutar
                         };
            dgvTümSiparisler.DataSource = result.ToList();

            if (db.Siparisler.Count() > 0)
            {
                lblCiro.Text = db.Siparisler.Select(x => x.ToplamTutar).Sum().ToString("C2");
                lblSatilanUrunAdedi.Text = db.Siparisler.Select(x => x.Adet).Sum().ToString();
                lblToplamSiparisAdedi.Text = db.Siparisler.Count().ToString();
            }
        }
    }
}
