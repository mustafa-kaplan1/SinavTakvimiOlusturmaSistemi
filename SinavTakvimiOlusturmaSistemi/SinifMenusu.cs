using Microsoft.Data.SqlClient;
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
    public partial class SinifMenusu : Form
    {
        public SinifMenusu()
        {
            InitializeComponent();

            textBox1.ReadOnly = true;
            textBox1.Text = KullaniciBilgileri.Instance.AdminRol;
        }

        private void buttonYeniSınıf_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            panelYeniSinif.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelYeniSinif.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };

            // Tüm textboxlar dolu mu kontrol et
            foreach (TextBox tb in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    MessageBox.Show("Lutfen tum alanlari doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // TextBox 4-7 int mi kontrol et
            int derslikKapasitesi, enineSira, boyunaSira, siraYapisi;
            if (!int.TryParse(textBox4.Text, out derslikKapasitesi) ||
                !int.TryParse(textBox5.Text, out enineSira) ||
                !int.TryParse(textBox6.Text, out boyunaSira) ||
                !int.TryParse(textBox7.Text, out siraYapisi))
            {
                MessageBox.Show("Derslik Kapasitesi, Enine Sira, Boyuna Sira ve Sira Yapisi alanlari sayi olmalidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Onay mesajı, textbox değerleriyle birlikte
            string message = $"Bölüm Adi: {textBox1.Text}\n" +
                             $"Derslik Kodu: {textBox2.Text}\n" +
                             $"Derslik Adi: {textBox3.Text}\n" +
                             $"Derslik Kapasitesi: {textBox4.Text}\n" +
                             $"Enine Sira Sayisi: {textBox5.Text}\n" +
                             $"Boyuna Sira Sayisi: {textBox6.Text}\n" +
                             $"Sira yapisi: {textBox7.Text}\n\n" +
                             "Bu özelliklerde sınıf eklenmesini onayliyor musunuz?";

            DialogResult result = MessageBox.Show(
                message,
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Kullanıcı onayladıysa buraya sınıf ekleme kodunu yaz
                MessageBox.Show("Sınıf eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Derslik yeniDerslik = new Derslik // formaki verileri Derslik class türünde tuttuk
                {
                    BolumAdi = textBox1.Text,
                    DerslikKodu = textBox2.Text,
                    DerslikAdi = textBox3.Text,
                    DerslikKapasitesi = int.Parse(textBox4.Text),
                    EnineSiraSayisi = int.Parse(textBox5.Text),
                    BoyunaSiraSayisi = int.Parse(textBox6.Text),
                    SiraYapisi = textBox7.Text
                };

                Derslikler.Instance.DerslikEkle(yeniDerslik); // Derslikler classını yoksa oluşturduk, derslik ekledik

                DerslikDAL.DerslikEkle(yeniDerslik); // veritabanına eklendi

                panelYeniSinif.Hide();
            }
        }

        private void butonExit_Click(object sender, EventArgs e)
        {
            BolumKoordinatoru koordinatorSf = new BolumKoordinatoru();
            koordinatorSf.Show();
            this.Hide();
        }
    }
}
