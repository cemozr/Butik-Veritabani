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
    public partial class terzi_ekle : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public int id = -1;
        public terzi_ekle()
        {
            InitializeComponent();
        }
        void TerziEkleGetir()
        {
            baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Terzi_atolyesi_proje;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select terzi.id,terzi_adi,terzi_adres,terzi_iletisim,terzi_email,terzi_durum.durum from terzi INNER JOIN terzi_durum ON terzi.terzi_durum_id = terzi_durum.id", baglanti);



            DataTable tablo = new DataTable();
            da.Fill(tablo);
            terzi_ekle_GridView.DataSource = tablo;
            baglanti.Close();
        }
        private void terzi_ekle_Load(object sender, EventArgs e)
        {
            TerziEkleGetir();
        }
        private void terzi_email_lbl_Click(object sender, EventArgs e)
        {

        }

        private void terzi_adres_lbl_Click(object sender, EventArgs e)
        {

        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            Menu _menu = new Menu();
            _menu.Show();
            this.Hide();

        }

        private void terzi_ekle_GridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //terzi_ekle_GridView.CurrentRow.Cells[1].Value.ToString();
            id = Convert.ToInt32(terzi_ekle_GridView.CurrentRow.Cells[0].Value);
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO terzi(terzi_durum_id, terzi_adi, terzi_adres, terzi_iletisim, terzi_email) VALUES (@terzi_durum_id, @terzi_adi,@terzi_adres,@terzi_iletisim,@terzi_email)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@terzi_durum_id", terzi_durum_tb1.Text);
            komut.Parameters.AddWithValue("@terzi_adi", terzi_ad_tb.Text);
            komut.Parameters.AddWithValue("@terzi_adres", terzi_adres_tb.Text);
            komut.Parameters.AddWithValue("@terzi_iletisim", terzi_tel_tb.Text);
            komut.Parameters.AddWithValue("@terzi_email", terzi_email_tb.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            TerziEkleGetir();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM terzi WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            TerziEkleGetir();
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE terzi SET terzi_durum_id=@durum,terzi_adi=@terzi_adi,terzi_adres=@terzi_adres,terzi_iletisim=@terzi_iletisim,terzi_email=@terzi_email WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            komut.Parameters.AddWithValue("@durum", Convert.ToInt32(id));
            komut.Parameters.AddWithValue("@terzi_adi", terzi_ad_tb.Text);
            komut.Parameters.AddWithValue("@terzi_adres", terzi_adres_tb.Text);
            komut.Parameters.AddWithValue("@terzi_iletisim",terzi_tel_tb.Text);
            komut.Parameters.AddWithValue("@terzi_email", terzi_email_tb.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            TerziEkleGetir();
        }
    }
}
