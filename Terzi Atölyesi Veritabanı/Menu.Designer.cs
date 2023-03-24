
namespace Terzi_Atölyesi_Veritabanı
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.siparis_btn = new System.Windows.Forms.Button();
            this.siparis_durum_btn = new System.Windows.Forms.Button();
            this.terzi_ekle_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // siparis_btn
            // 
            this.siparis_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.siparis_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siparis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.siparis_btn.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.siparis_btn.Image = ((System.Drawing.Image)(resources.GetObject("siparis_btn.Image")));
            this.siparis_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.siparis_btn.Location = new System.Drawing.Point(80, 44);
            this.siparis_btn.Name = "siparis_btn";
            this.siparis_btn.Size = new System.Drawing.Size(200, 200);
            this.siparis_btn.TabIndex = 0;
            this.siparis_btn.Text = "Sipariş Oluştur\r\n";
            this.siparis_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.siparis_btn.UseVisualStyleBackColor = false;
            this.siparis_btn.Click += new System.EventHandler(this.siparis_btn_Click);
            // 
            // siparis_durum_btn
            // 
            this.siparis_durum_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.siparis_durum_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siparis_durum_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparis_durum_btn.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.siparis_durum_btn.Image = ((System.Drawing.Image)(resources.GetObject("siparis_durum_btn.Image")));
            this.siparis_durum_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.siparis_durum_btn.Location = new System.Drawing.Point(376, 44);
            this.siparis_durum_btn.Name = "siparis_durum_btn";
            this.siparis_durum_btn.Size = new System.Drawing.Size(200, 200);
            this.siparis_durum_btn.TabIndex = 1;
            this.siparis_durum_btn.Text = "Siparişlerin Durumu";
            this.siparis_durum_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.siparis_durum_btn.UseVisualStyleBackColor = false;
            this.siparis_durum_btn.Click += new System.EventHandler(this.siparis_durum_btn_Click);
            // 
            // terzi_ekle_btn
            // 
            this.terzi_ekle_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.terzi_ekle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.terzi_ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.terzi_ekle_btn.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.terzi_ekle_btn.Image = ((System.Drawing.Image)(resources.GetObject("terzi_ekle_btn.Image")));
            this.terzi_ekle_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.terzi_ekle_btn.Location = new System.Drawing.Point(226, 284);
            this.terzi_ekle_btn.Name = "terzi_ekle_btn";
            this.terzi_ekle_btn.Size = new System.Drawing.Size(200, 200);
            this.terzi_ekle_btn.TabIndex = 2;
            this.terzi_ekle_btn.Text = "Yeni Terzi Ekle";
            this.terzi_ekle_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.terzi_ekle_btn.UseVisualStyleBackColor = false;
            this.terzi_ekle_btn.Click += new System.EventHandler(this.terzi_ekle_btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(677, 534);
            this.Controls.Add(this.terzi_ekle_btn);
            this.Controls.Add(this.siparis_durum_btn);
            this.Controls.Add(this.siparis_btn);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terzi Atölyesi Veritabanı";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button siparis_btn;
        private System.Windows.Forms.Button terzi_ekle_btn;
        private System.Windows.Forms.Button siparis_durum_btn;
    }
}