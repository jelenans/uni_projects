namespace HCI2012PZ7E13080
{
    partial class IzmenaZaposlenog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmenaZaposlenog));
            this.dtpZap = new System.Windows.Forms.DateTimePicker();
            this.tbPrez = new System.Windows.Forms.TextBox();
            this.tbSif = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.otvoriSliku = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cbKat = new System.Windows.Forms.ComboBox();
            this.mtbJmb = new System.Windows.Forms.MaskedTextBox();
            this.rtbKom = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpIzdav = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chbIma = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpZap
            // 
            this.dtpZap.Location = new System.Drawing.Point(130, 230);
            this.dtpZap.Name = "dtpZap";
            this.dtpZap.Size = new System.Drawing.Size(182, 20);
            this.dtpZap.TabIndex = 44;
            // 
            // tbPrez
            // 
            this.tbPrez.Location = new System.Drawing.Point(130, 79);
            this.tbPrez.Name = "tbPrez";
            this.tbPrez.Size = new System.Drawing.Size(182, 20);
            this.tbPrez.TabIndex = 43;
            this.tbPrez.TextChanged += new System.EventHandler(this.tbPrez_TextChanged);
            this.tbPrez.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrez_KeyPress);
            this.tbPrez.Leave += new System.EventHandler(this.tbPrez_Leave);
            // 
            // tbSif
            // 
            this.tbSif.Location = new System.Drawing.Point(130, 128);
            this.tbSif.Name = "tbSif";
            this.tbSif.ReadOnly = true;
            this.tbSif.Size = new System.Drawing.Size(182, 20);
            this.tbSif.TabIndex = 42;
            this.tbSif.TextChanged += new System.EventHandler(this.tbSif_TextChanged);
            this.tbSif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSif_KeyPress);
            this.tbSif.Leave += new System.EventHandler(this.tbSif_Leave);
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(130, 29);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(182, 20);
            this.tbIme.TabIndex = 40;
            this.tbIme.TextChanged += new System.EventHandler(this.tbIme_TextChanged);
            this.tbIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIme_KeyPress);
            this.tbIme.Leave += new System.EventHandler(this.tbIme_Leave);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(380, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 24);
            this.button3.TabIndex = 39;
            this.button3.Text = "Izaberi sliku...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlika.Location = new System.Drawing.Point(380, 29);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(120, 140);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 38;
            this.pbSlika.TabStop = false;
            // 
            // otvoriSliku
            // 
            this.otvoriSliku.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Datum zaposlenja: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "JMBG:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Kategorija:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Šifra: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ime: ";
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(404, 391);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(125, 33);
            this.btnPonisti.TabIndex = 28;
            this.btnPonisti.Text = "Poništiti";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(260, 391);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(125, 33);
            this.btnSacuvaj.TabIndex = 27;
            this.btnSacuvaj.Text = "Sačuvati";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cbKat
            // 
            this.cbKat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKat.FormattingEnabled = true;
            this.cbKat.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbKat.Location = new System.Drawing.Point(276, 334);
            this.cbKat.Name = "cbKat";
            this.cbKat.Size = new System.Drawing.Size(36, 21);
            this.cbKat.TabIndex = 53;
            // 
            // mtbJmb
            // 
            this.mtbJmb.Location = new System.Drawing.Point(130, 175);
            this.mtbJmb.Mask = "0000000000000";
            this.mtbJmb.Name = "mtbJmb";
            this.mtbJmb.Size = new System.Drawing.Size(182, 20);
            this.mtbJmb.TabIndex = 54;
            this.mtbJmb.TextChanged += new System.EventHandler(this.mtbJmb_TextChanged);
            this.mtbJmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbJmb_KeyPress);
            this.mtbJmb.Leave += new System.EventHandler(this.mtbJmb_Leave);
            // 
            // rtbKom
            // 
            this.rtbKom.Location = new System.Drawing.Point(358, 264);
            this.rtbKom.Name = "rtbKom";
            this.rtbKom.Size = new System.Drawing.Size(173, 91);
            this.rtbKom.TabIndex = 57;
            this.rtbKom.Text = "";
            this.rtbKom.TextChanged += new System.EventHandler(this.rtbKom_TextChanged);
            this.rtbKom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbKom_KeyPress);
            this.rtbKom.Leave += new System.EventHandler(this.rtbKom_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Komentar:";
            // 
            // dtpIzdav
            // 
            this.dtpIzdav.Location = new System.Drawing.Point(130, 282);
            this.dtpIzdav.Name = "dtpIzdav";
            this.dtpIzdav.Size = new System.Drawing.Size(182, 20);
            this.dtpIzdav.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Datum izdavanja:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Dozvola za oružje: ";
            // 
            // chbIma
            // 
            this.chbIma.AutoSize = true;
            this.chbIma.Location = new System.Drawing.Point(130, 341);
            this.chbIma.Name = "chbIma";
            this.chbIma.Size = new System.Drawing.Size(43, 17);
            this.chbIma.TabIndex = 62;
            this.chbIma.Text = "Ima";
            this.chbIma.UseVisualStyleBackColor = true;
            // 
            // IzmenaZaposlenog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 435);
            this.Controls.Add(this.chbIma);
            this.Controls.Add(this.dtpIzdav);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtbKom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mtbJmb);
            this.Controls.Add(this.cbKat);
            this.Controls.Add(this.dtpZap);
            this.Controls.Add(this.tbPrez);
            this.Controls.Add(this.tbSif);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnSacuvaj);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "IzmenaZaposlenog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmena podataka o zaposlenom";
            this.Load += new System.EventHandler(this.IzmenaZaposlenog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpZap;
        private System.Windows.Forms.TextBox tbPrez;
        private System.Windows.Forms.TextBox tbSif;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.OpenFileDialog otvoriSliku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cbKat;
        private System.Windows.Forms.MaskedTextBox mtbJmb;
        private System.Windows.Forms.RichTextBox rtbKom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpIzdav;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbIma;
    }
}