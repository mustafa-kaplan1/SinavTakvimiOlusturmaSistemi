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
    public partial class LoginSayfasi : OrtakStilForm
    {
        public LoginSayfasi()
        {
            InitializeComponent();
        }

        private void LoginSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void girisyapButton_Click(object sender, EventArgs e)
        {
            if(epostaTextBox.Text=="admin" && SifreTextBox.Text == "123")
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                this.Hide();
            }

        }
    }
}
