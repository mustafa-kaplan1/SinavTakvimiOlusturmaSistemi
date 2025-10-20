using Microsoft.Data.SqlClient;
using SinavTakvimiOlusturmaSistemi;
using System.Collections.Generic;
using System;

public static class DersListesiDAL // (DAL – Data Access Layer)
{
    private static string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Yazlab1SinavOlustur;Trusted_Connection=True;TrustServerCertificate=True;";

    // Modeldeki tüm dersleri veritabanına ekler
    public static void DersListesiEkle()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            DersListesiSil();
            con.Open();
            string query = "INSERT INTO Dersler (DersKodu, DersAdi, DersOgretmeni, BolumAdi, DersYili) " +
                           "VALUES (@DersKodu, @DersAdi, @DersOgretmeni, @BolumAdi, @DersYili)";

            foreach (var ders in DersListesi.Instance.TumDersler)
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DersKodu", ders.DersKodu);
                    cmd.Parameters.AddWithValue("@DersAdi", ders.DersAdi);
                    cmd.Parameters.AddWithValue("@DersOgretmeni", ders.DersOgretmeni);
                    cmd.Parameters.AddWithValue("@BolumAdi", ders.BolumAdi);
                    cmd.Parameters.AddWithValue("@DersYili", ders.DersYili);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    // Veritabanındaki Dersler tablosunu tamamen siler
    public static void DersListesiSil()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "DELETE FROM Dersler";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Singleton'daki listeyi sıfırlayıp veritabanından doldurur
    public static void DersListesiGetir()
    {
        // Önce singleton listeyi temizle
        DersListesi.Instance.TumDersler.Clear();

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            string query = "SELECT * FROM Dersler";
            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Ders d = new Ders
                    {
                        DersKodu = reader["DersKodu"].ToString(),
                        DersAdi = reader["DersAdi"].ToString(),
                        DersOgretmeni = reader["DersOgretmeni"].ToString(),
                        BolumAdi = reader["BolumAdi"].ToString(),
                        DersYili = reader["DersYili"].ToString()
                    };
                    DersListesi.Instance.DersEkle(d);
                }
            }
        }
    }
}