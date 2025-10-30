using ClosedXML.Excel;
using SinavTakvimiOlusturmaSistemi;
using System;
using System.Windows.Forms;

namespace HelperClasses
{
    public class SinavTakvimiOlustur
    {
        private SinavProgramOlustur? form;
        private int sinifSayi;
        private DateTime[] siniflar;
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
            siniflar = new DateTime[sinifSayi];
            baslaTarih = form.dateTimePicker1.Value;
            bitisTarih = form.dateTimePicker2.Value;
            sinavSureDk = int.Parse(form.textBox1.Text);
            molaSureDk = int.Parse(form.textBox2.Text);

            for (int i = 0; i < sinifSayi; i++)
            {
                siniflar[i] = baslaTarih.AddDays(-1);
            }

            ExcelOlustur();
            DersListesiOku();
            ExcelTarihSirala();
            ExcelHucreBirlestir();
            ExcelKaydet(@"C:\yazlab\vize_programi.xlsx");
        }

        private bool inputKontrol()
        {
            // textBox1 int mi kontrol et
            if (!int.TryParse(form.textBox1.Text, out _))
            {
                MessageBox.Show("Sınav süresi sayi icermelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.textBox1.Focus();
                return false;
            }

            // textBox2 int mi kontrol et
            if (!int.TryParse(form.textBox2.Text, out _))
            {
                MessageBox.Show("Bekleme süresi sayi icermelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.textBox2.Focus();
                return false;
            }

            // comboBox1 seçim yapılmış mı
            if (string.IsNullOrEmpty(form.comboBox1.Text))
            {
                MessageBox.Show("Ders türü seçilmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.comboBox1.Focus();
                return false;
            }

            // checkedListBox1 en az bir seçim yapılmış mı
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

            // Tüm kontroller geçtiyse
            return true;
        }

        private int idealSinif(int gerekliKapasite, DateTime tarih) // dersi alan öğrenci saysı için yeterli en düşük kapasiteli sınıf indeksini verir
        {
            int uygunIndex = -1;
            int enKucukKapasite = int.MaxValue;

            for (int i = 0; i < Derslikler.Instance.TumDerslikler.Count; i++)
            {
                var derslik = Derslikler.Instance.TumDerslikler[i];

                // Zaten dolu siniflari atla
                if (siniflar[i] >= tarih)
                    continue;

                MessageBox.Show(derslik.DerslikKapasitesi.ToString());

                if (derslik.DerslikKapasitesi >= gerekliKapasite && derslik.DerslikKapasitesi < enKucukKapasite)
                {
                    enKucukKapasite = derslik.DerslikKapasitesi;
                    uygunIndex = i;
                }
            }
            MessageBox.Show("Gerekli Kapasite: " + gerekliKapasite.ToString());
            MessageBox.Show("En Kucuk Kapasite: " + enKucukKapasite.ToString());


            return uygunIndex;
        }

        private void DersListesiOku()
        {
            DateTime tarih = baslaTarih;
            DateTime saat = DateTime.Today.AddHours(baslangicSaat).AddMinutes(baslangicdk);
            string derslikKodu = "";
            int sinavArasiBosluk = sinavSureDk + molaSureDk;
            int gerekliKapasite;

            

            for (int i = 0; i < DersListesi.Instance.TumDersler.Count; i++)
            {
                var ders = DersListesi.Instance.TumDersler[i];
                while (tarih.DayOfWeek == DayOfWeek.Saturday || tarih.DayOfWeek == DayOfWeek.Sunday)
                    tarih = tarih.AddDays(1);
                if (tarih > bitisTarih) 
                { 
                    tarih = baslaTarih;
                    saat = saat.AddMinutes(sinavArasiBosluk);
                    while (tarih.DayOfWeek == DayOfWeek.Saturday || tarih.DayOfWeek == DayOfWeek.Sunday)
                        tarih = tarih.AddDays(1);
                }
                if (saat.AddMinutes(sinavArasiBosluk).Hour > bitSaat)
                {
                    // hata
                }
                gerekliKapasite = OgrenciListesi.Instance.TumOgrenciler
                                  .Count(ogr => ogr.OgrenciDersler.Contains(ders.DersKodu));
                int sinifIndex = idealSinif(gerekliKapasite, tarih);
                derslikKodu = Derslikler.Instance.TumDerslikler[sinifIndex].DerslikKodu;
                siniflar[sinifIndex] = tarih;


                ExcelSatirEkle(tarih, saat, ders.DersAdi, ders.DersOgretmeni, derslikKodu);
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
            // Veri araligini bul: 2. satir header, veri 3.satirdan basliyor
            var lastRow = _sheet.LastRowUsed().RowNumber();
            var range = _sheet.Range($"A2:E{lastRow}");

            range.Sort("A3", XLSortOrder.Ascending); // A sutununa gore artan siralama
        }

        private void ExcelHucreBirlestir()
        {
            var lastRow = _sheet.LastRowUsed().RowNumber();

            int startRow = 3; // veri 3. satirdan basliyor
            while (startRow <= lastRow)
            {
                string currentDate = _sheet.Cell(startRow, 1).GetValue<string>();
                int endRow = startRow;

                // ardısık aynı tarihleri bul
                while (endRow + 1 <= lastRow &&
                       _sheet.Cell(endRow + 1, 1).GetValue<string>() == currentDate)
                {
                    endRow++;
                }

                // birden fazla satır varsa birleştir
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
