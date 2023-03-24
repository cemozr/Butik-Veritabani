
namespace Terzi_Atölyesi_Veritabanı
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.şifre_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(67, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(388, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // username_tb
            // 
            this.username_tb.BackColor = System.Drawing.Color.Azure;
            this.username_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.username_tb.Location = new System.Drawing.Point(217, 77);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(238, 30);
            this.username_tb.TabIndex = 1;
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.Color.Azure;
            this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.password_tb.Location = new System.Drawing.Point(217, 142);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(238, 30);
            this.password_tb.TabIndex = 2;
            this.password_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_tb_KeyDown);
            this.password_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_tb_KeyPress);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id_label.Location = new System.Drawing.Point(62, 77);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(139, 25);
            this.id_label.TabIndex = 3;
            this.id_label.Text = "Kullanıcı Adı:";
            this.id_label.Click += new System.EventHandler(this.id_label_Click);
            // 
            // şifre_label
            // 
            this.şifre_label.AutoSize = true;
            this.şifre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.şifre_label.Location = new System.Drawing.Point(129, 142);
            this.şifre_label.Name = "şifre_label";
            this.şifre_label.Size = new System.Drawing.Size(64, 25);
            this.şifre_label.TabIndex = 4;
            this.şifre_label.Text = "Şifre:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(545, 332);
            this.Controls.Add(this.şifre_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.button1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terzi Atölyesi Veritabanı";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label şifre_label;
    }
}

