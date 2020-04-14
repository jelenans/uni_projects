using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HCI2012PZ7E13080
{
    public partial class DodavanjeZaposlenog : Form
    {

        private spisakZaposleni sz = spisakZaposleni.Instanca();
        public static Zaposleni z;
        int grupa;


        public DodavanjeZaposlenog(int brGrupe)
        {
            InitializeComponent();

            grupa = brGrupe;
            ToolTip tt = new ToolTip();
           
            tt.ShowAlways = true;

            tt.InitialDelay = 100;
            tt.ReshowDelay = 200;

            tt.SetToolTip(tbIme, "Uneti ime zaposlenog(samo cifre i slova)");
            tt.SetToolTip(tbPrez, "Uneti prezime zaposlenog(samo slova)");
            tt.SetToolTip(tbSif, "Uneti sifru zaposlenog(samo cifre)");
            tt.SetToolTip(mtbJmb, "Uneti jmbg zaposlenog(13 cifara)");
            tt.SetToolTip(dtpZap, "Uneti datum zaposlenja");
            tt.SetToolTip(cbKat, "Izabrati kategoriju zaposlenog");
            tt.SetToolTip(dtpIzdav, "Uneti datum izdavanja dozvole nošenja oružja");
            tt.SetToolTip(rtbKom,"Uneti komentar o zaposlenom");
            tt.SetToolTip(pbSlika, "Izabrati sliku zaposlenog");

            pbSlika.Image = HCI2012PZ7E13080.Properties.Resources.security_guard_icon;
            this.dtpZap.MaxDate = DateTime.Now;
            this.dtpIzdav.MaxDate = DateTime.Now;
            cbKat.Text = "A";
            chbIma.Checked = false;
        }

        private void DodavanjeZaposlenog_Load(object sender, EventArgs e)
        {
            popunjenaPolja();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter= "JPEG Image(*.jpg)|*.jpg";
            file.InitialDirectory = "";
            if (file.ShowDialog() == DialogResult.OK)
            {
                string ime = file.FileName;
                if (Path.GetExtension(ime) == ".jpg")
                {
                    pbSlika.Image = new Bitmap(new Bitmap(ime), pbSlika.Width, pbSlika.Height);
                }

            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();

            String doz="";
            if(chbIma.Checked)
                doz="ima";
            else
                doz="nema";

            String stanje = "slobodan";

            z = new Zaposleni(tbSif.Text,tbIme.Text, tbPrez.Text, mtbJmb.Text,
                         dtpZap.Value, dtpIzdav.Value, cbKat.Text, doz, rtbKom.Text,pbSlika.Image,panel,stanje);

            if (grupa == 1)
            {
                if (sz.NadjiZap1(tbSif.Text) == null)
                {
                    sz.DodajZap1(z);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
            if (grupa == 2)
            {
                if (sz.NadjiZap2(tbSif.Text) == null)
                {
                    sz.DodajZap2(z);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
            if (grupa == 3)
            {
                if (sz.NadjiZap3(tbSif.Text) == null)
                {
                    sz.DodajZap3(z);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
            if (grupa == 4)
            {
                if (sz.NadjiZap4(tbSif.Text) == null)
                {
                    sz.DodajZap4(z);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
            if (grupa == 5)
            {
                if (sz.NadjiZap5(tbSif.Text) == null)
                {
                    sz.DodajZap5(z);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }

            
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

       

#region provere
        private ErrorProvider err = new ErrorProvider();
        private Color colErr = Color.Salmon;
        private Color colOk = Color.White;

        public bool popunjenaPolja()
        {
            if ((tbIme.Text.Length != 0) && (tbPrez.Text.Length != 0) 
                && (tbSif.Text.Length != 0) && (mtbJmb.Text.Length == 13))
            {
                btnSacuvaj.Enabled = true;
                return true;
            }
            else
            {
                btnSacuvaj.Enabled = false;
                return false;
            }
        }
#region ime
        private void tbIme_TextChanged(object sender, EventArgs e)
        {
            if (tbIme.Text.Length != 0)
            {
                tbIme.BackColor = colOk;
                err.Clear();
                popunjenaPolja();
            }
        }

        private void tbIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void tbIme_Leave(object sender, EventArgs e)
        {
            if (tbIme.Text.Trim().Length == 0)
            {
                tbIme.BackColor = colErr;
                err.SetError(tbIme, "Morate uneti ime klijenta");
                err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                btnSacuvaj.Enabled = false;
            }
        }
#endregion

#region prz
        private void tbPrez_TextChanged(object sender, EventArgs e)
        {
            if (tbPrez.Text.Length != 0)
            {
                tbPrez.BackColor = colOk;
                err.Clear();
                popunjenaPolja();
            }
        }

        private void tbPrez_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void tbPrez_Leave(object sender, EventArgs e)
        {
            if (tbPrez.Text.Trim().Length == 0)
            {
                tbPrez.BackColor = colErr;
                err.SetError(tbPrez, "Morate uneti prezime klijenta");
                err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                btnSacuvaj.Enabled = false;
            }
        }

#endregion

#region sifra
        private void tbSif_Leave(object sender, EventArgs e)
        {
            if (tbSif.Text.Trim().Length == 0)
            {
                tbSif.BackColor = colErr;
                err.SetError(tbSif, "Morate uneti sifru klijenta(samo cifre)");
                err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                btnSacuvaj.Enabled = false;
            }
         
        }

        private void tbSif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void tbSif_TextChanged(object sender, EventArgs e)
        {
            if (tbSif.Text.Length != 0)
            {
                tbSif.BackColor = colOk;
                err.Clear();
                popunjenaPolja();
            }
        }

#endregion

#region jmbg
        private void mtbJmb_TextChanged(object sender, EventArgs e)
        {
            if (mtbJmb.Text.Length == 13)
            {
                mtbJmb.BackColor = colOk;
                err.Clear();
                popunjenaPolja();
            }
        }

        private void mtbJmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.KeyChar = (char)0;
        }

        private void mtbJmb_Leave(object sender, EventArgs e)
        {
            if (mtbJmb.Text.Trim().Length < 13)
            {
                mtbJmb.BackColor = colErr;
                err.SetError(mtbJmb, "jmbg mora imati 13 cifara");
                err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                btnSacuvaj.Enabled = false;
            }
        }
#endregion

#region komentar
        private void rtbKom_TextChanged(object sender, EventArgs e)
        {
            if (rtbKom.Text.Length != 0)
            {
                rtbKom.BackColor = colOk;
                err.Clear();
                popunjenaPolja();
            }
        }

        private void rtbKom_Leave(object sender, EventArgs e)
        {
            if (rtbKom.Text.Trim().Length == 0)
            {
                rtbKom.BackColor = colErr;
                err.SetError(rtbKom, "Morate uneti delatnost klijenta");
                err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                rtbKom.Enabled = false;
            }
        }

    
#endregion


#endregion

    }
}
