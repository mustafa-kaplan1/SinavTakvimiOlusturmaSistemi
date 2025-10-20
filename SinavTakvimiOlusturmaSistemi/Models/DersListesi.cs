using System;
using System.Collections.Generic;

namespace SinavTakvimiOlusturmaSistemi
{
    public class Ders
    {
        public string DersKodu { get; set; }
        public string DersAdi { get; set; }
        public string DersOgretmeni { get; set; }
        public string BolumAdi { get; set; }
        public string DersYili { get; set; }
    }

    public class DersListesi
    {
        // Singleton instance
        private static DersListesi? instance = null;
        public static DersListesi Instance
        {
            get
            {
                if (instance == null)
                    instance = new DersListesi();
                return instance;
            }
        }

        // Tüm dersliklerin listesi
        public List<Ders> TumDersler { get; set; } = new List<Ders>();

        // Private constructor
        private DersListesi() { }

        // Derslik ekleme metodu (istege bagli)
        public void DersEkle(Ders ders)
        {
            TumDersler.Add(ders);
        }
    }
}
