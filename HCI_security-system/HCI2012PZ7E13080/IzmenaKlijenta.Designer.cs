namespace HCI2012PZ7E13080
{
    partial class IzmenaKlijenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmenaKlijenta));
            this.cbKat = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbZ = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.tbDel = new System.Windows.Forms.TextBox();
            this.dtpDat = new System.Windows.Forms.DateTimePicker();
            this.tbPrz = new System.Windows.Forms.TextBox();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPon = new System.Windows.Forms.Button();
            this.btnSac = new System.Windows.Forms.Button();
            this.mtbJMBG = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.cbKat.Location = new System.Drawing.Point(126, 360);
            this.cbKat.Name = "cbKat";
            this.cbKat.Size = new System.Drawing.Size(36, 21);
            this.cbKat.TabIndex = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbZ);
            this.groupBox1.Controls.Add(this.rbM);
            this.groupBox1.Location = new System.Drawing.Point(126, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 38);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // rbZ
            // 
            this.rbZ.AutoSize = true;
            this.rbZ.Location = new System.Drawing.Point(90, 11);
            this.rbZ.Name = "rbZ";
            this.rbZ.Size = new System.Drawing.Size(57, 17);
            this.rbZ.TabIndex = 69;
            this.rbZ.TabStop = true;
            this.rbZ.Text = "Ženski";
            this.rbZ.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(18, 11);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(53, 17);
            this.rbM.TabIndex = 68;
            this.rbM.TabStop = true;
            this.rbM.Text = "Muški";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // tbDel
            // 
            this.tbDel.Location = new System.Drawing.Point(127, 261);
            this.tbDel.Name = "tbDel";
            this.tbDel.Size = new System.Drawing.Size(192, 20);
            this.tbDel.TabIndex = 67;
            this.tbDel.TextChanged += new System.EventHandler(this.tbDel_TextChanged);
            this.tbDel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDel_KeyPress);
            this.tbDel.Leave += new System.EventHandler(this.tbDel_Leave);
            // 
            // dtpDat
            // 
            this.dtpDat.Location = new System.Drawing.Point(127, 211);
            this.dtpDat.Name = "dtpDat";
            this.dtpDat.Size = new System.Drawing.Size(192, 20);
            this.dtpDat.TabIndex = 66;
            // 
            // tbPrz
            // 
            this.tbPrz.Location = new System.Drawing.Point(127, 76);
            this.tbPrz.Name = "tbPrz";
            this.tbPrz.Size = new System.Drawing.Size(192, 20);
            this.tbPrz.TabIndex = 64;
            this.tbPrz.TextChanged += new System.EventHandler(this.tbPrz_TextChanged);
            this.tbPrz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrz_KeyPress);
            this.tbPrz.Leave += new System.EventHandler(this.tbPrz_Leave);
            // 
            // tbSifra
            // 
            this.tbSifra.BackColor = System.Drawing.SystemColors.Control;
            this.tbSifra.Location = new System.Drawing.Point(127, 121);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.ReadOnly = true;
            this.tbSifra.Size = new System.Drawing.Size(192, 20);
            this.tbSifra.TabIndex = 65;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(127, 35);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(192, 20);
            this.tbIme.TabIndex = 63;
            this.tbIme.TextChanged += new System.EventHandler(this.tbIme_TextChanged);
            this.tbIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIme_KeyPress);
            this.tbIme.Leave += new System.EventHandler(this.tbIme_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Pol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Datum ugovora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "JMBG:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Kategorija:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Delatnost: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Šifra: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Ime: ";
            // 
            // btnPon
            // 
            this.btnPon.Location = new System.Drawing.Point(255, 414);
            this.btnPon.Name = "btnPon";
            this.btnPon.Size = new System.Drawing.Size(84, 28);
            this.btnPon.TabIndex = 72;
            this.btnPon.Text = "Poništiti";
            this.btnPon.UseVisualStyleBackColor = true;
            this.btnPon.Click += new System.EventHandler(this.btnPon_Click_1);
            // 
            // btnSac
            // 
            this.btnSac.Location = new System.Drawing.Point(156, 414);
            this.btnSac.Name = "btnSac";
            this.btnSac.Size = new System.Drawing.Size(82, 28);
            this.btnSac.TabIndex = 71;
            this.btnSac.Text = "Sačuvati";
            this.btnSac.UseVisualStyleBackColor = true;
            this.btnSac.Click += new System.EventHandler(this.btnSac_Click);
            // 
            // mtbJMBG
            // 
            this.mtbJMBG.Location = new System.Drawing.Point(126, 160);
            this.mtbJMBG.Mask = "0000000000000";
            this.mtbJMBG.Name = "mtbJMBG";
            this.mtbJMBG.Size = new System.Drawing.Size(193, 20);
            this.mtbJMBG.TabIndex = 65;
            this.mtbJMBG.TextChanged += new System.EventHandler(this.mtbJMBG_TextChanged);
            this.mtbJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbJMBG_KeyPress);
            this.mtbJMBG.Leave += new System.EventHandler(this.mtbJMBG_Leave);
            // 
            // IzmenaKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 453);
            this.Controls.Add(this.mtbJMBG);
            this.Controls.Add(this.cbKat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbDel);
            this.Controls.Add(this.dtpDat);
            this.Controls.Add(this.tbPrz);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPon);
            this.Controls.Add(this.btnSac);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IzmenaKlijenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmena podataka o klijentu";
            this.Load += new System.EventHandler(this.IzmenaKlijenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbZ;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.TextBox tbDel;
        private System.Windows.Forms.DateTimePicker dtpDat;
        private System.Windows.Forms.TextBox tbPrz;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPon;
        private System.Windows.Forms.Button btnSac;
        private System.Windows.Forms.MaskedTextBox mtbJMBG;
    }
}