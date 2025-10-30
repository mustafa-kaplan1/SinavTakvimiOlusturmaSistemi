using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelperClasses;

namespace SinavTakvimiOlusturmaSistemi
{
    public partial class SinavProgramOlustur : Form
    {
        public SinavProgramOlustur()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            BolumKoordinatoru k = new BolumKoordinatoru();
            k.Show();
            this.Hide();
        }

        private void SinavProgramOlustur_Load(object sender, EventArgs e)
        {
            CheckedListBox1DerslerileYukle();
        }

        private void CheckedListBox1DerslerileYukle()
        {
            checkedListBox1.Items.Clear();

            foreach (var ders in DersListesi.Instance.TumDersler)
            {
                string dersGosterim = $"{ders.DersKodu} - {ders.DersAdi} ({ders.DersOgretmeni})";
                checkedListBox1.Items.Add(dersGosterim);
            }

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            var takvim = new SinavTakvimiOlustur();
            takvim.TakvimOlustur(this);
        }
    }
}
