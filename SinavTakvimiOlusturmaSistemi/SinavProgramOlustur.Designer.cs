namespace SinavTakvimiOlusturmaSistemi
{
    partial class SinavProgramOlustur
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
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            checkedListBox1 = new CheckedListBox();
            CheckBoxSinavlarCakismasin = new CheckBox();
            buttonOlustur = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 228);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 13;
            label5.Text = "Bitiş Tarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 190);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 12;
            label6.Text = "Başlangıç Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 24);
            label4.Name = "label4";
            label4.Size = new Size(212, 15);
            label4.TabIndex = 11;
            label4.Text = "Sınav Programında Kullanılacak Dersler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 151);
            label3.Name = "label3";
            label3.Size = new Size(177, 15);
            label3.TabIndex = 10;
            label3.Text = "Bekleme Süresi (varsayılan 15dk)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(579, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(579, 24);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 7;
            label2.Text = "Sınav Süresi (varsayılan 75dk)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 23);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 6;
            label1.Text = "Ders Türü";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(579, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(579, 54);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(268, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(121, 230);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(121, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 59);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(212, 94);
            checkedListBox1.TabIndex = 0;
            // 
            // CheckBoxSinavlarCakismasin
            // 
            CheckBoxSinavlarCakismasin.AutoSize = true;
            CheckBoxSinavlarCakismasin.Location = new Point(270, 108);
            CheckBoxSinavlarCakismasin.Name = "CheckBoxSinavlarCakismasin";
            CheckBoxSinavlarCakismasin.Size = new Size(130, 19);
            CheckBoxSinavlarCakismasin.TabIndex = 14;
            CheckBoxSinavlarCakismasin.Text = "Sınavlar Çakışmasın";
            CheckBoxSinavlarCakismasin.UseVisualStyleBackColor = true;
            // 
            // buttonOlustur
            // 
            buttonOlustur.Location = new Point(653, 336);
            buttonOlustur.Name = "buttonOlustur";
            buttonOlustur.Size = new Size(75, 58);
            buttonOlustur.TabIndex = 15;
            buttonOlustur.Text = "Oluştur";
            buttonOlustur.UseVisualStyleBackColor = true;
            // 
            // SinavProgramOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOlustur);
            Controls.Add(CheckBoxSinavlarCakismasin);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(checkedListBox1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "SinavProgramOlustur";
            Text = "SinavProgramOlustur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox checkedListBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private CheckBox CheckBoxSinavlarCakismasin;
        private Button buttonOlustur;
    }
}