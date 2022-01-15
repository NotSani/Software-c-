using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

using Microsoft.VisualBasic;

namespace Sanino_Abbigliamento
{
    public partial class Form1 : Form
    {
        List<clsMaglie> listaMaglie = new List<clsMaglie>();
        List<clsPantaloni> listaPantaloni = new List<clsPantaloni>();
        List<clsScarpe> listaScarpe = new List<clsScarpe>();
        List<clsGiacche> listaGiacche = new List<clsGiacche>();
        List<clsBorse> listaBorse = new List<clsBorse>();
        bool creato = false;
        public Form1()
        {
            InitializeComponent();

            recuperaFile();

            txtGenere.Items.Add("Uomo");
            txtGenere.Items.Add("Donna");
            txtGenere.Items.Add("Bambino");
            txtGenere.Items.Add("Bambina");

            txtGenere1.Items.Add("Uomo");
            txtGenere1.Items.Add("Donna");
            txtGenere1.Items.Add("Bambino");
            txtGenere1.Items.Add("Bambina");

            txtGenere2.Items.Add("Uomo");
            txtGenere2.Items.Add("Donna");
            txtGenere2.Items.Add("Bambino");
            txtGenere2.Items.Add("Bambina");

            txtGenere3.Items.Add("Uomo");
            txtGenere3.Items.Add("Donna");
            txtGenere3.Items.Add("Bambino");
            txtGenere3.Items.Add("Bambina");

            txtGenere4.Items.Add("Uomo");
            txtGenere4.Items.Add("Donna");
            txtGenere4.Items.Add("Bambino");
            txtGenere4.Items.Add("Bambina");

            txtTipo.Items.Add("felpa");
            txtTipo.Items.Add("T-Shirt");
            txtTipo.Items.Add("Polo");
            txtTipo.Items.Add("Canotta");

            txtTaglia.Items.Add("XS");
            txtTaglia.Items.Add("S");
            txtTaglia.Items.Add("M");
            txtTaglia.Items.Add("L");
            txtTaglia.Items.Add("XL");
            txtTaglia.Items.Add("XXL");
            txtTaglia.Items.Add("XXXL");

            txtManica.Items.Add("Lunga");
            txtManica.Items.Add("Corta");
            txtManica.Items.Add("MezzaManica");
            txtManica.Items.Add("Smanicata");

            txtApertura.Items.Add("Zip");
            txtApertura.Items.Add("Bottoni");
            txtApertura.Items.Add("Velcro");
            txtApertura.Items.Add("Senza");


            txtTipo1.Items.Add("Jeans");
            txtTipo1.Items.Add("Felpati");
            txtTipo1.Items.Add("Leggins");
            txtTipo1.Items.Add("Classici");

            txtLunghezza.Items.Add("Lunghi");
            txtLunghezza.Items.Add("Corti");
            txtLunghezza.Items.Add("Pinocchietti");

            txtVestibilita.Items.Add("Slim");
            txtVestibilita.Items.Add("Skinny");

            txtTipologia.Items.Add("Sandali");
            txtTipologia.Items.Add("da Ginnastica");
            txtTipologia.Items.Add("Mocassini");
            txtTipologia.Items.Add("Stivali");
            txtTipologia.Items.Add("Ciabatte");

            txtApertura1.Items.Add("Lacci");
            txtApertura1.Items.Add("Velcro");
            txtApertura1.Items.Add("Zip");
            txtApertura1.Items.Add("Aperte");

            txtSuola.Items.Add("Cuoio");
            txtSuola.Items.Add("Gomma");
            txtSuola.Items.Add("Plastica");
            txtSuola.Items.Add("Legno");

            txtTipologia1.Items.Add("Impermeabile");
            txtTipologia1.Items.Add("Piumino");
            txtTipologia1.Items.Add("Giacca");
            txtTipologia1.Items.Add("Kway");
            txtTipologia1.Items.Add("Giubbotto");
            txtTipologia1.Items.Add("Cappotto");

            txtTaglia2.Items.Add("XS");
            txtTaglia2.Items.Add("S");
            txtTaglia2.Items.Add("M");
            txtTaglia2.Items.Add("L");
            txtTaglia2.Items.Add("XL");
            txtTaglia2.Items.Add("XXL");
            txtTaglia2.Items.Add("XXXL");

            txtStagione.Items.Add("Invernale");
            txtStagione.Items.Add("Estivo");
            txtStagione.Items.Add("Primaverile");


            txtTipo2.Items.Add("Tracolla");
            txtTipo2.Items.Add("Zainetto");
            txtTipo2.Items.Add("Marsupio");
            txtTipo2.Items.Add("Pochette");

            txtTaglia3.Items.Add("Piccola");
            txtTaglia3.Items.Add("Media");
            txtTaglia3.Items.Add("Grande");

            txtStagione1.Items.Add("Invernale");
            txtStagione1.Items.Add("Estivo");
            txtStagione1.Items.Add("Estivo");
        }


        /*------------------------------
        ////////CREAZIONE MAGLIE///////
        ------------------------------*/
        private void btnMaglie_Click(object sender, EventArgs e)
        {
            creaMaglie();
        }

        public void creaMaglie()
        {
            clsMaglie Maglia = new clsMaglie();

            // Controllo i Input dell Indumento
            if (txtMarca.Text == string.Empty)
            {
                txtMarca.Focus();
                MessageBox.Show("Non è stata inserita la Marca.");
            }
            else if (txtPrezzo.Value == 0)
            {
                txtPrezzo.Focus();
                MessageBox.Show("Non è stato inserito il prezzo.");
            }
            else if (txtColore.Text == string.Empty)
            {
                txtColore.Focus();
                MessageBox.Show("Non è stato inserito il Colore.");
            }
            else if (txtMateriale.Text == string.Empty)
            {
                txtGenere.Focus();
                MessageBox.Show("Non è stato inserito il Materiale.");
            }
            else if (txtGenere.Text == string.Empty)
            {
                txtGenere.Focus();
                MessageBox.Show("Non è stato inserito il Genere.");
            }

            //controllo input SPECIFICO
            else if (txtTipo.Text == string.Empty)
            {
                txtTipo.Focus();
                MessageBox.Show("Non è stato inserito il Tipo.");
            }
            else if (txtTaglia.Text == string.Empty)
            {
                txtTaglia.Focus();
                MessageBox.Show("Non è stato inserito la Taglia.");
            }
            else if (txtManica.Text == string.Empty)
            {
                txtManica.Focus();
                MessageBox.Show("Non è stato inserita la Manica.");
            }
            else if (txtApertura.Text == string.Empty)
            {
                txtApertura.Focus();
                MessageBox.Show("Non è stato inserita la Apertura.");
            }
            else
            {

                creato = true;

                Maglia.Marca = txtMarca.Text;
                Maglia.Prezzo = Convert.ToUInt16(txtPrezzo.Text);
                Maglia.Colore = txtColore.Text;
                Maglia.Materiale = txtMateriale.Text;
                Maglia.Genere = txtGenere.Text;
                Maglia.Tipo = txtTipo.Text;
                Maglia.Taglia = txtTaglia.Text;
                Maglia.Manica = txtManica.Text;
                Maglia.Apertura = txtApertura.Text;
                Maglia.Cod = Maglia.getCod();

                // Aggiungo la Nuova Auto alla Lista
                listaMaglie.Add(Maglia);

                dgvMaglie.DataSource = null;
                dgvMaglie.DataSource = listaMaglie;

                txtMarca.Text = String.Empty;
                txtPrezzo.Value = 0;
                txtColore.Text = String.Empty;
                txtMateriale.Text = String.Empty;
                txtGenere.Text = String.Empty;
                txtTipo.Text = String.Empty;
                txtTaglia.Text = String.Empty;
                txtManica.Text = String.Empty;
                txtApertura.Text = String.Empty;

            }
        }

        /*///////////////////////////*/




        /*------------------------------
        ////////CREAZIONE PATALONI//////
        ------------------------------*/
        private void btnPantaloni_Click(object sender, EventArgs e)
        {
            creaPantaloni();
        }

        public void creaPantaloni()
        {
            clsPantaloni Pantaloni = new clsPantaloni();

            // Controllo i Input dell Indumento
            if (txtMarca1.Text == string.Empty)
            {
                txtMarca1.Focus();
                MessageBox.Show("Non è stata inserita la Marca.");
            }
            else if (txtPrezzo1.Value == 0)
            {
                txtPrezzo1.Focus();
                MessageBox.Show("Non è stato inserito il prezzo.");
            }
            else if (txtColore1.Text == string.Empty)
            {
                txtColore1.Focus();
                MessageBox.Show("Non è stato inserito il Colore.");
            }
            else if (txtMateriale1.Text == string.Empty)
            {
                txtMateriale1.Focus();
                MessageBox.Show("Non è stato inserito il Materiale.");
            }
            else if (txtGenere1.Text == string.Empty)
            {
                txtGenere1.Focus();
                MessageBox.Show("Non è stato inserito il Genere.");
            }

            //controllo input SPECIFICO
            else if (txtTipo1.Text == string.Empty)
            {
                txtTipo1.Focus();
                MessageBox.Show("Non è stato inserito il Tipo.");
            }
            else if (txtTaglia1.Text == string.Empty)
            {
                txtTaglia1.Focus();
                MessageBox.Show("Non è stato inserito la Taglia.");
            }
            else if (txtLunghezza.Text == string.Empty)
            {
                txtLunghezza.Focus();
                MessageBox.Show("Non è stato inserita la Lunghezza.");
            }
            else if (txtVestibilita.Text == string.Empty)
            {
                txtVestibilita.Focus();
                MessageBox.Show("Non è stato inserita la Vestibilita.");
            }
            else
            {
                creato = true;
                Pantaloni.Marca = txtMarca1.Text;
                Pantaloni.Prezzo = Convert.ToUInt16(txtPrezzo1.Text);
                Pantaloni.Colore = txtColore1.Text;
                Pantaloni.Materiale = txtMateriale1.Text;
                Pantaloni.Genere = txtGenere1.Text;
                Pantaloni.Tipo = txtTipo1.Text;
                Pantaloni.Taglia = Convert.ToUInt32(txtTaglia1.Value);
                Pantaloni.Lunghezza = txtLunghezza.Text;
                Pantaloni.Vestibilita = txtVestibilita.Text;
                Pantaloni.Cod = Pantaloni.getCod();

                // Aggiungo la Nuova Auto alla Lista
                listaPantaloni.Add(Pantaloni);
                dgvPantaloni.DataSource = null;
                dgvPantaloni.DataSource = listaPantaloni;

                txtMarca1.Text = String.Empty;
                txtPrezzo1.Value = 0;
                txtColore1.Text = String.Empty;
                txtMateriale1.Text = String.Empty;
                txtGenere1.Text = String.Empty;
                txtTipo1.Text = String.Empty;
                txtTaglia1.Text = String.Empty;
                txtLunghezza.Text = String.Empty;
                txtVestibilita.Text = String.Empty;

            }
        }

        /*///////////////////////////*/


        /*------------------------------
        ////////CREAZIONE Scarpe///////
        ------------------------------*/
        private void btnScarpe_Click(object sender, EventArgs e)
        {
            creaScarpe();
        }

        public void creaScarpe()
        {
            clsScarpe Scarpe = new clsScarpe();

            // Controllo i Input dell Indumento
            if (txtMarca2.Text == string.Empty)
            {
                txtMarca2.Focus();
                MessageBox.Show("Non è stata inserita la Marca.");
            }
            else if (txtPrezzo2.Value == 0)
            {
                txtPrezzo2.Focus();
                MessageBox.Show("Non è stato inserito il prezzo.");
            }
            else if (txtColore2.Text == string.Empty)
            {
                txtColore2.Focus();
                MessageBox.Show("Non è stato inserito il Colore.");
            }
            else if (txtMateriale2.Text == string.Empty)
            {
                txtMateriale2.Focus();
                MessageBox.Show("Non è stato inserito il Materiale.");
            }
            else if (txtGenere2.Text == string.Empty)
            {
                txtGenere2.Focus();
                MessageBox.Show("Non è stato inserito il Genere.");
            }

            //controllo input SPECIFICO
            else if (txtTipologia.Text == string.Empty)
            {
                txtTipologia.Focus();
                MessageBox.Show("Non è stato inserita la Tipologia.");
            }
            else if (txtNumero.Text == string.Empty)
            {
                txtNumero.Focus();
                MessageBox.Show("Non è stato inserito il Numero.");
            }
            else if (txtApertura1.Text == string.Empty)
            {
                txtApertura1.Focus();
                MessageBox.Show("Non è stato inserita la Apertura.");
            }
            else if (txtSuola.Text == string.Empty)
            {
                txtSuola.Focus();
                MessageBox.Show("Non è stato inserita la Suola.");
            }
            else
            {
                creato = true;
                Scarpe.Marca = txtMarca2.Text;
                Scarpe.Prezzo = Convert.ToUInt16(txtPrezzo2.Text);
                Scarpe.Colore = txtColore2.Text;
                Scarpe.Materiale = txtMateriale2.Text;
                Scarpe.Genere = txtGenere2.Text;
                Scarpe.Tipologia = txtTipologia.Text;
                Scarpe.Numero = Convert.ToUInt32(txtNumero.Text);
                Scarpe.Apertura = txtApertura1.Text;
                Scarpe.Suola = txtSuola.Text;
                Scarpe.Cod = Scarpe.getCod();

                // Aggiungo la Nuova Auto alla Lista
                listaScarpe.Add(Scarpe);
                dgvScarpe.DataSource = null;
                dgvScarpe.DataSource = listaScarpe;

                txtMarca2.Text = String.Empty;
                txtPrezzo2.Value = 0;
                txtColore2.Text = String.Empty;
                txtMateriale2.Text = String.Empty;
                txtGenere2.Text = String.Empty;
                txtTipologia.Text = String.Empty;
                txtNumero.Value = 18;
                txtApertura1.Text = String.Empty;
                txtSuola.Text = String.Empty;


            }
        }

        /*////////////////////////////*/




        /*------------------------------
        ////////CREAZIONE GIACCHE///////
        ------------------------------*/
        private void btnGiacche_Click(object sender, EventArgs e)
        {
            creaGiacca();
        }

        public void creaGiacca()
        {
            clsGiacche Giacca = new clsGiacche();

            // Controllo i Input dell Indumento
            if (txtMarca3.Text == string.Empty)
            {
                txtMarca3.Focus();
                MessageBox.Show("Non è stata inserita la Marca.");
            }
            else if (txtPrezzo3.Value == 0)
            {
                txtPrezzo3.Focus();
                MessageBox.Show("Non è stato inserito il prezzo.");
            }
            else if (txtColore3.Text == string.Empty)
            {
                txtColore3.Focus();
                MessageBox.Show("Non è stato inserito il Colore.");
            }
            else if (txtMateriale3.Text == string.Empty)
            {
                txtMateriale3.Focus();
                MessageBox.Show("Non è stato inserito il Materiale.");
            }
            else if (txtGenere3.Text == string.Empty)
            {
                txtGenere3.Focus();
                MessageBox.Show("Non è stato inserito il Genere.");
            }

            //controllo input SPECIFICO
            else if (txtTipologia1.Text == string.Empty)
            {
                txtTipologia1.Focus();
                MessageBox.Show("Non è stato inserita la Tipologia.");
            }
            else if (txtTaglia2.Text == string.Empty)
            {
                txtTaglia2.Focus();
                MessageBox.Show("Non è stata inserita la Taglia.");
            }
            else if (txtStagione.Text == string.Empty)
            {
                txtStagione.Focus();
                MessageBox.Show("Non è stato inserita la Stagione.");
            }
            else
            {
                creato = true;
                Giacca.Marca = txtMarca3.Text;
                Giacca.Prezzo = Convert.ToUInt16(txtPrezzo3.Text);
                Giacca.Colore = txtColore3.Text;
                Giacca.Materiale = txtMateriale3.Text;
                Giacca.Genere = txtGenere3.Text;
                Giacca.Tipologia = txtTipologia1.Text;
                Giacca.Taglia = txtTaglia2.Text;
                Giacca.Stagione = txtStagione.Text;
                Giacca.Cod = Giacca.getCod();


                // Aggiungo la Nuova Auto alla Lista
                listaGiacche.Add(Giacca);
                dgvGiacche.DataSource = null;
                dgvGiacche.DataSource = listaGiacche;

                txtMarca3.Text = String.Empty;
                txtPrezzo3.Value = 0;
                txtColore3.Text = String.Empty;
                txtMateriale3.Text = String.Empty;
                txtGenere3.Text = String.Empty;
                txtTipologia1.Text = String.Empty;

                txtTaglia2.Text = String.Empty;
                txtStagione.Text = String.Empty;


            }
        }

        /*////////////////////////////*/





        /*------------------------------
        ////////CREAZIONE BORSE/////////
        ------------------------------*/

        private void btnBorse_Click(object sender, EventArgs e)
        {
            creaBorsa();
        }

        public void creaBorsa()
        {

            clsBorse Borse = new clsBorse();

            // Controllo i Input dell Indumento
            if (txtMarca4.Text == string.Empty)
            {
                txtMarca4.Focus();
                MessageBox.Show("Non è stata inserita la Marca.");
            }
            else if (txtPrezzo4.Value == 0)
            {
                txtPrezzo4.Focus();
                MessageBox.Show("Non è stato inserito il prezzo.");
            }
            else if (txtColore4.Text == string.Empty)
            {
                txtColore4.Focus();
                MessageBox.Show("Non è stato inserito il Colore.");
            }
            else if (txtMateriale4.Text == string.Empty)
            {
                txtMateriale4.Focus();
                MessageBox.Show("Non è stato inserito il Materiale.");
            }
            else if (txtGenere4.Text == string.Empty)
            {
                txtGenere4.Focus();
                MessageBox.Show("Non è stato inserito il Genere.");
            }

            //controllo input SPECIFICO
            else if (txtTipo2.Text == string.Empty)
            {
                txtTipo2.Focus();
                MessageBox.Show("Non è stato inserita la Tipo.");
            }
            else if (txtTaglia3.Text == string.Empty)
            {
                txtTaglia3.Focus();
                MessageBox.Show("Non è stata inserita la Taglia.");
            }
            else if (txtStagione1.Text == string.Empty)
            {
                txtStagione1.Focus();
                MessageBox.Show("Non è stato inserita la Stagione.");
            }
            else
            {
                creato = true;
                Borse.Marca = txtMarca4.Text;
                Borse.Prezzo = Convert.ToUInt16(txtPrezzo4.Text);
                Borse.Colore = txtColore4.Text;
                Borse.Materiale = txtMateriale4.Text;
                Borse.Genere = txtGenere4.Text;
                Borse.Tipo = txtTipo2.Text;
                Borse.Taglia = txtTaglia3.Text;
                Borse.Stagione = txtStagione1.Text;
                Borse.Cod = Borse.getCod();


                // Aggiungo la Nuova Auto alla Lista
                listaBorse.Add(Borse);
                dgvBorse.DataSource = null;
                dgvBorse.DataSource = listaBorse;

                txtMarca4.Text = String.Empty;
                txtPrezzo4.Value = 0;
                txtColore4.Text = String.Empty;
                txtMateriale4.Text = String.Empty;
                txtGenere4.Text = String.Empty;
                txtTipo2.Text = String.Empty;

                txtTaglia3.Text = String.Empty;
                txtStagione1.Text = String.Empty;

            }
        }

        /*////////////////////////////*/






        /*-------------------------------
        ////////SALVATAGGIO SU FILE//////
        -------------------------------*/
        private void btnSalva_Click(object sender, EventArgs e)
        {

            // Dichiaro il File - Apro
            TextWriter fMaglie = new StreamWriter("Maglie.txt");

            foreach (clsMaglie Maglia in listaMaglie)
            {
                fMaglie.WriteLine(Maglia.Marca + ";" +
                                  Maglia.Prezzo + ";" +
                                  Maglia.Colore + ";" +
                                  Maglia.Materiale + ";" +
                                  Maglia.Genere + ";" +
                                  Maglia.Tipo + ";" +
                                  Maglia.Taglia + ";" +
                                  Maglia.Manica + ";" +
                                  Maglia.Apertura + ";");
            }

            TextWriter fPantaloni = new StreamWriter("Pantaloni.txt");

            foreach (clsPantaloni Pantaloni in listaPantaloni)
            {
                fPantaloni.WriteLine(Pantaloni.Marca + ";" +
                                  Pantaloni.Prezzo + ";" +
                                  Pantaloni.Colore + ";" +
                                  Pantaloni.Materiale + ";" +
                                  Pantaloni.Genere + ";" +
                                  Pantaloni.Tipo + ";" +
                                  Pantaloni.Taglia + ";" +
                                  Pantaloni.Lunghezza + ";" +
                                  Pantaloni.Vestibilita + ";");
            }

            TextWriter fScarpe = new StreamWriter("Scarpe.txt");

            foreach (clsScarpe Scarpe in listaScarpe)
            {
                fScarpe.WriteLine(Scarpe.Marca + ";" +
                                  Scarpe.Prezzo + ";" +
                                  Scarpe.Colore + ";" +
                                  Scarpe.Materiale + ";" +
                                  Scarpe.Genere + ";" +
                                  Scarpe.Tipologia + ";" +
                                  Scarpe.Numero + ";" +
                                  Scarpe.Apertura + ";" +
                                  Scarpe.Suola + ";");
            }

            TextWriter fGiacche = new StreamWriter("Giacche.txt");

            foreach (clsGiacche Giacche in listaGiacche)
            {
                fGiacche.WriteLine(Giacche.Marca + ";" +
                                  Giacche.Prezzo + ";" +
                                  Giacche.Colore + ";" +
                                  Giacche.Materiale + ";" +
                                  Giacche.Genere + ";" +
                                  Giacche.Tipologia + ";" +
                                  Giacche.Taglia + ";" +
                                  Giacche.Stagione + ";");
            }

            TextWriter fBorse = new StreamWriter("Borse.txt");

            foreach (clsBorse Borse in listaBorse)
            {
                fBorse.WriteLine(Borse.Marca + ";" +
                                  Borse.Prezzo + ";" +
                                  Borse.Colore + ";" +
                                  Borse.Materiale + ";" +
                                  Borse.Genere + ";" +
                                  Borse.Tipo + ";" +
                                  Borse.Taglia + ";" +
                                  Borse.Stagione + ";");
            }

            fMaglie.Close();
            fPantaloni.Close();
            fScarpe.Close();
            fGiacche.Close();
            fBorse.Close();

            MessageBox.Show("Le Classi sono State Salvate correttamente su File");
        }

        /*////////////////////////////*/






        /*-------------------------------
        ////////SALVATAGGIO SU FILE//////
        -------------------------------*/
        private void recuperaFile()
        {
            int j = 0;
            string[] Maglie = recuperaClasse("Maglie.txt", ref j);
            for (int i = 0; i < j; i++) {
                clsMaglie Maglia = new clsMaglie();
                string[] vDati = new string[7];
                vDati = Maglie[i].Split(';');

                Maglia.Marca = vDati[0];
                Maglia.Prezzo = Convert.ToInt32(vDati[1]);
                Maglia.Colore = vDati[2];
                Maglia.Materiale = vDati[3];
                Maglia.Genere = vDati[4];
                Maglia.Tipo = vDati[5];
                Maglia.Taglia = vDati[6];
                Maglia.Manica = vDati[7];
                Maglia.Apertura = vDati[8];
                Maglia.Cod = Maglia.getCod();
                listaMaglie.Add(Maglia);
            }

            j = 0;
            string[] Pantaloni = recuperaClasse("Pantaloni.txt", ref j);
            for (int i = 0; i < j; i++)
            {
                clsPantaloni Pantalone = new clsPantaloni();
                string[] vDati = new string[100];
                vDati = Pantaloni[i].Split(';');

                Pantalone.Marca = vDati[0];
                Pantalone.Prezzo = Convert.ToInt32(vDati[1]);
                Pantalone.Colore = vDati[2];
                Pantalone.Materiale = vDati[3];
                Pantalone.Genere = vDati[4];
                Pantalone.Tipo = vDati[5];
                Pantalone.Taglia = Convert.ToUInt32(vDati[6]);
                Pantalone.Lunghezza = vDati[7];
                Pantalone.Vestibilita = vDati[8];
                Pantalone.Cod = Pantalone.getCod();
                listaPantaloni.Add(Pantalone);
            }

            j = 0;
            string[] Scarpe = recuperaClasse("Scarpe.txt", ref j);
            for (int i = 0; i < j; i++)
            {
                clsScarpe Scarpa = new clsScarpe();
                string[] vDati = new string[100];
                vDati = Scarpe[i].Split(';');

                Scarpa.Marca = vDati[0];
                Scarpa.Prezzo = Convert.ToInt32(vDati[1]);
                Scarpa.Colore = vDati[2];
                Scarpa.Materiale = vDati[3];
                Scarpa.Genere = vDati[4];
                Scarpa.Tipologia = vDati[5];
                Scarpa.Numero = Convert.ToUInt32(vDati[6]);
                Scarpa.Apertura = vDati[7];
                Scarpa.Suola = vDati[8];
                Scarpa.Cod = Scarpa.getCod();
                listaScarpe.Add(Scarpa);
            }

            j = 0;
            string[] Giacche = recuperaClasse("Giacche.txt", ref j);
            for (int i = 0; i < j; i++)
            {
                clsGiacche Giacca = new clsGiacche();
                string[] vDati = new string[100];
                vDati = Giacche[i].Split(';');

                Giacca.Marca = vDati[0];
                Giacca.Prezzo = Convert.ToInt32(vDati[1]);
                Giacca.Colore = vDati[2];
                Giacca.Materiale = vDati[3];
                Giacca.Genere = vDati[4];
                Giacca.Tipologia = vDati[5];
                Giacca.Taglia = vDati[6];
                Giacca.Stagione = vDati[7];
                Giacca.Cod = Giacca.getCod();
                listaGiacche.Add(Giacca);
            }

            j = 0;
            string[] Borse = recuperaClasse("Borse.txt", ref j);
            for (int i = 0; i < j; i++)
            {
                clsBorse Borsa = new clsBorse();
                string[] vDati = new string[100];
                vDati = Borse[i].Split(';');

                Borsa.Marca = vDati[0];
                Borsa.Prezzo = Convert.ToInt32(vDati[1]);
                Borsa.Colore = vDati[2];
                Borsa.Materiale = vDati[3];
                Borsa.Genere = vDati[4];
                Borsa.Tipo = vDati[5];
                Borsa.Taglia = vDati[6];
                Borsa.Stagione = vDati[7];
                Borsa.Cod = Borsa.getCod();
                listaBorse.Add(Borsa);
            }


            // Aggiungo la Nuova Auto alla Lista

            dgvMaglie.DataSource = null;
            dgvMaglie.DataSource = listaMaglie;

            // Aggiungo la Nuova Auto alla Lista

            dgvPantaloni.DataSource = null;
            dgvPantaloni.DataSource = listaPantaloni;

            // Aggiungo la Nuova Auto alla Lista

            dgvScarpe.DataSource = null;
            dgvScarpe.DataSource = listaScarpe;

            // Aggiungo la Nuova Auto alla Lista

            dgvGiacche.DataSource = null;
            dgvGiacche.DataSource = listaGiacche;

            // Aggiungo la Nuova Auto alla Lista

            dgvBorse.DataSource = null;
            dgvBorse.DataSource = listaBorse;
        }

        private string ricerca(ref int i)
        {
            
            string list = "";

            //ricerca del elemento
            foreach (clsMaglie maglia in listaMaglie)
                if (txtCod.Text == maglia.Cod)
                {
                    list = "Maglia";
                    return list;
                }
                else
                    i++;
            i = 0;
                foreach (clsPantaloni Pants in listaPantaloni)
                    if (txtCod.Text == Pants.Cod)
                    {
                        
                        list = "Pants";
                        return list;
                    }
                    else
                        i++;
            i = 0;
            
                foreach (clsScarpe Scarpa in listaScarpe)
                    if (txtCod.Text == Scarpa.Cod)
                    {
                        
                        list = "Scarpe";
                        return list;
                    }
                    else
                        i++;
            i = 0;
            
                foreach (clsGiacche Giacca in listaGiacche)
                    if (txtCod.Text == Giacca.Cod)
                    {
                        
                        list = "Giacche";
                        return list;
                    }
                    else
                        i++;
            i = 0;
            
                foreach (clsBorse Borsa in listaBorse)
                    if (txtCod.Text == Borsa.Cod)
                    {
                        
                        list = "Borse";
                        return list;
                    }
                    else
                        i++;
            return "";
        }
        private string[] recuperaClasse(string file, ref int i)
        {
            // Dichiaro il File - Apro
            TextReader fClasse = new StreamReader(file);

            string[] vDati = new string[100];
            // Leggere da FILE

            while (fClasse.Peek() > -1)
            {
                vDati[i] = fClasse.ReadLine();
                //MessageBox.Show(vDati[i]);
                i++;
            }


            fClasse.Close();
            return vDati;
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {

            int i = 0;

            string list = ricerca(ref i);
            

                switch (list)
                {
                    case "Maglia":
                        listaMaglie.RemoveAt(i);
                        dgvMaglie.DataSource = null;
                        dgvMaglie.DataSource = listaMaglie;
                        break;
                    case "Pants":
                        listaPantaloni.RemoveAt(i);
                        dgvPantaloni.DataSource = null;
                        dgvPantaloni.DataSource = listaPantaloni;
                        break;
                    case "Scarpe":
                        listaScarpe.RemoveAt(i);
                        dgvScarpe.DataSource = null;
                        dgvScarpe.DataSource = listaScarpe;
                        break;
                    case "Giacche":
                        listaGiacche.RemoveAt(i);
                        dgvGiacche.DataSource = null;
                        dgvGiacche.DataSource = listaGiacche;
                        break;
                    case "Borse":
                        listaBorse.RemoveAt(i);
                        dgvBorse.DataSource = null;
                        dgvBorse.DataSource = listaBorse;
                        break;
                    case "":
                        MessageBox.Show("Elemento non trovato");
                        break;
                }

            MessageBox.Show("Elemento Eliminato con Successo!");

        }

        private void btnXML_Click(object sender, EventArgs e)
        {

            XmlSerializer xmlSerMaglie = new XmlSerializer(listaMaglie.GetType());
            StreamWriter sw = new StreamWriter("Maglie.xml");

            xmlSerMaglie.Serialize(sw, listaMaglie);
            sw.Close();

            XmlSerializer xmlSerPantaloni = new XmlSerializer(listaPantaloni.GetType());
            StreamWriter swPant = new StreamWriter("Pantaloni.xml");

            xmlSerPantaloni.Serialize(swPant, listaPantaloni);
            swPant.Close();

            XmlSerializer xmlSerScarpe = new XmlSerializer(listaScarpe.GetType());
            StreamWriter swScarp = new StreamWriter("Scarpe.xml");

            xmlSerScarpe.Serialize(swScarp, listaScarpe);
            swScarp.Close();

            XmlSerializer xmlSerGiacche = new XmlSerializer(listaGiacche.GetType());
            StreamWriter swGiacch = new StreamWriter("Giacche.xml");

            xmlSerGiacche.Serialize(swGiacch, listaGiacche);
            swGiacch.Close();

            XmlSerializer xmlSerBorse = new XmlSerializer(listaBorse.GetType());
            StreamWriter swBorse = new StreamWriter("Borse.xml");

            xmlSerBorse.Serialize(swBorse, listaBorse);
            swBorse.Close();

            MessageBox.Show("XML creato con successo !!");
        }

        private void btnModifica1_Click(object sender, EventArgs e)
        {
            if (txtCod1.Text == string.Empty)
            {
                txtCod1.Focus();
                MessageBox.Show("Non è stata inserita il codice.");
            }
            int i = 0;
            bool trovato = false;
            foreach (clsMaglie maglia in listaMaglie)
                if (txtCod1.Text == maglia.Cod)
                {
                    trovato = true;
                    break;
                }
                else
                    i++;

            if (trovato == true)
            {
                creato = false;
                creaMaglie();
                if (creato == true){  //evitiamo di cancellare nel caso l'utente non aggiunga niente perche non inserisc eniente nei cmapi
                        listaMaglie.RemoveAt(i);
                        dgvMaglie.DataSource = null;
                        dgvMaglie.DataSource = listaMaglie;
                    }
            }
            else
                MessageBox.Show("Capo non trovato o Codice non valido.");



        }

        private void btnModifica2_Click(object sender, EventArgs e)
        {
            if (txtCod2.Text == string.Empty)
            {
                txtCod2.Focus();
                MessageBox.Show("Non è stata inserita il codice.");
            }
            int i = 0;
            bool trovato = false;
            foreach (clsBorse Borsa in listaBorse)
                if (txtCod2.Text == Borsa.Cod)
                {
                    trovato = true;
                    break;
                }
                else
                    i++;

            if (trovato == true)
            {
                creato = false;
                creaBorsa();
                if (creato == true){  //evitiamo di cancellare nel caso l'utente non aggiunga niente perche non inserisc eniente nei cmapi
                    listaBorse.RemoveAt(i);
                    dgvBorse.DataSource = null;
                    dgvBorse.DataSource = listaBorse;
                }
            }
            else
                MessageBox.Show("Capo non trovato o Codice non valido.");



        }

        private void btnModifica3_Click(object sender, EventArgs e)
        {
            if (txtCod3.Text == string.Empty)
            {
                txtCod3.Focus();
                MessageBox.Show("Non è stata inserita il codice.");
            }
            int i = 0;
            bool trovato = false;
            foreach (clsScarpe Scarpa in listaScarpe)
                if (txtCod3.Text == Scarpa.Cod)
                {
                    trovato = true;
                    break;
                }
                else
                    i++;

            if (trovato == true)
            {
                creato = false;
                creaScarpe();
                if (creato == true){  //evitiamo di cancellare nel caso l'utente non aggiunga niente perche non inserisc eniente nei cmapi
                    listaScarpe.RemoveAt(i);
                    dgvScarpe.DataSource = null;
                    dgvScarpe.DataSource = listaScarpe;
                }
            }
            else
                MessageBox.Show("Capo non trovato o Codice non valido.");


        }

        private void btnModifica4_Click(object sender, EventArgs e)
        {
            if (txtCod4.Text == string.Empty)
            {
                txtCod4.Focus();
                MessageBox.Show("Non è stata inserita il codice.");
            }
            int i = 0;
            bool trovato = false;
            foreach (clsGiacche Giacca in listaGiacche)
                if (txtCod4.Text == Giacca.Cod)
                {
                    trovato = true;
                    break;
                }
                else
                    i++;

            if (trovato == true)
            {
                creato = false;
                creaGiacca();
                if (creato == true)
                {  //evitiamo di cancellare nel caso l'utente non aggiunga niente perche non inserisc eniente nei cmapi
                    listaGiacche.RemoveAt(i);
                    dgvGiacche.DataSource = null;
                    dgvGiacche.DataSource = listaGiacche;
                }
            }
            else
                MessageBox.Show("Capo non trovato o Codice non valido.");


        }

        private void btnModifica5_Click(object sender, EventArgs e)
        {
            if (txtCod5.Text == string.Empty)
            {
                txtCod5.Focus();
                MessageBox.Show("Non è stata inserita il codice.");
            }
            int i = 0;
            bool trovato = false;
            foreach (clsBorse Borsa in listaBorse)
                if (txtCod5.Text == Borsa.Cod)
                {
                    trovato = true;
                    break;
                }
                else
                    i++;

            if (trovato == true)
            {
                creato = false;
                creaBorsa();
                if (creato == true)
                {  //evitiamo di cancellare nel caso l'utente non aggiunga niente perche non inserisc eniente nei cmapi
                    listaBorse.RemoveAt(i);
                    dgvBorse.DataSource = null;
                    dgvBorse.DataSource = listaBorse;
                }
            }
            else
                MessageBox.Show("Capo non trovato o Codice non valido.");

        }




        /*-------------------------------
        ////////MODIFICA FILE//////
        -------------------------------*/

        /*////////////////////////////*/







    }


}
