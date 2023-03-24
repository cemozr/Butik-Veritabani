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
    public partial class siparis_terzi_sec : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public int id = -1;
        public siparis_terzi_sec()
        {
            InitializeComponent();
        }
        void TerziSeçimGetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT id, terzi_adi FROM terzi", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                list.Add(dr["id"].ToString() + "-" + dr["terzi_adi"].ToString());

            }
            dr.Close();
            baglanti.Close();
            list = list.Distinct().ToList();
            list.Sort();
            terzi_comboBox.DataSource = list;
        }
        void TerziGetir()
        {
            baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Terzi_atolyesi_proje;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select urun.id, terzi.terzi_adi, urun_kategori.urun_kategori, urun.urun_adi, kalip.kalip,beden.beden,renk.renk, kumas.kumas,kesim.kesim,model.model,urun_detay.adet,urun_detay.fiyat" +
                " FROM urun " +
                "INNER JOIN terzi ON urun.terzi_id = terzi.id " +
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
            terzi_seç_GridView.DataSource = tablo;
            baglanti.Close();
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {

           
              string sorgu = "UPDATE urun SET terzi_id=@terzi";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@terzi", Convert.ToInt32(terzi_comboBox.SelectedItem.ToString().Split('-')[0]));

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            TerziGetir();
        }

        private void siparis_terzi_sec_Load(object sender, EventArgs e)
        {
            TerziGetir();
            TerziSeçimGetir();
        }

        private void terzi_seç_GridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(terzi_seç_GridView.CurrentRow.Cells[0].Value);
            
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            siparis_olustur_urun_bilgi _siparis_olustur_urun_bilgi = new siparis_olustur_urun_bilgi();
            _siparis_olustur_urun_bilgi.Show();
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
            MessageBox.Show("Sipariş Oluşturulmuştur.");
            Menu _menu = new Menu();
            _menu.Show();
            this.Hide();

        }
    }
}
