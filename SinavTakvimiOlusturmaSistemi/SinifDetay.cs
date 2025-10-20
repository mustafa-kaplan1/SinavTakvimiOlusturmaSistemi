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
        int sinifIndex;
        public SinifDetay(int sinifIndex)
        {
            InitializeComponent();

            this.sinifIndex = sinifIndex;
        }

        private void SinifDetay_Load(object sender, EventArgs e)
        {

        }

        private void SiraCiz(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int offset = 10;
            int bosluk = 10;
            int kareBoyutu = 30;

            // Örnek: 5x5 kareler
            int yatay = Derslikler.Instance.TumDerslikler[sinifIndex].EnineSiraSayisi;
            int dikey = Derslikler.Instance.TumDerslikler[sinifIndex].BoyunaSiraSayisi;
            int tip = Derslikler.Instance.TumDerslikler[sinifIndex].SiraYapisi;

            for (int satir = 0; satir < yatay; satir++) //! DUzELT
            {
                for (int sutun = 0; sutun < dikey; sutun++)
                {
                    for (int k = 0; k < tip; k++)
                    {
                        int x = ((sutun + 1) % tip) * (tip * kareBoyutu + bosluk) + sutun * kareBoyutu;
                        int y = ((satir + 1) % tip) * (tip * kareBoyutu + bosluk) + sutun * kareBoyutu;

                        // Kareyi çiz
                        g.FillRectangle(Brushes.LightBlue, x, y, kareBoyutu, kareBoyutu);
                        g.DrawRectangle(Pens.Black, x, y, kareBoyutu, kareBoyutu);

                        // Kare içine metin yazmak (opsiyonel)
                        string text = $"K{sutun + 1}S{satir + 1}";
                        g.DrawString(text, this.Font, Brushes.Black, x + 5, y + 5);
                    }
                }
            }
        }

    }
}
