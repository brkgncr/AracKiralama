namespace AracKiralama
{
    partial class frmAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKiralama = new System.Windows.Forms.Button();
            this.btnAracListeleme = new System.Windows.Forms.Button();
            this.btnAracKayit = new System.Windows.Forms.Button();
            this.btnMusteriListeleme = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnKiralama);
            this.panel1.Controls.Add(this.btnAracListeleme);
            this.panel1.Controls.Add(this.btnAracKayit);
            this.panel1.Controls.Add(this.btnMusteriListeleme);
            this.panel1.Controls.Add(this.btnMusteriEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 517);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.ImageIndex = 4;
            this.btnExit.ImageList = this.ımageList1;
            this.btnExit.Location = new System.Drawing.Point(0, 435);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 81);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Çıkış";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "arabalisteleme.png");
            this.ımageList1.Images.SetKeyName(1, "aracekle.png");
            this.ımageList1.Images.SetKeyName(2, "kiralama.png");
            this.ımageList1.Images.SetKeyName(3, "musterilistele.jpg");
            this.ımageList1.Images.SetKeyName(4, "cikis.png");
            this.ımageList1.Images.SetKeyName(5, "satislar.png");
            this.ımageList1.Images.SetKeyName(6, "musteriekle.png");
            this.ımageList1.Images.SetKeyName(7, "satislar.png");
            // 
            // btnKiralama
            // 
            this.btnKiralama.BackColor = System.Drawing.Color.White;
            this.btnKiralama.ImageIndex = 2;
            this.btnKiralama.ImageList = this.ımageList1;
            this.btnKiralama.Location = new System.Drawing.Point(0, 348);
            this.btnKiralama.Name = "btnKiralama";
            this.btnKiralama.Size = new System.Drawing.Size(120, 81);
            this.btnKiralama.TabIndex = 5;
            this.btnKiralama.Text = "Kiralama";
            this.btnKiralama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKiralama.UseVisualStyleBackColor = false;
            this.btnKiralama.Click += new System.EventHandler(this.btnKiralama_Click);
            // 
            // btnAracListeleme
            // 
            this.btnAracListeleme.BackColor = System.Drawing.Color.White;
            this.btnAracListeleme.ImageIndex = 0;
            this.btnAracListeleme.ImageList = this.ımageList1;
            this.btnAracListeleme.Location = new System.Drawing.Point(0, 261);
            this.btnAracListeleme.Name = "btnAracListeleme";
            this.btnAracListeleme.Size = new System.Drawing.Size(120, 81);
            this.btnAracListeleme.TabIndex = 4;
            this.btnAracListeleme.Text = "Araç Listeleme";
            this.btnAracListeleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracListeleme.UseVisualStyleBackColor = false;
            this.btnAracListeleme.Click += new System.EventHandler(this.btnAracListeleme_Click);
            // 
            // btnAracKayit
            // 
            this.btnAracKayit.BackColor = System.Drawing.Color.White;
            this.btnAracKayit.ImageIndex = 1;
            this.btnAracKayit.ImageList = this.ımageList1;
            this.btnAracKayit.Location = new System.Drawing.Point(0, 174);
            this.btnAracKayit.Name = "btnAracKayit";
            this.btnAracKayit.Size = new System.Drawing.Size(120, 81);
            this.btnAracKayit.TabIndex = 3;
            this.btnAracKayit.Text = "Araç Ekleme";
            this.btnAracKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracKayit.UseVisualStyleBackColor = false;
            this.btnAracKayit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMusteriListeleme
            // 
            this.btnMusteriListeleme.BackColor = System.Drawing.Color.White;
            this.btnMusteriListeleme.ImageIndex = 3;
            this.btnMusteriListeleme.ImageList = this.ımageList1;
            this.btnMusteriListeleme.Location = new System.Drawing.Point(0, 87);
            this.btnMusteriListeleme.Name = "btnMusteriListeleme";
            this.btnMusteriListeleme.Size = new System.Drawing.Size(120, 81);
            this.btnMusteriListeleme.TabIndex = 2;
            this.btnMusteriListeleme.Text = "Müşteri Listeleme";
            this.btnMusteriListeleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriListeleme.UseVisualStyleBackColor = false;
            this.btnMusteriListeleme.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.White;
            this.btnMusteriEkle.ImageIndex = 6;
            this.btnMusteriEkle.ImageList = this.ımageList1;
            this.btnMusteriEkle.Location = new System.Drawing.Point(0, 0);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(120, 81);
            this.btnMusteriEkle.TabIndex = 1;
            this.btnMusteriEkle.Text = "Müşteri Ekleme";
            this.btnMusteriEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 517);
            this.Controls.Add(this.panel1);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnKiralama;
        private System.Windows.Forms.Button btnAracListeleme;
        private System.Windows.Forms.Button btnAracKayit;
        private System.Windows.Forms.Button btnMusteriListeleme;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

