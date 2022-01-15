using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanino_Abbigliamento
{
    public class clsMaglie : clsIndumenti
    {
        private string pCod;
        private string pTipo; //felpa, t-shirt, polo. canotta
        private string pTaglia;
        private string pManica;
        private string pApertura; //zip, pottoni etc
        private int lenght;

        public clsMaglie(){
            pCod = string.Empty;
            pTipo = string.Empty;
            pTaglia = string.Empty;
            pManica = string.Empty;
            pApertura = string.Empty;
            lenght++;
        }

        public string getCod()
        {
            string s = "" + pTipo[0]+ pTaglia[0]+ pManica[0]+ pApertura[0];
            return s;
        }

        public string Cod
        {
            get { return pCod; }
            set { pCod = value; }
        }

        public int Lenght(){
            return lenght;
        }

        public string Tipo
        {
            get { return pTipo; }
            set { pTipo = value; }
        }

        public string Taglia
        {
            get { return pTaglia; }
            set { pTaglia = value; }
        }

        public string Manica
        {
            get { return pManica; }
            set { pManica = value; }
        }

        public string Apertura
        {
            get { return pApertura; }
            set { pApertura = value; }
        }


    }
}
