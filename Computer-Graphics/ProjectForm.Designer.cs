namespace RacunarskaGrafika.Vezbe
{
    partial class ProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            this.m_world.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openglControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // openglControl
            // 
            this.openglControl.AccumBits = ((byte)(0));
            this.openglControl.AutoCheckErrors = false;
            this.openglControl.AutoFinish = false;
            this.openglControl.AutoMakeCurrent = true;
            this.openglControl.AutoSwapBuffers = true;
            this.openglControl.BackColor = System.Drawing.Color.Black;
            this.openglControl.ColorBits = ((byte)(32));
            this.openglControl.DepthBits = ((byte)(16));
            this.openglControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openglControl.Location = new System.Drawing.Point(0, 0);
            this.openglControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openglControl.Name = "openglControl";
            this.openglControl.Size = new System.Drawing.Size(1176, 749);
            this.openglControl.StencilBits = ((byte)(0));
            this.openglControl.TabIndex = 0;
            this.openglControl.Paint += new System.Windows.Forms.PaintEventHandler(this.OpenGlControlPaint);
            this.openglControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpenGlControlKeyDown);
            this.openglControl.Resize += new System.EventHandler(this.OpenGlControlResize);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 749);
            this.Controls.Add(this.openglControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProjectForm";
            this.Text = "Predmetni projekat";
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl openglControl;
        private System.Windows.Forms.Timer timer1;
    }
}

