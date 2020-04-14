using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.ObjectModel;



namespace EvidencijaAviona.Model
{
   public class AvioniKolekcija: EvidencijaAviona.Model.IAvioniKolekcija
    {
        private ObservableCollection<IAvion> skladisteAviona;
        private readonly string _datoteka;

        public ObservableCollection<IAvion> Avioni { get { return skladisteAviona; } } 

        private static AvioniKolekcija kolek = null;

        public static AvioniKolekcija getInstance()
        {
            if (kolek == null)
            {
                kolek = new AvioniKolekcija();
            }
            return kolek;
        }

        private AvioniKolekcija()
        {
            _datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Avioni.podaci");
            UcitajDatoteku();
        }
        public ObservableCollection<IAvion> PronadjiSveAvione()
        {
            return new ObservableCollection<IAvion>(skladisteAviona);
        }
        public void SacuvajAvion(IAvion av)
        {
            if (av.Oznaka == Guid.Empty)
                av.Oznaka = Guid.NewGuid();
            bool flag = false;
            foreach (IAvion a in skladisteAviona)
            {
                if (a.Oznaka.Equals(av.Oznaka))
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
                skladisteAviona.Add(av);
           
            MemorisiDatoteku();
        }
        public void ObrisiAvion(IAvion aa)
        {
            if (skladisteAviona.Remove(aa))
                MemorisiDatoteku();
        }
        public void IzmeniAvion(IAvion aa)
        {
            foreach (IAvion a in skladisteAviona)
            {
                if (aa.Oznaka.Equals(a.Oznaka))
                {
                    a.Oznaka1 = aa.Oznaka1;
                    a.Oznaka2 = aa.Oznaka2;
                    a.Kljuc = aa.Kljuc;
                    a.Tezina = aa.Tezina;
                    a.DatTehPregled = aa.DatTehPregled;
                    a.SpremanZaLet = aa.SpremanZaLet;
                    a.Status = aa.Status;
                    a.MaxBrPutnika = aa.MaxBrPutnika;
                    a.MaxBrzina = aa.MaxBrzina;
                    a.TipAviona = aa.TipAviona;
                    a.TeretKapac = aa.TeretKapac;
                    a.Posada = aa.Posada;
                    a.Letovi = aa.Letovi;
                    MemorisiDatoteku();
                }
            }

        }
        public IAvion VratiAvionId(Guid avOznk)
        {

            foreach (IAvion a in skladisteAviona)
            {
                if (avOznk.Equals(a.Oznaka))
                {
                    return a;
                }
            }
            return null;

        }
       
        public void MemorisiDatoteku()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(_datoteka, FileMode.OpenOrCreate);
                formatter.Serialize(stream, skladisteAviona);
            }
            catch
            {
                // 
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }
        private void UcitajDatoteku()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            if (File.Exists(_datoteka))
            {
                try
                {
                    stream = File.Open(_datoteka, FileMode.Open);
                    skladisteAviona = (ObservableCollection<IAvion>)formatter.Deserialize(stream);
                }
                catch
                {
                    // 
                }
                finally
                {
                    if (stream != null)
                        stream.Dispose();
                }

            }
            else
                skladisteAviona = new ObservableCollection<IAvion>();
        }
    }
}
