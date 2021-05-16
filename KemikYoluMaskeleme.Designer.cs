namespace MaskelemeAsistanıProjesi
{
    partial class KemikYoluMaskeleme
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
            this.HertzLabel = new System.Windows.Forms.Label();
            this.Hertz = new System.Windows.Forms.Label();
            this.GürültüArtışGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add5 = new System.Windows.Forms.RadioButton();
            this.add10 = new System.Windows.Forms.RadioButton();
            this.OklüzyonGroup = new System.Windows.Forms.GroupBox();
            this.ok25 = new System.Windows.Forms.RadioButton();
            this.ok20 = new System.Windows.Forms.RadioButton();
            this.ok15 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ok10 = new System.Windows.Forms.RadioButton();
            this.ok0 = new System.Windows.Forms.RadioButton();
            this.GürültüGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startAdd15 = new System.Windows.Forms.RadioButton();
            this.startAdd10 = new System.Windows.Forms.RadioButton();
            this.eşikLabel = new System.Windows.Forms.Label();
            this.gürültüLabel = new System.Windows.Forms.Label();
            this.gürültüDeğeri = new System.Windows.Forms.Label();
            this.eşikDeğeri = new System.Windows.Forms.Label();
            this.SonucLabel = new System.Windows.Forms.Label();
            this.duymadıButton = new System.Windows.Forms.Button();
            this.duyduButton = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.MaskelemeButton = new System.Windows.Forms.Button();
            this.sayac = new System.Windows.Forms.Timer(this.components);
            this.Kapat = new System.Windows.Forms.Button();
            this.GürültüArtışGroup.SuspendLayout();
            this.OklüzyonGroup.SuspendLayout();
            this.GürültüGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // HertzLabel
            // 
            this.HertzLabel.AutoSize = true;
            this.HertzLabel.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HertzLabel.Location = new System.Drawing.Point(137, 25);
            this.HertzLabel.Name = "HertzLabel";
            this.HertzLabel.Size = new System.Drawing.Size(91, 23);
            this.HertzLabel.TabIndex = 9;
            this.HertzLabel.Text = "HERTZ :";
            this.HertzLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hertz
            // 
            this.Hertz.AutoSize = true;
            this.Hertz.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hertz.Location = new System.Drawing.Point(270, 25);
            this.Hertz.Name = "Hertz";
            this.Hertz.Size = new System.Drawing.Size(79, 23);
            this.Hertz.TabIndex = 8;
            this.Hertz.Text = "HERTZ";
            this.Hertz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GürültüArtışGroup
            // 
            this.GürültüArtışGroup.Controls.Add(this.label1);
            this.GürültüArtışGroup.Controls.Add(this.add5);
            this.GürültüArtışGroup.Controls.Add(this.add10);
            this.GürültüArtışGroup.Location = new System.Drawing.Point(27, 300);
            this.GürültüArtışGroup.Name = "GürültüArtışGroup";
            this.GürültüArtışGroup.Size = new System.Drawing.Size(263, 93);
            this.GürültüArtışGroup.TabIndex = 18;
            this.GürültüArtışGroup.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gürültünün Arttırıldığı Şiddet Miktarı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // OklüzyonGroup
            // 
            this.OklüzyonGroup.Controls.Add(this.ok25);
            this.OklüzyonGroup.Controls.Add(this.ok20);
            this.OklüzyonGroup.Controls.Add(this.ok15);
            this.OklüzyonGroup.Controls.Add(this.label2);
            this.OklüzyonGroup.Controls.Add(this.ok10);
            this.OklüzyonGroup.Controls.Add(this.ok0);
            this.OklüzyonGroup.Location = new System.Drawing.Point(31, 163);
            this.OklüzyonGroup.Name = "OklüzyonGroup";
            this.OklüzyonGroup.Size = new System.Drawing.Size(157, 131);
            this.OklüzyonGroup.TabIndex = 17;
            this.OklüzyonGroup.TabStop = false;
            // 
            // ok25
            // 
            this.ok25.AutoSize = true;
            this.ok25.Location = new System.Drawing.Point(63, 68);
            this.ok25.Name = "ok25";
            this.ok25.Size = new System.Drawing.Size(37, 17);
            this.ok25.TabIndex = 16;
            this.ok25.TabStop = true;
            this.ok25.Text = "25";
            this.ok25.UseVisualStyleBackColor = true;
            // 
            // ok20
            // 
            this.ok20.AutoSize = true;
            this.ok20.Location = new System.Drawing.Point(63, 45);
            this.ok20.Name = "ok20";
            this.ok20.Size = new System.Drawing.Size(37, 17);
            this.ok20.TabIndex = 15;
            this.ok20.TabStop = true;
            this.ok20.Text = "20";
            this.ok20.UseVisualStyleBackColor = true;
            // 
            // ok15
            // 
            this.ok15.AutoSize = true;
            this.ok15.Location = new System.Drawing.Point(11, 91);
            this.ok15.Name = "ok15";
            this.ok15.Size = new System.Drawing.Size(37, 17);
            this.ok15.TabIndex = 14;
            this.ok15.TabStop = true;
            this.ok15.Text = "15";
            this.ok15.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Oklüzyon Etkisi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok10
            // 
            this.ok10.AutoSize = true;
            this.ok10.Location = new System.Drawing.Point(10, 68);
            this.ok10.Name = "ok10";
            this.ok10.Size = new System.Drawing.Size(37, 17);
            this.ok10.TabIndex = 12;
            this.ok10.TabStop = true;
            this.ok10.Text = "10";
            this.ok10.UseVisualStyleBackColor = true;
            // 
            // ok0
            // 
            this.ok0.AutoSize = true;
            this.ok0.Location = new System.Drawing.Point(10, 45);
            this.ok0.Name = "ok0";
            this.ok0.Size = new System.Drawing.Size(31, 17);
            this.ok0.TabIndex = 11;
            this.ok0.TabStop = true;
            this.ok0.Text = "0";
            this.ok0.UseVisualStyleBackColor = true;
            // 
            // GürültüGroup
            // 
            this.GürültüGroup.Controls.Add(this.label3);
            this.GürültüGroup.Controls.Add(this.startAdd15);
            this.GürültüGroup.Controls.Add(this.startAdd10);
            this.GürültüGroup.Location = new System.Drawing.Point(31, 63);
            this.GürültüGroup.Name = "GürültüGroup";
            this.GürültüGroup.Size = new System.Drawing.Size(162, 94);
            this.GürültüGroup.TabIndex = 19;
            this.GürültüGroup.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gürültü Başlangıcı";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startAdd15
            // 
            this.startAdd15.AutoSize = true;
            this.startAdd15.Location = new System.Drawing.Point(10, 68);
            this.startAdd15.Name = "startAdd15";
            this.startAdd15.Size = new System.Drawing.Size(104, 17);
            this.startAdd15.TabIndex = 12;
            this.startAdd15.TabStop = true;
            this.startAdd15.Text = "15 dB Eklenerek";
            this.startAdd15.UseVisualStyleBackColor = true;
            // 
            // startAdd10
            // 
            this.startAdd10.AutoSize = true;
            this.startAdd10.Location = new System.Drawing.Point(10, 45);
            this.startAdd10.Name = "startAdd10";
            this.startAdd10.Size = new System.Drawing.Size(104, 17);
            this.startAdd10.TabIndex = 11;
            this.startAdd10.TabStop = true;
            this.startAdd10.Text = "10 dB Eklenerek";
            this.startAdd10.UseVisualStyleBackColor = true;
            // 
            // eşikLabel
            // 
            this.eşikLabel.AutoSize = true;
            this.eşikLabel.Location = new System.Drawing.Point(215, 85);
            this.eşikLabel.Name = "eşikLabel";
            this.eşikLabel.Size = new System.Drawing.Size(31, 13);
            this.eşikLabel.TabIndex = 21;
            this.eşikLabel.Text = "EŞİK";
            // 
            // gürültüLabel
            // 
            this.gürültüLabel.AutoSize = true;
            this.gürültüLabel.Location = new System.Drawing.Point(215, 114);
            this.gürültüLabel.Name = "gürültüLabel";
            this.gürültüLabel.Size = new System.Drawing.Size(60, 13);
            this.gürültüLabel.TabIndex = 22;
            this.gürültüLabel.Text = "GÜRÜLTÜ";
            // 
            // gürültüDeğeri
            // 
            this.gürültüDeğeri.AutoSize = true;
            this.gürültüDeğeri.Location = new System.Drawing.Point(284, 114);
            this.gürültüDeğeri.Name = "gürültüDeğeri";
            this.gürültüDeğeri.Size = new System.Drawing.Size(68, 13);
            this.gürültüDeğeri.TabIndex = 23;
            this.gürültüDeğeri.Text = "gürültüdeğeri";
            // 
            // eşikDeğeri
            // 
            this.eşikDeğeri.AutoSize = true;
            this.eşikDeğeri.Location = new System.Drawing.Point(284, 85);
            this.eşikDeğeri.Name = "eşikDeğeri";
            this.eşikDeğeri.Size = new System.Drawing.Size(55, 13);
            this.eşikDeğeri.TabIndex = 24;
            this.eşikDeğeri.Text = "eşikdeğeri";
            // 
            // SonucLabel
            // 
            this.SonucLabel.AutoSize = true;
            this.SonucLabel.Location = new System.Drawing.Point(253, 231);
            this.SonucLabel.Name = "SonucLabel";
            this.SonucLabel.Size = new System.Drawing.Size(45, 13);
            this.SonucLabel.TabIndex = 32;
            this.SonucLabel.Text = "SONUC";
            // 
            // duymadıButton
            // 
            this.duymadıButton.BackColor = System.Drawing.Color.Red;
            this.duymadıButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.duymadıButton.Location = new System.Drawing.Point(287, 176);
            this.duymadıButton.Name = "duymadıButton";
            this.duymadıButton.Size = new System.Drawing.Size(76, 34);
            this.duymadıButton.TabIndex = 27;
            this.duymadıButton.Text = "DUYMADI";
            this.duymadıButton.UseVisualStyleBackColor = false;
            this.duymadıButton.Visible = false;
            this.duymadıButton.Click += new System.EventHandler(this.duymadıButton_Click);
            // 
            // duyduButton
            // 
            this.duyduButton.BackColor = System.Drawing.Color.Lime;
            this.duyduButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.duyduButton.Location = new System.Drawing.Point(202, 176);
            this.duyduButton.Name = "duyduButton";
            this.duyduButton.Size = new System.Drawing.Size(76, 34);
            this.duyduButton.TabIndex = 26;
            this.duyduButton.Text = "DUYDU";
            this.duyduButton.UseVisualStyleBackColor = false;
            this.duyduButton.Visible = false;
            this.duyduButton.Click += new System.EventHandler(this.duyduButton_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.time.Location = new System.Drawing.Point(268, 131);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(30, 31);
            this.time.TabIndex = 25;
            this.time.Text = "5";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.time.Visible = false;
            // 
            // MaskelemeButton
            // 
            this.MaskelemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaskelemeButton.Location = new System.Drawing.Point(296, 316);
            this.MaskelemeButton.Name = "MaskelemeButton";
            this.MaskelemeButton.Size = new System.Drawing.Size(101, 63);
            this.MaskelemeButton.TabIndex = 33;
            this.MaskelemeButton.Text = "Maskeleme Başlat";
            this.MaskelemeButton.UseVisualStyleBackColor = true;
            this.MaskelemeButton.Click += new System.EventHandler(this.MaskelemeButton_Click);
            // 
            // sayac
            // 
            this.sayac.Interval = 1000;
            this.sayac.Tick += new System.EventHandler(this.sayac_Tick);
            // 
            // Kapat
            // 
            this.Kapat.Location = new System.Drawing.Point(403, 316);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(125, 63);
            this.Kapat.TabIndex = 34;
            this.Kapat.Text = "Sıradakine Geçiş --->";
            this.Kapat.UseVisualStyleBackColor = true;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // KemikYoluMaskeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 404);
            this.Controls.Add(this.Kapat);
            this.Controls.Add(this.MaskelemeButton);
            this.Controls.Add(this.SonucLabel);
            this.Controls.Add(this.duymadıButton);
            this.Controls.Add(this.duyduButton);
            this.Controls.Add(this.time);
            this.Controls.Add(this.eşikDeğeri);
            this.Controls.Add(this.gürültüDeğeri);
            this.Controls.Add(this.gürültüLabel);
            this.Controls.Add(this.eşikLabel);
            this.Controls.Add(this.GürültüGroup);
            this.Controls.Add(this.GürültüArtışGroup);
            this.Controls.Add(this.OklüzyonGroup);
            this.Controls.Add(this.HertzLabel);
            this.Controls.Add(this.Hertz);
            this.Name = "KemikYoluMaskeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KemikYoluMaskeleme";
            this.Load += new System.EventHandler(this.KemikYoluMaskeleme_Load);
            this.GürültüArtışGroup.ResumeLayout(false);
            this.GürültüArtışGroup.PerformLayout();
            this.OklüzyonGroup.ResumeLayout(false);
            this.OklüzyonGroup.PerformLayout();
            this.GürültüGroup.ResumeLayout(false);
            this.GürültüGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label HertzLabel;
        public System.Windows.Forms.Label Hertz;
        private System.Windows.Forms.GroupBox GürültüArtışGroup;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton add5;
        private System.Windows.Forms.RadioButton add10;
        private System.Windows.Forms.GroupBox OklüzyonGroup;
        private System.Windows.Forms.RadioButton ok25;
        private System.Windows.Forms.RadioButton ok20;
        private System.Windows.Forms.RadioButton ok15;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ok10;
        private System.Windows.Forms.RadioButton ok0;
        private System.Windows.Forms.GroupBox GürültüGroup;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton startAdd15;
        private System.Windows.Forms.RadioButton startAdd10;
        private System.Windows.Forms.Label eşikLabel;
        private System.Windows.Forms.Label gürültüLabel;
        private System.Windows.Forms.Label gürültüDeğeri;
        private System.Windows.Forms.Label eşikDeğeri;
        private System.Windows.Forms.Label SonucLabel;
        private System.Windows.Forms.Button duymadıButton;
        private System.Windows.Forms.Button duyduButton;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button MaskelemeButton;
        private System.Windows.Forms.Timer sayac;
        private System.Windows.Forms.Button Kapat;
    }
}