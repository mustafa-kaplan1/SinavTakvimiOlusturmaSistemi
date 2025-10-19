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
        string rol;
        public BolumKoordinatoru()
        {
            InitializeComponent();

            rol = KullaniciBilgileri.Instance.AdminRol;

            this.Text = rol + " Koordinatorlugu";
            labelBolumAdi.Text = rol + " Koordinatorlugu";
        }

        private void DersListeYukleButton_Click(object sender, EventArgs e)
        {

        }

        private void BolumKoordinatoru_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdminMenu_Click(object sender, EventArgs e)
        {
            if (rol == "Admin")
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

        private void buttonSinifMenusu_Click(object sender, EventArgs e)
        {
            SinifMenusu sinifMenu = new SinifMenusu();
            sinifMenu.Show();
            this.Hide();
        }
    }
}
