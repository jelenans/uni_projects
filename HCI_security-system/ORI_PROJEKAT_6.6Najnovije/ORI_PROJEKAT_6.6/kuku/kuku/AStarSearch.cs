using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace kuku
{
    class AStarSearch
    {//mm
        List<State> krajnjaStanjaSva = new List<State>();
        public double heuristicFunction(State s)
        {
            return s.predjeno;
        }

        public State getBest(List<State> stanja)
        {
            State rez = null;
            double min = double.MaxValue;
            foreach (State s in stanja)
            {
                double h = heuristicFunction(s);
                if (h < min)
                {
                    min = h;
                    rez = s;
                }
               
                   
            }

            return rez;
        }

        public State search(State pocetnoStanje)
        {
            List<State> stanjaZaObradu = new List<State>();
            Hashtable predjeniPut = new Hashtable();
            stanjaZaObradu.Add(pocetnoStanje);

            while (stanjaZaObradu.Count > 0)
            {
                State naObradi = getBest(stanjaZaObradu);
                if (naObradi.isZavrsnoStanje())
                {
                    //mm
                    krajnjaStanjaSva.Add(naObradi);
                }
                if (!predjeniPut.ContainsKey(naObradi.GetHashCode()))
                {
                    List<State> mogucaSledecaStanja = naObradi.mogucaSledecaStanja();
                    foreach (State s in mogucaSledecaStanja)
                    {
                        stanjaZaObradu.Add(s);
                    }
                    predjeniPut.Add(naObradi.GetHashCode(), null);
                    
                }
                stanjaZaObradu.Remove(naObradi);
            }

            //mm
            if (krajnjaStanjaSva.Count == 0)
                return null;
            else
            {
                State theBestStateOfAllKrajnjaStanjaSva = krajnjaStanjaSva[0];
                for (int i = 1; i < krajnjaStanjaSva.Count; i++)
                {
                    if (theBestStateOfAllKrajnjaStanjaSva.predjeno > krajnjaStanjaSva[i].predjeno)
                        theBestStateOfAllKrajnjaStanjaSva = krajnjaStanjaSva[i];

                }
                return theBestStateOfAllKrajnjaStanjaSva;
            }
            //
        }
    }
}
