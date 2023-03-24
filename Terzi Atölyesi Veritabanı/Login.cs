using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Terzi_Atölyesi_Veritabanı
{
    public partial class Login : Form
    {
        SqlConnection baglanti;
        SqlDataReader dr;
        SqlCommand komut;
        public Login()
        {
            InitializeComponent();
        }

        private void id_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = username_tb.Text;
            string password = password_tb.Text;
            baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Terzi_atolyesi_proje;Integrated Security=True");
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select*From kullanici where kullanici_adi='" + user + "'And sifre='" + password + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                //MessageBox.Show("Giriş Başarılı!");
                Menu _menu = new Menu();
                _menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
            baglanti.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void password_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void password_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string user = username_tb.Text;
                string password = password_tb.Text;
                baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Terzi_atolyesi_proje;Integrated Security=True");
                komut = new SqlCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Select*From kullanici where kullanici_adi='" + user + "'And sifre='" + password + "'";
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    //MessageBox.Show("Giriş Başarılı!");
                    Menu _menu = new Menu();
                    _menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }
                baglanti.Close();
            }
        }
    }
    }

