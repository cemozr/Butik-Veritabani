
namespace Terzi_Atölyesi_Veritabanı
{
    partial class siparis_birlestirme
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
            this.birlestirme_GridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.birlestirme_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // birlestirme_GridView
            // 
            this.birlestirme_GridView.AllowUserToAddRows = false;
            this.birlestirme_GridView.AllowUserToDeleteRows = false;
            this.birlestirme_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.birlestirme_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.birlestirme_GridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birlestirme_GridView.Location = new System.Drawing.Point(105, 288);
            this.birlestirme_GridView.Name = "birlestirme_GridView";
            this.birlestirme_GridView.ReadOnly = true;
            this.birlestirme_GridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.birlestirme_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.birlestirme_GridView.Size = new System.Drawing.Size(597, 150);
            this.birlestirme_GridView.TabIndex = 24;
            this.birlestirme_GridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.birlestirme_GridView_CellEnter);
            // 
            // siparis_birlestirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.birlestirme_GridView);
            this.Name = "siparis_birlestirme";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.siparis_birlestirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.birlestirme_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView birlestirme_GridView;
    }
}