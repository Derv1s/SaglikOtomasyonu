
namespace SaglikOtomasyonu2
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcNo = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.doctorRadio = new System.Windows.Forms.RadioButton();
            this.hastaRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cikisButton = new System.Windows.Forms.Button();
            this.girisButton = new System.Windows.Forms.Button();
            this.girisKayitol = new System.Windows.Forms.Button();
            this.sifreGoster = new System.Windows.Forms.CheckBox();
            this.hakSayisi = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tcNo
            // 
            this.tcNo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcNo.Location = new System.Drawing.Point(80, 160);
            this.tcNo.MaxLength = 11;
            this.tcNo.Name = "tcNo";
            this.tcNo.Size = new System.Drawing.Size(160, 26);
            this.tcNo.TabIndex = 1;
            this.tcNo.Text = "TC Numaranızı Girin";
            this.tcNo.Click += new System.EventHandler(this.tcNo_Click);
            this.tcNo.TextChanged += new System.EventHandler(this.tcNo_TextChanged_1);
            // 
            // parola
            // 
            this.parola.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parola.Location = new System.Drawing.Point(80, 192);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(160, 26);
            this.parola.TabIndex = 2;
            this.parola.Text = "Parola Giriniz";
            this.parola.Click += new System.EventHandler(this.parola_Click);
            // 
            // doctorRadio
            // 
            this.doctorRadio.AutoSize = true;
            this.doctorRadio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doctorRadio.Location = new System.Drawing.Point(80, 224);
            this.doctorRadio.Name = "doctorRadio";
            this.doctorRadio.Size = new System.Drawing.Size(75, 22);
            this.doctorRadio.TabIndex = 3;
            this.doctorRadio.TabStop = true;
            this.doctorRadio.Text = "Doktor";
            this.doctorRadio.UseVisualStyleBackColor = true;
            // 
            // hastaRadio
            // 
            this.hastaRadio.AutoSize = true;
            this.hastaRadio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaRadio.Location = new System.Drawing.Point(174, 224);
            this.hastaRadio.Name = "hastaRadio";
            this.hastaRadio.Size = new System.Drawing.Size(66, 22);
            this.hastaRadio.TabIndex = 4;
            this.hastaRadio.TabStop = true;
            this.hastaRadio.Text = "Hasta";
            this.hastaRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "SAĞLIK OTOMASYONU 2.0";
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.Red;
            this.cikisButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.Location = new System.Drawing.Point(165, 253);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(75, 32);
            this.cikisButton.TabIndex = 6;
            this.cikisButton.Text = "Çıkış";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.Color.GreenYellow;
            this.girisButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButton.Location = new System.Drawing.Point(79, 253);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(76, 32);
            this.girisButton.TabIndex = 7;
            this.girisButton.Text = "Giriş";
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // girisKayitol
            // 
            this.girisKayitol.BackColor = System.Drawing.Color.DarkCyan;
            this.girisKayitol.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisKayitol.Location = new System.Drawing.Point(79, 291);
            this.girisKayitol.Name = "girisKayitol";
            this.girisKayitol.Size = new System.Drawing.Size(161, 35);
            this.girisKayitol.TabIndex = 8;
            this.girisKayitol.Text = "Kayıt Ol";
            this.girisKayitol.UseVisualStyleBackColor = false;
            this.girisKayitol.Click += new System.EventHandler(this.girisKayitol_Click);
            // 
            // sifreGoster
            // 
            this.sifreGoster.AutoSize = true;
            this.sifreGoster.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreGoster.Location = new System.Drawing.Point(246, 196);
            this.sifreGoster.Name = "sifreGoster";
            this.sifreGoster.Size = new System.Drawing.Size(73, 20);
            this.sifreGoster.TabIndex = 9;
            this.sifreGoster.Text = "ŞifreGstr";
            this.sifreGoster.UseVisualStyleBackColor = true;
            this.sifreGoster.CheckedChanged += new System.EventHandler(this.sifreGoster_CheckedChanged);
            // 
            // hakSayisi
            // 
            this.hakSayisi.AutoSize = true;
            this.hakSayisi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hakSayisi.Location = new System.Drawing.Point(55, 259);
            this.hakSayisi.Name = "hakSayisi";
            this.hakSayisi.Size = new System.Drawing.Size(18, 19);
            this.hakSayisi.TabIndex = 10;
            this.hakSayisi.Text = "3";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(315, 352);
            this.Controls.Add(this.hakSayisi);
            this.Controls.Add(this.sifreGoster);
            this.Controls.Add(this.girisKayitol);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hastaRadio);
            this.Controls.Add(this.doctorRadio);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.tcNo);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tcNo;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.RadioButton doctorRadio;
        private System.Windows.Forms.RadioButton hastaRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.Button girisKayitol;
        private System.Windows.Forms.CheckBox sifreGoster;
        private System.Windows.Forms.Label hakSayisi;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

