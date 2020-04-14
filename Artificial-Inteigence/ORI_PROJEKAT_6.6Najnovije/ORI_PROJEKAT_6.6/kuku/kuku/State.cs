using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Collections;
using kuku;

namespace kuku
{
    public class State
    {
        public State parent=null;
        public PictureBox grad;
        public List<PictureBox> gradovi;
        public double predjeno=0;
        public int nivo=1;
        int sifra;

        public State()
        {
            gradovi = new List<PictureBox>();
        }
        

        public List<State> mogucaSledecaStanja()
        {
           bool nemojDodati=false;
            List<State> rezultat = new List<State>();

           /* for (int i = 1; i < Gradovi.cBrojGradova; i++)
            {
                nemojDodati = false;
                for (int j = 0; j < gradovi.Count; j++)
                    if (gradovi[j] == Gradovi.gradovi[i])
                        nemojDodati = true;

                if (!nemojDodati)
                    rezultat.Add(sledeceStanje(Gradovi.gradovi[i]));

            }*/

            for (int i = 0; i < Lista.Instanca().listaRastojanja.Count; i++)
            {
                PictureBox a=null;
                nemojDodati = false;
                if (grad.Tag.Equals(Lista.Instanca().listaRastojanja[i].g1.Tag))
                    a = Lista.Instanca().listaRastojanja[i].g2;
                if (grad.Tag.Equals(Lista.Instanca().listaRastojanja[i].g2.Tag))
                    a = Lista.Instanca().listaRastojanja[i].g1;
                if(a!=null){  
                   for(int j=0;j<gradovi.Count;j++)
                       if (gradovi[j].Tag.Equals(a.Tag))
                            nemojDodati=true;
                   if (!nemojDodati)
                       rezultat.Add(sledeceStanje(a, Lista.Instanca().listaRastojanja[i].razd));



                }
            }
                return rezultat;
        }


        public State sledeceStanje(PictureBox grad,int razd)
        {
            State sledeceSt = new State();
            sledeceSt.grad = grad;
            for (int i = 0; i < gradovi.Count; i++)
                sledeceSt.gradovi.Add(gradovi[i]);
            sledeceSt.gradovi.Add(grad);
            sledeceSt.nivo=sledeceSt.gradovi.Count;
            sledeceSt.sifra = ++Main.sifra;
            sledeceSt.parent = this;
            sledeceSt.predjeno = predjeno + razd;

            return sledeceSt;
        }



        public override int GetHashCode()
        {
            return sifra;
        }

        public bool isZavrsnoStanje()
        {
            if (Main.najkracaMoguca)
                if (grad.Tag.Equals(Main.KrajnjeStanje.grad.Tag)) return true;
                else return false;
            if (nivo == Main.i && grad.Tag.Equals(Main.KrajnjeStanje.grad.Tag)) return true;
            return false;
        }
        public List<State> path()
        {
            List<State> putanja = new List<State>();
            State tt = this;
            while (tt != null)
            {
                putanja.Insert(0, tt);
                tt = tt.parent;
                //odavde uzimamo kroz koje gradove je prosao
            }
            return putanja;
        }
    }
}
