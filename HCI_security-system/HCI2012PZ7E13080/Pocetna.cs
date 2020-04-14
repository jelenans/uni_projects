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
    public partial class Pocetna : Form
    {
        ToolTip tt = new ToolTip();
        spisakKlijenti sk = spisakKlijenti.Instanca();
        spisakZaposleni sz = spisakZaposleni.Instanca();
        String salji;
        //Panel selektovanZaposleni= new Panel();
        Panel selektovanZaposleni = null;
        int brSlob1;
        int brSlob2;
        int selekt = 0;

        public static Panel slob;
        public static Panel slob2;
        public static Panel slob3;
        public static Panel slob4;
        public static Panel slob5;


        Rectangle _mouseDownSelekcioniProzor;
        
        Point _ofsetEkrana;

        public Panel Slob
        {
            get { return slob; }
            set { slob = value; }
        }
        private Dictionary<String, Panel> spisakPanela = new Dictionary<string, Panel>();
        private Dictionary<String, Panel> spisakPanela2 = new Dictionary<string, Panel>();
        private Dictionary<String, Panel> spisakPanela3 = new Dictionary<string, Panel>();
        private Dictionary<String, Panel> spisakPanela4 = new Dictionary<string, Panel>();
        private Dictionary<String, Panel> spisakPanela5 = new Dictionary<string, Panel>();

        public static Zaposleni zaposleni = new Zaposleni();

        public Pocetna()
        {
            InitializeComponent();
            popuniTree();
            isprazniLabele();
            unvisibleBtnZap();
#region INIT
            pp1.Visible = false;
            pp2.Visible = false;
            pp3.Visible = false;
            pp4.Visible = false;
            pp5.Visible = false;
            pp6.Visible = false;
            pp7.Visible = false;
            pp8.Visible = false;
            pp9.Visible = false;
            pp10.Visible = false;
            pp11.Visible = false;
            pp12.Visible = false;
            pp13.Visible = false;

            pStanje.Visible = false;

            spisakPanela.Add("1",pp1);
            spisakPanela.Add("2", pp2);
            spisakPanela.Add("3", pp3);
            spisakPanela.Add("4", pp4);
            spisakPanela.Add("5", pp5);
            spisakPanela.Add("6", pp6);
            spisakPanela.Add("7", pp7);
            spisakPanela.Add("8", pp8);
            spisakPanela.Add("9", pp9);
            spisakPanela.Add("10", pp10);
            spisakPanela.Add("11", pp11);
            spisakPanela.Add("12", pp12);
            spisakPanela.Add("13", pp13);

            pp21.Visible = false;
            pp22.Visible = false;
            pp23.Visible = false;
            pp24.Visible = false;
            pp25.Visible = false;
            pp26.Visible = false;
            pp27.Visible = false;
            pp28.Visible = false;
            pp29.Visible = false;
            pp210.Visible = false;
            pp211.Visible = false;
            pp212.Visible = false;
            pp213.Visible = false;

            spisakPanela2.Add("1", pp21);
            spisakPanela2.Add("2", pp22);
            spisakPanela2.Add("3", pp23);
            spisakPanela2.Add("4", pp24);
            spisakPanela2.Add("5", pp25);
            spisakPanela2.Add("6", pp26);
            spisakPanela2.Add("7", pp27);
            spisakPanela2.Add("8", pp28);
            spisakPanela2.Add("9", pp29);
            spisakPanela2.Add("10", pp210);
            spisakPanela2.Add("11", pp211);
            spisakPanela2.Add("12", pp212);
            spisakPanela2.Add("13", pp213);

            pp31.Visible = false;
            pp32.Visible = false;
            pp33.Visible = false;
            pp34.Visible = false;
            pp35.Visible = false;
            pp36.Visible = false;
            pp37.Visible = false;
            pp38.Visible = false;
            pp39.Visible = false;
            pp310.Visible = false;
            pp311.Visible = false;
            pp312.Visible = false;
            pp313.Visible = false;

            spisakPanela3.Add("1", pp31);
            spisakPanela3.Add("2", pp32);
            spisakPanela3.Add("3", pp33);
            spisakPanela3.Add("4", pp34);
            spisakPanela3.Add("5", pp35);
            spisakPanela3.Add("6", pp36);
            spisakPanela3.Add("7", pp37);
            spisakPanela3.Add("8", pp38);
            spisakPanela3.Add("9", pp39);
            spisakPanela3.Add("10", pp310);
            spisakPanela3.Add("11", pp311);
            spisakPanela3.Add("12", pp312);
            spisakPanela3.Add("13", pp313);

            pp41.Visible = false;
            pp42.Visible = false;
            pp43.Visible = false;
            pp44.Visible = false;
            pp45.Visible = false;
            pp46.Visible = false;
            pp47.Visible = false;
            pp48.Visible = false;
            pp49.Visible = false;
            pp410.Visible = false;
            pp411.Visible = false;
            pp412.Visible = false;
            pp413.Visible = false;

            spisakPanela4.Add("1", pp41);
            spisakPanela4.Add("2", pp42);
            spisakPanela4.Add("3", pp43);
            spisakPanela4.Add("4", pp44);
            spisakPanela4.Add("5", pp45);
            spisakPanela4.Add("6", pp46);
            spisakPanela4.Add("7", pp47);
            spisakPanela4.Add("8", pp48);
            spisakPanela4.Add("9", pp49);
            spisakPanela4.Add("10", pp410);
            spisakPanela4.Add("11", pp411);
            spisakPanela4.Add("12", pp412);
            spisakPanela4.Add("13", pp413);

            pp51.Visible = false;
            pp52.Visible = false;
            pp53.Visible = false;
            pp54.Visible = false;
            pp55.Visible = false;
            pp56.Visible = false;
            pp57.Visible = false;
            pp58.Visible = false;
            pp59.Visible = false;
            pp510.Visible = false;
            pp511.Visible = false;
            pp512.Visible = false;
            pp513.Visible = false;

            spisakPanela5.Add("1", pp51);
            spisakPanela5.Add("2", pp52);
            spisakPanela5.Add("3", pp53);
            spisakPanela5.Add("4", pp54);
            spisakPanela5.Add("5", pp55);
            spisakPanela5.Add("6", pp56);
            spisakPanela5.Add("7", pp57);
            spisakPanela5.Add("8", pp58);
            spisakPanela5.Add("9", pp59);
            spisakPanela5.Add("10", pp510);
            spisakPanela5.Add("11", pp511);
            spisakPanela5.Add("12", pp512);
            spisakPanela5.Add("13", pp513);
#endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pp1.AllowDrop = true;

                btnDodZap.Visible = false;
                btnIzmZap.Visible = false;
                btnUklZap.Visible = false;

        }

        private void btnAngaz_Click(object sender, EventArgs e)
        {

        }

    
        private void pbGrupa1_Click_1(object sender, EventArgs e)
        {
            tabCtrl.SelectedTab = tbGr;
            tbGr.Text = "Grupa1";
            lbgr1.Text = "";
            visibleBtnZap();
            if (spisakZaposleni.Instanca().BrojZap1() == 0)
            {
                disableBtnZap();
                lbgr1.Text = "U grupi 1 trenutno nema zaposlenih.";
            }
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void spisakKlijenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpisakKlijenata sk = new SpisakKlijenata();
            this.Opacity = .50;
            DialogResult dr = sk.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;


        }

        private void pregledAngažovanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pregled preg = new Pregled();
            this.Opacity = .50;
            DialogResult dr = preg.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pregled_zaposlenih pz = new Pregled_zaposlenih();
            this.Opacity = .50;
            DialogResult dr = pz.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        public void popuniTree()
        {
            treeView1.Nodes.Clear();

            for (int i = 0; i < sk.BrojKlijenata(); i++)
            {

                treeView1.Nodes.Add( 
                    sk.NadjiKlijenta(i).Ime.ToString() + " " + sk.NadjiKlijenta(i).Prezime.ToString());
                treeView1.Nodes[i].Tag = sk.NadjiKlijenta(i).Sifra.ToString();
            }


        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            salji = treeView1.SelectedNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(salji);

            lbIm.Text = k.Ime;
            lbPr.Text = k.Prezime;
            lbSif.Text = k.Sifra;
            lbJm.Text = k.Jmbg;
            lbDa.Text = k.DatUgovora.ToString();

        }



        void isprazniLabele()
        {

            lbJm.Text = "________________";
            lbIm.Text = "________________";
            lbPr.Text = "________________";
            lbSif.Text = "________________";
            lbDa.Text = "________________";
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            

            tt.ShowAlways = true;

            tt.InitialDelay = 100;
            tt.ReshowDelay = 200;

            tt.SetToolTip(btnDodati, "Registracija klijenta");
            tt.SetToolTip(btnIzmeniti, "Izmena klijenta");
            tt.SetToolTip(btnUkloniti, "Uklanjanje klijenta");
            tt.SetToolTip(treeView1, "Spisak klijenata");
            tt.SetToolTip(panel1, "Podaci o klijentu");
            tt.SetToolTip(btnDodZap, "Dodavanje zaposlenog u prvu grupu");
            tt.SetToolTip(btnDodZap5,"Dodavanje zaposlenog u petu grupu");
            tt.SetToolTip(btnDodZap2, "Dodavanje zaposlenog u drugu grupu");
            tt.SetToolTip(btnDodZap3, "Dodavanje zaposlenog u treću grupu");
            tt.SetToolTip(btnDodZap4, "Dodavanje zaposlenog u četvrtu grupu");
            tt.SetToolTip(btnIzmZap, "Izmena zaposlenog");
            tt.SetToolTip(btnIzmZap2, "Izmena zaposlenog");
            tt.SetToolTip(btnIzmZap3, "Izmena zaposlenog");
            tt.SetToolTip(btnIzmZap4, "Izmena zaposlenog");
            tt.SetToolTip(btnIzmZap5, "Izmena zaposlenog");
            tt.SetToolTip(btnUklZap, "Uklanjanje zaposlenog");
            tt.SetToolTip(btnUklZap2, "Uklanjanje zaposlenog");
            tt.SetToolTip(btnUklZap3, "Uklanjanje zaposlenog");
            tt.SetToolTip(btnUklZap4, "Uklanjanje zaposlenog");
            tt.SetToolTip(btnUklZap5, "Uklanjanje zaposlenog");
            tt.SetToolTip(pbGrupa1, "Grupa 1: " + lbSt1.Text);
            tt.SetToolTip(pbGrupa2, "Grupa 2: " + lbSt2.Text);
            tt.SetToolTip(pbGrupa3, "Grupa 3: " + lbSt3.Text);
            tt.SetToolTip(pbGrupa4, "Grupa 4: " + lbSt4.Text);
            tt.SetToolTip(pbGrupa5, "Grupa 5: " + lbSt5.Text);
            if (spisakKlijenti.Instanca().BrojKlijenata() == 0)
                disableButtons();
      
        }

#region dugmici Zaposleni
        public void disableBtnZap()
        {
            if (tabCtrl.SelectedTab == tbGr)
            {
                btnIzmZap.Enabled = false;
                btnUklZap.Enabled = false;
            }
            else if (tabCtrl.SelectedTab == tbGr2)
            {
                btnIzmZap2.Enabled = false;
                btnUklZap2.Enabled = false;
            }
            else if (tabCtrl.SelectedTab == tbGr3)
            {
                btnIzmZap3.Enabled = false;
                btnUklZap3.Enabled = false;
            }
            else if (tabCtrl.SelectedTab == tbGr4)
            {
                btnIzmZap4.Enabled = false;
                btnUklZap4.Enabled = false;
            }
            else if (tabCtrl.SelectedTab == tbGr5)
            {
                btnIzmZap5.Enabled = false;
                btnUklZap5.Enabled = false;
            }

        }

        public void enableBtnZap()
        {
            if (tabCtrl.SelectedTab == tbGr)
            {
                btnIzmZap.Enabled = true;
                btnUklZap.Enabled = true;
            }
            else if (tabCtrl.SelectedTab == tbGr2)
            {
                btnIzmZap2.Enabled = true;
                btnUklZap2.Enabled = true;
            }
            else if (tabCtrl.SelectedTab == tbGr3)
            {
                btnIzmZap3.Enabled = true;
                btnUklZap3.Enabled = true;
            }
            else if (tabCtrl.SelectedTab == tbGr4)
            {
                btnIzmZap4.Enabled = true;
                btnUklZap4.Enabled = true;
            }
            else if (tabCtrl.SelectedTab == tbGr5)
            {
                btnIzmZap5.Enabled = true;
                btnUklZap5.Enabled = true;
            }

        }
        public void unvisibleBtnZap()
        {

            if (tabCtrl.SelectedTab == tbGr)
            {
                btnDodZap.Visible = false;
                btnIzmZap.Visible = false;
                btnUklZap.Visible = false;
            }
            else if (tabCtrl.SelectedTab == tbGr2)
            {
                btnDodZap2.Visible = false;
                btnIzmZap2.Visible = false;
                btnUklZap2.Visible = false;
            }
            else if (tabCtrl.SelectedTab == tbGr3)
            {
                btnDodZap3.Visible = false;
                btnIzmZap3.Visible = false;
                btnUklZap3.Visible = false;
            }
            else if (tabCtrl.SelectedTab == tbGr4)
            {
                btnDodZap4.Visible = false;
                btnIzmZap4.Visible = false;
                btnUklZap4.Visible = false;
            }
            else if (tabCtrl.SelectedTab == tbGr5)
            {
                btnDodZap5.Visible = false;
                btnIzmZap5.Visible = false;
                btnUklZap5.Visible = false;
            }

        }

        public void visibleBtnZap()
        {
            if (tabCtrl.SelectedTab == tbGr)
            {
                btnDodZap.Visible = true;
                btnIzmZap.Visible = true;
                btnUklZap.Visible = true;
            }
            else if (tabCtrl.SelectedTab == tbGr2)
            {
                btnDodZap2.Visible = true;
                btnIzmZap2.Visible = true;
                btnUklZap2.Visible = true;
            }
            else if (tabCtrl.SelectedTab == tbGr3)
            {
                btnDodZap3.Visible = true;
                btnIzmZap3.Visible = true;
                btnUklZap3.Visible = true;
            }
            else if (tabCtrl.SelectedTab == tbGr4)
            {
                btnDodZap4.Visible = true;
                btnIzmZap4.Visible = true;
                btnUklZap4.Visible = true;
            }
            else if (tabCtrl.SelectedTab == tbGr5)
            {
                btnDodZap5.Visible = true;
                btnIzmZap5.Visible = true;
                btnUklZap5.Visible = true;
            }
        }
#endregion

#region GRUPA 1

#region dugmiciKlijenti
        private void btnDodati_Click(object sender, EventArgs e)
        {
            DodavanjeKlijenta dk = new DodavanjeKlijenta();
            this.Opacity = .70;
            DialogResult dr = dk.ShowDialog();

            if (dr == DialogResult.OK)
            {
                this.popuniTree();
                isprazniLabele();
                this.enableButtons();
                this.Opacity = 1;
            }
            else if (dr == DialogResult.Cancel)
                this.Opacity = 1;
            
        }

        private void btnIzmeniti_Click(object sender, EventArgs e)
        {
            salji = treeView1.SelectedNode.Tag.ToString();
            IzmenaKlijenta ik = new IzmenaKlijenta(salji);
            this.Opacity = .50;
            DialogResult dr = ik.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.popuniTree();
                isprazniLabele();
                this.enableButtons();
                this.Opacity = 1;
            }
            else
                this.Opacity = 1;
        }

        private void btnUkloniti_Click(object sender, EventArgs e)
        {
            salji = treeView1.SelectedNode.Tag.ToString();
            Brisanje p1 = new Brisanje(salji);
            DialogResult dr = p1.ShowDialog();
            this.Opacity = .60;
            if (dr == DialogResult.Yes)
            {
                spisakKlijenti.Instanca().UkloniKlijenta(salji);
                if (spisakKlijenti.Instanca().BrojKlijenata() == 0)
                    disableButtons();

                popuniTree();
                isprazniLabele();
                this.Opacity = 1;
            }
            if (dr == DialogResult.No)
                this.Opacity = 1;
        }

        public void disableButtons()
        {
            btnIzmeniti.Enabled = false;
            btnUkloniti.Enabled = false;
        }

        public void enableButtons()
        {

            btnIzmeniti.Enabled = true;
            btnUkloniti.Enabled = true;
        }
#endregion

#region dugmiciZaposleni

        private void btnDodZap_Click(object sender, EventArgs e)
        {
   
            
            DodavanjeZaposlenog dz = new DodavanjeZaposlenog(1);
            this.Opacity = .70;
            DialogResult dr = dz.ShowDialog();
            if (dr == DialogResult.OK)
            {
                String sifra = zaposleni.Kljuc();

                slob = slobodanPanel();
                slob.BackgroundImage = DodavanjeZaposlenog.z.postaviSliku();
                slob.Tag = DodavanjeZaposlenog.z.Kljuc();
                slob.Visible = true;
                slob.AllowDrop = true;
                Zaposleni z= sz.NadjiZap1(DodavanjeZaposlenog.z.Kljuc()); 
                z.Panel= slob;

                lbgr1.Text = "";
                brSlob1 = 13 - spisakZaposleni.Instanca().BrojZap1();
                lbSt1.Text = brSlob1 + " slobodno";
                tt.SetToolTip(pbGrupa1, "Grupa 1: " + lbSt1.Text);
                this.enableBtnZap();
                this.Opacity = 1;
            }
            else if (dr==DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void btnIzmZap_Click(object sender, EventArgs e)
        {if (selektovanZaposleni == null)
                MessageBox.Show("Morate selektovati zaposlenog za izmenu!");
            else
            
            {
                String salji = selektovanZaposleni.Tag.ToString();

                Zaposleni z = sz.NadjiZap1(salji);
                IzmenaZaposlenog iz = new IzmenaZaposlenog(salji, 1);
                this.Opacity = .7;
                DialogResult dr = iz.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    selektovanZaposleni.BackgroundImage = z.postaviSliku();
                    DeselektujPP(selektovanZaposleni);
                }
                this.Opacity = 1;
            }
        }

        private void btnUklZap_Click(object sender, EventArgs e)
        {
            if (selektovanZaposleni == null)
                MessageBox.Show("Morate selektovati zaposlenog za uklanjanje!");
            else
            {
                salji = selektovanZaposleni.Tag.ToString();
                BrisZap p1 = new BrisZap(salji);
                DialogResult dr = p1.ShowDialog();
                this.Opacity = .60;
                if (dr == DialogResult.Yes)
                {
                    sz.UkloniZap1(salji);
                    if (sz.BrojZap1() == 0)
                    {
                        disableBtnZap();
                        lbgr1.Text = "U grupi 1 trenutno nema zaposlenih.";
                    }
                    selektovanZaposleni.Visible = false;
                    pStanje.Visible = false;

                    int brSlob = 13 - spisakZaposleni.Instanca().BrojZap1();
                    lbSt1.Text = brSlob + " slobodno";
                    tt.SetToolTip(pbGrupa1, "Grupa 1: " + lbSt1.Text);
                    this.Opacity = 1;
                }
                else
                    this.Opacity = 1;
            }
        }
        #endregion

private Panel slobodanPanel() {

            
            Dictionary<string, Panel>.Enumerator e = spisakPanela.GetEnumerator();
            {
                Panel pan = new Panel(); 
                while (e.MoveNext())
                {
                    pan=e.Current.Value;
                    if (pan.Visible==false)
                        break;

                }
                return pan;
            }
        }

#region SELEKCIJA_PARCELA
        private void SelektujPP(Panel sender)
        {
            selektovanZaposleni = sender;
            sender.BorderStyle = BorderStyle.FixedSingle;
            if (sender == pp1) {
                pp2.BorderStyle = BorderStyle.None;
                pp3.BorderStyle = BorderStyle.None;
                pp4.BorderStyle = BorderStyle.None;
                pp5.BorderStyle = BorderStyle.None;
                pp6.BorderStyle = BorderStyle.None;
                pp7.BorderStyle = BorderStyle.None;
                pp8.BorderStyle = BorderStyle.None;
                pp9.BorderStyle = BorderStyle.None;
                pp10.BorderStyle = BorderStyle.None;
                pp11.BorderStyle = BorderStyle.None;
                pp12.BorderStyle = BorderStyle.None;
                pp13.BorderStyle = BorderStyle.None;
            }
            else if (sender == pp2)
            {
                pp1.BorderStyle = BorderStyle.None;
                pp3.BorderStyle = BorderStyle.None;
                pp4.BorderStyle = BorderStyle.None;
                pp5.BorderStyle = BorderStyle.None;
                pp6.BorderStyle = BorderStyle.None;
                pp7.BorderStyle = BorderStyle.None;
                pp8.BorderStyle = BorderStyle.None;
                pp9.BorderStyle = BorderStyle.None;
                pp10.BorderStyle = BorderStyle.None;
                pp11.BorderStyle = BorderStyle.None;
                pp12.BorderStyle = BorderStyle.None;
                pp13.BorderStyle = BorderStyle.None;
            }
            else if (sender == pp3)
            {
                pp1.BorderStyle = BorderStyle.None;
                pp2.BorderStyle = BorderStyle.None;
                pp4.BorderStyle = BorderStyle.None;
                pp5.BorderStyle = BorderStyle.None;
                pp6.BorderStyle = BorderStyle.None;
                pp7.BorderStyle = BorderStyle.None;
                pp8.BorderStyle = BorderStyle.None;
                pp9.BorderStyle = BorderStyle.None;
                pp10.BorderStyle = BorderStyle.None;
                pp11.BorderStyle = BorderStyle.None;
                pp12.BorderStyle = BorderStyle.None;
                pp13.BorderStyle = BorderStyle.None;
            }
            else if (sender == pp4)
            {
                pp1.BorderStyle = BorderStyle.None;
                pp3.BorderStyle = BorderStyle.None;
                pp2.BorderStyle = BorderStyle.None;
                pp5.BorderStyle = BorderStyle.None;
                pp6.BorderStyle = BorderStyle.None;
                pp7.BorderStyle = BorderStyle.None;
                pp8.BorderStyle = BorderStyle.None;
                pp9.BorderStyle = BorderStyle.None;
                pp10.BorderStyle = BorderStyle.None;
                pp11.BorderStyle = BorderStyle.None;
                pp12.BorderStyle = BorderStyle.None;
                pp13.BorderStyle = BorderStyle.None;
            }
            else if (sender == pp5)
            {
                pp1.BorderStyle = BorderStyle.None;
                pp3.BorderStyle = BorderStyle.None;
                pp4.BorderStyle = BorderStyle.None;
                pp2.BorderStyle = BorderStyle.None;
                pp6.BorderStyle = BorderStyle.None;
                pp7.BorderStyle = BorderStyle.None;
                pp8.BorderStyle = BorderStyle.None;
                pp9.BorderStyle = BorderStyle.None;
                pp10.BorderStyle = BorderStyle.None;
                pp11.BorderStyle = BorderStyle.None;
                pp12.BorderStyle = BorderStyle.None;
                pp13.BorderStyle = BorderStyle.None;
            }
            else if (sender == pp6)
            {
                pp1.BorderStyle = BorderStyle.None;
                pp3.BorderStyle = BorderStyle.None;
                pp4.BorderStyle = BorderStyle.None;
                pp5.BorderStyle = BorderStyle.None;
                pp2.BorderStyle = BorderStyle.None;
                pp7.BorderStyle = BorderStyle.None;
                pp8.BorderStyle = BorderStyle.None;
                pp9.BorderStyle = BorderStyle.None;
                pp10.BorderStyle = BorderStyle.None;
                pp11.BorderStyle = BorderStyle.None;
                pp12.BorderStyle = BorderStyle.None;
                pp13.BorderStyle = BorderStyle.None;
            }
            else if (sender == pp7)
            {
                pp1.BorderStyle = BorderStyle.None;
                pp3.BorderStyle = BorderStyle.None;
                pp4.BorderStyle = BorderStyle.None;
                pp5.BorderStyle = BorderStyle.None;
                pp6.BorderStyle = BorderStyle.None;
                pp2.BorderStyle = BorderStyle.None;
                pp8.BorderStyle = BorderStyle.None;
                pp9.BorderStyle = BorderStyle.None;
                pp10.BorderStyle = BorderStyle.None;
                pp11.BorderStyle = BorderStyle.None;
                pp12.BorderStyle = BorderStyle.None;
                pp13.BorderStyle = BorderStyle.None;
            }
            else if (sender == pp8)
            {
                pp1.BorderStyle = BorderStyle.None;
                pp3.BorderStyle = BorderStyle.None;
                pp4.BorderStyle = BorderStyle.None;
                pp5.BorderStyle = BorderStyle.None;
                pp6.BorderStyle = BorderStyle.None;
                pp7.BorderStyle = BorderStyle.None;
                pp2.BorderStyle = BorderStyle.None;
                pp9.BorderStyle = BorderStyle.None;
                pp10.BorderStyle = BorderStyle.None;
                pp11.BorderStyle = BorderStyle.None;
                pp12.BorderStyle = BorderStyle.None;
                pp13.BorderStyle = BorderStyle.None;
            }
            else if (sender == pp2)
            {
                pp1.BorderStyle = BorderStyle.None;
                pp3.BorderStyle = BorderStyle.None;
                pp4.BorderStyle = BorderStyle.None;
                pp5.BorderStyle = BorderStyle.None;
                pp6.BorderStyle = BorderStyle.None;
                pp7.BorderStyle = BorderStyle.None;
                pp8.BorderStyle = BorderStyle.None;
                pp9.BorderStyle = BorderStyle.None;
                pp10.BorderStyle = BorderStyle.None;
                pp11.BorderStyle = BorderStyle.None;
                pp12.BorderStyle = BorderStyle.None;
                pp13.BorderStyle = BorderStyle.None;
            }
            else if (sender == pp9)
            {
                pp1.BorderStyle = BorderStyle.None;
                pp3.BorderStyle = BorderStyle.None;
                pp4.BorderStyle = BorderStyle.None;
                pp5.BorderStyle = BorderStyle.None;
                pp6.BorderStyle = BorderStyle.None;
                pp7.BorderStyle = BorderStyle.None;
                pp8.BorderStyle = BorderStyle.None;
                pp2.BorderStyle = BorderStyle.None;
                pp10.BorderStyle = BorderStyle.None;
                pp11.BorderStyle = BorderStyle.None;
                pp12.BorderStyle = BorderStyle.None;
                pp13.BorderStyle = BorderStyle.None;
            }
            else if (sender == pp10)
            {
                pp1.BorderStyle = BorderStyle.None;
                pp3.BorderStyle = BorderStyle.None;
                pp4.BorderStyle = BorderStyle.None;
                pp5.BorderStyle = BorderStyle.None;
                pp6.BorderStyle = BorderStyle.None;
                pp7.BorderStyle = BorderStyle.None;
                pp8.BorderStyle = BorderStyle.None;
                pp9.BorderStyle = BorderStyle.None;
                pp2.BorderStyle = BorderStyle.None;
                pp11.BorderStyle = BorderStyle.None;
                pp12.BorderStyle = BorderStyle.None;
                pp13.BorderStyle = BorderStyle.None;
            }
            else if (sender == pp11)
            {
                pp1.BorderStyle = BorderStyle.None;
                pp3.BorderStyle = BorderStyle.None;
                pp4.BorderStyle = BorderStyle.None;
                pp5.BorderStyle = BorderStyle.None;
                pp6.BorderStyle = BorderStyle.None;
                pp7.BorderStyle = BorderStyle.None;
                pp8.BorderStyle = BorderStyle.None;
                pp9.BorderStyle = BorderStyle.None;
                pp10.BorderStyle = BorderStyle.None;
                pp2.BorderStyle = BorderStyle.None;
                pp12.BorderStyle = BorderStyle.None;
                pp13.BorderStyle = BorderStyle.None;
            }
            else if (sender == pp12)
            {
                pp1.BorderStyle = BorderStyle.None;
                pp3.BorderStyle = BorderStyle.None;
                pp4.BorderStyle = BorderStyle.None;
                pp5.BorderStyle = BorderStyle.None;
                pp6.BorderStyle = BorderStyle.None;
                pp7.BorderStyle = BorderStyle.None;
                pp8.BorderStyle = BorderStyle.None;
                pp9.BorderStyle = BorderStyle.None;
                pp10.BorderStyle = BorderStyle.None;
                pp11.BorderStyle = BorderStyle.None;
                pp2.BorderStyle = BorderStyle.None;
                pp13.BorderStyle = BorderStyle.None;
            }
            else if (sender == pp13)
            {
                pp1.BorderStyle = BorderStyle.None;
                pp3.BorderStyle = BorderStyle.None;
                pp4.BorderStyle = BorderStyle.None;
                pp5.BorderStyle = BorderStyle.None;
                pp6.BorderStyle = BorderStyle.None;
                pp7.BorderStyle = BorderStyle.None;
                pp8.BorderStyle = BorderStyle.None;
                pp9.BorderStyle = BorderStyle.None;
                pp10.BorderStyle = BorderStyle.None;
                pp11.BorderStyle = BorderStyle.None;
                pp12.BorderStyle = BorderStyle.None;
                pp2.BorderStyle = BorderStyle.None;
            } 
        }


        private void DeselektujPP(Panel sender)
        {
            selektovanZaposleni = sender;
            sender.BorderStyle = BorderStyle.None;
        }


        private void pp1_Click(object sender, EventArgs e)
        {

            SelektujPP((Panel)sender);
          
        }

      

        private void pp2_Click(object sender, EventArgs e)
        {

            SelektujPP((Panel)sender);
        }

        private void pp3_Click(object sender, EventArgs e)
        {

            SelektujPP((Panel)sender);
        }

        private void pp4_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp5_Click(object sender, EventArgs e)
        {

            SelektujPP((Panel)sender);
        }

        private void pp6_Click(object sender, EventArgs e)
        {

            SelektujPP((Panel)sender);
        }

        private void pp7_Click(object sender, EventArgs e)
        {

            SelektujPP((Panel)sender);
        }

        private void pp8_Click(object sender, EventArgs e)
        {

            SelektujPP((Panel)sender);
        }

        private void pp9_Click(object sender, EventArgs e)
        {

            SelektujPP((Panel)sender);
        }

        private void pp10_Click(object sender, EventArgs e)
        {

            SelektujPP((Panel)sender);
        }

        private void pp11_Click(object sender, EventArgs e)
        {

            SelektujPP((Panel)sender);
        }

        private void pp12_Click(object sender, EventArgs e)
        {

            SelektujPP((Panel)sender);
        }

        private void pp13_Click(object sender, EventArgs e)
        {

            SelektujPP((Panel)sender);
        }

#endregion

#region drag&drop


        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode _indeksPrevucenogCvora = treeView1.GetNodeAt(e.Location);

            if (_indeksPrevucenogCvora != null)
            {
                treeView1.SelectedNode = _indeksPrevucenogCvora;
                if ((_indeksPrevucenogCvora.GetNodeCount(true) == 0) && (_indeksPrevucenogCvora.ForeColor != Color.Gray))
                {
                    Size dragVelicina = SystemInformation.DragSize;
                    _mouseDownSelekcioniProzor = new Rectangle(new Point(e.X - (dragVelicina.Width / 2), e.Y - (dragVelicina.Height / 2)), dragVelicina);
                }
                else
                    _mouseDownSelekcioniProzor = Rectangle.Empty;
            }
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            TreeNode _indeksPrevucenogCvora= treeView1.GetNodeAt(e.Location);
            if (e.Button == MouseButtons.Left)
            {
                if ((_mouseDownSelekcioniProzor != Rectangle.Empty) && (!_mouseDownSelekcioniProzor.Contains(e.X, e.Y)))
                {
                    _ofsetEkrana = SystemInformation.WorkingArea.Location;
                    DragDropEffects dropEffekat = this.treeView1.DoDragDrop(_indeksPrevucenogCvora, DragDropEffects.Copy);
                }
            }
        }

#region GR1
        private void pp1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp1.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            if (!(z.Stanje.Equals("slobodan") || z.Kategorija.Equals(k.Kategorija)))
                pp1.AllowDrop = false;
            else
                pp1.AllowDrop = true;
        }

        private void pp1_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k= sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz= pp1.Tag.ToString();
            Zaposleni z= sz.NadjiZap1(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz,1);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {
               
               z.Stanje= "na zadatku";
               
               pStanje.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
               pStanje.Visible = true;

                
            }
            this.Opacity = 100;
        }

        private void pp2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp2.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp2.AllowDrop = false;
            else
                pp2.AllowDrop = true;
        }

        private void pp2_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp2.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz,1);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje2.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje2.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp3.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp3.AllowDrop = false;
            else
                pp3.AllowDrop = true;
        }

        private void pp3_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp3.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz,1);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje3.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje3.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp4.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp4.AllowDrop = false;
            else
                pp4.AllowDrop = true;
            this.Opacity = 100;
        }

        private void pp4_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp4.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz,1);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje4.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje4.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp5_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp5.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp5.AllowDrop = false;
            else
                pp5.AllowDrop = true;
        }

        private void pp5_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp5.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz,1);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje5.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje5.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp6_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp6.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp6.AllowDrop = false;
            else
                pp6.AllowDrop = true;

        }

        private void pp6_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp6.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 1);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje6.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje6.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp7_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp7.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp7.AllowDrop = false;
            else
                pp7.AllowDrop = true;
        }

        private void pp7_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp7.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz,1);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje7.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje7.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp8_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp8.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp8.AllowDrop = false;
            else
                pp8.AllowDrop = true;
        }

        private void pp8_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp8.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 1);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje8.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje8.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp9_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp9.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp9.AllowDrop = false;
            else
                pp9.AllowDrop = true;
        }

        private void pp9_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp9.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 1);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje9.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje9.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp10_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp10.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp10.AllowDrop = false;
            else
                pp10.AllowDrop = true;
        }

        private void pp10_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp10.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 1);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje10.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje10.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp11_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp11.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp11.AllowDrop = false;
            else
                pp11.AllowDrop = true;
        }

        private void pp11_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp11.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 1);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje11.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje11.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp12_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp12.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp12.AllowDrop = false;
            else
                pp12.AllowDrop = true;
        }

        private void pp12_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp12.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 1);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje12.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje12.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp13_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp13.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp13.AllowDrop = false;
            else
                pp13.AllowDrop = true;
        }

        private void pp13_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp13.Tag.ToString();
            Zaposleni z = sz.NadjiZap1(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 1);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje13.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje13.Visible = true;


            }
            this.Opacity = 100;
        }
#endregion
        #region GR2
        private void pp21_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp21.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp21.AllowDrop = false;
            else
                pp21.AllowDrop = true;
        }

        private void pp21_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp21.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 2);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje21.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje21.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp22_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp22.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp22.AllowDrop = false;
            else
                pp22.AllowDrop = true;
        }

        private void pp22_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp22.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 2);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje22.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje22.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp23_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp23.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp23.AllowDrop = false;
            else
                pp23.AllowDrop = true;
        }

        private void pp23_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp23.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 2);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje23.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje23.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp24_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp24.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp24.AllowDrop = false;
            else
                pp24.AllowDrop = true;
        }

        private void pp24_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp24.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 2);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje24.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje24.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp25_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp25.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp25.AllowDrop = false;
            else
                pp25.AllowDrop = true;
        }

        private void pp25_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp25.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 2);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje25.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje25.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp26_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp26.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp26.AllowDrop = false;
            else
                pp26.AllowDrop = true;
        }

        private void pp26_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp26.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 2);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje26.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje26.Visible = true;
            }
            this.Opacity = 100;
        }

        private void pp27_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp27.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp27.AllowDrop = false;
            else
                pp27.AllowDrop = true;
        }

        private void pp27_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp27.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 2);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje27.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje27.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp28_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp28.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp28.AllowDrop = false;
            else
                pp28.AllowDrop = true;
        }

        private void pp28_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp28.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 2);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje28.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje28.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp29_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp29.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp29.AllowDrop = false;
            else
                pp29.AllowDrop = true;
        }

        private void pp29_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp29.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 2);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje29.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje29.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp210_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp210.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp210.AllowDrop = false;
            else
                pp210.AllowDrop = true;
        }

        private void pp210_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp210.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 2);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje210.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje210.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp211_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp211.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp211.AllowDrop = false;
            else
                pp211.AllowDrop = true;
        }

        private void pp211_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp211.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 2);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje211.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje211.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp212_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp212.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp212.AllowDrop = false;
            else
                pp212.AllowDrop = true;
        }

        private void pp212_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp212.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 2);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje212.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje212.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp213_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp213.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp213.AllowDrop = false;
            else
                pp213.AllowDrop = true;
        }

        private void pp213_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp213.Tag.ToString();
            Zaposleni z = sz.NadjiZap2(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 2);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje213.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje213.Visible = true;


            }
            this.Opacity = 100;
        }
        #endregion
        #region GR3
   

        private void pp31_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp31.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp31.AllowDrop = false;
            else
                pp31.AllowDrop = true;
        }

        private void pp31_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp31.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 3);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje31.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje31.Visible = true;


            }
            this.Opacity = 100;
        }
        private void pp32_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp32.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp32.AllowDrop = false;
            else
                pp32.AllowDrop = true;
        }

        private void pp32_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp32.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 3);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje32.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje32.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp33_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp33.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp33.AllowDrop = false;
            else
                pp33.AllowDrop = true;
        }

        private void pp33_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp33.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 3);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje33.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje33.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp34_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp34.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp34.AllowDrop = false;
            else
                pp34.AllowDrop = true;
        }

        private void pp34_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp34.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 3);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje34.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje34.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp35_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp35.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp35.AllowDrop = false;
            else
                pp35.AllowDrop = true;
        }

        private void pp35_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp35.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 3);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje35.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje35.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp36_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp36.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp36.AllowDrop = false;
            else
                pp36.AllowDrop = true;
        }

        private void pp36_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp36.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 3);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje36.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje36.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp37_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp37.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp37.AllowDrop = false;
            else
                pp37.AllowDrop = true;
        }

        private void pp37_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp37.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 3);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje37.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje37.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp38_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp38.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp38.AllowDrop = false;
            else
                pp38.AllowDrop = true;
        }

        private void pp38_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp38.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 3);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje38.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje38.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp39_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp39.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp39.AllowDrop = false;
            else
                pp39.AllowDrop = true;
        }

        private void pp39_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp39.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 3);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje39.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje39.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp310_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp310.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp310.AllowDrop = false;
            else
                pp310.AllowDrop = true;
        }

        private void pp310_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp310.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 3);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje310.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje310.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp311_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp311.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp311.AllowDrop = false;
            else
                pp311.AllowDrop = true;
        }

        private void pp311_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp311.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 3);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje311.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje311.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp312_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp312.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp312.AllowDrop = false;
            else
                pp312.AllowDrop = true;
        }

        private void pp312_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp312.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 3);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje312.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje312.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp313_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp313.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp313.AllowDrop = false;
            else
                pp313.AllowDrop = true;
        }

        private void pp313_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp313.Tag.ToString();
            Zaposleni z = sz.NadjiZap3(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 3);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje313.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje313.Visible = true;


            }
            this.Opacity = 100;
        }
        #endregion
        #region GR4
        private void pp41_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp41.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp41.AllowDrop = false;
            else
                pp41.AllowDrop = true;
        }

        private void pp41_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp41.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 4);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje41.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje41.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp42_DragEnter(object sender, DragEventArgs e)
        {
              e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp42.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp42.AllowDrop = false;
            else
                pp42.AllowDrop = true;
        
        }

        private void pp42_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp42.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 4);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje42.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje42.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp43_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp43.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp43.AllowDrop = false;
            else
                pp43.AllowDrop = true;
        }

        private void pp43_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp43.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 4);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje43.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje43.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp44_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp44.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp44.AllowDrop = false;
            else
                pp44.AllowDrop = true;
        }

        private void pp44_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp44.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 4);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje44.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje44.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp45_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp45.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp45.AllowDrop = false;
            else
                pp45.AllowDrop = true;
        }

        private void pp45_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp45.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 4);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje45.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje45.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp46_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp46.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp46.AllowDrop = false;
            else
                pp46.AllowDrop = true;
        }

        private void pp46_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp46.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 4);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje46.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje46.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp47_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp47.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp47.AllowDrop = false;
            else
                pp47.AllowDrop = true;
        }

        private void pp47_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp47.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 4);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje47.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje47.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp48_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp48.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp48.AllowDrop = false;
            else
                pp48.AllowDrop = true;
        }

        private void pp48_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp48.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 4);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje48.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje48.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp49_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp49.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp49.AllowDrop = false;
            else
                pp49.AllowDrop = true;
        }

        private void pp49_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp49.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 4);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje49.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje49.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp410_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp410.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp410.AllowDrop = false;
            else
                pp410.AllowDrop = true;
        }

        private void pp410_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp410.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 4);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje410.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje410.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp411_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp411.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp411.AllowDrop = false;
            else
                pp411.AllowDrop = true;
        }

        private void pp411_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp411.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 4);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje411.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje41.Visible = true;


            }
            this.Opacity = 100;
        }

       private void pp412_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp412.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp412.AllowDrop = false;
            else
                pp412.AllowDrop = true;
        }

        private void pp412_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp412.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 4);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje412.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje412.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp413_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp413.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp413.AllowDrop = false;
            else
                pp413.AllowDrop = true;
        }

        private void pp413_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp413.Tag.ToString();
            Zaposleni z = sz.NadjiZap4(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 4);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje413.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje413.Visible = true;


            }
            this.Opacity = 100;
        }
        #endregion
        #region GR5
        private void pp51_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp51.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp51.AllowDrop = false;
            else
                pp51.AllowDrop = true;
        }

        private void pp51_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp51.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 5);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje51.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje51.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp52_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp52.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 5);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje52.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje52.Visible = true;


            }
            this.Opacity = 100;
        }
        private void pp52_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp52.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp52.AllowDrop = false;
            else
                pp52.AllowDrop = true;
        }

        private void pp53_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp53.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp53.AllowDrop = false;
            else
                pp53.AllowDrop = true;
        }

        private void pp53_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp53.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 5);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje53.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje53.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp54_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp54.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp54.AllowDrop = false;
            else
                pp54.AllowDrop = true;
        }

        private void pp54_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp54.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 5);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje54.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje54.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp55_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp55.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp55.AllowDrop = false;
            else
                pp55.AllowDrop = true;
        }

        private void pp55_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp55.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 5);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje55.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje55.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp56_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp56.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp56.AllowDrop = false;
            else
                pp56.AllowDrop = true;
        }

        private void pp56_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp56.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 5);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje56.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje56.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp57_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp57.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp57.AllowDrop = false;
            else
                pp57.AllowDrop = true;
        }

        private void pp57_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp57.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 5);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje57.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje57.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp58_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp58.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp58.AllowDrop = false;
            else
                pp58.AllowDrop = true;
        }

        private void pp58_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp58.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 5);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje58.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje58.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp59_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp59.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 5);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje59.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje59.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp59_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp59.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp59.AllowDrop = false;
            else
                pp59.AllowDrop = true;
        }

        private void pp510_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp510.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp510.AllowDrop = false;
            else
                pp510.AllowDrop = true;
        }

        private void pp510_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp510.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 5);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje510.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje510.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp511_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp511.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp511.AllowDrop = false;
            else
                pp511.AllowDrop = true;
        }

        private void pp511_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp511.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 5);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje511.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje511.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp512_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp512.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp512.AllowDrop = false;
            else
                pp512.AllowDrop = true;
        }

        private void pp512_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp512.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 5);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje512.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje512.Visible = true;


            }
            this.Opacity = 100;
        }

        private void pp513_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            String sifz = pp513.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            if (!z.Stanje.Equals("slobodan") || !z.Kategorija.Equals(k.Kategorija))
                pp513.AllowDrop = false;
            else
                pp513.AllowDrop = true;
        }

        private void pp513_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");


            String sifk = NewNode.Tag.ToString();
            Klijent k = sk.NadjiKlijenta(sifk);

            lbsifk.Text = sifk;

            String sifz = pp513.Tag.ToString();
            Zaposleni z = sz.NadjiZap5(sifz);

            this.Opacity = .75;
            AngazZap ang = new AngazZap(sifk, sifz, 5);

            DialogResult dr = ang.ShowDialog();
            if (dr == DialogResult.OK)
            {

                z.Stanje = "na zadatku";

                pStanje513.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.busy;
                pStanje513.Visible = true;


            }
            this.Opacity = 100;
        }
        #endregion

#endregion

 #region MOUSE_DOWN_GR1

        private void pp1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp1);
                    pp1.ContextMenuStrip.Show(this.pp1, e.Location);
                    lbp.Text = "pp1";
                    Zaposleni z = sz.NadjiZap1(pp1.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp2_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp2);
                    pp1.ContextMenuStrip.Show(this.pp2, e.Location);
                    lbp.Text = "pp2";
                    Zaposleni z = sz.NadjiZap1(pp2.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp3_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp3);
                    pp1.ContextMenuStrip.Show(this.pp3, e.Location);
                    lbp.Text = "pp3";
                    Zaposleni z = sz.NadjiZap1(pp3.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp4_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp4);
                    pp1.ContextMenuStrip.Show(this.pp4, e.Location);
                    lbp.Text = "pp4";
                    Zaposleni z = sz.NadjiZap1(pp4.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp5_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp5);
                    pp1.ContextMenuStrip.Show(this.pp5, e.Location);
                    lbp.Text = "pp5";
                    Zaposleni z = sz.NadjiZap1(pp5.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp6_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp6);
                    pp1.ContextMenuStrip.Show(this.pp6, e.Location);
                    lbp.Text = "pp6";
                    Zaposleni z = sz.NadjiZap1(pp6.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp7_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp7);
                    pp1.ContextMenuStrip.Show(this.pp7, e.Location);
                    lbp.Text = "pp7";
                    Zaposleni z = sz.NadjiZap1(pp7.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp8_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp8);
                    pp1.ContextMenuStrip.Show(this.pp8, e.Location);
                    lbp.Text = "pp8";
                    Zaposleni z = sz.NadjiZap1(pp8.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp9_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp9);
                    pp1.ContextMenuStrip.Show(this.pp9, e.Location);
                    lbp.Text = "pp9";
                    Zaposleni z = sz.NadjiZap1(pp9.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp10_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp10);
                    pp1.ContextMenuStrip.Show(this.pp10, e.Location);
                    lbp.Text = "pp10";
                    Zaposleni z = sz.NadjiZap1(pp10.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp11_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp11);
                    pp1.ContextMenuStrip.Show(this.pp11, e.Location);
                    lbp.Text = "pp11";
                    Zaposleni z = sz.NadjiZap1(pp11.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp12_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp12);
                    pp1.ContextMenuStrip.Show(this.pp12, e.Location);
                    lbp.Text = "pp12";
                    Zaposleni z = sz.NadjiZap1(pp12.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp13_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp13);
                    pp1.ContextMenuStrip.Show(this.pp13, e.Location);
                    lbp.Text = "pp13";
                    Zaposleni z = sz.NadjiZap1(pp13.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }
#endregion 

#endregion

#region GRUPA 2
     

        private void pbGrupa2_Click_1(object sender, EventArgs e)
        {

            tabCtrl.SelectedTab = tbGr2;
            lbPocetna2.Text = "";
            visibleBtnZap();

            if (spisakZaposleni.Instanca().BrojZap2() == 0)
            {
                disableBtnZap();
                lbPocetna2.Text = "U grupi 2 trenutno nema zaposlenih.";
            }
        }

       
        private Panel slobodanPanel2()
        {
            Dictionary<string, Panel>.Enumerator e = spisakPanela2.GetEnumerator();
            {
                Panel pan = new Panel();
                while (e.MoveNext())
                {
                    pan = e.Current.Value;
                    if (pan.Visible == false)
                        break;

                }
                return pan;
            }
        }



#region SELEKCIJA_PARCELA2


        private void pp21_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
            selekt = 1;
        }

        private void pp22_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp23_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp24_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp25_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp26_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp27_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp28_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp29_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp210_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp211_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp212_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp213_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

       
#endregion

#region dugmici ZAPOSLENI
        private void btnDodZap2_Click(object sender, EventArgs e)
        {
            DodavanjeZaposlenog dz = new DodavanjeZaposlenog(2);
            this.Opacity = .70;
            DialogResult dr = dz.ShowDialog();
            if (dr == DialogResult.OK)
            {
                String sifra = zaposleni.Kljuc();

                slob2 = slobodanPanel2();
                slob2.BackgroundImage = DodavanjeZaposlenog.z.postaviSliku();
                slob2.Tag = DodavanjeZaposlenog.z.Kljuc();
                slob2.Visible = true;
                slob2.AllowDrop = true;
                Zaposleni z = sz.NadjiZap2(DodavanjeZaposlenog.z.Kljuc());
                z.Panel = slob2;

                lbPocetna2.Text = "";
                brSlob2 = 13 - spisakZaposleni.Instanca().BrojZap2();
                lbSt2.Text = brSlob2 + " slobodno";
                tt.SetToolTip(pbGrupa2, "Grupa 2: " + lbSt2.Text);
                this.enableBtnZap();
                this.Opacity = 1;
            }
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void btnIzmZap2_Click(object sender, EventArgs e)
        {
            if (selektovanZaposleni == null)
                MessageBox.Show("Morate selektovati zaposlenog za izmenu!");
            else
            {
                String salji = selektovanZaposleni.Tag.ToString();

                Zaposleni z = sz.NadjiZap2(salji);
                IzmenaZaposlenog iz = new IzmenaZaposlenog(salji, 2);
                Opacity = .7;
                DialogResult dr = iz.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    selektovanZaposleni.BackgroundImage = z.postaviSliku();
                }
                Opacity = 1;
            }
        }

        private void btnUklZap2_Click(object sender, EventArgs e)
        {
            if (selektovanZaposleni == null)
                MessageBox.Show("Morate selektovati zaposlenog za izmenu!");
            else
            {
                salji = selektovanZaposleni.Tag.ToString();
                BrisZap p1 = new BrisZap(salji);
                DialogResult dr = p1.ShowDialog();
                this.Opacity = .60;
                if (dr == DialogResult.Yes)
                {
                    sz.UkloniZap2(salji);
                    if (sz.BrojZap2() == 0)
                    {
                        disableBtnZap();
                        lbPocetna2.Text = "U grupi 2 trenutno nema zaposlenih.";
                    }
                    selektovanZaposleni.Visible = false;
                    int brSlob = 13 - spisakZaposleni.Instanca().BrojZap2();
                    lbSt2.Text = brSlob + " slobodno";
                    tt.SetToolTip(pbGrupa2, "Grupa 2: " + lbSt2.Text);
                    this.Opacity = 1;
                }
                else
                    this.Opacity = 1;
            }
        }
        #endregion

#region MOUSE_DOWN_GR2

        private void pp21_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp21);
                    pp21.ContextMenuStrip.Show(this.pp21, e.Location);
                    lbp.Text = "pp21";
                    Zaposleni z = sz.NadjiZap2(pp21.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp22_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp22);
                    pp22.ContextMenuStrip.Show(this.pp22, e.Location);
                    lbp.Text = "pp22";
                    Zaposleni z = sz.NadjiZap2(pp22.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp23_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp23);
                    pp23.ContextMenuStrip.Show(this.pp23, e.Location);
                    lbp.Text = "pp23";
                    Zaposleni z = sz.NadjiZap2(pp23.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp24_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp24);
                    pp24.ContextMenuStrip.Show(this.pp24, e.Location);
                    lbp.Text = "pp24";
                    Zaposleni z = sz.NadjiZap2(pp24.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp25_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp25);
                    pp25.ContextMenuStrip.Show(this.pp25, e.Location);
                    lbp.Text = "pp25";
                    Zaposleni z = sz.NadjiZap2(pp25.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp26_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp26);
                    pp26.ContextMenuStrip.Show(this.pp26, e.Location);
                    lbp.Text = "pp26";
                    Zaposleni z = sz.NadjiZap2(pp26.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp27_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp27);
                    pp27.ContextMenuStrip.Show(this.pp27, e.Location);
                    lbp.Text = "pp27";
                    Zaposleni z = sz.NadjiZap2(pp27.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp28_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp28);
                    pp1.ContextMenuStrip.Show(this.pp28, e.Location);
                    lbp.Text = "pp28";
                    Zaposleni z = sz.NadjiZap2(pp28.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp29_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp29);
                    pp29.ContextMenuStrip.Show(this.pp29, e.Location);
                    lbp.Text = "pp29";
                    Zaposleni z = sz.NadjiZap2(pp29.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp210_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp210);
                    pp210.ContextMenuStrip.Show(this.pp210, e.Location);
                    lbp.Text = "pp210";
                    Zaposleni z = sz.NadjiZap2(pp210.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp211_MouseDown(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp211);
                    pp211.ContextMenuStrip.Show(this.pp211, e.Location);
                    lbp.Text = "pp211";
                    Zaposleni z = sz.NadjiZap2(pp211.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp212_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp212);
                    pp212.ContextMenuStrip.Show(this.pp212, e.Location);
                    lbp.Text = "pp212";
                    Zaposleni z = sz.NadjiZap2(pp212.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp213_MouseDown(object sender, MouseEventArgs e)
        {
           switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp213);
                    pp213.ContextMenuStrip.Show(this.pp213, e.Location);
                    lbp.Text = "pp213";
                    Zaposleni z = sz.NadjiZap2(pp213.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        #endregion

#endregion

#region GRUPA 3

     
        private void pbGrupa3_Click_1(object sender, EventArgs e)
        {
            tabCtrl.SelectedTab = tbGr3;
            lbPocetna3.Text = "";
            visibleBtnZap();
            if (spisakZaposleni.Instanca().BrojZap3() == 0)
            {
                disableBtnZap();
                lbPocetna3.Text = "U grupi 3 trenutno nema zaposlenih.";
            }
        }

      
        private Panel slobodanPanel3()
        {
            Dictionary<string, Panel>.Enumerator e = spisakPanela3.GetEnumerator();
            {
                Panel pan = new Panel();
                while (e.MoveNext())
                {
                    pan = e.Current.Value;
                    if (pan.Visible == false)
                        break;

                }
                return pan;
            }
        }

#region dugmici_ZAPOSLENI
        private void btnDodZap3_Click(object sender, EventArgs e)
        {
            DodavanjeZaposlenog dz = new DodavanjeZaposlenog(3);
            this.Opacity = .70;
            DialogResult dr = dz.ShowDialog();
            if (dr == DialogResult.OK)
            {
                String sifra = zaposleni.Kljuc();

                slob3 = slobodanPanel3();
                slob3.BackgroundImage = DodavanjeZaposlenog.z.postaviSliku();
                slob3.Tag = DodavanjeZaposlenog.z.Kljuc();
                slob3.Visible = true;
                slob3.AllowDrop = true;
                Zaposleni z = sz.NadjiZap3(DodavanjeZaposlenog.z.Kljuc());
                z.Panel = slob3;

                lbPocetna3.Text = "";
                int brSlob = 13 - spisakZaposleni.Instanca().BrojZap3();
                lbSt3.Text = brSlob + " slobodno";
                tt.SetToolTip(pbGrupa3, "Grupa 3: " + lbSt3.Text);
                this.enableBtnZap();
                this.Opacity = 1;
            }
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void btnIzmZap3_Click(object sender, EventArgs e)
        {
            if (selektovanZaposleni == null)
                MessageBox.Show("Morate selektovati zaposlenog za izmenu!");
            else
            {
                String salji = selektovanZaposleni.Tag.ToString();

                Zaposleni z = sz.NadjiZap3(salji);
                IzmenaZaposlenog iz = new IzmenaZaposlenog(salji, 3);
                Opacity = .7;
                DialogResult dr = iz.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    selektovanZaposleni.BackgroundImage = z.postaviSliku();
                }
                Opacity = 1;
            }
        }

        private void btnUklZap3_Click(object sender, EventArgs e)
        {
            if (selektovanZaposleni == null)
                MessageBox.Show("Morate selektovati zaposlenog za izmenu!");
            else
            {
                salji = selektovanZaposleni.Tag.ToString();
                BrisZap p1 = new BrisZap(salji);
                DialogResult dr = p1.ShowDialog();
                this.Opacity = .60;
                if (dr == DialogResult.Yes)
                {
                    sz.UkloniZap3(salji);
                    if (sz.BrojZap3() == 0)
                    {
                        disableBtnZap();
                        lbPocetna3.Text = "U grupi 3 trenutno nema zaposlenih.";
                    }
                    selektovanZaposleni.Visible = false;
                    int brSlob = 13 - spisakZaposleni.Instanca().BrojZap3();
                    lbSt3.Text = brSlob + " slobodno";
                    tt.SetToolTip(pbGrupa3, "Grupa 3: " + lbSt3.Text);
                    this.Opacity = 1;
                }
                else
                    this.Opacity = 1;
            }
        }
        #endregion

#region SELEKCIJA_PARCELA3

        private void pp31_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp32_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp33_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp34_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp35_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp36_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp37_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp38_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp39_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp310_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp311_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp312_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp313_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }
#endregion

#region MOUSE_DOWN_GR3
        private void pp31_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp31);
                    pp31.ContextMenuStrip.Show(this.pp31, e.Location);
                    lbp.Text = "pp31";
                    Zaposleni z = sz.NadjiZap3(pp31.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }

        }

        private void pp32_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp32);
                    pp32.ContextMenuStrip.Show(this.pp32, e.Location);
                    lbp.Text = "pp32";
                    Zaposleni z = sz.NadjiZap3(pp32.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp33_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp33);
                    pp33.ContextMenuStrip.Show(this.pp33, e.Location);
                    lbp.Text = "pp33";
                    Zaposleni z = sz.NadjiZap3(pp33.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp34_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp34);
                    pp34.ContextMenuStrip.Show(this.pp34, e.Location);
                    lbp.Text = "pp34";
                    Zaposleni z = sz.NadjiZap3(pp34.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp35_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp35);
                    pp35.ContextMenuStrip.Show(this.pp35, e.Location);
                    lbp.Text = "pp35";
                    Zaposleni z = sz.NadjiZap3(pp35.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp36_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp36);
                    pp36.ContextMenuStrip.Show(this.pp36, e.Location);
                    lbp.Text = "pp36";
                    Zaposleni z = sz.NadjiZap3(pp36.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp37_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp37);
                    pp37.ContextMenuStrip.Show(this.pp37, e.Location);
                    lbp.Text = "pp37";
                    Zaposleni z = sz.NadjiZap3(pp37.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp38_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp38);
                    pp38.ContextMenuStrip.Show(this.pp38, e.Location);
                    lbp.Text = "pp38";
                    Zaposleni z = sz.NadjiZap3(pp38.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp39_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp39);
                    pp39.ContextMenuStrip.Show(this.pp39, e.Location);
                    lbp.Text = "pp39";
                    Zaposleni z = sz.NadjiZap3(pp39.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp310_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp310);
                    pp310.ContextMenuStrip.Show(this.pp310, e.Location);
                    lbp.Text = "pp310";
                    Zaposleni z = sz.NadjiZap3(pp310.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp311_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp311);
                    pp31.ContextMenuStrip.Show(this.pp311, e.Location);
                    lbp.Text = "pp311";
                    Zaposleni z = sz.NadjiZap3(pp311.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp312_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp312);
                    pp312.ContextMenuStrip.Show(this.pp312, e.Location);
                    lbp.Text = "pp312";
                    Zaposleni z = sz.NadjiZap3(pp312.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp313_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp313);
                    pp313.ContextMenuStrip.Show(this.pp313, e.Location);
                    lbp.Text = "pp313";
                    Zaposleni z = sz.NadjiZap3(pp313.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }
#endregion



#endregion

#region GRUPA 4

     
        private void pbGrupa4_Click_1(object sender, EventArgs e)
        {

            tabCtrl.SelectedTab = tbGr4;
            lbPocetna4.Text = "";
            visibleBtnZap();
            if (spisakZaposleni.Instanca().BrojZap4() == 0)
            {
                disableBtnZap();
                lbPocetna4.Text = "U grupi 4 trenutno nema zaposlenih.";
            }
        }

      
        private Panel slobodanPanel4()
        {
            Dictionary<string, Panel>.Enumerator e = spisakPanela4.GetEnumerator();
            {
                Panel pan = new Panel();
                while (e.MoveNext())
                {
                    pan = e.Current.Value;
                    if (pan.Visible == false)
                        break;

                }
                return pan;
            }
        }

#region SELEKCIJA_PARCELA4
        private void pp41_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp42_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp43_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp44_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp45_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp46_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp47_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp48_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp49_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp410_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp411_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp412_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp413_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }
#endregion

#region dugmici_ZAPOSLENI4
        private void btnDodZap4_Click(object sender, EventArgs e)
        {
            DodavanjeZaposlenog dz = new DodavanjeZaposlenog(4);
            this.Opacity = .70;
            DialogResult dr = dz.ShowDialog();
            if (dr == DialogResult.OK)
            {
                String sifra = zaposleni.Kljuc();

                slob4 = slobodanPanel4();
                slob4.BackgroundImage = DodavanjeZaposlenog.z.postaviSliku();
                slob4.Tag = DodavanjeZaposlenog.z.Kljuc();
                slob4.Visible = true;
                slob4.AllowDrop = true;
                Zaposleni z = sz.NadjiZap4(DodavanjeZaposlenog.z.Kljuc());
                z.Panel = slob4;

                lbPocetna4.Text = "";
                int brSlob = 13 - spisakZaposleni.Instanca().BrojZap4();
                lbSt4.Text = brSlob + " slobodno";
                tt.SetToolTip(pbGrupa4, "Grupa 4: " + lbSt4.Text);
                this.enableBtnZap();
                this.Opacity = 1;
            }
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void btnIzmZap4_Click(object sender, EventArgs e)
        {
            if (selektovanZaposleni == null)
                MessageBox.Show("Morate selektovati zaposlenog za izmenu!");
            else
            {
                String salji = selektovanZaposleni.Tag.ToString();

                Zaposleni z = sz.NadjiZap4(salji);
                IzmenaZaposlenog iz = new IzmenaZaposlenog(salji, 4);
                Opacity = .7;
                DialogResult dr = iz.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    selektovanZaposleni.BackgroundImage = z.postaviSliku();
                }
                Opacity = 1;
            }
        }


        private void btnUklZap4_Click(object sender, EventArgs e)
        {
            if (selektovanZaposleni == null)
                MessageBox.Show("Morate selektovati zaposlenog za izmenu!");
            salji = selektovanZaposleni.Tag.ToString();
            BrisZap p1 = new BrisZap(salji);
            DialogResult dr = p1.ShowDialog();
            this.Opacity = .60;
            if (dr == DialogResult.Yes)
            {
                sz.UkloniZap4(salji);
                if (sz.BrojZap4() == 0)
                {
                    disableBtnZap();
                    lbPocetna4.Text = "U grupi 4 trenutno nema zaposlenih.";
                }
                selektovanZaposleni.Visible = false;
                int brSlob = 13 - spisakZaposleni.Instanca().BrojZap4();
                lbSt4.Text = brSlob + " slobodno";
                tt.SetToolTip(pbGrupa4, "Grupa 4: " + lbSt4.Text);
                this.Opacity = 1;
            }
            else
                this.Opacity = 1;
        }
#endregion

#region MOUSE_DOWN_GR4

        private void pp41_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp41);
                    pp41.ContextMenuStrip.Show(this.pp41, e.Location);
                    lbp.Text = "pp41";
                    Zaposleni z = sz.NadjiZap4(pp41.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp42_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp42);
                    pp42.ContextMenuStrip.Show(this.pp42, e.Location);
                    lbp.Text = "pp42";
                    Zaposleni z = sz.NadjiZap4(pp42.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp43_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp43);
                    pp43.ContextMenuStrip.Show(this.pp43, e.Location);
                    lbp.Text = "pp43";
                    Zaposleni z = sz.NadjiZap4(pp43.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp44_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp44);
                    pp44.ContextMenuStrip.Show(this.pp44, e.Location);
                    lbp.Text = "pp44";
                    Zaposleni z = sz.NadjiZap4(pp44.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp45_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp45);
                    pp45.ContextMenuStrip.Show(this.pp45, e.Location);
                    lbp.Text = "pp45";
                    Zaposleni z = sz.NadjiZap4(pp45.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp46_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp46);
                    pp46.ContextMenuStrip.Show(this.pp46, e.Location);
                    lbp.Text = "pp46";
                    Zaposleni z = sz.NadjiZap4(pp46.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp47_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp47);
                    pp47.ContextMenuStrip.Show(this.pp47, e.Location);
                    lbp.Text = "pp47";
                    Zaposleni z = sz.NadjiZap4(pp47.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp48_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp48);
                    pp48.ContextMenuStrip.Show(this.pp48, e.Location);
                    lbp.Text = "pp48";
                    Zaposleni z = sz.NadjiZap4(pp48.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp49_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp49);
                    pp49.ContextMenuStrip.Show(this.pp49, e.Location);
                    lbp.Text = "pp49";
                    Zaposleni z = sz.NadjiZap4(pp49.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp410_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp410);
                    pp410.ContextMenuStrip.Show(this.pp410, e.Location);
                    lbp.Text = "pp410";
                    Zaposleni z = sz.NadjiZap4(pp410.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp411_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp411);
                    pp411.ContextMenuStrip.Show(this.pp411, e.Location);
                    lbp.Text = "pp411";
                    Zaposleni z = sz.NadjiZap4(pp411.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp412_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp412);
                    pp412.ContextMenuStrip.Show(this.pp412, e.Location);
                    lbp.Text = "pp412";
                    Zaposleni z = sz.NadjiZap4(pp412.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }

        private void pp413_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DeselektujPP(pp413);
                    pp413.ContextMenuStrip.Show(this.pp413, e.Location);
                    lbp.Text = "pp413";
                    Zaposleni z = sz.NadjiZap4(pp413.Tag.ToString());
                    z.postaviKonteksniMeni();

                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }
        }
        
#endregion

#endregion

#region GRUPA 5

        private void pbGrupa5_Click_1(object sender, EventArgs e)
        {

            tabCtrl.SelectedTab = tbGr5;
            lbPocetna5.Text = "";
            visibleBtnZap();
            if (spisakZaposleni.Instanca().BrojZap5() == 0)
            {
                disableBtnZap();
                lbPocetna5.Text = "U grupi 5 trenutno nema zaposlenih.";
            }
        }
        private Panel slobodanPanel5()
        {
            Dictionary<string, Panel>.Enumerator e = spisakPanela5.GetEnumerator();
            {
                Panel pan = new Panel();
                while (e.MoveNext())
                {
                    pan = e.Current.Value;
                    if (pan.Visible == false)
                        break;

                }
                return pan;
            }
        }

#region SELEKCIJA_PARCELA5

        private void pp51_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp52_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp53_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp54_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp55_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp56_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp57_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp58_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp59_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp510_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp511_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp512_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        private void pp513_Click(object sender, EventArgs e)
        {
            SelektujPP((Panel)sender);
        }

        #endregion

#region dugmici_ZAPOSLENI5
        private void btnDodZap5_Click(object sender, EventArgs e)
        {
            DodavanjeZaposlenog dz = new DodavanjeZaposlenog(5);
            this.Opacity = .70;
            DialogResult dr = dz.ShowDialog();
            if (dr == DialogResult.OK)
            {
                String sifra = zaposleni.Kljuc();

                slob5 = slobodanPanel5();
                slob5.BackgroundImage = DodavanjeZaposlenog.z.postaviSliku();
                slob5.Tag = DodavanjeZaposlenog.z.Kljuc();
                slob5.Visible = true;
                slob5.AllowDrop = true;
                Zaposleni z = sz.NadjiZap5(DodavanjeZaposlenog.z.Kljuc());
                z.Panel = slob5;

                lbPocetna5.Text = "";
                int brSlob = 13 - spisakZaposleni.Instanca().BrojZap5();
                lbSt5.Text = brSlob + " slobodno";
                tt.SetToolTip(pbGrupa5, "Grupa 5: " + lbSt5.Text);
                this.enableBtnZap();
                this.Opacity = 1;
            }
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

    private void btnIzmZap5_Click(object sender, EventArgs e)
    {
        if (selektovanZaposleni == null)
            MessageBox.Show("Morate selektovati zaposlenog za izmenu!");
        else
        {
            String salji = selektovanZaposleni.Tag.ToString();

            Zaposleni z = sz.NadjiZap5(salji);
            IzmenaZaposlenog iz = new IzmenaZaposlenog(salji, 5);
            Opacity = .7;
            DialogResult dr = iz.ShowDialog();
            if (dr == DialogResult.OK)
            {
                selektovanZaposleni.BackgroundImage = z.postaviSliku();
            }
            Opacity = 1;
        }
    }


    private void btnUklZap5_Click(object sender, EventArgs e)
    {
        if (selektovanZaposleni == null)
            MessageBox.Show("Morate selektovati zaposlenog za uklanjanje!");
        else
        {
            salji = selektovanZaposleni.Tag.ToString();
            BrisZap p1 = new BrisZap(salji);
            DialogResult dr = p1.ShowDialog();
            this.Opacity = .60;
            if (dr == DialogResult.Yes)
            {
                sz.UkloniZap5(salji);
                if (sz.BrojZap5() == 0)
                {
                    disableBtnZap();
                    lbPocetna5.Text = "U grupi 5 trenutno nema zaposlenih.";
                }
                selektovanZaposleni.Visible = false;
                int brSlob = 13 - spisakZaposleni.Instanca().BrojZap5();
                lbSt5.Text = brSlob + " slobodno";
                tt.SetToolTip(pbGrupa5, "Grupa 5: " + lbSt5.Text);
                this.Opacity = 1;
            }
            else
                this.Opacity = 1;
        }
    }
#endregion

#region MOUSE_DOWN_GR5
    private void pp51_MouseDown(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
            case MouseButtons.Right:
                DeselektujPP(pp51);
                pp51.ContextMenuStrip.Show(this.pp51, e.Location);
                lbp.Text = "pp51";
                Zaposleni z = sz.NadjiZap5(pp51.Tag.ToString());
                z.postaviKonteksniMeni();

                break;
            case MouseButtons.Middle:
                break;
            default:
                break;
        }
    }

    private void pp52_MouseDown(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
            case MouseButtons.Right:
                DeselektujPP(pp52);
                pp52.ContextMenuStrip.Show(this.pp52, e.Location);
                lbp.Text = "pp52";
                Zaposleni z = sz.NadjiZap5(pp52.Tag.ToString());
                z.postaviKonteksniMeni();

                break;
            case MouseButtons.Middle:
                break;
            default:
                break;
        }
    }

    private void pp53_MouseDown(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
            case MouseButtons.Right:
                DeselektujPP(pp53);
                pp53.ContextMenuStrip.Show(this.pp53, e.Location);
                lbp.Text = "pp53";
                Zaposleni z = sz.NadjiZap5(pp53.Tag.ToString());
                z.postaviKonteksniMeni();

                break;
            case MouseButtons.Middle:
                break;
            default:
                break;
        }
    }

    private void pp54_MouseDown(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
            case MouseButtons.Right:
                DeselektujPP(pp54);
                pp54.ContextMenuStrip.Show(this.pp54, e.Location);
                lbp.Text = "pp54";
                Zaposleni z = sz.NadjiZap5(pp54.Tag.ToString());
                z.postaviKonteksniMeni();

                break;
            case MouseButtons.Middle:
                break;
            default:
                break;
        }
    }

    private void pp55_MouseDown(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
            case MouseButtons.Right:
                DeselektujPP(pp55);
                pp55.ContextMenuStrip.Show(this.pp55, e.Location);
                lbp.Text = "pp55";
                Zaposleni z = sz.NadjiZap5(pp55.Tag.ToString());
                z.postaviKonteksniMeni();

                break;
            case MouseButtons.Middle:
                break;
            default:
                break;
        }
    }

    private void pp56_MouseDown(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
            case MouseButtons.Right:
                DeselektujPP(pp56);
                pp56.ContextMenuStrip.Show(this.pp56, e.Location);
                lbp.Text = "pp56";
                Zaposleni z = sz.NadjiZap5(pp56.Tag.ToString());
                z.postaviKonteksniMeni();

                break;
            case MouseButtons.Middle:
                break;
            default:
                break;
        }
    }

    private void pp57_MouseDown(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
            case MouseButtons.Right:
                DeselektujPP(pp57);
                pp57.ContextMenuStrip.Show(this.pp57, e.Location);
                lbp.Text = "pp57";
                Zaposleni z = sz.NadjiZap5(pp57.Tag.ToString());
                z.postaviKonteksniMeni();

                break;
            case MouseButtons.Middle:
                break;
            default:
                break;
        }
    }

    private void pp58_MouseDown(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
            case MouseButtons.Right:
                DeselektujPP(pp58);
                pp58.ContextMenuStrip.Show(this.pp58, e.Location);
                lbp.Text = "pp58";
                Zaposleni z = sz.NadjiZap5(pp58.Tag.ToString());
                z.postaviKonteksniMeni();

                break;
            case MouseButtons.Middle:
                break;
            default:
                break;
        }
    }

    private void pp59_MouseDown(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
            case MouseButtons.Right:
                DeselektujPP(pp59);
                pp59.ContextMenuStrip.Show(this.pp59, e.Location);
                lbp.Text = "pp59";
                Zaposleni z = sz.NadjiZap5(pp59.Tag.ToString());
                z.postaviKonteksniMeni();

                break;
            case MouseButtons.Middle:
                break;
            default:
                break;
        }
    }

    private void pp510_MouseDown(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
            case MouseButtons.Right:
                DeselektujPP(pp510);
                pp510.ContextMenuStrip.Show(this.pp510, e.Location);
                lbp.Text = "pp510";
                Zaposleni z = sz.NadjiZap5(pp510.Tag.ToString());
                z.postaviKonteksniMeni();

                break;
            case MouseButtons.Middle:
                break;
            default:
                break;
        }
    }

    private void pp511_MouseDown(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
            case MouseButtons.Right:
                DeselektujPP(pp511);
                pp511.ContextMenuStrip.Show(this.pp511, e.Location);
                lbp.Text = "pp511";
                Zaposleni z = sz.NadjiZap5(pp511.Tag.ToString());
                z.postaviKonteksniMeni();

                break;
            case MouseButtons.Middle:
                break;
            default:
                break;
        }
    }

    private void pp512_MouseDown(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
            case MouseButtons.Right:
                DeselektujPP(pp512);
                pp512.ContextMenuStrip.Show(this.pp512, e.Location);
                lbp.Text = "pp512";
                Zaposleni z = sz.NadjiZap5(pp512.Tag.ToString());
                z.postaviKonteksniMeni();

                break;
            case MouseButtons.Middle:
                break;
            default:
                break;
        }
    }

    private void pp513_MouseDown(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
            case MouseButtons.Right:
                DeselektujPP(pp513);
                pp513.ContextMenuStrip.Show(this.pp513, e.Location);
                lbp.Text = "pp513";
                Zaposleni z = sz.NadjiZap5(pp513.Tag.ToString());
                z.postaviKonteksniMeni();

                break;
            case MouseButtons.Middle:
                break;
            default:
                break;
        }
    }
    #endregion.l
#endregion


    #region contextMeni

        private void poslatiNaOdmorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbp.Text.Equals("pp1"))
            {
                String sifra = pp1.Tag.ToString();
                pStanje.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp1.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp2"))
            {
                String sifra = pp2.Tag.ToString();
                pStanje2.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje2.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp2.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp3"))
            {
                String sifra = pp3.Tag.ToString();
                pStanje3.Visible = true;
                pStanje3.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
               
                Zaposleni z = sz.NadjiZap1(pp3.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp4"))
            {
                String sifra = pp4.Tag.ToString();
                pStanje4.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje4.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp4.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp5"))
            {
                String sifra = pp5.Tag.ToString();
                pStanje5.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje5.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp5.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp6"))
            {
                String sifra = pp6.Tag.ToString();
                pStanje6.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje6.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp6.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp7"))
            {
                String sifra = pp7.Tag.ToString();
                pStanje7.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje7.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp7.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp8"))
            {
                String sifra = pp8.Tag.ToString();
                pStanje8.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje8.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp8.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp9"))
            {
                String sifra = pp9.Tag.ToString();
                pStanje9.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje9.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp9.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp10"))
            {
                String sifra = pp10.Tag.ToString();
                pStanje10.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje10.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp10.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp11"))
            {
                String sifra = pp1.Tag.ToString();
                pStanje11.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje11.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp11.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp12"))
            {
                String sifra = pp12.Tag.ToString();
                pStanje12.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje12.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp12.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp13"))
            {
                String sifra = pp13.Tag.ToString();
                pStanje13.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje13.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp13.Tag.ToString());
                z.Stanje = "odmor";
            }
//GR2......................
            if (lbp.Text.Equals("pp21"))
            {
                String sifra = pp21.Tag.ToString();
                pStanje21.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje21.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp21.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp22"))
            {
                String sifra = pp22.Tag.ToString();
                pStanje22.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje22.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp22.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp23"))
            {
                String sifra = pp23.Tag.ToString();
                pStanje23.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje23.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp23.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp24"))
            {
                String sifra = pp24.Tag.ToString();
                pStanje24.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje24.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp24.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp25"))
            {
                String sifra = pp25.Tag.ToString();
                pStanje25.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje25.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp25.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp26"))
            {
                String sifra = pp26.Tag.ToString();
                pStanje26.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje26.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp26.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp27"))
            {
                String sifra = pp27.Tag.ToString();
                pStanje27.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje27.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp27.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp28"))
            {
                String sifra = pp28.Tag.ToString();
                pStanje28.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje28.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp28.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp29"))
            {
                String sifra = pp29.Tag.ToString();
                pStanje29.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje29.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp29.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp210"))
            {
                String sifra = pp210.Tag.ToString();
                pStanje210.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje210.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp210.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp211"))
            {
                String sifra = pp211.Tag.ToString();
                pStanje211.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje211.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp211.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp212"))
            {
                String sifra = pp212.Tag.ToString();
                pStanje212.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje212.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp212.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp213"))
            {
                String sifra = pp213.Tag.ToString();
                pStanje213.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje213.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp213.Tag.ToString());
                z.Stanje = "odmor";
            }
//GR3......................
            if (lbp.Text.Equals("pp31"))
            {
                String sifra = pp31.Tag.ToString();
                pStanje31.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje31.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp31.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp32"))
            {
                String sifra = pp32.Tag.ToString();
                pStanje32.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje32.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp32.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp33"))
            {
                String sifra = pp33.Tag.ToString();
                pStanje33.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje33.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp33.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp34"))
            {
                String sifra = pp34.Tag.ToString();
                pStanje34.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje34.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp34.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp35"))
            {
                String sifra = pp35.Tag.ToString();
                pStanje35.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje35.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp5.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp36"))
            {
                String sifra = pp36.Tag.ToString();
                pStanje36.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje36.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp6.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp37"))
            {
                String sifra = pp37.Tag.ToString();
                pStanje37.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje37.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp37.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp38"))
            {
                String sifra = pp38.Tag.ToString();
                pStanje38.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje38.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp38.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp39"))
            {
                String sifra = pp39.Tag.ToString();
                pStanje39.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje39.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp39.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp310"))
            {
                String sifra = pp310.Tag.ToString();
                pStanje310.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje310.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp310.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp311"))
            {
                String sifra = pp311.Tag.ToString();
                pStanje311.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje311.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp311.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp312"))
            {
                String sifra = pp312.Tag.ToString();
                pStanje312.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje312.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp312.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp313"))
            {
                String sifra = pp313.Tag.ToString();
                pStanje313.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje313.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp313.Tag.ToString());
                z.Stanje = "odmor";
            }
//GR4......................
            if (lbp.Text.Equals("pp41"))
            {
                String sifra = pp41.Tag.ToString();
                pStanje41.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje41.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp41.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp42"))
            {
                String sifra = pp42.Tag.ToString();
                pStanje42.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje42.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp42.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp43"))
            {
                String sifra = pp43.Tag.ToString();
                pStanje43.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje43.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp43.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp44"))
            {
                String sifra = pp44.Tag.ToString();
                pStanje44.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje44.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp44.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp45"))
            {
                String sifra = pp45.Tag.ToString();
                pStanje45.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje45.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp45.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp46"))
            {
                String sifra = pp46.Tag.ToString();
                pStanje46.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje46.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp46.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp47"))
            {
                String sifra = pp47.Tag.ToString();
                pStanje47.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje47.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp47.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp48"))
            {
                String sifra = pp48.Tag.ToString();
                pStanje48.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje48.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp48.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp49"))
            {
                String sifra = pp49.Tag.ToString();
                pStanje49.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje49.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp49.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp410"))
            {
                String sifra = pp410.Tag.ToString();
                pStanje410.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje410.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp410.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp411"))
            {
                String sifra = pp411.Tag.ToString();
                pStanje411.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje411.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp411.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp412"))
            {
                String sifra = pp412.Tag.ToString();
                pStanje412.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje412.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp412.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp413"))
            {
                String sifra = pp413.Tag.ToString();
                pStanje413.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje413.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp413.Tag.ToString());
                z.Stanje = "odmor";
            }
//GR5......................
            if (lbp.Text.Equals("pp51"))
            {
                String sifra = pp51.Tag.ToString();
                pStanje51.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje51.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp51.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp52"))
            {
                String sifra = pp52.Tag.ToString();
                pStanje52.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje52.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp52.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp53"))
            {
                String sifra = pp53.Tag.ToString();
                pStanje53.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje53.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp53.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp54"))
            {
                String sifra = pp54.Tag.ToString();
                pStanje54.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje54.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp54.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp55"))
            {
                String sifra = pp55.Tag.ToString();
                pStanje55.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje55.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp55.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp56"))
            {
                String sifra = pp56.Tag.ToString();
                pStanje56.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje56.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp56.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp57"))
            {
                String sifra = pp57.Tag.ToString();
                pStanje57.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje57.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp57.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp58"))
            {
                String sifra = pp58.Tag.ToString();
                pStanje58.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje58.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp58.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp59"))
            {
                String sifra = pp59.Tag.ToString();
                pStanje59.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje59.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp59.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp510"))
            {
                String sifra = pp510.Tag.ToString();
                pStanje510.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje510.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp510.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp511"))
            {
                String sifra = pp511.Tag.ToString();
                pStanje511.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje511.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp511.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp512"))
            {
                String sifra = pp512.Tag.ToString();
                pStanje512.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje512.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp512.Tag.ToString());
                z.Stanje = "odmor";
            }

            if (lbp.Text.Equals("pp513"))
            {
                String sifra = pp513.Tag.ToString();
                pStanje513.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.odmor;
                pStanje513.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp513.Tag.ToString());
                z.Stanje = "odmor";
            }
        }

        private void poslatiNaTreningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbp.Text.Equals("pp1"))
            {
                String sifra = pp1.Tag.ToString();
                pStanje.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp1.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp2"))
            {
                String sifra = pp2.Tag.ToString();
                pStanje2.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje2.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp2.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp3"))
            {
                pStanje3.Visible = true;
                String sifra = pp3.Tag.ToString();
                pStanje3.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                
                Zaposleni z = sz.NadjiZap1(pp3.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp4"))
            {
                String sifra = pp4.Tag.ToString();
                pStanje4.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje4.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp4.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp5"))
            {
                String sifra = pp5.Tag.ToString();
                pStanje5.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje5.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp5.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp6"))
            {
                String sifra = pp6.Tag.ToString();
                pStanje6.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje6.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp6.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp7"))
            {
                String sifra = pp7.Tag.ToString();
                pStanje7.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje7.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp7.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp8"))
            {
                String sifra = pp8.Tag.ToString();
                pStanje8.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje8.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp8.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp9"))
            {
                String sifra = pp9.Tag.ToString();
                pStanje9.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje9.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp9.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp10"))
            {
                String sifra = pp10.Tag.ToString();
                pStanje10.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje10.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp10.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp11"))
            {
                String sifra = pp11.Tag.ToString();
                pStanje11.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje11.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp11.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp12"))
            {
                String sifra = pp12.Tag.ToString();
                pStanje12.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje12.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp12.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp13"))
            {
                String sifra = pp13.Tag.ToString();
                pStanje13.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje13.Visible = true;
                Zaposleni z = sz.NadjiZap1(pp13.Tag.ToString());
                z.Stanje = "trening";
            }
//GR2..................            
            if (lbp.Text.Equals("pp21"))
            {
                String sifra = pp21.Tag.ToString();
                pStanje21.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje21.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp21.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp22"))
            {
                String sifra = pp22.Tag.ToString();
                pStanje22.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje22.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp22.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp23"))
            {
                String sifra = pp23.Tag.ToString();
                pStanje23.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje23.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp23.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp24"))
            {
                String sifra = pp24.Tag.ToString();
                pStanje24.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje24.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp24.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp25"))
            {
                String sifra = pp25.Tag.ToString();
                pStanje25.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje25.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp25.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp26"))
            {
                String sifra = pp26.Tag.ToString();
                pStanje26.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje26.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp26.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp27"))
            {
                String sifra = pp27.Tag.ToString();
                pStanje27.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje27.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp27.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp28"))
            {
                String sifra = pp28.Tag.ToString();
                pStanje28.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje28.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp28.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp29"))
            {
                String sifra = pp29.Tag.ToString();
                pStanje29.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje29.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp29.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp210"))
            {
                String sifra = pp210.Tag.ToString();
                pStanje210.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje210.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp10.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp211"))
            {
                String sifra = pp211.Tag.ToString();
                pStanje211.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje211.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp211.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp212"))
            {
                String sifra = pp212.Tag.ToString();
                pStanje212.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje212.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp212.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp213"))
            {
                String sifra = pp213.Tag.ToString();
                pStanje213.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje213.Visible = true;
                Zaposleni z = sz.NadjiZap2(pp213.Tag.ToString());
                z.Stanje = "trening";
            }
//GR3....................
            if (lbp.Text.Equals("pp31"))
            {
                String sifra = pp31.Tag.ToString();
                pStanje31.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje31.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp31.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp32"))
            {
                String sifra = pp32.Tag.ToString();
                pStanje32.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje32.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp32.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp33"))
            {
                String sifra = pp33.Tag.ToString();
                pStanje33.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje33.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp33.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp34"))
            {
                String sifra = pp34.Tag.ToString();
                pStanje34.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje34.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp34.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp35"))
            {
                String sifra = pp35.Tag.ToString();
                pStanje35.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje35.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp35.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp36"))
            {
                String sifra = pp36.Tag.ToString();
                pStanje36.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje36.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp36.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp7"))
            {
                String sifra = pp37.Tag.ToString();
                pStanje37.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje37.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp37.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp38"))
            {
                String sifra = pp38.Tag.ToString();
                pStanje38.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje38.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp38.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp39"))
            {
                String sifra = pp39.Tag.ToString();
                pStanje39.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje39.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp39.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp310"))
            {
                String sifra = pp310.Tag.ToString();
                pStanje310.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje310.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp310.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp311"))
            {
                String sifra = pp311.Tag.ToString();
                pStanje311.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje311.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp311.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp312"))
            {
                String sifra = pp312.Tag.ToString();
                pStanje312.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje312.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp312.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp313"))
            {
                String sifra = pp313.Tag.ToString();
                pStanje313.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje313.Visible = true;
                Zaposleni z = sz.NadjiZap3(pp313.Tag.ToString());
                z.Stanje = "trening";
            }
//GR4.....................
           if (lbp.Text.Equals("pp41"))
            {
                String sifra = pp41.Tag.ToString();
                pStanje41.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje41.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp41.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp42"))
            {
                String sifra = pp42.Tag.ToString();
                pStanje42.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje42.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp42.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp43"))
            {
                String sifra = pp43.Tag.ToString();
                pStanje43.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje43.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp43.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp44"))
            {
                String sifra = pp44.Tag.ToString();
                pStanje44.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje44.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp44.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp45"))
            {
                String sifra = pp45.Tag.ToString();
                pStanje45.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje45.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp45.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp46"))
            {
                String sifra = pp46.Tag.ToString();
                pStanje46.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje46.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp46.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp47"))
            {
                String sifra = pp47.Tag.ToString();
                pStanje47.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje47.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp47.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp48"))
            {
                String sifra = pp48.Tag.ToString();
                pStanje48.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje48.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp48.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp49"))
            {
                String sifra = pp49.Tag.ToString();
                pStanje49.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje49.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp49.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp410"))
            {
                String sifra = pp410.Tag.ToString();
                pStanje410.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje410.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp410.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp411"))
            {
                String sifra = pp411.Tag.ToString();
                pStanje411.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje411.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp411.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp412"))
            {
                String sifra = pp412.Tag.ToString();
                pStanje412.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje412.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp412.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp413"))
            {
                String sifra = pp413.Tag.ToString();
                pStanje413.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje413.Visible = true;
                Zaposleni z = sz.NadjiZap4(pp13.Tag.ToString());
                z.Stanje = "trening";
            
             }
//GR5.....................
            if (lbp.Text.Equals("pp51"))
            {
                String sifra = pp51.Tag.ToString();
                pStanje51.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje51.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp51.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp52"))
            {
                String sifra = pp52.Tag.ToString();
                pStanje52.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje52.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp52.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp53"))
            {
                String sifra = pp53.Tag.ToString();
                pStanje53.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje53.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp53.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp54"))
            {
                String sifra = pp54.Tag.ToString();
                pStanje54.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje54.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp54.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp55"))
            {
                String sifra = pp55.Tag.ToString();
                pStanje55.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje55.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp55.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp56"))
            {
                String sifra = pp56.Tag.ToString();
                pStanje56.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje56.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp56.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp57"))
            {
                String sifra = pp57.Tag.ToString();
                pStanje57.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje57.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp57.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp58"))
            {
                String sifra = pp58.Tag.ToString();
                pStanje58.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje58.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp58.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp59"))
            {
                String sifra = pp59.Tag.ToString();
                pStanje59.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje9.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp59.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp510"))
            {
                String sifra = pp510.Tag.ToString();
                pStanje510.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje510.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp510.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp511"))
            {
                String sifra = pp511.Tag.ToString();
                pStanje511.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje511.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp511.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp512"))
            {
                String sifra = pp512.Tag.ToString();
                pStanje512.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje512.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp512.Tag.ToString());
                z.Stanje = "trening";
            }

            if (lbp.Text.Equals("pp513"))
            {
                String sifra = pp513.Tag.ToString();
                pStanje513.BackgroundImage = HCI2012PZ7E13080.Properties.Resources.trening1;
                pStanje513.Visible = true;
                Zaposleni z = sz.NadjiZap5(pp513.Tag.ToString());
                z.Stanje = "trening";
            }
        
        }

        private void oslboditiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbp.Text.Equals("pp1"))
            {
                String sifz = pp1.Tag.ToString();
                Zaposleni z = sz.NadjiZap1(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz,1);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje.Visible = false;
                    z.Stanje = "slobodan";
                   // Angazovanja.Instanca().DodajAng(ang);
                    lbsifk.Text = "";
                }
                this.Opacity = 100;

            }

            if (lbp.Text.Equals("pp2"))
            {
                String sifz = pp2.Tag.ToString();
                Zaposleni z = sz.NadjiZap1(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 1);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje2.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp3"))
            {
                String sifz = pp3.Tag.ToString();
                Zaposleni z = sz.NadjiZap1(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 1);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje3.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp4"))
            {
                String sifz = pp4.Tag.ToString();
                Zaposleni z = sz.NadjiZap1(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 1);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje4.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp5"))
            {
                String sifz = pp5.Tag.ToString();
                Zaposleni z = sz.NadjiZap1(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 1);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje5.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }
            if (lbp.Text.Equals("pp6"))
            {
                String sifz = pp6.Tag.ToString();
                Zaposleni z = sz.NadjiZap1(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 1);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje6.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp7"))
            {
                String sifz = pp7.Tag.ToString();
                Zaposleni z = sz.NadjiZap1(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 1);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje7.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp8"))
            {
                String sifz = pp8.Tag.ToString();
                Zaposleni z = sz.NadjiZap1(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 1);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje8.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp9"))
            {
                String sifz = pp9.Tag.ToString();
                Zaposleni z = sz.NadjiZap1(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 1);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje9.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp10"))
            {
                String sifz = pp10.Tag.ToString();
                Zaposleni z = sz.NadjiZap1(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 1);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje10.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp11"))
            {
                String sifz = pp11.Tag.ToString();
                Zaposleni z = sz.NadjiZap1(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 1);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje11.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp12"))
            {
                String sifz = pp12.Tag.ToString();
                Zaposleni z = sz.NadjiZap1(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 1);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje12.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp13"))
            {
                String sifz = pp13.Tag.ToString();
                Zaposleni z = sz.NadjiZap1(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 1);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje13.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }
//GR2..............
            if (lbp.Text.Equals("pp21"))
            {
                String sifz = pp21.Tag.ToString();
                Zaposleni z = sz.NadjiZap2(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 2);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje21.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;

            }

            if (lbp.Text.Equals("pp22"))
            {
                String sifz = pp22.Tag.ToString();
                Zaposleni z = sz.NadjiZap2(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 2);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje22.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp23"))
            {
                String sifz = pp23.Tag.ToString();
                Zaposleni z = sz.NadjiZap2(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 2);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje23.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp24"))
            {
                String sifz = pp24.Tag.ToString();
                Zaposleni z = sz.NadjiZap2(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 2);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje24.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp25"))
            {
                String sifz = pp25.Tag.ToString();
                Zaposleni z = sz.NadjiZap2(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 2);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje25.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }
            if (lbp.Text.Equals("pp26"))
            {
                String sifz = pp26.Tag.ToString();
                Zaposleni z = sz.NadjiZap2(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 2);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje26.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp27"))
            {
                String sifz = pp27.Tag.ToString();
                Zaposleni z = sz.NadjiZap2(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 2);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje27.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp28"))
            {
                String sifz = pp28.Tag.ToString();
                Zaposleni z = sz.NadjiZap2(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 2);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje28.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp29"))
            {
                String sifz = pp29.Tag.ToString();
                Zaposleni z = sz.NadjiZap2(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 2);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje29.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp210"))
            {
                String sifz = pp210.Tag.ToString();
                Zaposleni z = sz.NadjiZap2(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 2);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje210.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp211"))
            {
                String sifz = pp211.Tag.ToString();
                Zaposleni z = sz.NadjiZap2(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 2);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje211.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp212"))
            {
                String sifz = pp212.Tag.ToString();
                Zaposleni z = sz.NadjiZap2(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 2);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje212.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp213"))
            {
                String sifz = pp213.Tag.ToString();
                Zaposleni z = sz.NadjiZap2(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 2);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje213.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }   
//GR3..............
            if (lbp.Text.Equals("pp31"))
            {
                String sifz = pp31.Tag.ToString();
                Zaposleni z = sz.NadjiZap3(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 3);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje31.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;

            }

            if (lbp.Text.Equals("pp32"))
            {
                String sifz = pp32.Tag.ToString();
                Zaposleni z = sz.NadjiZap3(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 3);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje2.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp33"))
            {
                String sifz = pp33.Tag.ToString();
                Zaposleni z = sz.NadjiZap3(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 3);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje33.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp34"))
            {
                String sifz = pp34.Tag.ToString();
                Zaposleni z = sz.NadjiZap3(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 3);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje34.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp35"))
            {
                String sifz = pp35.Tag.ToString();
                Zaposleni z = sz.NadjiZap3(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 3);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje35.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }
            if (lbp.Text.Equals("pp36"))
            {
                String sifz = pp36.Tag.ToString();
                Zaposleni z = sz.NadjiZap3(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 3);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje36.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp37"))
            {
                String sifz = pp37.Tag.ToString();
                Zaposleni z = sz.NadjiZap3(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 3);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje37.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp38"))
            {
                String sifz = pp38.Tag.ToString();
                Zaposleni z = sz.NadjiZap3(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 3);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje38.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp39"))
            {
                String sifz = pp39.Tag.ToString();
                Zaposleni z = sz.NadjiZap3(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 3);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje39.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp310"))
            {
                String sifz = pp310.Tag.ToString();
                Zaposleni z = sz.NadjiZap3(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 3);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje310.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp311"))
            {
                String sifz = pp311.Tag.ToString();
                Zaposleni z = sz.NadjiZap3(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 3);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje311.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp312"))
            {
                String sifz = pp312.Tag.ToString();
                Zaposleni z = sz.NadjiZap3(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 3);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje312.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp313"))
            {
                String sifz = pp313.Tag.ToString();
                Zaposleni z = sz.NadjiZap3(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 3);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje313.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }
//GR4..............
            if (lbp.Text.Equals("pp41"))
            {
                String sifz = pp41.Tag.ToString();
                Zaposleni z = sz.NadjiZap4(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 4);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje41.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;

            }

            if (lbp.Text.Equals("pp42"))
            {
                String sifz = pp42.Tag.ToString();
                Zaposleni z = sz.NadjiZap4(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 4);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje42.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp43"))
            {
                String sifz = pp43.Tag.ToString();
                Zaposleni z = sz.NadjiZap4(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 4);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje43.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp44"))
            {
                String sifz = pp44.Tag.ToString();
                Zaposleni z = sz.NadjiZap4(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 4);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje44.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp45"))
            {
                String sifz = pp45.Tag.ToString();
                Zaposleni z = sz.NadjiZap4(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 4);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje45.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }
            if (lbp.Text.Equals("pp46"))
            {
                String sifz = pp46.Tag.ToString();
                Zaposleni z = sz.NadjiZap4(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 4);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje46.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp47"))
            {
                String sifz = pp47.Tag.ToString();
                Zaposleni z = sz.NadjiZap4(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 4);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje47.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp48"))
            {
                String sifz = pp48.Tag.ToString();
                Zaposleni z = sz.NadjiZap4(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 4);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje48.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp49"))
            {
                String sifz = pp49.Tag.ToString();
                Zaposleni z = sz.NadjiZap4(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 4);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje49.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp410"))
            {
                String sifz = pp410.Tag.ToString();
                Zaposleni z = sz.NadjiZap4(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 4);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje410.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp411"))
            {
                String sifz = pp411.Tag.ToString();
                Zaposleni z = sz.NadjiZap4(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 4);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje411.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp412"))
            {
                String sifz = pp412.Tag.ToString();
                Zaposleni z = sz.NadjiZap4(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 4);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje412.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp413"))
            {
                String sifz = pp413.Tag.ToString();
                Zaposleni z = sz.NadjiZap4(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 4);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje413.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }
//GR5..............
            if (lbp.Text.Equals("pp51"))
            {
                String sifz = pp51.Tag.ToString();
                Zaposleni z = sz.NadjiZap5(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 5);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje51.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;

            }

            if (lbp.Text.Equals("pp52"))
            {
                String sifz = pp52.Tag.ToString();
                Zaposleni z = sz.NadjiZap5(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 5);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje52.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp53"))
            {
                String sifz = pp53.Tag.ToString();
                Zaposleni z = sz.NadjiZap5(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 5);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje53.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp54"))
            {
                String sifz = pp54.Tag.ToString();
                Zaposleni z = sz.NadjiZap5(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 5);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje54.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp55"))
            {
                String sifz = pp55.Tag.ToString();
                Zaposleni z = sz.NadjiZap5(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 5);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje55.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }
            if (lbp.Text.Equals("pp56"))
            {
                String sifz = pp56.Tag.ToString();
                Zaposleni z = sz.NadjiZap5(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 5);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje56.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp57"))
            {
                String sifz = pp57.Tag.ToString();
                Zaposleni z = sz.NadjiZap5(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 5);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje57.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp58"))
            {
                String sifz = pp58.Tag.ToString();
                Zaposleni z = sz.NadjiZap5(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 5);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje58.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp59"))
            {
                String sifz = pp59.Tag.ToString();
                Zaposleni z = sz.NadjiZap5(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 5);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje59.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp510"))
            {
                String sifz = pp510.Tag.ToString();
                Zaposleni z = sz.NadjiZap5(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 5);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje510.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp511"))
            {
                String sifz = pp511.Tag.ToString();
                Zaposleni z = sz.NadjiZap5(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 5);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje511.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp512"))
            {
                String sifz = pp512.Tag.ToString();
                Zaposleni z = sz.NadjiZap5(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 5);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje512.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }

            if (lbp.Text.Equals("pp513"))
            {
                String sifz = pp513.Tag.ToString();
                Zaposleni z = sz.NadjiZap5(sifz);

                this.Opacity = .75;
                OslobZap oslobodi = new OslobZap(lbsifk.Text, sifz, 5);

                DialogResult dr = oslobodi.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pStanje513.Visible = false;
                    z.Stanje = "slobodan";
                    lbsifk.Text = "";
                }
                this.Opacity = 100;
            }
        }

        private void vratitiSaOdmoratreningaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbp.Text.Equals("pp1"))
            {
                String sifra = pp1.Tag.ToString();
                pStanje.Visible = false;
                Zaposleni z = sz.NadjiZap1(pp1.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp2"))
            {
                String sifra = pp2.Tag.ToString();
                pStanje2.Visible = false;
                Zaposleni z = sz.NadjiZap1(pp2.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp3"))
            {
                String sifra = pp3.Tag.ToString();
                pStanje3.Visible = false;
                Zaposleni z = sz.NadjiZap1(pp3.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp4"))
            {
                String sifra = pp4.Tag.ToString();
                pStanje4.Visible = false;
                Zaposleni z = sz.NadjiZap1(pp4.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp5"))
            {
                String sifra = pp5.Tag.ToString();
                pStanje5.Visible = false;
                Zaposleni z = sz.NadjiZap1(pp5.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp6"))
            {
                String sifra = pp6.Tag.ToString();
                pStanje6.Visible = false;
                Zaposleni z = sz.NadjiZap1(pp6.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp7"))
            {
                String sifra = pp7.Tag.ToString();
                pStanje7.Visible = false;
                Zaposleni z = sz.NadjiZap1(pp7.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp8"))
            {
                String sifra = pp8.Tag.ToString();
                pStanje8.Visible = false;
                Zaposleni z = sz.NadjiZap1(pp8.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp9"))
            {
                String sifra = pp9.Tag.ToString();
                pStanje9.Visible = false;
                Zaposleni z = sz.NadjiZap1(pp9.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp10"))
            {
                String sifra = pp10.Tag.ToString();
                pStanje10.Visible = false;
                Zaposleni z = sz.NadjiZap1(pp10.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp11"))
            {
                String sifra = pp11.Tag.ToString();
                pStanje11.Visible = false;
                Zaposleni z = sz.NadjiZap1(pp11.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp12"))
            {
                String sifra = pp12.Tag.ToString();
                pStanje12.Visible = false;
                Zaposleni z = sz.NadjiZap1(pp12.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp13"))
            {
                String sifra = pp13.Tag.ToString();
                pStanje13.Visible = false;
                Zaposleni z = sz.NadjiZap1(pp13.Tag.ToString());
                z.Stanje = "slobodan";
            }

// GR2................................................................
            if (lbp.Text.Equals("pp21"))
            {
                String sifra = pp21.Tag.ToString();
                pStanje21.Visible = false;
                Zaposleni z = sz.NadjiZap2(pp21.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp22"))
            {
                String sifra = pp22.Tag.ToString();
                pStanje22.Visible = false;
                Zaposleni z = sz.NadjiZap2(pp22.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp23"))
            {
                String sifra = pp23.Tag.ToString();
                pStanje23.Visible = false;
                Zaposleni z = sz.NadjiZap2(pp23.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp24"))
            {
                String sifra = pp24.Tag.ToString();
                pStanje24.Visible = false;
                Zaposleni z = sz.NadjiZap2(pp24.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp25"))
            {
                String sifra = pp25.Tag.ToString();
                pStanje25.Visible = false;
                Zaposleni z = sz.NadjiZap2(pp25.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp26"))
            {
                String sifra = pp26.Tag.ToString();
                pStanje26.Visible = false;
                Zaposleni z = sz.NadjiZap2(pp26.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp27"))
            {
                String sifra = pp27.Tag.ToString();
                pStanje27.Visible = false;
                Zaposleni z = sz.NadjiZap2(pp27.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp28"))
            {
                String sifra = pp28.Tag.ToString();
                pStanje28.Visible = false;
                Zaposleni z = sz.NadjiZap2(pp28.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp29"))
            {
                String sifra = pp29.Tag.ToString();
                pStanje29.Visible = false;
                Zaposleni z = sz.NadjiZap2(pp29.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp210"))
            {
                String sifra = pp210.Tag.ToString();
                pStanje210.Visible = false;
                Zaposleni z = sz.NadjiZap2(pp210.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp211"))
            {
                String sifra = pp211.Tag.ToString();
                pStanje211.Visible = false;
                Zaposleni z = sz.NadjiZap2(pp11.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp212"))
            {
                String sifra = pp212.Tag.ToString();
                pStanje212.Visible = false;
                Zaposleni z = sz.NadjiZap2(pp212.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp213"))
            {
                String sifra = pp213.Tag.ToString();
                pStanje213.Visible = false;
                Zaposleni z = sz.NadjiZap2(pp213.Tag.ToString());
                z.Stanje = "slobodan";
            }
//GR3...................
            if (lbp.Text.Equals("pp31"))
            {
                String sifra = pp31.Tag.ToString();
                pStanje31.Visible = false;
                Zaposleni z = sz.NadjiZap3(pp31.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp32"))
            {
                String sifra = pp32.Tag.ToString();
                pStanje32.Visible = false;
                Zaposleni z = sz.NadjiZap3(pp32.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp33"))
            {
                String sifra = pp33.Tag.ToString();
                pStanje33.Visible = false;
                Zaposleni z = sz.NadjiZap3(pp33.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp34"))
            {
                String sifra = pp34.Tag.ToString();
                pStanje34.Visible = false;
                Zaposleni z = sz.NadjiZap3(pp34.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp35"))
            {
                String sifra = pp35.Tag.ToString();
                pStanje35.Visible = false;
                Zaposleni z = sz.NadjiZap3(pp35.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp36"))
            {
                String sifra = pp36.Tag.ToString();
                pStanje36.Visible = false;
                Zaposleni z = sz.NadjiZap3(pp36.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp37"))
            {
                String sifra = pp37.Tag.ToString();
                pStanje37.Visible = false;
                Zaposleni z = sz.NadjiZap3(pp37.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp38"))
            {
                String sifra = pp38.Tag.ToString();
                pStanje38.Visible = false;
                Zaposleni z = sz.NadjiZap3(pp38.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp39"))
            {
                String sifra = pp39.Tag.ToString();
                pStanje39.Visible = false;
                Zaposleni z = sz.NadjiZap3(pp39.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp310"))
            {
                String sifra = pp310.Tag.ToString();
                pStanje310.Visible = false;
                Zaposleni z = sz.NadjiZap3(pp310.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp311"))
            {
                String sifra = pp311.Tag.ToString();
                pStanje311.Visible = false;
                Zaposleni z = sz.NadjiZap3(pp311.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp312"))
            {
                String sifra = pp312.Tag.ToString();
                pStanje312.Visible = false;
                Zaposleni z = sz.NadjiZap3(pp312.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp313"))
            {
                String sifra = pp313.Tag.ToString();
                pStanje313.Visible = false;
                Zaposleni z = sz.NadjiZap3(pp313.Tag.ToString());
                z.Stanje = "slobodan";
            }
//GR4...................
            if (lbp.Text.Equals("pp41"))
            {
                String sifra = pp41.Tag.ToString();
                pStanje41.Visible = false;
                Zaposleni z = sz.NadjiZap4(pp41.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp42"))
            {
                String sifra = pp42.Tag.ToString();
                pStanje42.Visible = false;
                Zaposleni z = sz.NadjiZap4(pp42.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp43"))
            {
                String sifra = pp43.Tag.ToString();
                pStanje43.Visible = false;
                Zaposleni z = sz.NadjiZap4(pp43.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp44"))
            {
                String sifra = pp44.Tag.ToString();
                pStanje44.Visible = false;
                Zaposleni z = sz.NadjiZap4(pp44.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp45"))
            {
                String sifra = pp45.Tag.ToString();
                pStanje45.Visible = false;
                Zaposleni z = sz.NadjiZap4(pp45.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp46"))
            {
                String sifra = pp46.Tag.ToString();
                pStanje46.Visible = false;
                Zaposleni z = sz.NadjiZap4(pp46.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp47"))
            {
                String sifra = pp47.Tag.ToString();
                pStanje47.Visible = false;
                Zaposleni z = sz.NadjiZap4(pp47.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp48"))
            {
                String sifra = pp48.Tag.ToString();
                pStanje48.Visible = false;
                Zaposleni z = sz.NadjiZap4(pp48.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp49"))
            {
                String sifra = pp49.Tag.ToString();
                pStanje49.Visible = false;
                Zaposleni z = sz.NadjiZap4(pp49.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp410"))
            {
                String sifra = pp410.Tag.ToString();
                pStanje410.Visible = false;
                Zaposleni z = sz.NadjiZap4(pp410.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp411"))
            {
                String sifra = pp411.Tag.ToString();
                pStanje411.Visible = false;
                Zaposleni z = sz.NadjiZap4(pp411.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp412"))
            {
                String sifra = pp412.Tag.ToString();
                pStanje412.Visible = false;
                Zaposleni z = sz.NadjiZap4(pp412.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp413"))
            {
                String sifra = pp413.Tag.ToString();
                pStanje413.Visible = false;
                Zaposleni z = sz.NadjiZap4(pp413.Tag.ToString());
                z.Stanje = "slobodan";
            }
//GR5...................
            if (lbp.Text.Equals("pp51"))
            {
                String sifra = pp51.Tag.ToString();
                pStanje51.Visible = false;
                Zaposleni z = sz.NadjiZap5(pp51.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp52"))
            {
                String sifra = pp52.Tag.ToString();
                pStanje52.Visible = false;
                Zaposleni z = sz.NadjiZap5(pp52.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp53"))
            {
                String sifra = pp53.Tag.ToString();
                pStanje53.Visible = false;
                Zaposleni z = sz.NadjiZap5(pp53.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp54"))
            {
                String sifra = pp54.Tag.ToString();
                pStanje54.Visible = false;
                Zaposleni z = sz.NadjiZap5(pp54.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp55"))
            {
                String sifra = pp55.Tag.ToString();
                pStanje55.Visible = false;
                Zaposleni z = sz.NadjiZap5(pp55.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp56"))
            {
                String sifra = pp56.Tag.ToString();
                pStanje56.Visible = false;
                Zaposleni z = sz.NadjiZap5(pp56.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp57"))
            {
                String sifra = pp57.Tag.ToString();
                pStanje57.Visible = false;
                Zaposleni z = sz.NadjiZap5(pp57.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp58"))
            {
                String sifra = pp58.Tag.ToString();
                pStanje58.Visible = false;
                Zaposleni z = sz.NadjiZap5(pp58.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp59"))
            {
                String sifra = pp59.Tag.ToString();
                pStanje59.Visible = false;
                Zaposleni z = sz.NadjiZap5(pp59.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp510"))
            {
                String sifra = pp510.Tag.ToString();
                pStanje510.Visible = false;
                Zaposleni z = sz.NadjiZap5(pp510.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp511"))
            {
                String sifra = pp511.Tag.ToString();
                pStanje511.Visible = false;
                Zaposleni z = sz.NadjiZap5(pp511.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp512"))
            {
                String sifra = pp512.Tag.ToString();
                pStanje512.Visible = false;
                Zaposleni z = sz.NadjiZap5(pp512.Tag.ToString());
                z.Stanje = "slobodan";
            }

            if (lbp.Text.Equals("pp513"))
            {
                String sifra = pp513.Tag.ToString();
                pStanje513.Visible = false;
                Zaposleni z = sz.NadjiZap5(pp513.Tag.ToString());
                z.Stanje = "slobodan";
            }
        }

#endregion

        private void tbGr_Click(object sender, EventArgs e)
        {

        }

        private void tbGr5_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tbGr2_Click(object sender, EventArgs e)
        {
         
        }

        private void pp9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbSt1_Click(object sender, EventArgs e)
        {

        }

      

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "..\\..\\Slike\\HelpHCI.chm");
        }


    }
}