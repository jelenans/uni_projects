// -----------------------------------------------------------------------
// <file>World.cs</file>
// <copyright>Grupa za Grafiku, Interakciju i Multimediju 2012.</copyright>
// <author>Srdjan Mihic</author>
// <summary>Klasa koja enkapsulira OpenGL programski kod.</summary>
// -----------------------------------------------------------------------
namespace RacunarskaGrafika.Vezbe
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Windows.Forms;
    using Tao.OpenGl;
    using Projekat;


    /// <summary>
    ///  Klasa enkapsulira OpenGL kod i omogucavanje njegovo iscrtavanje i azuriranje.
    /// </summary>
    public class World : IDisposable
    {
        #region Atributi

        /// <summary>
        ///	 Ugao rotacije sveta oko Y ose.
        /// </summary>
        private float m_yRotation = 0.0f;

        /// <summary>
        ///	 Ugao rotacije sveta oko X ose.
        /// </summary>
        private float m_xRotation = 15.0f;

        /// <summary>
        ///	 Pozicija pogleda na svet po Z osi.
        /// </summary>
        private float m_zPos = 0.0f;

        private float pomeraj = 0.0f;
        private float pomeraj_falcon = 0.0f;
        public static float pomeraj_metak = 7.0f;
        public static float pomeraj_metak_x = 0.0f;
        public static bool[] meci = new bool[10];
        public static int i = 0;

        /// <summary>
        ///	 Satl koji se iscrtava.
        /// </summary>
        private ImperialShuttle m_shuttle = null;

        private MilleniumFalcon m_falcon = null;

        /// <summary>
        ///	 Sirina OpenGL kontrole u pikselima.
        /// </summary>
        private int m_width;

        /// <summary>
        ///	 Visina OpenGL kontrole u pikselima.
        /// </summary>
        private int m_height;

        BitmapFont m_font = null;


        private Glu.GLUquadric m_gluObj;

        /// <summary>
        ///	 Identifikatori tekstura za jednostavniji pristup teksturama
        /// </summary>
        public enum TextureObjects
        {
            TEKSTURA_STAKLA = 0,
            TEKSTURA_KRILA,
            TEKSTURA_METALA,
            TEKSTURA_SREBRA
        };

        private readonly int textureCount = Enum.GetNames(typeof(TextureObjects)).Length;

        /// <summary>
        ///	 Identifikatori OpenGL tekstura
        /// </summary>
        public static int[] textures = null;

        /// <summary>
        ///	 Putanje do slika koje se koriste za teksture
        /// </summary>
        static string[] textureFiles = { "..//..//images//staklo.jpg", 
                                       "..//..//images//metal_sivo.jpg",
                                       "..//..//images//metal_rdja.jpg", 
                                       "..//..//images//metal_srebro.jpg",
                                     };

        /// <summary>
        ///	 Relativni pomeraj teksture po S osi
        /// </summary>


        #endregion Atributi

        #region Properties

        /// <summary>
        ///	 Ugao rotacije sveta oko Y ose.
        /// </summary>
        public float RotationY
        {
            get { return m_yRotation; }
            set { m_yRotation = value; }
        }

        /// <summary>
        ///	 Ugao rotacije sveta oko X ose.
        /// </summary>
        public float RotationX
        {
            get { return m_xRotation; }
            set { m_xRotation = value; }
        }

        /// <summary>
        ///	 Pozicija pogleda na svet po Z osi.
        /// </summary>
        public float PositionZ
        {
            get { return m_zPos; }
            set { m_zPos = value; }
        }

        public float Pomeraj
        {
            get { return pomeraj; }
            set { pomeraj = value; }
        }

        public float Pomeraj_falcon
        {
            get { return pomeraj_falcon; }
            set { pomeraj_falcon = value; }
        }

        public float Pomeraj_metak
        {
            get { return pomeraj_metak; }
            set { pomeraj_metak = value; }
        }

        public float Pomeraj_metak_x
        {
            get { return pomeraj_metak_x; }
            set { pomeraj_metak_x = value; }
        }
        /// <summary>
        ///	 Sirina OpenGL kontrole u pikselima.
        /// </summary>
        public int Width
        {
            get { return m_width; }
            set { m_width = value; }
        }

        /// <summary>
        ///	 Visina OpenGL kontrole u pikselima.
        /// </summary>
        public int Height
        {
            get { return m_height; }
            set { m_height = value; }
        }


        #endregion Properties

        #region Konstruktori

        /// <summary>
        ///		Konstruktor.
        /// </summary>
        /// <param name="handle">Visina OpenGL kontrole u pikselima.</param>
        /// <param name="creator">Sirina OpenGL kontrole u pikselima.</param>
        public World(int width, int height)
        {
            // Inicijalizacija atributa
            m_width = width;
            m_height = height;

            try
            {
                textures = new int[textureCount];
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspesno kreirana niz identifikatora za teksture", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                m_shuttle = new ImperialShuttle();
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspesno kreirana instanca klase ImperialShuttle", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                m_falcon = new MilleniumFalcon();
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspesno kreirana instanca klase MilleniumFalcon", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                m_font = new BitmapFont("Helvetica", 10, false, false, true, false);
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspesno kreirana instanca klase BitmapFont", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Korisnicka inicijalizacija OpenGL parametara
            Initialize();

            // Podesi projekciju i viewport
            Resize();
        }

        #endregion Konstruktori

        #region Metode

        /// <summary>
        /// Korisnicka inicijalizacija i podesavanje OpenGL parametara
        /// </summary>
        public void Initialize()
        {

            float[] ambientReflectLightYellow = { 0.7f, 0.5f, 0.1f, 1.0f };
            float[] diffuseReflectLightYellow = { 0.6f, 0.8f, 0.1f, 1.0f };

            float[] ambientSpotLightGreen = { 0.0f, 0.2f, 0.0f, 1.0f };
            float[] diffuseSpotLightGreen = { 0.0f, 1.0f, 0.0f, 1.0f };

            float[] pozicijaReflek = { 5.0f, 5.0f, -13.0f, 1.0f };

            float[] smer = { -1, -1, 0 };
            float[] pozicijaTackasti = { 0.0f, -0.7f, -9.5f, 0.0f };

            Bitmap image;  // promenljiva u koju ucitavamo sadrzaj slike


            Gl.glClearColor(0.0f, 0.0f, 0.2588f, 1.0f); // teget boja

            m_gluObj = Glu.gluNewQuadric();
            Glu.gluQuadricNormals(m_gluObj, Glu.GLU_SMOOTH);

            // Podesiti generisanje koordinata teksture za GLU objekat - gluObj
            Glu.gluQuadricTexture(m_gluObj, Gl.GL_TRUE);

            // TODO 1: Ukljuciti depth testing, back face culling
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_CULL_FACE);

            // TODO 1: Podesiti da prednji poligoni budu u CW orijentaciji
            Gl.glFrontFace(Gl.GL_CW);


            /*Definisati reflektorski  svetlosni  izvor*/
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_AMBIENT, ambientReflectLightYellow);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, diffuseReflectLightYellow);
            Gl.glLightf(Gl.GL_LIGHT0, Gl.GL_SPOT_CUTOFF, 35.0f);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, pozicijaReflek);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_SPOT_DIRECTION, smer);

            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_AMBIENT, ambientSpotLightGreen);
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_DIFFUSE, diffuseSpotLightGreen);
            Gl.glLightf(Gl.GL_LIGHT1, Gl.GL_SPOT_CUTOFF, 180.0f);
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_POSITION, pozicijaTackasti);

            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glEnable(Gl.GL_LIGHT1);
            Gl.glEnable(Gl.GL_NORMALIZE);


            /* Ukljuciti color  tracking  mehanizam  i  podesiti  da  se  pozivom  metode glColor  definiše 
               ambijentalna i difuzna komponenta materijala*/
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glColorMaterial(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE);


            // Teksture se primenjuju sa parametrom decal
            Gl.glEnable(Gl.GL_TEXTURE_2D);
          //  Gl.glTexEnvi(Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE, Gl.GL_DECAL); //stapanje teksture sa materijalom

            // Ucitaj slike i kreiraj teksture
            Gl.glGenTextures(textureCount, textures);

            for (int i = 0; i < textureCount; ++i)
            {
                // Pridruzi teksturu odgovarajucem identifikatoru
                Gl.glBindTexture(Gl.GL_TEXTURE_2D, textures[i]);

                // Ucitaj sliku i podesi parametre teksture
                image = new Bitmap(textureFiles[i]);
                // rotiramo sliku zbog koordinantog sistema opengl-a
                image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
                // RGBA format (dozvoljena providnost slike tj. alfa kanal)
                BitmapData imageData = image.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly,
                                                      System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                Glu.gluBuild2DMipmaps(Gl.GL_TEXTURE_2D, (int)Gl.GL_RGBA8, image.Width, image.Height, Gl.GL_BGRA, Gl.GL_UNSIGNED_BYTE, imageData.Scan0);

                //  Podesiti texture filtre: max = linear, min=linear_mipmap_linear,
                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);  // ?

                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_REPEAT);
                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_REPEAT);

                image.UnlockBits(imageData);
                image.Dispose();
            }

         


            // Lepsi izgled
            Gl.glEnable(Gl.GL_POLYGON_SMOOTH);
            Gl.glEnable(Gl.GL_POINT_SMOOTH);
            Gl.glEnable(Gl.GL_LINE_SMOOTH);
            Gl.glHint(Gl.GL_POLYGON_SMOOTH_HINT, Gl.GL_NICEST);
            Gl.glHint(Gl.GL_LINE_SMOOTH_HINT, Gl.GL_NICEST);
            Gl.glHint(Gl.GL_POINT_SMOOTH_HINT, Gl.GL_NICEST);
        }

        /// <summary>
        /// Podesava viewport i projekciju za OpenGL kontrolu.
        /// </summary>
        public void Resize()
        {
            // TODO 1: Definisati viewport preko celog prozora
            Gl.glViewport(0, 0, m_width, m_height);

            // TODO 1: Definisati projekciju u perspektivi sa fov = 75.0, near = 1.5 i far = 55.0

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(75.0, (double)m_width / (double)m_height, 1.5, 55.0);  // 2.parametar?
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();


        }

        /// <summary>
        /// Iscrtavanje OpenGL kontrole
        /// </summary>
        public void Draw()
        {
            // Obrisi sadrzaj kolor i depth bafera
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Resize();
            // !!!!!!!!!!!!!!!!!! Sacuvaj stanje modelview matrice i primeni transformacije
            Gl.glPushMatrix();

            

            // Primeni transformacije
            Gl.glTranslated(0.0, -0.7, -15.0);

            Glu.gluLookAt(-0.3, -0.2, m_zPos, 0.1, -0.2, -0.8, 0.0, 1.0, 0.0);


            Gl.glRotated(m_xRotation, 1.0, 0.0, 0.0);
            Gl.glRotated(m_yRotation, 0.0, 1.0, 0.0);

            // TODO 5: Nacrtati Millenium Falcon svemirski brod, koji se inicijalno nalazi ispred satla.
            //         Entitet implementirati u posebnom fajlu kao klasu koja implementira IDrawable interfejs.

            //Gl.glPushMatrix();


            //Gl.glDisable(Gl.GL_TEXTURE_2D);
            //// postavi tackasti izvor svetlosti
            //Gl.glTranslatef(-2.5f, -0.5f, 2.0f);
            //Gl.glPushAttrib(Gl.GL_LIGHTING_BIT);
            //// Iskljuci osvetljenje jer zelimo da boja sijalice uvek bude zelena
            //Gl.glDisable(Gl.GL_LIGHTING);
            //Gl.glColor3ub(0, 255, 0);
            //// Glu.gluSphere(m_gluObj, 0.1f, 60, 60);
            //// Restauriraj stanje osvetljenja
            //Gl.glPopAttrib();

            //Gl.glEnable(Gl.GL_TEXTURE_2D);
            //Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(pomeraj_falcon, 0.0f, 0.0f);
            Gl.glTexEnvi(Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE,
                         Gl.GL_MODULATE);
            m_falcon.Draw();
            Gl.glPopMatrix();

            // TODO 2: Iscrtati satl m_shuttle
            Gl.glPushMatrix();
            Gl.glTranslatef(pomeraj, 0.0f, 0.0f);
            Gl.glTexEnvi(Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE,
                         Gl.GL_DECAL);
            m_shuttle.Draw();
            Gl.glPopMatrix();


            Gl.glPopMatrix();

            // TODO 4: Ispisati bitmap tekst belom bojom u gornjem desnom uglu prozora uz definiciju projekcije koristeci gluOrtho2D metodu. Tekst treba biti oblika:
            // Predmet:   Racunarska grafika
            // Sk.god:    2012./13.
            // Ime:       ime_studenta
            // Prezime:   prezime_studenta
            // Sifra zad: sifra_zadatka
            // Font treba da bude underline, 10 pt, Helvetica

            Gl.glDisable(Gl.GL_DEPTH_TEST);
            Gl.glDisable(Gl.GL_LIGHTING);
            Gl.glDisable(Gl.GL_TEXTURE_2D);

            Gl.glViewport(0, 0, m_width, m_height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluOrtho2D(-m_width / 2.0, m_width / 2.0, -m_height / 2.0, m_height / 2.0);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glColor3ub(255, 255, 255);



            Gl.glRasterPos2f(0.0f, m_height / 2.0f - m_font.Height - 20.0f);
            m_font.DrawText("Predmet:   Racunarska grafika");

            Gl.glRasterPos2f(0.0f, m_height / 2.0f - m_font.Height - 40.0f);
            m_font.DrawText("Sk.god:    2012./13.");

            Gl.glRasterPos2f(0.0f, m_height / 2.0f - m_font.Height - 60.0f);
            m_font.DrawText("Ime:       Jelena");

            Gl.glRasterPos2f(0.0f, m_height / 2.0f - m_font.Height - 80.0f);
            m_font.DrawText("Prezime:   Pantovic");

            Gl.glRasterPos2f(0.0f, m_height / 2.0f - m_font.Height - 100.0f);
            m_font.DrawText("Indeks:    E13080");
            Gl.glRasterPos2f(0.0f, m_height / 2.0f - m_font.Height - 120.0f);
            m_font.DrawText("Sifra zad: 6");

            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glFlush();
        }

        public void Update()
        {
            if (Pomeraj < 3.0f)
                m_shuttle.PozicijaSnopa1 += 0.5f;
            else
                m_shuttle.PozicijaSnopa2 += 0.2f;


        }

        /// <summary>
        ///  Dispose metoda.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///  Destruktor.
        /// </summary>
        ~World()
        {
            this.Dispose(false);
        }

        #endregion Metode

        #region IDisposable metode

        /// <summary>
        ///  Implementacija IDisposable interfejsa.
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            // Oslobodi OpenGL resurse
            Terminate();
        }

        /// <summary>
        ///  Korisnicko oslobadjanje OpenGL resursa.
        /// </summary>
        private void Terminate()
        {
            // TODO 3: Osloboditi OpenGL resurse

            Glu.gluDeleteQuadric(m_gluObj);
            m_font.Dispose();
        }

        #endregion IDisposable metode
    }
}
