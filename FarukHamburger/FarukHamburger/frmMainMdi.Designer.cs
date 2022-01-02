
namespace FarukHamburger
{
    partial class frmMainMdi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparisYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hamburgerEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraMalzemeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisYonetimiToolStripMenuItem,
            this.urunYonetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1000, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparisYonetimiToolStripMenuItem
            // 
            this.siparisYonetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisOlusturToolStripMenuItem,
            this.siparisBilgileriToolStripMenuItem});
            this.siparisYonetimiToolStripMenuItem.Name = "siparisYonetimiToolStripMenuItem";
            this.siparisYonetimiToolStripMenuItem.Size = new System.Drawing.Size(144, 27);
            this.siparisYonetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // siparisOlusturToolStripMenuItem
            // 
            this.siparisOlusturToolStripMenuItem.Name = "siparisOlusturToolStripMenuItem";
            this.siparisOlusturToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.siparisOlusturToolStripMenuItem.Text = "Sipariş Oluştur";
            this.siparisOlusturToolStripMenuItem.Click += new System.EventHandler(this.siparisOlusturToolStripMenuItem_Click);
            // 
            // siparisBilgileriToolStripMenuItem
            // 
            this.siparisBilgileriToolStripMenuItem.Name = "siparisBilgileriToolStripMenuItem";
            this.siparisBilgileriToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.siparisBilgileriToolStripMenuItem.Text = "Sipariş Bilgileri";
            this.siparisBilgileriToolStripMenuItem.Click += new System.EventHandler(this.siparisBilgileriToolStripMenuItem_Click);
            // 
            // urunYonetimiToolStripMenuItem
            // 
            this.urunYonetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hamburgerEkleToolStripMenuItem,
            this.extraMalzemeEkleToolStripMenuItem});
            this.urunYonetimiToolStripMenuItem.Name = "urunYonetimiToolStripMenuItem";
            this.urunYonetimiToolStripMenuItem.Size = new System.Drawing.Size(133, 27);
            this.urunYonetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // hamburgerEkleToolStripMenuItem
            // 
            this.hamburgerEkleToolStripMenuItem.Name = "hamburgerEkleToolStripMenuItem";
            this.hamburgerEkleToolStripMenuItem.Size = new System.Drawing.Size(241, 28);
            this.hamburgerEkleToolStripMenuItem.Text = "Hamburger Ekle";
            this.hamburgerEkleToolStripMenuItem.Click += new System.EventHandler(this.hamburgerEkleToolStripMenuItem_Click);
            // 
            // extraMalzemeEkleToolStripMenuItem
            // 
            this.extraMalzemeEkleToolStripMenuItem.Name = "extraMalzemeEkleToolStripMenuItem";
            this.extraMalzemeEkleToolStripMenuItem.Size = new System.Drawing.Size(241, 28);
            this.extraMalzemeEkleToolStripMenuItem.Text = "Extra Malzeme Ekle";
            this.extraMalzemeEkleToolStripMenuItem.Click += new System.EventHandler(this.extraMalzemeEkleToolStripMenuItem_Click);
            // 
            // frmMainMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMainMdi";
            this.Text = "frmMainMdi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparisYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hamburgerEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraMalzemeEkleToolStripMenuItem;
    }
}