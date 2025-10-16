namespace SinavTakvimiOlusturmaSistemi
{
    partial class BolumKoordinatoru
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
            textBoxAra = new TextBox();
            buttonAra = new Button();
            buttonSinifEkle = new Button();
            labelBolumAdi = new Label();
            buttonDersListeYukle = new Button();
            buttonOgrenciListeYukle = new Button();
            buttonAdminMenu = new Button();
            buttonDersListeİncele = new Button();
            buttonOgrenciListeIncele = new Button();
            buttonProgramOlustur = new Button();
            SuspendLayout();
            // 
            // textBoxAra
            // 
            textBoxAra.Location = new Point(125, 25);
            textBoxAra.Name = "textBoxAra";
            textBoxAra.Size = new Size(100, 23);
            textBoxAra.TabIndex = 0;
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(240, 25);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(33, 23);
            buttonAra.TabIndex = 1;
            buttonAra.Text = "ara";
            buttonAra.UseVisualStyleBackColor = true;
            // 
            // buttonSinifEkle
            // 
            buttonSinifEkle.Location = new Point(301, 162);
            buttonSinifEkle.Name = "buttonSinifEkle";
            buttonSinifEkle.Size = new Size(75, 23);
            buttonSinifEkle.TabIndex = 2;
            buttonSinifEkle.Text = "Sınıf Ekle";
            buttonSinifEkle.UseVisualStyleBackColor = true;
            // 
            // labelBolumAdi
            // 
            labelBolumAdi.AutoSize = true;
            labelBolumAdi.Location = new Point(421, 29);
            labelBolumAdi.Name = "labelBolumAdi";
            labelBolumAdi.Size = new Size(219, 15);
            labelBolumAdi.TabIndex = 3;
            labelBolumAdi.Text = "Bilgisayar Mühendisliği Koordinatörlüğü";
            // 
            // buttonDersListeYukle
            // 
            buttonDersListeYukle.Location = new Point(263, 213);
            buttonDersListeYukle.Name = "buttonDersListeYukle";
            buttonDersListeYukle.Size = new Size(153, 23);
            buttonDersListeYukle.TabIndex = 4;
            buttonDersListeYukle.Text = "Ders Listesi Yükle";
            buttonDersListeYukle.UseVisualStyleBackColor = true;
            buttonDersListeYukle.Click += DersListeYukleButton_Click;
            // 
            // buttonOgrenciListeYukle
            // 
            buttonOgrenciListeYukle.Location = new Point(263, 261);
            buttonOgrenciListeYukle.Name = "buttonOgrenciListeYukle";
            buttonOgrenciListeYukle.Size = new Size(153, 23);
            buttonOgrenciListeYukle.TabIndex = 5;
            buttonOgrenciListeYukle.Text = "Öğrenci Listesi Yükle";
            buttonOgrenciListeYukle.UseVisualStyleBackColor = true;
            // 
            // buttonAdminMenu
            // 
            buttonAdminMenu.Location = new Point(565, 60);
            buttonAdminMenu.Name = "buttonAdminMenu";
            buttonAdminMenu.Size = new Size(75, 62);
            buttonAdminMenu.TabIndex = 6;
            buttonAdminMenu.Text = "Admin Menüsüne Dön";
            buttonAdminMenu.UseVisualStyleBackColor = true;
            // 
            // buttonDersListeİncele
            // 
            buttonDersListeİncele.Location = new Point(460, 214);
            buttonDersListeİncele.Name = "buttonDersListeİncele";
            buttonDersListeİncele.Size = new Size(136, 23);
            buttonDersListeİncele.TabIndex = 7;
            buttonDersListeİncele.Text = "Ders Listesi Menüsü";
            buttonDersListeİncele.UseVisualStyleBackColor = true;
            // 
            // buttonOgrenciListeIncele
            // 
            buttonOgrenciListeIncele.Location = new Point(460, 261);
            buttonOgrenciListeIncele.Name = "buttonOgrenciListeIncele";
            buttonOgrenciListeIncele.Size = new Size(152, 23);
            buttonOgrenciListeIncele.TabIndex = 8;
            buttonOgrenciListeIncele.Text = "Öğrenci Listesi Menüsü";
            buttonOgrenciListeIncele.UseVisualStyleBackColor = true;
            // 
            // buttonProgramOlustur
            // 
            buttonProgramOlustur.Location = new Point(295, 356);
            buttonProgramOlustur.Name = "buttonProgramOlustur";
            buttonProgramOlustur.Size = new Size(201, 23);
            buttonProgramOlustur.TabIndex = 9;
            buttonProgramOlustur.Text = "Sınav Programı Oluştur";
            buttonProgramOlustur.UseVisualStyleBackColor = true;
            // 
            // BolumKoordinatoru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonProgramOlustur);
            Controls.Add(buttonOgrenciListeIncele);
            Controls.Add(buttonDersListeİncele);
            Controls.Add(buttonAdminMenu);
            Controls.Add(buttonOgrenciListeYukle);
            Controls.Add(buttonDersListeYukle);
            Controls.Add(labelBolumAdi);
            Controls.Add(buttonSinifEkle);
            Controls.Add(buttonAra);
            Controls.Add(textBoxAra);
            Name = "BolumKoordinatoru";
            Text = "BolumKoordinatoru";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAra;
        private Button buttonAra;
        private Button buttonSinifEkle;
        private Label labelBolumAdi;
        private Button buttonDersListeYukle;
        private Button buttonOgrenciListeYukle;
        private Button buttonAdminMenu;
        private Button buttonDersListeİncele;
        private Button buttonOgrenciListeIncele;
        private Button buttonProgramOlustur;
    }
}