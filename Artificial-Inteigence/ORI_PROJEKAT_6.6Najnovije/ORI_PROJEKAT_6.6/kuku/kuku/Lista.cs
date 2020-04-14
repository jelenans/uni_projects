using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Drawing;

namespace kuku
{
    [Serializable]
    class Lista //: ISerializable
    {
     public List<Rastojanje> listaRastojanja;

     public static List<Dat> listaDat= new List<Dat>();
     private static Lista lista = new Lista();
     private static Lista listaa;
     public static Lista Instanca() { return lista; }
     public static int rastojanje;

     private List<Rastojanje> listica;
     private Lista() {
         listaRastojanja = new List<Rastojanje>();
     }
    
 /*        protected Lista(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
            listaa = (Lista)info.GetValue("AltName", typeof(Lista));
            
        }


         [SecurityPermission(SecurityAction.LinkDemand,
            Flags = SecurityPermissionFlag.SerializationFormatter)]
         public virtual void GetObjectData(
        SerializationInfo info, StreamingContext context)
         {
             if (info == null)
                 throw new System.ArgumentNullException("info");
             info.AddValue("AltName", lista);           
         }*/
     public void SAVE()
     {
         String fajl;
         SaveFileDialog sfd = new SaveFileDialog();
         sfd.Title = "Čuvanje fajla";
         sfd.DefaultExt = "bin";
         sfd.AddExtension = true;
         sfd.Filter = "Bin files(*.bin)|*.bin|All files(*.*)|*.*";
         if (sfd.ShowDialog() == DialogResult.OK)
         {
             Lista lista = Lista.Instanca();
             for (int i = 0; i < lista.listaRastojanja.Count;i++ )
             {
                 Image im1 = lista.listaRastojanja[i].g1.Image;
                 String tag1= lista.listaRastojanja[i].g1.Tag.ToString();
                 Point lok1 = lista.listaRastojanja[i].g1.Location;
                 Size size1 = lista.listaRastojanja[i].g1.Size;
               
                 Image im2 = lista.listaRastojanja[i].g2.Image;
                 String tag2 = lista.listaRastojanja[i].g2.Tag.ToString();
                 Point lok2 = lista.listaRastojanja[i].g2.Location;
                 Size size2 = lista.listaRastojanja[i].g2.Size;

                 rastojanje = lista.listaRastojanja[i].razd;


                 Dat dat = new Dat(im1, lok1, size1, tag1,im2, lok2, size2, tag2,rastojanje);

                 listaDat.Add(dat);
             }
             IFormatter form = new BinaryFormatter();
             fajl = sfd.FileName;
             Stream str = new FileStream(fajl, FileMode.Create, FileAccess.Write, FileShare.None);
             form.Serialize(str, listaDat);
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
             otvori(fajl);
         }
     }

     public void otvori(String file)
     {
         IFormatter form = new BinaryFormatter();
         Lista lista = null;
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
                 listaDat = (List<Dat>)form.Deserialize(str);
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
         if (listaDat == null)
         {
             listaRastojanja = new List<Rastojanje>();

         }


         }

     }
    }

