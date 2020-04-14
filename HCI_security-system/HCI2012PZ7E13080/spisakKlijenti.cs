 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCI2012PZ7E13080
{
   public class spisakKlijenti
    {
        
        private Dictionary<String, Klijent> spisakKlijenata = new Dictionary<string, Klijent>();


        public static spisakKlijenti sk = new spisakKlijenti();
        public static spisakKlijenti Instanca() 
        {
            return sk;        
        }

#region metode


        public Klijent NadjiKlijenta(int pozicija)
        {
            int brojac = 0;
            Dictionary<string, Klijent>.Enumerator e = spisakKlijenata.GetEnumerator();
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

        public Klijent NadjiKlijenta(String kljuc)
        {
            try
            {
                return spisakKlijenata[kljuc];
            }
            catch (KeyNotFoundException)
            {

                Console.WriteLine("Klijent sa kljucem {0} ne postoji.", kljuc);
            }
            return null;
        }

        public void IzmeniKlijenta(Klijent k)
        {
            String sifra = k.Kljuc();

            sk.NadjiKlijenta(sifra).Ime = k.Ime;
            sk.NadjiKlijenta(sifra).Prezime = k.Prezime;
            sk.NadjiKlijenta(sifra).Jmbg = k.Jmbg;
            sk.NadjiKlijenta(sifra).Kategorija = k.Kategorija;
            sk.NadjiKlijenta(sifra).Pol = k.Pol;
            sk.NadjiKlijenta(sifra).Delatnost = k.Delatnost;
            sk.NadjiKlijenta(sifra).DatUgovora = k.DatUgovora;
        }


        public bool DodajKlijenta(Klijent klijent)
        {
          
              spisakKlijenata.Add(klijent.Kljuc(), klijent);
           
            return true;
        }

        public int BrojKlijenata()
        {

            Dictionary<string, Klijent>.Enumerator e = spisakKlijenata.GetEnumerator();
            int brojac = 0;

            while (e.MoveNext())
            {
                brojac++;
            }

            return brojac;
        }

     

        public void UkloniKlijenta(String kljuc)
        {
            spisakKlijenata.Remove(kljuc);
        }

       
#endregion 

#region serijalizacija
        /*
             public void SAVE()
        {
            String fajl;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title= "Čuvanje fajla";
            sfd.DefaultExt = "bin";
            sfd.AddExtension= true;
            sfd.Filter= "Bin files(*.bin)|*.bin|All files(*.*)|*.*";
            if(sfd.ShowDialog()==DialogResult.OK)
            {
                Lista lista= Lista.Instanca();
                IFormatter form=new BinaryFormatter();
                fajl= sfd.FileName;
                Stream str= new FileStream(fajl,FileMode.Create,FileAccess.Write,FileShare.None);
                form.Serialize(str,lista);
                str.Close();
            }

        }

        public void LOAD()
        {
            String fajl;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Učitavanje fajla";
            ofd.Filter = "BIN files (*.bin)|*.bin|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fajl = ofd.FileName;
                lista.otvori(fajl);
            }
        }

        public void otvori(String file)
        { 
            IFormatter form =new BinaryFormatter();
            Lista lista= null;
            Stream str = null;

            try
            {
                str = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Nije moguće otvoriti datoteku zbog " + ex + "!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (str != null)
                    lista = (Lista)form.Deserialize(str);
            }
            catch (SerializationException ex)
            {
                MessageBox.Show("Nije moguće otvoriti datoteku zbog " + ex + "!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (str != null)
                    str.Close();
            }
            if (lista == null)
            {
                listaVozaca = new Dictionary<String, Vozac>();

            }
            else
            {
                listaVozaca = lista.listaVozaca;

            }

        }
         */
#endregion


    }
}
