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
    public partial class siparis_olustur_urun_bilgi : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public int id = -1;
        public siparis_olustur_urun_bilgi()
        {
            InitializeComponent();
        }
        void UrunGetir()
        {
            baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Terzi_atolyesi_proje;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select urun.id, urun_kategori.urun_kategori, urun.urun_adi, kalip.kalip,beden.beden,renk.renk, kumas.kumas,kesim.kesim,model.model,urun_detay.adet,urun_detay.fiyat" +
                " FROM urun " +
                "INNER JOIN urun_kategori ON urun.urun_kategori_id = urun_kategori.id " +
                "INNER JOIN urun_detay ON urun.urun_detay_id = urun_detay.id " +
                "INNER JOIN renk ON urun_detay.renk_id = renk.id " +
                "INNER JOIN kumas ON urun_detay.kumas_id = kumas.id " +
                "INNER JOIN beden ON urun_detay.beden_id = beden.id " +
                "INNER JOIN kesim ON urun_detay.kesim_id = kesim.id " +
                "INNER JOIN model ON urun_detay.model_id = model.id " +
                "INNER JOIN kalip ON urun_detay.kalip_id = kalip.id", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            urun_GridView.DataSource = tablo;
            baglanti.Close();
        }
        void KategoriGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT id,urun_kategori FROM urun_kategori", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                list.Add(dr["id"].ToString()+"-"+dr["urun_kategori"].ToString());

            }
            dr.Close();
            baglanti.Close();
            list = list.Distinct().ToList();
            list.Sort();
            kategori_comboBox.DataSource = list;
        }
        void CinsiyetGetir()
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT id, kalip FROM kalip", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                list.Add(dr["id"].ToString()+"-"+dr["kalip"].ToString());

            }
            dr.Close();
            baglanti.Close();
            list = list.Distinct().ToList();
            list.Sort();
            cinsiyet_comboBox.DataSource = list;
        }
        
        void BedenGetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT id,beden FROM beden", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                list.Add(dr["id"].ToString() + "-" + dr["beden"].ToString());

            }
            dr.Close();
            baglanti.Close();
            list = list.Distinct().ToList();
            list.Sort();
            beden_comboBox.DataSource = list;
        }
        void RenkGetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT id,renk FROM renk", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                list.Add(dr["id"].ToString() + "-" + dr["renk"].ToString());

            }
            dr.Close();
            baglanti.Close();
            list = list.Distinct().ToList();
            list.Sort();
            renk_comboBox.DataSource = list;
        }
        void KumasGetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT id,kumas FROM kumas", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                list.Add(dr["id"].ToString() + "-" + dr["kumas"].ToString());

            }
            dr.Close();
            baglanti.Close();
            list = list.Distinct().ToList();
            list.Sort();
            kumas_comboBox.DataSource = list;
        }
        void KesimGetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT id,kesim FROM kesim", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                list.Add(dr["id"].ToString() + "-" + dr["kesim"].ToString());

            }
            dr.Close();
            baglanti.Close();
            list = list.Distinct().ToList();
            list.Sort();
            kesim_comboBox.DataSource = list;
        }
        void ModelGetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT id,model FROM model", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                list.Add(dr["id"].ToString() + "-" + dr["model"].ToString());

            }
            dr.Close();
            baglanti.Close();
            list = list.Distinct().ToList();
            list.Sort();
            model_comboBox.DataSource = list;
        }


        private void siparis_olustur_urun_bilgi_Load(object sender, EventArgs e)
        {
            UrunGetir();
            KategoriGetir();
            CinsiyetGetir();
            BedenGetir();
            RenkGetir();
            KumasGetir();
            KesimGetir();
            ModelGetir();
        }
        private void geri_btn_Click(object sender, EventArgs e)
        {
            
            siparis_olusturma _siparis_olusturma = new siparis_olusturma();
            _siparis_olusturma.Show();
            this.Hide();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Menu _menu = new Menu();
            _menu.Show();
            this.Hide();
        }

        private void ileri_btn_Click(object sender, EventArgs e)
        {
            siparis_terzi_sec _siparis_terzi_seç = new siparis_terzi_sec();
            _siparis_terzi_seç.Show();
            this.Hide();

        }
        private void ekle_btn_Click(object sender, EventArgs e)
        {
             baglanti.Open();
            string sorgu = @"INSERT INTO [dbo].[urun_detay]
           ([fiyat]
           ,[adet]
           ,[detay_adi]
           ,[renk_id]
           ,[kumas_id]
           ,[beden_id]
           ,[kesim_id]
           ,[model_id]
           ,[kalip_id])
     VALUES
           (@fiyat
           ,@adet
            ,@detay_adi
           ,@renk
           ,@kumas
           ,@beden
           ,@kesim
           ,@model
           ,@kalip)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@renk", Convert.ToInt32( renk_comboBox.SelectedItem.ToString().Split('-')[0]));
            komut.Parameters.AddWithValue("@kumas", Convert.ToInt32(kumas_comboBox.SelectedItem.ToString().Split('-')[0]));
            komut.Parameters.AddWithValue("@beden", Convert.ToInt32(beden_comboBox.SelectedItem.ToString().Split('-')[0]));
            komut.Parameters.AddWithValue("@kesim", Convert.ToInt32(kesim_comboBox.SelectedItem.ToString().Split('-')[0]));
            komut.Parameters.AddWithValue("@model", Convert.ToInt32(model_comboBox.SelectedItem.ToString().Split('-')[0]));
            komut.Parameters.AddWithValue("@kalip", Convert.ToInt32(cinsiyet_comboBox.SelectedItem.ToString().Split('-')[0]));
            komut.Parameters.AddWithValue("@fiyat", Convert.ToInt32(fiyat_tb.Text));
            komut.Parameters.AddWithValue("@adet", Convert.ToInt32(adet_tb.Text));
            komut.Parameters.AddWithValue("@urun_kategori", Convert.ToInt32(kategori_comboBox.SelectedItem.ToString().Split('-')[0]));
            komut.Parameters.AddWithValue("@detay_adi", Urun_adi.Text);
komut.ExecuteNonQuery();
            string sql = "insert into urun (urun_kategori_id,urun_adi,urun_detay_id) values (" + Convert.ToInt32( kategori_comboBox.SelectedItem.ToString().Split('-')[0])+",'"+Urun_adi.Text+"',(select max(id) from urun_detay) )";
            komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();


            UrunGetir();

            baglanti.Close();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM urun WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            UrunGetir();
        }

        private void urun_GridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            id = Convert.ToInt32(urun_GridView.CurrentRow.Cells[0].Value);


        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE urun_detay SET renk_id=@renk,kumas_id=@kumas,beden_id=@beden,kesim_id=@kesim,model_id=@model,kalip_id=@kalip,fiyat=@fiyat,adet=@adet,detay_adi=@detay_adi;UPDATE urun SET urun_kategori_id=@urun_kategori WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            komut.Parameters.AddWithValue("@renk", Convert.ToInt32(renk_comboBox.SelectedItem.ToString().Split('-')[0]));
            komut.Parameters.AddWithValue("@kumas", Convert.ToInt32(kumas_comboBox.SelectedItem.ToString().Split('-')[0]));
            komut.Parameters.AddWithValue("@beden", Convert.ToInt32(beden_comboBox.SelectedItem.ToString().Split('-')[0]));
            komut.Parameters.AddWithValue("@kesim", Convert.ToInt32(kesim_comboBox.SelectedItem.ToString().Split('-')[0]));
            komut.Parameters.AddWithValue("@model", Convert.ToInt32(model_comboBox.SelectedItem.ToString().Split('-')[0]));
            komut.Parameters.AddWithValue("@kalip", Convert.ToInt32(cinsiyet_comboBox.SelectedItem.ToString().Split('-')[0]));
            komut.Parameters.AddWithValue("@fiyat", Convert.ToInt32(fiyat_tb.Text));
            komut.Parameters.AddWithValue("@adet", Convert.ToInt32(adet_tb.Text));
            komut.Parameters.AddWithValue("@urun_kategori", Convert.ToInt32(kategori_comboBox.SelectedItem.ToString().Split('-')[0]));
            komut.Parameters.AddWithValue("@detay_adi", Urun_adi.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            UrunGetir();
        }

        private void ileri_btn_Click_1(object sender, EventArgs e)
        {
            siparis_terzi_sec _siparis_terzi_sec = new siparis_terzi_sec();
            _siparis_terzi_sec.Show();
            this.Hide();
        }
    }
}
