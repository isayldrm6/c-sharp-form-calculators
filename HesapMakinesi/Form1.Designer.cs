
namespace HesapMakinesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_üç = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_sonuc = new System.Windows.Forms.Button();
            this.btn_topla = new System.Windows.Forms.Button();
            this.btn_virgül = new System.Windows.Forms.Button();
            this.btn_sıfır = new System.Windows.Forms.Button();
            this.btn_cıkar = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.btn_yedi = new System.Windows.Forms.Button();
            this.btn_iki = new System.Windows.Forms.Button();
            this.btn_sekiz = new System.Windows.Forms.Button();
            this.btn_bir = new System.Windows.Forms.Button();
            this.btn_dokuz = new System.Windows.Forms.Button();
            this.btn_altı = new System.Windows.Forms.Button();
            this.btn_dört = new System.Windows.Forms.Button();
            this.btn_beş = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_üç);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_sonuc);
            this.panel1.Controls.Add(this.btn_topla);
            this.panel1.Controls.Add(this.btn_virgül);
            this.panel1.Controls.Add(this.btn_sıfır);
            this.panel1.Controls.Add(this.btn_cıkar);
            this.panel1.Controls.Add(this.btn_carp);
            this.panel1.Controls.Add(this.btn_bol);
            this.panel1.Controls.Add(this.btn_yedi);
            this.panel1.Controls.Add(this.btn_iki);
            this.panel1.Controls.Add(this.btn_sekiz);
            this.panel1.Controls.Add(this.btn_bir);
            this.panel1.Controls.Add(this.btn_dokuz);
            this.panel1.Controls.Add(this.btn_altı);
            this.panel1.Controls.Add(this.btn_dört);
            this.panel1.Controls.Add(this.btn_beş);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 306);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 18;
            // 
            // btn_üç
            // 
            this.btn_üç.Location = new System.Drawing.Point(101, 210);
            this.btn_üç.Name = "btn_üç";
            this.btn_üç.Size = new System.Drawing.Size(32, 31);
            this.btn_üç.TabIndex = 10;
            this.btn_üç.Text = "3";
            this.btn_üç.UseVisualStyleBackColor = true;
            this.btn_üç.Click += new System.EventHandler(this.btn_üç_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(185, 132);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(30, 72);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "c";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_sonuc
            // 
            this.btn_sonuc.Location = new System.Drawing.Point(185, 210);
            this.btn_sonuc.Name = "btn_sonuc";
            this.btn_sonuc.Size = new System.Drawing.Size(30, 72);
            this.btn_sonuc.TabIndex = 16;
            this.btn_sonuc.Text = "=";
            this.btn_sonuc.UseVisualStyleBackColor = true;
            this.btn_sonuc.Click += new System.EventHandler(this.btn_sonuc_Click);
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(139, 249);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(32, 33);
            this.btn_topla.TabIndex = 15;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // btn_virgül
            // 
            this.btn_virgül.Location = new System.Drawing.Point(101, 249);
            this.btn_virgül.Name = "btn_virgül";
            this.btn_virgül.Size = new System.Drawing.Size(32, 33);
            this.btn_virgül.TabIndex = 11;
            this.btn_virgül.Text = ",";
            this.btn_virgül.UseVisualStyleBackColor = true;
            this.btn_virgül.Click += new System.EventHandler(this.btn_virgül_Click);
            // 
            // btn_sıfır
            // 
            this.btn_sıfır.Location = new System.Drawing.Point(20, 249);
            this.btn_sıfır.Name = "btn_sıfır";
            this.btn_sıfır.Size = new System.Drawing.Size(70, 33);
            this.btn_sıfır.TabIndex = 11;
            this.btn_sıfır.Text = "0";
            this.btn_sıfır.UseVisualStyleBackColor = true;
            this.btn_sıfır.Click += new System.EventHandler(this.btn_sıfır_Click);
            // 
            // btn_cıkar
            // 
            this.btn_cıkar.Location = new System.Drawing.Point(139, 208);
            this.btn_cıkar.Name = "btn_cıkar";
            this.btn_cıkar.Size = new System.Drawing.Size(32, 33);
            this.btn_cıkar.TabIndex = 12;
            this.btn_cıkar.Text = "-";
            this.btn_cıkar.UseVisualStyleBackColor = true;
            this.btn_cıkar.Click += new System.EventHandler(this.btn_cıkar_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.Location = new System.Drawing.Point(139, 171);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(32, 33);
            this.btn_carp.TabIndex = 13;
            this.btn_carp.Text = "*";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // btn_bol
            // 
            this.btn_bol.Location = new System.Drawing.Point(139, 132);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(32, 33);
            this.btn_bol.TabIndex = 14;
            this.btn_bol.Text = "/";
            this.btn_bol.UseVisualStyleBackColor = true;
            this.btn_bol.Click += new System.EventHandler(this.btn_bol_Click);
            // 
            // btn_yedi
            // 
            this.btn_yedi.Location = new System.Drawing.Point(20, 132);
            this.btn_yedi.Name = "btn_yedi";
            this.btn_yedi.Size = new System.Drawing.Size(32, 33);
            this.btn_yedi.TabIndex = 2;
            this.btn_yedi.Text = "7";
            this.btn_yedi.UseVisualStyleBackColor = true;
            this.btn_yedi.Click += new System.EventHandler(this.btn_yedi_Click);
            // 
            // btn_iki
            // 
            this.btn_iki.Location = new System.Drawing.Point(58, 210);
            this.btn_iki.Name = "btn_iki";
            this.btn_iki.Size = new System.Drawing.Size(32, 31);
            this.btn_iki.TabIndex = 9;
            this.btn_iki.Text = "2";
            this.btn_iki.UseVisualStyleBackColor = true;
            this.btn_iki.Click += new System.EventHandler(this.btn_iki_Click);
            // 
            // btn_sekiz
            // 
            this.btn_sekiz.Location = new System.Drawing.Point(58, 132);
            this.btn_sekiz.Name = "btn_sekiz";
            this.btn_sekiz.Size = new System.Drawing.Size(32, 33);
            this.btn_sekiz.TabIndex = 3;
            this.btn_sekiz.Text = "8";
            this.btn_sekiz.UseVisualStyleBackColor = true;
            this.btn_sekiz.Click += new System.EventHandler(this.btn_sekiz_Click);
            // 
            // btn_bir
            // 
            this.btn_bir.Location = new System.Drawing.Point(20, 210);
            this.btn_bir.Name = "btn_bir";
            this.btn_bir.Size = new System.Drawing.Size(32, 31);
            this.btn_bir.TabIndex = 8;
            this.btn_bir.Text = "1";
            this.btn_bir.UseVisualStyleBackColor = true;
            this.btn_bir.Click += new System.EventHandler(this.btn_bir_Click);
            // 
            // btn_dokuz
            // 
            this.btn_dokuz.Location = new System.Drawing.Point(101, 132);
            this.btn_dokuz.Name = "btn_dokuz";
            this.btn_dokuz.Size = new System.Drawing.Size(32, 33);
            this.btn_dokuz.TabIndex = 4;
            this.btn_dokuz.Text = "9";
            this.btn_dokuz.UseVisualStyleBackColor = true;
            this.btn_dokuz.Click += new System.EventHandler(this.btn_dokuz_Click);
            // 
            // btn_altı
            // 
            this.btn_altı.Location = new System.Drawing.Point(101, 171);
            this.btn_altı.Name = "btn_altı";
            this.btn_altı.Size = new System.Drawing.Size(32, 33);
            this.btn_altı.TabIndex = 7;
            this.btn_altı.Text = "6";
            this.btn_altı.UseVisualStyleBackColor = true;
            this.btn_altı.Click += new System.EventHandler(this.btn_altı_Click);
            // 
            // btn_dört
            // 
            this.btn_dört.Location = new System.Drawing.Point(20, 171);
            this.btn_dört.Name = "btn_dört";
            this.btn_dört.Size = new System.Drawing.Size(32, 33);
            this.btn_dört.TabIndex = 5;
            this.btn_dört.Text = "4";
            this.btn_dört.UseVisualStyleBackColor = true;
            this.btn_dört.Click += new System.EventHandler(this.btn_dört_Click);
            // 
            // btn_beş
            // 
            this.btn_beş.Location = new System.Drawing.Point(58, 171);
            this.btn_beş.Name = "btn_beş";
            this.btn_beş.Size = new System.Drawing.Size(32, 33);
            this.btn_beş.TabIndex = 6;
            this.btn_beş.Text = "5";
            this.btn_beş.UseVisualStyleBackColor = true;
            this.btn_beş.Click += new System.EventHandler(this.btn_beş_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 335);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HESAP MAKİNESİ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_sonuc;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Button btn_virgül;
        private System.Windows.Forms.Button btn_sıfır;
        private System.Windows.Forms.Button btn_cıkar;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Button btn_bol;
        private System.Windows.Forms.Button btn_yedi;
        private System.Windows.Forms.Button btn_iki;
        private System.Windows.Forms.Button btn_sekiz;
        private System.Windows.Forms.Button btn_bir;
        private System.Windows.Forms.Button btn_dokuz;
        private System.Windows.Forms.Button btn_altı;
        private System.Windows.Forms.Button btn_dört;
        private System.Windows.Forms.Button btn_beş;
        private System.Windows.Forms.Button btn_üç;
        private System.Windows.Forms.TextBox textBox1;
    }
}

