using Service.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void genCarteAchizitie_Click(object sender, EventArgs e)
        {

        }

        private void buttonAchizitie_Click(object sender, EventArgs e)
        {
            BibliotecaClient bc = new BibliotecaClient();

            var titluCarte = textBoxTitluCarteAchizitie.Text;
            var numeAutor = textBoxNumeAutorAchizitie.Text;
            var prenumeAutor = textBoxPrenumeAutorAchizitie.Text;
            var gen = textBoxGenAchizitie.Text;
            var numar = (int)numericNumarCartiAchizitie.Value;
            bc.achizitie(titluCarte, gen, numeAutor, prenumeAutor, numar);
        }

        private void numeCititorImprumut_Click(object sender, EventArgs e)
        {

        }

        private void butonVerificareImprumut_Click(object sender, EventArgs e)
        {
            BibliotecaClient bc = new BibliotecaClient();
            var numeCititor = textBoxNumeCititorImprumut.Text;
            var prenumeCititor = textBoxPrenumeCititorImprumut.Text;
            var adresa = textBoxAdresaCititorImprumut.Text;
            var adresaEmail = textBoxAdresaEmailCititorImprumut.Text;

            if(bc.existaCititor(numeCititor, prenumeCititor, adresa, adresaEmail))
            {
                var stare = bc.getStareCititor(numeCititor, prenumeCititor, adresa, adresaEmail);
                string mesaj = "Atentie esti in starea : " + stare;
                labelAtentionareStareImprumut.Text = mesaj;
            }
            else
            {
                string mesaj = "Bine ai venit!";
                labelAtentionareStareImprumut.Text = mesaj;
                var cititor = bc.getCititorId(numeCititor, prenumeCititor, adresa, adresaEmail);
            }
            labelAtentionareStareImprumut.Visible = true;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
           
            var genuri = bc.getAllGens();
            DataTable dt = new DataTable();
            dt.Columns.Add("A1", typeof(int));
            dt.Columns.Add("A2");


            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "A2";
            comboBox1.ValueMember = "A1";

            foreach (var gen in genuri)
            {
                dt.Rows.Add(gen.GenId, gen.Descriere);

            }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BibliotecaClient bc = new BibliotecaClient();
            DataRowView row = (DataRowView)comboBox1.SelectedItem;
            var selectedGen = (int)row[0];
            List<string> listaNumeCarti = new List<string>();
            foreach(var carte in bc.getCartiDupaGen(selectedGen))
            {
                listaNumeCarti.Add(carte.Titlu);
            }
            listBox1.DataSource = listaNumeCarti;

        }

        private void imprumutaCarteButton_Click(object sender, EventArgs e)
        {
            var carte = listBox1.SelectedItem;
            BibliotecaClient bc = new BibliotecaClient();
            DataRowView row = (DataRowView)comboBox1.SelectedItem;
            var selectetGen = (int)row[0];
            var descriere = bc.getGenCarteDescriere(selectetGen);
            var rezultat = bc.realizareImprumut(descriere, carte.ToString(), textBoxNumeCititorImprumut.Text, textBoxPrenumeCititorImprumut.Text, textBoxAdresaCititorImprumut.Text, textBoxAdresaEmailCititorImprumut.Text);
            string mesaj = "";
            if (rezultat < 0)
            {
                 mesaj = "Atentie, cartea nu exista";    
            }
            if (rezultat == 0)
            {
                 mesaj = "Ai imprumutat cartea";
            }
            if (rezultat > 0)
            {
                 mesaj = "Cartea va fi valabila in " + rezultat + " zile";
            }
            labelRezultat.Text = mesaj; 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void adresaEmailImprumut_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAdresaEmailCititorImprumut_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRestituire_Click(object sender, EventArgs e)
        {
            BibliotecaClient bc = new BibliotecaClient();
            var numeCarte = textBoxNumeCarteRestituire.Text;
            var numeAutor = textBoxNumeAutorRestituire.Text;
            var prenumeAutor = textBoxPrenumeAutorRestituire.Text;
            var numeCititor = textBoxNumeCititorRestituire.Text;
            var prenumeCititor = textBoxPrenumeCititorRestituire.Text;
            var review = textBoxReview.Text;

            bc.restituire(numeCarte, numeAutor, prenumeAutor, numeCititor, prenumeCititor, review);

        }

        private void buttonCititoriStatistica_Click(object sender, EventArgs e)
        {
            DateTime dataStart = dateTimePickerStart.Value;
            DateTime dataEnd = dateTimePickerEnd.Value;

            BibliotecaClient bc = new BibliotecaClient();

            string listaCititori = "";
            var contor = 1;
            foreach( var cititor in bc.getCititoriPerioada(dataStart, dataEnd))
            {
                listaCititori = listaCititori + contor + ". " + cititor.Nume + " " + cititor.Prenume + "\n";
                contor++;
            }
            numarCititoriStatistica1.Text = contor.ToString();

            labelListaCititori.Text = listaCititori;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStatisticaCarti_Click(object sender, EventArgs e)
        {
            BibliotecaClient bc = new BibliotecaClient();

            string listaCarti = "";
            var contor = 1;
            foreach (var carte in bc.getCartiSolicitate())
            {
                listaCarti = listaCarti + contor + ". " + carte.Titlu + "\n";
                contor++;
            }

            celeMaiSolicitateCarti2.Text = listaCarti;
        }

        private void buttonStatisticaAutori_Click(object sender, EventArgs e)
        {

            BibliotecaClient bc = new BibliotecaClient();

            string listaAutori = "";
            var contor = 1;
            foreach (var autor in bc.getAutoriCautati())
            {
                listaAutori = listaAutori + contor + ". " + autor.Nume + " " + autor.Prenume + "\n";
                contor++;
            }

            autorisolicitatiLabel2.Text = listaAutori;
        }

        private void buttonStatisticaGenuri_Click(object sender, EventArgs e)
        {
            BibliotecaClient bc = new BibliotecaClient();


            string listaGenuri = "";
            var contor = 1;
            foreach (var gen in bc.getGenuriCautate())
            {
                listaGenuri = listaGenuri + contor + ". " + gen.Descriere +  "\n";
                contor++;
            }

            genuriSolicitateLabel2.Text = listaGenuri;
        }

        private void buttonStatisticaReview_Click(object sender, EventArgs e)
        {
            BibliotecaClient bc = new BibliotecaClient();
            var numeCarte = textBoxNumeCarteStatisticaReview.Text;

            string listaReview = "";
            var contor = 1;
            foreach (var review in bc.getReviews(bc.getCarteByName(numeCarte)))
            {
                listaReview = listaReview + contor + ". " + review.Text + "\n";
                contor++;
            }

            labelStatisticaReview.Text = listaReview; 
        }

    }
}
