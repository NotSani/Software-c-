using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanino_Abbigliamento
{
    public class clsPantaloni : clsIndumenti
    {
        private string pCod;
        private string pTipo; //jeans, felpati, leggins
        private uint pTaglia; //44 , 46 , 48, 50, 52, 54, 56, 58
        private string pLunghezza; //lunghi, corti, pinocchietti
        private string pVestibilita; //slim, skiny

        public clsPantaloni()
        {
            pTipo = string.Empty;
            pTaglia = 0;
            pLunghezza = string.Empty;
            pVestibilita = string.Empty;
        }
        public string getCod()
        {
            string s = "" + pTipo[0]+ pTaglia + pLunghezza[0]+ pVestibilita[0];
            return s;
        }

        public string Cod
        {
            get { return pCod; }
            set { pCod = value; }
        }

        public string Tipo
        {
            get { return pTipo; }
            set { pTipo = value; }
        }

        public uint Taglia
        {
            get { return pTaglia; }
            set { pTaglia = value; }
        }

        public string Lunghezza
        {
            get { return pLunghezza; }
            set { pLunghezza = value; }
        }

        public string Vestibilita
        {
            get { return pVestibilita; }
            set { pVestibilita = value; }
        }

    }
}
