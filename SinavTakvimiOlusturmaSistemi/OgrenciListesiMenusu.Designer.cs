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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 376);
            dataGridView1.TabIndex = 13;
            // 
            // butonExit
            // 
            butonExit.Location = new Point(96, 15);
            butonExit.Name = "butonExit";
            butonExit.Size = new Size(71, 23);
            butonExit.TabIndex = 12;
            butonExit.Text = "Geri Dön";
            butonExit.UseVisualStyleBackColor = true;
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(753, 15);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(35, 23);
            buttonAra.TabIndex = 11;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
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
            // 
            // OgrenciListesiMenusu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(butonExit);
            Controls.Add(buttonAra);
            Controls.Add(textBoxAra);
            Controls.Add(buttonExcel);
            Name = "OgrenciListesiMenusu";
            Text = "OgrenciListesiMenusu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button butonExit;
        private Button buttonAra;
        private TextBox textBoxAra;
        private Button buttonExcel;
    }
}