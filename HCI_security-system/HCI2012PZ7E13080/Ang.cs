using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI2012PZ7E13080
{
    class Ang
    {
        private String imeiprzKlijenta;
        private String imeiprzZaposlenog;
        private DateTime datAng;
        private String sifraKlij;
        private String sifraZap;
        private DateTime datPrekidaAng;
        private String razlogAng;
        private String koment;
        private String sifra;

        #region KONSTRUKTORI

        public Ang()
        {

            this.ImeiprzZaposlenog = "";
            this.ImeiprzKlijenta = "";
            this.datAng = DateTime.Today;
            this.datPrekidaAng = DateTime.Today;
            this.razlogAng = "";
            this.koment = "";
        }

        public Ang(String imeiprzz, String imeiprzk, DateTime datang, DateTime datprekang,
        String razlog, String koment)
        {

            this.ImeiprzZaposlenog = imeiprzz;
            this.ImeiprzKlijenta = imeiprzk;
            this.datAng = datang;
            this.datPrekidaAng = datprekang;
            this.razlogAng = razlog;
            this.koment = koment;
            this.sifra = imeiprzz + imeiprzk;


        }
        #endregion

  

      

        #region GETSET
        public String ImeiprzKlijenta
        {
            get { return imeiprzKlijenta; }
            set { imeiprzKlijenta = value; }
        }

        public String ImeiprzZaposlenog
        {
            get { return imeiprzZaposlenog; }
            set { imeiprzZaposlenog = value; }
        }
        public String SifraZap
        {
            get { return sifraZap; }
            set { sifraZap = value; }
        }

        public String SifraKlij
        {
            get { return sifraKlij; }
            set { sifraKlij = value; }
        }

        public String RazlogAng
        {
            get { return razlogAng; }
            set { razlogAng = value; }
        }

        public DateTime DatAng
        {
            get { return datAng; }
            set { datAng = value; }
        }

        public DateTime DatPrekidaAng
        {
            get { return datPrekidaAng; }
            set { datPrekidaAng = value; }
        }

        public String Koment
        {
            get { return koment; }
            set { koment = value; }
        }

        public String Kljuc()
        {
            return this.sifra;
        }
        #endregion

    }


}
