namespace IlkerRentACar.UI
{
    partial class MusteriEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.lblMeslek = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtIsTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCepTel = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNotlar = new System.Windows.Forms.Label();
            this.dateAlisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.lblEhliyetAlisTArihi = new System.Windows.Forms.Label();
            this.txtEhliyetTur = new System.Windows.Forms.TextBox();
            this.lblEhliyetTur = new System.Windows.Forms.Label();
            this.txtEhliyetNo = new System.Windows.Forms.TextBox();
            this.lblEhliyetNo = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Size = new System.Drawing.Size(1384, 596);
            // 
            // btnKaydet
            // 
            this.btnKaydet.AutoEllipsis = true;
            this.btnKaydet.Location = new System.Drawing.Point(1091, 18);
            this.btnKaydet.Size = new System.Drawing.Size(243, 71);
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCinsiyet);
            this.groupBox1.Controls.Add(this.dateDogumTarihi);
            this.groupBox1.Controls.Add(this.txtMeslek);
            this.groupBox1.Controls.Add(this.lblMeslek);
            this.groupBox1.Controls.Add(this.lblCinsiyet);
            this.groupBox1.Controls.Add(this.lblDogumTarihi);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 569);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(173, 435);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(254, 34);
            this.cmbCinsiyet.TabIndex = 3;
            // 
            // dateDogumTarihi
            // 
            this.dateDogumTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDogumTarihi.Location = new System.Drawing.Point(173, 357);
            this.dateDogumTarihi.Name = "dateDogumTarihi";
            this.dateDogumTarihi.Size = new System.Drawing.Size(254, 32);
            this.dateDogumTarihi.TabIndex = 2;
            // 
            // txtMeslek
            // 
            this.txtMeslek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMeslek.Location = new System.Drawing.Point(169, 515);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(258, 32);
            this.txtMeslek.TabIndex = 1;
            // 
            // lblMeslek
            // 
            this.lblMeslek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMeslek.AutoSize = true;
            this.lblMeslek.Location = new System.Drawing.Point(-3, 516);
            this.lblMeslek.Name = "lblMeslek";
            this.lblMeslek.Size = new System.Drawing.Size(94, 26);
            this.lblMeslek.TabIndex = 0;
            this.lblMeslek.Text = "Meslek:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(-3, 438);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(105, 26);
            this.lblCinsiyet.TabIndex = 0;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(-3, 360);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(161, 26);
            this.lblDogumTarihi.TabIndex = 0;
            this.lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // txtTc
            // 
            this.txtTc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTc.Location = new System.Drawing.Point(169, 279);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(258, 32);
            this.txtTc.TabIndex = 1;
            // 
            // lblTc
            // 
            this.lblTc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(-3, 282);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(96, 26);
            this.lblTc.TabIndex = 0;
            this.lblTc.Text = "T.C. no:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoyad.Location = new System.Drawing.Point(169, 201);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(258, 32);
            this.txtSoyad.TabIndex = 1;
            // 
            // lblSoyad
            // 
            this.lblSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(-3, 204);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(86, 26);
            this.lblSoyad.TabIndex = 0;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(169, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(258, 32);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(-3, 48);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(39, 26);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // txtAd
            // 
            this.txtAd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAd.Location = new System.Drawing.Point(169, 123);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(258, 32);
            this.txtAd.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(-3, 126);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(48, 26);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAdres);
            this.groupBox2.Controls.Add(this.lblSehir);
            this.groupBox2.Controls.Add(this.txtAdres);
            this.groupBox2.Controls.Add(this.txtSehir);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtIsTel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCepTel);
            this.groupBox2.Controls.Add(this.lblCep);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(451, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 569);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İletişim Bilgiler";
            // 
            // lblAdres
            // 
            this.lblAdres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(6, 372);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(81, 26);
            this.lblAdres.TabIndex = 0;
            this.lblAdres.Text = "Adres:";
            // 
            // lblSehir
            // 
            this.lblSehir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(6, 291);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(75, 26);
            this.lblSehir.TabIndex = 0;
            this.lblSehir.Text = "Şehir:";
            // 
            // txtAdres
            // 
            this.txtAdres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdres.Location = new System.Drawing.Point(169, 365);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(252, 177);
            this.txtAdres.TabIndex = 1;
            // 
            // txtSehir
            // 
            this.txtSehir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSehir.Location = new System.Drawing.Point(169, 285);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(252, 32);
            this.txtSehir.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(169, 205);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 32);
            this.txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 210);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 26);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtIsTel
            // 
            this.txtIsTel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIsTel.Location = new System.Drawing.Point(169, 125);
            this.txtIsTel.Name = "txtIsTel";
            this.txtIsTel.Size = new System.Drawing.Size(252, 32);
            this.txtIsTel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "İş Tel:";
            // 
            // txtCepTel
            // 
            this.txtCepTel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCepTel.Location = new System.Drawing.Point(169, 45);
            this.txtCepTel.Name = "txtCepTel";
            this.txtCepTel.Size = new System.Drawing.Size(252, 32);
            this.txtCepTel.TabIndex = 1;
            // 
            // lblCep
            // 
            this.lblCep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(6, 48);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(101, 26);
            this.lblCep.TabIndex = 0;
            this.lblCep.Text = "Cep Tel:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblNotlar);
            this.groupBox3.Controls.Add(this.dateAlisTarihi);
            this.groupBox3.Controls.Add(this.txtNotlar);
            this.groupBox3.Controls.Add(this.lblEhliyetAlisTArihi);
            this.groupBox3.Controls.Add(this.txtEhliyetTur);
            this.groupBox3.Controls.Add(this.lblEhliyetTur);
            this.groupBox3.Controls.Add(this.txtEhliyetNo);
            this.groupBox3.Controls.Add(this.lblEhliyetNo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(884, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 569);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ehliyet/Diğer Bilgiler";
            // 
            // lblNotlar
            // 
            this.lblNotlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotlar.AutoSize = true;
            this.lblNotlar.Location = new System.Drawing.Point(7, 291);
            this.lblNotlar.Name = "lblNotlar";
            this.lblNotlar.Size = new System.Drawing.Size(83, 26);
            this.lblNotlar.TabIndex = 0;
            this.lblNotlar.Text = "Notlar:";
            // 
            // dateAlisTarihi
            // 
            this.dateAlisTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateAlisTarihi.Location = new System.Drawing.Point(169, 205);
            this.dateAlisTarihi.Name = "dateAlisTarihi";
            this.dateAlisTarihi.Size = new System.Drawing.Size(281, 32);
            this.dateAlisTarihi.TabIndex = 2;
            // 
            // txtNotlar
            // 
            this.txtNotlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotlar.Location = new System.Drawing.Point(170, 285);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(281, 257);
            this.txtNotlar.TabIndex = 1;
            // 
            // lblEhliyetAlisTArihi
            // 
            this.lblEhliyetAlisTArihi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEhliyetAlisTArihi.AutoSize = true;
            this.lblEhliyetAlisTArihi.Location = new System.Drawing.Point(7, 210);
            this.lblEhliyetAlisTArihi.Name = "lblEhliyetAlisTArihi";
            this.lblEhliyetAlisTArihi.Size = new System.Drawing.Size(125, 26);
            this.lblEhliyetAlisTArihi.TabIndex = 0;
            this.lblEhliyetAlisTArihi.Text = "Alış Tarihi:";
            // 
            // txtEhliyetTur
            // 
            this.txtEhliyetTur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEhliyetTur.Location = new System.Drawing.Point(169, 125);
            this.txtEhliyetTur.Name = "txtEhliyetTur";
            this.txtEhliyetTur.Size = new System.Drawing.Size(281, 32);
            this.txtEhliyetTur.TabIndex = 1;
            // 
            // lblEhliyetTur
            // 
            this.lblEhliyetTur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEhliyetTur.AutoSize = true;
            this.lblEhliyetTur.Location = new System.Drawing.Point(7, 129);
            this.lblEhliyetTur.Name = "lblEhliyetTur";
            this.lblEhliyetTur.Size = new System.Drawing.Size(146, 26);
            this.lblEhliyetTur.TabIndex = 0;
            this.lblEhliyetTur.Text = "Ehliyet Türü:";
            // 
            // txtEhliyetNo
            // 
            this.txtEhliyetNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEhliyetNo.Location = new System.Drawing.Point(169, 45);
            this.txtEhliyetNo.Name = "txtEhliyetNo";
            this.txtEhliyetNo.Size = new System.Drawing.Size(281, 32);
            this.txtEhliyetNo.TabIndex = 1;
            // 
            // lblEhliyetNo
            // 
            this.lblEhliyetNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEhliyetNo.AutoSize = true;
            this.lblEhliyetNo.Location = new System.Drawing.Point(7, 48);
            this.lblEhliyetNo.Name = "lblEhliyetNo";
            this.lblEhliyetNo.Size = new System.Drawing.Size(129, 26);
            this.lblEhliyetNo.TabIndex = 0;
            this.lblEhliyetNo.Text = "Ehliyet No:";
            // 
            // MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 796);
            this.Name = "MusteriEkle";
            this.Text = "MusteriEkle";
            this.Load += new System.EventHandler(this.MusteriEkle_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNotlar;
        private System.Windows.Forms.DateTimePicker dateAlisTarihi;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.Label lblEhliyetAlisTArihi;
        private System.Windows.Forms.TextBox txtEhliyetTur;
        private System.Windows.Forms.Label lblEhliyetTur;
        private System.Windows.Forms.TextBox txtEhliyetNo;
        private System.Windows.Forms.Label lblEhliyetNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtIsTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCepTel;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker dateDogumTarihi;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Label lblMeslek;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}