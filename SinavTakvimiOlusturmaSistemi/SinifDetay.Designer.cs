namespace SinavTakvimiOlusturmaSistemi
{
    partial class SinifDetay
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
            buttonGeriDon = new Button();
            buttonDelete = new Button();
            labelSinifOzellik = new Label();
            SuspendLayout();
            // 
            // buttonGeriDon
            // 
            buttonGeriDon.Location = new Point(11, 9);
            buttonGeriDon.Name = "buttonGeriDon";
            buttonGeriDon.Size = new Size(75, 23);
            buttonGeriDon.TabIndex = 0;
            buttonGeriDon.Text = "Geri Dön";
            buttonGeriDon.UseVisualStyleBackColor = true;
            buttonGeriDon.Click += buttonGeriDon_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(92, 9);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(86, 23);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Bu Sınıfı Sil";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelSinifOzellik
            // 
            labelSinifOzellik.AutoSize = true;
            labelSinifOzellik.Location = new Point(208, 13);
            labelSinifOzellik.Name = "labelSinifOzellik";
            labelSinifOzellik.Size = new Size(87, 15);
            labelSinifOzellik.TabIndex = 2;
            labelSinifOzellik.Text = "Sınıf Özellikleri:";
            // 
            // SinifDetay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSinifOzellik);
            Controls.Add(buttonDelete);
            Controls.Add(buttonGeriDon);
            Name = "SinifDetay";
            Text = "SinifDetay";
            Load += SinifDetay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGeriDon;
        private Button buttonDelete;
        private Label labelSinifOzellik;
    }
}