
namespace Polymorphism
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
            this.btnInsan = new System.Windows.Forms.Button();
            this.btnHayvan = new System.Windows.Forms.Button();
            this.btnBitki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsan
            // 
            this.btnInsan.Location = new System.Drawing.Point(124, 122);
            this.btnInsan.Name = "btnInsan";
            this.btnInsan.Size = new System.Drawing.Size(107, 43);
            this.btnInsan.TabIndex = 0;
            this.btnInsan.Text = "İnsan";
            this.btnInsan.UseVisualStyleBackColor = true;
            this.btnInsan.Click += new System.EventHandler(this.btnInsan_Click);
            // 
            // btnHayvan
            // 
            this.btnHayvan.Location = new System.Drawing.Point(330, 122);
            this.btnHayvan.Name = "btnHayvan";
            this.btnHayvan.Size = new System.Drawing.Size(107, 43);
            this.btnHayvan.TabIndex = 1;
            this.btnHayvan.Text = "Hayvan";
            this.btnHayvan.UseVisualStyleBackColor = true;
            this.btnHayvan.Click += new System.EventHandler(this.btnHayvan_Click);
            // 
            // btnBitki
            // 
            this.btnBitki.Location = new System.Drawing.Point(528, 122);
            this.btnBitki.Name = "btnBitki";
            this.btnBitki.Size = new System.Drawing.Size(107, 43);
            this.btnBitki.TabIndex = 2;
            this.btnBitki.Text = "Bitki";
            this.btnBitki.UseVisualStyleBackColor = true;
            this.btnBitki.Click += new System.EventHandler(this.btnBitki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBitki);
            this.Controls.Add(this.btnHayvan);
            this.Controls.Add(this.btnInsan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsan;
        private System.Windows.Forms.Button btnHayvan;
        private System.Windows.Forms.Button btnBitki;
    }
}

