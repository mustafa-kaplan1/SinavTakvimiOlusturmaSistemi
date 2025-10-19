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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
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
            kullaniciEkle.Click += kullaniciEkle_Click;
            // 
            // BolumBilgisayar
            // 
            BolumBilgisayar.Location = new Point(83, 207);
            BolumBilgisayar.Name = "BolumBilgisayar";
            BolumBilgisayar.Size = new Size(88, 67);
            BolumBilgisayar.TabIndex = 1;
            BolumBilgisayar.Text = "Bilgisayar Mühenisliği";
            BolumBilgisayar.UseVisualStyleBackColor = true;
            BolumBilgisayar.Click += BolumBilgisayar_Click;
            // 
            // BolumYazilim
            // 
            BolumYazilim.Location = new Point(216, 229);
            BolumYazilim.Name = "BolumYazilim";
            BolumYazilim.Size = new Size(75, 23);
            BolumYazilim.TabIndex = 2;
            BolumYazilim.Text = "Yazılım";
            BolumYazilim.UseVisualStyleBackColor = true;
            BolumYazilim.Click += BolumYazilim_Click;
            // 
            // BolumElektrik
            // 
            BolumElektrik.Location = new Point(354, 229);
            BolumElektrik.Name = "BolumElektrik";
            BolumElektrik.Size = new Size(75, 23);
            BolumElektrik.TabIndex = 3;
            BolumElektrik.Text = "Elektrik";
            BolumElektrik.UseVisualStyleBackColor = true;
            BolumElektrik.Click += BolumElektrik_Click;
            // 
            // BolumElektronik
            // 
            BolumElektronik.Location = new Point(460, 229);
            BolumElektronik.Name = "BolumElektronik";
            BolumElektronik.Size = new Size(75, 23);
            BolumElektronik.TabIndex = 4;
            BolumElektronik.Text = "Elektronik";
            BolumElektronik.UseVisualStyleBackColor = true;
            BolumElektronik.Click += BolumElektronik_Click;
            // 
            // Bolumİnsaat
            // 
            Bolumİnsaat.Location = new Point(581, 229);
            Bolumİnsaat.Name = "Bolumİnsaat";
            Bolumİnsaat.Size = new Size(75, 23);
            Bolumİnsaat.TabIndex = 5;
            Bolumİnsaat.Text = "İnşaat";
            Bolumİnsaat.UseVisualStyleBackColor = true;
            Bolumİnsaat.Click += Bolumİnsaat_Click;
            // 
            // CikisBtn
            // 
            CikisBtn.Location = new Point(354, 324);
            CikisBtn.Name = "CikisBtn";
            CikisBtn.Size = new Size(75, 23);
            CikisBtn.TabIndex = 6;
            CikisBtn.Text = "Çıkış";
            CikisBtn.UseVisualStyleBackColor = true;
            CikisBtn.Click += CikisBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(435, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 172);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullancı Ekle";
            groupBox1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(98, 139);
            button2.Name = "button2";
            button2.Size = new Size(47, 23);
            button2.TabIndex = 7;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(151, 139);
            button1.Name = "button1";
            button1.Size = new Size(115, 23);
            button1.TabIndex = 6;
            button1.Text = "Yeni Kullanıcı Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 104);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 5;
            label3.Text = "Yeni Kullanıcı Rolü:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bilgisayar Muhendisligi", "Yazilim Muhendisligi", "Elektrik Muhendisligi", "Elektronik Muhendisligi", "Insaat Muhendisligi" });
            comboBox1.Location = new Point(151, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 23);
            comboBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(151, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 63);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 2;
            label2.Text = "Yeni Kullanıcı Şifresi:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 25);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "yeni kullanıcı epostası:";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(CikisBtn);
            Controls.Add(Bolumİnsaat);
            Controls.Add(BolumElektronik);
            Controls.Add(BolumElektrik);
            Controls.Add(BolumYazilim);
            Controls.Add(BolumBilgisayar);
            Controls.Add(kullaniciEkle);
            Name = "AdminPanel";
            Text = "AdminPanel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Button button1;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
    }
}