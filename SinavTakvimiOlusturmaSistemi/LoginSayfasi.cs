using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;



namespace SinavTakvimiOlusturmaSistemi
{
    public partial class LoginSayfasi : OrtakStilForm
    {
        public LoginSayfasi()
        {
            InitializeComponent();
        }

        private void LoginSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void girisyapButton_Click(object sender, EventArgs e)
        {
            string eposta = epostaTextBox.Text.Trim();
            string sifre = SifreTextBox.Text.Trim();

            if (string.IsNullOrEmpty(eposta) || string.IsNullOrEmpty(sifre))
            {
                hatamesajLabel.Show();
                hatamesajLabel.Text = "Eposta ve sifre bos birakilamaz!";
            }

            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Yazlab1SinavOlustur;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM Kullanici WHERE KullaniciEposta=@eposta AND Sifre=@sifre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@eposta", eposta);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Verileri modelimize aktar
                                KullaniciBilgileri.Instance.Eposta = reader["KullaniciEposta"].ToString();
                                KullaniciBilgileri.Instance.Rol = reader["KullaniciTipi"].ToString();

                                GirisYap();
                            }
                            else
                            {
                                hatamesajLabel.Text = "Eposta veya sifre hatali!";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

            }
        }

        private void GirisYap()
        {
            string kullaniciRol = KullaniciBilgileri.Instance.Rol;
            if (kullaniciRol == "Admin")
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                this.Hide();
            }
            else
            {
                BolumKoordinatoru bolumKoordinatorSayfasi = new BolumKoordinatoru(0);
                bolumKoordinatorSayfasi.Show();
                this.Hide();
            }
        }
    }
}
