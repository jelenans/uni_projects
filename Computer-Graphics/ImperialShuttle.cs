// -----------------------------------------------------------------------
// <file>ImperialShuttle.cs</file>
// <copyright>Grupa za Grafiku, Interakciju i Multimediju 2012.</copyright>
// <author>Srdjan Mihic</author>
// <summary>Klasa koja enkapsulira OpenGL programski kod za iscrtavanje imperial shuttle-a.</summary>
// -----------------------------------------------------------------------
namespace RacunarskaGrafika.Vezbe
{
  using System;
  using System.Windows.Forms; 
  using Tao.OpenGl;
    using Projekat; // prostor imena za rad sa OpenGL-om

  /// <summary>
  ///  Klasa enkapsulira OpenGL kod za iscrtavanje imperial shuttle-a.
  /// </summary>
  class ImperialShuttle : IDrawable
  {
    #region Atributi

      /// <summary>
      ///	 Promenljiva za iscrtavanje quadric objekata
      /// </summary>
      private Glu.GLUquadric m_gluObj;

      /// <summary>
      ///	 Identifikator displej liste za mlaznicu aviona.
      /// </summary>
      private int m_wingDL;

      /// <summary>
      ///	 Kvadar.
      /// </summary>
      private Box m_box = null;

      private float pozicijaSnopa1 = 0.0f;

      public float PozicijaSnopa1
      {
          get { return pozicijaSnopa1; }
          set { pozicijaSnopa1 = value; }
      }
      private float pozicijaSnopa2 = 0.0f;

      public float PozicijaSnopa2
      {
          get { return pozicijaSnopa2; }
          set { pozicijaSnopa2 = value; }
      }


    #endregion Atributi

    #region Konstruktori

      /// <summary>
      ///		Konstruktor.
      /// </summary>
      public ImperialShuttle()
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


        // TODO 3: Kreirati DL listu sa identifikatorom m_wingDL koja iscrtava krilo pozivom metode DrawWing
        m_wingDL = Gl.glGenLists(1);    //identifikator prvog objekta.
        Gl.glNewList(m_wingDL, Gl.GL_COMPILE);
        DrawWing();
        Gl.glEndList();
        
        
      }

    #endregion Konstruktori

    #region Metode

      /// <summary>
      ///  Metoda iscrtava jednu mlaznicu.
      /// </summary>
      void DrawThruster()
      {
        Gl.glDisable(Gl.GL_CULL_FACE);
        
        // Mlaznica = valjak i zarubljena kupa
        Gl.glPushMatrix();
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_METALA]);
          // Glu.gluQuadricTexture(m_gluObj, Glu.GLU_TRUE);
          //automatsko generisanje normala za GLU objekte


        // TODO 2: Nacrtati valjak poluprecnika 0.15 i visine 1.4 pomeren za 0.25 po x-osi i -0.25 po y-osi
        Gl.glTranslatef(0.25f, -0.25f, 0.0f);
        Glu.gluCylinder(m_gluObj, 0.15f, 0.15f, 1.4f, 128, 128);


        

          // TODO 2: Nacrtati sferu sa poluprecnikom 0.15

        Glu.gluSphere(m_gluObj, 0.15f, 128, 128);


          // TODO 2: Nacrtati zarubljenu kupu poluprecnika 0.15 i 0.07 i visine 0.25 pomerenu 1.4 po z-osi
        Gl.glTranslatef(0.0f, 0.0f, 1.4f);
        Glu.gluCylinder(m_gluObj, 0.15f, 0.07f, 0.25f, 128, 128);

        

          // TODO 2: Nacrtati krug poluprecnika 0.07 pomeren za 0.25 po z-osi
        Gl.glTranslatef(0.0f, 0.0f, 0.25f);
        Glu.gluDisk(m_gluObj, 0, 0.07f, 128, 128);
        

        Gl.glPopMatrix();

        Gl.glEnable(Gl.GL_CULL_FACE);
      }
    
      /// <summary>
      ///  Metoda iscrtava jedno krilo.
      /// </summary>
      void DrawWing()
      {
        // Mlaznica
        DrawThruster();

        // Krilo
        Gl.glPushMatrix();

          // TODO 2: Nacrtati omotac krila koriscenjem GL_QUAD_STRIP primitive
          //         temena su (u pravilnom redosledu): (0.0, 2.4, 0.4), (0.0, 2.4, 0.0), (0.1, 2.4, 0.4), (0.1, 2.4, 0.0),
          //                                            (0.1, 0.0, 1.2), (0.1, 0.0, 0.0), (0.3, -0.2, 1.2), (0.3, -0.2, 0.0),
          //                                            (0.2, -0.25, 1.2), (0.2, -0.25, 0.0), (0.0, 0.0, 1.2), (0.0, 0.0, 0.0),
          //                                            (0.0, 2.4, 0.4), (0.0, 2.4, 0.0).
          //  

        Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_KRILA]);
        Gl.glBegin(Gl.GL_QUAD_STRIP);

      Gl.glNormal3fv(Lighting.FindFaceNormal(0.0f, 2.4f, 0.4f, 0.0f, 2.4f, 0.0f, 0.1f, 2.4f, 0.4f));

      Gl.glTexCoord2f(0.0f, 0.0f);
      Gl.glVertex3f(0.0f, 2.4f, 0.4f);
      Gl.glTexCoord2f(0.0f, 1.0f);
      Gl.glVertex3f(0.0f, 2.4f, 0.0f);
      Gl.glTexCoord2f(1.0f, 1.0f);
      Gl.glVertex3f(0.1f, 2.4f, 0.4f);
      Gl.glTexCoord2f(1.0f, 0.0f);
      Gl.glVertex3f(0.1f, 2.4f, 0.0f);


      Gl.glNormal3fv(Lighting.FindFaceNormal(0.1f, 0.0f, 1.2f, 0.1f, 0.0f, 0.0f, 0.3f, -0.2f, 1.2f));

      Gl.glTexCoord2f(0.0f, 0.0f);
      Gl.glVertex3f(0.1f, 0.0f, 1.2f);
      Gl.glTexCoord2f(0.0f, 1.0f);
      Gl.glVertex3f(0.1f, 0.0f, 0.0f);
      Gl.glTexCoord2f(1.0f, 1.0f);
      Gl.glVertex3f(0.3f, -0.2f, 1.2f);
      Gl.glTexCoord2f(1.0f, 0.0f);
      Gl.glVertex3f(0.3f, -0.2f, 0.0f);

        Gl.glNormal3fv(Lighting.FindFaceNormal(0.2f, -0.25f, 1.2f, 0.2f, -0.25f, 0.0f, 0.0f, 0.0f, 1.2f));

        Gl.glTexCoord2f(0.0f, 0.0f);
        Gl.glVertex3f(0.2f, -0.25f, 1.2f);
        Gl.glTexCoord2f(0.0f, 1.0f);
        Gl.glVertex3f(0.2f, -0.25f, 0.0f);
        Gl.glTexCoord2f(1.0f, 1.0f);
        Gl.glVertex3f(0.0f, 0.0f, 1.2f);

        Gl.glNormal3fv(Lighting.FindFaceNormal(0.0f, 0.0f, 0.0f, 0.0f, 2.4f, 0.4f, 0.0f, 2.4f, 0.0f));

        Gl.glTexCoord2f(1.0f, 0.0f);
        Gl.glVertex3f(0.0f, 0.0f, 0.0f);
        Gl.glTexCoord2f(0.0f, 1.0f);
        Gl.glVertex3f(0.0f, 2.4f, 0.4f);
        Gl.glTexCoord2f(0.0f, 0.0f);
        Gl.glVertex3f(0.0f, 2.4f, 0.0f);

        Gl.glEnd();

          // TODO 2: Nacrtati zadnju bazu krila koriscenjem GL_QUAD_STRIP primitive
          //         temena su (u pravilnom redosledu): (0.1, 2.4, 0.0), (0.0, 2.4, 0.0), (0.1, 0.0, 0.0), (0.0, 0.0, 0.0),
          //                                            (0.3, -0.2, 0.0), (0.2, -0.25, 0.0).

        Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_KRILA]);  
        Gl.glBegin(Gl.GL_QUAD_STRIP);


        Gl.glNormal3fv(Lighting.FindFaceNormal(0.1f , 2.4f, 0.0f, 0.0f, 2.4f, 0.0f, 0.1f, 0.0f, 0.0f));


        Gl.glTexCoord2f(0.0f, 0.0f);
        Gl.glVertex3f(0.1f, 2.4f, 0.0f);
        Gl.glTexCoord2f(0.0f, 1.0f);
        Gl.glVertex3f(0.0f, 2.4f, 0.0f);
        Gl.glTexCoord2f(1.0f, 1.0f);
        Gl.glVertex3f(0.1f, 0.0f, 0.0f);

         Gl.glNormal3fv(Lighting.FindFaceNormal(0.0f, 0.0f, 0.0f, 0.3f, -0.2f, 0.0f, 0.2f, -0.25f, 0.0f));

         Gl.glTexCoord2f(0.0f, 0.0f);
         Gl.glVertex3f(0.0f, 0.0f, 0.0f);
         Gl.glTexCoord2f(0.0f, 1.0f);
         Gl.glVertex3f(0.3f, -0.2f, 0.0f);
         Gl.glTexCoord2f(1.0f, 1.0f);
         Gl.glVertex3f(0.2f, -0.25f, 0.0f);

         Gl.glEnd();
        
          // TODO 2: Nacrtati prednju bazu krila koriscenjem GL_QUAD_STRIP primitive
          //         temena su (u pravilnom redosledu): (0.0, 2.4, 0.4), (0.1, 2.4, 0.4), (0.0, 0.0, 0.8), (0.1, 0.0, 0.8), 
          //                                            (0.2, -0.25, 0.8), (0.3, -0.2, 0.8).

         Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_KRILA]);
     
          Gl.glBegin(Gl.GL_QUAD_STRIP);

          Gl.glNormal3fv(Lighting.FindFaceNormal(0.0f, 2.4f, 0.4f, 0.1f, 2.4f, 0.4f, 0.0f, 0.0f, 0.8f));

          Gl.glTexCoord2f(0.0f, 0.0f); ;
          Gl.glVertex3f(0.0f, 2.4f, 0.4f);
          Gl.glTexCoord2f(0.0f, 1.0f);
          Gl.glVertex3f(0.1f, 2.4f, 0.4f);
          Gl.glTexCoord2f(1.0f, 1.0f);
          Gl.glVertex3f(0.0f, 0.0f, 0.8f);

        Gl.glNormal3fv(Lighting.FindFaceNormal(0.1f, 0.0f, 0.8f, 0.2f, -0.25f, 0.8f, 0.3f, -0.2f, 0.8f));
        Gl.glTexCoord2f(0.0f, 0.0f);
        Gl.glVertex3f(0.1f, 0.0f, 0.8f);
        Gl.glTexCoord2f(0.0f, 1.0f);
        Gl.glVertex3f(0.2f, -0.25f, 0.8f);
        Gl.glTexCoord2f(1.0f, 1.0f);
        Gl.glVertex3f(0.3f, -0.2f, 0.8f);

        Gl.glEnd();
          

        Gl.glPopMatrix();
      }

    /// <summary>
    ///  Iscrtavanje laserskog topa.
    /// </summary>
    void DrawLaserCanon()
    {

      Gl.glPushMatrix();
      Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_METALA]);
      Glu.gluQuadricTexture(m_gluObj, Glu.GLU_TRUE); //automatsko generisanje normala za GLU objekte

        // TODO 2: Nacrtati zarubljenu kupu poluprecnika 0.06 i 0.03, visine 0.7
      Glu.gluCylinder(m_gluObj, 0.06f, 0.03f, 0.7f, 128, 128);


        // TODO 2: Nacrtati dva valjka poluprecnika 0.08 i 0.04, visine 0.5
      /*slices i stacks  –  broj  segmenata  po  x  odnosno  y  osi.  (sfera  se 
iscrtava aproksimacijom pomoću trouglova ili 
četvorouglova (quad stripes))*/

      Glu.gluCylinder(m_gluObj, 0.08f, 0.08f, 0.5f, 128, 128);
      Glu.gluCylinder(m_gluObj, 0.04f, 0.04f, 0.5f, 128, 128);

      

        // TODO 2: Nacrtati prsten sa unutrasnjim poluprecnikom 0.04 i spoljasnjim 0.08

      Glu.gluDisk(m_gluObj, 0.04f, 0.08f, 128, 128);

        // TODO 2: Nacrtati prsten sa unutrasnjim poluprecnikom 0.04 i spoljasnjim 0.08, pomeren za 0.5 po z-osi


      Gl.glTranslatef(0.0f, 0.0f, 0.5f);
      Glu.gluDisk(m_gluObj, 0.04f, 0.08f, 128, 128);

      //Iscrtavanje laserskog snopa
    //  Gl.glColor3ub(255, 0, 0);
      Gl.glTranslatef(0.0f, 0.0f, pozicijaSnopa1 - 1.0f);
      Glu.gluCylinder(m_gluObj, 0.04f, 0.04f, 0.5f, 128, 128);

      Gl.glTranslatef(0.0f, 0.0f, pozicijaSnopa2 - 101.0f);
      Glu.gluCylinder(m_gluObj, 0.04f, 0.04f, 0.5f, 128, 128);

      Gl.glPopMatrix();
    }

    /// <summary>
    ///  Iscrtavanje aviona pomocu OpenGL-a.
    /// </summary>
    public void Draw()
    {
      // Levo krilo
      Gl.glColor3ub(180, 180, 180);
      Gl.glPushMatrix();
        // TODO 3: Nacrtati levo krilo koriscenjem DL mehanizma na poziciji (-0.7, -0.4, -0.6) zarotirano za 120 stepeni oko z-ose
     // Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_KRILA]);

      Gl.glTranslatef(-0.7f, -0.4f, -0.6f); 
      Gl.glRotatef(120.0f, 0.0f, 0.0f, 1.0f);
      Gl.glCallList(m_wingDL);

      Gl.glPopMatrix();
      
      // Desno krilo
      Gl.glPushMatrix();
        // TODO 3: Nacrtati desno krilo koriscenjem DL mehanizma na poziciji (0.7, -0.4, -0.6), skalirano -1 puta po x-osi, a zatim zarotirano za 120 stepeni oko z-ose
      Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_KRILA]);

      Gl.glTranslatef(0.7f, -0.4f, -0.6f); 
      Gl.glScalef(-1.0f,1.0f,1.0f);
      Gl.glRotatef(120.0f, 0.0f, 0.0f, 1.0f);
      Gl.glCallList(m_wingDL);
      
      Gl.glPopMatrix();

      // Telo satla
      Gl.glColor3ub(150, 150, 150);
      Gl.glPushMatrix();
        // TODO 2: Nacrtati telo satla osnovni deo kao kvadar sirine 1.2, visine 0.4 i dubine 1.2
      Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_SREBRA]);
      Glu.gluQuadricTexture(m_gluObj, Glu.GLU_TRUE); //automatsko generisanje normala za GLU objekte

      m_box.SetSize(1.2,0.4,1.2);
      m_box.Draw();

      Gl.glPopMatrix();

      Gl.glPushMatrix();
        // TODO 2: Nacrtati telo satla zadnji deo kao kvadar sirine 0.4, visine 0.6 i dubine 1.6, na poziciji (0, 0.4, 0.2)

      Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_METALA]);

      m_box.SetSize(0.4,0.6,1.6);
      Gl.glTranslatef(0.0f, 0.4f, 0.2f);
      m_box.Draw();

      Gl.glPopMatrix();

      Gl.glPushMatrix();
        // TODO 2: Nacrtati osnovu gornjem krila kao kvadar sirine 0.15, visine 0.4 i dubine 1.0 na poziciji (0, 0.8, -0.1)
      Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_METALA]);

      m_box.SetSize(0.15, 0.4, 1.0);
      Gl.glTranslatef(0.0f, 0.8f, -0.1f);
      m_box.Draw();    

      Gl.glPopMatrix();

      // TODO 2: Podesiti orijentaciju poligona lica da budu CW

      Gl.glFrontFace(Gl.GL_CW);

      // Kabina satla
      Gl.glColor3ub(100, 100, 100);
      Gl.glPushMatrix();

        // TODO 2: Translirati za 0.84 po y-osi i 0.85 po z-osi, zatim zarotirati za 8 stepeni oko x-ose

      Gl.glTranslatef(0.0f, 0.84f, 0.85f);
      Gl.glRotatef(8.0f, 1.0f, 0.0f, 0.0f);


        // TODO 2: Nacrtati omotac kabine koriscenjem GL_QUAD_STRIP primitive
        //         temena su (u pravilnom redosledu): (0.1, -0.6, 1.2), (0.3, 0.0, 0.0), (0.1, -0.7, 1.0), (0.3, -0.7, 0.0),
        //                                            (-0.1, -0.7, 1.0), (-0.3, -0.7, 0.0), (-0.1, -0.6, 1.2), (-0.3, 0.0, 0.0),
        //                                            (0.1, -0.6, 1.2), (0.3, 0.0, 0.0).

      Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_STAKLA]);
       Gl.glBegin(Gl.GL_QUAD_STRIP);

       Gl.glNormal3fv(Lighting.FindFaceNormal(0.1f, -0.6f, 1.2f, 0.3f, 0.0f, 0.0f, 0.1f, -0.7f, 1.0f));

       Gl.glTexCoord2f(0.0f, 0.0f);
       Gl.glVertex3f(0.1f, -0.6f, 1.2f);
       Gl.glTexCoord2f(0.0f, 1.0f);
       Gl.glVertex3f(0.3f, 0.0f, 0.0f);
       Gl.glTexCoord2f(1.0f, 1.0f);
       Gl.glVertex3f(0.1f, -0.7f, 1.0f);
       Gl.glTexCoord2f(1.0f, 0.0f);
       Gl.glVertex3f(0.3f, -0.7f, 0.0f);

       Gl.glNormal3fv(Lighting.FindFaceNormal(-0.1f, -0.7f, 1.0f, -0.3f, -0.7f, 0.0f, -0.1f, -0.6f, 1.2f));

       Gl.glTexCoord2f(0.0f, 0.0f);
       Gl.glVertex3f(-0.1f, -0.7f, 1.0f);
       Gl.glTexCoord2f(0.0f, 1.0f);
       Gl.glVertex3f(-0.3f, -0.7f, 0.0f);
       Gl.glTexCoord2f(1.0f, 1.0f);
       Gl.glVertex3f(-0.1f, -0.6f, 1.2f);


       Gl.glNormal3fv(Lighting.FindFaceNormal(-0.3f, 0.0f, 0.0f, 0.1f, -0.6f, 1.2f, 0.3f, 0.0f, 0.0f));

       Gl.glTexCoord2f(0.0f, 0.0f);
       Gl.glVertex3f(-0.3f, 0.0f, 0.0f);
       Gl.glTexCoord2f(0.0f, 0.0f);
       Gl.glVertex3f(0.1f, -0.6f, 1.2f);
       Gl.glTexCoord2f(0.0f, 0.0f);
       Gl.glVertex3f(0.3f, 0.0f, 0.0f);
       Gl.glEnd();
        // TODO 2: Nacrtati baze kabine koriscenjem GL_QUADS primitive
        //         temena su (u pravilnom redosledu): (-0.1, -0.6, 1.2), (0.1, -0.6, 1.2), (0.1, -0.7, 1.0), (-0.1, -0.7, 1.0),
        //                                            (0.3, 0.0, 0.0), (-0.3, 0.0, 0.0), (-0.3, -0.7, 0.0), (0.3, -0.7, 0.0).

       Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_STAKLA]);
           
       Gl.glBegin(Gl.GL_QUADS);


       Gl.glNormal3fv(Lighting.FindFaceNormal(-0.1f, -0.6f, 1.2f, 0.1f, -0.6f, 1.2f, 0.1f, -0.7f, 1.0f));

       Gl.glTexCoord2f(0.0f, 0.0f);
       Gl.glVertex3f(-0.1f, -0.6f, 1.2f);
       Gl.glTexCoord2f(0.0f, 1.0f);
       Gl.glVertex3f(0.1f, -0.6f, 1.2f);
       Gl.glTexCoord2f(1.0f, 1.0f);
       Gl.glVertex3f(0.1f, -0.7f, 1.0f);
       Gl.glTexCoord2f(1.0f, 0.0f);
       Gl.glVertex3f(-0.1f, -0.7f, 1.0f);

      Gl.glNormal3fv(Lighting.FindFaceNormal(0.3f, 0.0f, 0.0f, -0.3f, 0.0f, 0.0f, -0.3f, -0.7f, 0.0f));

      Gl.glTexCoord2f(0.0f, 0.0f);
      Gl.glVertex3f(0.3f, 0.0f, 0.0f);
      Gl.glTexCoord2f(0.0f, 1.0f);
      Gl.glVertex3f(-0.3f, 0.0f, 0.0f);
      Gl.glTexCoord2f(1.0f, 1.0f);
      Gl.glVertex3f(-0.3f, -0.7f, 0.0f);
      Gl.glTexCoord2f(1.0f, 0.0f);
      Gl.glVertex3f(0.3f, -0.7f, 0.0f);
      Gl.glEnd();

      Gl.glPopMatrix();

      // Gornje krilo
      Gl.glColor3ub(180, 180, 180);
      Gl.glPushMatrix();
        // TODO 2: Translirati u tacku (-0.05, 1.2, -0.7) i skalirati 1.2 puta po y-osi i 1.15 puta po z-osi
      Gl.glTranslatef(-0.05f, 1.2f, -0.7f);
      Gl.glScalef(1.0f, 1.2f, 1.15f);
    
      
        // TODO 2: Nacrtati omotac gornjeg krila koriscenjem GL_QUAD_STRIP primitive
        //         temena su (u pravilnom redosledu): (0.0, 1.8, 0.4), (0.0, 1.8, 0.0), (0.1, 1.8, 0.4), (0.1, 1.8, 0.0),
        //                                            (0.1, 0.0, 1.5), (0.1, 0.0, 0.0), (0.1, -0.3, 1.1), (0.1, -0.3, 0.0), 
        //                                            (0.0, -0.3, 1.1), (0.0, -0.3, 0.0), (0.0, 0.0, 1.5), (0.0, 0.0, 0.0),
        //                                            (0.0, 1.8, 0.4), (0.0, 1.8, 0.0).

      Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_KRILA]);
    
      Gl.glBegin(Gl.GL_QUAD_STRIP);

      Gl.glNormal3fv(Lighting.FindFaceNormal(0.0f, 1.8f, 0.4f, 0.0f, 1.8f, 0.0f, 0.1f, 1.8f, 0.4f));

      Gl.glTexCoord2f(0.0f, 0.0f);      Gl.glVertex3f(0.0f, 1.8f, 0.4f);
      Gl.glTexCoord2f(0.0f, 1.0f);      Gl.glVertex3f(0.0f, 1.8f, 0.0f);
      Gl.glTexCoord2f(1.0f, 1.0f);      Gl.glVertex3f(0.1f, 1.8f, 0.4f);
      Gl.glTexCoord2f(1.0f, 0.0f);      Gl.glVertex3f(0.1f, 1.8f, 0.0f);

      Gl.glNormal3fv(Lighting.FindFaceNormal(0.1f, 0.0f, 1.5f, 0.1f, 0.0f, 0.0f, 0.1f, -0.3f, 1.1f));

      Gl.glTexCoord2f(0.0f, 0.0f);      Gl.glVertex3f(0.1f, 0.0f, 1.5f);
      Gl.glTexCoord2f(0.0f, 1.0f);      Gl.glVertex3f(0.1f, 0.0f, 0.0f);
      Gl.glTexCoord2f(1.0f, 1.0f);      Gl.glVertex3f(0.1f, -0.3f, 1.1f);
      Gl.glTexCoord2f(1.0f, 0.0f);      Gl.glVertex3f(0.1f, -0.3f, 0.0f);

      Gl.glNormal3fv(Lighting.FindFaceNormal(0.0f, -0.3f, 1.1f, 0.0f, -0.3f, 0.0f, 0.0f, 0.0f, 1.5f));

      Gl.glTexCoord2f(0.0f, 0.0f);      Gl.glVertex3f(0.0f, -0.3f, 1.1f);
      Gl.glTexCoord2f(0.0f, 1.0f);      Gl.glVertex3f(0.0f, -0.3f, 0.0f);
      Gl.glTexCoord2f(1.0f, 1.0f);      Gl.glVertex3f(0.0f, 0.0f, 1.5f);

      Gl.glNormal3fv(Lighting.FindFaceNormal(0.0f, 0.0f, 0.0f, 0.0f, 1.8f, 0.4f, 0.0f, 1.8f, 0.0f));

      Gl.glTexCoord2f(0.0f, 0.0f);      Gl.glVertex3f(0.0f, 0.0f, 0.0f);
      Gl.glTexCoord2f(0.0f, 1.0f);      Gl.glVertex3f(0.0f, 1.8f, 0.4f);
      Gl.glTexCoord2f(1.0f, 1.0f);      Gl.glVertex3f(0.0f, 1.8f, 0.0f);
      Gl.glEnd();
        // TODO 2: Nacrtati zadnju bazu gornjeg krila koriscenjem GL_QUADS primitive
        //         temena su (u pravilnom redosledu): (0.1, 1.8, 0.0), (0.0, 1.8, 0.0), (0.0, -0.3, 0.0), (0.1, -0.3, 0.0).

      Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_KRILA]);
     
      Gl.glBegin(Gl.GL_QUADS);

      Gl.glNormal3fv(Lighting.FindFaceNormal(0.1f, 1.8f, 0.0f, 0.0f, 1.8f, 0.0f, 0.0f, -0.3f, 0.0f));

      Gl.glTexCoord2f(0.0f, 0.0f);      Gl.glVertex3f(0.1f, 1.8f, 0.0f);
      Gl.glTexCoord2f(0.0f, 1.0f);      Gl.glVertex3f(0.0f, 1.8f, 0.0f);
      Gl.glTexCoord2f(1.0f, 1.0f);      Gl.glVertex3f(0.0f, -0.3f, 0.0f);
      Gl.glTexCoord2f(1.0f, 0.0f);      Gl.glVertex3f(0.1f, -0.3f, 0.0f);
      Gl.glEnd();
        // TODO 2: Nacrtati prednju bazu gornjeg krila koriscenjem GL_QUAD_STRIP primitive
        //         temena su (u pravilnom redosledu): (0.0, 1.8, 0.4), (0.1, 1.8, 0.4), (0.0, 0.0, 1.5), (0.1, 0.0, 1.5), 
        //                                            (0.0, -0.3, 1.1), (0.1, -0.3, 1.1).

      Gl.glBindTexture(Gl.GL_TEXTURE_2D, World.textures[(int)World.TextureObjects.TEKSTURA_KRILA]);
    
      Gl.glBegin(Gl.GL_QUAD_STRIP);

      Gl.glNormal3fv(Lighting.FindFaceNormal(0.0f, 1.8f, 0.4f, 0.1f, 1.8f, 0.4f, 0.0f, 0.0f, 1.5f));

      Gl.glTexCoord2f(0.0f, 0.0f);      Gl.glVertex3f(0.0f, 1.8f, 0.4f);
      Gl.glTexCoord2f(0.0f, 1.0f);      Gl.glVertex3f(0.1f, 1.8f, 0.4f);
      Gl.glTexCoord2f(1.0f, 1.0f);      Gl.glVertex3f(0.0f, 0.0f, 1.5f);


       Gl.glNormal3fv(Lighting.FindFaceNormal( 0.1f, 0.0f, 1.5f, 0.0f, -0.3f, 1.1f, 0.1f, -0.3f, 1.1f));


       Gl.glTexCoord2f(0.0f, 0.0f);       Gl.glVertex3f(0.1f, 0.0f, 1.5f);
       Gl.glTexCoord2f(0.0f, 1.0f);       Gl.glVertex3f(0.0f, -0.3f, 1.1f);
       Gl.glTexCoord2f(1.0f, 1.0f);       Gl.glVertex3f(0.1f, -0.3f, 1.1f);
      Gl.glEnd();

      Gl.glPopMatrix();

      // TODO 2: Podesiti orijentaciju poligona lica da budu CCW
      Gl.glFrontFace(Gl.GL_CCW);

      // Laserski top
      Gl.glColor3ub(28, 28, 28);
      Gl.glTranslated(0, -0.1, 0.5);
      Gl.glScaled(1.5, 1.5, 1);
        DrawLaserCanon();
      Gl.glPopMatrix();
      }

    // TODO 3: Osloboditi resurse koriscenjem Dispose metode i IDisposable interfejsa 
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            // Oslodi managed resurse
        }

        // Oslobodi OpenGL resurse
        Terminate();
    }

    private void Terminate()
    {
        // Oslobodi alocirane identifikatore DL liste i VBO objekta
        Glu.gluDeleteQuadric(m_gluObj);
        Gl.glDeleteLists(m_wingDL, 1);
   
    }
    #endregion Metode
  }
}
