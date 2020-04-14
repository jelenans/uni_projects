using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Security.Permissions;

namespace kuku
{
     [Serializable]
    public class Rastojanje// : ISerializable
    {
         public int razd;
         public PictureBox g1;
         public PictureBox g2;

         private PictureBox prvi_gr;
         private PictureBox drugi_gr;
         private int razd1;


          public Rastojanje() { }

  /*        protected Rastojanje(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
          prvi_gr = (PictureBox)info.GetValue("AltName", typeof(PictureBox));
         drugi_gr= (PictureBox)info.GetValue("AltID", typeof(PictureBox));
            razd1 = (int)info.GetValue("raz", typeof(int));
        }*/


/*         [SecurityPermission(SecurityAction.LinkDemand,
            Flags = SecurityPermissionFlag.SerializationFormatter)]
         public virtual void GetObjectData(
        SerializationInfo info, StreamingContext context)
         {
             if (info == null)
                 throw new System.ArgumentNullException("info");
             info.AddValue("AltName", g1);
             info.AddValue("AltID", g2);
             info.AddValue("raz", razd);
         }*/
    }
}
