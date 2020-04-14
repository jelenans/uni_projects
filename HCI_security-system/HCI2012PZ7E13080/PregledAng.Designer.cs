namespace HCI2012PZ7E13080
{
    partial class Pregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pregled));
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.dgvPregledAng = new System.Windows.Forms.DataGridView();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmbg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dozvola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledAng)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(740, 8);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(98, 26);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(740, 335);
            this.btnNazad.Margin = new System.Windows.Forms.Padding(2);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(98, 26);
            this.btnNazad.TabIndex = 7;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // dgvPregledAng
            // 
            this.dgvPregledAng.AllowUserToAddRows = false;
            this.dgvPregledAng.AllowUserToDeleteRows = false;
            this.dgvPregledAng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledAng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ime,
            this.prz,
            this.sifra,
            this.jmbg,
            this.dozvola,
            this.kat});
            this.dgvPregledAng.Location = new System.Drawing.Point(8, 8);
            this.dgvPregledAng.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPregledAng.Name = "dgvPregledAng";
            this.dgvPregledAng.ReadOnly = true;
            this.dgvPregledAng.RowTemplate.Height = 28;
            this.dgvPregledAng.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPregledAng.Size = new System.Drawing.Size(718, 353);
            this.dgvPregledAng.TabIndex = 8;
            // 
            // ime
            // 
            this.ime.HeaderText = "Ime i prezime zaposlenog";
            this.ime.Name = "ime";
            this.ime.ReadOnly = true;
            this.ime.Width = 105;
            // 
            // prz
            // 
            this.prz.HeaderText = "Ime i prezime klijenta";
            this.prz.Name = "prz";
            this.prz.ReadOnly = true;
            this.prz.Width = 105;
            // 
            // sifra
            // 
            this.sifra.HeaderText = "Datum angažovanja";
            this.sifra.Name = "sifra";
            this.sifra.ReadOnly = true;
            this.sifra.Width = 105;
            // 
            // jmbg
            // 
            this.jmbg.HeaderText = "Datum prekida angažovanja";
            this.jmbg.Name = "jmbg";
            this.jmbg.ReadOnly = true;
            this.jmbg.Width = 105;
            // 
            // dozvola
            // 
            this.dozvola.HeaderText = "Razlog angažovanja";
            this.dozvola.Name = "dozvola";
            this.dozvola.ReadOnly = true;
            this.dozvola.Width = 105;
            // 
            // kat
            // 
            this.kat.HeaderText = "Komentar";
            this.kat.Name = "kat";
            this.kat.ReadOnly = true;
            this.kat.Width = 150;
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 399);
            this.Controls.Add(this.dgvPregledAng);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Pregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled angažovanja zaposlenih";
            this.Load += new System.EventHandler(this.Pregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledAng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.DataGridView dgvPregledAng;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prz;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmbg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dozvola;
        private System.Windows.Forms.DataGridViewTextBoxColumn kat;
    }
}