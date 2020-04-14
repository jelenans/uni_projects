using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCI2012PZ7E13080
{
    public partial class OslobZap : Form
    {
        spisakKlijenti sk = spisakKlijenti.Instanca();
        spisakZaposleni sz = spisakZaposleni.Instanca();
        int grupa;
        Zaposleni z;

        public OslobZap(String sifK, String sifZ,int brGrupe)
        {
            InitializeComponent();

            grupa = brGrupe;

            Klijent k = sk.NadjiKlijenta(sifK);

            if (grupa == 1)
                z = sz.NadjiZap1(sifZ);
            if (grupa == 2)
                z = sz.NadjiZap2(sifZ);
            if (grupa == 3)
                z = sz.NadjiZap3(sifZ);
            if (grupa == 4)
                z = sz.NadjiZap4(sifZ);
            if (grupa == 5)
                z = sz.NadjiZap5(sifZ);

            tbImePrzK.Text = k.Ime + " " + k.Prezime;
            tbSifraK.Text = k.Sifra;

            tbImePrzZ.Text = z.Ime + " " + z.Prezime;
            tbSifZ.Text = z.Sifra;

            dtpDatA.Value = AngazZap.datAng;
            cbRazlog.Text = AngazZap.razlAng;
            rtbKoment.Text = AngazZap.kom;

        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            String j= tbImePrzK.Text;
            Ang ang = new Ang(tbImePrzZ.Text, tbImePrzK.Text, dtpDatA.Value, dtpDatP.Value,
          cbRazlog.Text, rtbKoment.Text);
            Angazovanja.Instanca().DodajAng(ang);
            this.DialogResult = DialogResult.OK;
        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void OslobZap_Load(object sender, EventArgs e)
        {

        }
    }
}
