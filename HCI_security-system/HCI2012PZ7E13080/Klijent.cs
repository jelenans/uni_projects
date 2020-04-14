using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI2012PZ7E13080
{

    [Serializable]
    public class Klijent
    {



        private String sifra;
        private String ime;
        private String prezime;
        private String jmbg;
        private String pol;
        private DateTime datUgovora;
        private String delatnost;
        private String kategorija;


        #region KONTRUKTORI

        public Klijent()
        {
            this.sifra = "";
            this.ime = "";
            this.prezime = "";
            this.jmbg = "";
            this.pol = "";
            this.datUgovora = DateTime.Today;
            this.delatnost="";
            this.kategorija = "";
        }



        public Klijent(String sifra,String ime, String prezime, String jmbg, String pol, DateTime datUgovora,
            String delatnost, String kategorija)
        {

            this.sifra = sifra;
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.pol = pol;
            this.datUgovora = DateTime.Today;
            this.delatnost = delatnost;
            this.kategorija = kategorija;


        }



        #endregion

        #region GETTERI I SETTERI

        public String Kategorija
        {
            get { return kategorija; }
            set { kategorija = value; }
        }


        public String Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }
        

        public String Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public String Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public String Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; }
        }


        public String Pol
        {
            get { return pol; }
            set { pol = value; }
        }

        public DateTime DatUgovora
        {
            get { return datUgovora; }
            set { datUgovora = value; }
        }

        public String Delatnost
        {
            get { return delatnost; }
            set { delatnost = value; }
        }


        public String Kljuc() 
        {
            return sifra;
        }

        #endregion



  

    }
}

    
