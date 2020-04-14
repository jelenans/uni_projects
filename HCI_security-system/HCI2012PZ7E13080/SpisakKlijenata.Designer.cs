namespace HCI2012PZ7E13080
{
    partial class SpisakKlijenata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpisakKlijenata));
            this.btnNazad = new System.Windows.Forms.Button();
            this.dgvSpisakZap = new System.Windows.Forms.DataGridView();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmbg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpisakZap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(725, 352);
            this.btnNazad.Margin = new System.Windows.Forms.Padding(2);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(82, 26);
            this.btnNazad.TabIndex = 10;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // dgvSpisakZap
            // 
            this.dgvSpisakZap.AllowUserToAddRows = false;
            this.dgvSpisakZap.AllowUserToDeleteRows = false;
            this.dgvSpisakZap.AllowUserToResizeColumns = false;
            this.dgvSpisakZap.AllowUserToResizeRows = false;
            this.dgvSpisakZap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpisakZap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ime,
            this.prz,
            this.sifra,
            this.jmbg,
            this.dat,
            this.delat,
            this.pol,
            this.kat});
            this.dgvSpisakZap.Location = new System.Drawing.Point(1, -1);
            this.dgvSpisakZap.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSpisakZap.MultiSelect = false;
            this.dgvSpisakZap.Name = "dgvSpisakZap";
            this.dgvSpisakZap.ReadOnly = true;
            this.dgvSpisakZap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSpisakZap.RowTemplate.Height = 28;
            this.dgvSpisakZap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpisakZap.Size = new System.Drawing.Size(819, 349);
            this.dgvSpisakZap.TabIndex = 0;
            this.dgvSpisakZap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpisakZap_CellContentClick);
            // 
            // ime
            // 
            this.ime.HeaderText = "Ime";
            this.ime.Name = "ime";
            this.ime.ReadOnly = true;
            // 
            // prz
            // 
            this.prz.HeaderText = "Prezime";
            this.prz.Name = "prz";
            this.prz.ReadOnly = true;
            // 
            // sifra
            // 
            this.sifra.HeaderText = "Šifra";
            this.sifra.Name = "sifra";
            this.sifra.ReadOnly = true;
            // 
            // jmbg
            // 
            this.jmbg.HeaderText = "JMBG";
            this.jmbg.Name = "jmbg";
            this.jmbg.ReadOnly = true;
            // 
            // dat
            // 
            this.dat.HeaderText = "Datum ugovora";
            this.dat.Name = "dat";
            this.dat.ReadOnly = true;
            // 
            // delat
            // 
            this.delat.HeaderText = "Delatnost";
            this.delat.Name = "delat";
            this.delat.ReadOnly = true;
            // 
            // pol
            // 
            this.pol.HeaderText = "Pol";
            this.pol.Name = "pol";
            this.pol.ReadOnly = true;
            this.pol.Width = 80;
            // 
            // kat
            // 
            this.kat.HeaderText = "Kategorija";
            this.kat.Name = "kat";
            this.kat.ReadOnly = true;
            // 
            // SpisakKlijenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 384);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.dgvSpisakZap);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SpisakKlijenata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled klijenata";
            this.Load += new System.EventHandler(this.SpisakKlijenata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpisakZap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.DataGridView dgvSpisakZap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prz;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmbg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dat;
        private System.Windows.Forms.DataGridViewTextBoxColumn delat;
        private System.Windows.Forms.DataGridViewTextBoxColumn pol;
        private System.Windows.Forms.DataGridViewTextBoxColumn kat;
    }
}