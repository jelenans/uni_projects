using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace kuku
{
    
    public partial class Main : Form
    {
        public static List<State> tekuci;

        public static int sifra = 0;
        private Rectangle _mouseDownSelekcioniProzor = Rectangle.Empty;
        private Point _ofsetEkrana;

        public Main()
        {
            tekuci = null;
            InitializeComponent();
            gradoviPanel1.AllowDrop = true;
            gradoviPanel1.DragEnter += new DragEventHandler(gradoviPanel1_DragEnter);
            gradoviPanel1.DragDrop += new DragEventHandler(gradoviPanel1_DragDrop);
            //  Model.UcitajDatoteku();
        }

        State pocetnoStanje = null;
        public static State KrajnjeStanje = null;
        public static Boolean najkracaMoguca = false;

        private void inicijalizacijaPretrage()
        {
            pocetnoStanje = new State();
            pocetnoStanje.gradovi.Add(selektovana);
            pocetnoStanje.grad = selektovana;

            KrajnjeStanje = new State();
            KrajnjeStanje.grad = selektovana2;

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (selektovana != null && selektovana2 != null)
            {
                inicijalizacijaPretrage();

                AStarSearch astar = new AStarSearch();
                State st = astar.search(pocetnoStanje);
                try
                {
                    tekuci = st.path();
                    gradoviPanel1.resenje = tekuci;
                    gradoviPanel1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nije moguc prolazak kroz sve gradove preko agoritma A* jer do nekih nema puta!");
                }


            }
            else MessageBox.Show("Potrebno je odabrati pocetni i krajnji grad!");
        }

   

        public static int i = 0;
        int x = 0;
        int y = 0;
        int a = 65;
        PictureBox pb;
        int brisiKlik = 0;
        PictureBox selektovana;
        PictureBox selektovana2;
        List<PictureBox> obrisana = new List<PictureBox>();
        int m = -1;

        private void btnDodaj_Click(object sender, EventArgs e)
        {


            gradoviPanel1.SuspendLayout();
            pb = new PictureBox();
            pb.AllowDrop = false;

            if (i == 26)
            {
                MessageBox.Show("Maksimalan broj gradova je 26!");
            }
            else
            {
                if (i == 11 || i == 22)
                {
                    x = 0;
                    y += 50;
                }
                pb.Location = new Point(gradoviPanel1.Left + x, gradoviPanel1.Left + y);
                x += 50;
                pb.Size = new System.Drawing.Size(50, 50);
                if (brisiKlik > 0)
                {
                    pb = obrisana[m];
                    pb.Tag = obrisana[m].Tag;
                    obrisana.RemoveAt(m);
                    m--;

                    brisiKlik--;
                    pb.BorderStyle = BorderStyle.None;

                }
                else
                {
                    pb.Image = imageList1.Images[i];
                    pb.Tag = "grad" + i.ToString();
                    char chA = Convert.ToChar(a);
                   
                    pb.Name = "grad " + chA.ToString();
                      
                    //MessageBox.Show(pb.Name);
                    pb.SizeMode = PictureBoxSizeMode.AutoSize;
                    pb.MouseClick += new MouseEventHandler(gradoviPanel1_MouseClick);
                    pb.MouseDown += new MouseEventHandler(pb_MouseDown);
                    pb.MouseMove += new MouseEventHandler(pb_MouseMove);
                }
                a++; 
                i++;
                //MessageBox.Show(pb.Name);
               

                // listaGradova.Add(pb);
                gradoviPanel1.Controls.Add(pb);
                gradoviPanel1.ResumeLayout(false);
                gradoviPanel1.Refresh();


            }
        }

        private void gradoviPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender == gradoviPanel1)
            {
                if (selektovana != null)
                    selektovana.BorderStyle = BorderStyle.None;
                if (selektovana2 != null)
                    selektovana2.BorderStyle = BorderStyle.None;
                selektovana = null;
                selektovana2 = null;
            }
            else
            {

                if (selektovana != null && selektovana2 != null)
                {
                    selektovana.BorderStyle = BorderStyle.None;
                    selektovana2.BorderStyle = BorderStyle.None;
                    selektovana = null;
                    selektovana2 = null;

                }
                if (selektovana == null)
                {

                    PictureBox aaa = (PictureBox)sender;
                    selektovana = aaa;
                    selektovana.BorderStyle = BorderStyle.Fixed3D;
                }
                else
                {
                    selektovana2 = (PictureBox)sender;
                    selektovana2.BorderStyle = BorderStyle.Fixed3D;
                }


            }

        }
        #region DRAG_DROP
        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pbSel = (PictureBox)sender;


            if (selektovana != null)
            {
                Size dragVelicina = SystemInformation.DragSize;
                _mouseDownSelekcioniProzor = new Rectangle(new Point(e.X - (dragVelicina.Width / 2), e.Y - (dragVelicina.Height / 2)), dragVelicina);

            }
            else
                _mouseDownSelekcioniProzor = Rectangle.Empty;
        }

        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (e.Button == MouseButtons.Left)
                try
                {
                    if ((_mouseDownSelekcioniProzor != Rectangle.Empty) && (!_mouseDownSelekcioniProzor.Contains(e.X, e.Y)))
                    {

                        _ofsetEkrana = SystemInformation.WorkingArea.Location;
                        DragDropEffects dropEffekat = this.pb.DoDragDrop(pb, DragDropEffects.Copy);
                    }
                }
                catch (NullReferenceException)
                {
                    //
                }
        }

        private void gradoviPanel1_DragEnter(object sender, DragEventArgs e)
        {
            gradoviPanel1.AllowDrop = true;

            Type testTip = new PictureBox().GetType();

            if (e.Data.GetDataPresent(testTip))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }


        private void gradoviPanel1_DragDrop(object sender, DragEventArgs e)
        {
            gradoviPanel1.SuspendLayout();

            Type testTip = new PictureBox().GetType();
            PictureBox c = (PictureBox)e.Data.GetData(testTip);
            if (e.Data.GetDataPresent(testTip))
            {
                c.Location = this.gradoviPanel1.PointToClient(new Point(e.X, e.Y));
                this.gradoviPanel1.Controls.Add(c);
            }

            gradoviPanel1.ResumeLayout(false);
            gradoviPanel1.Refresh();
        }

        #endregion






        private void pbPovezivanje_Click(object sender, EventArgs e)
        {
            if (selektovana != null && selektovana2 != null)
            {
                UnosRazdaljine udaljenost = new UnosRazdaljine();
                if (udaljenost.ShowDialog() == DialogResult.OK)
                {

                    Rastojanje r = new Rastojanje();
                    r.razd = udaljenost.razdaljina;
                    r.g1 = selektovana;
                    r.g2 = selektovana2;
                    Lista.Instanca().listaRastojanja.Add(r);
                    // Model.MemorisiDatoteku();
                    gradoviPanel1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Dva grada moraju biti selektovana da bi se mogla povezati!");
            }

        }
      
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            najkracaMoguca = checkBox1.Checked;
        }

        private void btnObrisi_Click_1(object sender, EventArgs e)
        {
            
            if (selektovana == null || selektovana2!=null )
                MessageBox.Show("Morate selektovati tacno jedan grad za brisanje!");
            else
            {
                Brisanje b = new Brisanje("Da li želite da obrišete grad?");
                DialogResult dr = b.ShowDialog();

               if(dr==DialogResult.OK)
               {
                   if (selektovana != null)
                   {
                       foreach (PictureBox p in gradoviPanel1.Controls)
                       {
                           if (p.Tag.Equals(selektovana.Tag))
                           {
                               gradoviPanel1.SuspendLayout();
                               int n = Lista.Instanca().listaRastojanja.Count;
                               for (int k = 0; k < n; k++)
                               {

                                   if (Lista.Instanca().listaRastojanja[k].g1.Tag.Equals(selektovana.Tag) || Lista.Instanca().listaRastojanja[k].g2.Tag.Equals(selektovana.Tag))
                                   {
                                       Lista.Instanca().listaRastojanja.Remove(Lista.Instanca().listaRastojanja[k]);
                                       n--;
                                       k--;
                                   }
                               }
                               gradoviPanel1.resenje = null;
                               tekuci = null;
                               gradoviPanel1.Controls.Remove(p);
                               //  x -= 50;
                               obrisana.Add(p);
                               brisiKlik++;
                               m++;
                               i--;
                               selektovana = null;
                               gradoviPanel1.ResumeLayout(false);
                               gradoviPanel1.Refresh();
                               break;
                           }

                       }
                   }
                }
               
            }


            gradoviPanel1.Refresh();
        }
       // int kk = 0;
        /*   if (kk == 1)
                               {
                                   MessageBox.Show("Ne postoji veza");
                                   return;
                               }*/
        private void btnBrisivezu_Click(object sender, EventArgs e)
        {
           
            if (selektovana != null && selektovana2 != null)         
            {
                                              
                Brisanje b = new Brisanje("Da li želite da obrišete vezu?");
                DialogResult dr = b.ShowDialog();

               if(dr==DialogResult.OK)
               {
                   foreach (PictureBox p in gradoviPanel1.Controls)
                   {
                       if (p.Tag.Equals(selektovana.Tag))
                       {
                           gradoviPanel1.SuspendLayout();
                           int n = Lista.Instanca().listaRastojanja.Count;
                           for (int k = 0; k < n; k++)
                           {

                               if (Lista.Instanca().listaRastojanja[k].g1.Tag.Equals(selektovana.Tag) || Lista.Instanca().listaRastojanja[k].g2.Tag.Equals(selektovana2.Tag))
                               {
                                   Lista.Instanca().listaRastojanja.Remove(Lista.Instanca().listaRastojanja[k]);
                                   n--;
                                   k--;
                                 //  kk = 1;
                                   break;
                               }

                           }
                           gradoviPanel1.resenje = null;
                           tekuci = null;
                           gradoviPanel1.ResumeLayout(false);
                           gradoviPanel1.Refresh();
                           break;


                       }
                   }
                }

            }
            else
                MessageBox.Show("Morate selektovati dva grada za brisanje veze!");

            gradoviPanel1.Refresh();
         
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista.Instanca().LOAD();
           
            gradoviPanel1.SuspendLayout();

                for (int i = 0; i < Lista.listaDat.Count; i++)
             {
                 Dat d1 = Lista.listaDat[i];
  
            PictureBox pb = new PictureBox();
            pb.AllowDrop = false;

                pb.Location = d1.lokacija;
                pb.Size = d1.velicina;
                pb.Image = d1.slk;
                pb.Tag = d1.tag;                 
               // pb.Name = "grad " + chA.ToString();
                      
                    //MessageBox.Show(pb.Name);
                    pb.SizeMode = PictureBoxSizeMode.AutoSize;
                    pb.MouseClick += new MouseEventHandler(gradoviPanel1_MouseClick);
                    pb.MouseDown += new MouseEventHandler(pb_MouseDown);
                   pb.MouseMove += new MouseEventHandler(pb_MouseMove);
                
               // a++; 
                //i++;
                //MessageBox.Show(pb.Name);
               

                // listaGradova.Add(pb);
                 

                   PictureBox pb2 = new PictureBox();
                   pb2.AllowDrop = false;

                   pb2.Location = d1.lokacija2;
                   pb2.Size = d1.velicina2;
                   pb2.Image = d1.slk2;
                   pb2.Tag = d1.tag2;
                   // pb.Name = "grad " + chA.ToString();

                   //MessageBox.Show(pb.Name);
                   pb2.SizeMode = PictureBoxSizeMode.AutoSize;
                   pb2.MouseClick += new MouseEventHandler(gradoviPanel1_MouseClick);
                   pb2.MouseDown += new MouseEventHandler(pb_MouseDown);
                   pb2.MouseMove += new MouseEventHandler(pb_MouseMove);

                   // a++; 
                   //i++;
                   //MessageBox.Show(pb.Name);
                   gradoviPanel1.Controls.Add(pb);
                   gradoviPanel1.Controls.Add(pb2);

                   // listaGradova.Add(pb);
                   Rastojanje r = new Rastojanje();
                   r.razd = d1.razdaljina;
                   r.g1 = pb;
                   r.g2 = pb2;
                   // Model.MemorisiDatoteku();
                  // gradoviPanel1.Refresh();
  
                   Lista.Instanca().listaRastojanja.Add(r);
                  
                }
                gradoviPanel1.ResumeLayout(false);
                gradoviPanel1.Refresh();
        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista.Instanca().SAVE();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

      

    }
}
