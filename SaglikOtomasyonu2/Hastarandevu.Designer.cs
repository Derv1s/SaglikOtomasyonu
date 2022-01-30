
namespace SaglikOtomasyonu2
{
    partial class Hastarandevu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hastarandevu));
            this.randevusebep = new System.Windows.Forms.ComboBox();
            this.randevutarihsec = new System.Windows.Forms.DateTimePicker();
            this.randevualbuton = new System.Windows.Forms.Button();
            this.randevusaatcombo = new System.Windows.Forms.ComboBox();
            this.tclabel = new System.Windows.Forms.Label();
            this.geridonbuton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // randevusebep
            // 
            this.randevusebep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevusebep.FormattingEnabled = true;
            this.randevusebep.Location = new System.Drawing.Point(114, 151);
            this.randevusebep.Name = "randevusebep";
            this.randevusebep.Size = new System.Drawing.Size(275, 32);
            this.randevusebep.TabIndex = 1;
            this.randevusebep.SelectedIndexChanged += new System.EventHandler(this.randevusaatsec_SelectedIndexChanged);
            // 
            // randevutarihsec
            // 
            this.randevutarihsec.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevutarihsec.Location = new System.Drawing.Point(114, 189);
            this.randevutarihsec.MaxDate = new System.DateTime(2021, 8, 31, 0, 0, 0, 0);
            this.randevutarihsec.MinDate = new System.DateTime(2021, 6, 16, 0, 0, 0, 0);
            this.randevutarihsec.Name = "randevutarihsec";
            this.randevutarihsec.Size = new System.Drawing.Size(275, 31);
            this.randevutarihsec.TabIndex = 2;
            this.randevutarihsec.Value = new System.DateTime(2021, 6, 16, 0, 0, 0, 0);
            // 
            // randevualbuton
            // 
            this.randevualbuton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevualbuton.Location = new System.Drawing.Point(114, 262);
            this.randevualbuton.Name = "randevualbuton";
            this.randevualbuton.Size = new System.Drawing.Size(120, 36);
            this.randevualbuton.TabIndex = 3;
            this.randevualbuton.Text = "Randevu al";
            this.randevualbuton.UseVisualStyleBackColor = true;
            this.randevualbuton.Click += new System.EventHandler(this.randevualbuton_Click);
            // 
            // randevusaatcombo
            // 
            this.randevusaatcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevusaatcombo.FormattingEnabled = true;
            this.randevusaatcombo.Location = new System.Drawing.Point(114, 224);
            this.randevusaatcombo.Name = "randevusaatcombo";
            this.randevusaatcombo.Size = new System.Drawing.Size(275, 32);
            this.randevusaatcombo.TabIndex = 4;
            // 
            // tclabel
            // 
            this.tclabel.AutoSize = true;
            this.tclabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tclabel.Location = new System.Drawing.Point(64, 119);
            this.tclabel.Name = "tclabel";
            this.tclabel.Size = new System.Drawing.Size(58, 19);
            this.tclabel.TabIndex = 6;
            this.tclabel.Text = "label1";
            // 
            // geridonbuton
            // 
            this.geridonbuton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geridonbuton.Location = new System.Drawing.Point(269, 262);
            this.geridonbuton.Name = "geridonbuton";
            this.geridonbuton.Size = new System.Drawing.Size(120, 36);
            this.geridonbuton.TabIndex = 9;
            this.geridonbuton.Text = "Geri dön";
            this.geridonbuton.UseVisualStyleBackColor = true;
            this.geridonbuton.Click += new System.EventHandler(this.geridonbuton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Hastarandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 341);
            this.Controls.Add(this.geridonbuton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tclabel);
            this.Controls.Add(this.randevusaatcombo);
            this.Controls.Add(this.randevualbuton);
            this.Controls.Add(this.randevutarihsec);
            this.Controls.Add(this.randevusebep);
            this.Name = "Hastarandevu";
            this.Text = "Hastarandevu";
            this.Load += new System.EventHandler(this.Hastarandevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox randevusebep;
        private System.Windows.Forms.DateTimePicker randevutarihsec;
        private System.Windows.Forms.Button randevualbuton;
        private System.Windows.Forms.ComboBox randevusaatcombo;
        private System.Windows.Forms.Label tclabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button geridonbuton;
    }
}