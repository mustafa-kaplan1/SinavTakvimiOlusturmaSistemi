namespace SinavTakvimiOlusturmaSistemi
{
    partial class LoginSayfasi
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
            epostaLabel = new Label();
            sifreLabel = new Label();
            epostaTextBox = new TextBox();
            SifreTextBox = new TextBox();
            girisyapButton = new Button();
            hatamesajLabel = new Label();
            SuspendLayout();
            // 
            // epostaLabel
            // 
            epostaLabel.AutoSize = true;
            epostaLabel.Location = new Point(255, 262);
            epostaLabel.Name = "epostaLabel";
            epostaLabel.Size = new Size(45, 15);
            epostaLabel.TabIndex = 0;
            epostaLabel.Text = "Eposta:";
            // 
            // sifreLabel
            // 
            sifreLabel.AutoSize = true;
            sifreLabel.Location = new Point(255, 291);
            sifreLabel.Name = "sifreLabel";
            sifreLabel.Size = new Size(33, 15);
            sifreLabel.TabIndex = 1;
            sifreLabel.Text = "Şifre:";
            // 
            // epostaTextBox
            // 
            epostaTextBox.Location = new Point(355, 258);
            epostaTextBox.Name = "epostaTextBox";
            epostaTextBox.Size = new Size(100, 23);
            epostaTextBox.TabIndex = 2;
            // 
            // SifreTextBox
            // 
            SifreTextBox.Location = new Point(355, 287);
            SifreTextBox.Name = "SifreTextBox";
            SifreTextBox.Size = new Size(100, 23);
            SifreTextBox.TabIndex = 3;
            // 
            // girisyapButton
            // 
            girisyapButton.Location = new Point(321, 350);
            girisyapButton.Name = "girisyapButton";
            girisyapButton.Size = new Size(75, 23);
            girisyapButton.TabIndex = 4;
            girisyapButton.Text = "Giriş Yap";
            girisyapButton.UseVisualStyleBackColor = true;
            girisyapButton.Click += girisyapButton_Click;
            // 
            // hatamesajLabel
            // 
            hatamesajLabel.AutoSize = true;
            hatamesajLabel.Location = new Point(255, 212);
            hatamesajLabel.Name = "hatamesajLabel";
            hatamesajLabel.Size = new Size(207, 15);
            hatamesajLabel.TabIndex = 5;
            hatamesajLabel.Text = "epostanızı veya şifrenizi hatalı girdiniz!";
            // 
            // LoginSayfasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hatamesajLabel);
            Controls.Add(girisyapButton);
            Controls.Add(SifreTextBox);
            Controls.Add(epostaTextBox);
            Controls.Add(sifreLabel);
            Controls.Add(epostaLabel);
            Name = "LoginSayfasi";
            Text = "LoginSayfasi";
            Load += LoginSayfasi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label epostaLabel;
        private Label sifreLabel;
        private TextBox epostaTextBox;
        private TextBox SifreTextBox;
        private Button girisyapButton;
        private Label hatamesajLabel;
    }
}
