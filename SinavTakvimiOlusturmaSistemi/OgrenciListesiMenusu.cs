using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavTakvimiOlusturmaSistemi
{
    public partial class OgrenciListesiMenusu : Form
    {
        public OgrenciListesiMenusu()
        {
            InitializeComponent();
        }
        private void OgrenciListesiMenusu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OgrenciListesi.Instance.TumOgrenciler;
            dataGridBtnEkle();
        }

        private void butonExit_Click(object sender, EventArgs e)
        {
            BolumKoordinatoru k = new BolumKoordinatoru();
            k.Show();
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

                    ExcelOku(secilenDosyaYolu);
                    OgrenciListesiDAL.ModelToSql();

                    dataGridView1.DataSource = OgrenciListesi.Instance.TumOgrenciler;
                    dataGridBtnEkle();
                }
            }
        }

        private void ExcelOku(string path)
        {
            var ogrenciler = new List<Ogrenci>();

            using (var workbook = new XLWorkbook(path))
            {
                var worksheet = workbook.Worksheet(1);

                string ogrenciNo = worksheet.Cell(2, 1).GetValue<string>();
                Ogrenci n = new Ogrenci
                {
                    OgrenciNo = ogrenciNo,
                    OgrenciAd = worksheet.Cell(2, 2).GetValue<string>(),
                    OgrenciSinif = worksheet.Cell(2, 3).GetValue<string>(),
                };
                OgrenciListesi.Instance.OgrenciEkle(n);
                n.OgrenciDersler.Add(worksheet.Cell(2, 4).GetValue<string>());

                var rows = worksheet.RangeUsed().RowsUsed().Skip(2);
                foreach (var row in rows)
                {
                    if (ogrenciNo != row.Cell(1).GetValue<string>())
                    {
                        ogrenciNo = row.Cell(1).GetValue<string>();
                        Ogrenci o = new Ogrenci
                        {
                            OgrenciNo = ogrenciNo,
                            OgrenciAd = row.Cell(2).GetValue<string>(),
                            OgrenciSinif = row.Cell(3).GetValue<string>()
                        };
                        OgrenciListesi.Instance.OgrenciEkle(o);
                        o.OgrenciDersler.Add(row.Cell(4).GetValue<string>());
                    }
                    else
                    {
                        Ogrenci? o = OgrenciListesi.Instance.TumOgrenciler.FirstOrDefault(o => o.OgrenciNo == ogrenciNo);
                        if (o != null)
                            o.OgrenciDersler.Add(row.Cell(4).GetValue<string>());
                    }
                }
            }
        }

        private void buttonGroupBoxKapat_Click(object sender, EventArgs e)
        {
            groupBoxOgrenciBilgi.Hide();
        }

        private void dataGridBtnEkle()
        {
            DataGridViewButtonColumn btn_col = new DataGridViewButtonColumn();
            btn_col.HeaderText = "+";
            btn_col.Name = "detayBtn";
            btn_col.Text = "Öğrenci Bilgi";
            btn_col.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn_col);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["detayBtn"].Index && e.RowIndex >= 0)
            {
                string? ogrenciNo = dataGridView1.Rows[e.RowIndex].Cells["OgrenciNo"].Value.ToString();

                detayGoster(ogrenciNo);
            }
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            string ogrenciNo = textBoxAra.Text;
            if (!string.IsNullOrEmpty(ogrenciNo))
            {
                detayGoster(ogrenciNo);
                return;
            }
            MessageBox.Show("geçersiz değer");
        }

        private void detayGoster(string ogrenciNo)
        {
            Ogrenci? ogrenci = OgrenciListesi.Instance.TumOgrenciler.FirstOrDefault(d => d.OgrenciNo == ogrenciNo);
            if (ogrenci != null)
            {
                groupBoxOgrenciBilgi.Show();
                groupBoxOgrenciBilgi.Text = ogrenci.OgrenciAd;
                string content = "";
                foreach (string s in ogrenci.OgrenciDersler)
                {
                    Ders? ders = DersListesi.Instance.TumDersler.FirstOrDefault(d => d.DersKodu == s);
                    if (ders != null)
                        content += ders.DersAdi + " (Kodu: " + s + ")\n";
                }
                label2.Text = content;
            }
        }
    }
}
