using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing; 
using System.Windows.Forms;

namespace HCI2012PZ7E13080
{
  
    public class Zaposleni
    {

      //  enum Stanje { odmor, trening, slobodan, na_zadatku };

        private String sifra;
        private String ime;
        private String prezime;
        private String jmbg;
        private DateTime datZaposl;
        private DateTime datIzdav;
        private String kategorija;
        private String dozvola;
        private String komentar;
        private Image slika;
        private Panel panel;
        private String stanje;

  

        #region KONSTRUKTORI
        public Zaposleni()
        {
            this.sifra = "";
            this.ime = "";
            this.prezime = "";
            this.jmbg = "";
            this.datZaposl = DateTime.Today;
            this.datIzdav = DateTime.Today;
            this.kategorija = "";
            this.komentar = "";
            this.dozvola = "";
            stanje = "";

        }


        public Zaposleni(String sifra, String ime, String prezime, String jmbg,
                         DateTime datZaposl, DateTime datIzdav, String kategorija,
            String dozvola, String komentar, Image slika, Panel panel,String stanje)
        {
            this.panel = panel;
            this.sifra = sifra;
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.datZaposl = datZaposl;
            this.datIzdav = datIzdav;
            this.kategorija = kategorija;
            this.komentar = komentar;
            this.dozvola = dozvola;
            this.slika = slika;
            this.stanje = stanje;
        }
        #endregion


        #region GETTERI i SETTERI


        public String Stanje
        {
            get { return stanje; }
            set { stanje = value; }
        }

        public Panel Panel
        {
            get { return panel; }
            set { panel = value; }
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


        public DateTime DatZaposl
        {
            get { return datZaposl; }
            set { datZaposl = value; }
        }


        public DateTime DatIzdav
        {
            get { return datIzdav; }
            set { datIzdav = value; }
        }

        public String Kategorija
        {
            get { return kategorija; }
            set { kategorija = value; }
        }


        public String Komentar
        {
            get { return komentar; }
            set { komentar = value; }
        }

        public Image Slika
        {
            get { return slika; }
            set { slika = value; }
        }


        public String Dozvola
        {
            get { return dozvola; }
            set { dozvola = value; }
        }

        public String Kljuc()
        {
            return sifra;
        }
        #endregion


        public Image postaviSliku()
        {
            Image im = slika;
            return im;
        }

        public Image postaviSlikuKat()
        {
            Image im = HCI2012PZ7E13080.Properties.Resources.security_guard_icon;
            if (kategorija.Equals("A"))
                im = HCI2012PZ7E13080.Properties.Resources.A;
            else if (kategorija.Equals("B"))
                im = HCI2012PZ7E13080.Properties.Resources.B;
            else if (kategorija.Equals("C"))
                im = HCI2012PZ7E13080.Properties.Resources.C;
            else if (kategorija.Equals("D"))
                im = HCI2012PZ7E13080.Properties.Resources.D;


            return im;
        }

        public void postaviKonteksniMeni()
        {
            if(stanje.Equals("slobodan"))
            {
                panel.ContextMenuStrip.Items[0].Enabled = false;
                panel.ContextMenuStrip.Items[1].Enabled = true;
                panel.ContextMenuStrip.Items[2].Enabled = true;
                panel.ContextMenuStrip.Items[3].Enabled = false;
    
            }
            if(stanje.Equals("odmor"))
            {
                panel.ContextMenuStrip.Items[0].Enabled = false;
                panel.ContextMenuStrip.Items[1].Enabled = false;
                panel.ContextMenuStrip.Items[2].Enabled = false;
                panel.ContextMenuStrip.Items[3].Enabled = true;

            }
            if(stanje.Equals("trening"))
            {
                panel.ContextMenuStrip.Items[0].Enabled = false;
                panel.ContextMenuStrip.Items[1].Enabled = false;
                panel.ContextMenuStrip.Items[2].Enabled = false;
                panel.ContextMenuStrip.Items[3].Enabled = true;

            }
            if (stanje.Equals("na zadatku"))
            {
                panel.ContextMenuStrip.Items[0].Enabled = true;
                panel.ContextMenuStrip.Items[1].Enabled = false;
                panel.ContextMenuStrip.Items[2].Enabled = false;
                panel.ContextMenuStrip.Items[3].Enabled = false;

            }
        }
    }
}
