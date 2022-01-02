
namespace FarukHamburger
{
    partial class frmSiparisBilgileri
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCiro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblToplamSiparisAdedi = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSatilanUrunAdedi = new System.Windows.Forms.Label();
            this.dgvTümSiparisler = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTümSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(146, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tüm Siparişler";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCiro);
            this.groupBox1.Location = new System.Drawing.Point(508, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 73);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciro";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCiro.Location = new System.Drawing.Point(31, 34);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(62, 25);
            this.lblCiro.TabIndex = 11;
            this.lblCiro.Text = "0 TL ";
            this.lblCiro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToplamSiparisAdedi);
            this.groupBox2.Location = new System.Drawing.Point(508, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 73);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplam Sipariş Adedi";
            // 
            // lblToplamSiparisAdedi
            // 
            this.lblToplamSiparisAdedi.AutoSize = true;
            this.lblToplamSiparisAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSiparisAdedi.Location = new System.Drawing.Point(31, 34);
            this.lblToplamSiparisAdedi.Name = "lblToplamSiparisAdedi";
            this.lblToplamSiparisAdedi.Size = new System.Drawing.Size(24, 25);
            this.lblToplamSiparisAdedi.TabIndex = 11;
            this.lblToplamSiparisAdedi.Text = "0";
            this.lblToplamSiparisAdedi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblExtra);
            this.groupBox3.Location = new System.Drawing.Point(508, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 73);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extra Malzeme Geliri";
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExtra.Location = new System.Drawing.Point(31, 34);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(62, 25);
            this.lblExtra.TabIndex = 11;
            this.lblExtra.Text = "0 TL ";
            this.lblExtra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSatilanUrunAdedi);
            this.groupBox4.Location = new System.Drawing.Point(508, 343);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 73);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Satılan Ürün Adedi";
            // 
            // lblSatilanUrunAdedi
            // 
            this.lblSatilanUrunAdedi.AutoSize = true;
            this.lblSatilanUrunAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatilanUrunAdedi.Location = new System.Drawing.Point(31, 34);
            this.lblSatilanUrunAdedi.Name = "lblSatilanUrunAdedi";
            this.lblSatilanUrunAdedi.Size = new System.Drawing.Size(24, 25);
            this.lblSatilanUrunAdedi.TabIndex = 11;
            this.lblSatilanUrunAdedi.Text = "0";
            this.lblSatilanUrunAdedi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvTümSiparisler
            // 
            this.dgvTümSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTümSiparisler.Location = new System.Drawing.Point(12, 94);
            this.dgvTümSiparisler.Name = "dgvTümSiparisler";
            this.dgvTümSiparisler.RowHeadersWidth = 51;
            this.dgvTümSiparisler.RowTemplate.Height = 24;
            this.dgvTümSiparisler.Size = new System.Drawing.Size(478, 413);
            this.dgvTümSiparisler.TabIndex = 13;
            // 
            // frmSiparisBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 532);
            this.Controls.Add(this.dgvTümSiparisler);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSiparisBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmSiparisBilgileri";
            this.Load += new System.EventHandler(this.frmSiparisBilgileri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTümSiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblToplamSiparisAdedi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSatilanUrunAdedi;
        private System.Windows.Forms.DataGridView dgvTümSiparisler;
    }
}