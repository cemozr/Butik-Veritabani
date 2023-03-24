using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terzi_Atölyesi_Veritabanı
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void siparis_btn_Click(object sender, EventArgs e)
        {
            siparis_olusturma _siparis_olusturma = new siparis_olusturma();
            _siparis_olusturma.Show();
            this.Hide();
        }

        private void siparis_durum_btn_Click(object sender, EventArgs e)
        {
            siparis_durum _siparis_durum = new siparis_durum();
            _siparis_durum.Show();
            this.Hide();
        }

        private void terzi_ekle_btn_Click(object sender, EventArgs e)
        {
            terzi_ekle _terzi_ekle = new terzi_ekle();
            _terzi_ekle.Show();
            this.Hide();
        }

       
    }
}
