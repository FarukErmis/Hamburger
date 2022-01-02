
namespace FarukHamburger
{
    partial class frmSiparisOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparisOlustur));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.nmAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.flpExtraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAdet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btnSiparisEkle);
            this.groupBox1.Controls.Add(this.nmAdet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.flpExtraMalzemeler);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbMenuler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 641);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş Oluştur";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSiparisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisEkle.ForeColor = System.Drawing.Color.White;
            this.btnSiparisEkle.Location = new System.Drawing.Point(12, 576);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(243, 53);
            this.btnSiparisEkle.TabIndex = 8;
            this.btnSiparisEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // nmAdet
            // 
            this.nmAdet.Location = new System.Drawing.Point(89, 542);
            this.nmAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAdet.Name = "nmAdet";
            this.nmAdet.Size = new System.Drawing.Size(120, 30);
            this.nmAdet.TabIndex = 7;
            this.nmAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adet : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flpExtraMalzemeler
            // 
            this.flpExtraMalzemeler.Location = new System.Drawing.Point(6, 390);
            this.flpExtraMalzemeler.Name = "flpExtraMalzemeler";
            this.flpExtraMalzemeler.Size = new System.Drawing.Size(249, 151);
            this.flpExtraMalzemeler.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extra Malzameler...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBuyuk);
            this.groupBox2.Controls.Add(this.rbNormal);
            this.groupBox2.Controls.Add(this.rbKucuk);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(6, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 66);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boyut Seçimi";
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBuyuk.Location = new System.Drawing.Point(172, 25);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(88, 29);
            this.rbBuyuk.TabIndex = 0;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbNormal.Location = new System.Drawing.Point(83, 25);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(95, 29);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKucuk.Location = new System.Drawing.Point(6, 25);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(89, 29);
            this.rbKucuk.TabIndex = 0;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(6, 264);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(249, 33);
            this.cmbMenuler.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menü Seçimi....";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(691, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Toplam Tutar : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(857, 602);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(62, 25);
            this.lblToplamTutar.TabIndex = 10;
            this.lblToplamTutar.Text = "0 TL ";
            this.lblToplamTutar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSiparisTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisTamamla.ForeColor = System.Drawing.Color.White;
            this.btnSiparisTamamla.Location = new System.Drawing.Point(933, 586);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(243, 53);
            this.btnSiparisTamamla.TabIndex = 9;
            this.btnSiparisTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisTamamla.UseVisualStyleBackColor = false;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 25;
            this.lstSiparisler.Location = new System.Drawing.Point(294, 20);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(894, 554);
            this.lstSiparisler.TabIndex = 12;
            // 
            // frmSiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 661);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSiparisOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmSiparisOlustur";
            this.Load += new System.EventHandler(this.frmSiparisOlustur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAdet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.ComboBox cmbMenuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.NumericUpDown nmAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpExtraMalzemeler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox lstSiparisler;
    }
}