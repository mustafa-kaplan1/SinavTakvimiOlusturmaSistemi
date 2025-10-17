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

            string connectionString = "Data Source=.;Initial Catalog=Yazlab1SinavOlustur;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM Kullanici WHERE KullaniciEposta = @eposta AND Sifre = @sifre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@eposta", eposta);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string kullanici_tipi = reader["KullaniciTipi"].ToString();
                                GirisYap();
                            }
                            else
                            {
                                MessageBox.Show("Eposta veya sifre hatali!");
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

        }
    }
}
