using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
//using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace EvidencijaAviona.Model
{
    [Serializable]
    public class Avion : EvidencijaAviona.Model.IAvion
    {
        private int brClanovaPosade;
        private Guid oznaka;
        private String kljuc;

        private String oznaka1;

        public String Oznaka1
        {
            get { return oznaka1; }
            set { oznaka1 = value; }
        }
        private int oznaka2;

        public int Oznaka2
        {
            get { return oznaka2; }
            set { oznaka2 = value; }
        }

        private int tezina;
        private String status;
        bool isSelected;

        public bool IsSelected
        {
            get { return true; }
            set { isSelected = value; }
        }

        private DateTime datTehPregled = DateTime.Now;
        private Boolean spremanZaLet;
        private String tipAviona = "teretni";
        private int teretKapac;
        private int maxBrPutnika;
        private List<String> posada;
        private int maxBrzina;
        private List<Let> letovi;
        private String slika;

          

        #region GETTERI/SETTERI


        public String Slika
        {
            get { return slika; }
            set { slika = value; }
        }

        public int BrClanovaPosade
        {
            get { return brClanovaPosade; }
            set { brClanovaPosade = value; }
        }

        public Guid Oznaka
        {

            get
            {
                return this.oznaka;
            }

            set
            {
                this.oznaka = value;
            }
        }

        public int Tezina
        {

            get
            {
                return this.tezina;
            }

            set
            {
                this.tezina = value;
            }
        }


        public String Kljuc
        {
            get { return oznaka1 + "-" + oznaka2.ToString(); }
            set { kljuc = value; }
        }
        public String Status
        {
            get
            {
                if (this.SpremanZaLet==true)
                    return "Spreman za let";
                else
                    return "Nespreman za let";
            }
            set { status = value; }
        }
        public int TeretKapac
        {
            get { return teretKapac; }
            set { teretKapac = value; }
        }

        public int MaxBrPutnika
        {
            get { return maxBrPutnika; }
            set { maxBrPutnika = value; }
        }

        public int MaxBrzina
        {
            get { return maxBrzina; }
            set { maxBrzina = value; }
        }

        public DateTime DatTehPregled
        {
            get
            {
                return this.datTehPregled;
            }

            set
            {
                this.datTehPregled = value;
            }
        }

        public Boolean SpremanZaLet
        {
            get
            {
                return this.spremanZaLet;
            }

            set
            {
                this.spremanZaLet = value;
            }
        }
        public String SpremanZaLet2
        {
            get
            {
                if (this.spremanZaLet == true)
                    return "Spreman za let";
                else
                    return "Nespreman za let";
            }

        }
        public String TipAviona
        {
            get
            {
                return this.tipAviona;
            }
            set
            {
                this.tipAviona = value;
            }
        }



        public List<String> Posada
        {
            get
            {
                return this.posada;
            }
            set
            {
                this.posada = value;
            }
        }



        public List<Let> Letovi
        {
            get
            {
                return this.letovi;
            }
            set
            {
                this.letovi = value;
            }
        }

        #endregion; 


    }
}
