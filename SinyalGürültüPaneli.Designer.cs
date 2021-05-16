namespace MaskelemeAsistanıProjesi
{
    partial class SinyalGürültüPaneli
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
            this.components = new System.ComponentModel.Container();
            this.Hertz = new System.Windows.Forms.Label();
            this.HertzLabel = new System.Windows.Forms.Label();
            this.Kapat = new System.Windows.Forms.Button();
            this.kötüKulakLabel = new System.Windows.Forms.Label();
            this.kötüKulak = new System.Windows.Forms.Label();
            this.iyiKulakLabel = new System.Windows.Forms.Label();
            this.iyiKulak = new System.Windows.Forms.Label();
            this.add5 = new System.Windows.Forms.RadioButton();
            this.add10 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startadd15 = new System.Windows.Forms.RadioButton();
            this.startadd10 = new System.Windows.Forms.RadioButton();
            this.MaskelemeButton = new System.Windows.Forms.Button();
            this.sayac = new System.Windows.Forms.Timer(this.components);
            this.GürültüBaslangıc = new System.Windows.Forms.GroupBox();
            this.GürültüArtış = new System.Windows.Forms.GroupBox();
            this.time = new System.Windows.Forms.Label();
            this.duyduButton = new System.Windows.Forms.Button();
            this.duymadıButton = new System.Windows.Forms.Button();
            this.eşikLabel = new System.Windows.Forms.Label();
            this.gürültüLabel = new System.Windows.Forms.Label();
            this.mevcutGürültü = new System.Windows.Forms.Label();
            this.mevcutEşik = new System.Windows.Forms.Label();
            this.SonucLabel = new System.Windows.Forms.Label();
            this.GürültüBaslangıc.SuspendLayout();
            this.GürültüArtış.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hertz
            // 
            this.Hertz.AutoSize = true;
            this.Hertz.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hertz.Location = new System.Drawing.Point(260, 9);
            this.Hertz.Name = "Hertz";
            this.Hertz.Size = new System.Drawing.Size(79, 23);
            this.Hertz.TabIndex = 0;
            this.Hertz.Text = "HERTZ";
            this.Hertz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HertzLabel
            // 
            this.HertzLabel.AutoSize = true;
            this.HertzLabel.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HertzLabel.Location = new System.Drawing.Point(127, 9);
            this.HertzLabel.Name = "HertzLabel";
            this.HertzLabel.Size = new System.Drawing.Size(91, 23);
            this.HertzLabel.TabIndex = 2;
            this.HertzLabel.Text = "HERTZ :";
            this.HertzLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kapat
            // 
            this.Kapat.Location = new System.Drawing.Point(433, 346);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(125, 43);
            this.Kapat.TabIndex = 3;
            this.Kapat.Text = "Sıradakine Geçiş --->";
            this.Kapat.UseVisualStyleBackColor = true;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // kötüKulakLabel
            // 
            this.kötüKulakLabel.AutoSize = true;
            this.kötüKulakLabel.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kötüKulakLabel.Location = new System.Drawing.Point(127, 46);
            this.kötüKulakLabel.Name = "kötüKulakLabel";
            this.kötüKulakLabel.Size = new System.Drawing.Size(127, 23);
            this.kötüKulakLabel.TabIndex = 5;
            this.kötüKulakLabel.Text = "Kötü Kulak:";
            this.kötüKulakLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kötüKulak
            // 
            this.kötüKulak.AutoSize = true;
            this.kötüKulak.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kötüKulak.Location = new System.Drawing.Point(260, 46);
            this.kötüKulak.Name = "kötüKulak";
            this.kötüKulak.Size = new System.Drawing.Size(111, 23);
            this.kötüKulak.TabIndex = 4;
            this.kötüKulak.Text = "kötükulak";
            this.kötüKulak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iyiKulakLabel
            // 
            this.iyiKulakLabel.AutoSize = true;
            this.iyiKulakLabel.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iyiKulakLabel.Location = new System.Drawing.Point(127, 84);
            this.iyiKulakLabel.Name = "iyiKulakLabel";
            this.iyiKulakLabel.Size = new System.Drawing.Size(105, 23);
            this.iyiKulakLabel.TabIndex = 7;
            this.iyiKulakLabel.Text = "Iyi Kulak:";
            this.iyiKulakLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iyiKulak
            // 
            this.iyiKulak.AutoSize = true;
            this.iyiKulak.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iyiKulak.Location = new System.Drawing.Point(260, 84);
            this.iyiKulak.Name = "iyiKulak";
            this.iyiKulak.Size = new System.Drawing.Size(91, 23);
            this.iyiKulak.TabIndex = 6;
            this.iyiKulak.Text = "iyikulak";
            this.iyiKulak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add5
            // 
            this.add5.AutoSize = true;
            this.add5.Location = new System.Drawing.Point(54, 42);
            this.add5.Name = "add5";
            this.add5.Size = new System.Drawing.Size(53, 17);
            this.add5.TabIndex = 8;
            this.add5.TabStop = true;
            this.add5.Text = "+5 dB";
            this.add5.UseVisualStyleBackColor = true;
            // 
            // add10
            // 
            this.add10.AutoSize = true;
            this.add10.Location = new System.Drawing.Point(54, 64);
            this.add10.Name = "add10";
            this.add10.Size = new System.Drawing.Size(59, 17);
            this.add10.TabIndex = 9;
            this.add10.TabStop = true;
            this.add10.Text = "+10 dB";
            this.add10.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gürültünün Arttırıldığı Şiddet Miktarı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Gürültü Başlangıcı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startadd15
            // 
            this.startadd15.AutoSize = true;
            this.startadd15.Location = new System.Drawing.Point(55, 68);
            this.startadd15.Name = "startadd15";
            this.startadd15.Size = new System.Drawing.Size(104, 17);
            this.startadd15.TabIndex = 12;
            this.startadd15.TabStop = true;
            this.startadd15.Text = "15 dB Eklenerek";
            this.startadd15.UseVisualStyleBackColor = true;
            // 
            // startadd10
            // 
            this.startadd10.AutoSize = true;
            this.startadd10.Location = new System.Drawing.Point(55, 45);
            this.startadd10.Name = "startadd10";
            this.startadd10.Size = new System.Drawing.Size(104, 17);
            this.startadd10.TabIndex = 11;
            this.startadd10.TabStop = true;
            this.startadd10.Text = "10 dB Eklenerek";
            this.startadd10.UseVisualStyleBackColor = true;
            // 
            // MaskelemeButton
            // 
            this.MaskelemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaskelemeButton.Location = new System.Drawing.Point(95, 320);
            this.MaskelemeButton.Name = "MaskelemeButton";
            this.MaskelemeButton.Size = new System.Drawing.Size(101, 63);
            this.MaskelemeButton.TabIndex = 14;
            this.MaskelemeButton.Text = "Maskeleme Başlat";
            this.MaskelemeButton.UseVisualStyleBackColor = true;
            this.MaskelemeButton.Click += new System.EventHandler(this.MaskelemeButton_Click);
            // 
            // sayac
            // 
            this.sayac.Tick += new System.EventHandler(this.sayac_Tick);
            // 
            // GürültüBaslangıc
            // 
            this.GürültüBaslangıc.Controls.Add(this.label2);
            this.GürültüBaslangıc.Controls.Add(this.startadd15);
            this.GürültüBaslangıc.Controls.Add(this.startadd10);
            this.GürültüBaslangıc.Location = new System.Drawing.Point(11, 121);
            this.GürültüBaslangıc.Name = "GürültüBaslangıc";
            this.GürültüBaslangıc.Size = new System.Drawing.Size(264, 94);
            this.GürültüBaslangıc.TabIndex = 15;
            this.GürültüBaslangıc.TabStop = false;
            // 
            // GürültüArtış
            // 
            this.GürültüArtış.Controls.Add(this.label1);
            this.GürültüArtış.Controls.Add(this.add5);
            this.GürültüArtış.Controls.Add(this.add10);
            this.GürültüArtış.Location = new System.Drawing.Point(12, 221);
            this.GürültüArtış.Name = "GürültüArtış";
            this.GürültüArtış.Size = new System.Drawing.Size(263, 93);
            this.GürültüArtış.TabIndex = 16;
            this.GürültüArtış.TabStop = false;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.time.Location = new System.Drawing.Point(384, 176);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(30, 31);
            this.time.TabIndex = 17;
            this.time.Text = "5";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.time.Visible = false;
            // 
            // duyduButton
            // 
            this.duyduButton.BackColor = System.Drawing.Color.Lime;
            this.duyduButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.duyduButton.Location = new System.Drawing.Point(318, 221);
            this.duyduButton.Name = "duyduButton";
            this.duyduButton.Size = new System.Drawing.Size(76, 34);
            this.duyduButton.TabIndex = 18;
            this.duyduButton.Text = "DUYDU";
            this.duyduButton.UseVisualStyleBackColor = false;
            this.duyduButton.Visible = false;
            this.duyduButton.Click += new System.EventHandler(this.duyduButton_Click);
            // 
            // duymadıButton
            // 
            this.duymadıButton.BackColor = System.Drawing.Color.Red;
            this.duymadıButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.duymadıButton.Location = new System.Drawing.Point(403, 221);
            this.duymadıButton.Name = "duymadıButton";
            this.duymadıButton.Size = new System.Drawing.Size(76, 34);
            this.duymadıButton.TabIndex = 19;
            this.duymadıButton.Text = "DUYMADI";
            this.duymadıButton.UseVisualStyleBackColor = false;
            this.duymadıButton.Visible = false;
            this.duymadıButton.Click += new System.EventHandler(this.duymadıButton_Click);
            // 
            // eşikLabel
            // 
            this.eşikLabel.AutoSize = true;
            this.eşikLabel.Location = new System.Drawing.Point(315, 263);
            this.eşikLabel.Name = "eşikLabel";
            this.eşikLabel.Size = new System.Drawing.Size(82, 13);
            this.eşikLabel.TabIndex = 20;
            this.eşikLabel.Text = "MEVCUT EŞİK:";
            // 
            // gürültüLabel
            // 
            this.gürültüLabel.AutoSize = true;
            this.gürültüLabel.Location = new System.Drawing.Point(315, 287);
            this.gürültüLabel.Name = "gürültüLabel";
            this.gürültüLabel.Size = new System.Drawing.Size(111, 13);
            this.gürültüLabel.TabIndex = 21;
            this.gürültüLabel.Text = "MEVCUT GÜRÜLTÜ:";
            // 
            // mevcutGürültü
            // 
            this.mevcutGürültü.AutoSize = true;
            this.mevcutGürültü.Location = new System.Drawing.Point(432, 289);
            this.mevcutGürültü.Name = "mevcutGürültü";
            this.mevcutGürültü.Size = new System.Drawing.Size(13, 13);
            this.mevcutGürültü.TabIndex = 23;
            this.mevcutGürültü.Text = "0";
            // 
            // mevcutEşik
            // 
            this.mevcutEşik.AutoSize = true;
            this.mevcutEşik.Location = new System.Drawing.Point(432, 263);
            this.mevcutEşik.Name = "mevcutEşik";
            this.mevcutEşik.Size = new System.Drawing.Size(13, 13);
            this.mevcutEşik.TabIndex = 22;
            this.mevcutEşik.Text = "0";
            // 
            // SonucLabel
            // 
            this.SonucLabel.AutoSize = true;
            this.SonucLabel.Location = new System.Drawing.Point(358, 320);
            this.SonucLabel.Name = "SonucLabel";
            this.SonucLabel.Size = new System.Drawing.Size(45, 13);
            this.SonucLabel.TabIndex = 24;
            this.SonucLabel.Text = "SONUC";
            // 
            // SinyalGürültüPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 404);
            this.Controls.Add(this.SonucLabel);
            this.Controls.Add(this.mevcutGürültü);
            this.Controls.Add(this.mevcutEşik);
            this.Controls.Add(this.gürültüLabel);
            this.Controls.Add(this.eşikLabel);
            this.Controls.Add(this.duymadıButton);
            this.Controls.Add(this.duyduButton);
            this.Controls.Add(this.time);
            this.Controls.Add(this.GürültüArtış);
            this.Controls.Add(this.GürültüBaslangıc);
            this.Controls.Add(this.MaskelemeButton);
            this.Controls.Add(this.iyiKulakLabel);
            this.Controls.Add(this.iyiKulak);
            this.Controls.Add(this.kötüKulakLabel);
            this.Controls.Add(this.kötüKulak);
            this.Controls.Add(this.Kapat);
            this.Controls.Add(this.HertzLabel);
            this.Controls.Add(this.Hertz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SinyalGürültüPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SinyalGürültüPaneli";
            this.Load += new System.EventHandler(this.SinyalGürültüPaneli_Load);
            this.GürültüBaslangıc.ResumeLayout(false);
            this.GürültüBaslangıc.PerformLayout();
            this.GürültüArtış.ResumeLayout(false);
            this.GürültüArtış.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Hertz;
        public System.Windows.Forms.Label HertzLabel;
        private System.Windows.Forms.Button Kapat;
        public System.Windows.Forms.Label kötüKulakLabel;
        public System.Windows.Forms.Label kötüKulak;
        public System.Windows.Forms.Label iyiKulakLabel;
        public System.Windows.Forms.Label iyiKulak;
        private System.Windows.Forms.RadioButton add5;
        private System.Windows.Forms.RadioButton add10;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton startadd15;
        private System.Windows.Forms.RadioButton startadd10;
        private System.Windows.Forms.Button MaskelemeButton;
        private System.Windows.Forms.Timer sayac;
        private System.Windows.Forms.GroupBox GürültüBaslangıc;
        private System.Windows.Forms.GroupBox GürültüArtış;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button duyduButton;
        private System.Windows.Forms.Button duymadıButton;
        private System.Windows.Forms.Label eşikLabel;
        private System.Windows.Forms.Label gürültüLabel;
        private System.Windows.Forms.Label mevcutGürültü;
        private System.Windows.Forms.Label mevcutEşik;
        private System.Windows.Forms.Label SonucLabel;
    }
}