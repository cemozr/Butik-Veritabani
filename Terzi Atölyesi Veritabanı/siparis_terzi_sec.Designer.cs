
namespace Terzi_Atölyesi_Veritabanı
{
    partial class siparis_terzi_sec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparis_terzi_sec));
            this.ileri_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.geri_btn = new System.Windows.Forms.Button();
            this.terzi_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.terzi_lbl = new System.Windows.Forms.Label();
            this.terzi_seç_GridView = new System.Windows.Forms.DataGridView();
            this.ekle_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.terzi_seç_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ileri_btn
            // 
            this.ileri_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.ileri_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ileri_btn.BackgroundImage")));
            this.ileri_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ileri_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ileri_btn.Location = new System.Drawing.Point(586, 12);
            this.ileri_btn.Name = "ileri_btn";
            this.ileri_btn.Size = new System.Drawing.Size(45, 45);
            this.ileri_btn.TabIndex = 38;
            this.ileri_btn.UseVisualStyleBackColor = false;
            this.ileri_btn.Click += new System.EventHandler(this.ileri_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.home_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_btn.BackgroundImage")));
            this.home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_btn.Location = new System.Drawing.Point(97, 12);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(45, 45);
            this.home_btn.TabIndex = 37;
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
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
            this.geri_btn.TabIndex = 36;
            this.geri_btn.UseVisualStyleBackColor = false;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // terzi_comboBox
            // 
            this.terzi_comboBox.FormattingEnabled = true;
            this.terzi_comboBox.Location = new System.Drawing.Point(240, 123);
            this.terzi_comboBox.Name = "terzi_comboBox";
            this.terzi_comboBox.Size = new System.Drawing.Size(188, 21);
            this.terzi_comboBox.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(225, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 49;
            this.label3.Text = "Terzi Seçiniz";
            // 
            // terzi_lbl
            // 
            this.terzi_lbl.AutoSize = true;
            this.terzi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.terzi_lbl.Location = new System.Drawing.Point(172, 119);
            this.terzi_lbl.Name = "terzi_lbl";
            this.terzi_lbl.Size = new System.Drawing.Size(62, 25);
            this.terzi_lbl.TabIndex = 48;
            this.terzi_lbl.Text = "Terzi:";
            // 
            // terzi_seç_GridView
            // 
            this.terzi_seç_GridView.AllowUserToAddRows = false;
            this.terzi_seç_GridView.AllowUserToDeleteRows = false;
            this.terzi_seç_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.terzi_seç_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terzi_seç_GridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.terzi_seç_GridView.Location = new System.Drawing.Point(34, 250);
            this.terzi_seç_GridView.Name = "terzi_seç_GridView";
            this.terzi_seç_GridView.ReadOnly = true;
            this.terzi_seç_GridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.terzi_seç_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.terzi_seç_GridView.Size = new System.Drawing.Size(597, 150);
            this.terzi_seç_GridView.TabIndex = 51;
            this.terzi_seç_GridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.terzi_seç_GridView_CellEnter);
            // 
            // ekle_btn
            // 
            this.ekle_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.ekle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_btn.Location = new System.Drawing.Point(240, 171);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(120, 40);
            this.ekle_btn.TabIndex = 54;
            this.ekle_btn.Text = "EKLE";
            this.ekle_btn.UseVisualStyleBackColor = false;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // siparis_terzi_sec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(659, 412);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.terzi_seç_GridView);
            this.Controls.Add(this.terzi_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.terzi_lbl);
            this.Controls.Add(this.ileri_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.geri_btn);
            this.Name = "siparis_terzi_sec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terzi Atölyesi Veritabanı";
            this.Load += new System.EventHandler(this.siparis_terzi_sec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.terzi_seç_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ileri_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.ComboBox terzi_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label terzi_lbl;
        private System.Windows.Forms.DataGridView terzi_seç_GridView;
        private System.Windows.Forms.Button ekle_btn;
    }
}