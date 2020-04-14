using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCI2012PZ7E13080
{
   public class spisakZaposleni
    {
        private Dictionary<String, Zaposleni> spisakZapReg1 = new Dictionary<string, Zaposleni>();
        private Dictionary<String, Zaposleni> spisakZapGr2 = new Dictionary<string, Zaposleni>();
        private Dictionary<String, Zaposleni> spisakZapGr3 = new Dictionary<string, Zaposleni>();
        private Dictionary<String, Zaposleni> spisakZapGr4 = new Dictionary<string, Zaposleni>();
        private Dictionary<String, Zaposleni> spisakZapGr5 = new Dictionary<string, Zaposleni>();

        private Dictionary<String, Zaposleni> spisakSlobZapReg1 = new Dictionary<string, Zaposleni>();

        public static spisakZaposleni sz = new spisakZaposleni();
        public static spisakZaposleni Instanca()
        {
            return sz;
        }


        #region grupa1

        public Zaposleni NadjiZap1(int pozicija)
        {
            int brojac = 0;
            Dictionary<string, Zaposleni>.Enumerator e = spisakSlobZapReg1.GetEnumerator();
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

        public Zaposleni NadjiZap1(String kljuc)
        {
            try
            {
                return spisakSlobZapReg1[kljuc];
            }
            catch (KeyNotFoundException)
            {

                Console.WriteLine("Klijent sa kljucem" + kljuc + "ne postoji.");
            }
            return null;
        }

        public void IzmeniZap1(Zaposleni z)
        {
            String sifra = z.Kljuc();

            sz.NadjiZap1(sifra).Ime = z.Ime;
            sz.NadjiZap1(sifra).Prezime = z.Prezime;
            sz.NadjiZap1(sifra).Jmbg = z.Jmbg;
            sz.NadjiZap1(sifra).Kategorija = z.Kategorija;
            sz.NadjiZap1(sifra).Komentar = z.Komentar;
            sz.NadjiZap1(sifra).Dozvola = z.Dozvola;
            sz.NadjiZap1(sifra).DatZaposl = z.DatZaposl;
            sz.NadjiZap1(sifra).Panel = z.Panel;

        }


        public bool DodajZap1(Zaposleni z)
        {
            try
            {
                spisakSlobZapReg1.Add(z.Kljuc(), z);
            }
            catch
            {
                MessageBox.Show("Klijent sa oznakom" + z.Kljuc() + "vec postoji, molimo ispravite");
                return false;
            }
            return true;
        }
 
        public int BrojZap1()
        {

            Dictionary<string, Zaposleni>.Enumerator e = spisakSlobZapReg1.GetEnumerator();
            int brojac = 0;

            while (e.MoveNext())
            {
                brojac++;
            }

            return brojac;
        }



        public void UkloniZap1(String kljuc)
        {
            spisakSlobZapReg1.Remove(kljuc);
        }
   
        #endregion

        #region grupa2

        public Zaposleni NadjiZap2(int pozicija)
        {
            int brojac = 0;
            Dictionary<string, Zaposleni>.Enumerator e = spisakZapGr2.GetEnumerator();
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

        public Zaposleni NadjiZap2(String kljuc)
        {
            try
            {
                return spisakZapGr2[kljuc];
            }
            catch (KeyNotFoundException)
            {

                Console.WriteLine("Klijent sa kljucem" + kljuc + "ne postoji.");
            }
            return null;
        }

        public void IzmeniZap2(Zaposleni z)
        {
            String sifra = z.Kljuc();

            sz.NadjiZap2(sifra).Ime = z.Ime;
            sz.NadjiZap2(sifra).Prezime = z.Prezime;
            sz.NadjiZap2(sifra).Jmbg = z.Jmbg;
            sz.NadjiZap2(sifra).Kategorija = z.Kategorija;
            sz.NadjiZap2(sifra).Komentar = z.Komentar;
            sz.NadjiZap2(sifra).Dozvola = z.Dozvola;
            sz.NadjiZap2(sifra).DatZaposl = z.DatZaposl;
            sz.NadjiZap2(sifra).Panel = z.Panel;

        }


        public bool DodajZap2(Zaposleni z)
        {
            try
            {
                spisakZapGr2.Add(z.Kljuc(), z);
            }
            catch
            {
                MessageBox.Show("Klijent sa oznakom" + z.Kljuc() + "vec postoji, molimo ispravite");
                return false;
            }
            return true;
        }

        public int BrojZap2()
        {

            Dictionary<string, Zaposleni>.Enumerator e = spisakZapGr2.GetEnumerator();
            int brojac = 0;

            while (e.MoveNext())
            {
                brojac++;
            }

            return brojac;
        }



        public void UkloniZap2(String kljuc)
        {
            spisakZapGr2.Remove(kljuc);
        }
        #endregion

        #region grupa3

        public Zaposleni NadjiZap3(int pozicija)
        {
            int brojac = 0;
            Dictionary<string, Zaposleni>.Enumerator e = spisakZapGr3.GetEnumerator();
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

        public Zaposleni NadjiZap3(String kljuc)
        {
            try
            {
                return spisakZapGr3[kljuc];
            }
            catch (KeyNotFoundException)
            {

                Console.WriteLine("Klijent sa kljucem" + kljuc + "ne postoji.");
            }
            return null;
        }

        public void IzmeniZap3(Zaposleni z)
        {
            String sifra = z.Kljuc();

            sz.NadjiZap3(sifra).Ime = z.Ime;
            sz.NadjiZap3(sifra).Prezime = z.Prezime;
            sz.NadjiZap3(sifra).Jmbg = z.Jmbg;
            sz.NadjiZap3(sifra).Kategorija = z.Kategorija;
            sz.NadjiZap3(sifra).Komentar = z.Komentar;
            sz.NadjiZap3(sifra).Dozvola = z.Dozvola;
            sz.NadjiZap3(sifra).DatZaposl = z.DatZaposl;
            sz.NadjiZap3(sifra).Panel = z.Panel;

        }


        public bool DodajZap3(Zaposleni z)
        {
            try
            {
                spisakZapGr3.Add(z.Kljuc(), z);
            }
            catch
            {
                MessageBox.Show("Klijent sa oznakom" + z.Kljuc() + "vec postoji, molimo ispravite");
                return false;
            }
            return true;
        }

        public int BrojZap3()
        {

            Dictionary<string, Zaposleni>.Enumerator e = spisakZapGr3.GetEnumerator();
            int brojac = 0;

            while (e.MoveNext())
            {
                brojac++;
            }

            return brojac;
        }



        public void UkloniZap3(String kljuc)
        {
            spisakZapGr3.Remove(kljuc);
        }

        #endregion

        #region grupa4


        public Zaposleni NadjiZap4(int pozicija)
        {
            int brojac = 0;
            Dictionary<string, Zaposleni>.Enumerator e = spisakZapGr4.GetEnumerator();
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

        public Zaposleni NadjiZap4(String kljuc)
        {
            try
            {
                return spisakZapGr4[kljuc];
            }
            catch (KeyNotFoundException)
            {

                Console.WriteLine("Klijent sa kljucem" + kljuc + "ne postoji.");
            }
            return null;
        }

        public void IzmeniZap4(Zaposleni z)
        {
            String sifra = z.Kljuc();

            sz.NadjiZap4(sifra).Ime = z.Ime;
            sz.NadjiZap4(sifra).Prezime = z.Prezime;
            sz.NadjiZap4(sifra).Jmbg = z.Jmbg;
            sz.NadjiZap4(sifra).Kategorija = z.Kategorija;
            sz.NadjiZap4(sifra).Komentar = z.Komentar;
            sz.NadjiZap4(sifra).Dozvola = z.Dozvola;
            sz.NadjiZap4(sifra).DatZaposl = z.DatZaposl;
            sz.NadjiZap4(sifra).Panel = z.Panel;

        }


        public bool DodajZap4(Zaposleni z)
        {
            try
            {
                spisakZapGr4.Add(z.Kljuc(), z);
            }
            catch
            {
                MessageBox.Show("Klijent sa oznakom" + z.Kljuc() + "vec postoji, molimo ispravite");
                return false;
            }
            return true;
        }

        public int BrojZap4()
        {

            Dictionary<string, Zaposleni>.Enumerator e = spisakZapGr4.GetEnumerator();
            int brojac = 0;

            while (e.MoveNext())
            {
                brojac++;
            }

            return brojac;
        }



        public void UkloniZap4(String kljuc)
        {
            spisakZapGr4.Remove(kljuc);
        }

        #endregion

        #region grupa5


        public Zaposleni NadjiZap5(int pozicija)
        {
            int brojac = 0;
            Dictionary<string, Zaposleni>.Enumerator e = spisakZapGr5.GetEnumerator();
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

        public Zaposleni NadjiZap5(String kljuc)
        {
            try
            {
                return spisakZapGr5[kljuc];
            }
            catch (KeyNotFoundException)
            {

                Console.WriteLine("Klijent sa kljucem" + kljuc + "ne postoji.");
            }
            return null;
        }

        public void IzmeniZap5(Zaposleni z)
        {
            String sifra = z.Kljuc();

            sz.NadjiZap5(sifra).Ime = z.Ime;
            sz.NadjiZap5(sifra).Prezime = z.Prezime;
            sz.NadjiZap5(sifra).Jmbg = z.Jmbg;
            sz.NadjiZap5(sifra).Kategorija = z.Kategorija;
            sz.NadjiZap5(sifra).Komentar = z.Komentar;
            sz.NadjiZap5(sifra).Dozvola = z.Dozvola;
            sz.NadjiZap5(sifra).DatZaposl = z.DatZaposl;
            sz.NadjiZap5(sifra).Panel = z.Panel;

        }


        public bool DodajZap5(Zaposleni z)
        {
            try
            {
                spisakZapGr5.Add(z.Kljuc(), z);
            }
            catch
            {
                MessageBox.Show("Klijent sa oznakom" + z.Kljuc() + "vec postoji, molimo ispravite");
                return false;
            }
            return true;
        }

        public int BrojZap5()
        {

            Dictionary<string, Zaposleni>.Enumerator e = spisakZapGr5.GetEnumerator();
            int brojac = 0;

            while (e.MoveNext())
            {
                brojac++;
            }

            return brojac;
        }



        public void UkloniZap5(String kljuc)
        {
            spisakZapGr5.Remove(kljuc);
        }

        #endregion
    }
}
