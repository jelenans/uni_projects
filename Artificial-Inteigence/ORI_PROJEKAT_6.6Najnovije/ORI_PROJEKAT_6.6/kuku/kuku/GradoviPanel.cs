using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kuku
{
    public partial class GradoviPanel : UserControl
    {
        public List<State> resenje;
      //  public Gradovi gradovi;
        public int[] pozicije;

        public GradoviPanel()
        {
            InitializeComponent();
            resenje = null;
          //  gradovi = new Gradovi();
        //    pozicije = new int[Gradovi.cBrojGradova];
            

          //  for (int i = 0; i < Gradovi.cBrojGradova; i++)
         //   {
         //       pozicije[i] = i;
         //   }

        }




      
        public int brojVrsta = 25;
        public int brojKolona = 25;



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics gr = e.Graphics;
            gr.FillRectangle(Brushes.White, this.ClientRectangle);

            Rectangle rec = this.ClientRectangle;
            int width = rec.Width;
            int height = rec.Height;
            Font f = new Font(FontFamily.GenericSerif, 8);

            foreach (Rastojanje m in Lista.Instanca().listaRastojanja)
            {
                PictureBox g1 = m.g1;
                PictureBox g2 = m.g2;
                String razdaljina = m.razd.ToString();
                float xx1 = (float)g1.Location.X;
                float yy1 = (float)g1.Location.Y;
                float xx2 = (float)g2.Location.X;
                float yy2 = (float)g2.Location.Y;
                gr.DrawLine(Pens.Green, xx1 + 10, yy1 + 10, xx2 + 10, yy2 + 10);
                gr.DrawString(razdaljina, f, Brushes.Black, (xx1 + xx2) / 2 , (yy1 + yy2) / 2 -2 );

            }

            if (Main.tekuci != null)
            {
                State stanje = Main.tekuci[Main.tekuci.Count - 1];
                int x = 140;
                int y = 30;
                int ss = 1;
                for (int i = 1; i < stanje.gradovi.Count; i++)
                {
                    PictureBox g1 = stanje.gradovi[i-1];
                    PictureBox g2 = stanje.gradovi[i];
                    Font fr = new Font(FontFamily.GenericSansSerif, 12);
                    Font ff = new Font(FontFamily.GenericSansSerif, 10);
                    gr.DrawString("Lista gradova: ", fr, Brushes.Gray, width - 140, 0);
                    gr.DrawLine(Pens.Gray, width - 137, 20, width - 40, 20);
                    gr.DrawLine(Pens.Gray, width - 142, 0, width - 142, height);
                    if (i == 1)
                    {
                       // String tag = g1.Tag.ToString();
                        //Label l1 = new Label();

                        gr.DrawString(ss+"."+g1.Name, ff, Brushes.RosyBrown, width- x, y);
                        ss++;
                        //l1.Location=   new Point(100,100);
                      //  l1.Visible = true;
                        y += 20;
                    }
                    //String tag2 = g2.Tag.ToString();
                    //Label l2 = new Label();
                   // l2.Text = "wfwe"; 
                    gr.DrawString(ss + "." + g2.Name, ff, Brushes.RosyBrown, width - x, y);
                    ss++;
                    //l2.Visible = true;
                    y += 20;
                    float xx1 = (float)g1.Location.X;
                    float yy1 = (float)g1.Location.Y;
                    float xx2 = (float)g2.Location.X;
                    float yy2 = (float)g2.Location.Y;
                    gr.DrawLine(Pens.Red, xx1 + 10, yy1 + 10, xx2 + 10, yy2 + 10);
                }

            }
        }

        private void GradoviPanel_Load(object sender, EventArgs e)
        {
            
        }// if gradovi != null
    }


}

