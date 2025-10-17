using System;
using System.Collections.Generic;

namespace SinavTakvimiOlusturmaSistemi
{
    public class Derslik
    {
        public string BolumAdi { get; set; }
        public string DerslikKodu { get; set; }
        public string DerslikAdi { get; set; }
        public int DerslikKapasitesi { get; set; }
        public int EnineSiraSayisi { get; set; }  // Sutun sayisi
        public int BoyunaSiraSayisi { get; set; } // Satir sayisi
        public string SiraYapisi { get; set; }    // Ornegin "2'li" veya "3'erli"
    }

    public class Derslikler
    {
        // Singleton instance
        private static Derslikler? instance = null;
        public static Derslikler Instance
        {
            get
            {
                if (instance == null)
                    instance = new Derslikler();
                return instance;
            }
        }

        // Tüm dersliklerin listesi
        public List<Derslik> TumDerslikler { get; set; } = new List<Derslik>();

        // Private constructor
        private Derslikler() { }

        // Derslik ekleme metodu (istege bagli)
        public void DerslikEkle(Derslik derslik)
        {
            TumDerslikler.Add(derslik);
        }
    }
}
