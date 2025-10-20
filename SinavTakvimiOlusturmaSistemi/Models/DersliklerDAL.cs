using Microsoft.Data.SqlClient;
using SinavTakvimiOlusturmaSistemi;

public static class DerslikDAL // (DAL – Data Access Layer)
{
    private static string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Yazlab1SinavOlustur;Trusted_Connection=True;TrustServerCertificate=True;";
    public static void DerslikEkle(Derslik derslik)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            string query = "INSERT INTO Derslikler (BolumAdi, DerslikKodu, DerslikAdi, DerslikKapasitesi, EnineSiraSayisi, BoyunaSiraSayisi, SiraYapisi) " +
                           "VALUES (@BolumAdi, @DerslikKodu, @DerslikAdi, @DerslikKapasitesi, @EnineSiraSayisi, @BoyunaSiraSayisi, @SiraYapisi)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@BolumAdi", derslik.BolumAdi);
                cmd.Parameters.AddWithValue("@DerslikKodu", derslik.DerslikKodu);
                cmd.Parameters.AddWithValue("@DerslikAdi", derslik.DerslikAdi);
                cmd.Parameters.AddWithValue("@DerslikKapasitesi", derslik.DerslikKapasitesi);
                cmd.Parameters.AddWithValue("@EnineSiraSayisi", derslik.EnineSiraSayisi);
                cmd.Parameters.AddWithValue("@BoyunaSiraSayisi", derslik.BoyunaSiraSayisi);
                cmd.Parameters.AddWithValue("@SiraYapisi", derslik.SiraYapisi);

                cmd.ExecuteNonQuery();
            }
        }
    }

    public static List<Derslik> TumDerslikleriGetir()
    {
        List<Derslik> derslikListesi = new List<Derslik>();

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            string query = "SELECT * FROM Derslikler";

            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Derslik d = new Derslik
                    {
                        BolumAdi = reader["BolumAdi"].ToString(),
                        DerslikKodu = reader["DerslikKodu"].ToString(),
                        DerslikAdi = reader["DerslikAdi"].ToString(),
                        DerslikKapasitesi = Convert.ToInt32(reader["DerslikKapasitesi"]),
                        EnineSiraSayisi = Convert.ToInt32(reader["EnineSiraSayisi"]),
                        BoyunaSiraSayisi = Convert.ToInt32(reader["BoyunaSiraSayisi"]),
                        SiraYapisi = Convert.ToInt32(reader["SiraYapisi"])
                    };
                    derslikListesi.Add(d);
                }
            }
        }

        return derslikListesi;
    }

}
