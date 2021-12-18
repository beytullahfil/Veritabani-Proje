
namespace ödevv
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
            this.TxtAliciNo = new System.Windows.Forms.TextBox();
            this.AbtnListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.TxtAliciAdi = new System.Windows.Forms.TextBox();
            this.TxtAliciSoyadi = new System.Windows.Forms.TextBox();
            this.TxtAdresil = new System.Windows.Forms.TextBox();
            this.TxtKartNo = new System.Windows.Forms.TextBox();
            this.TxtKitapNo = new System.Windows.Forms.TextBox();
            this.TxtKitapAdi = new System.Windows.Forms.TextBox();
            this.TxtTur = new System.Windows.Forms.TextBox();
            this.TxtSayfa = new System.Windows.Forms.TextBox();
            this.TxtYazar = new System.Windows.Forms.TextBox();
            this.AbtnEkle = new System.Windows.Forms.Button();
            this.AbtnSil = new System.Windows.Forms.Button();
            this.AbtnGuncelle = new System.Windows.Forms.Button();
            this.AbtnArama = new System.Windows.Forms.Button();
            this.KbtnArama = new System.Windows.Forms.Button();
            this.KbtnGuncelle = new System.Windows.Forms.Button();
            this.KbtnSil = new System.Windows.Forms.Button();
            this.KbtnEkle = new System.Windows.Forms.Button();
            this.KbtnListele = new System.Windows.Forms.Button();
            this.YbtnArama = new System.Windows.Forms.Button();
            this.YbtnGuncelle = new System.Windows.Forms.Button();
            this.YbtnSil = new System.Windows.Forms.Button();
            this.YbtnEkle = new System.Windows.Forms.Button();
            this.YbtnListele = new System.Windows.Forms.Button();
            this.TxtDogumYili = new System.Windows.Forms.TextBox();
            this.TxtYazarTur = new System.Windows.Forms.TextBox();
            this.TxtYazarSoyadi = new System.Windows.Forms.TextBox();
            this.TxtYazarAdi = new System.Windows.Forms.TextBox();
            this.txtYazarNo = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtArama = new System.Windows.Forms.TextBox();
            this.TxtAraKitap = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtAraYazar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAliciNo
            // 
            this.TxtAliciNo.Location = new System.Drawing.Point(98, 435);
            this.TxtAliciNo.Name = "TxtAliciNo";
            this.TxtAliciNo.Size = new System.Drawing.Size(100, 22);
            this.TxtAliciNo.TabIndex = 0;
            // 
            // AbtnListele
            // 
            this.AbtnListele.Location = new System.Drawing.Point(216, 434);
            this.AbtnListele.Name = "AbtnListele";
            this.AbtnListele.Size = new System.Drawing.Size(75, 23);
            this.AbtnListele.TabIndex = 1;
            this.AbtnListele.Text = "Listele";
            this.AbtnListele.UseVisualStyleBackColor = true;
            this.AbtnListele.Click += new System.EventHandler(this.AbtnListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ALICI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(913, 387);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "aliciNo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "aliciAdi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "aliciSoyadi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "adresİl:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "kartNo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "kitapNo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(321, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "KİTAP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "kitapAdi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "sayfa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "tür:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(323, 547);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "yazar:";
            // 
            // TxtAliciAdi
            // 
            this.TxtAliciAdi.Location = new System.Drawing.Point(98, 463);
            this.TxtAliciAdi.Name = "TxtAliciAdi";
            this.TxtAliciAdi.Size = new System.Drawing.Size(100, 22);
            this.TxtAliciAdi.TabIndex = 27;
            // 
            // TxtAliciSoyadi
            // 
            this.TxtAliciSoyadi.Location = new System.Drawing.Point(98, 487);
            this.TxtAliciSoyadi.Name = "TxtAliciSoyadi";
            this.TxtAliciSoyadi.Size = new System.Drawing.Size(100, 22);
            this.TxtAliciSoyadi.TabIndex = 28;
            // 
            // TxtAdresil
            // 
            this.TxtAdresil.Location = new System.Drawing.Point(99, 515);
            this.TxtAdresil.Name = "TxtAdresil";
            this.TxtAdresil.Size = new System.Drawing.Size(100, 22);
            this.TxtAdresil.TabIndex = 29;
            // 
            // TxtKartNo
            // 
            this.TxtKartNo.Location = new System.Drawing.Point(98, 542);
            this.TxtKartNo.Name = "TxtKartNo";
            this.TxtKartNo.Size = new System.Drawing.Size(100, 22);
            this.TxtKartNo.TabIndex = 30;
            // 
            // TxtKitapNo
            // 
            this.TxtKitapNo.Location = new System.Drawing.Point(389, 434);
            this.TxtKitapNo.Name = "TxtKitapNo";
            this.TxtKitapNo.Size = new System.Drawing.Size(100, 22);
            this.TxtKitapNo.TabIndex = 31;
            // 
            // TxtKitapAdi
            // 
            this.TxtKitapAdi.Location = new System.Drawing.Point(389, 464);
            this.TxtKitapAdi.Name = "TxtKitapAdi";
            this.TxtKitapAdi.Size = new System.Drawing.Size(100, 22);
            this.TxtKitapAdi.TabIndex = 32;
            // 
            // TxtTur
            // 
            this.TxtTur.Location = new System.Drawing.Point(389, 492);
            this.TxtTur.Name = "TxtTur";
            this.TxtTur.Size = new System.Drawing.Size(100, 22);
            this.TxtTur.TabIndex = 33;
            // 
            // TxtSayfa
            // 
            this.TxtSayfa.Location = new System.Drawing.Point(389, 520);
            this.TxtSayfa.Name = "TxtSayfa";
            this.TxtSayfa.Size = new System.Drawing.Size(100, 22);
            this.TxtSayfa.TabIndex = 34;
            // 
            // TxtYazar
            // 
            this.TxtYazar.Location = new System.Drawing.Point(389, 550);
            this.TxtYazar.Name = "TxtYazar";
            this.TxtYazar.Size = new System.Drawing.Size(100, 22);
            this.TxtYazar.TabIndex = 35;
            // 
            // AbtnEkle
            // 
            this.AbtnEkle.Location = new System.Drawing.Point(216, 463);
            this.AbtnEkle.Name = "AbtnEkle";
            this.AbtnEkle.Size = new System.Drawing.Size(75, 23);
            this.AbtnEkle.TabIndex = 37;
            this.AbtnEkle.Text = "Ekle";
            this.AbtnEkle.UseVisualStyleBackColor = true;
            this.AbtnEkle.Click += new System.EventHandler(this.AbtnEkle_Click);
            // 
            // AbtnSil
            // 
            this.AbtnSil.Location = new System.Drawing.Point(216, 492);
            this.AbtnSil.Name = "AbtnSil";
            this.AbtnSil.Size = new System.Drawing.Size(75, 23);
            this.AbtnSil.TabIndex = 38;
            this.AbtnSil.Text = "Sil";
            this.AbtnSil.UseVisualStyleBackColor = true;
            this.AbtnSil.Click += new System.EventHandler(this.AbtnSil_Click);
            // 
            // AbtnGuncelle
            // 
            this.AbtnGuncelle.Location = new System.Drawing.Point(216, 521);
            this.AbtnGuncelle.Name = "AbtnGuncelle";
            this.AbtnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.AbtnGuncelle.TabIndex = 39;
            this.AbtnGuncelle.Text = "Güncelle";
            this.AbtnGuncelle.UseVisualStyleBackColor = true;
            this.AbtnGuncelle.Click += new System.EventHandler(this.AbtnGuncelle_Click);
            // 
            // AbtnArama
            // 
            this.AbtnArama.Location = new System.Drawing.Point(216, 547);
            this.AbtnArama.Name = "AbtnArama";
            this.AbtnArama.Size = new System.Drawing.Size(75, 23);
            this.AbtnArama.TabIndex = 40;
            this.AbtnArama.Text = "Arama";
            this.AbtnArama.UseVisualStyleBackColor = true;
            this.AbtnArama.Click += new System.EventHandler(this.AbtnArama_Click);
            // 
            // KbtnArama
            // 
            this.KbtnArama.Location = new System.Drawing.Point(505, 548);
            this.KbtnArama.Name = "KbtnArama";
            this.KbtnArama.Size = new System.Drawing.Size(75, 23);
            this.KbtnArama.TabIndex = 46;
            this.KbtnArama.Text = "Arama";
            this.KbtnArama.UseVisualStyleBackColor = true;
            this.KbtnArama.Click += new System.EventHandler(this.KbtnArama_Click);
            // 
            // KbtnGuncelle
            // 
            this.KbtnGuncelle.Location = new System.Drawing.Point(505, 522);
            this.KbtnGuncelle.Name = "KbtnGuncelle";
            this.KbtnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.KbtnGuncelle.TabIndex = 45;
            this.KbtnGuncelle.Text = "Güncelle";
            this.KbtnGuncelle.UseVisualStyleBackColor = true;
            this.KbtnGuncelle.Click += new System.EventHandler(this.KbtnGuncelle_Click);
            // 
            // KbtnSil
            // 
            this.KbtnSil.Location = new System.Drawing.Point(505, 493);
            this.KbtnSil.Name = "KbtnSil";
            this.KbtnSil.Size = new System.Drawing.Size(75, 23);
            this.KbtnSil.TabIndex = 44;
            this.KbtnSil.Text = "Sil";
            this.KbtnSil.UseVisualStyleBackColor = true;
            this.KbtnSil.Click += new System.EventHandler(this.KbtnSil_Click);
            // 
            // KbtnEkle
            // 
            this.KbtnEkle.Location = new System.Drawing.Point(505, 464);
            this.KbtnEkle.Name = "KbtnEkle";
            this.KbtnEkle.Size = new System.Drawing.Size(75, 23);
            this.KbtnEkle.TabIndex = 43;
            this.KbtnEkle.Text = "Ekle";
            this.KbtnEkle.UseVisualStyleBackColor = true;
            this.KbtnEkle.Click += new System.EventHandler(this.KbtnEkle_Click);
            // 
            // KbtnListele
            // 
            this.KbtnListele.Location = new System.Drawing.Point(505, 435);
            this.KbtnListele.Name = "KbtnListele";
            this.KbtnListele.Size = new System.Drawing.Size(75, 23);
            this.KbtnListele.TabIndex = 42;
            this.KbtnListele.Text = "Listele";
            this.KbtnListele.UseVisualStyleBackColor = true;
            this.KbtnListele.Click += new System.EventHandler(this.KbtnListele_Click);
            // 
            // YbtnArama
            // 
            this.YbtnArama.Location = new System.Drawing.Point(840, 548);
            this.YbtnArama.Name = "YbtnArama";
            this.YbtnArama.Size = new System.Drawing.Size(75, 23);
            this.YbtnArama.TabIndex = 62;
            this.YbtnArama.Text = "Arama";
            this.YbtnArama.UseVisualStyleBackColor = true;
            this.YbtnArama.Click += new System.EventHandler(this.YbtnArama_Click);
            // 
            // YbtnGuncelle
            // 
            this.YbtnGuncelle.Location = new System.Drawing.Point(840, 522);
            this.YbtnGuncelle.Name = "YbtnGuncelle";
            this.YbtnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.YbtnGuncelle.TabIndex = 61;
            this.YbtnGuncelle.Text = "Güncelle";
            this.YbtnGuncelle.UseVisualStyleBackColor = true;
            this.YbtnGuncelle.Click += new System.EventHandler(this.YbtnGuncelle_Click);
            // 
            // YbtnSil
            // 
            this.YbtnSil.Location = new System.Drawing.Point(840, 492);
            this.YbtnSil.Name = "YbtnSil";
            this.YbtnSil.Size = new System.Drawing.Size(75, 23);
            this.YbtnSil.TabIndex = 60;
            this.YbtnSil.Text = "Sil";
            this.YbtnSil.UseVisualStyleBackColor = true;
            this.YbtnSil.Click += new System.EventHandler(this.YbtnSil_Click);
            // 
            // YbtnEkle
            // 
            this.YbtnEkle.Location = new System.Drawing.Point(840, 464);
            this.YbtnEkle.Name = "YbtnEkle";
            this.YbtnEkle.Size = new System.Drawing.Size(75, 23);
            this.YbtnEkle.TabIndex = 59;
            this.YbtnEkle.Text = "Ekle";
            this.YbtnEkle.UseVisualStyleBackColor = true;
            this.YbtnEkle.Click += new System.EventHandler(this.YbtnEkle_Click);
            // 
            // YbtnListele
            // 
            this.YbtnListele.Location = new System.Drawing.Point(840, 435);
            this.YbtnListele.Name = "YbtnListele";
            this.YbtnListele.Size = new System.Drawing.Size(75, 23);
            this.YbtnListele.TabIndex = 58;
            this.YbtnListele.Text = "Listele";
            this.YbtnListele.UseVisualStyleBackColor = true;
            this.YbtnListele.Click += new System.EventHandler(this.YbtnListele_Click);
            // 
            // TxtDogumYili
            // 
            this.TxtDogumYili.Location = new System.Drawing.Point(713, 550);
            this.TxtDogumYili.Name = "TxtDogumYili";
            this.TxtDogumYili.Size = new System.Drawing.Size(100, 22);
            this.TxtDogumYili.TabIndex = 57;
            // 
            // TxtYazarTur
            // 
            this.TxtYazarTur.Location = new System.Drawing.Point(713, 521);
            this.TxtYazarTur.Name = "TxtYazarTur";
            this.TxtYazarTur.Size = new System.Drawing.Size(100, 22);
            this.TxtYazarTur.TabIndex = 56;
            // 
            // TxtYazarSoyadi
            // 
            this.TxtYazarSoyadi.Location = new System.Drawing.Point(713, 491);
            this.TxtYazarSoyadi.Name = "TxtYazarSoyadi";
            this.TxtYazarSoyadi.Size = new System.Drawing.Size(100, 22);
            this.TxtYazarSoyadi.TabIndex = 55;
            // 
            // TxtYazarAdi
            // 
            this.TxtYazarAdi.Location = new System.Drawing.Point(713, 463);
            this.TxtYazarAdi.Name = "TxtYazarAdi";
            this.TxtYazarAdi.Size = new System.Drawing.Size(100, 22);
            this.TxtYazarAdi.TabIndex = 54;
            // 
            // txtYazarNo
            // 
            this.txtYazarNo.Location = new System.Drawing.Point(713, 436);
            this.txtYazarNo.Name = "txtYazarNo";
            this.txtYazarNo.Size = new System.Drawing.Size(100, 22);
            this.txtYazarNo.TabIndex = 53;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(623, 547);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 17);
            this.label25.TabIndex = 52;
            this.label25.Text = "dogumYili:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(623, 492);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 17);
            this.label26.TabIndex = 51;
            this.label26.Text = "yazarSoyadi:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(624, 521);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 17);
            this.label27.TabIndex = 50;
            this.label27.Text = "tür:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(623, 463);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 17);
            this.label28.TabIndex = 49;
            this.label28.Text = "yazarAdi:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.Location = new System.Drawing.Point(621, 401);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 25);
            this.label29.TabIndex = 48;
            this.label29.Text = "YAZAR";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(623, 434);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(65, 17);
            this.label30.TabIndex = 47;
            this.label30.Text = "yazarNo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 577);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 17);
            this.label13.TabIndex = 63;
            this.label13.Text = "Aranacak Alıcı:";
            // 
            // TxtArama
            // 
            this.TxtArama.Location = new System.Drawing.Point(122, 574);
            this.TxtArama.Name = "TxtArama";
            this.TxtArama.Size = new System.Drawing.Size(100, 22);
            this.TxtArama.TabIndex = 64;
            // 
            // TxtAraKitap
            // 
            this.TxtAraKitap.Location = new System.Drawing.Point(431, 577);
            this.TxtAraKitap.Name = "TxtAraKitap";
            this.TxtAraKitap.Size = new System.Drawing.Size(100, 22);
            this.TxtAraKitap.TabIndex = 66;
            this.TxtAraKitap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(324, 580);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 17);
            this.label14.TabIndex = 65;
            this.label14.Text = "Aranacak Kitap:";
            // 
            // TxtAraYazar
            // 
            this.TxtAraYazar.Location = new System.Drawing.Point(746, 580);
            this.TxtAraYazar.Name = "TxtAraYazar";
            this.TxtAraYazar.Size = new System.Drawing.Size(100, 22);
            this.TxtAraYazar.TabIndex = 68;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(627, 583);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 17);
            this.label15.TabIndex = 67;
            this.label15.Text = "Aranacak Yazar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 618);
            this.Controls.Add(this.TxtAraYazar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtAraKitap);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtArama);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.YbtnArama);
            this.Controls.Add(this.YbtnGuncelle);
            this.Controls.Add(this.YbtnSil);
            this.Controls.Add(this.YbtnEkle);
            this.Controls.Add(this.YbtnListele);
            this.Controls.Add(this.TxtDogumYili);
            this.Controls.Add(this.TxtYazarTur);
            this.Controls.Add(this.TxtYazarSoyadi);
            this.Controls.Add(this.TxtYazarAdi);
            this.Controls.Add(this.txtYazarNo);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.KbtnArama);
            this.Controls.Add(this.KbtnGuncelle);
            this.Controls.Add(this.KbtnSil);
            this.Controls.Add(this.KbtnEkle);
            this.Controls.Add(this.KbtnListele);
            this.Controls.Add(this.AbtnArama);
            this.Controls.Add(this.AbtnGuncelle);
            this.Controls.Add(this.AbtnSil);
            this.Controls.Add(this.AbtnEkle);
            this.Controls.Add(this.TxtYazar);
            this.Controls.Add(this.TxtSayfa);
            this.Controls.Add(this.TxtTur);
            this.Controls.Add(this.TxtKitapAdi);
            this.Controls.Add(this.TxtKitapNo);
            this.Controls.Add(this.TxtKartNo);
            this.Controls.Add(this.TxtAdresil);
            this.Controls.Add(this.TxtAliciSoyadi);
            this.Controls.Add(this.TxtAliciAdi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AbtnListele);
            this.Controls.Add(this.TxtAliciNo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAliciNo;
        private System.Windows.Forms.Button AbtnListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.TextBox TxtAliciAdi;
        private System.Windows.Forms.TextBox TxtAliciSoyadi;
        private System.Windows.Forms.TextBox TxtAdresil;
        private System.Windows.Forms.TextBox TxtKartNo;
        private System.Windows.Forms.TextBox TxtKitapNo;
        private System.Windows.Forms.TextBox TxtKitapAdi;
        private System.Windows.Forms.TextBox TxtTur;
        private System.Windows.Forms.TextBox TxtSayfa;
        private System.Windows.Forms.TextBox TxtYazar;
        private System.Windows.Forms.Button AbtnEkle;
        private System.Windows.Forms.Button AbtnSil;
        private System.Windows.Forms.Button AbtnGuncelle;
        private System.Windows.Forms.Button AbtnArama;
        private System.Windows.Forms.Button KbtnArama;
        private System.Windows.Forms.Button KbtnGuncelle;
        private System.Windows.Forms.Button KbtnSil;
        private System.Windows.Forms.Button KbtnEkle;
        private System.Windows.Forms.Button KbtnListele;
        private System.Windows.Forms.Button YbtnArama;
        private System.Windows.Forms.Button YbtnGuncelle;
        private System.Windows.Forms.Button YbtnSil;
        private System.Windows.Forms.Button YbtnEkle;
        private System.Windows.Forms.Button YbtnListele;
        private System.Windows.Forms.TextBox TxtDogumYili;
        private System.Windows.Forms.TextBox TxtYazarTur;
        private System.Windows.Forms.TextBox TxtYazarSoyadi;
        private System.Windows.Forms.TextBox TxtYazarAdi;
        private System.Windows.Forms.TextBox txtYazarNo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtArama;
        private System.Windows.Forms.TextBox TxtAraKitap;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtAraYazar;
        private System.Windows.Forms.Label label15;
    }
}

