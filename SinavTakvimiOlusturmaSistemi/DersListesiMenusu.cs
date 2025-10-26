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
            DersListesiDAL.SqlToModel();
            dataGridView1.DataSource = DersListesi.Instance.TumDersler;
            dataGridBtnEkle();
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
                    DersListesiDAL.ModelToSql();

                    dataGridView1.DataSource = DersListesi.Instance.TumDersler;
                    dataGridBtnEkle();
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
        }

        private void buttonGroupBoxKapat_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
        private void dataGridBtnEkle()
        {
            DataGridViewButtonColumn btn_col = new DataGridViewButtonColumn();
            btn_col.HeaderText = "+";
            btn_col.Name = "detayBtn";
            btn_col.Text = "Ders Bilgi";
            btn_col.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn_col);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["detayBtn"].Index && e.RowIndex >= 0)
            {
                string? dersKod = dataGridView1.Rows[e.RowIndex].Cells["DersKodu"].Value.ToString();
                detayGoster(dersKod);
            }
        }
        private void buttonAra_Click(object sender, EventArgs e)
        {
                string dersKod = textBoxAra.Text;
            if (!string.IsNullOrEmpty(dersKod))
            {
                detayGoster(dersKod);
            }
        }
        private void detayGoster(string dersKodu)
        {
            Ders? ders = DersListesi.Instance.TumDersler.FirstOrDefault(d => d.DersKodu == dersKodu);
            if (ders != null)
            {
                panel1.Show();
                label3.Text = ders.DersAdi;
                string content = "";

                foreach (var ogrenci in OgrenciListesi.Instance.TumOgrenciler)
                {
                    foreach (string s in ogrenci.OgrenciDersler)
                    {
                        if (s == dersKodu)
                        {
                            content += ogrenci.OgrenciNo + " - " + ogrenci.OgrenciAd + "\n";
                            continue;
                        }
                    }
                }
                label2.Text = content;
            }
        }
    }
}
