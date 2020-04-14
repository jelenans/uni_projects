using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RacunarskaGrafika.Vezbe;
using System.Windows.Forms;
using Tao.OpenGl;

namespace Projekat
{
    class MilleniumFalcon : IDrawable
    {
        #region Atributi

        /// <summary>
        ///	 Promenljiva za iscrtavanje quadric objekata
        /// </summary>
        private Glu.GLUquadric m_gluObj;

        /// <summary>
        ///	 Identifikator displej liste za mlaznicu aviona.
        /// </summary>
//        private int m_wingDL;

        /// <summary>
        ///	 Kvadar.
        /// </summary>
        private Box m_box = null;



        #endregion Atributi

         #region Konstruktori

      /// <summary>
      ///		Konstruktor.
      /// </summary>
      public MilleniumFalcon()
      {
        try
        {
          m_box = new Box();
        }
        catch (Exception)
        {
          MessageBox.Show("Neuspesno kreirana instanca klase Box", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        m_gluObj = Glu.gluNewQuadric();
        Glu.gluQuadricNormals(m_gluObj, Glu.GLU_SMOOTH);
        Glu.gluQuadricTexture(m_gluObj, Glu.GLU_TRUE);
               
      }

    #endregion Konstruktori

      #region Metode

      /// <summary>
      ///  Metoda iscrtava jednu mlaznicu.
      /// </summary>
      void DrawBase()
      {
          Gl.glDisable(Gl.GL_CULL_FACE);

          Gl.glPushMatrix();
          Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_SREBRA]);


          Gl.glColor3ub(150, 180, 180);
          Gl.glPushMatrix();
          
          Gl.glTranslatef(0.0f, 0.0f, 7.0f);
          Gl.glRotatef(90.0f, 1.0f, 0.0f, 0.0f);
          Glu.gluCylinder(m_gluObj, 1.3f, 1.3f, 0.5f, 128, 128);
          Gl.glPopMatrix();


          Gl.glPushMatrix();
          Gl.glTranslatef(0.0f, 0.0f, 7.0f);
          Gl.glRotatef(90.0f, 1.0f, 0.0f, 0.0f);
          Glu.gluDisk(m_gluObj, 0.0f, 1.3f, 128, 128);
          Gl.glPopMatrix();


          Gl.glPushMatrix();
          Gl.glTranslatef(0.0f, 0.0f, 7.0f);
          Gl.glTranslatef(0.0f, -0.5f, 0.0f);
          Gl.glRotatef(90.0f, 1.0f, 0.0f, 0.0f);
          Glu.gluDisk(m_gluObj, 0.0f, 1.3f, 128, 128);
          Gl.glPopMatrix();

          Gl.glPopMatrix();
      
      }

      void DrawCentralPart() {

          Gl.glPushMatrix();

          Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_KRILA]);
     
          Gl.glColor3ub(150, 160, 165);
          Gl.glTranslatef(0.0f, -0.25f, 8.1f);
          m_box.SetSize(0.4f, 0.75f, 1.2f);
          m_box.Draw();
          Gl.glPopMatrix();    

      }

      void DrawWings() {

          Gl.glColor3ub(120, 120, 120);
          Gl.glPushMatrix();

          Gl.glTranslatef(-0.2f, 0.0f, 7.7f);

          Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_METALA]);

          Gl.glBegin(Gl.GL_QUADS);

//gornja..............................................
          Gl.glNormal3fv(Lighting.FindFaceNormal(0.0f, 0.0f, 0.0f, 0.0f, -0.2f, 1.8f, -0.5f, -0.2f, 1.8f));
          Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(0.0f, 0.0f, 0.0f);
          Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(0.0f, -0.2f, 1.8f);
          Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(-0.5f, -0.2f, 1.8f);
          Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(-0.8f, 0.0f, 0.0f);
          //donja...............................................
          Gl.glNormal3fv(Lighting.FindFaceNormal(0.0f, -0.5f, 0.0f, 0.0f, -0.3f, 1.8f, -0.5f, -0.3f, 1.8f));
          Gl.glTexCoord2f(0.0f, 0.0f);          Gl.glVertex3f(0.0f, -0.5f, 0.0f);
          Gl.glTexCoord2f(0.0f, 1.0f);          Gl.glVertex3f(0.0f, -0.3f, 1.8f);
          Gl.glTexCoord2f(1.0f, 1.0f);          Gl.glVertex3f(-0.5f, -0.3f, 1.8f);
          Gl.glTexCoord2f(1.0f, 0.0f);          Gl.glVertex3f(-0.8f, -0.5f, 0.0f);
          //strana1................................................
          Gl.glNormal3fv(Lighting.FindFaceNormal(-0.8f, 0.0f, 0.0f, -0.5f, -0.2f, 1.8f, -0.5f, -0.3f, 1.8f));
          Gl.glTexCoord2f(0.0f, 0.0f);          Gl.glVertex3f(-0.8f, 0.0f, 0.0f);
          Gl.glTexCoord2f(0.0f, 1.0f);          Gl.glVertex3f(-0.5f, -0.2f, 1.8f);
          Gl.glTexCoord2f(1.0f, 1.0f);          Gl.glVertex3f(-0.5f, -0.3f, 1.8f);
          Gl.glTexCoord2f(1.0f, 0.0f);          Gl.glVertex3f(-0.8f, -0.5f, 0.0f);
          //strana2..................................................
          Gl.glNormal3fv(Lighting.FindFaceNormal(0.0f, 0.0f, 0.0f,0.0f, -0.2f, 1.8f,0.0f, -0.3f, 1.8f));
          Gl.glTexCoord2f(0.0f, 0.0f);          Gl.glVertex3f(0.0f, 0.0f, 0.0f);
          Gl.glTexCoord2f(0.0f, 1.0f);          Gl.glVertex3f(0.0f, -0.2f, 1.8f);
          Gl.glTexCoord2f(1.0f, 1.0f);          Gl.glVertex3f(0.0f, -0.3f, 1.8f);
          Gl.glTexCoord2f(1.0f, 0.0f);          Gl.glVertex3f(0.0f, -0.5f, 0.0f);
          //prednje..................................................
          Gl.glNormal3fv(Lighting.FindFaceNormal(0.0f, -0.2f, 1.8f,-0.5f, -0.2f, 1.8f,-0.5f, -0.3f, 1.8f));
          Gl.glTexCoord2f(0.0f, 0.0f);          Gl.glVertex3f(0.0f, -0.2f, 1.8f);
          Gl.glTexCoord2f(0.0f, 1.0f);          Gl.glVertex3f(-0.5f, -0.2f, 1.8f);
          Gl.glTexCoord2f(1.0f, 1.0f);          Gl.glVertex3f(-0.5f, -0.3f, 1.8f);
          Gl.glTexCoord2f(1.0f, 0.0f);          Gl.glVertex3f(0.0f, -0.3f, 1.8f);

          Gl.glEnd();


          Gl.glRotatef(180.0f,0.0f,0.0f,1.0f);
          Gl.glTranslatef(-0.4f, 0.5f,0.0f);


          Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_METALA]);

          Gl.glBegin(Gl.GL_QUADS);

          //gornja..............................................
          Gl.glNormal3fv(Lighting.FindFaceNormal(-0.5f, -0.2f, 1.8f, 0.0f, -0.2f, 1.8f, 0.0f, 0.0f, 0.0f));
          Gl.glTexCoord2f(0.0f, 0.0f);          Gl.glVertex3f(0.0f, 0.0f, 0.0f);
          Gl.glTexCoord2f(0.0f, 1.0f);          Gl.glVertex3f(0.0f, -0.2f, 1.8f);
          Gl.glTexCoord2f(1.0f, 1.0f);          Gl.glVertex3f(-0.5f, -0.2f, 1.8f);
          Gl.glTexCoord2f(1.0f, 0.0f);          Gl.glVertex3f(-0.8f, 0.0f, 0.0f);
          //donja...............................................
          Gl.glNormal3fv(Lighting.FindFaceNormal(-0.5f, -0.3f, 1.8f, 0.0f, -0.3f, 1.8f, 0.0f, -0.5f, 0.0f));
          Gl.glTexCoord2f(0.0f, 0.0f);          Gl.glVertex3f(0.0f, -0.5f, 0.0f);
          Gl.glTexCoord2f(0.0f, 1.0f);          Gl.glVertex3f(0.0f, -0.3f, 1.8f);
          Gl.glTexCoord2f(1.0f, 1.0f);          Gl.glVertex3f(-0.5f, -0.3f, 1.8f);
          Gl.glTexCoord2f(1.0f, 0.0f);          Gl.glVertex3f(-0.8f, -0.5f, 0.0f);
          //strana1................................................
          Gl.glNormal3fv(Lighting.FindFaceNormal(-0.5f, -0.3f, 1.8f, -0.5f, -0.2f, 1.8f, -0.8f, 0.0f, 0.0f));
          Gl.glTexCoord2f(0.0f, 0.0f);          Gl.glVertex3f(-0.8f, 0.0f, 0.0f);
          Gl.glTexCoord2f(0.0f, 1.0f);          Gl.glVertex3f(-0.5f, -0.2f, 1.8f);
          Gl.glTexCoord2f(1.0f, 1.0f);          Gl.glVertex3f(-0.5f, -0.3f, 1.8f);
          Gl.glTexCoord2f(1.0f, 0.0f);          Gl.glVertex3f(-0.8f, -0.5f, 0.0f);
          //strana2..................................................
          Gl.glNormal3fv(Lighting.FindFaceNormal(0.0f, -0.3f, 1.8f, 0.0f, -0.2f, 1.8f, 0.0f, 0.0f, 0.0f));
          Gl.glTexCoord2f(0.0f, 0.0f);          Gl.glVertex3f(0.0f, 0.0f, 0.0f);
          Gl.glTexCoord2f(0.0f, 1.0f);          Gl.glVertex3f(0.0f, -0.2f, 1.8f);
          Gl.glTexCoord2f(1.0f, 1.0f);          Gl.glVertex3f(0.0f, -0.3f, 1.8f);
          Gl.glTexCoord2f(1.0f, 0.0f);          Gl.glVertex3f(0.0f, -0.5f, 0.0f);
          //prednje..................................................
          Gl.glNormal3fv(Lighting.FindFaceNormal(0.0f, -0.2f, 1.8f, -0.5f, -0.2f, 1.8f, -0.5f, -0.3f, 1.8f));
          Gl.glTexCoord2f(0.0f, 0.0f);          Gl.glVertex3f(0.0f, -0.2f, 1.8f);
          Gl.glTexCoord2f(0.0f, 1.0f);          Gl.glVertex3f(-0.5f, -0.2f, 1.8f);
          Gl.glTexCoord2f(1.0f, 1.0f);          Gl.glVertex3f(-0.5f, -0.3f, 1.8f);
          Gl.glTexCoord2f(1.0f, 0.0f);          Gl.glVertex3f(0.0f, -0.3f, 1.8f);


          Gl.glEnd();
          Gl.glPopMatrix();   
 

      }
    
      public void Draw()
      {
        
         
          DrawBase();
          DrawCentralPart();
          DrawWings();
   
      }


      // TODO 3: Osloboditi resurse koriscenjem Dispose metode i IDisposable interfejsa 
      protected virtual void Dispose(bool disposing)
      {
          //if (disposing)
          //{
          //  // Oslodi managed resurse
          //}

          // Oslobodi quadric objekat
          Glu.gluDeleteQuadric(this.m_gluObj);
      }

      #endregion Metode
    }
}
