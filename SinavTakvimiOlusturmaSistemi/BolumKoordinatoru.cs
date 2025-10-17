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
    public partial class BolumKoordinatoru : Form
    {
        private int bolumKodu;
        private string bolumAdi;
        private bool isAdmin;
        public BolumKoordinatoru(int adminRol)
        {

            InitializeComponent();

            this.isAdmin = isAdmin;
            this.bolumKodu = bolumKodu;
            bolumAdi = BolumAdiGetir(bolumKodu);
            this.Text = bolumAdi + " Koordinatorlugu"; // Form basligi degistirilir
            labelBolumAdi.Text = bolumAdi + " Koordinatorlugu";

            if(isAdmin)
                buttonAdminMenu.Text = "Admin Menüsüne Dön";
        }

        private void DersListeYukleButton_Click(object sender, EventArgs e)
        {

        }

        private void BolumKoordinatoru_Load(object sender, EventArgs e)
        {

        }

        private string BolumAdiGetir(int kod)
        {
            switch (kod)
            {
                case 0:
                    return "Bilgisayar Muhendisligi";
                case 1:
                    return "Yazilim Muhendisligi";
                case 2:
                    return "Elektrik Muhendisligi";
                case 3:
                    return "Elektronik Muhendisligi";
                case 4:
                    return "Insaat Muhendisligi";
                default:
                    return "Bilinmeyen Bolum";
            }
        }

        private void buttonAdminMenu_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                this.Hide();
            }
            else
            {
                LoginSayfasi loginSayfasi = new LoginSayfasi();
                loginSayfasi.Show();
                this.Hide();
            }
        }
    }
}
