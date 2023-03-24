using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Terzi_Atölyesi_Veritabanı
{
    public partial class siparis_olusturma : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public int id=-1;
        public siparis_olusturma()
        {
            InitializeComponent();
        }
        void MusteriGetir()
        {
            baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Terzi_atolyesi_proje;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM musteri", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            mus_GridView.DataSource = tablo;
            baglanti.Close();
        }

        private void siparis_olustur_Load(object sender, EventArgs e)
        {
            MusteriGetir();   
        }

       

       

        private void geri_btn_Click(object sender, EventArgs e)
        {
            Menu _menu = new Menu();
            _menu.Show();
            this.Hide();
        }

        

        private void ileri_btn_Click(object sender, EventArgs e)
        {
            siparis_olustur_urun_bilgi _siparis_olustur_urun_bilgi = new siparis_olustur_urun_bilgi();
            _siparis_olustur_urun_bilgi.Show();
            this.Hide();
        }

        private void mus_GridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id =Convert.ToInt32(mus_GridView.CurrentRow.Cells[0].Value);
            mus_ad_tb.Text = mus_GridView.CurrentRow.Cells[1].Value.ToString();
            mus_tel_tb.Text = mus_GridView.CurrentRow.Cells[2].Value.ToString();
            mus_email_tb.Text = mus_GridView.CurrentRow.Cells[3].Value.ToString();
            mus_adres_tb.Text = mus_GridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO musteri(musteri_isim,musteri_email,musteri_tel,adres) VALUES (@musteri_isim,@musteri_email,@musteri_tel,@adres)";
            komut = new SqlCommand(sorgu, baglanti);
            //komut.Parameters.AddWithValue("@id", mus_id.Text);
            komut.Parameters.AddWithValue("@musteri_isim", mus_ad_tb.Text);
            komut.Parameters.AddWithValue("@musteri_email", mus_email_tb.Text);
            komut.Parameters.AddWithValue("@musteri_tel", mus_tel_tb.Text);
            komut.Parameters.AddWithValue("@adres", mus_adres_tb.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();

        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM musteri WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE musteri SET musteri_isim=@musteri_isim,musteri_email=@musteri_email,musteri_tel=@musteri_tel,adres=@adres WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            komut.Parameters.AddWithValue("@musteri_isim", mus_ad_tb.Text);
            komut.Parameters.AddWithValue("@musteri_email", mus_email_tb.Text);
            komut.Parameters.AddWithValue("@musteri_tel", mus_tel_tb.Text);
            komut.Parameters.AddWithValue("@adres", mus_adres_tb.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }
    }
}
