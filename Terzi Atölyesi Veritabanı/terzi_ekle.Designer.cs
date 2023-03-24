
namespace Terzi_Atölyesi_Veritabanı
{
    partial class terzi_ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(terzi_ekle));
            this.geri_btn = new System.Windows.Forms.Button();
            this.terzi_ekle_GridView = new System.Windows.Forms.DataGridView();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.terzi_adi_lbl = new System.Windows.Forms.Label();
            this.terzi_iletisim_lbl = new System.Windows.Forms.Label();
            this.terzi_email_lbl = new System.Windows.Forms.Label();
            this.terzi_adres_lbl = new System.Windows.Forms.Label();
            this.terzi_email_tb = new System.Windows.Forms.TextBox();
            this.terzi_tel_tb = new System.Windows.Forms.TextBox();
            this.terzi_ad_tb = new System.Windows.Forms.TextBox();
            this.terzi_adres_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.terzi_durum_tb1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.terzi_ekle_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // geri_btn
            // 
            this.geri_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.geri_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geri_btn.BackgroundImage")));
            this.geri_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.geri_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri_btn.Location = new System.Drawing.Point(33, 12);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(45, 45);
            this.geri_btn.TabIndex = 34;
            this.geri_btn.UseVisualStyleBackColor = false;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // terzi_ekle_GridView
            // 
            this.terzi_ekle_GridView.AllowUserToAddRows = false;
            this.terzi_ekle_GridView.AllowUserToDeleteRows = false;
            this.terzi_ekle_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.terzi_ekle_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terzi_ekle_GridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.terzi_ekle_GridView.Location = new System.Drawing.Point(33, 250);
            this.terzi_ekle_GridView.Name = "terzi_ekle_GridView";
            this.terzi_ekle_GridView.ReadOnly = true;
            this.terzi_ekle_GridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.terzi_ekle_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.terzi_ekle_GridView.Size = new System.Drawing.Size(597, 150);
            this.terzi_ekle_GridView.TabIndex = 53;
            this.terzi_ekle_GridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.terzi_ekle_GridView_CellEnter);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.guncelle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle_btn.Location = new System.Drawing.Point(510, 175);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(120, 40);
            this.guncelle_btn.TabIndex = 56;
            this.guncelle_btn.Text = "GÜNCELLE";
            this.guncelle_btn.UseVisualStyleBackColor = false;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.sil_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_btn.Location = new System.Drawing.Point(510, 114);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(120, 40);
            this.sil_btn.TabIndex = 55;
            this.sil_btn.Text = "SİL";
            this.sil_btn.UseVisualStyleBackColor = false;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // ekle_btn
            // 
            this.ekle_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.ekle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_btn.Location = new System.Drawing.Point(510, 57);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(120, 40);
            this.ekle_btn.TabIndex = 54;
            this.ekle_btn.Text = "EKLE";
            this.ekle_btn.UseVisualStyleBackColor = false;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // terzi_adi_lbl
            // 
            this.terzi_adi_lbl.AutoSize = true;
            this.terzi_adi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.terzi_adi_lbl.Location = new System.Drawing.Point(44, 114);
            this.terzi_adi_lbl.Name = "terzi_adi_lbl";
            this.terzi_adi_lbl.Size = new System.Drawing.Size(36, 20);
            this.terzi_adi_lbl.TabIndex = 57;
            this.terzi_adi_lbl.Text = "Adı:";
            // 
            // terzi_iletisim_lbl
            // 
            this.terzi_iletisim_lbl.AutoSize = true;
            this.terzi_iletisim_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.terzi_iletisim_lbl.Location = new System.Drawing.Point(14, 149);
            this.terzi_iletisim_lbl.Name = "terzi_iletisim_lbl";
            this.terzi_iletisim_lbl.Size = new System.Drawing.Size(66, 20);
            this.terzi_iletisim_lbl.TabIndex = 58;
            this.terzi_iletisim_lbl.Text = "Telefon:";
            // 
            // terzi_email_lbl
            // 
            this.terzi_email_lbl.AutoSize = true;
            this.terzi_email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.terzi_email_lbl.Location = new System.Drawing.Point(25, 184);
            this.terzi_email_lbl.Name = "terzi_email_lbl";
            this.terzi_email_lbl.Size = new System.Drawing.Size(52, 20);
            this.terzi_email_lbl.TabIndex = 59;
            this.terzi_email_lbl.Text = "Email:";
            this.terzi_email_lbl.Click += new System.EventHandler(this.terzi_email_lbl_Click);
            // 
            // terzi_adres_lbl
            // 
            this.terzi_adres_lbl.AutoSize = true;
            this.terzi_adres_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.terzi_adres_lbl.Location = new System.Drawing.Point(283, 114);
            this.terzi_adres_lbl.Name = "terzi_adres_lbl";
            this.terzi_adres_lbl.Size = new System.Drawing.Size(55, 20);
            this.terzi_adres_lbl.TabIndex = 60;
            this.terzi_adres_lbl.Text = "Adres:";
            this.terzi_adres_lbl.Click += new System.EventHandler(this.terzi_adres_lbl_Click);
            // 
            // terzi_email_tb
            // 
            this.terzi_email_tb.Location = new System.Drawing.Point(83, 184);
            this.terzi_email_tb.Name = "terzi_email_tb";
            this.terzi_email_tb.Size = new System.Drawing.Size(150, 20);
            this.terzi_email_tb.TabIndex = 61;
            // 
            // terzi_tel_tb
            // 
            this.terzi_tel_tb.Location = new System.Drawing.Point(83, 149);
            this.terzi_tel_tb.Name = "terzi_tel_tb";
            this.terzi_tel_tb.Size = new System.Drawing.Size(150, 20);
            this.terzi_tel_tb.TabIndex = 62;
            // 
            // terzi_ad_tb
            // 
            this.terzi_ad_tb.Location = new System.Drawing.Point(83, 114);
            this.terzi_ad_tb.Name = "terzi_ad_tb";
            this.terzi_ad_tb.Size = new System.Drawing.Size(150, 20);
            this.terzi_ad_tb.TabIndex = 63;
            // 
            // terzi_adres_tb
            // 
            this.terzi_adres_tb.Location = new System.Drawing.Point(344, 114);
            this.terzi_adres_tb.Multiline = true;
            this.terzi_adres_tb.Name = "terzi_adres_tb";
            this.terzi_adres_tb.Size = new System.Drawing.Size(150, 55);
            this.terzi_adres_tb.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 24);
            this.label3.TabIndex = 65;
            this.label3.Text = "Terzi bilgilerini giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(239, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Terzi Durum:";
            // 
            // terzi_durum_tb1
            // 
            this.terzi_durum_tb1.Location = new System.Drawing.Point(344, 186);
            this.terzi_durum_tb1.Name = "terzi_durum_tb1";
            this.terzi_durum_tb1.Size = new System.Drawing.Size(150, 20);
            this.terzi_durum_tb1.TabIndex = 67;
            // 
            // terzi_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(659, 412);
            this.Controls.Add(this.terzi_durum_tb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.terzi_adres_tb);
            this.Controls.Add(this.terzi_ad_tb);
            this.Controls.Add(this.terzi_tel_tb);
            this.Controls.Add(this.terzi_email_tb);
            this.Controls.Add(this.terzi_adres_lbl);
            this.Controls.Add(this.terzi_email_lbl);
            this.Controls.Add(this.terzi_iletisim_lbl);
            this.Controls.Add(this.terzi_adi_lbl);
            this.Controls.Add(this.guncelle_btn);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.terzi_ekle_GridView);
            this.Controls.Add(this.geri_btn);
            this.Name = "terzi_ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "terzi_ekle";
            this.Load += new System.EventHandler(this.terzi_ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.terzi_ekle_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.DataGridView terzi_ekle_GridView;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Label terzi_adi_lbl;
        private System.Windows.Forms.Label terzi_iletisim_lbl;
        private System.Windows.Forms.Label terzi_email_lbl;
        private System.Windows.Forms.Label terzi_adres_lbl;
        private System.Windows.Forms.TextBox terzi_email_tb;
        private System.Windows.Forms.TextBox terzi_tel_tb;
        private System.Windows.Forms.TextBox terzi_ad_tb;
        private System.Windows.Forms.TextBox terzi_adres_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox terzi_durum_tb1;
    }
}