namespace SinavTakvimiOlusturmaSistemi
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kullaniciEkle = new Button();
            BolumBilgisayar = new Button();
            BolumYazilim = new Button();
            BolumElektrik = new Button();
            BolumElektronik = new Button();
            Bolumİnsaat = new Button();
            CikisBtn = new Button();
            SuspendLayout();
            // 
            // kullaniciEkle
            // 
            kullaniciEkle.Location = new Point(354, 134);
            kullaniciEkle.Name = "kullaniciEkle";
            kullaniciEkle.Size = new Size(75, 75);
            kullaniciEkle.TabIndex = 0;
            kullaniciEkle.Text = "Kullanıcı Ekle";
            kullaniciEkle.UseVisualStyleBackColor = true;
            // 
            // BolumBilgisayar
            // 
            BolumBilgisayar.Location = new Point(83, 207);
            BolumBilgisayar.Name = "BolumBilgisayar";
            BolumBilgisayar.Size = new Size(88, 67);
            BolumBilgisayar.TabIndex = 1;
            BolumBilgisayar.Text = "Bilgisayar Mühenisliği";
            BolumBilgisayar.UseVisualStyleBackColor = true;
            // 
            // BolumYazilim
            // 
            BolumYazilim.Location = new Point(216, 229);
            BolumYazilim.Name = "BolumYazilim";
            BolumYazilim.Size = new Size(75, 23);
            BolumYazilim.TabIndex = 2;
            BolumYazilim.Text = "Yazılım";
            BolumYazilim.UseVisualStyleBackColor = true;
            // 
            // BolumElektrik
            // 
            BolumElektrik.Location = new Point(354, 229);
            BolumElektrik.Name = "BolumElektrik";
            BolumElektrik.Size = new Size(75, 23);
            BolumElektrik.TabIndex = 3;
            BolumElektrik.Text = "Elektrik";
            BolumElektrik.UseVisualStyleBackColor = true;
            // 
            // BolumElektronik
            // 
            BolumElektronik.Location = new Point(460, 229);
            BolumElektronik.Name = "BolumElektronik";
            BolumElektronik.Size = new Size(75, 23);
            BolumElektronik.TabIndex = 4;
            BolumElektronik.Text = "Elektronik";
            BolumElektronik.UseVisualStyleBackColor = true;
            // 
            // Bolumİnsaat
            // 
            Bolumİnsaat.Location = new Point(581, 229);
            Bolumİnsaat.Name = "Bolumİnsaat";
            Bolumİnsaat.Size = new Size(75, 23);
            Bolumİnsaat.TabIndex = 5;
            Bolumİnsaat.Text = "İnşaat";
            Bolumİnsaat.UseVisualStyleBackColor = true;
            // 
            // CikisBtn
            // 
            CikisBtn.Location = new Point(354, 324);
            CikisBtn.Name = "CikisBtn";
            CikisBtn.Size = new Size(75, 23);
            CikisBtn.TabIndex = 6;
            CikisBtn.Text = "Çıkış";
            CikisBtn.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CikisBtn);
            Controls.Add(Bolumİnsaat);
            Controls.Add(BolumElektronik);
            Controls.Add(BolumElektrik);
            Controls.Add(BolumYazilim);
            Controls.Add(BolumBilgisayar);
            Controls.Add(kullaniciEkle);
            Name = "AdminPanel";
            Text = "AdminPanel";
            ResumeLayout(false);
        }

        #endregion

        private Button kullaniciEkle;
        private Button BolumBilgisayar;
        private Button BolumYazilim;
        private Button BolumElektrik;
        private Button BolumElektronik;
        private Button Bolumİnsaat;
        private Button CikisBtn;
    }
}