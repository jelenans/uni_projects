using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvidencijaAviona.Model
{
   public class Let
    {
        private Avion avion;
        private String polaziste;
        private String odrediste;
        private DateTime datPoletanja;

        public Let(Avion avion, String polaziste, String odrediste, DateTime datPoletanja)
        {
            this.avion = avion;
            this.polaziste = polaziste;
            this.odrediste = odrediste;
            this.datPoletanja = datPoletanja;

        }

        #region GETTERI/SETTERI
        public Avion Avion
        {
            get
            {
                return this.avion; 
            }
            set
            {
                this.avion = value;
            }
        }

        public String Polaziste
        {
            get
            {
                return this.polaziste;
            }
            set
            {
                this.polaziste = value;
            }
        }

        public String Odrediste
        {
            get
            {
                return this.odrediste;
            }
            set
            {
                this.odrediste = value;
            }
        }

        public DateTime DatPoletanja
        {
            get
            {
                return this.datPoletanja;
            }
            set
            {
                this.datPoletanja = value;
            }
        }

        #endregion
    }
}
