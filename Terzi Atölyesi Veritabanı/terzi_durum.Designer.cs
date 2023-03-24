
namespace Terzi_Atölyesi_Veritabanı
{
    partial class terzi_durum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(terzi_durum));
            this.geri_btn = new System.Windows.Forms.Button();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.terzi_durumu_lbl = new System.Windows.Forms.Label();
            this.terzi_durum_comboBox = new System.Windows.Forms.ComboBox();
            this.terzi_durum_GridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.terzi_durum_GridView)).BeginInit();
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
            this.geri_btn.TabIndex = 37;
            this.geri_btn.UseVisualStyleBackColor = false;
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.guncelle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle_btn.Location = new System.Drawing.Point(476, 82);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(120, 40);
            this.guncelle_btn.TabIndex = 39;
            this.guncelle_btn.Text = "GÜNCELLE";
            this.guncelle_btn.UseVisualStyleBackColor = false;
            // 
            // terzi_durumu_lbl
            // 
            this.terzi_durumu_lbl.AutoSize = true;
            this.terzi_durumu_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.terzi_durumu_lbl.Location = new System.Drawing.Point(29, 90);
            this.terzi_durumu_lbl.Name = "terzi_durumu_lbl";
            this.terzi_durumu_lbl.Size = new System.Drawing.Size(202, 24);
            this.terzi_durumu_lbl.TabIndex = 40;
            this.terzi_durumu_lbl.Text = "Terzi Durumu Giriniz";
            this.terzi_durumu_lbl.Click += new System.EventHandler(this.terzi_durumu_lbl_Click);
            // 
            // terzi_durum_comboBox
            // 
            this.terzi_durum_comboBox.FormattingEnabled = true;
            this.terzi_durum_comboBox.Location = new System.Drawing.Point(237, 93);
            this.terzi_durum_comboBox.Name = "terzi_durum_comboBox";
            this.terzi_durum_comboBox.Size = new System.Drawing.Size(150, 21);
            this.terzi_durum_comboBox.TabIndex = 51;
            // 
            // terzi_durum_GridView
            // 
            this.terzi_durum_GridView.AllowUserToAddRows = false;
            this.terzi_durum_GridView.AllowUserToDeleteRows = false;
            this.terzi_durum_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.terzi_durum_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terzi_durum_GridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.terzi_durum_GridView.Location = new System.Drawing.Point(33, 148);
            this.terzi_durum_GridView.Name = "terzi_durum_GridView";
            this.terzi_durum_GridView.ReadOnly = true;
            this.terzi_durum_GridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.terzi_durum_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.terzi_durum_GridView.Size = new System.Drawing.Size(597, 150);
            this.terzi_durum_GridView.TabIndex = 52;
            // 
            // terzi_durum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(659, 321);
            this.Controls.Add(this.terzi_durum_GridView);
            this.Controls.Add(this.terzi_durum_comboBox);
            this.Controls.Add(this.terzi_durumu_lbl);
            this.Controls.Add(this.guncelle_btn);
            this.Controls.Add(this.geri_btn);
            this.Name = "terzi_durum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "terzi_durum";
            this.Load += new System.EventHandler(this.terzi_durum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.terzi_durum_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Label terzi_durumu_lbl;
        private System.Windows.Forms.ComboBox terzi_durum_comboBox;
        private System.Windows.Forms.DataGridView terzi_durum_GridView;
    }
}