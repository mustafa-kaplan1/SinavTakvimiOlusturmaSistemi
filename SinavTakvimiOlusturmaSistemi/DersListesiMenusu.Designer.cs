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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            butonExit.Location = new Point(95, 14);
            butonExit.Name = "butonExit";
            butonExit.Size = new Size(71, 23);
            butonExit.TabIndex = 7;
            butonExit.Text = "Geri Dön";
            butonExit.UseVisualStyleBackColor = true;
            butonExit.Click += butonExit_Click;
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(752, 14);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(35, 23);
            buttonAra.TabIndex = 6;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
            // 
            // textBoxAra
            // 
            textBoxAra.Location = new Point(577, 14);
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
            // 
            // DersListesiMenusu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(butonExit);
            Controls.Add(buttonAra);
            Controls.Add(textBoxAra);
            Controls.Add(buttonExcel);
            Name = "DersListesiMenusu";
            Text = "DersListesiMenusu";
            Load += DersListesiMenusu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExcel;
        private Button butonExit;
        private Button buttonAra;
        private TextBox textBoxAra;
        private DataGridView dataGridView1;
    }
}