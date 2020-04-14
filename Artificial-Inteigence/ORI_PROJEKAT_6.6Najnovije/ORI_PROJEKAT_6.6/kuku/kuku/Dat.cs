using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;

namespace kuku
{
    [Serializable]
    public class Dat
    {
        public Image slk;
        public Point lokacija;
        public Size velicina;
        public String tag;
        String aaa;

        public Image slk2;
        public Point lokacija2;
        public Size velicina2;
        public String tag2;
        public int razdaljina;

        public Dat(Image s, Point l, Size size,String tagg,Image s2, Point l2, Size size2,String tagg2, int r)
        {
            slk = s;
            lokacija = l;
            velicina = size;
            tag = tagg;

            slk2 = s2;
            lokacija2 = l2;
            velicina2 = size2;
            tag2 = tagg2;
            
            razdaljina = r;


        }

        public Dat(String s, Point l)
        {
            aaa = s;
            lokacija = l;
        }
    }
}
