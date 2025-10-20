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
    public partial class SinifDetay : Form
    {
        string derslikKod;
        public SinifDetay(string derslikKod)
        {
            InitializeComponent();

            this.derslikKod = derslikKod;
            this.Paint += SiraCiz;
        }

        private void SinifDetay_Load(object sender, EventArgs e)
        {
            Derslik d = Derslikler.Instance.TumDerslikler.FirstOrDefault(d => d.DerslikKodu == derslikKod);

            labelSinifOzellik.Text =
                $"Bolum Adi: {d.BolumAdi}, " +
                $"Derslik Kodu: {d.DerslikKodu}, " +
                $"Derslik Adi: {d.DerslikAdi}, " +
                $"Derslik Kapasitesi: {d.DerslikKapasitesi}, " +
                $"Enine Sira Sayisi: {d.EnineSiraSayisi}, " +
                $"Boyuna Sira Sayisi: {d.BoyunaSiraSayisi}, " +
                $"Sira Yapisi: {d.SiraYapisi}";
        }

        private void SiraCiz(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int offset = 30;
            int kareBoyutu = 20;

            // Örnek: 5x5 kareler
            Derslik d = Derslikler.Instance.TumDerslikler.FirstOrDefault(d => d.DerslikKodu == derslikKod);
            int yatay = d.EnineSiraSayisi;
            int dikey = d.BoyunaSiraSayisi;
            int tip = d.SiraYapisi;

            for (int x = 0; x < tip * yatay + (yatay - 1); x++)
            {
                for (int y = 0; y < dikey * 2; y++)
                {
                    if (x % (tip + 1) != tip && y % 2 == 1)
                    {
                        int px = offset + x * kareBoyutu;
                        int py = offset + y * kareBoyutu;
                        // Kareyi çiz
                        g.FillRectangle(Brushes.LightBlue, px, py, kareBoyutu, kareBoyutu);
                        g.DrawRectangle(Pens.Black, px, py, kareBoyutu, kareBoyutu);
                    }
                }
            }
        }

        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            SinifMenusu sinifMenu = new SinifMenusu();
            sinifMenu.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
            $"Derslik Kodu {derslikKod} olan sınıf silinecek. Emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Kullanıcı onayladıysa silme işlemi
                Derslik d = Derslikler.Instance.TumDerslikler.FirstOrDefault(d => d.DerslikKodu == derslikKod);
                if (d != null)
                {
                    Derslikler.Instance.TumDerslikler.Remove(d);
                    DerslikDAL.DerslikSil(d.DerslikKodu);
                    MessageBox.Show("Derslik silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Derslik bulunamadi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Kullanıcı hayır dedi
                MessageBox.Show("İşlem iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
