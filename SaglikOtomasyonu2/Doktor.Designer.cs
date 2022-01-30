
namespace SaglikOtomasyonu2
{
    partial class Doktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktor));
            this.hastabilgileri = new System.Windows.Forms.DataGridView();
            this.hastalarlistesi = new System.Windows.Forms.Label();
            this.hastagoster = new System.Windows.Forms.Button();
            this.ilaclarliste = new System.Windows.Forms.DataGridView();
            this.ilaclar = new System.Windows.Forms.Label();
            this.hosgeldinlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ilaclarigoster = new System.Windows.Forms.Button();
            this.hastatc = new System.Windows.Forms.TextBox();
            this.ilaccombobox = new System.Windows.Forms.ComboBox();
            this.ilacyazbuton = new System.Windows.Forms.Button();
            this.tcnolabel = new System.Windows.Forms.Label();
            this.ilaclabel = new System.Windows.Forms.Label();
            this.recetelabel = new System.Windows.Forms.Label();
            this.anamenubuton = new System.Windows.Forms.Button();
            this.ilaclarigizle = new System.Windows.Forms.Button();
            this.bilgibuton = new System.Windows.Forms.Button();
            this.ilacdozcombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hastabilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaclarliste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hastabilgileri
            // 
            this.hastabilgileri.AllowUserToResizeColumns = false;
            this.hastabilgileri.AllowUserToResizeRows = false;
            this.hastabilgileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hastabilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastabilgileri.Location = new System.Drawing.Point(29, 181);
            this.hastabilgileri.Name = "hastabilgileri";
            this.hastabilgileri.ReadOnly = true;
            this.hastabilgileri.Size = new System.Drawing.Size(532, 150);
            this.hastabilgileri.TabIndex = 0;
            // 
            // hastalarlistesi
            // 
            this.hastalarlistesi.AutoSize = true;
            this.hastalarlistesi.BackColor = System.Drawing.Color.Transparent;
            this.hastalarlistesi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastalarlistesi.Location = new System.Drawing.Point(25, 155);
            this.hastalarlistesi.Name = "hastalarlistesi";
            this.hastalarlistesi.Size = new System.Drawing.Size(141, 23);
            this.hastalarlistesi.TabIndex = 1;
            this.hastalarlistesi.Text = "Hastalar listesi";
            // 
            // hastagoster
            // 
            this.hastagoster.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastagoster.Location = new System.Drawing.Point(567, 181);
            this.hastagoster.Name = "hastagoster";
            this.hastagoster.Size = new System.Drawing.Size(113, 48);
            this.hastagoster.TabIndex = 2;
            this.hastagoster.Text = "Hasta listesini yenile";
            this.hastagoster.UseVisualStyleBackColor = true;
            this.hastagoster.Click += new System.EventHandler(this.hastagoster_Click);
            // 
            // ilaclarliste
            // 
            this.ilaclarliste.AllowUserToResizeColumns = false;
            this.ilaclarliste.AllowUserToResizeRows = false;
            this.ilaclarliste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ilaclarliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ilaclarliste.Location = new System.Drawing.Point(29, 369);
            this.ilaclarliste.Name = "ilaclarliste";
            this.ilaclarliste.ReadOnly = true;
            this.ilaclarliste.Size = new System.Drawing.Size(351, 126);
            this.ilaclarliste.TabIndex = 3;
            // 
            // ilaclar
            // 
            this.ilaclar.AutoSize = true;
            this.ilaclar.BackColor = System.Drawing.Color.Transparent;
            this.ilaclar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilaclar.Location = new System.Drawing.Point(25, 343);
            this.ilaclar.Name = "ilaclar";
            this.ilaclar.Size = new System.Drawing.Size(69, 23);
            this.ilaclar.TabIndex = 4;
            this.ilaclar.Text = "İlaçlar";
            // 
            // hosgeldinlabel
            // 
            this.hosgeldinlabel.AutoSize = true;
            this.hosgeldinlabel.BackColor = System.Drawing.Color.Transparent;
            this.hosgeldinlabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hosgeldinlabel.Location = new System.Drawing.Point(291, 65);
            this.hosgeldinlabel.Name = "hosgeldinlabel";
            this.hosgeldinlabel.Size = new System.Drawing.Size(174, 36);
            this.hosgeldinlabel.TabIndex = 5;
            this.hosgeldinlabel.Text = "Hoşgeldiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SaglikOtomasyonu2.Properties.Resources.hearth;
            this.pictureBox1.Location = new System.Drawing.Point(29, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ilaclarigoster
            // 
            this.ilaclarigoster.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilaclarigoster.Location = new System.Drawing.Point(126, 501);
            this.ilaclarigoster.Name = "ilaclarigoster";
            this.ilaclarigoster.Size = new System.Drawing.Size(126, 48);
            this.ilaclarigoster.TabIndex = 7;
            this.ilaclarigoster.Text = "İlaç listesini görüntüle";
            this.ilaclarigoster.UseVisualStyleBackColor = true;
            this.ilaclarigoster.Click += new System.EventHandler(this.ilaclarigoster_Click);
            // 
            // hastatc
            // 
            this.hastatc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastatc.Location = new System.Drawing.Point(603, 391);
            this.hastatc.Name = "hastatc";
            this.hastatc.Size = new System.Drawing.Size(169, 27);
            this.hastatc.TabIndex = 12;
            this.hastatc.Text = "T.C. Kimlik No";
            this.hastatc.Enter += new System.EventHandler(this.hastatc_Enter);
            this.hastatc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hastatc_KeyPress);
            this.hastatc.Leave += new System.EventHandler(this.hastatc_Leave);
            // 
            // ilaccombobox
            // 
            this.ilaccombobox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilaccombobox.FormattingEnabled = true;
            this.ilaccombobox.IntegralHeight = false;
            this.ilaccombobox.ItemHeight = 21;
            this.ilaccombobox.Location = new System.Drawing.Point(603, 426);
            this.ilaccombobox.Name = "ilaccombobox";
            this.ilaccombobox.Size = new System.Drawing.Size(169, 29);
            this.ilaccombobox.TabIndex = 13;
            this.ilaccombobox.Text = "Seçiniz";
            // 
            // ilacyazbuton
            // 
            this.ilacyazbuton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilacyazbuton.Location = new System.Drawing.Point(603, 501);
            this.ilacyazbuton.Name = "ilacyazbuton";
            this.ilacyazbuton.Size = new System.Drawing.Size(106, 35);
            this.ilacyazbuton.TabIndex = 14;
            this.ilacyazbuton.Text = "İlaç Yaz";
            this.ilacyazbuton.UseVisualStyleBackColor = true;
            this.ilacyazbuton.Click += new System.EventHandler(this.ilacyazbuton_Click);
            // 
            // tcnolabel
            // 
            this.tcnolabel.AutoSize = true;
            this.tcnolabel.BackColor = System.Drawing.Color.Transparent;
            this.tcnolabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcnolabel.Location = new System.Drawing.Point(440, 396);
            this.tcnolabel.Name = "tcnolabel";
            this.tcnolabel.Size = new System.Drawing.Size(157, 18);
            this.tcnolabel.TabIndex = 15;
            this.tcnolabel.Text = "TC kimlik numarası  :";
            // 
            // ilaclabel
            // 
            this.ilaclabel.AutoSize = true;
            this.ilaclabel.BackColor = System.Drawing.Color.Transparent;
            this.ilaclabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilaclabel.Location = new System.Drawing.Point(400, 431);
            this.ilaclabel.Name = "ilaclabel";
            this.ilaclabel.Size = new System.Drawing.Size(197, 18);
            this.ilaclabel.TabIndex = 16;
            this.ilaclabel.Text = "Reçeteye yazılacak ilaç :";
            // 
            // recetelabel
            // 
            this.recetelabel.AutoSize = true;
            this.recetelabel.BackColor = System.Drawing.Color.Transparent;
            this.recetelabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recetelabel.Location = new System.Drawing.Point(599, 368);
            this.recetelabel.Name = "recetelabel";
            this.recetelabel.Size = new System.Drawing.Size(93, 19);
            this.recetelabel.TabIndex = 17;
            this.recetelabel.Text = "Reçete yaz";
            // 
            // anamenubuton
            // 
            this.anamenubuton.BackColor = System.Drawing.Color.Silver;
            this.anamenubuton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anamenubuton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.anamenubuton.Location = new System.Drawing.Point(659, 90);
            this.anamenubuton.Name = "anamenubuton";
            this.anamenubuton.Size = new System.Drawing.Size(113, 48);
            this.anamenubuton.TabIndex = 18;
            this.anamenubuton.Text = "Giriş ekranına dön";
            this.anamenubuton.UseVisualStyleBackColor = false;
            this.anamenubuton.Click += new System.EventHandler(this.anamenubuton_Click);
            // 
            // ilaclarigizle
            // 
            this.ilaclarigizle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilaclarigizle.Location = new System.Drawing.Point(254, 501);
            this.ilaclarigizle.Name = "ilaclarigizle";
            this.ilaclarigizle.Size = new System.Drawing.Size(126, 48);
            this.ilaclarigizle.TabIndex = 19;
            this.ilaclarigizle.Text = "İlaç listesini gizle";
            this.ilaclarigizle.UseVisualStyleBackColor = true;
            this.ilaclarigizle.Click += new System.EventHandler(this.ilaclarigizle_Click);
            // 
            // bilgibuton
            // 
            this.bilgibuton.BackColor = System.Drawing.Color.Silver;
            this.bilgibuton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgibuton.Location = new System.Drawing.Point(659, 36);
            this.bilgibuton.Name = "bilgibuton";
            this.bilgibuton.Size = new System.Drawing.Size(113, 48);
            this.bilgibuton.TabIndex = 20;
            this.bilgibuton.Text = "Bilgilerim";
            this.bilgibuton.UseVisualStyleBackColor = false;
            this.bilgibuton.Click += new System.EventHandler(this.bilgibuton_Click);
            // 
            // ilacdozcombobox
            // 
            this.ilacdozcombobox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilacdozcombobox.FormattingEnabled = true;
            this.ilacdozcombobox.Location = new System.Drawing.Point(603, 461);
            this.ilacdozcombobox.Name = "ilacdozcombobox";
            this.ilacdozcombobox.Size = new System.Drawing.Size(121, 29);
            this.ilacdozcombobox.TabIndex = 21;
            this.ilacdozcombobox.Text = "Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(497, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Doz seçiniz :";
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ilacdozcombobox);
            this.Controls.Add(this.bilgibuton);
            this.Controls.Add(this.ilaclarigizle);
            this.Controls.Add(this.anamenubuton);
            this.Controls.Add(this.recetelabel);
            this.Controls.Add(this.ilaclabel);
            this.Controls.Add(this.tcnolabel);
            this.Controls.Add(this.ilacyazbuton);
            this.Controls.Add(this.ilaccombobox);
            this.Controls.Add(this.hastatc);
            this.Controls.Add(this.ilaclarigoster);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hosgeldinlabel);
            this.Controls.Add(this.ilaclar);
            this.Controls.Add(this.ilaclarliste);
            this.Controls.Add(this.hastagoster);
            this.Controls.Add(this.hastalarlistesi);
            this.Controls.Add(this.hastabilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Doktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor";
            this.Load += new System.EventHandler(this.Doktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastabilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaclarliste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView hastabilgileri;
        private System.Windows.Forms.Label hastalarlistesi;
        private System.Windows.Forms.Button hastagoster;
        private System.Windows.Forms.DataGridView ilaclarliste;
        private System.Windows.Forms.Label ilaclar;
        public System.Windows.Forms.Label hosgeldinlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ilaclarigoster;
        private System.Windows.Forms.TextBox hastatc;
        private System.Windows.Forms.ComboBox ilaccombobox;
        private System.Windows.Forms.Button ilacyazbuton;
        private System.Windows.Forms.Label tcnolabel;
        private System.Windows.Forms.Label ilaclabel;
        private System.Windows.Forms.Label recetelabel;
        private System.Windows.Forms.Button anamenubuton;
        private System.Windows.Forms.Button ilaclarigizle;
        private System.Windows.Forms.Button bilgibuton;
        private System.Windows.Forms.ComboBox ilacdozcombobox;
        private System.Windows.Forms.Label label1;
    }
}