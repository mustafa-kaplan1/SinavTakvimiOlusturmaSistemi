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
            labelBolumAdi = new Label();
            buttonAdminMenu = new Button();
            buttonDersListeİncele = new Button();
            buttonOgrenciListeIncele = new Button();
            buttonProgramOlustur = new Button();
            buttonSinifMenusu = new Button();
            SuspendLayout();
            // 
            // labelBolumAdi
            // 
            labelBolumAdi.AutoSize = true;
            labelBolumAdi.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelBolumAdi.Location = new Point(197, 74);
            labelBolumAdi.Name = "labelBolumAdi";
            labelBolumAdi.Size = new Size(396, 28);
            labelBolumAdi.TabIndex = 3;
            labelBolumAdi.Text = "Bilgisayar Mühendisliği Koordinatörlüğü";
            // 
            // buttonAdminMenu
            // 
            buttonAdminMenu.Location = new Point(713, 376);
            buttonAdminMenu.Name = "buttonAdminMenu";
            buttonAdminMenu.Size = new Size(75, 62);
            buttonAdminMenu.TabIndex = 6;
            buttonAdminMenu.Text = "Çıkış";
            buttonAdminMenu.UseVisualStyleBackColor = true;
            buttonAdminMenu.Click += buttonAdminMenu_Click;
            // 
            // buttonDersListeİncele
            // 
            buttonDersListeİncele.Location = new Point(318, 216);
            buttonDersListeİncele.Name = "buttonDersListeİncele";
            buttonDersListeİncele.Size = new Size(152, 23);
            buttonDersListeİncele.TabIndex = 7;
            buttonDersListeİncele.Text = "Ders Listesi Menüsü";
            buttonDersListeİncele.UseVisualStyleBackColor = true;
            buttonDersListeİncele.Click += buttonDersListeİncele_Click;
            // 
            // buttonOgrenciListeIncele
            // 
            buttonOgrenciListeIncele.Location = new Point(318, 265);
            buttonOgrenciListeIncele.Name = "buttonOgrenciListeIncele";
            buttonOgrenciListeIncele.Size = new Size(152, 23);
            buttonOgrenciListeIncele.TabIndex = 8;
            buttonOgrenciListeIncele.Text = "Öğrenci Listesi Menüsü";
            buttonOgrenciListeIncele.UseVisualStyleBackColor = true;
            buttonOgrenciListeIncele.Click += buttonOgrenciListeIncele_Click;
            // 
            // buttonProgramOlustur
            // 
            buttonProgramOlustur.Location = new Point(295, 335);
            buttonProgramOlustur.Name = "buttonProgramOlustur";
            buttonProgramOlustur.Size = new Size(201, 47);
            buttonProgramOlustur.TabIndex = 9;
            buttonProgramOlustur.Text = "Sınav Programı Oluştur";
            buttonProgramOlustur.UseVisualStyleBackColor = true;
            // 
            // buttonSinifMenusu
            // 
            buttonSinifMenusu.Location = new Point(317, 167);
            buttonSinifMenusu.Name = "buttonSinifMenusu";
            buttonSinifMenusu.Size = new Size(153, 23);
            buttonSinifMenusu.TabIndex = 10;
            buttonSinifMenusu.Text = "Sınıf Menüsü";
            buttonSinifMenusu.UseVisualStyleBackColor = true;
            buttonSinifMenusu.Click += buttonSinifMenusu_Click;
            // 
            // BolumKoordinatoru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSinifMenusu);
            Controls.Add(buttonProgramOlustur);
            Controls.Add(buttonOgrenciListeIncele);
            Controls.Add(buttonDersListeİncele);
            Controls.Add(buttonAdminMenu);
            Controls.Add(labelBolumAdi);
            Name = "BolumKoordinatoru";
            Text = "BolumKoordinatoru";
            Load += BolumKoordinatoru_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelBolumAdi;
        private Button buttonAdminMenu;
        private Button buttonDersListeİncele;
        private Button buttonOgrenciListeIncele;
        private Button buttonProgramOlustur;
        private Button buttonSinifMenusu;
    }
}