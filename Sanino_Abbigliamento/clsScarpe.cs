using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanino_Abbigliamento
{
    public class clsScarpe : clsIndumenti
    {
        private string pCod;
        private string pTipologia;
        private uint pNumero;
        private string pApertura;
        private string pSuola;

        public clsScarpe()
        {
            pTipologia = string.Empty;
            pNumero = 0;
            pApertura = string.Empty;
            pSuola = string.Empty;
        }

        public string getCod()
        {
            string s = "" + pTipologia[0]+ pNumero + pApertura[0] + pSuola[0];
            return s;

        }
        public string Cod
        {
            get { return pCod; }
            set { pCod = value; }
        }

        public string Tipologia
        {
            get { return pTipologia; }
            set { pTipologia = value; }
        }

        public uint Numero
        {
            get { return pNumero; }
            set { pNumero = value; }
        }

        public string Apertura
        {
            get { return pApertura; }
            set { pApertura = value; }
        }

        public string Suola
        {
            get { return pSuola; }
            set { pSuola = value; }
        }
    }
}
