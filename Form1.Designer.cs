namespace MaskelemeAsistanıProjesi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Kontrol = new System.Windows.Forms.Button();
            this.timer250 = new System.Windows.Forms.Timer(this.components);
            this.timer500 = new System.Windows.Forms.Timer(this.components);
            this.timer1000 = new System.Windows.Forms.Timer(this.components);
            this.timer2000 = new System.Windows.Forms.Timer(this.components);
            this.timer4000 = new System.Windows.Forms.Timer(this.components);
            this.timer6000 = new System.Windows.Forms.Timer(this.components);
            this.timer8000 = new System.Windows.Forms.Timer(this.components);
            this.HavaControlTimer = new System.Windows.Forms.Timer(this.components);
            this.timerkemik250 = new System.Windows.Forms.Timer(this.components);
            this.timerkemik500 = new System.Windows.Forms.Timer(this.components);
            this.timerkemik1000 = new System.Windows.Forms.Timer(this.components);
            this.timerkemik2000 = new System.Windows.Forms.Timer(this.components);
            this.timerkemik4000 = new System.Windows.Forms.Timer(this.components);
            this.loading = new System.Windows.Forms.Label();
            this.KemikControlTimer = new System.Windows.Forms.Timer(this.components);
            this.hsag1 = new System.Windows.Forms.ComboBox();
            this.ksag1 = new System.Windows.Forms.ComboBox();
            this.hsag2 = new System.Windows.Forms.ComboBox();
            this.hsag3 = new System.Windows.Forms.ComboBox();
            this.hsag4 = new System.Windows.Forms.ComboBox();
            this.hsag5 = new System.Windows.Forms.ComboBox();
            this.hsag6 = new System.Windows.Forms.ComboBox();
            this.hsag7 = new System.Windows.Forms.ComboBox();
            this.hsol7 = new System.Windows.Forms.ComboBox();
            this.hsol6 = new System.Windows.Forms.ComboBox();
            this.hsol5 = new System.Windows.Forms.ComboBox();
            this.hsol4 = new System.Windows.Forms.ComboBox();
            this.hsol3 = new System.Windows.Forms.ComboBox();
            this.hsol2 = new System.Windows.Forms.ComboBox();
            this.hsol1 = new System.Windows.Forms.ComboBox();
            this.ksag2 = new System.Windows.Forms.ComboBox();
            this.ksag3 = new System.Windows.Forms.ComboBox();
            this.ksag4 = new System.Windows.Forms.ComboBox();
            this.ksag5 = new System.Windows.Forms.ComboBox();
            this.ksol5 = new System.Windows.Forms.ComboBox();
            this.ksol4 = new System.Windows.Forms.ComboBox();
            this.ksol3 = new System.Windows.Forms.ComboBox();
            this.ksol2 = new System.Windows.Forms.ComboBox();
            this.ksol1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(114, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "HAVA YOLU(SAG)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(114, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "HAVA YOLU(SOL)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(114, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "KEMIK YOLU(SOL)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(114, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "KEMIK YOLU(SAG)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(112, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Durum/Frekans";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(247, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = " 250Hz ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(317, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = " 500Hz ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(383, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "1000Hz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(451, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 36;
            this.label9.Text = "2000Hz ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(516, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 37;
            this.label10.Text = " 4000Hz ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(588, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 38;
            this.label11.Text = "6000Hz ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(649, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 39;
            this.label12.Text = " 8000Hz ";
            // 
            // Kontrol
            // 
            this.Kontrol.BackColor = System.Drawing.Color.Gray;
            this.Kontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kontrol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Kontrol.Location = new System.Drawing.Point(364, 314);
            this.Kontrol.Name = "Kontrol";
            this.Kontrol.Size = new System.Drawing.Size(105, 33);
            this.Kontrol.TabIndex = 41;
            this.Kontrol.Text = "KONTROL";
            this.Kontrol.UseVisualStyleBackColor = false;
            this.Kontrol.Click += new System.EventHandler(this.Kontrol_Click);
            // 
            // timer250
            // 
            this.timer250.Interval = 350;
            this.timer250.Tick += new System.EventHandler(this.timer250_Tick);
            // 
            // timer500
            // 
            this.timer500.Interval = 350;
            this.timer500.Tick += new System.EventHandler(this.timer500_Tick);
            // 
            // timer1000
            // 
            this.timer1000.Interval = 350;
            this.timer1000.Tick += new System.EventHandler(this.timer1000_Tick);
            // 
            // timer2000
            // 
            this.timer2000.Interval = 350;
            this.timer2000.Tick += new System.EventHandler(this.timer2000_Tick);
            // 
            // timer4000
            // 
            this.timer4000.Interval = 350;
            this.timer4000.Tick += new System.EventHandler(this.timer4000_Tick);
            // 
            // timer6000
            // 
            this.timer6000.Interval = 350;
            this.timer6000.Tick += new System.EventHandler(this.timer6000_Tick);
            // 
            // timer8000
            // 
            this.timer8000.Interval = 350;
            this.timer8000.Tick += new System.EventHandler(this.timer8000_Tick);
            // 
            // HavaControlTimer
            // 
            this.HavaControlTimer.Tick += new System.EventHandler(this.HavaKontrolTimer_Tick);
            // 
            // timerkemik250
            // 
            this.timerkemik250.Interval = 350;
            this.timerkemik250.Tick += new System.EventHandler(this.timerkemik250_Tick);
            // 
            // timerkemik500
            // 
            this.timerkemik500.Interval = 350;
            this.timerkemik500.Tick += new System.EventHandler(this.timerkemik500_Tick);
            // 
            // timerkemik1000
            // 
            this.timerkemik1000.Interval = 350;
            this.timerkemik1000.Tick += new System.EventHandler(this.timerkemik1000_Tick);
            // 
            // timerkemik2000
            // 
            this.timerkemik2000.Interval = 350;
            this.timerkemik2000.Tick += new System.EventHandler(this.timerkemik2000_Tick);
            // 
            // timerkemik4000
            // 
            this.timerkemik4000.Interval = 350;
            this.timerkemik4000.Tick += new System.EventHandler(this.timerkemik4000_Tick);
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loading.Location = new System.Drawing.Point(383, 286);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(0, 18);
            this.loading.TabIndex = 42;
            // 
            // KemikControlTimer
            // 
            this.KemikControlTimer.Tick += new System.EventHandler(this.KemikControlTimer_Tick);
            // 
            // hsag1
            // 
            this.hsag1.FormattingEnabled = true;
            this.hsag1.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "105",
            "110",
            "115",
            "120"});
            this.hsag1.Location = new System.Drawing.Point(247, 123);
            this.hsag1.Name = "hsag1";
            this.hsag1.Size = new System.Drawing.Size(64, 21);
            this.hsag1.TabIndex = 43;
            this.hsag1.Text = "-";
            // 
            // ksag1
            // 
            this.ksag1.FormattingEnabled = true;
            this.ksag1.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75"});
            this.ksag1.Location = new System.Drawing.Point(247, 195);
            this.ksag1.Name = "ksag1";
            this.ksag1.Size = new System.Drawing.Size(64, 21);
            this.ksag1.TabIndex = 44;
            this.ksag1.Text = "-";
            // 
            // hsag2
            // 
            this.hsag2.FormattingEnabled = true;
            this.hsag2.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "105",
            "110",
            "115",
            "120"});
            this.hsag2.Location = new System.Drawing.Point(314, 123);
            this.hsag2.Name = "hsag2";
            this.hsag2.Size = new System.Drawing.Size(64, 21);
            this.hsag2.TabIndex = 45;
            this.hsag2.Text = "-";
            // 
            // hsag3
            // 
            this.hsag3.FormattingEnabled = true;
            this.hsag3.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "105",
            "110",
            "115",
            "120"});
            this.hsag3.Location = new System.Drawing.Point(381, 123);
            this.hsag3.Name = "hsag3";
            this.hsag3.Size = new System.Drawing.Size(64, 21);
            this.hsag3.TabIndex = 46;
            this.hsag3.Text = "-";
            // 
            // hsag4
            // 
            this.hsag4.FormattingEnabled = true;
            this.hsag4.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "105",
            "110",
            "115",
            "120"});
            this.hsag4.Location = new System.Drawing.Point(451, 123);
            this.hsag4.Name = "hsag4";
            this.hsag4.Size = new System.Drawing.Size(64, 21);
            this.hsag4.TabIndex = 47;
            this.hsag4.Text = "-";
            // 
            // hsag5
            // 
            this.hsag5.FormattingEnabled = true;
            this.hsag5.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "105",
            "110",
            "115",
            "120"});
            this.hsag5.Location = new System.Drawing.Point(516, 123);
            this.hsag5.Name = "hsag5";
            this.hsag5.Size = new System.Drawing.Size(64, 21);
            this.hsag5.TabIndex = 48;
            this.hsag5.Text = "-";
            // 
            // hsag6
            // 
            this.hsag6.FormattingEnabled = true;
            this.hsag6.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "105",
            "110",
            "115",
            "120"});
            this.hsag6.Location = new System.Drawing.Point(586, 123);
            this.hsag6.Name = "hsag6";
            this.hsag6.Size = new System.Drawing.Size(64, 21);
            this.hsag6.TabIndex = 49;
            this.hsag6.Text = "-";
            // 
            // hsag7
            // 
            this.hsag7.FormattingEnabled = true;
            this.hsag7.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "105",
            "110",
            "115",
            "120"});
            this.hsag7.Location = new System.Drawing.Point(651, 123);
            this.hsag7.Name = "hsag7";
            this.hsag7.Size = new System.Drawing.Size(64, 21);
            this.hsag7.TabIndex = 50;
            this.hsag7.Text = "-";
            // 
            // hsol7
            // 
            this.hsol7.FormattingEnabled = true;
            this.hsol7.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "105",
            "110",
            "115",
            "120"});
            this.hsol7.Location = new System.Drawing.Point(651, 157);
            this.hsol7.Name = "hsol7";
            this.hsol7.Size = new System.Drawing.Size(64, 21);
            this.hsol7.TabIndex = 57;
            this.hsol7.Text = "-";
            // 
            // hsol6
            // 
            this.hsol6.FormattingEnabled = true;
            this.hsol6.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "105",
            "110",
            "115",
            "120"});
            this.hsol6.Location = new System.Drawing.Point(586, 157);
            this.hsol6.Name = "hsol6";
            this.hsol6.Size = new System.Drawing.Size(64, 21);
            this.hsol6.TabIndex = 56;
            this.hsol6.Text = "-";
            // 
            // hsol5
            // 
            this.hsol5.FormattingEnabled = true;
            this.hsol5.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "105",
            "110",
            "115",
            "120"});
            this.hsol5.Location = new System.Drawing.Point(516, 157);
            this.hsol5.Name = "hsol5";
            this.hsol5.Size = new System.Drawing.Size(64, 21);
            this.hsol5.TabIndex = 55;
            this.hsol5.Text = "-";
            // 
            // hsol4
            // 
            this.hsol4.FormattingEnabled = true;
            this.hsol4.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "105",
            "110",
            "115",
            "120"});
            this.hsol4.Location = new System.Drawing.Point(451, 157);
            this.hsol4.Name = "hsol4";
            this.hsol4.Size = new System.Drawing.Size(64, 21);
            this.hsol4.TabIndex = 54;
            this.hsol4.Text = "-";
            // 
            // hsol3
            // 
            this.hsol3.FormattingEnabled = true;
            this.hsol3.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "105",
            "110",
            "115",
            "120"});
            this.hsol3.Location = new System.Drawing.Point(381, 157);
            this.hsol3.Name = "hsol3";
            this.hsol3.Size = new System.Drawing.Size(64, 21);
            this.hsol3.TabIndex = 53;
            this.hsol3.Text = "-";
            // 
            // hsol2
            // 
            this.hsol2.FormattingEnabled = true;
            this.hsol2.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "105",
            "110",
            "115",
            "120"});
            this.hsol2.Location = new System.Drawing.Point(314, 157);
            this.hsol2.Name = "hsol2";
            this.hsol2.Size = new System.Drawing.Size(64, 21);
            this.hsol2.TabIndex = 52;
            this.hsol2.Text = "-";
            // 
            // hsol1
            // 
            this.hsol1.FormattingEnabled = true;
            this.hsol1.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "105",
            "110",
            "115",
            "120"});
            this.hsol1.Location = new System.Drawing.Point(247, 157);
            this.hsol1.Name = "hsol1";
            this.hsol1.Size = new System.Drawing.Size(64, 21);
            this.hsol1.TabIndex = 51;
            this.hsol1.Text = "-";
            // 
            // ksag2
            // 
            this.ksag2.FormattingEnabled = true;
            this.ksag2.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75"});
            this.ksag2.Location = new System.Drawing.Point(314, 195);
            this.ksag2.Name = "ksag2";
            this.ksag2.Size = new System.Drawing.Size(64, 21);
            this.ksag2.TabIndex = 58;
            this.ksag2.Text = "-";
            // 
            // ksag3
            // 
            this.ksag3.FormattingEnabled = true;
            this.ksag3.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75"});
            this.ksag3.Location = new System.Drawing.Point(381, 195);
            this.ksag3.Name = "ksag3";
            this.ksag3.Size = new System.Drawing.Size(64, 21);
            this.ksag3.TabIndex = 59;
            this.ksag3.Text = "-";
            // 
            // ksag4
            // 
            this.ksag4.FormattingEnabled = true;
            this.ksag4.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75"});
            this.ksag4.Location = new System.Drawing.Point(451, 195);
            this.ksag4.Name = "ksag4";
            this.ksag4.Size = new System.Drawing.Size(64, 21);
            this.ksag4.TabIndex = 60;
            this.ksag4.Text = "-";
            // 
            // ksag5
            // 
            this.ksag5.FormattingEnabled = true;
            this.ksag5.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75"});
            this.ksag5.Location = new System.Drawing.Point(516, 195);
            this.ksag5.Name = "ksag5";
            this.ksag5.Size = new System.Drawing.Size(64, 21);
            this.ksag5.TabIndex = 61;
            this.ksag5.Text = "-";
            // 
            // ksol5
            // 
            this.ksol5.FormattingEnabled = true;
            this.ksol5.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75"});
            this.ksol5.Location = new System.Drawing.Point(516, 230);
            this.ksol5.Name = "ksol5";
            this.ksol5.Size = new System.Drawing.Size(64, 21);
            this.ksol5.TabIndex = 66;
            this.ksol5.Text = "-";
            // 
            // ksol4
            // 
            this.ksol4.FormattingEnabled = true;
            this.ksol4.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75"});
            this.ksol4.Location = new System.Drawing.Point(451, 230);
            this.ksol4.Name = "ksol4";
            this.ksol4.Size = new System.Drawing.Size(64, 21);
            this.ksol4.TabIndex = 65;
            this.ksol4.Text = "-";
            // 
            // ksol3
            // 
            this.ksol3.FormattingEnabled = true;
            this.ksol3.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75"});
            this.ksol3.Location = new System.Drawing.Point(381, 230);
            this.ksol3.Name = "ksol3";
            this.ksol3.Size = new System.Drawing.Size(64, 21);
            this.ksol3.TabIndex = 64;
            this.ksol3.Text = "-";
            // 
            // ksol2
            // 
            this.ksol2.FormattingEnabled = true;
            this.ksol2.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75"});
            this.ksol2.Location = new System.Drawing.Point(314, 230);
            this.ksol2.Name = "ksol2";
            this.ksol2.Size = new System.Drawing.Size(64, 21);
            this.ksol2.TabIndex = 63;
            this.ksol2.Text = "-";
            // 
            // ksol1
            // 
            this.ksol1.FormattingEnabled = true;
            this.ksol1.Items.AddRange(new object[] {
            "-",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75"});
            this.ksol1.Location = new System.Drawing.Point(247, 230);
            this.ksol1.Name = "ksol1";
            this.ksol1.Size = new System.Drawing.Size(64, 21);
            this.ksol1.TabIndex = 62;
            this.ksol1.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ksol5);
            this.Controls.Add(this.ksol4);
            this.Controls.Add(this.ksol3);
            this.Controls.Add(this.ksol2);
            this.Controls.Add(this.ksol1);
            this.Controls.Add(this.ksag5);
            this.Controls.Add(this.ksag4);
            this.Controls.Add(this.ksag3);
            this.Controls.Add(this.ksag2);
            this.Controls.Add(this.hsol7);
            this.Controls.Add(this.hsol6);
            this.Controls.Add(this.hsol5);
            this.Controls.Add(this.hsol4);
            this.Controls.Add(this.hsol3);
            this.Controls.Add(this.hsol2);
            this.Controls.Add(this.hsol1);
            this.Controls.Add(this.hsag7);
            this.Controls.Add(this.hsag6);
            this.Controls.Add(this.hsag5);
            this.Controls.Add(this.hsag4);
            this.Controls.Add(this.hsag3);
            this.Controls.Add(this.hsag2);
            this.Controls.Add(this.ksag1);
            this.Controls.Add(this.hsag1);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.Kontrol);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Kontrol;
        public System.Windows.Forms.Timer timer250;
        public System.Windows.Forms.Timer timer500;
        public System.Windows.Forms.Timer timer1000;
        public System.Windows.Forms.Timer timer2000;
        public System.Windows.Forms.Timer timer4000;
        public System.Windows.Forms.Timer timer6000;
        public System.Windows.Forms.Timer timer8000;
        public System.Windows.Forms.Timer HavaControlTimer;
        public System.Windows.Forms.Timer timerkemik250;
        public System.Windows.Forms.Timer timerkemik500;
        public System.Windows.Forms.Timer timerkemik1000;
        public System.Windows.Forms.Timer timerkemik2000;
        public System.Windows.Forms.Timer timerkemik4000;
        public System.Windows.Forms.Timer KemikControlTimer;
        public System.Windows.Forms.Label loading;
        private System.Windows.Forms.ComboBox hsag1;
        private System.Windows.Forms.ComboBox ksag1;
        private System.Windows.Forms.ComboBox hsag2;
        private System.Windows.Forms.ComboBox hsag3;
        private System.Windows.Forms.ComboBox hsag4;
        private System.Windows.Forms.ComboBox hsag5;
        private System.Windows.Forms.ComboBox hsag6;
        private System.Windows.Forms.ComboBox hsag7;
        private System.Windows.Forms.ComboBox hsol7;
        private System.Windows.Forms.ComboBox hsol6;
        private System.Windows.Forms.ComboBox hsol5;
        private System.Windows.Forms.ComboBox hsol4;
        private System.Windows.Forms.ComboBox hsol3;
        private System.Windows.Forms.ComboBox hsol2;
        private System.Windows.Forms.ComboBox hsol1;
        private System.Windows.Forms.ComboBox ksag2;
        private System.Windows.Forms.ComboBox ksag3;
        private System.Windows.Forms.ComboBox ksag4;
        private System.Windows.Forms.ComboBox ksag5;
        private System.Windows.Forms.ComboBox ksol5;
        private System.Windows.Forms.ComboBox ksol4;
        private System.Windows.Forms.ComboBox ksol3;
        private System.Windows.Forms.ComboBox ksol2;
        private System.Windows.Forms.ComboBox ksol1;
    }
}

