using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCI2012PZ7E13080
{
    class Angazovanja
    {
        private Dictionary<String, Ang> spisakAngazovanja = new Dictionary<String, Ang>();


        public static Angazovanja ang = new Angazovanja();
        public static Angazovanja Instanca()
        {
            return ang;
        }

   


        public Ang NadjiAng(int pozicija)
        {
            int brojac = 0;
            Dictionary<string, Ang>.Enumerator e = spisakAngazovanja.GetEnumerator();
            {
                while (e.MoveNext())
                {
                    if (brojac == pozicija)
                        break;
                    else
                        brojac++;
                }
                return e.Current.Value;
            }
        }

        
        public bool DodajAng(Ang ang)
        {

                spisakAngazovanja.Add(ang.Kljuc(), ang);


            return true;
        }

        public int BrojAng()
        {

            Dictionary<string, Ang>.Enumerator e = spisakAngazovanja.GetEnumerator();
            int brojac = 0;

            while (e.MoveNext())
            {
                brojac++;
            }

            return brojac;
        }

    }
}
