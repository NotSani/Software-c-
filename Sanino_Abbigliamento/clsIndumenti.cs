using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanino_Abbigliamento
{
    public class clsIndumenti : clsAstratta
    {
        private string pMarca;
        private int pPrezzo;
        private string pColore;
        private string pMateriale;
        private string pGenere;

        public clsIndumenti()
        {
            pMarca = string.Empty;
            pPrezzo = 0;
            pColore = string.Empty;
            pMateriale = string.Empty;
            pGenere = string.Empty;
        }

        

        public string Marca
        {
            get { return pMarca; }
            set { pMarca = value; }
        }
        public int Prezzo
        {
            get { return pPrezzo; }
            set { pPrezzo = value; }
        }
        public string Colore
        {
            get { return pColore; }
            set { pColore = value; }
        }
        public string Materiale
        {
            get { return pMateriale; }
            set { pMateriale = value; }
        }
        public string Genere
        {
            get { return pGenere; }
            set { pGenere = value; }
        }


        public override void inserisciIndumento() { } //su file + lettura per list
        public override void modificaIndumento() { }  //su file + modifica su list
        public override void eliminaIndumento() { }  // da file + modifica list
    }
}
