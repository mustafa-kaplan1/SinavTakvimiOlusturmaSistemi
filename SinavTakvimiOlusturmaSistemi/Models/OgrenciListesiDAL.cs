using Microsoft.Data.SqlClient;
using SinavTakvimiOlusturmaSistemi;
using System.Collections.Generic;
using System;

public static class OgrenciListesiDAL
{
    private static string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Yazlab1SinavOlustur;Trusted_Connection=True;TrustServerCertificate=True;";
    
    public static void ModelToSql()
    {
        SqlTabloSil();
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            string query1 = "INSERT INTO Ogrenciler (OgrenciNo, OgrenciAd, OgrenciSinif) " +
                           "VALUES (@OgrenciNo, @OgrenciAd, @OgrenciSinif)";

            string query2 = "INSERT INTO OgrenciDersler (OgrenciNo, DersKodu) VALUES (@OgrenciNo, @DersKodu)";

            foreach (var ogrenci in OgrenciListesi.Instance.TumOgrenciler)
            {
                using (SqlCommand cmd1 = new SqlCommand(query1, con))
                {
                    cmd1.Parameters.AddWithValue("@OgrenciNo", ogrenci.OgrenciNo);
                    cmd1.Parameters.AddWithValue("@OgrenciAd", ogrenci.OgrenciAd);
                    cmd1.Parameters.AddWithValue("@OgrenciSinif", ogrenci.OgrenciSinif);
                    cmd1.ExecuteNonQuery();
                    foreach(string ders in ogrenci.OgrenciDersler)
                    {
                        using (SqlCommand cmd2 = new SqlCommand(query2, con))
                        {
                            cmd2.Parameters.AddWithValue("@OgrenciNo", ogrenci.OgrenciNo);
                            cmd2.Parameters.AddWithValue("@DersKodu", ders);
                            cmd2.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }

    public static void SqlToModel()
    {
        // Listeyi temizle
        OgrenciListesi.Instance.TumOgrenciler.Clear();

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();

            // Önce öğrencileri çek
            string query1 = "SELECT * FROM Ogrenciler";
            using (SqlCommand cmd = new SqlCommand(query1, con))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Ogrenci o = new Ogrenci
                    {
                        OgrenciNo = reader["OgrenciNo"].ToString(),
                        OgrenciAd = reader["OgrenciAd"].ToString(),
                        OgrenciSinif = reader["OgrenciSinif"].ToString(),
                    };
                    OgrenciListesi.Instance.OgrenciEkle(o);
                }
            }

            // Sonra her öğrenci için derslerini çek
            foreach (var ogrenci in OgrenciListesi.Instance.TumOgrenciler)
            {
                string query2 = "SELECT DersKodu FROM OgrenciDersler WHERE OgrenciNo = @OgrenciNo";
                using (SqlCommand cmd = new SqlCommand(query2, con))
                {
                    cmd.Parameters.AddWithValue("@OgrenciNo", ogrenci.OgrenciNo);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ogrenci.OgrenciDersler.Add(reader["DersKodu"].ToString());
                        }
                    }
                }
            }
        }
    }

    public static void SqlTabloSil()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            string query1 = "DELETE FROM OgrenciDersler";
            using (SqlCommand cmd = new SqlCommand(query1, conn))
            {
                cmd.ExecuteNonQuery();
            }

            string query2 = "DELETE FROM Ogrenciler";
            using (SqlCommand cmd = new SqlCommand(query2, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}