namespace HavaDurumuApiCekme
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelSehir = new System.Windows.Forms.Label();
            this.labelHavaDurumu = new System.Windows.Forms.Label();
            this.labelSicaklik = new System.Windows.Forms.Label();
            this.labelBulutDurumu = new System.Windows.Forms.Label();
            this.labelHissedilenSicaklik = new System.Windows.Forms.Label();
            this.labelNem = new System.Windows.Forms.Label();
            this.labelBasınç = new System.Windows.Forms.Label();
            this.labelGunDogumu = new System.Windows.Forms.Label();
            this.labelRuzgarHizi = new System.Windows.Forms.Label();
            this.labelGunBatimi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(128, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 28);
            this.textBox1.TabIndex = 10;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // labelSehir
            // 
            this.labelSehir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSehir.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSehir.Location = new System.Drawing.Point(25, 83);
            this.labelSehir.Name = "labelSehir";
            this.labelSehir.Size = new System.Drawing.Size(198, 48);
            this.labelSehir.TabIndex = 0;
            this.labelSehir.Text = "Şehir:";
            this.labelSehir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSehir.Click += new System.EventHandler(this.labelSehir_Click);
            // 
            // labelHavaDurumu
            // 
            this.labelHavaDurumu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHavaDurumu.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHavaDurumu.Location = new System.Drawing.Point(25, 140);
            this.labelHavaDurumu.Name = "labelHavaDurumu";
            this.labelHavaDurumu.Size = new System.Drawing.Size(448, 43);
            this.labelHavaDurumu.TabIndex = 1;
            this.labelHavaDurumu.Text = "Hava Durumu:";
            this.labelHavaDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSicaklik
            // 
            this.labelSicaklik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSicaklik.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSicaklik.Location = new System.Drawing.Point(25, 192);
            this.labelSicaklik.Name = "labelSicaklik";
            this.labelSicaklik.Size = new System.Drawing.Size(202, 49);
            this.labelSicaklik.TabIndex = 2;
            this.labelSicaklik.Text = "Sıcaklık:";
            this.labelSicaklik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBulutDurumu
            // 
            this.labelBulutDurumu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBulutDurumu.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBulutDurumu.Location = new System.Drawing.Point(25, 258);
            this.labelBulutDurumu.Name = "labelBulutDurumu";
            this.labelBulutDurumu.Size = new System.Drawing.Size(448, 41);
            this.labelBulutDurumu.TabIndex = 3;
            this.labelBulutDurumu.Text = "Bulut Durumu:";
            this.labelBulutDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHissedilenSicaklik
            // 
            this.labelHissedilenSicaklik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHissedilenSicaklik.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHissedilenSicaklik.Location = new System.Drawing.Point(255, 192);
            this.labelHissedilenSicaklik.Name = "labelHissedilenSicaklik";
            this.labelHissedilenSicaklik.Size = new System.Drawing.Size(218, 46);
            this.labelHissedilenSicaklik.TabIndex = 4;
            this.labelHissedilenSicaklik.Text = "Hissedilen Sıcaklık";
            this.labelHissedilenSicaklik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNem
            // 
            this.labelNem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNem.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNem.Location = new System.Drawing.Point(255, 83);
            this.labelNem.Name = "labelNem";
            this.labelNem.Size = new System.Drawing.Size(218, 46);
            this.labelNem.TabIndex = 5;
            this.labelNem.Text = "Nem:";
            this.labelNem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNem.Click += new System.EventHandler(this.labelNem_Click);
            // 
            // labelBasınç
            // 
            this.labelBasınç.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBasınç.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBasınç.Location = new System.Drawing.Point(255, 311);
            this.labelBasınç.Name = "labelBasınç";
            this.labelBasınç.Size = new System.Drawing.Size(218, 46);
            this.labelBasınç.TabIndex = 6;
            this.labelBasınç.Text = "Basınç:";
            this.labelBasınç.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGunDogumu
            // 
            this.labelGunDogumu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGunDogumu.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGunDogumu.Location = new System.Drawing.Point(25, 367);
            this.labelGunDogumu.Name = "labelGunDogumu";
            this.labelGunDogumu.Size = new System.Drawing.Size(202, 48);
            this.labelGunDogumu.TabIndex = 7;
            this.labelGunDogumu.Text = "Gün Doğumu:";
            this.labelGunDogumu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRuzgarHizi
            // 
            this.labelRuzgarHizi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRuzgarHizi.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRuzgarHizi.Location = new System.Drawing.Point(25, 311);
            this.labelRuzgarHizi.Name = "labelRuzgarHizi";
            this.labelRuzgarHizi.Size = new System.Drawing.Size(202, 46);
            this.labelRuzgarHizi.TabIndex = 8;
            this.labelRuzgarHizi.Text = "Rüzgar Hızı:";
            this.labelRuzgarHizi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRuzgarHizi.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelGunBatimi
            // 
            this.labelGunBatimi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGunBatimi.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGunBatimi.Location = new System.Drawing.Point(255, 367);
            this.labelGunBatimi.Name = "labelGunBatimi";
            this.labelGunBatimi.Size = new System.Drawing.Size(218, 48);
            this.labelGunBatimi.TabIndex = 9;
            this.labelGunBatimi.Text = "Gün Batımı:";
            this.labelGunBatimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Şehir Giriniz: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelGunBatimi);
            this.Controls.Add(this.labelRuzgarHizi);
            this.Controls.Add(this.labelGunDogumu);
            this.Controls.Add(this.labelBasınç);
            this.Controls.Add(this.labelNem);
            this.Controls.Add(this.labelHissedilenSicaklik);
            this.Controls.Add(this.labelBulutDurumu);
            this.Controls.Add(this.labelSicaklik);
            this.Controls.Add(this.labelHavaDurumu);
            this.Controls.Add(this.labelSehir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelSehir;
        private System.Windows.Forms.Label labelHavaDurumu;
        private System.Windows.Forms.Label labelSicaklik;
        private System.Windows.Forms.Label labelBulutDurumu;
        private System.Windows.Forms.Label labelHissedilenSicaklik;
        private System.Windows.Forms.Label labelNem;
        private System.Windows.Forms.Label labelBasınç;
        private System.Windows.Forms.Label labelGunDogumu;
        private System.Windows.Forms.Label labelRuzgarHizi;
        private System.Windows.Forms.Label labelGunBatimi;
        private System.Windows.Forms.Label label1;
    }
}

