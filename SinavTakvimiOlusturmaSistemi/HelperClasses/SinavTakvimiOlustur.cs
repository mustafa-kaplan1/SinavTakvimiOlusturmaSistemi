using ClosedXML.Excel;
using SinavTakvimiOlusturmaSistemi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HelperClasses
{
    public class SinavTakvimiOlustur
    {
        private SinavProgramOlustur? form;
        private int sinifSayi;
        private Dictionary<int, List<DateTime>> sinifSaatler; // Her sınıf için kullanılan saat listesi
        private DateTime baslaTarih;
        private DateTime bitisTarih;
        private int baslangicSaat = 10;
        private int baslangicdk = 0;
        private int bitSaat = 17;
        private int sinavSureDk;
        private int molaSureDk;

        private XLWorkbook _workbook;
        private IXLWorksheet _sheet;
        private int _currentRow = 3;

        public void TakvimOlustur(SinavProgramOlustur form)
        {
            this.form = form;
            if (!inputKontrol())
                return;

            sinifSayi = Derslikler.Instance.TumDerslikler.Count;
            sinifSaatler = new Dictionary<int, List<DateTime>>();
            baslaTarih = form.dateTimePicker1.Value;
            bitisTarih = form.dateTimePicker2.Value;
            sinavSureDk = int.Parse(form.textBox1.Text);
            molaSureDk = int.Parse(form.textBox2.Text);

            // Her sınıf için boş saat listesi oluştur
            for (int i = 0; i < sinifSayi; i++)
            {
                sinifSaatler[i] = new List<DateTime>();
            }

            ExcelOlustur();
            DersListesiOku();
            ExcelTarihSirala();
            ExcelHucreBirlestir();
            ExcelKaydet(@"C:\yazlab\vize_programi.xlsx");

            MessageBox.Show("Sınav programı başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool inputKontrol()
        {
            if (!int.TryParse(form.textBox1.Text, out _))
            {
                MessageBox.Show("Sınav süresi sayi icermelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.textBox1.Focus();
                return false;
            }

            if (!int.TryParse(form.textBox2.Text, out _))
            {
                MessageBox.Show("Bekleme süresi sayi icermelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.textBox2.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(form.comboBox1.Text))
            {
                MessageBox.Show("Ders türü seçilmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.comboBox1.Focus();
                return false;
            }

            if (form.checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("En az bir Ders seçimi yapmalisiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.checkedListBox1.Focus();
                return false;
            }

            if (form.dateTimePicker1.Value > form.dateTimePicker2.Value)
            {
                MessageBox.Show("Baslangic tarihi bitis tarihinden sonra olamaz!",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.dateTimePicker1.Focus();
                return false;
            }

            return true;
        }

        private DateTime SonrakiCalismaGunu(DateTime tarih)
        {
            tarih = tarih.AddDays(1);
            while (tarih.DayOfWeek == DayOfWeek.Saturday || tarih.DayOfWeek == DayOfWeek.Sunday)
            {
                tarih = tarih.AddDays(1);
            }
            return tarih;
        }

        // Bir sınıfın belirli tarih ve saatte müsait olup olmadığını kontrol eder
        private bool SinifMusaitMi(int sinifIndex, DateTime tarihSaat)
        {
            if (!sinifSaatler.ContainsKey(sinifIndex))
                return true;

            // Bu sınıfın bu tarih-saatte kullanılıp kullanılmadığını kontrol et
            return !sinifSaatler[sinifIndex].Any(kullanilan =>
                kullanilan.Date == tarihSaat.Date &&
                kullanilan.TimeOfDay == tarihSaat.TimeOfDay);
        }

        // Bir ders için gereken sınıfları kapasiteye göre büyükten küçüğe bul
        private List<(int index, string kod, int kapasite)> CokluSinifBul(int toplamKapasite, DateTime tarihSaat)
        {
            var secilenSiniflar = new List<(int index, string kod, int kapasite)>();
            int kalanKapasite = toplamKapasite;

            // Sınıfları kapasiteye göre büyükten küçüğe sırala
            var musaitSiniflar = new List<(int index, int kapasite, string kod)>();

            for (int i = 0; i < Derslikler.Instance.TumDerslikler.Count; i++)
            {
                // Bu sınıf bu tarih-saatte müsait mi?
                if (!SinifMusaitMi(i, tarihSaat))
                    continue;

                var derslik = Derslikler.Instance.TumDerslikler[i];
                musaitSiniflar.Add((i, derslik.DerslikKapasitesi, derslik.DerslikKodu));
            }

            // Büyükten küçüğe sırala
            musaitSiniflar = musaitSiniflar.OrderByDescending(x => x.kapasite).ToList();

            // Gerekli kapasiteyi karşılayana kadar sınıf ekle
            foreach (var sinif in musaitSiniflar)
            {
                if (kalanKapasite <= 0)
                    break;

                int kullanilacakKapasite = Math.Min(sinif.kapasite, kalanKapasite);
                secilenSiniflar.Add((sinif.index, sinif.kod, kullanilacakKapasite));
                kalanKapasite -= kullanilacakKapasite;
            }

            // Eğer tüm kapasiteyi karşılayamadıysak null döndür
            if (kalanKapasite > 0)
                return null;

            return secilenSiniflar;
        }

        private void DersListesiOku()
        {
            DateTime baslangicSaati = DateTime.Today.AddHours(baslangicSaat).AddMinutes(baslangicdk);
            int sinavArasiBosluk = sinavSureDk + molaSureDk;

            // Kullanılabilir günleri hesapla (hafta sonları hariç)
            var kullanilabilirGunler = new List<DateTime>();
            DateTime gunSayici = baslaTarih;

            while (gunSayici <= bitisTarih)
            {
                if (gunSayici.DayOfWeek != DayOfWeek.Saturday && gunSayici.DayOfWeek != DayOfWeek.Sunday)
                {
                    kullanilabilirGunler.Add(gunSayici);
                }
                gunSayici = gunSayici.AddDays(1);
            }

            if (kullanilabilirGunler.Count == 0)
            {
                MessageBox.Show("Başlangıç ve bitiş tarihleri arasında çalışma günü yok!",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Her gün için dersleri tutacak yapı
            var gunlukPlan = new Dictionary<DateTime, List<(DateTime saat, Ders ders, int kapasite, List<(int index, string kod, int kapasite)> siniflar)>>();

            foreach (var gun in kullanilabilirGunler)
            {
                gunlukPlan[gun] = new List<(DateTime, Ders, int, List<(int, string, int)>)>();
            }

            // Dersleri round-robin şekilde günlere dağıt
            for (int i = 0; i < DersListesi.Instance.TumDersler.Count; i++)
            {
                var ders = DersListesi.Instance.TumDersler[i];

                // Bu dersin hangi güne gideceğini hesapla (round-robin)
                int gunIndex = i % kullanilabilirGunler.Count;
                DateTime hedefTarih = kullanilabilirGunler[gunIndex];

                // Gerekli öğrenci kapasitesini hesapla
                int gerekliKapasite = OgrenciListesi.Instance.TumOgrenciler
                                      .Count(ogr => ogr.OgrenciDersler.Contains(ders.DersKodu));

                if (gerekliKapasite == 0)
                {
                    MessageBox.Show($"Uyarı: '{ders.DersAdi}' dersini alan öğrenci yok!",
                                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                // Bu gün için kaçıncı sınav bu?
                int gunlukSinavSayisi = gunlukPlan[hedefTarih].Count;
                DateTime saat = baslangicSaati.AddMinutes(gunlukSinavSayisi * sinavArasiBosluk);

                // Saat kontrolü
                if (saat.Hour >= bitSaat || (saat.Hour == bitSaat - 1 && saat.AddMinutes(sinavSureDk).Hour >= bitSaat))
                {
                    MessageBox.Show($"Ders saate sığmıyor!\n\n" +
                                    $"Ders: {ders.DersAdi} (İndeks: {i})\n" +
                                    $"Tarih: {hedefTarih.ToShortDateString()}\n" +
                                    $"Bu gündeki sınav sayısı: {gunlukSinavSayisi + 1}\n" +
                                    $"Hesaplanan saat: {saat.ToString("HH:mm")}\n" +
                                    $"Bitiş saati: {bitSaat}:00\n\n" +
                                    $"Çözüm önerileri:\n" +
                                    $"- Bitiş tarihini uzatın (daha fazla gün)\n" +
                                    $"- Sınav süresini kısaltın\n" +
                                    $"- Çalışma saatlerini uzatın (bitiş saatini ilerletin)\n" +
                                    $"- Mola süresini azaltın",
                                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tarih ve saat kombinasyonunu oluştur
                DateTime tarihSaat = hedefTarih.Date.Add(saat.TimeOfDay);

                // Bu tarih-saat için uygun sınıfları bul
                var gerekliSiniflar = CokluSinifBul(gerekliKapasite, tarihSaat);

                if (gerekliSiniflar == null)
                {
                    MessageBox.Show($"Yeterli sınıf bulunamadı!\n\n" +
                                    $"Ders: {ders.DersAdi} (İndeks: {i})\n" +
                                    $"Tarih: {hedefTarih.ToShortDateString()}\n" +
                                    $"Saat: {saat.ToString("HH:mm")}\n" +
                                    $"Gereken Kapasite: {gerekliKapasite}\n" +
                                    $"Toplam Derslik Kapasitesi: {Derslikler.Instance.TumDerslikler.Sum(d => d.DerslikKapasitesi)}\n\n" +
                                    $"Lütfen daha fazla/büyük derslik ekleyin.",
                                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Plana ekle
                gunlukPlan[hedefTarih].Add((saat, ders, gerekliKapasite, gerekliSiniflar));

                // Sınıfları bu tarih-saatte kullanıldı olarak işaretle
                foreach (var sinif in gerekliSiniflar)
                {
                    if (!sinifSaatler.ContainsKey(sinif.index))
                        sinifSaatler[sinif.index] = new List<DateTime>();

                    sinifSaatler[sinif.index].Add(tarihSaat);
                }
            }

            // Plana göre Excel'e yaz
            foreach (var gun in gunlukPlan.OrderBy(x => x.Key))
            {
                foreach (var sinav in gun.Value)
                {
                    foreach (var sinif in sinav.siniflar)
                    {
                        // Derslik bilgisini hazırla
                        string derslikBilgisi = sinav.siniflar.Count > 1
                            ? $"{sinif.kod} ({sinif.kapasite} kişi)"
                            : sinif.kod;

                        // Excel'e ekle
                        ExcelSatirEkle(gun.Key, sinav.saat, sinav.ders.DersAdi, sinav.ders.DersOgretmeni, derslikBilgisi);
                    }
                }
            }
        }

        private void ExcelOlustur()
        {
            _workbook = new XLWorkbook();
            _sheet = _workbook.AddWorksheet("Vize Programi");

            _sheet.Range("A1:E1").Merge();
            _sheet.Cell("A1").Value = "BILGISAYAR MUHENDISLIGI BOLUMU VIZE SINAV PROGRAMI";
            _sheet.Cell("A1").Style.Font.SetBold().Font.SetFontSize(14);
            _sheet.Cell("A1").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

            string[] headers = { "Tarih", "Sinav Saati", "Ders Adi", "Ogretim Elemani", "Derslik" };

            for (int i = 0; i < headers.Length; i++)
            {
                _sheet.Cell(2, i + 1).Value = headers[i];
                _sheet.Cell(2, i + 1).Style.Font.SetBold();
                _sheet.Cell(2, i + 1).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                _sheet.Cell(2, i + 1).Style.Fill.SetBackgroundColor(XLColor.LightGray);
                _sheet.Cell(2, i + 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            }
        }

        private void ExcelSatirEkle(DateTime tarih, DateTime saat, string dersAdi, string ogretmen, string derslik)
        {
            _sheet.Cell(_currentRow, 1).Value = tarih;
            _sheet.Cell(_currentRow, 1).Style.DateFormat.Format = "dd.MM.yyyy";

            _sheet.Cell(_currentRow, 2).Value = saat;
            _sheet.Cell(_currentRow, 2).Style.DateFormat.Format = "HH:mm";

            _sheet.Cell(_currentRow, 3).Value = dersAdi;
            _sheet.Cell(_currentRow, 4).Value = ogretmen;
            _sheet.Cell(_currentRow, 5).Value = derslik;

            for (int i = 1; i <= 5; i++)
            {
                _sheet.Cell(_currentRow, i).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
            }

            _currentRow++;
        }

        private void ExcelTarihSirala()
        {
            var lastRow = _sheet.LastRowUsed().RowNumber();
            if (lastRow > 2)
            {
                var range = _sheet.Range($"A3:E{lastRow}");
                range.Sort(1); // 1. kolona göre sırala (Tarih)
            }
        }

        private void ExcelHucreBirlestir()
        {
            var lastRow = _sheet.LastRowUsed().RowNumber();

            int startRow = 3;
            while (startRow <= lastRow)
            {
                string currentDate = _sheet.Cell(startRow, 1).GetValue<string>();
                int endRow = startRow;

                while (endRow + 1 <= lastRow &&
                       _sheet.Cell(endRow + 1, 1).GetValue<string>() == currentDate)
                {
                    endRow++;
                }

                if (endRow > startRow)
                {
                    _sheet.Range(startRow, 1, endRow, 1).Merge();
                    _sheet.Cell(startRow, 1).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                    _sheet.Cell(startRow, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                }

                startRow = endRow + 1;
            }
        }

        private void ExcelKaydet(string path)
        {
            _sheet.Columns().AdjustToContents();
            _workbook.SaveAs(path);
        }
    }
}