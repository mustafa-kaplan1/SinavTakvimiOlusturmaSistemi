using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace SinavTakvimiOlusturmaSistemi
{
    public partial class DersListesiMenusu : Form
    {
        public DersListesiMenusu()
        {
            InitializeComponent();
        }

        private void DersListesiMenusu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DersListesi.Instance.TumDersler;
        }

        private void butonExit_Click(object sender, EventArgs e)
        {
            BolumKoordinatoru koordinator = new BolumKoordinatoru();
            koordinator.Show();
            this.Hide();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Excel dosyası seçin";
                ofd.Filter = "Excel Dosyaları|*.xlsx;*.xls";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string secilenDosyaYolu = ofd.FileName;
                    MessageBox.Show("Seçilen dosya: " + secilenDosyaYolu);

                    DersOku(secilenDosyaYolu);
                    dataGridView1.DataSource = DersListesi.Instance.TumDersler;
                }
            }
        }

        public void DersOku(string excelDosyaYolu)
        {
            var dersler = new List<Ders>();

            using (var workbook = new XLWorkbook(excelDosyaYolu))
            {
                var worksheet = workbook.Worksheet(1); // 1. sayfa
                var rows = worksheet.RangeUsed().RowsUsed();
                string dersYil = "0";
                foreach (var row in rows)
                {
                    if (row.Cell(1).IsMerged())
                    {
                        dersYil = row.Cell(1).GetValue<string>();
                        continue;
                    }
                    else if (row.Cell(1).GetValue<string>() == "DERS KODU")
                    {
                        continue;
                    }

                    Ders d = new Ders
                    {
                        DersKodu = row.Cell(1).GetValue<string>(),
                        DersAdi = row.Cell(2).GetValue<string>(),
                        DersOgretmeni = row.Cell(3).GetValue<string>(),
                        BolumAdi = KullaniciBilgileri.Instance.AdminRol,
                        DersYili = dersYil
                    };
                    DersListesi.Instance.DersEkle(d);
                }
            }

            return;
        }
    }
}
