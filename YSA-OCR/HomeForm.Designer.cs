namespace YSA_OCR
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel_giriş = new System.Windows.Forms.Panel();
            this.groupBox_giriş = new System.Windows.Forms.GroupBox();
            this.checkBox_cizgi = new System.Windows.Forms.CheckBox();
            this.button_sıfırla = new System.Windows.Forms.Button();
            this.button_eğit = new System.Windows.Forms.Button();
            this.groupBox_eğitim = new System.Windows.Forms.GroupBox();
            this.checkBox_epoch = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_epoch = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_goal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button_tahminet = new System.Windows.Forms.Button();
            this.label_hataoranı = new System.Windows.Forms.Label();
            this.comboBox_harf = new System.Windows.Forms.ComboBox();
            this.groupBox_tanımlama = new System.Windows.Forms.GroupBox();
            this.checkBox_otoyükle = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_harfseç = new System.Windows.Forms.Button();
            this.linkLabel_restart = new System.Windows.Forms.LinkLabel();
            this.groupBox_baslangıc = new System.Windows.Forms.GroupBox();
            this.numericUpDown_alfa = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_lamda = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_nöronsayısı = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ağoluştur = new System.Windows.Forms.Button();
            this.groupBox_sonuçlar = new System.Windows.Forms.GroupBox();
            this.label_çıkışE = new System.Windows.Forms.Label();
            this.label_result_e = new System.Windows.Forms.Label();
            this.label_çıkışC = new System.Windows.Forms.Label();
            this.label_result_c = new System.Windows.Forms.Label();
            this.label_çıkışD = new System.Windows.Forms.Label();
            this.label_result_d = new System.Windows.Forms.Label();
            this.label_çıkışB = new System.Windows.Forms.Label();
            this.label_result_b = new System.Windows.Forms.Label();
            this.label_çıkışA = new System.Windows.Forms.Label();
            this.label_result_a = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_giriş.SuspendLayout();
            this.groupBox_eğitim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_epoch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_goal)).BeginInit();
            this.groupBox_tanımlama.SuspendLayout();
            this.groupBox_baslangıc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_alfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lamda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nöronsayısı)).BeginInit();
            this.groupBox_sonuçlar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_giriş
            // 
            this.panel_giriş.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_giriş.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_giriş.Location = new System.Drawing.Point(12, 19);
            this.panel_giriş.Name = "panel_giriş";
            this.panel_giriş.Size = new System.Drawing.Size(156, 218);
            this.panel_giriş.TabIndex = 0;
            // 
            // groupBox_giriş
            // 
            this.groupBox_giriş.Controls.Add(this.checkBox_cizgi);
            this.groupBox_giriş.Controls.Add(this.button_sıfırla);
            this.groupBox_giriş.Controls.Add(this.panel_giriş);
            this.groupBox_giriş.Location = new System.Drawing.Point(12, 12);
            this.groupBox_giriş.Name = "groupBox_giriş";
            this.groupBox_giriş.Size = new System.Drawing.Size(180, 299);
            this.groupBox_giriş.TabIndex = 1;
            this.groupBox_giriş.TabStop = false;
            this.groupBox_giriş.Text = "Veri Girişi";
            // 
            // checkBox_cizgi
            // 
            this.checkBox_cizgi.AutoSize = true;
            this.checkBox_cizgi.Location = new System.Drawing.Point(12, 272);
            this.checkBox_cizgi.Name = "checkBox_cizgi";
            this.checkBox_cizgi.Size = new System.Drawing.Size(90, 17);
            this.checkBox_cizgi.TabIndex = 3;
            this.checkBox_cizgi.Text = "Çizgileri Kaldır";
            this.checkBox_cizgi.UseVisualStyleBackColor = true;
            this.checkBox_cizgi.CheckedChanged += new System.EventHandler(this.checkBox_cizgi_CheckedChanged);
            // 
            // button_sıfırla
            // 
            this.button_sıfırla.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_sıfırla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sıfırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sıfırla.Location = new System.Drawing.Point(12, 243);
            this.button_sıfırla.Name = "button_sıfırla";
            this.button_sıfırla.Size = new System.Drawing.Size(156, 23);
            this.button_sıfırla.TabIndex = 2;
            this.button_sıfırla.Text = "Sıfırla";
            this.button_sıfırla.UseVisualStyleBackColor = false;
            this.button_sıfırla.Click += new System.EventHandler(this.button_sıfırla_Click);
            // 
            // button_eğit
            // 
            this.button_eğit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_eğit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_eğit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_eğit.Location = new System.Drawing.Point(149, 19);
            this.button_eğit.Name = "button_eğit";
            this.button_eğit.Size = new System.Drawing.Size(73, 40);
            this.button_eğit.TabIndex = 2;
            this.button_eğit.Text = "Eğit";
            this.button_eğit.UseVisualStyleBackColor = false;
            this.button_eğit.Click += new System.EventHandler(this.button_eğit_Click);
            // 
            // groupBox_eğitim
            // 
            this.groupBox_eğitim.Controls.Add(this.checkBox_epoch);
            this.groupBox_eğitim.Controls.Add(this.label6);
            this.groupBox_eğitim.Controls.Add(this.label5);
            this.groupBox_eğitim.Controls.Add(this.numericUpDown_epoch);
            this.groupBox_eğitim.Controls.Add(this.numericUpDown_goal);
            this.groupBox_eğitim.Controls.Add(this.label4);
            this.groupBox_eğitim.Controls.Add(this.button_eğit);
            this.groupBox_eğitim.Location = new System.Drawing.Point(210, 204);
            this.groupBox_eğitim.Name = "groupBox_eğitim";
            this.groupBox_eğitim.Size = new System.Drawing.Size(289, 79);
            this.groupBox_eğitim.TabIndex = 3;
            this.groupBox_eğitim.TabStop = false;
            this.groupBox_eğitim.Text = "3-Eğitim";
            // 
            // checkBox_epoch
            // 
            this.checkBox_epoch.AutoSize = true;
            this.checkBox_epoch.Location = new System.Drawing.Point(6, 20);
            this.checkBox_epoch.Name = "checkBox_epoch";
            this.checkBox_epoch.Size = new System.Drawing.Size(60, 17);
            this.checkBox_epoch.TabIndex = 10;
            this.checkBox_epoch.Text = "Epoch;";
            this.checkBox_epoch.UseVisualStyleBackColor = true;
            this.checkBox_epoch.CheckedChanged += new System.EventHandler(this.checkBox_epoch_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "--";
            // 
            // numericUpDown_epoch
            // 
            this.numericUpDown_epoch.Enabled = false;
            this.numericUpDown_epoch.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_epoch.Location = new System.Drawing.Point(68, 18);
            this.numericUpDown_epoch.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_epoch.Name = "numericUpDown_epoch";
            this.numericUpDown_epoch.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown_epoch.TabIndex = 9;
            this.numericUpDown_epoch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_epoch.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown_goal
            // 
            this.numericUpDown_goal.DecimalPlaces = 6;
            this.numericUpDown_goal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.numericUpDown_goal.Location = new System.Drawing.Point(68, 39);
            this.numericUpDown_goal.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            this.numericUpDown_goal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.numericUpDown_goal.Name = "numericUpDown_goal";
            this.numericUpDown_goal.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown_goal.TabIndex = 9;
            this.numericUpDown_goal.Value = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Goal:";
            // 
            // button_tahminet
            // 
            this.button_tahminet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_tahminet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tahminet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_tahminet.Location = new System.Drawing.Point(12, 18);
            this.button_tahminet.Name = "button_tahminet";
            this.button_tahminet.Size = new System.Drawing.Size(156, 38);
            this.button_tahminet.TabIndex = 4;
            this.button_tahminet.Text = "Tahmin Et";
            this.button_tahminet.UseVisualStyleBackColor = false;
            this.button_tahminet.Click += new System.EventHandler(this.button_tahminet_Click);
            // 
            // label_hataoranı
            // 
            this.label_hataoranı.AutoSize = true;
            this.label_hataoranı.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_hataoranı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_hataoranı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_hataoranı.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_hataoranı.ForeColor = System.Drawing.Color.Red;
            this.label_hataoranı.Location = new System.Drawing.Point(9, 64);
            this.label_hataoranı.Name = "label_hataoranı";
            this.label_hataoranı.Size = new System.Drawing.Size(76, 15);
            this.label_hataoranı.TabIndex = 7;
            this.label_hataoranı.Text = "Hata oranı: ";
            // 
            // comboBox_harf
            // 
            this.comboBox_harf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_harf.Enabled = false;
            this.comboBox_harf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_harf.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBox_harf.FormattingEnabled = true;
            this.comboBox_harf.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBox_harf.Location = new System.Drawing.Point(20, 39);
            this.comboBox_harf.Name = "comboBox_harf";
            this.comboBox_harf.Size = new System.Drawing.Size(96, 21);
            this.comboBox_harf.TabIndex = 8;
            // 
            // groupBox_tanımlama
            // 
            this.groupBox_tanımlama.Controls.Add(this.checkBox_otoyükle);
            this.groupBox_tanımlama.Controls.Add(this.label3);
            this.groupBox_tanımlama.Controls.Add(this.comboBox_harf);
            this.groupBox_tanımlama.Controls.Add(this.button_harfseç);
            this.groupBox_tanımlama.Location = new System.Drawing.Point(210, 119);
            this.groupBox_tanımlama.Name = "groupBox_tanımlama";
            this.groupBox_tanımlama.Size = new System.Drawing.Size(289, 79);
            this.groupBox_tanımlama.TabIndex = 6;
            this.groupBox_tanımlama.TabStop = false;
            this.groupBox_tanımlama.Text = "2-Tanımlama";
            // 
            // checkBox_otoyükle
            // 
            this.checkBox_otoyükle.AutoSize = true;
            this.checkBox_otoyükle.Checked = true;
            this.checkBox_otoyükle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_otoyükle.Location = new System.Drawing.Point(210, 20);
            this.checkBox_otoyükle.Name = "checkBox_otoyükle";
            this.checkBox_otoyükle.Size = new System.Drawing.Size(75, 17);
            this.checkBox_otoyükle.TabIndex = 10;
            this.checkBox_otoyükle.Text = "Auto-Load";
            this.checkBox_otoyükle.UseVisualStyleBackColor = true;
            this.checkBox_otoyükle.CheckedChanged += new System.EventHandler(this.checkBox_otoyükle_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Harf Seç :";
            // 
            // button_harfseç
            // 
            this.button_harfseç.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_harfseç.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_harfseç.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_harfseç.Location = new System.Drawing.Point(131, 20);
            this.button_harfseç.Name = "button_harfseç";
            this.button_harfseç.Size = new System.Drawing.Size(73, 40);
            this.button_harfseç.TabIndex = 2;
            this.button_harfseç.Text = "Harf Tanımla";
            this.button_harfseç.UseVisualStyleBackColor = false;
            this.button_harfseç.Click += new System.EventHandler(this.button_harfseç_Click);
            // 
            // linkLabel_restart
            // 
            this.linkLabel_restart.ActiveLinkColor = System.Drawing.Color.Green;
            this.linkLabel_restart.AutoSize = true;
            this.linkLabel_restart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabel_restart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel_restart.Font = new System.Drawing.Font("Eras Bold ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_restart.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_restart.LinkColor = System.Drawing.Color.Red;
            this.linkLabel_restart.Location = new System.Drawing.Point(505, 413);
            this.linkLabel_restart.Name = "linkLabel_restart";
            this.linkLabel_restart.Size = new System.Drawing.Size(51, 15);
            this.linkLabel_restart.TabIndex = 11;
            this.linkLabel_restart.TabStop = true;
            this.linkLabel_restart.Text = "Restart";
            this.linkLabel_restart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_restart_LinkClicked);
            // 
            // groupBox_baslangıc
            // 
            this.groupBox_baslangıc.Controls.Add(this.numericUpDown_alfa);
            this.groupBox_baslangıc.Controls.Add(this.numericUpDown_lamda);
            this.groupBox_baslangıc.Controls.Add(this.numericUpDown_nöronsayısı);
            this.groupBox_baslangıc.Controls.Add(this.label7);
            this.groupBox_baslangıc.Controls.Add(this.label2);
            this.groupBox_baslangıc.Controls.Add(this.label1);
            this.groupBox_baslangıc.Controls.Add(this.button_ağoluştur);
            this.groupBox_baslangıc.Location = new System.Drawing.Point(210, 12);
            this.groupBox_baslangıc.Name = "groupBox_baslangıc";
            this.groupBox_baslangıc.Size = new System.Drawing.Size(289, 101);
            this.groupBox_baslangıc.TabIndex = 6;
            this.groupBox_baslangıc.TabStop = false;
            this.groupBox_baslangıc.Text = "1-Başlangıç Ayarları";
            // 
            // numericUpDown_alfa
            // 
            this.numericUpDown_alfa.DecimalPlaces = 2;
            this.numericUpDown_alfa.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown_alfa.Location = new System.Drawing.Point(144, 63);
            this.numericUpDown_alfa.Name = "numericUpDown_alfa";
            this.numericUpDown_alfa.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown_alfa.TabIndex = 12;
            this.numericUpDown_alfa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_alfa.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // numericUpDown_lamda
            // 
            this.numericUpDown_lamda.DecimalPlaces = 2;
            this.numericUpDown_lamda.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown_lamda.Location = new System.Drawing.Point(144, 39);
            this.numericUpDown_lamda.Name = "numericUpDown_lamda";
            this.numericUpDown_lamda.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown_lamda.TabIndex = 12;
            this.numericUpDown_lamda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_lamda.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numericUpDown_nöronsayısı
            // 
            this.numericUpDown_nöronsayısı.Location = new System.Drawing.Point(144, 15);
            this.numericUpDown_nöronsayısı.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_nöronsayısı.Name = "numericUpDown_nöronsayısı";
            this.numericUpDown_nöronsayısı.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown_nöronsayısı.TabIndex = 12;
            this.numericUpDown_nöronsayısı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_nöronsayısı.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ağ Momentum Katsayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ağ Öğrenme Katsayısı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gizli Katman Nöron Sayısı :";
            // 
            // button_ağoluştur
            // 
            this.button_ağoluştur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_ağoluştur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ağoluştur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ağoluştur.Location = new System.Drawing.Point(220, 15);
            this.button_ağoluştur.Name = "button_ağoluştur";
            this.button_ağoluştur.Size = new System.Drawing.Size(63, 68);
            this.button_ağoluştur.TabIndex = 2;
            this.button_ağoluştur.Text = "Ağı Oluştur";
            this.button_ağoluştur.UseVisualStyleBackColor = false;
            this.button_ağoluştur.Click += new System.EventHandler(this.button_ağoluştur_Click);
            // 
            // groupBox_sonuçlar
            // 
            this.groupBox_sonuçlar.Controls.Add(this.label_çıkışE);
            this.groupBox_sonuçlar.Controls.Add(this.label_result_e);
            this.groupBox_sonuçlar.Controls.Add(this.label_çıkışC);
            this.groupBox_sonuçlar.Controls.Add(this.label_result_c);
            this.groupBox_sonuçlar.Controls.Add(this.label_çıkışD);
            this.groupBox_sonuçlar.Controls.Add(this.label_result_d);
            this.groupBox_sonuçlar.Controls.Add(this.label_çıkışB);
            this.groupBox_sonuçlar.Controls.Add(this.label_result_b);
            this.groupBox_sonuçlar.Controls.Add(this.label_çıkışA);
            this.groupBox_sonuçlar.Controls.Add(this.label_result_a);
            this.groupBox_sonuçlar.Location = new System.Drawing.Point(210, 289);
            this.groupBox_sonuçlar.Name = "groupBox_sonuçlar";
            this.groupBox_sonuçlar.Size = new System.Drawing.Size(289, 139);
            this.groupBox_sonuçlar.TabIndex = 6;
            this.groupBox_sonuçlar.TabStop = false;
            this.groupBox_sonuçlar.Text = "=> Ağın Çıktısı";
            // 
            // label_çıkışE
            // 
            this.label_çıkışE.AutoSize = true;
            this.label_çıkışE.Location = new System.Drawing.Point(54, 115);
            this.label_çıkışE.Name = "label_çıkışE";
            this.label_çıkışE.Size = new System.Drawing.Size(16, 13);
            this.label_çıkışE.TabIndex = 5;
            this.label_çıkışE.Text = "---";
            // 
            // label_result_e
            // 
            this.label_result_e.AutoSize = true;
            this.label_result_e.Location = new System.Drawing.Point(23, 115);
            this.label_result_e.Name = "label_result_e";
            this.label_result_e.Size = new System.Drawing.Size(20, 13);
            this.label_result_e.TabIndex = 5;
            this.label_result_e.Text = "E :";
            // 
            // label_çıkışC
            // 
            this.label_çıkışC.AutoSize = true;
            this.label_çıkışC.Location = new System.Drawing.Point(54, 67);
            this.label_çıkışC.Name = "label_çıkışC";
            this.label_çıkışC.Size = new System.Drawing.Size(16, 13);
            this.label_çıkışC.TabIndex = 5;
            this.label_çıkışC.Text = "---";
            // 
            // label_result_c
            // 
            this.label_result_c.AutoSize = true;
            this.label_result_c.Location = new System.Drawing.Point(23, 67);
            this.label_result_c.Name = "label_result_c";
            this.label_result_c.Size = new System.Drawing.Size(20, 13);
            this.label_result_c.TabIndex = 5;
            this.label_result_c.Text = "C :";
            // 
            // label_çıkışD
            // 
            this.label_çıkışD.AutoSize = true;
            this.label_çıkışD.Location = new System.Drawing.Point(54, 91);
            this.label_çıkışD.Name = "label_çıkışD";
            this.label_çıkışD.Size = new System.Drawing.Size(16, 13);
            this.label_çıkışD.TabIndex = 5;
            this.label_çıkışD.Text = "---";
            // 
            // label_result_d
            // 
            this.label_result_d.AutoSize = true;
            this.label_result_d.Location = new System.Drawing.Point(23, 91);
            this.label_result_d.Name = "label_result_d";
            this.label_result_d.Size = new System.Drawing.Size(21, 13);
            this.label_result_d.TabIndex = 5;
            this.label_result_d.Text = "D :";
            // 
            // label_çıkışB
            // 
            this.label_çıkışB.AutoSize = true;
            this.label_çıkışB.Location = new System.Drawing.Point(54, 43);
            this.label_çıkışB.Name = "label_çıkışB";
            this.label_çıkışB.Size = new System.Drawing.Size(16, 13);
            this.label_çıkışB.TabIndex = 5;
            this.label_çıkışB.Text = "---";
            // 
            // label_result_b
            // 
            this.label_result_b.AutoSize = true;
            this.label_result_b.Location = new System.Drawing.Point(23, 43);
            this.label_result_b.Name = "label_result_b";
            this.label_result_b.Size = new System.Drawing.Size(20, 13);
            this.label_result_b.TabIndex = 5;
            this.label_result_b.Text = "B :";
            // 
            // label_çıkışA
            // 
            this.label_çıkışA.AutoSize = true;
            this.label_çıkışA.Location = new System.Drawing.Point(54, 19);
            this.label_çıkışA.Name = "label_çıkışA";
            this.label_çıkışA.Size = new System.Drawing.Size(16, 13);
            this.label_çıkışA.TabIndex = 5;
            this.label_çıkışA.Text = "---";
            // 
            // label_result_a
            // 
            this.label_result_a.AutoSize = true;
            this.label_result_a.Location = new System.Drawing.Point(23, 19);
            this.label_result_a.Name = "label_result_a";
            this.label_result_a.Size = new System.Drawing.Size(20, 13);
            this.label_result_a.TabIndex = 5;
            this.label_result_a.Text = "A :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_tahminet);
            this.groupBox1.Controls.Add(this.label_hataoranı);
            this.groupBox1.Location = new System.Drawing.Point(12, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 111);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "4-Ağı Test Et";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 440);
            this.Controls.Add(this.linkLabel_restart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_sonuçlar);
            this.Controls.Add(this.groupBox_baslangıc);
            this.Controls.Add(this.groupBox_tanımlama);
            this.Controls.Add(this.groupBox_eğitim);
            this.Controls.Add(this.groupBox_giriş);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karakter Tanıma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_giriş.ResumeLayout(false);
            this.groupBox_giriş.PerformLayout();
            this.groupBox_eğitim.ResumeLayout(false);
            this.groupBox_eğitim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_epoch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_goal)).EndInit();
            this.groupBox_tanımlama.ResumeLayout(false);
            this.groupBox_tanımlama.PerformLayout();
            this.groupBox_baslangıc.ResumeLayout(false);
            this.groupBox_baslangıc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_alfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lamda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nöronsayısı)).EndInit();
            this.groupBox_sonuçlar.ResumeLayout(false);
            this.groupBox_sonuçlar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_giriş;
        private System.Windows.Forms.GroupBox groupBox_giriş;
        private System.Windows.Forms.Button button_sıfırla;
        private System.Windows.Forms.Button button_eğit;
        private System.Windows.Forms.GroupBox groupBox_eğitim;
        private System.Windows.Forms.Button button_tahminet;
        private System.Windows.Forms.CheckBox checkBox_cizgi;
        private System.Windows.Forms.Label label_hataoranı;
        private System.Windows.Forms.ComboBox comboBox_harf;
        private System.Windows.Forms.GroupBox groupBox_tanımlama;
        private System.Windows.Forms.Button button_harfseç;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_goal;
        private System.Windows.Forms.CheckBox checkBox_otoyükle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_epoch;
        private System.Windows.Forms.LinkLabel linkLabel_restart;
        private System.Windows.Forms.GroupBox groupBox_baslangıc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ağoluştur;
        private System.Windows.Forms.NumericUpDown numericUpDown_lamda;
        private System.Windows.Forms.NumericUpDown numericUpDown_nöronsayısı;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_alfa;
        private System.Windows.Forms.GroupBox groupBox_sonuçlar;
        private System.Windows.Forms.Label label_result_c;
        private System.Windows.Forms.Label label_result_b;
        private System.Windows.Forms.Label label_result_a;
        private System.Windows.Forms.Label label_çıkışE;
        private System.Windows.Forms.Label label_result_e;
        private System.Windows.Forms.Label label_çıkışC;
        private System.Windows.Forms.Label label_çıkışD;
        private System.Windows.Forms.Label label_result_d;
        private System.Windows.Forms.Label label_çıkışB;
        private System.Windows.Forms.Label label_çıkışA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_epoch;

    }
}

