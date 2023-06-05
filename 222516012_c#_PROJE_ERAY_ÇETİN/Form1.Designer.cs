namespace _222516012_c__PROJE_ERAY_ÇETİN
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboHastalık = new System.Windows.Forms.Label();
            this.lbHastaInfo = new System.Windows.Forms.ListBox();
            this.citySelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hospitalSelect = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(166, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Randevu Sistemi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 73);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 13);
            this.name.TabIndex = 2;
            this.name.Text = "Adınız: ";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(12, 116);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(56, 13);
            this.lastName.TabIndex = 4;
            this.lastName.Text = "SoyAdınız:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(12, 156);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(43, 13);
            this.phone.TabIndex = 6;
            this.phone.Text = "Telefon";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btnRandevu
            // 
            this.btnRandevu.Location = new System.Drawing.Point(92, 234);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(100, 23);
            this.btnRandevu.TabIndex = 7;
            this.btnRandevu.Text = "Randevu Al";
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // comboHastalık
            // 
            this.comboHastalık.AutoSize = true;
            this.comboHastalık.Location = new System.Drawing.Point(15, 204);
            this.comboHastalık.Name = "comboHastalık";
            this.comboHastalık.Size = new System.Drawing.Size(45, 13);
            this.comboHastalık.TabIndex = 9;
            this.comboHastalık.Text = "Hastalık";
            // 
            // lbHastaInfo
            // 
            this.lbHastaInfo.FormattingEnabled = true;
            this.lbHastaInfo.Location = new System.Drawing.Point(485, 38);
            this.lbHastaInfo.Name = "lbHastaInfo";
            this.lbHastaInfo.Size = new System.Drawing.Size(233, 186);
            this.lbHastaInfo.TabIndex = 10;
            // 
            // citySelect
            // 
            this.citySelect.FormattingEnabled = true;
            this.citySelect.Location = new System.Drawing.Point(324, 78);
            this.citySelect.Name = "citySelect";
            this.citySelect.Size = new System.Drawing.Size(121, 21);
            this.citySelect.TabIndex = 11;
            this.citySelect.SelectedIndexChanged += new System.EventHandler(this.citySelect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Şehir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hastane";
            // 
            // hospitalSelect
            // 
            this.hospitalSelect.FormattingEnabled = true;
            this.hospitalSelect.Location = new System.Drawing.Point(324, 120);
            this.hospitalSelect.Name = "hospitalSelect";
            this.hospitalSelect.Size = new System.Drawing.Size(121, 21);
            this.hospitalSelect.TabIndex = 14;
            this.hospitalSelect.SelectedIndexChanged += new System.EventHandler(this.hospitalSelect_SelectedIndexChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(557, 234);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 837);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.hospitalSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.citySelect);
            this.Controls.Add(this.lbHastaInfo);
            this.Controls.Add(this.comboHastalık);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRandevu);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label comboHastalık;
        private System.Windows.Forms.ListBox lbHastaInfo;
        private System.Windows.Forms.ComboBox citySelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hospitalSelect;
        private System.Windows.Forms.Button btnTemizle;
    }
}

