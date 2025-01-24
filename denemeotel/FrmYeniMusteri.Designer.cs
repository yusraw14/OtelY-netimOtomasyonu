namespace denemeotel
{
    partial class FrmYeniMusteri
    {
        private System.ComponentModel.IContainer components = null;
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpCikis = new System.Windows.Forms.DateTimePicker();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.LabelCikis = new System.Windows.Forms.Label();
            this.LabelGiris = new System.Windows.Forms.Label();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.LabelUcret = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.TxtTCkimlik = new System.Windows.Forms.TextBox();
            this.TxtOdaNumarasi = new System.Windows.Forms.TextBox();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.LabelOdaNo = new System.Windows.Forms.Label();
            this.LabelTC = new System.Windows.Forms.Label();
            this.LabelTel = new System.Windows.Forms.Label();
            this.LabelSoyadi = new System.Windows.Forms.Label();
            this.LabelAdi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOda402 = new System.Windows.Forms.Button();
            this.btnDoluOda = new System.Windows.Forms.Button();
            this.btnBosOda = new System.Windows.Forms.Button();
            this.btnOda403 = new System.Windows.Forms.Button();
            this.btnOda401 = new System.Windows.Forms.Button();
            this.btnOda302 = new System.Windows.Forms.Button();
            this.btnOda303 = new System.Windows.Forms.Button();
            this.btnOda301 = new System.Windows.Forms.Button();
            this.btnOda202 = new System.Windows.Forms.Button();
            this.btnOda203 = new System.Windows.Forms.Button();
            this.btnOda201 = new System.Windows.Forms.Button();
            this.btnOda102 = new System.Windows.Forms.Button();
            this.btnOda103 = new System.Windows.Forms.Button();
            this.btnOda101 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpCikis);
            this.groupBox1.Controls.Add(this.dtpGiris);
            this.groupBox1.Controls.Add(this.LabelCikis);
            this.groupBox1.Controls.Add(this.LabelGiris);
            this.groupBox1.Controls.Add(this.TxtUcret);
            this.groupBox1.Controls.Add(this.LabelUcret);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.TxtTCkimlik);
            this.groupBox1.Controls.Add(this.TxtOdaNumarasi);
            this.groupBox1.Controls.Add(this.TxtAdi);
            this.groupBox1.Controls.Add(this.TxtSoyadi);
            this.groupBox1.Controls.Add(this.LabelOdaNo);
            this.groupBox1.Controls.Add(this.LabelTC);
            this.groupBox1.Controls.Add(this.LabelTel);
            this.groupBox1.Controls.Add(this.LabelSoyadi);
            this.groupBox1.Controls.Add(this.LabelAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpCikis
            // 
            this.dtpCikis.Location = new System.Drawing.Point(129, 321);
            this.dtpCikis.Name = "dtpCikis";
            this.dtpCikis.Size = new System.Drawing.Size(196, 22);
            this.dtpCikis.TabIndex = 42;
            // 
            // dtpGiris
            // 
            this.dtpGiris.CalendarMonthBackground = System.Drawing.Color.Wheat;
            this.dtpGiris.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dtpGiris.Location = new System.Drawing.Point(129, 274);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(196, 22);
            this.dtpGiris.TabIndex = 41;
            // 
            // LabelCikis
            // 
            this.LabelCikis.AutoSize = true;
            this.LabelCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelCikis.Location = new System.Drawing.Point(32, 321);
            this.LabelCikis.Name = "LabelCikis";
            this.LabelCikis.Size = new System.Drawing.Size(89, 16);
            this.LabelCikis.TabIndex = 40;
            this.LabelCikis.Text = "Çıkış Tarihi:";
            // 
            // LabelGiris
            // 
            this.LabelGiris.AutoSize = true;
            this.LabelGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelGiris.Location = new System.Drawing.Point(34, 279);
            this.LabelGiris.Name = "LabelGiris";
            this.LabelGiris.Size = new System.Drawing.Size(87, 16);
            this.LabelGiris.TabIndex = 39;
            this.LabelGiris.Text = "Giriş Tarihi:";
            // 
            // TxtUcret
            // 
            this.TxtUcret.BackColor = System.Drawing.Color.Wheat;
            this.TxtUcret.Location = new System.Drawing.Point(129, 233);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(196, 22);
            this.TxtUcret.TabIndex = 38;
            // 
            // LabelUcret
            // 
            this.LabelUcret.AutoSize = true;
            this.LabelUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelUcret.Location = new System.Drawing.Point(66, 239);
            this.LabelUcret.Name = "LabelUcret";
            this.LabelUcret.Size = new System.Drawing.Size(48, 16);
            this.LabelUcret.TabIndex = 37;
            this.LabelUcret.Text = "Ücret:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Wheat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(150, 426);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(129, 57);
            this.btnKaydet.TabIndex = 36;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.Wheat;
            this.maskedTextBox1.Location = new System.Drawing.Point(127, 121);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(196, 22);
            this.maskedTextBox1.TabIndex = 33;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // TxtTCkimlik
            // 
            this.TxtTCkimlik.BackColor = System.Drawing.Color.Wheat;
            this.TxtTCkimlik.Location = new System.Drawing.Point(127, 157);
            this.TxtTCkimlik.Name = "TxtTCkimlik";
            this.TxtTCkimlik.Size = new System.Drawing.Size(196, 22);
            this.TxtTCkimlik.TabIndex = 32;
            // 
            // TxtOdaNumarasi
            // 
            this.TxtOdaNumarasi.BackColor = System.Drawing.Color.Wheat;
            this.TxtOdaNumarasi.Location = new System.Drawing.Point(129, 197);
            this.TxtOdaNumarasi.Name = "TxtOdaNumarasi";
            this.TxtOdaNumarasi.Size = new System.Drawing.Size(196, 22);
            this.TxtOdaNumarasi.TabIndex = 31;
            // 
            // TxtAdi
            // 
            this.TxtAdi.BackColor = System.Drawing.Color.Wheat;
            this.TxtAdi.Location = new System.Drawing.Point(127, 45);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(196, 22);
            this.TxtAdi.TabIndex = 30;
            this.TxtAdi.TextChanged += new System.EventHandler(this.TxtAdi_TextChanged);
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.BackColor = System.Drawing.Color.Wheat;
            this.TxtSoyadi.Location = new System.Drawing.Point(127, 79);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(196, 22);
            this.TxtSoyadi.TabIndex = 29;
            // 
            // LabelOdaNo
            // 
            this.LabelOdaNo.AutoSize = true;
            this.LabelOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelOdaNo.Location = new System.Drawing.Point(11, 200);
            this.LabelOdaNo.Name = "LabelOdaNo";
            this.LabelOdaNo.Size = new System.Drawing.Size(110, 16);
            this.LabelOdaNo.TabIndex = 24;
            this.LabelOdaNo.Text = "Oda Numarası:";
            this.LabelOdaNo.Click += new System.EventHandler(this.txtOdaNumarasi_Click);
            // 
            // LabelTC
            // 
            this.LabelTC.AutoSize = true;
            this.LabelTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelTC.Location = new System.Drawing.Point(21, 163);
            this.LabelTC.Name = "LabelTC";
            this.LabelTC.Size = new System.Drawing.Size(100, 16);
            this.LabelTC.TabIndex = 23;
            this.LabelTC.Text = "TC Kimlik No:";
            // 
            // LabelTel
            // 
            this.LabelTel.AutoSize = true;
            this.LabelTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelTel.Location = new System.Drawing.Point(33, 124);
            this.LabelTel.Name = "LabelTel";
            this.LabelTel.Size = new System.Drawing.Size(88, 16);
            this.LabelTel.TabIndex = 22;
            this.LabelTel.Text = "Telefon No:";
            // 
            // LabelSoyadi
            // 
            this.LabelSoyadi.AutoSize = true;
            this.LabelSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelSoyadi.Location = new System.Drawing.Point(57, 82);
            this.LabelSoyadi.Name = "LabelSoyadi";
            this.LabelSoyadi.Size = new System.Drawing.Size(60, 16);
            this.LabelSoyadi.TabIndex = 21;
            this.LabelSoyadi.Text = "Soyadı:";
            // 
            // LabelAdi
            // 
            this.LabelAdi.AutoSize = true;
            this.LabelAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelAdi.Location = new System.Drawing.Point(80, 45);
            this.LabelAdi.Name = "LabelAdi";
            this.LabelAdi.Size = new System.Drawing.Size(34, 16);
            this.LabelAdi.TabIndex = 20;
            this.LabelAdi.Text = "Adı:";
            this.LabelAdi.Click += new System.EventHandler(this.txtAdi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOda402);
            this.groupBox2.Controls.Add(this.btnDoluOda);
            this.groupBox2.Controls.Add(this.btnBosOda);
            this.groupBox2.Controls.Add(this.btnOda403);
            this.groupBox2.Controls.Add(this.btnOda401);
            this.groupBox2.Controls.Add(this.btnOda302);
            this.groupBox2.Controls.Add(this.btnOda303);
            this.groupBox2.Controls.Add(this.btnOda301);
            this.groupBox2.Controls.Add(this.btnOda202);
            this.groupBox2.Controls.Add(this.btnOda203);
            this.groupBox2.Controls.Add(this.btnOda201);
            this.groupBox2.Controls.Add(this.btnOda102);
            this.groupBox2.Controls.Add(this.btnOda103);
            this.groupBox2.Controls.Add(this.btnOda101);
            this.groupBox2.Location = new System.Drawing.Point(423, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 524);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            // 
            // btnOda402
            // 
            this.btnOda402.BackColor = System.Drawing.Color.LightGreen;
            this.btnOda402.Location = new System.Drawing.Point(163, 362);
            this.btnOda402.Name = "btnOda402";
            this.btnOda402.Size = new System.Drawing.Size(88, 50);
            this.btnOda402.TabIndex = 19;
            this.btnOda402.Text = "402";
            this.btnOda402.UseVisualStyleBackColor = false;
            // 
            // btnDoluOda
            // 
            this.btnDoluOda.BackColor = System.Drawing.Color.Red;
            this.btnDoluOda.Location = new System.Drawing.Point(224, 468);
            this.btnDoluOda.Name = "btnDoluOda";
            this.btnDoluOda.Size = new System.Drawing.Size(88, 50);
            this.btnDoluOda.TabIndex = 21;
            this.btnDoluOda.Text = "DOLU";
            this.btnDoluOda.UseVisualStyleBackColor = false;
            // 
            // btnBosOda
            // 
            this.btnBosOda.BackColor = System.Drawing.Color.LightGreen;
            this.btnBosOda.Location = new System.Drawing.Point(95, 465);
            this.btnBosOda.Name = "btnBosOda";
            this.btnBosOda.Size = new System.Drawing.Size(88, 53);
            this.btnBosOda.TabIndex = 20;
            this.btnBosOda.Text = "BOŞ";
            this.btnBosOda.UseVisualStyleBackColor = false;
            // 
            // btnOda403
            // 
            this.btnOda403.BackColor = System.Drawing.Color.LightGreen;
            this.btnOda403.Location = new System.Drawing.Point(295, 360);
            this.btnOda403.Name = "btnOda403";
            this.btnOda403.Size = new System.Drawing.Size(88, 50);
            this.btnOda403.TabIndex = 17;
            this.btnOda403.Text = "403";
            this.btnOda403.UseVisualStyleBackColor = false;
            // 
            // btnOda401
            // 
            this.btnOda401.BackColor = System.Drawing.Color.LightGreen;
            this.btnOda401.Location = new System.Drawing.Point(22, 361);
            this.btnOda401.Name = "btnOda401";
            this.btnOda401.Size = new System.Drawing.Size(88, 53);
            this.btnOda401.TabIndex = 16;
            this.btnOda401.Text = "401";
            this.btnOda401.UseVisualStyleBackColor = false;
            // 
            // btnOda302
            // 
            this.btnOda302.BackColor = System.Drawing.Color.LightGreen;
            this.btnOda302.Location = new System.Drawing.Point(163, 258);
            this.btnOda302.Name = "btnOda302";
            this.btnOda302.Size = new System.Drawing.Size(88, 50);
            this.btnOda302.TabIndex = 15;
            this.btnOda302.Text = "302";
            this.btnOda302.UseVisualStyleBackColor = false;
            // 
            // btnOda303
            // 
            this.btnOda303.BackColor = System.Drawing.Color.LightGreen;
            this.btnOda303.Location = new System.Drawing.Point(295, 256);
            this.btnOda303.Name = "btnOda303";
            this.btnOda303.Size = new System.Drawing.Size(88, 50);
            this.btnOda303.TabIndex = 13;
            this.btnOda303.Text = "303";
            this.btnOda303.UseVisualStyleBackColor = false;
            // 
            // btnOda301
            // 
            this.btnOda301.BackColor = System.Drawing.Color.LightGreen;
            this.btnOda301.Location = new System.Drawing.Point(22, 257);
            this.btnOda301.Name = "btnOda301";
            this.btnOda301.Size = new System.Drawing.Size(88, 53);
            this.btnOda301.TabIndex = 12;
            this.btnOda301.Text = "301";
            this.btnOda301.UseVisualStyleBackColor = false;
            // 
            // btnOda202
            // 
            this.btnOda202.BackColor = System.Drawing.Color.LightGreen;
            this.btnOda202.Location = new System.Drawing.Point(163, 157);
            this.btnOda202.Name = "btnOda202";
            this.btnOda202.Size = new System.Drawing.Size(88, 50);
            this.btnOda202.TabIndex = 11;
            this.btnOda202.Text = "202";
            this.btnOda202.UseVisualStyleBackColor = false;
            // 
            // btnOda203
            // 
            this.btnOda203.BackColor = System.Drawing.Color.LightGreen;
            this.btnOda203.Location = new System.Drawing.Point(295, 155);
            this.btnOda203.Name = "btnOda203";
            this.btnOda203.Size = new System.Drawing.Size(88, 50);
            this.btnOda203.TabIndex = 9;
            this.btnOda203.Text = "203";
            this.btnOda203.UseVisualStyleBackColor = false;
            // 
            // btnOda201
            // 
            this.btnOda201.BackColor = System.Drawing.Color.LightGreen;
            this.btnOda201.Location = new System.Drawing.Point(22, 156);
            this.btnOda201.Name = "btnOda201";
            this.btnOda201.Size = new System.Drawing.Size(88, 53);
            this.btnOda201.TabIndex = 8;
            this.btnOda201.Text = "201";
            this.btnOda201.UseVisualStyleBackColor = false;
            // 
            // btnOda102
            // 
            this.btnOda102.BackColor = System.Drawing.Color.LightGreen;
            this.btnOda102.Location = new System.Drawing.Point(163, 53);
            this.btnOda102.Name = "btnOda102";
            this.btnOda102.Size = new System.Drawing.Size(88, 50);
            this.btnOda102.TabIndex = 7;
            this.btnOda102.Text = "102";
            this.btnOda102.UseVisualStyleBackColor = false;
            // 
            // btnOda103
            // 
            this.btnOda103.BackColor = System.Drawing.Color.LightGreen;
            this.btnOda103.Location = new System.Drawing.Point(295, 51);
            this.btnOda103.Name = "btnOda103";
            this.btnOda103.Size = new System.Drawing.Size(88, 50);
            this.btnOda103.TabIndex = 3;
            this.btnOda103.Text = "103";
            this.btnOda103.UseVisualStyleBackColor = false;
            // 
            // btnOda101
            // 
            this.btnOda101.BackColor = System.Drawing.Color.LightGreen;
            this.btnOda101.Location = new System.Drawing.Point(22, 52);
            this.btnOda101.Name = "btnOda101";
            this.btnOda101.Size = new System.Drawing.Size(88, 53);
            this.btnOda101.TabIndex = 2;
            this.btnOda101.Text = "101";
            this.btnOda101.UseVisualStyleBackColor = false;
            this.btnOda101.Click += new System.EventHandler(this.btnOda101_Click);
            // 
            // FrmYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(840, 683);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYeniMusteri";
            this.Text = "Yeni Müşteri Kayıt ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox TxtTCkimlik;
        private System.Windows.Forms.TextBox TxtOdaNumarasi;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.TextBox TxtSoyadi;
        private System.Windows.Forms.Label LabelOdaNo;
        private System.Windows.Forms.Label LabelTC;
        private System.Windows.Forms.Label LabelTel;
        private System.Windows.Forms.Label LabelSoyadi;
        private System.Windows.Forms.Label LabelAdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOda102;
        private System.Windows.Forms.Button btnOda103;
        private System.Windows.Forms.Button btnOda101;
        private System.Windows.Forms.Button btnOda402;
        private System.Windows.Forms.Button btnOda403;
        private System.Windows.Forms.Button btnOda401;
        private System.Windows.Forms.Button btnOda302;
        private System.Windows.Forms.Button btnOda303;
        private System.Windows.Forms.Button btnOda301;
        private System.Windows.Forms.Button btnOda202;
        private System.Windows.Forms.Button btnOda203;
        private System.Windows.Forms.Button btnOda201;
        private System.Windows.Forms.Button btnDoluOda;
        private System.Windows.Forms.Button btnBosOda;
        private System.Windows.Forms.DateTimePicker dtpCikis;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.Label LabelCikis;
        private System.Windows.Forms.Label LabelGiris;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.Label LabelUcret;
    }
}