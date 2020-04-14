// -----------------------------------------------------------------------
// <file>ProjectForm.cs</file>
// <copyright>Grupa za Grafiku, Interakciju i Multimediju 2012.</copyright>
// <author>Srdjan Mihic</author>
// <summary>Predmetni projekat - Sifra 6.</summary>
// -----------------------------------------------------------------------
namespace RacunarskaGrafika.Vezbe
{
  using System;
  using System.Windows.Forms;

  public partial class ProjectForm : Form
  {
    #region Atributi

      /// <summary>
      /// Instanca OpenGL sveta
      /// </summary>
      private World m_world = null;

    #endregion Atributi
        
    #region Konstruktori

      public ProjectForm()
      {
        InitializeComponent();

        // Inicijalizacija OpenGL konteksta
        openglControl.InitializeContexts();

        // Kreiranje OpenGL sveta
        try
        {
          m_world = new World(openglControl.Width, openglControl.Height);
        }
        catch (Exception)
        {
          MessageBox.Show("Neuspesno kreirana instanca OpenGL sveta", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
          this.Close();
        }
      }

    #endregion Konstruktori

    #region Rukovaoci dogadjajima OpenGL kontrole

      /// <summary>
      /// Rukovalac dogadjama izmene dimenzija OpenGL kontrole
      /// </summary>
      private void OpenGlControlResize(object sender, EventArgs e)
      {
        base.OnResize(e);

        //m_world.Height = this.Height;
        //m_world.Width = this.Width;
        //m_world.Resize();
      }

      /// <summary>
      /// Rukovalac dogadjaja: iscrtavanje OpenGL kontrole
      /// </summary>
      private void OpenGlControlPaint(object sender, PaintEventArgs e)
      {
        m_world.Draw();
      }

      /// <summary>
      /// Rukovalac dogadjaja: obrada tastera nad OpenGL kontrolom
      /// </summary>
      private void OpenGlControlKeyDown(object sender, KeyEventArgs e)
      {
        
        switch (e.KeyCode)
        {    
          case Keys.F10: this.Close(); break;
          case Keys.W: m_world.RotationX -= 5.0f; break;
          case Keys.S: m_world.RotationX += 5.0f; break;
          case Keys.A: m_world.RotationY -= 5.0f; break;
          //case Keys.D: m_world.RotationY += 5.0f; break;
          case Keys.R: m_world.RotationX -= 2.5f; break;
          case Keys.F: m_world.RotationX += 2.5f; break;
          case Keys.Q: this.Close(); break;
          case Keys.D:
              {
                  if (ModifierKeys == Keys.Alt)
                  {
                      m_world.Pomeraj -= 0.01f;
                      if (m_world.Pomeraj < 0.0f)
                          m_world.Pomeraj = 0.0f;

                  }
                  else
                  {
                      m_world.RotationY -= 2.5f;
                      if (m_world.RotationY < -45.0f)
                          m_world.RotationY = -45.0f;
                  }
              }
              break;
          case Keys.G:
              {
                  if (ModifierKeys == Keys.Alt)
                  {
                      m_world.Pomeraj += 0.01f;
                      if (m_world.Pomeraj > 3.0f)
                          m_world.Pomeraj = 3.0f;

                  }
                  else
                  {
                      m_world.RotationY += 2.5f;
                      if (m_world.RotationY > 45.0f)
                          m_world.RotationY = 45.0f;
                  }
              }
              break;
          case Keys.V:
              {
                  if (m_world.Pomeraj < 6.0f)
                  {
                      timer1.Enabled = true;
                  }
              }
              break;
        
        }

        openglControl.Refresh();
      }

      //private void timer1_Tick(object sender, EventArgs e)
      //{
      //    if (m_world.Pomeraj < 6.0f)
      //    {
      //        m_world.Update();

      //        m_world.Pomeraj += 0.1f;
      //        m_world.Pomeraj_falcon += 0.2f;

      //    }
      //    else
      //        timer1.Enabled = false;
      //    openglControl.Refresh();
      //}

    #endregion Rukovaoci dogadjajima OpenGL kontrole

      private void openglControl_Load(object sender, EventArgs e)
      {

      }

      private void ProjectForm_Load(object sender, EventArgs e)
      {

      }

      private void timer1_Tick(object sender, EventArgs e)
      {
          if (m_world.Pomeraj < 6.0f)
          {
              m_world.Update();

              m_world.Pomeraj += 0.1f;
              m_world.Pomeraj_falcon += 0.2f;

          }
          else
              timer1.Enabled = false;
          
          openglControl.Refresh();
      }

   
  }
}
