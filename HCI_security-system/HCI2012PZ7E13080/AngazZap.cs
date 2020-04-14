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
    public partial class AngazZap : Form
    {
        spisakKlijenti sk = spisakKlijenti.Instanca();
        spisakZaposleni sz = spisakZaposleni.Instanca();

        public static DateTime datAng;
        public static String razlAng;
        public static String kom;
        private int grupa;
        Zaposleni z;

        public AngazZap(String sifK, String sifZ,int brGrupe)
        {
            InitializeComponent();
            grupa = brGrupe;

            Klijent k = sk.NadjiKlijenta(sifK);
            
            if(grupa==1)
                z= sz.NadjiZap1(sifZ);
            if(grupa==2)
                z = sz.NadjiZap2(sifZ);
            if(grupa==3)
                z = sz.NadjiZap3(sifZ);
            if(grupa==4)
                z = sz.NadjiZap4(sifZ);
            if(grupa==5)
                z = sz.NadjiZap5(sifZ);

            tbImePrzK.Text = k.Ime + " " + k.Prezime;
            tbSifraK.Text = k.Sifra;

            tbImePrzZ.Text = z.Ime + " " + z.Prezime;
            tbSifZ.Text = z.Sifra;
            cbRazlog.Text = "zaštita";

            
        }

        private void AngazZap_Load(object sender, EventArgs e)
        {

        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            kom = rtbKoment.Text;
            datAng = dtpDatA.Value;
            razlAng = cbRazlog.Text;

          
            this.DialogResult = DialogResult.OK;
        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

     
    }
}
