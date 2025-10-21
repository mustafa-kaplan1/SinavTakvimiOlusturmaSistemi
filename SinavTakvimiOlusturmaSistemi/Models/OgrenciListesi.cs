using System;
using System.Collections.Generic;

namespace SinavTakvimiOlusturmaSistemi
{
    public class Ogrenci
    {
        public string OgrenciNo { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSinif { get; set; }
        public List<string> OgrenciDersler { get; set; } = new List<string>();
    }

    public class OgrenciListesi
    {
        private static OgrenciListesi? instance = null;
        public static OgrenciListesi Instance
        {
            get
            {
                if (instance == null)
                    instance = new OgrenciListesi();
                return instance;
            }
        }
        public List<Ogrenci> TumOgrenciler { get; set; } = new List<Ogrenci>();

        private OgrenciListesi() { }

        public void OgrenciEkle(Ogrenci o)
        {
            TumOgrenciler.Add(o);
        }
    }
}