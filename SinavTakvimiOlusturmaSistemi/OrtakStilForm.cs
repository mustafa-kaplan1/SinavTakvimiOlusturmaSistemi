using System;
using System.Drawing;
using System.Windows.Forms;

namespace SinavTakvimiOlusturmaSistemi
{
    public partial class OrtakStilForm : Form
    {
        public OrtakStilForm()
        {
            InitializeComponent();
            ApplyModernStyle(this.Controls);  // Form yüklendiðinde stil uygula
        }

        private void OrtakStilForm_Load(object sender, EventArgs e)
        {
            // Ekstra load kodlarý buraya eklenebilir
        }

        // Tüm kontroller için stil uygular
        private void ApplyModernStyle(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                // Button stili
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(52, 152, 219); // Canlý mavi
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;
                }

                // Label stili
                else if (ctrl is Label lbl)
                {
                    lbl.ForeColor = Color.FromArgb(44, 62, 80); // Koyu mavi-gri ton
                    lbl.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                }

                // TextBox stili
                else if (ctrl is TextBox txt)
                {
                    txt.BackColor = Color.White;
                    txt.ForeColor = Color.FromArgb(44, 62, 80);
                    txt.Font = new Font("Segoe UI", 10);
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.Padding = new Padding(5);
                }

                // Panel veya GroupBox içindekiler varsa recursive uygula
                if (ctrl.HasChildren)
                {
                    ApplyModernStyle(ctrl.Controls);
                }
            }

            // Form arkaplan rengi
            this.BackColor = Color.FromArgb(236, 240, 241); // Açýk gri-bej ton
        }
    }
}
