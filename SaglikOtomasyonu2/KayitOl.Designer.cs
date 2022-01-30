
namespace SaglikOtomasyonu2
{
    partial class KayitOl
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
            this.lb_isim = new System.Windows.Forms.Label();
            this.lb_soyisim = new System.Windows.Forms.Label();
            this.lb_tc = new System.Windows.Forms.Label();
            this.lb_cinsiyet = new System.Windows.Forms.Label();
            this.lb_dogumt = new System.Windows.Forms.Label();
            this.lb_sifre = new System.Windows.Forms.Label();
            this.lb_sifretekrar = new System.Windows.Forms.Label();
            this.kayitAd = new System.Windows.Forms.TextBox();
            this.kayitSoyAd = new System.Windows.Forms.TextBox();
            this.kayitTC = new System.Windows.Forms.MaskedTextBox();
            this.kayitErkek = new System.Windows.Forms.RadioButton();
            this.kayitKadın = new System.Windows.Forms.RadioButton();
            this.kayitSifre = new System.Windows.Forms.TextBox();
            this.kayitSifreTekrar = new System.Windows.Forms.TextBox();
            this.kayitButtonKayıt = new System.Windows.Forms.Button();
            this.kayitGeri = new System.Windows.Forms.Button();
            this.KayitDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lb_isim
            // 
            this.lb_isim.AutoSize = true;
            this.lb_isim.Location = new System.Drawing.Point(19, 23);
            this.lb_isim.Name = "lb_isim";
            this.lb_isim.Size = new System.Drawing.Size(42, 23);
            this.lb_isim.TabIndex = 0;
            this.lb_isim.Text = "Ad:";
            // 
            // lb_soyisim
            // 
            this.lb_soyisim.AutoSize = true;
            this.lb_soyisim.Location = new System.Drawing.Point(19, 62);
            this.lb_soyisim.Name = "lb_soyisim";
            this.lb_soyisim.Size = new System.Drawing.Size(74, 23);
            this.lb_soyisim.TabIndex = 1;
            this.lb_soyisim.Text = "Soyad:";
            // 
            // lb_tc
            // 
            this.lb_tc.AutoSize = true;
            this.lb_tc.Location = new System.Drawing.Point(19, 100);
            this.lb_tc.Name = "lb_tc";
            this.lb_tc.Size = new System.Drawing.Size(130, 23);
            this.lb_tc.TabIndex = 2;
            this.lb_tc.Text = "TC Kimlik No:";
            // 
            // lb_cinsiyet
            // 
            this.lb_cinsiyet.AutoSize = true;
            this.lb_cinsiyet.Location = new System.Drawing.Point(19, 137);
            this.lb_cinsiyet.Name = "lb_cinsiyet";
            this.lb_cinsiyet.Size = new System.Drawing.Size(88, 23);
            this.lb_cinsiyet.TabIndex = 3;
            this.lb_cinsiyet.Text = "Cinsiyet:";
            // 
            // lb_dogumt
            // 
            this.lb_dogumt.AutoSize = true;
            this.lb_dogumt.Location = new System.Drawing.Point(19, 173);
            this.lb_dogumt.Name = "lb_dogumt";
            this.lb_dogumt.Size = new System.Drawing.Size(135, 23);
            this.lb_dogumt.TabIndex = 4;
            this.lb_dogumt.Text = "Doğum Tarihi:";
            // 
            // lb_sifre
            // 
            this.lb_sifre.AutoSize = true;
            this.lb_sifre.Location = new System.Drawing.Point(19, 210);
            this.lb_sifre.Name = "lb_sifre";
            this.lb_sifre.Size = new System.Drawing.Size(53, 23);
            this.lb_sifre.TabIndex = 5;
            this.lb_sifre.Text = "Şifre:";
            // 
            // lb_sifretekrar
            // 
            this.lb_sifretekrar.AutoSize = true;
            this.lb_sifretekrar.Location = new System.Drawing.Point(19, 247);
            this.lb_sifretekrar.Name = "lb_sifretekrar";
            this.lb_sifretekrar.Size = new System.Drawing.Size(192, 23);
            this.lb_sifretekrar.TabIndex = 6;
            this.lb_sifretekrar.Text = "Şifreyi Tekrar Giriniz:";
            // 
            // kayitAd
            // 
            this.kayitAd.Location = new System.Drawing.Point(216, 20);
            this.kayitAd.Name = "kayitAd";
            this.kayitAd.Size = new System.Drawing.Size(317, 31);
            this.kayitAd.TabIndex = 7;
            this.kayitAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kayitAd_KeyPress);
            // 
            // kayitSoyAd
            // 
            this.kayitSoyAd.Location = new System.Drawing.Point(216, 59);
            this.kayitSoyAd.Name = "kayitSoyAd";
            this.kayitSoyAd.Size = new System.Drawing.Size(317, 31);
            this.kayitSoyAd.TabIndex = 8;
            this.kayitSoyAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kayitAd_KeyPress);
            // 
            // kayitTC
            // 
            this.kayitTC.Location = new System.Drawing.Point(216, 97);
            this.kayitTC.Mask = "00000000000";
            this.kayitTC.Name = "kayitTC";
            this.kayitTC.Size = new System.Drawing.Size(142, 31);
            this.kayitTC.TabIndex = 9;
            // 
            // kayitErkek
            // 
            this.kayitErkek.AutoSize = true;
            this.kayitErkek.Location = new System.Drawing.Point(216, 135);
            this.kayitErkek.Name = "kayitErkek";
            this.kayitErkek.Size = new System.Drawing.Size(78, 27);
            this.kayitErkek.TabIndex = 10;
            this.kayitErkek.TabStop = true;
            this.kayitErkek.Text = "Erkek";
            this.kayitErkek.UseVisualStyleBackColor = true;
            // 
            // kayitKadın
            // 
            this.kayitKadın.AutoSize = true;
            this.kayitKadın.Location = new System.Drawing.Point(300, 135);
            this.kayitKadın.Name = "kayitKadın";
            this.kayitKadın.Size = new System.Drawing.Size(82, 27);
            this.kayitKadın.TabIndex = 11;
            this.kayitKadın.TabStop = true;
            this.kayitKadın.Text = "Kadın";
            this.kayitKadın.UseVisualStyleBackColor = true;
            // 
            // kayitSifre
            // 
            this.kayitSifre.Location = new System.Drawing.Point(216, 207);
            this.kayitSifre.Name = "kayitSifre";
            this.kayitSifre.Size = new System.Drawing.Size(317, 31);
            this.kayitSifre.TabIndex = 13;
            // 
            // kayitSifreTekrar
            // 
            this.kayitSifreTekrar.Location = new System.Drawing.Point(216, 244);
            this.kayitSifreTekrar.Name = "kayitSifreTekrar";
            this.kayitSifreTekrar.Size = new System.Drawing.Size(317, 31);
            this.kayitSifreTekrar.TabIndex = 14;
            // 
            // kayitButtonKayıt
            // 
            this.kayitButtonKayıt.Location = new System.Drawing.Point(279, 295);
            this.kayitButtonKayıt.Name = "kayitButtonKayıt";
            this.kayitButtonKayıt.Size = new System.Drawing.Size(126, 60);
            this.kayitButtonKayıt.TabIndex = 15;
            this.kayitButtonKayıt.Text = "Kayıt Ol";
            this.kayitButtonKayıt.UseVisualStyleBackColor = true;
            this.kayitButtonKayıt.Click += new System.EventHandler(this.kayitButtonKayıt_Click);
            // 
            // kayitGeri
            // 
            this.kayitGeri.Location = new System.Drawing.Point(23, 295);
            this.kayitGeri.Name = "kayitGeri";
            this.kayitGeri.Size = new System.Drawing.Size(188, 60);
            this.kayitGeri.TabIndex = 16;
            this.kayitGeri.Text = "Giriş Ekranına Dön";
            this.kayitGeri.UseVisualStyleBackColor = true;
            this.kayitGeri.Click += new System.EventHandler(this.kayitGeri_Click);
            // 
            // KayitDogumTarih
            // 
            this.KayitDogumTarih.Location = new System.Drawing.Point(216, 167);
            this.KayitDogumTarih.Name = "KayitDogumTarih";
            this.KayitDogumTarih.Size = new System.Drawing.Size(317, 31);
            this.KayitDogumTarih.TabIndex = 17;
            // 
            // KayitOl
            // 
            this.AcceptButton = this.kayitButtonKayıt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(545, 377);
            this.Controls.Add(this.KayitDogumTarih);
            this.Controls.Add(this.kayitGeri);
            this.Controls.Add(this.kayitButtonKayıt);
            this.Controls.Add(this.kayitSifreTekrar);
            this.Controls.Add(this.kayitSifre);
            this.Controls.Add(this.kayitKadın);
            this.Controls.Add(this.kayitErkek);
            this.Controls.Add(this.kayitTC);
            this.Controls.Add(this.kayitSoyAd);
            this.Controls.Add(this.kayitAd);
            this.Controls.Add(this.lb_sifretekrar);
            this.Controls.Add(this.lb_sifre);
            this.Controls.Add(this.lb_dogumt);
            this.Controls.Add(this.lb_cinsiyet);
            this.Controls.Add(this.lb_tc);
            this.Controls.Add(this.lb_soyisim);
            this.Controls.Add(this.lb_isim);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "KayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitOl";
            this.Load += new System.EventHandler(this.KayitOl_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KayitOl_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_isim;
        private System.Windows.Forms.Label lb_soyisim;
        private System.Windows.Forms.Label lb_tc;
        private System.Windows.Forms.Label lb_cinsiyet;
        private System.Windows.Forms.Label lb_dogumt;
        private System.Windows.Forms.Label lb_sifre;
        private System.Windows.Forms.Label lb_sifretekrar;
        private System.Windows.Forms.TextBox kayitAd;
        private System.Windows.Forms.TextBox kayitSoyAd;
        private System.Windows.Forms.MaskedTextBox kayitTC;
        private System.Windows.Forms.RadioButton kayitErkek;
        private System.Windows.Forms.RadioButton kayitKadın;
        private System.Windows.Forms.TextBox kayitSifre;
        private System.Windows.Forms.TextBox kayitSifreTekrar;
        private System.Windows.Forms.Button kayitButtonKayıt;
        private System.Windows.Forms.Button kayitGeri;
        private System.Windows.Forms.DateTimePicker KayitDogumTarih;
    }
}