namespace WindowsForms
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Achizitie = new System.Windows.Forms.TabPage();
            this.numericNumarCartiAchizitie = new System.Windows.Forms.NumericUpDown();
            this.buttonAchizitie = new System.Windows.Forms.Button();
            this.textBoxGenAchizitie = new System.Windows.Forms.TextBox();
            this.textBoxPrenumeAutorAchizitie = new System.Windows.Forms.TextBox();
            this.textBoxNumeAutorAchizitie = new System.Windows.Forms.TextBox();
            this.textBoxTitluCarteAchizitie = new System.Windows.Forms.TextBox();
            this.numarCartiAchizitie = new System.Windows.Forms.Label();
            this.genCarteAchizitie = new System.Windows.Forms.Label();
            this.prenumeAutorAchizitie = new System.Windows.Forms.Label();
            this.numeAutorAchizitie = new System.Windows.Forms.Label();
            this.titluCarteAchizitie = new System.Windows.Forms.Label();
            this.Imprumutare = new System.Windows.Forms.TabPage();
            this.labelAtentionareStareImprumut = new System.Windows.Forms.Label();
            this.butonVerificareImprumut = new System.Windows.Forms.Button();
            this.textBoxAdresaEmailCititorImprumut = new System.Windows.Forms.TextBox();
            this.textBoxAdresaCititorImprumut = new System.Windows.Forms.TextBox();
            this.textBoxPrenumeCititorImprumut = new System.Windows.Forms.TextBox();
            this.textBoxNumeCititorImprumut = new System.Windows.Forms.TextBox();
            this.adresaEmailImprumut = new System.Windows.Forms.Label();
            this.adresaCititorImprumut = new System.Windows.Forms.Label();
            this.prenumeCititorImprumut = new System.Windows.Forms.Label();
            this.numeCititorImprumut = new System.Windows.Forms.Label();
            this.Restituire = new System.Windows.Forms.TabPage();
            this.Cititori = new System.Windows.Forms.TabPage();
            this.Carti = new System.Windows.Forms.TabPage();
            this.Autori = new System.Windows.Forms.TabPage();
            this.Genuri = new System.Windows.Forms.TabPage();
            this.Review = new System.Windows.Forms.TabPage();
            this.numeCarteRestituire = new System.Windows.Forms.Label();
            this.numeAutorRestiturie = new System.Windows.Forms.Label();
            this.prenumeAutorRestituire = new System.Windows.Forms.Label();
            this.numeCititorRestituire = new System.Windows.Forms.Label();
            this.prenumeCititorRestituire = new System.Windows.Forms.Label();
            this.reviewRestituire = new System.Windows.Forms.Label();
            this.textBoxNumeCarteRestituire = new System.Windows.Forms.TextBox();
            this.textBoxNumeAutorRestituire = new System.Windows.Forms.TextBox();
            this.textBoxPrenumeAutorRestituire = new System.Windows.Forms.TextBox();
            this.textBoxNumeCititorRestituire = new System.Windows.Forms.TextBox();
            this.textBoxPrenumeCititorRestituire = new System.Windows.Forms.TextBox();
            this.textBoxReview = new System.Windows.Forms.TextBox();
            this.buttonRestituire = new System.Windows.Forms.Button();
            this.numarCititoriStatistica = new System.Windows.Forms.Label();
            this.listaCititoriStatistica = new System.Windows.Forms.Label();
            this.buttonCititoriStatistica = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numarCititoriStatistica1 = new System.Windows.Forms.Label();
            this.labelListaCititori = new System.Windows.Forms.Label();
            this.labelCartiSolicitate1 = new System.Windows.Forms.Label();
            this.celeMaiSolicitateCarti2 = new System.Windows.Forms.Label();
            this.buttonStatisticaCarti = new System.Windows.Forms.Button();
            this.buttonStatisticaAutori = new System.Windows.Forms.Button();
            this.autoriSolicitatiLabel1 = new System.Windows.Forms.Label();
            this.autorisolicitatiLabel2 = new System.Windows.Forms.Label();
            this.buttonStatisticaGenuri = new System.Windows.Forms.Button();
            this.genuriSolicitateLabel1 = new System.Windows.Forms.Label();
            this.genuriSolicitateLabel2 = new System.Windows.Forms.Label();
            this.buttonStatisticaReview = new System.Windows.Forms.Button();
            this.numeCarteStatisticaReview = new System.Windows.Forms.Label();
            this.textBoxNumeCarteStatisticaReview = new System.Windows.Forms.TextBox();
            this.labelStatisticaReview = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelGenuriImprumut = new System.Windows.Forms.Label();
            this.labelCartiImprumutare = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.imprumutaCarteButton = new System.Windows.Forms.Button();
            this.labelRezultat = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.Achizitie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumarCartiAchizitie)).BeginInit();
            this.Imprumutare.SuspendLayout();
            this.Restituire.SuspendLayout();
            this.Cititori.SuspendLayout();
            this.Carti.SuspendLayout();
            this.Autori.SuspendLayout();
            this.Genuri.SuspendLayout();
            this.Review.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Achizitie);
            this.tabControl.Controls.Add(this.Imprumutare);
            this.tabControl.Controls.Add(this.Restituire);
            this.tabControl.Controls.Add(this.Cititori);
            this.tabControl.Controls.Add(this.Carti);
            this.tabControl.Controls.Add(this.Autori);
            this.tabControl.Controls.Add(this.Genuri);
            this.tabControl.Controls.Add(this.Review);
            this.tabControl.Location = new System.Drawing.Point(2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(724, 482);
            this.tabControl.TabIndex = 0;
            // 
            // Achizitie
            // 
            this.Achizitie.Controls.Add(this.numericNumarCartiAchizitie);
            this.Achizitie.Controls.Add(this.buttonAchizitie);
            this.Achizitie.Controls.Add(this.textBoxGenAchizitie);
            this.Achizitie.Controls.Add(this.textBoxPrenumeAutorAchizitie);
            this.Achizitie.Controls.Add(this.textBoxNumeAutorAchizitie);
            this.Achizitie.Controls.Add(this.textBoxTitluCarteAchizitie);
            this.Achizitie.Controls.Add(this.numarCartiAchizitie);
            this.Achizitie.Controls.Add(this.genCarteAchizitie);
            this.Achizitie.Controls.Add(this.prenumeAutorAchizitie);
            this.Achizitie.Controls.Add(this.numeAutorAchizitie);
            this.Achizitie.Controls.Add(this.titluCarteAchizitie);
            this.Achizitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Achizitie.Location = new System.Drawing.Point(4, 22);
            this.Achizitie.Name = "Achizitie";
            this.Achizitie.Padding = new System.Windows.Forms.Padding(3);
            this.Achizitie.Size = new System.Drawing.Size(716, 456);
            this.Achizitie.TabIndex = 0;
            this.Achizitie.Text = "Achizitie";
            this.Achizitie.UseVisualStyleBackColor = true;
            // 
            // numericNumarCartiAchizitie
            // 
            this.numericNumarCartiAchizitie.AllowDrop = true;
            this.numericNumarCartiAchizitie.Location = new System.Drawing.Point(166, 267);
            this.numericNumarCartiAchizitie.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumarCartiAchizitie.Name = "numericNumarCartiAchizitie";
            this.numericNumarCartiAchizitie.Size = new System.Drawing.Size(79, 20);
            this.numericNumarCartiAchizitie.TabIndex = 11;
            this.numericNumarCartiAchizitie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNumarCartiAchizitie.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAchizitie
            // 
            this.buttonAchizitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAchizitie.Location = new System.Drawing.Point(518, 133);
            this.buttonAchizitie.Name = "buttonAchizitie";
            this.buttonAchizitie.Size = new System.Drawing.Size(121, 30);
            this.buttonAchizitie.TabIndex = 10;
            this.buttonAchizitie.Text = "Achizitioneaza";
            this.buttonAchizitie.UseVisualStyleBackColor = true;
            this.buttonAchizitie.Click += new System.EventHandler(this.buttonAchizitie_Click);
            // 
            // textBoxGenAchizitie
            // 
            this.textBoxGenAchizitie.Location = new System.Drawing.Point(165, 218);
            this.textBoxGenAchizitie.Name = "textBoxGenAchizitie";
            this.textBoxGenAchizitie.Size = new System.Drawing.Size(246, 20);
            this.textBoxGenAchizitie.TabIndex = 8;
            // 
            // textBoxPrenumeAutorAchizitie
            // 
            this.textBoxPrenumeAutorAchizitie.Location = new System.Drawing.Point(165, 162);
            this.textBoxPrenumeAutorAchizitie.Name = "textBoxPrenumeAutorAchizitie";
            this.textBoxPrenumeAutorAchizitie.Size = new System.Drawing.Size(246, 20);
            this.textBoxPrenumeAutorAchizitie.TabIndex = 7;
            // 
            // textBoxNumeAutorAchizitie
            // 
            this.textBoxNumeAutorAchizitie.Location = new System.Drawing.Point(165, 107);
            this.textBoxNumeAutorAchizitie.Name = "textBoxNumeAutorAchizitie";
            this.textBoxNumeAutorAchizitie.Size = new System.Drawing.Size(246, 20);
            this.textBoxNumeAutorAchizitie.TabIndex = 6;
            // 
            // textBoxTitluCarteAchizitie
            // 
            this.textBoxTitluCarteAchizitie.Location = new System.Drawing.Point(165, 55);
            this.textBoxTitluCarteAchizitie.Name = "textBoxTitluCarteAchizitie";
            this.textBoxTitluCarteAchizitie.Size = new System.Drawing.Size(246, 20);
            this.textBoxTitluCarteAchizitie.TabIndex = 5;
            // 
            // numarCartiAchizitie
            // 
            this.numarCartiAchizitie.AutoSize = true;
            this.numarCartiAchizitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numarCartiAchizitie.Location = new System.Drawing.Point(47, 268);
            this.numarCartiAchizitie.Name = "numarCartiAchizitie";
            this.numarCartiAchizitie.Size = new System.Drawing.Size(112, 20);
            this.numarCartiAchizitie.TabIndex = 4;
            this.numarCartiAchizitie.Text = "Numar de carti";
            // 
            // genCarteAchizitie
            // 
            this.genCarteAchizitie.AutoSize = true;
            this.genCarteAchizitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genCarteAchizitie.Location = new System.Drawing.Point(119, 218);
            this.genCarteAchizitie.Name = "genCarteAchizitie";
            this.genCarteAchizitie.Size = new System.Drawing.Size(40, 20);
            this.genCarteAchizitie.TabIndex = 3;
            this.genCarteAchizitie.Text = "Gen";
            this.genCarteAchizitie.Click += new System.EventHandler(this.genCarteAchizitie_Click);
            // 
            // prenumeAutorAchizitie
            // 
            this.prenumeAutorAchizitie.AutoSize = true;
            this.prenumeAutorAchizitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumeAutorAchizitie.Location = new System.Drawing.Point(45, 162);
            this.prenumeAutorAchizitie.Name = "prenumeAutorAchizitie";
            this.prenumeAutorAchizitie.Size = new System.Drawing.Size(114, 20);
            this.prenumeAutorAchizitie.TabIndex = 2;
            this.prenumeAutorAchizitie.Text = "Prenume autor";
            // 
            // numeAutorAchizitie
            // 
            this.numeAutorAchizitie.AutoSize = true;
            this.numeAutorAchizitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeAutorAchizitie.Location = new System.Drawing.Point(67, 107);
            this.numeAutorAchizitie.Name = "numeAutorAchizitie";
            this.numeAutorAchizitie.Size = new System.Drawing.Size(92, 20);
            this.numeAutorAchizitie.TabIndex = 1;
            this.numeAutorAchizitie.Text = "Nume autor";
            // 
            // titluCarteAchizitie
            // 
            this.titluCarteAchizitie.AutoSize = true;
            this.titluCarteAchizitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titluCarteAchizitie.Location = new System.Drawing.Point(81, 55);
            this.titluCarteAchizitie.Name = "titluCarteAchizitie";
            this.titluCarteAchizitie.Size = new System.Drawing.Size(78, 20);
            this.titluCarteAchizitie.TabIndex = 0;
            this.titluCarteAchizitie.Text = "Titlul cartii";
            // 
            // Imprumutare
            // 
            this.Imprumutare.Controls.Add(this.labelRezultat);
            this.Imprumutare.Controls.Add(this.imprumutaCarteButton);
            this.Imprumutare.Controls.Add(this.listBox1);
            this.Imprumutare.Controls.Add(this.labelCartiImprumutare);
            this.Imprumutare.Controls.Add(this.labelGenuriImprumut);
            this.Imprumutare.Controls.Add(this.comboBox1);
            this.Imprumutare.Controls.Add(this.labelAtentionareStareImprumut);
            this.Imprumutare.Controls.Add(this.butonVerificareImprumut);
            this.Imprumutare.Controls.Add(this.textBoxAdresaEmailCititorImprumut);
            this.Imprumutare.Controls.Add(this.textBoxAdresaCititorImprumut);
            this.Imprumutare.Controls.Add(this.textBoxPrenumeCititorImprumut);
            this.Imprumutare.Controls.Add(this.textBoxNumeCititorImprumut);
            this.Imprumutare.Controls.Add(this.adresaEmailImprumut);
            this.Imprumutare.Controls.Add(this.adresaCititorImprumut);
            this.Imprumutare.Controls.Add(this.prenumeCititorImprumut);
            this.Imprumutare.Controls.Add(this.numeCititorImprumut);
            this.Imprumutare.Location = new System.Drawing.Point(4, 22);
            this.Imprumutare.Name = "Imprumutare";
            this.Imprumutare.Padding = new System.Windows.Forms.Padding(3);
            this.Imprumutare.Size = new System.Drawing.Size(716, 456);
            this.Imprumutare.TabIndex = 1;
            this.Imprumutare.Text = "Imprumutare";
            this.Imprumutare.UseVisualStyleBackColor = true;
            // 
            // labelAtentionareStareImprumut
            // 
            this.labelAtentionareStareImprumut.AutoSize = true;
            this.labelAtentionareStareImprumut.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelAtentionareStareImprumut.Location = new System.Drawing.Point(217, 17);
            this.labelAtentionareStareImprumut.Name = "labelAtentionareStareImprumut";
            this.labelAtentionareStareImprumut.Size = new System.Drawing.Size(0, 13);
            this.labelAtentionareStareImprumut.TabIndex = 9;
            this.labelAtentionareStareImprumut.Visible = false;
            // 
            // butonVerificareImprumut
            // 
            this.butonVerificareImprumut.Location = new System.Drawing.Point(481, 91);
            this.butonVerificareImprumut.Name = "butonVerificareImprumut";
            this.butonVerificareImprumut.Size = new System.Drawing.Size(117, 23);
            this.butonVerificareImprumut.TabIndex = 8;
            this.butonVerificareImprumut.Text = "Verifica";
            this.butonVerificareImprumut.UseVisualStyleBackColor = true;
            this.butonVerificareImprumut.Click += new System.EventHandler(this.butonVerificareImprumut_Click);
            // 
            // textBoxAdresaEmailCititorImprumut
            // 
            this.textBoxAdresaEmailCititorImprumut.Location = new System.Drawing.Point(115, 129);
            this.textBoxAdresaEmailCititorImprumut.Name = "textBoxAdresaEmailCititorImprumut";
            this.textBoxAdresaEmailCititorImprumut.Size = new System.Drawing.Size(251, 20);
            this.textBoxAdresaEmailCititorImprumut.TabIndex = 7;
            this.textBoxAdresaEmailCititorImprumut.TextChanged += new System.EventHandler(this.textBoxAdresaEmailCititorImprumut_TextChanged);
            // 
            // textBoxAdresaCititorImprumut
            // 
            this.textBoxAdresaCititorImprumut.Location = new System.Drawing.Point(115, 103);
            this.textBoxAdresaCititorImprumut.Name = "textBoxAdresaCititorImprumut";
            this.textBoxAdresaCititorImprumut.Size = new System.Drawing.Size(251, 20);
            this.textBoxAdresaCititorImprumut.TabIndex = 6;
            // 
            // textBoxPrenumeCititorImprumut
            // 
            this.textBoxPrenumeCititorImprumut.Location = new System.Drawing.Point(115, 77);
            this.textBoxPrenumeCititorImprumut.Name = "textBoxPrenumeCititorImprumut";
            this.textBoxPrenumeCititorImprumut.Size = new System.Drawing.Size(251, 20);
            this.textBoxPrenumeCititorImprumut.TabIndex = 5;
            // 
            // textBoxNumeCititorImprumut
            // 
            this.textBoxNumeCititorImprumut.Location = new System.Drawing.Point(115, 51);
            this.textBoxNumeCititorImprumut.Name = "textBoxNumeCititorImprumut";
            this.textBoxNumeCititorImprumut.Size = new System.Drawing.Size(251, 20);
            this.textBoxNumeCititorImprumut.TabIndex = 4;
            // 
            // adresaEmailImprumut
            // 
            this.adresaEmailImprumut.AutoSize = true;
            this.adresaEmailImprumut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresaEmailImprumut.Location = new System.Drawing.Point(-4, 129);
            this.adresaEmailImprumut.Name = "adresaEmailImprumut";
            this.adresaEmailImprumut.Size = new System.Drawing.Size(106, 20);
            this.adresaEmailImprumut.TabIndex = 3;
            this.adresaEmailImprumut.Text = "Adresa e-mail";
            this.adresaEmailImprumut.Click += new System.EventHandler(this.adresaEmailImprumut_Click);
            // 
            // adresaCititorImprumut
            // 
            this.adresaCititorImprumut.AutoSize = true;
            this.adresaCititorImprumut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresaCititorImprumut.Location = new System.Drawing.Point(40, 103);
            this.adresaCititorImprumut.Name = "adresaCititorImprumut";
            this.adresaCititorImprumut.Size = new System.Drawing.Size(60, 20);
            this.adresaCititorImprumut.TabIndex = 2;
            this.adresaCititorImprumut.Text = "Adresa";
            // 
            // prenumeCititorImprumut
            // 
            this.prenumeCititorImprumut.AutoSize = true;
            this.prenumeCititorImprumut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumeCititorImprumut.Location = new System.Drawing.Point(27, 77);
            this.prenumeCititorImprumut.Name = "prenumeCititorImprumut";
            this.prenumeCititorImprumut.Size = new System.Drawing.Size(73, 20);
            this.prenumeCititorImprumut.TabIndex = 1;
            this.prenumeCititorImprumut.Text = "Prenume";
            // 
            // numeCititorImprumut
            // 
            this.numeCititorImprumut.AutoSize = true;
            this.numeCititorImprumut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeCititorImprumut.Location = new System.Drawing.Point(49, 51);
            this.numeCititorImprumut.Name = "numeCititorImprumut";
            this.numeCititorImprumut.Size = new System.Drawing.Size(51, 20);
            this.numeCititorImprumut.TabIndex = 0;
            this.numeCititorImprumut.Text = "Nume";
            this.numeCititorImprumut.Click += new System.EventHandler(this.numeCititorImprumut_Click);
            // 
            // Restituire
            // 
            this.Restituire.Controls.Add(this.buttonRestituire);
            this.Restituire.Controls.Add(this.textBoxReview);
            this.Restituire.Controls.Add(this.textBoxPrenumeCititorRestituire);
            this.Restituire.Controls.Add(this.textBoxNumeCititorRestituire);
            this.Restituire.Controls.Add(this.textBoxPrenumeAutorRestituire);
            this.Restituire.Controls.Add(this.textBoxNumeAutorRestituire);
            this.Restituire.Controls.Add(this.textBoxNumeCarteRestituire);
            this.Restituire.Controls.Add(this.reviewRestituire);
            this.Restituire.Controls.Add(this.prenumeCititorRestituire);
            this.Restituire.Controls.Add(this.numeCititorRestituire);
            this.Restituire.Controls.Add(this.prenumeAutorRestituire);
            this.Restituire.Controls.Add(this.numeAutorRestiturie);
            this.Restituire.Controls.Add(this.numeCarteRestituire);
            this.Restituire.Location = new System.Drawing.Point(4, 22);
            this.Restituire.Name = "Restituire";
            this.Restituire.Padding = new System.Windows.Forms.Padding(3);
            this.Restituire.Size = new System.Drawing.Size(716, 456);
            this.Restituire.TabIndex = 2;
            this.Restituire.Text = "Restituire";
            this.Restituire.UseVisualStyleBackColor = true;
            // 
            // Cititori
            // 
            this.Cititori.Controls.Add(this.labelListaCititori);
            this.Cititori.Controls.Add(this.numarCititoriStatistica1);
            this.Cititori.Controls.Add(this.dateTimePickerEnd);
            this.Cititori.Controls.Add(this.dateTimePickerStart);
            this.Cititori.Controls.Add(this.buttonCititoriStatistica);
            this.Cititori.Controls.Add(this.listaCititoriStatistica);
            this.Cititori.Controls.Add(this.numarCititoriStatistica);
            this.Cititori.Location = new System.Drawing.Point(4, 22);
            this.Cititori.Name = "Cititori";
            this.Cititori.Padding = new System.Windows.Forms.Padding(3);
            this.Cititori.Size = new System.Drawing.Size(716, 456);
            this.Cititori.TabIndex = 3;
            this.Cititori.Text = "Cititori";
            this.Cititori.UseVisualStyleBackColor = true;
            // 
            // Carti
            // 
            this.Carti.Controls.Add(this.buttonStatisticaCarti);
            this.Carti.Controls.Add(this.celeMaiSolicitateCarti2);
            this.Carti.Controls.Add(this.labelCartiSolicitate1);
            this.Carti.Location = new System.Drawing.Point(4, 22);
            this.Carti.Name = "Carti";
            this.Carti.Padding = new System.Windows.Forms.Padding(3);
            this.Carti.Size = new System.Drawing.Size(716, 456);
            this.Carti.TabIndex = 4;
            this.Carti.Text = "Carti";
            this.Carti.UseVisualStyleBackColor = true;
            // 
            // Autori
            // 
            this.Autori.Controls.Add(this.autorisolicitatiLabel2);
            this.Autori.Controls.Add(this.autoriSolicitatiLabel1);
            this.Autori.Controls.Add(this.buttonStatisticaAutori);
            this.Autori.Location = new System.Drawing.Point(4, 22);
            this.Autori.Name = "Autori";
            this.Autori.Padding = new System.Windows.Forms.Padding(3);
            this.Autori.Size = new System.Drawing.Size(716, 456);
            this.Autori.TabIndex = 5;
            this.Autori.Text = "Autori";
            this.Autori.UseVisualStyleBackColor = true;
            // 
            // Genuri
            // 
            this.Genuri.Controls.Add(this.genuriSolicitateLabel2);
            this.Genuri.Controls.Add(this.genuriSolicitateLabel1);
            this.Genuri.Controls.Add(this.buttonStatisticaGenuri);
            this.Genuri.Location = new System.Drawing.Point(4, 22);
            this.Genuri.Name = "Genuri";
            this.Genuri.Padding = new System.Windows.Forms.Padding(3);
            this.Genuri.Size = new System.Drawing.Size(716, 456);
            this.Genuri.TabIndex = 6;
            this.Genuri.Text = "Genuri";
            this.Genuri.UseVisualStyleBackColor = true;
            // 
            // Review
            // 
            this.Review.Controls.Add(this.labelStatisticaReview);
            this.Review.Controls.Add(this.textBoxNumeCarteStatisticaReview);
            this.Review.Controls.Add(this.numeCarteStatisticaReview);
            this.Review.Controls.Add(this.buttonStatisticaReview);
            this.Review.Location = new System.Drawing.Point(4, 22);
            this.Review.Name = "Review";
            this.Review.Padding = new System.Windows.Forms.Padding(3);
            this.Review.Size = new System.Drawing.Size(716, 456);
            this.Review.TabIndex = 7;
            this.Review.Text = "Review";
            this.Review.UseVisualStyleBackColor = true;
            // 
            // numeCarteRestituire
            // 
            this.numeCarteRestituire.AutoSize = true;
            this.numeCarteRestituire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeCarteRestituire.Location = new System.Drawing.Point(30, 49);
            this.numeCarteRestituire.Name = "numeCarteRestituire";
            this.numeCarteRestituire.Size = new System.Drawing.Size(91, 20);
            this.numeCarteRestituire.TabIndex = 0;
            this.numeCarteRestituire.Text = "Nume carte";
            // 
            // numeAutorRestiturie
            // 
            this.numeAutorRestiturie.AutoSize = true;
            this.numeAutorRestiturie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeAutorRestiturie.Location = new System.Drawing.Point(29, 87);
            this.numeAutorRestiturie.Name = "numeAutorRestiturie";
            this.numeAutorRestiturie.Size = new System.Drawing.Size(92, 20);
            this.numeAutorRestiturie.TabIndex = 1;
            this.numeAutorRestiturie.Text = "Nume autor";
            // 
            // prenumeAutorRestituire
            // 
            this.prenumeAutorRestituire.AutoSize = true;
            this.prenumeAutorRestituire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumeAutorRestituire.Location = new System.Drawing.Point(7, 130);
            this.prenumeAutorRestituire.Name = "prenumeAutorRestituire";
            this.prenumeAutorRestituire.Size = new System.Drawing.Size(114, 20);
            this.prenumeAutorRestituire.TabIndex = 2;
            this.prenumeAutorRestituire.Text = "Prenume autor";
            // 
            // numeCititorRestituire
            // 
            this.numeCititorRestituire.AutoSize = true;
            this.numeCititorRestituire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeCititorRestituire.Location = new System.Drawing.Point(28, 175);
            this.numeCititorRestituire.Name = "numeCititorRestituire";
            this.numeCititorRestituire.Size = new System.Drawing.Size(93, 20);
            this.numeCititorRestituire.TabIndex = 3;
            this.numeCititorRestituire.Text = "Nume cititor";
            // 
            // prenumeCititorRestituire
            // 
            this.prenumeCititorRestituire.AutoSize = true;
            this.prenumeCititorRestituire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumeCititorRestituire.Location = new System.Drawing.Point(3, 221);
            this.prenumeCititorRestituire.Name = "prenumeCititorRestituire";
            this.prenumeCititorRestituire.Size = new System.Drawing.Size(118, 20);
            this.prenumeCititorRestituire.TabIndex = 4;
            this.prenumeCititorRestituire.Text = "Prenume Cititor";
            // 
            // reviewRestituire
            // 
            this.reviewRestituire.AutoSize = true;
            this.reviewRestituire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewRestituire.Location = new System.Drawing.Point(61, 269);
            this.reviewRestituire.Name = "reviewRestituire";
            this.reviewRestituire.Size = new System.Drawing.Size(60, 20);
            this.reviewRestituire.TabIndex = 5;
            this.reviewRestituire.Text = "Review";
            // 
            // textBoxNumeCarteRestituire
            // 
            this.textBoxNumeCarteRestituire.Location = new System.Drawing.Point(127, 49);
            this.textBoxNumeCarteRestituire.Name = "textBoxNumeCarteRestituire";
            this.textBoxNumeCarteRestituire.Size = new System.Drawing.Size(272, 20);
            this.textBoxNumeCarteRestituire.TabIndex = 6;
            // 
            // textBoxNumeAutorRestituire
            // 
            this.textBoxNumeAutorRestituire.Location = new System.Drawing.Point(128, 87);
            this.textBoxNumeAutorRestituire.Name = "textBoxNumeAutorRestituire";
            this.textBoxNumeAutorRestituire.Size = new System.Drawing.Size(271, 20);
            this.textBoxNumeAutorRestituire.TabIndex = 7;
            // 
            // textBoxPrenumeAutorRestituire
            // 
            this.textBoxPrenumeAutorRestituire.Location = new System.Drawing.Point(128, 129);
            this.textBoxPrenumeAutorRestituire.Name = "textBoxPrenumeAutorRestituire";
            this.textBoxPrenumeAutorRestituire.Size = new System.Drawing.Size(271, 20);
            this.textBoxPrenumeAutorRestituire.TabIndex = 8;
            // 
            // textBoxNumeCititorRestituire
            // 
            this.textBoxNumeCititorRestituire.Location = new System.Drawing.Point(127, 175);
            this.textBoxNumeCititorRestituire.Name = "textBoxNumeCititorRestituire";
            this.textBoxNumeCititorRestituire.Size = new System.Drawing.Size(272, 20);
            this.textBoxNumeCititorRestituire.TabIndex = 9;
            // 
            // textBoxPrenumeCititorRestituire
            // 
            this.textBoxPrenumeCititorRestituire.Location = new System.Drawing.Point(127, 221);
            this.textBoxPrenumeCititorRestituire.Name = "textBoxPrenumeCititorRestituire";
            this.textBoxPrenumeCititorRestituire.Size = new System.Drawing.Size(272, 20);
            this.textBoxPrenumeCititorRestituire.TabIndex = 10;
            // 
            // textBoxReview
            // 
            this.textBoxReview.Location = new System.Drawing.Point(127, 269);
            this.textBoxReview.Multiline = true;
            this.textBoxReview.Name = "textBoxReview";
            this.textBoxReview.Size = new System.Drawing.Size(272, 78);
            this.textBoxReview.TabIndex = 11;
            // 
            // buttonRestituire
            // 
            this.buttonRestituire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestituire.Location = new System.Drawing.Point(265, 395);
            this.buttonRestituire.Name = "buttonRestituire";
            this.buttonRestituire.Size = new System.Drawing.Size(134, 32);
            this.buttonRestituire.TabIndex = 12;
            this.buttonRestituire.Text = "Restituie";
            this.buttonRestituire.UseVisualStyleBackColor = true;
            this.buttonRestituire.Click += new System.EventHandler(this.buttonRestituire_Click);
            // 
            // numarCititoriStatistica
            // 
            this.numarCititoriStatistica.AutoSize = true;
            this.numarCititoriStatistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numarCititoriStatistica.Location = new System.Drawing.Point(29, 165);
            this.numarCititoriStatistica.Name = "numarCititoriStatistica";
            this.numarCititoriStatistica.Size = new System.Drawing.Size(101, 20);
            this.numarCititoriStatistica.TabIndex = 0;
            this.numarCititoriStatistica.Text = "Numar cititori";
            // 
            // listaCititoriStatistica
            // 
            this.listaCititoriStatistica.AutoSize = true;
            this.listaCititoriStatistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaCititoriStatistica.Location = new System.Drawing.Point(77, 201);
            this.listaCititoriStatistica.Name = "listaCititoriStatistica";
            this.listaCititoriStatistica.Size = new System.Drawing.Size(53, 20);
            this.listaCititoriStatistica.TabIndex = 1;
            this.listaCititoriStatistica.Text = "Cititori";
            // 
            // buttonCititoriStatistica
            // 
            this.buttonCititoriStatistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCititoriStatistica.Location = new System.Drawing.Point(190, 87);
            this.buttonCititoriStatistica.Name = "buttonCititoriStatistica";
            this.buttonCititoriStatistica.Size = new System.Drawing.Size(184, 35);
            this.buttonCititoriStatistica.TabIndex = 4;
            this.buttonCititoriStatistica.Text = "Vezi Statistica Cititorilor";
            this.buttonCititoriStatistica.UseVisualStyleBackColor = true;
            this.buttonCititoriStatistica.Click += new System.EventHandler(this.buttonCititoriStatistica_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(59, 32);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 5;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(290, 32);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 6;
            // 
            // numarCititoriStatistica1
            // 
            this.numarCititoriStatistica1.AutoSize = true;
            this.numarCititoriStatistica1.Location = new System.Drawing.Point(137, 171);
            this.numarCititoriStatistica1.Name = "numarCititoriStatistica1";
            this.numarCititoriStatistica1.Size = new System.Drawing.Size(0, 13);
            this.numarCititoriStatistica1.TabIndex = 8;
            // 
            // labelListaCititori
            // 
            this.labelListaCititori.AutoSize = true;
            this.labelListaCititori.Location = new System.Drawing.Point(137, 207);
            this.labelListaCititori.Name = "labelListaCititori";
            this.labelListaCititori.Size = new System.Drawing.Size(0, 13);
            this.labelListaCititori.TabIndex = 9;
            // 
            // labelCartiSolicitate1
            // 
            this.labelCartiSolicitate1.AutoSize = true;
            this.labelCartiSolicitate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartiSolicitate1.Location = new System.Drawing.Point(58, 108);
            this.labelCartiSolicitate1.Name = "labelCartiSolicitate1";
            this.labelCartiSolicitate1.Size = new System.Drawing.Size(209, 20);
            this.labelCartiSolicitate1.TabIndex = 0;
            this.labelCartiSolicitate1.Text = "Cele mai solicitate carti sunt:";
            // 
            // celeMaiSolicitateCarti2
            // 
            this.celeMaiSolicitateCarti2.AutoSize = true;
            this.celeMaiSolicitateCarti2.Location = new System.Drawing.Point(273, 115);
            this.celeMaiSolicitateCarti2.Name = "celeMaiSolicitateCarti2";
            this.celeMaiSolicitateCarti2.Size = new System.Drawing.Size(0, 13);
            this.celeMaiSolicitateCarti2.TabIndex = 1;
            this.celeMaiSolicitateCarti2.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonStatisticaCarti
            // 
            this.buttonStatisticaCarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatisticaCarti.Location = new System.Drawing.Point(62, 46);
            this.buttonStatisticaCarti.Name = "buttonStatisticaCarti";
            this.buttonStatisticaCarti.Size = new System.Drawing.Size(141, 29);
            this.buttonStatisticaCarti.TabIndex = 2;
            this.buttonStatisticaCarti.Text = "Vezi Statistica";
            this.buttonStatisticaCarti.UseVisualStyleBackColor = true;
            this.buttonStatisticaCarti.Click += new System.EventHandler(this.buttonStatisticaCarti_Click);
            // 
            // buttonStatisticaAutori
            // 
            this.buttonStatisticaAutori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatisticaAutori.Location = new System.Drawing.Point(95, 25);
            this.buttonStatisticaAutori.Name = "buttonStatisticaAutori";
            this.buttonStatisticaAutori.Size = new System.Drawing.Size(124, 31);
            this.buttonStatisticaAutori.TabIndex = 0;
            this.buttonStatisticaAutori.Text = "Vezi statistica";
            this.buttonStatisticaAutori.UseVisualStyleBackColor = true;
            this.buttonStatisticaAutori.Click += new System.EventHandler(this.buttonStatisticaAutori_Click);
            // 
            // autoriSolicitatiLabel1
            // 
            this.autoriSolicitatiLabel1.AutoSize = true;
            this.autoriSolicitatiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoriSolicitatiLabel1.Location = new System.Drawing.Point(95, 78);
            this.autoriSolicitatiLabel1.Name = "autoriSolicitatiLabel1";
            this.autoriSolicitatiLabel1.Size = new System.Drawing.Size(208, 20);
            this.autoriSolicitatiLabel1.TabIndex = 1;
            this.autoriSolicitatiLabel1.Text = "Cei mai solicitati autori sunt :";
            // 
            // autorisolicitatiLabel2
            // 
            this.autorisolicitatiLabel2.AutoSize = true;
            this.autorisolicitatiLabel2.Location = new System.Drawing.Point(309, 83);
            this.autorisolicitatiLabel2.Name = "autorisolicitatiLabel2";
            this.autorisolicitatiLabel2.Size = new System.Drawing.Size(0, 13);
            this.autorisolicitatiLabel2.TabIndex = 2;
            // 
            // buttonStatisticaGenuri
            // 
            this.buttonStatisticaGenuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatisticaGenuri.Location = new System.Drawing.Point(72, 23);
            this.buttonStatisticaGenuri.Name = "buttonStatisticaGenuri";
            this.buttonStatisticaGenuri.Size = new System.Drawing.Size(119, 31);
            this.buttonStatisticaGenuri.TabIndex = 0;
            this.buttonStatisticaGenuri.Text = "Vezi Statistica";
            this.buttonStatisticaGenuri.UseVisualStyleBackColor = true;
            this.buttonStatisticaGenuri.Click += new System.EventHandler(this.buttonStatisticaGenuri_Click);
            // 
            // genuriSolicitateLabel1
            // 
            this.genuriSolicitateLabel1.AutoSize = true;
            this.genuriSolicitateLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genuriSolicitateLabel1.Location = new System.Drawing.Point(72, 79);
            this.genuriSolicitateLabel1.Name = "genuriSolicitateLabel1";
            this.genuriSolicitateLabel1.Size = new System.Drawing.Size(227, 20);
            this.genuriSolicitateLabel1.TabIndex = 1;
            this.genuriSolicitateLabel1.Text = "Cele mai solicitate genuri sunt :";
            // 
            // genuriSolicitateLabel2
            // 
            this.genuriSolicitateLabel2.AutoSize = true;
            this.genuriSolicitateLabel2.Location = new System.Drawing.Point(306, 85);
            this.genuriSolicitateLabel2.Name = "genuriSolicitateLabel2";
            this.genuriSolicitateLabel2.Size = new System.Drawing.Size(0, 13);
            this.genuriSolicitateLabel2.TabIndex = 2;
            // 
            // buttonStatisticaReview
            // 
            this.buttonStatisticaReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatisticaReview.Location = new System.Drawing.Point(477, 79);
            this.buttonStatisticaReview.Name = "buttonStatisticaReview";
            this.buttonStatisticaReview.Size = new System.Drawing.Size(116, 32);
            this.buttonStatisticaReview.TabIndex = 0;
            this.buttonStatisticaReview.Text = "Vezi statistica";
            this.buttonStatisticaReview.UseVisualStyleBackColor = true;
            this.buttonStatisticaReview.Click += new System.EventHandler(this.buttonStatisticaReview_Click);
            // 
            // numeCarteStatisticaReview
            // 
            this.numeCarteStatisticaReview.AutoSize = true;
            this.numeCarteStatisticaReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeCarteStatisticaReview.Location = new System.Drawing.Point(68, 83);
            this.numeCarteStatisticaReview.Name = "numeCarteStatisticaReview";
            this.numeCarteStatisticaReview.Size = new System.Drawing.Size(91, 20);
            this.numeCarteStatisticaReview.TabIndex = 1;
            this.numeCarteStatisticaReview.Text = "Nume carte";
            // 
            // textBoxNumeCarteStatisticaReview
            // 
            this.textBoxNumeCarteStatisticaReview.Location = new System.Drawing.Point(166, 82);
            this.textBoxNumeCarteStatisticaReview.Name = "textBoxNumeCarteStatisticaReview";
            this.textBoxNumeCarteStatisticaReview.Size = new System.Drawing.Size(204, 20);
            this.textBoxNumeCarteStatisticaReview.TabIndex = 2;
            // 
            // labelStatisticaReview
            // 
            this.labelStatisticaReview.AutoSize = true;
            this.labelStatisticaReview.Location = new System.Drawing.Point(72, 132);
            this.labelStatisticaReview.Name = "labelStatisticaReview";
            this.labelStatisticaReview.Size = new System.Drawing.Size(0, 13);
            this.labelStatisticaReview.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelGenuriImprumut
            // 
            this.labelGenuriImprumut.AutoSize = true;
            this.labelGenuriImprumut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenuriImprumut.Location = new System.Drawing.Point(41, 186);
            this.labelGenuriImprumut.Name = "labelGenuriImprumut";
            this.labelGenuriImprumut.Size = new System.Drawing.Size(57, 20);
            this.labelGenuriImprumut.TabIndex = 11;
            this.labelGenuriImprumut.Text = "Genuri";
            // 
            // labelCartiImprumutare
            // 
            this.labelCartiImprumutare.AutoSize = true;
            this.labelCartiImprumutare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartiImprumutare.Location = new System.Drawing.Point(72, 258);
            this.labelCartiImprumutare.Name = "labelCartiImprumutare";
            this.labelCartiImprumutare.Size = new System.Drawing.Size(42, 20);
            this.labelCartiImprumutare.TabIndex = 12;
            this.labelCartiImprumutare.Text = "Carti";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(120, 258);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 95);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // imprumutaCarteButton
            // 
            this.imprumutaCarteButton.Location = new System.Drawing.Point(385, 288);
            this.imprumutaCarteButton.Name = "imprumutaCarteButton";
            this.imprumutaCarteButton.Size = new System.Drawing.Size(128, 25);
            this.imprumutaCarteButton.TabIndex = 14;
            this.imprumutaCarteButton.Text = "Imprumuta";
            this.imprumutaCarteButton.UseVisualStyleBackColor = true;
            this.imprumutaCarteButton.Click += new System.EventHandler(this.imprumutaCarteButton_Click);
            // 
            // labelRezultat
            // 
            this.labelRezultat.AutoSize = true;
            this.labelRezultat.Location = new System.Drawing.Point(181, 387);
            this.labelRezultat.Name = "labelRezultat";
            this.labelRezultat.Size = new System.Drawing.Size(0, 13);
            this.labelRezultat.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 481);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.Achizitie.ResumeLayout(false);
            this.Achizitie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumarCartiAchizitie)).EndInit();
            this.Imprumutare.ResumeLayout(false);
            this.Imprumutare.PerformLayout();
            this.Restituire.ResumeLayout(false);
            this.Restituire.PerformLayout();
            this.Cititori.ResumeLayout(false);
            this.Cititori.PerformLayout();
            this.Carti.ResumeLayout(false);
            this.Carti.PerformLayout();
            this.Autori.ResumeLayout(false);
            this.Autori.PerformLayout();
            this.Genuri.ResumeLayout(false);
            this.Genuri.PerformLayout();
            this.Review.ResumeLayout(false);
            this.Review.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Achizitie;
        private System.Windows.Forms.TabPage Imprumutare;
        private System.Windows.Forms.TabPage Restituire;
        private System.Windows.Forms.TabPage Cititori;
        private System.Windows.Forms.TabPage Carti;
        private System.Windows.Forms.TabPage Autori;
        private System.Windows.Forms.TabPage Genuri;
        private System.Windows.Forms.TabPage Review;
        private System.Windows.Forms.Label prenumeAutorAchizitie;
        private System.Windows.Forms.Label numeAutorAchizitie;
        private System.Windows.Forms.Label titluCarteAchizitie;
        private System.Windows.Forms.Label genCarteAchizitie;
        private System.Windows.Forms.Label numarCartiAchizitie;
        private System.Windows.Forms.NumericUpDown numericNumarCartiAchizitie;
        private System.Windows.Forms.Button buttonAchizitie;
        private System.Windows.Forms.TextBox textBoxGenAchizitie;
        private System.Windows.Forms.TextBox textBoxPrenumeAutorAchizitie;
        private System.Windows.Forms.TextBox textBoxNumeAutorAchizitie;
        private System.Windows.Forms.TextBox textBoxTitluCarteAchizitie;
        private System.Windows.Forms.Label adresaEmailImprumut;
        private System.Windows.Forms.Label adresaCititorImprumut;
        private System.Windows.Forms.Label prenumeCititorImprumut;
        private System.Windows.Forms.Label numeCititorImprumut;
        private System.Windows.Forms.Button butonVerificareImprumut;
        private System.Windows.Forms.TextBox textBoxAdresaEmailCititorImprumut;
        private System.Windows.Forms.TextBox textBoxAdresaCititorImprumut;
        private System.Windows.Forms.TextBox textBoxPrenumeCititorImprumut;
        private System.Windows.Forms.TextBox textBoxNumeCititorImprumut;
        private System.Windows.Forms.Label labelAtentionareStareImprumut;
        private System.Windows.Forms.Label numeCarteRestituire;
        private System.Windows.Forms.Label prenumeCititorRestituire;
        private System.Windows.Forms.Label numeCititorRestituire;
        private System.Windows.Forms.Label prenumeAutorRestituire;
        private System.Windows.Forms.Label numeAutorRestiturie;
        private System.Windows.Forms.Label reviewRestituire;
        private System.Windows.Forms.Button buttonRestituire;
        private System.Windows.Forms.TextBox textBoxReview;
        private System.Windows.Forms.TextBox textBoxPrenumeCititorRestituire;
        private System.Windows.Forms.TextBox textBoxNumeCititorRestituire;
        private System.Windows.Forms.TextBox textBoxPrenumeAutorRestituire;
        private System.Windows.Forms.TextBox textBoxNumeAutorRestituire;
        private System.Windows.Forms.TextBox textBoxNumeCarteRestituire;
        private System.Windows.Forms.Label listaCititoriStatistica;
        private System.Windows.Forms.Label numarCititoriStatistica;
        private System.Windows.Forms.Button buttonCititoriStatistica;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label numarCititoriStatistica1;
        private System.Windows.Forms.Label labelListaCititori;
        private System.Windows.Forms.Label celeMaiSolicitateCarti2;
        private System.Windows.Forms.Label labelCartiSolicitate1;
        private System.Windows.Forms.Button buttonStatisticaCarti;
        private System.Windows.Forms.Label autorisolicitatiLabel2;
        private System.Windows.Forms.Label autoriSolicitatiLabel1;
        private System.Windows.Forms.Button buttonStatisticaAutori;
        private System.Windows.Forms.Label genuriSolicitateLabel1;
        private System.Windows.Forms.Button buttonStatisticaGenuri;
        private System.Windows.Forms.Label genuriSolicitateLabel2;
        private System.Windows.Forms.TextBox textBoxNumeCarteStatisticaReview;
        private System.Windows.Forms.Label numeCarteStatisticaReview;
        private System.Windows.Forms.Button buttonStatisticaReview;
        private System.Windows.Forms.Label labelStatisticaReview;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelGenuriImprumut;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelCartiImprumutare;
        private System.Windows.Forms.Button imprumutaCarteButton;
        private System.Windows.Forms.Label labelRezultat;
    }
}

