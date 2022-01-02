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
    public partial class frmMainMdi : Form
    {
        public frmMainMdi()
        {
            InitializeComponent();
        }

        private void siparisOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChilForm(new frmSiparisOlustur());
        }

        private void siparisBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChilForm(new frmSiparisBilgileri());
        }

        private void hamburgerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChilForm(new frmHamburgerEkle());
        }

        private void extraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChilForm(new frmExtraMalzemeEkle());
        }
        private void ChilForm(Form _childForm)
        {
            this.Width = _childForm.Width + 25;
            this.Height = _childForm.Height + 75;

            bool durum = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                    frm.Close();
            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }
    }
}
