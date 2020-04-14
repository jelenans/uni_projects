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
  
    partial class Main 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnA = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbPovezivanje = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnBrisivezu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradoviPanel1 = new kuku.GradoviPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(12, 326);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(84, 31);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A*";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(194, 326);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(80, 31);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj grad";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(280, 326);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(82, 31);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši grad";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "A.jpg");
            this.imageList1.Images.SetKeyName(1, "B.jpg");
            this.imageList1.Images.SetKeyName(2, "C.jpg");
            this.imageList1.Images.SetKeyName(3, "D.jpg");
            this.imageList1.Images.SetKeyName(4, "E.jpg");
            this.imageList1.Images.SetKeyName(5, "F.jpg");
            this.imageList1.Images.SetKeyName(6, "g.jpg");
            this.imageList1.Images.SetKeyName(7, "H.jpg");
            this.imageList1.Images.SetKeyName(8, "I.jpg");
            this.imageList1.Images.SetKeyName(9, "J.jpg");
            this.imageList1.Images.SetKeyName(10, "K.jpg");
            this.imageList1.Images.SetKeyName(11, "L.jpg");
            this.imageList1.Images.SetKeyName(12, "M.jpg");
            this.imageList1.Images.SetKeyName(13, "N.jpg");
            this.imageList1.Images.SetKeyName(14, "O.jpg");
            this.imageList1.Images.SetKeyName(15, "P.jpg");
            this.imageList1.Images.SetKeyName(16, "Q.jpg");
            this.imageList1.Images.SetKeyName(17, "R.jpg");
            this.imageList1.Images.SetKeyName(18, "S.jpg");
            this.imageList1.Images.SetKeyName(19, "T.jpg");
            this.imageList1.Images.SetKeyName(20, "U.jpg");
            this.imageList1.Images.SetKeyName(21, "V.jpg");
            this.imageList1.Images.SetKeyName(22, "W.jpg");
            this.imageList1.Images.SetKeyName(23, "X.jpg");
            this.imageList1.Images.SetKeyName(24, "Y.jpg");
            this.imageList1.Images.SetKeyName(25, "Z.jpg");
            // 
            // pbPovezivanje
            // 
            this.pbPovezivanje.Location = new System.Drawing.Point(392, 326);
            this.pbPovezivanje.Name = "pbPovezivanje";
            this.pbPovezivanje.Size = new System.Drawing.Size(89, 31);
            this.pbPovezivanje.TabIndex = 4;
            this.pbPovezivanje.Text = "Poveži gradove";
            this.pbPovezivanje.UseVisualStyleBackColor = true;
            this.pbPovezivanje.Click += new System.EventHandler(this.pbPovezivanje_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(185, 1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(172, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Najkraci put izmedju dva grada\r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnBrisivezu
            // 
            this.btnBrisivezu.Location = new System.Drawing.Point(487, 326);
            this.btnBrisivezu.Name = "btnBrisivezu";
            this.btnBrisivezu.Size = new System.Drawing.Size(85, 31);
            this.btnBrisivezu.TabIndex = 6;
            this.btnBrisivezu.Text = "Obriši vezu";
            this.btnBrisivezu.UseVisualStyleBackColor = true;
            this.btnBrisivezu.Click += new System.EventHandler(this.btnBrisivezu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // gradoviPanel1
            // 
            this.gradoviPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.gradoviPanel1.Location = new System.Drawing.Point(12, 24);
            this.gradoviPanel1.Name = "gradoviPanel1";
            this.gradoviPanel1.Size = new System.Drawing.Size(560, 296);
            this.gradoviPanel1.TabIndex = 0;
            this.gradoviPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gradoviPanel1_MouseClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 365);
            this.Controls.Add(this.btnBrisivezu);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pbPovezivanje);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.gradoviPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gradovi";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradoviPanel gradoviPanel1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button pbPovezivanje;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnBrisivezu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;

      


    }
}

