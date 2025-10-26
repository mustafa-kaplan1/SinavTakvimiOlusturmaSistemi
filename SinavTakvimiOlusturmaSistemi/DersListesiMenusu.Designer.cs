namespace SinavTakvimiOlusturmaSistemi
{
    partial class DersListesiMenusu
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
            buttonExcel = new Button();
            butonExit = new Button();
            buttonAra = new Button();
            textBoxAra = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            buttonGroupBoxKapat = new Button();
            panel1 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonExcel
            // 
            buttonExcel.Location = new Point(11, 13);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(75, 23);
            buttonExcel.TabIndex = 0;
            buttonExcel.Text = "Excel Yükle";
            buttonExcel.UseVisualStyleBackColor = true;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // butonExit
            // 
            butonExit.Location = new Point(95, 13);
            butonExit.Name = "butonExit";
            butonExit.Size = new Size(71, 23);
            butonExit.TabIndex = 7;
            butonExit.Text = "Geri Dön";
            butonExit.UseVisualStyleBackColor = true;
            butonExit.Click += butonExit_Click;
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(752, 13);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(35, 23);
            buttonAra.TabIndex = 6;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // textBoxAra
            // 
            textBoxAra.Location = new Point(577, 13);
            textBoxAra.Name = "textBoxAra";
            textBoxAra.Size = new Size(169, 23);
            textBoxAra.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 376);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(23, 87);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(15, 51);
            label1.Name = "label1";
            label1.Size = new Size(161, 21);
            label1.TabIndex = 1;
            label1.Text = "Dersi Alan Öğrenciler:";
            // 
            // buttonGroupBoxKapat
            // 
            buttonGroupBoxKapat.Location = new Point(703, 22);
            buttonGroupBoxKapat.Name = "buttonGroupBoxKapat";
            buttonGroupBoxKapat.Size = new Size(51, 23);
            buttonGroupBoxKapat.TabIndex = 0;
            buttonGroupBoxKapat.Text = "kapat";
            buttonGroupBoxKapat.UseVisualStyleBackColor = true;
            buttonGroupBoxKapat.Click += buttonGroupBoxKapat_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonGroupBoxKapat);
            panel1.Location = new Point(11, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 376);
            panel1.TabIndex = 10;
            panel1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 26);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // DersListesiMenusu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(butonExit);
            Controls.Add(buttonAra);
            Controls.Add(textBoxAra);
            Controls.Add(buttonExcel);
            Name = "DersListesiMenusu";
            Text = "DersListesiMenusu";
            Load += DersListesiMenusu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExcel;
        private Button butonExit;
        private Button buttonAra;
        private TextBox textBoxAra;
        private DataGridView dataGridView1;
        private Label label1;
        private Button buttonGroupBoxKapat;
        private Label label2;
        private Panel panel1;
        private Label label3;
    }
}