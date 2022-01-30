
namespace SaglikOtomasyonu2
{
    partial class Ilaclarim
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
            this.ilacButon = new System.Windows.Forms.Button();
            this.ilacData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ilacData)).BeginInit();
            this.SuspendLayout();
            // 
            // ilacButon
            // 
            this.ilacButon.Location = new System.Drawing.Point(387, 18);
            this.ilacButon.Name = "ilacButon";
            this.ilacButon.Size = new System.Drawing.Size(118, 73);
            this.ilacButon.TabIndex = 1;
            this.ilacButon.Text = "İlaçlarımı Göster";
            this.ilacButon.UseVisualStyleBackColor = true;
            this.ilacButon.Click += new System.EventHandler(this.ilacButon_Click);
            // 
            // ilacData
            // 
            this.ilacData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ilacData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ilacData.Location = new System.Drawing.Point(12, 18);
            this.ilacData.Name = "ilacData";
            this.ilacData.ReadOnly = true;
            this.ilacData.Size = new System.Drawing.Size(353, 73);
            this.ilacData.TabIndex = 2;
            // 
            // Ilaclarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 123);
            this.Controls.Add(this.ilacData);
            this.Controls.Add(this.ilacButon);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ilaclarim";
            this.Text = "Ilaclarim";
            this.Load += new System.EventHandler(this.Ilaclarim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ilacData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ilacButon;
        private System.Windows.Forms.DataGridView ilacData;
    }
}