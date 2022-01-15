using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanino_Abbigliamento
{
    public class clsBorse : clsIndumenti
    {
        private string pCod;
        private string pTipo;
        private string pTaglia;
        private string pStagione;


        public clsBorse()
        {
            pTipo = string.Empty;
            pTaglia = string.Empty;
            pStagione = string.Empty;
        }

        public string getCod()
        {
            string s = "" + pTipo[0]  + pTaglia[0]+ pStagione[0] ;
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

        public string Taglia
        {
            get { return pTaglia; }
            set { pTaglia = value; }
        }

        public string Stagione
        {
            get { return pStagione; }
            set { pStagione = value; }
        }

    }
}
