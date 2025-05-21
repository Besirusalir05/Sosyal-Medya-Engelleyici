namespace SosyalMedyaEngelleyici
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
            this.btnİns = new System.Windows.Forms.Button();
            this.btnYtb = new System.Windows.Forms.Button();
            this.btnFcbk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnİns
            // 
            this.btnİns.BackgroundImage = global::SosyalMedyaEngelleyici.Properties.Resources.instagram;
            this.btnİns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnİns.Location = new System.Drawing.Point(607, 208);
            this.btnİns.Name = "btnİns";
            this.btnİns.Size = new System.Drawing.Size(204, 83);
            this.btnİns.TabIndex = 2;
            this.btnİns.UseVisualStyleBackColor = true;
            this.btnİns.Click += new System.EventHandler(this.btnİns_Click);
            // 
            // btnYtb
            // 
            this.btnYtb.BackgroundImage = global::SosyalMedyaEngelleyici.Properties.Resources.Logo_of_YouTube__2015_2017__svg;
            this.btnYtb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYtb.Location = new System.Drawing.Point(329, 208);
            this.btnYtb.Name = "btnYtb";
            this.btnYtb.Size = new System.Drawing.Size(204, 83);
            this.btnYtb.TabIndex = 1;
            this.btnYtb.UseVisualStyleBackColor = true;
            this.btnYtb.Click += new System.EventHandler(this.btnYtb_Click);
            // 
            // btnFcbk
            // 
            this.btnFcbk.BackgroundImage = global::SosyalMedyaEngelleyici.Properties.Resources.Facebook_New_Logo__2015__svg;
            this.btnFcbk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFcbk.Location = new System.Drawing.Point(42, 208);
            this.btnFcbk.Name = "btnFcbk";
            this.btnFcbk.Size = new System.Drawing.Size(204, 83);
            this.btnFcbk.TabIndex = 0;
            this.btnFcbk.UseVisualStyleBackColor = true;
            this.btnFcbk.Click += new System.EventHandler(this.btnFcbk_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(863, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yasaklı Uygulamalar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(296, 389);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(0, 16);
            this.labelX.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(852, 552);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnİns);
            this.Controls.Add(this.btnYtb);
            this.Controls.Add(this.btnFcbk);
            this.Name = "Form1";
            this.Text = "Sosyal Medya Engelleyici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFcbk;
        private System.Windows.Forms.Button btnYtb;
        private System.Windows.Forms.Button btnİns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX;
    }
}

