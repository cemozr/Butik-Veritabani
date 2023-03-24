
namespace Terzi_Atölyesi_Veritabanı
{
    partial class siparis_durum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparis_durum));
            this.geri_btn = new System.Windows.Forms.Button();
            this.siparis_durum_GridView = new System.Windows.Forms.DataGridView();
            this.odeme_durumu_comboBox1 = new System.Windows.Forms.ComboBox();
            this.odeme_durumu_lbl = new System.Windows.Forms.Label();
            this.siparis_durumu_comboBox = new System.Windows.Forms.ComboBox();
            this.siparis_durum_lbl = new System.Windows.Forms.Label();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.siparis_durum2_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.siparis_durum_GridView)).BeginInit();
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
            this.geri_btn.TabIndex = 18;
            this.geri_btn.UseVisualStyleBackColor = false;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // siparis_durum_GridView
            // 
            this.siparis_durum_GridView.AllowUserToAddRows = false;
            this.siparis_durum_GridView.AllowUserToDeleteRows = false;
            this.siparis_durum_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.siparis_durum_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siparis_durum_GridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siparis_durum_GridView.Location = new System.Drawing.Point(33, 250);
            this.siparis_durum_GridView.Name = "siparis_durum_GridView";
            this.siparis_durum_GridView.ReadOnly = true;
            this.siparis_durum_GridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.siparis_durum_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.siparis_durum_GridView.Size = new System.Drawing.Size(597, 150);
            this.siparis_durum_GridView.TabIndex = 24;
            this.siparis_durum_GridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.siparis_durum_GridView_CellEnter);
            // 
            // odeme_durumu_comboBox1
            // 
            this.odeme_durumu_comboBox1.FormattingEnabled = true;
            this.odeme_durumu_comboBox1.Location = new System.Drawing.Point(157, 165);
            this.odeme_durumu_comboBox1.Name = "odeme_durumu_comboBox1";
            this.odeme_durumu_comboBox1.Size = new System.Drawing.Size(150, 21);
            this.odeme_durumu_comboBox1.TabIndex = 57;
            // 
            // odeme_durumu_lbl
            // 
            this.odeme_durumu_lbl.AutoSize = true;
            this.odeme_durumu_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.odeme_durumu_lbl.Location = new System.Drawing.Point(25, 165);
            this.odeme_durumu_lbl.Name = "odeme_durumu_lbl";
            this.odeme_durumu_lbl.Size = new System.Drawing.Size(126, 20);
            this.odeme_durumu_lbl.TabIndex = 56;
            this.odeme_durumu_lbl.Text = "Ödeme Durumu:";
            // 
            // siparis_durumu_comboBox
            // 
            this.siparis_durumu_comboBox.FormattingEnabled = true;
            this.siparis_durumu_comboBox.Location = new System.Drawing.Point(157, 123);
            this.siparis_durumu_comboBox.Name = "siparis_durumu_comboBox";
            this.siparis_durumu_comboBox.Size = new System.Drawing.Size(150, 21);
            this.siparis_durumu_comboBox.TabIndex = 55;
            // 
            // siparis_durum_lbl
            // 
            this.siparis_durum_lbl.AutoSize = true;
            this.siparis_durum_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.siparis_durum_lbl.Location = new System.Drawing.Point(29, 123);
            this.siparis_durum_lbl.Name = "siparis_durum_lbl";
            this.siparis_durum_lbl.Size = new System.Drawing.Size(122, 20);
            this.siparis_durum_lbl.TabIndex = 54;
            this.siparis_durum_lbl.Text = "Sipariş Durumu:";
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.guncelle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle_btn.Location = new System.Drawing.Point(485, 175);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(120, 40);
            this.guncelle_btn.TabIndex = 60;
            this.guncelle_btn.Text = "GÜNCELLE";
            this.guncelle_btn.UseVisualStyleBackColor = false;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.sil_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_btn.Location = new System.Drawing.Point(485, 114);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(120, 40);
            this.sil_btn.TabIndex = 59;
            this.sil_btn.Text = "SİL";
            this.sil_btn.UseVisualStyleBackColor = false;
            // 
            // ekle_btn
            // 
            this.ekle_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.ekle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_btn.Location = new System.Drawing.Point(485, 57);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(120, 40);
            this.ekle_btn.TabIndex = 58;
            this.ekle_btn.Text = "EKLE";
            this.ekle_btn.UseVisualStyleBackColor = false;
            // 
            // siparis_durum2_lbl
            // 
            this.siparis_durum2_lbl.AutoSize = true;
            this.siparis_durum2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparis_durum2_lbl.Location = new System.Drawing.Point(88, 73);
            this.siparis_durum2_lbl.Name = "siparis_durum2_lbl";
            this.siparis_durum2_lbl.Size = new System.Drawing.Size(237, 24);
            this.siparis_durum2_lbl.TabIndex = 61;
            this.siparis_durum2_lbl.Text = "Sipariş durumunu giriniz";
            // 
            // siparis_durum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(659, 412);
            this.Controls.Add(this.siparis_durum2_lbl);
            this.Controls.Add(this.guncelle_btn);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.odeme_durumu_comboBox1);
            this.Controls.Add(this.odeme_durumu_lbl);
            this.Controls.Add(this.siparis_durumu_comboBox);
            this.Controls.Add(this.siparis_durum_lbl);
            this.Controls.Add(this.siparis_durum_GridView);
            this.Controls.Add(this.geri_btn);
            this.Name = "siparis_durum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "siparis_durum";
            this.Load += new System.EventHandler(this.siparis_durum_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.siparis_durum_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.DataGridView siparis_durum_GridView;
        private System.Windows.Forms.ComboBox odeme_durumu_comboBox1;
        private System.Windows.Forms.Label odeme_durumu_lbl;
        private System.Windows.Forms.ComboBox siparis_durumu_comboBox;
        private System.Windows.Forms.Label siparis_durum_lbl;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Label siparis_durum2_lbl;
    }
}