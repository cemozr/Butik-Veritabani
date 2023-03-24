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
    public partial class siparis_durum : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public int id = -1;

        public siparis_durum()
        {
            InitializeComponent();
        }
        void SiparisDurumGetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT id, durum_adi FROM siparis_durum", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                list.Add(dr["id"].ToString() + "-" + dr["durum_adi"].ToString());

            }
            dr.Close();
            baglanti.Close();
            list = list.Distinct().ToList();
            list.Sort();
            siparis_durumu_comboBox.DataSource = list;
        }
        void SiparisGetir()
        {
            baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Terzi_atolyesi_proje;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT musteri_isim,tutar,odeme_durumu,durum_adi,siparis_tarihi,teslim_tarihi  FROM siparis INNER JOIN odeme ON siparis.odeme_id = odeme.id INNER JOIN odeme_durumu ON odeme.odeme_durumu_id = odeme_durumu.id INNER JOIN musteri ON siparis.musteri_id = musteri.id INNER JOIN siparis_durum ON siparis.siparis_durum_id = siparis_durum.id ", baglanti);
                
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            siparis_durum_GridView.DataSource = tablo;
            baglanti.Close();
        }
      
        void OdemeDurumGetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT id, odeme_durumu FROM odeme_durumu", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                list.Add(dr["id"].ToString() + "-" + dr["odeme_durumu"].ToString());

            }
            dr.Close();
            baglanti.Close();
            list = list.Distinct().ToList();
            list.Sort();
            odeme_durumu_comboBox1.DataSource = list;
        }
       

        private void siparis_durum_GridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //id = Convert.ToInt32(siparis_durum_GridView.CurrentRow.Cells[0].Value);
            siparis_durum_GridView.CurrentRow.Cells[1].Value.ToString();

        }

        private void siparis_durum_Load_1(object sender, EventArgs e)
        {
            SiparisGetir();
            SiparisDurumGetir();
            OdemeDurumGetir();
           
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            Menu _menu = new Menu();
            _menu.Show();
            this.Hide();
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE siparis SET siparis_durum_id=@durum_adi,odeme_id=@odeme_durumu WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            komut.Parameters.AddWithValue("@durum_adi", Convert.ToInt32(id));
            komut.Parameters.AddWithValue("@odeme_durumu", Convert.ToInt32(id));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            SiparisDurumGetir();
            OdemeDurumGetir();
        }
    }
}
