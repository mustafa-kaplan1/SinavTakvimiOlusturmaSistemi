namespace SinavTakvimiOlusturmaSistemi
{
    partial class OgrenciListesiMenusu
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
            dataGridView1 = new DataGridView();
            butonExit = new Button();
            buttonAra = new Button();
            textBoxAra = new TextBox();
            buttonExcel = new Button();
            groupBoxOgrenciBilgi = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            buttonGroupBoxKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxOgrenciBilgi.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 376);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // butonExit
            // 
            butonExit.Location = new Point(96, 15);
            butonExit.Name = "butonExit";
            butonExit.Size = new Size(71, 23);
            butonExit.TabIndex = 12;
            butonExit.Text = "Geri Dön";
            butonExit.UseVisualStyleBackColor = true;
            butonExit.Click += butonExit_Click;
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(753, 15);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(35, 23);
            buttonAra.TabIndex = 11;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // textBoxAra
            // 
            textBoxAra.Location = new Point(578, 15);
            textBoxAra.Name = "textBoxAra";
            textBoxAra.Size = new Size(169, 23);
            textBoxAra.TabIndex = 10;
            // 
            // buttonExcel
            // 
            buttonExcel.Location = new Point(12, 14);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(75, 23);
            buttonExcel.TabIndex = 9;
            buttonExcel.Text = "Excel Yükle";
            buttonExcel.UseVisualStyleBackColor = true;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // groupBoxOgrenciBilgi
            // 
            groupBoxOgrenciBilgi.Controls.Add(label2);
            groupBoxOgrenciBilgi.Controls.Add(label1);
            groupBoxOgrenciBilgi.Controls.Add(buttonGroupBoxKapat);
            groupBoxOgrenciBilgi.Location = new Point(13, 60);
            groupBoxOgrenciBilgi.Name = "groupBoxOgrenciBilgi";
            groupBoxOgrenciBilgi.Size = new Size(776, 376);
            groupBoxOgrenciBilgi.TabIndex = 14;
            groupBoxOgrenciBilgi.TabStop = false;
            groupBoxOgrenciBilgi.Text = "groupBox1";
            groupBoxOgrenciBilgi.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(27, 64);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(19, 28);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 4;
            label1.Text = "Aldığı Dersler:";
            // 
            // buttonGroupBoxKapat
            // 
            buttonGroupBoxKapat.Location = new Point(707, 17);
            buttonGroupBoxKapat.Name = "buttonGroupBoxKapat";
            buttonGroupBoxKapat.Size = new Size(51, 23);
            buttonGroupBoxKapat.TabIndex = 3;
            buttonGroupBoxKapat.Text = "kapat";
            buttonGroupBoxKapat.UseVisualStyleBackColor = true;
            buttonGroupBoxKapat.Click += buttonGroupBoxKapat_Click;
            // 
            // OgrenciListesiMenusu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOgrenciBilgi);
            Controls.Add(dataGridView1);
            Controls.Add(butonExit);
            Controls.Add(buttonAra);
            Controls.Add(textBoxAra);
            Controls.Add(buttonExcel);
            Name = "OgrenciListesiMenusu";
            Text = "OgrenciListesiMenusu";
            Load += OgrenciListesiMenusu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxOgrenciBilgi.ResumeLayout(false);
            groupBoxOgrenciBilgi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button butonExit;
        private Button buttonAra;
        private TextBox textBoxAra;
        private Button buttonExcel;
        private GroupBox groupBoxOgrenciBilgi;
        private Label label2;
        private Label label1;
        private Button buttonGroupBoxKapat;
    }
}