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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
                DialogResult result = MessageBox.Show(
                    $"Epostasi '{textBox1.Text}', sifresi '{textBox2.Text}', rolu '{comboBox1.Text}' olan kullanici eklenecektir. Emin misiniz?",
                    "Ekleme Onayi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Kullanici ekleme islemi burada yapilir
                    MessageBox.Show("Kullanici eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Islem iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.SelectedIndex = -1;
                groupBox1.Hide();
            }
            else
            {
                MessageBox.Show("Eksik bilgi! Lutfen tum alanlari doldurun.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kullaniciEkle_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            groupBox1.Hide();
        }

        private void CikisBtn_Click(object sender, EventArgs e)
        {
            LoginSayfasi loginSayfasi = new LoginSayfasi();
            loginSayfasi.Show();
            this.Hide();
        }

        private void KoordinatorSayfasiAc()
        {
            BolumKoordinatoru bolumKoordinatorSayfasi = new BolumKoordinatoru();
            bolumKoordinatorSayfasi.Show();
            this.Hide();
        }

        private void BolumBilgisayar_Click(object sender, EventArgs e)
        {
            KullaniciBilgileri.Instance.AdminRol = "Bilgisayar Muhendisligi";
            KoordinatorSayfasiAc();
        }

        private void BolumYazilim_Click(object sender, EventArgs e)
        {
            KullaniciBilgileri.Instance.AdminRol = "Yazilim Muhendisligi";
            KoordinatorSayfasiAc();
        }

        private void BolumElektrik_Click(object sender, EventArgs e)
        {KullaniciBilgileri.Instance.AdminRol = "Elektrik Muhendisligi";  
            KoordinatorSayfasiAc();
        }

        private void BolumElektronik_Click(object sender, EventArgs e)
        {KullaniciBilgileri.Instance.AdminRol = "Elektronik Muhendisligi";
            KoordinatorSayfasiAc();
        }

        private void Bolumİnsaat_Click(object sender, EventArgs e)
        {KullaniciBilgileri.Instance.AdminRol = "Insaat Muhendisligi";
            KoordinatorSayfasiAc();
        }
    }
}
