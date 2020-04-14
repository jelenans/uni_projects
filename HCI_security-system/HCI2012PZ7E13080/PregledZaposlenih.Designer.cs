namespace HCI2012PZ7E13080
{
    partial class Pregled_zaposlenih
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pregled_zaposlenih));
            this.btnNazad = new System.Windows.Forms.Button();
            this.kom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dozvola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmbg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPregledZap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledZap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(718, 327);
            this.btnNazad.Margin = new System.Windows.Forms.Padding(2);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(91, 26);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // kom
            // 
            this.kom.HeaderText = "Komentar";
            this.kom.Name = "kom";
            this.kom.ReadOnly = true;
            this.kom.Width = 160;
            // 
            // kat
            // 
            this.kat.HeaderText = "Kategorija";
            this.kat.Name = "kat";
            this.kat.ReadOnly = true;
            // 
            // dozvola
            // 
            this.dozvola.HeaderText = "Dozvola za oružje";
            this.dozvola.Name = "dozvola";
            this.dozvola.ReadOnly = true;
            // 
            // dat
            // 
            this.dat.HeaderText = "Datum zaposlenja";
            this.dat.Name = "dat";
            this.dat.ReadOnly = true;
            // 
            // jmbg
            // 
            this.jmbg.HeaderText = "JMBG";
            this.jmbg.Name = "jmbg";
            this.jmbg.ReadOnly = true;
            // 
            // sifra
            // 
            this.sifra.HeaderText = "Sifra";
            this.sifra.Name = "sifra";
            this.sifra.ReadOnly = true;
            // 
            // prz
            // 
            this.prz.HeaderText = "Prezime";
            this.prz.Name = "prz";
            this.prz.ReadOnly = true;
            // 
            // ime
            // 
            this.ime.HeaderText = "Ime";
            this.ime.Name = "ime";
            this.ime.ReadOnly = true;
            // 
            // dgvPregledZap
            // 
            this.dgvPregledZap.AllowUserToAddRows = false;
            this.dgvPregledZap.AllowUserToDeleteRows = false;
            this.dgvPregledZap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledZap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ime,
            this.prz,
            this.sifra,
            this.jmbg,
            this.dat,
            this.dozvola,
            this.kat,
            this.kom});
            this.dgvPregledZap.Location = new System.Drawing.Point(0, -1);
            this.dgvPregledZap.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPregledZap.Name = "dgvPregledZap";
            this.dgvPregledZap.ReadOnly = true;
            this.dgvPregledZap.RowTemplate.Height = 28;
            this.dgvPregledZap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPregledZap.Size = new System.Drawing.Size(820, 324);
            this.dgvPregledZap.TabIndex = 1;
            this.dgvPregledZap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPregledZap_CellContentClick);
            // 
            // Pregled_zaposlenih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 358);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.dgvPregledZap);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "Pregled_zaposlenih";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled zaposlenih";
            this.Load += new System.EventHandler(this.Pregled_zaposlenih_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledZap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.DataGridViewTextBoxColumn kom;
        private System.Windows.Forms.DataGridViewTextBoxColumn kat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dozvola;
        private System.Windows.Forms.DataGridViewTextBoxColumn dat;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmbg;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn prz;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridView dgvPregledZap;
    }
}