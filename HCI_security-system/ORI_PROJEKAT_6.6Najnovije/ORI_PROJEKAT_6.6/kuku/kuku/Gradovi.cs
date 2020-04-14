using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kuku
{
    public class Gradovi
    {
        public static int cBrojGradova = 0;
        public static List<Grad> gradovi;
        public static int rastojanje2grada = 0;
        
//slobodno se dodaju,brisu ili menjaju gradovi, sa tim da se oni dodaju ispred Grad kraj. Grad kraj predstavlja poslednji grad
        public Gradovi()
        {
          /*  gradovi = new List<Grad>();
            gradovi.Add(new Grad(3,17));
            
            gradovi.Add(new Grad(5, 13));
            
            gradovi.Add(new Grad(10, 13));

           gradovi.Add(new Grad(13, 2));
           
           gradovi.Add(new Grad(4, 4));

            gradovi.Add(new Grad(8, 17));
           
            gradovi.Add(new Grad(15,17));

            gradovi.Add(new Grad(17, 8));
           


           Grad kraj = new Grad(20,1);

           cBrojGradova = gradovi.Count+1;

           kraj.stanje = cBrojGradova;
           gradovi.Add(kraj);*/
 
        }

      /*  public static double rastojanje(Grad i, Grad j)
        {
           // return Math.Sqrt(Math.Pow(i.x - j.x, 2) + Math.Pow(i.y - j.y, 2));
        }*/
    }
}
