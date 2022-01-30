
namespace SaglikOtomasyonu2
{
    partial class Doktorprofil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktorprofil));
            this.docBilgiler = new System.Windows.Forms.DataGridView();
            this.docTcLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.geridon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.docBilgiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // docBilgiler
            // 
            this.docBilgiler.AllowUserToResizeColumns = false;
            this.docBilgiler.AllowUserToResizeRows = false;
            this.docBilgiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.docBilgiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.docBilgiler.DefaultCellStyle = dataGridViewCellStyle1;
            this.docBilgiler.Location = new System.Drawing.Point(151, 26);
            this.docBilgiler.Name = "docBilgiler";
            this.docBilgiler.ReadOnly = true;
            this.docBilgiler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.docBilgiler.Size = new System.Drawing.Size(496, 67);
            this.docBilgiler.TabIndex = 0;
            // 
            // docTcLabel
            // 
            this.docTcLabel.AutoSize = true;
            this.docTcLabel.BackColor = System.Drawing.Color.Transparent;
            this.docTcLabel.Location = new System.Drawing.Point(22, 125);
            this.docTcLabel.Name = "docTcLabel";
            this.docTcLabel.Size = new System.Drawing.Size(35, 13);
            this.docTcLabel.TabIndex = 1;
            this.docTcLabel.Text = "label1";
            this.docTcLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SaglikOtomasyonu2.Properties.Resources.hearth;
            this.pictureBox1.Location = new System.Drawing.Point(25, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // geridon
            // 
            this.geridon.BackColor = System.Drawing.Color.Silver;
            this.geridon.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geridon.Location = new System.Drawing.Point(271, 105);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(243, 33);
            this.geridon.TabIndex = 3;
            this.geridon.Text = "Doktor işlem sayfasına geri dön";
            this.geridon.UseVisualStyleBackColor = false;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // Doktorprofil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(700, 150);
            this.ControlBox = false;
            this.Controls.Add(this.geridon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.docTcLabel);
            this.Controls.Add(this.docBilgiler);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doktorprofil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktorprofil";
            this.Load += new System.EventHandler(this.Doktorprofil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.docBilgiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView docBilgiler;
        private System.Windows.Forms.Label docTcLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button geridon;
    }
}