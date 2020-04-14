using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace kuku
{
    [Serializable]
    class Lista
    {
     private List<Rastojanje> listaRastojanja;
     private static Lista lista = new Lista();
     public static Lista Instanca() { return lista; }
     private Lista()
     {
         listaRastojanja = new List<Rastojanje>();
     }
    
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
           
             IFormatter form = new BinaryFormatter();
             fajl = sfd.FileName;
             Stream str = new FileStream(fajl, FileMode.Create, FileAccess.Write, FileShare.None);
             form.Serialize(str, listaRastojanja);
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
             listaRastojanja = new List<Rastojanje>();

         }
         else
         {
             listaRastojanja = lista.listaRastojanja;

         }

     }
    }
}
