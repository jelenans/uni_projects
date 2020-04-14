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
    public partial class DodavanjeKlijenta : Form
    {
        
        private spisakKlijenti sk = spisakKlijenti.Instanca();

        public DodavanjeKlijenta()
        {
            InitializeComponent();

            ToolTip tt = new ToolTip();

            tt.ShowAlways = true;

            tt.InitialDelay = 100;
            tt.ReshowDelay = 200;

            tt.SetToolTip(tbIme, "Uneti ime klijenta(samo cifre i slova)");
            tt.SetToolTip(tbPrzk, "Uneti prezime klijenta(samo slova)");
            tt.SetToolTip(tbSifrak, "Uneti sifru klijenta(samo cifre)");
            tt.SetToolTip(mtbJmbg, "Uneti jmbg klijenta(13 cifara)");
            tt.SetToolTip(dtpDate, "Uneti datum sklapanja ugovora");
            tt.SetToolTip(tbDelat, "Uneti delatnost klijenta");
            tt.SetToolTip(cbKat, "Izabrati kategoriju zaposlenog na koju se klijent pretplaćuje");

           

            this.dtpDate.MaxDate = DateTime.Now;
            cbKat.Text = "A";
            rbM.Checked = true;
           // btnSac.Enabled = false;
        }

        private void DodavanjeKlijenta_Load(object sender, EventArgs e)
        {
         popunjenaPolja();
        }

        private void btnSac_Click(object sender, EventArgs e)
        {
           
            String pol;

            if (rbM.Checked)
                pol = "M";
            else
                pol = "Ž";

            Klijent k = new Klijent(tbSifrak.Text,tbIme.Text, tbPrzk.Text, mtbJmbg.Text, pol, dtpDate.Value,
                tbDelat.Text, cbKat.Text);

            if (sk.NadjiKlijenta(tbSifrak.Text)==null)
              sk.DodajKlijenta(k);
            this.DialogResult = DialogResult.OK;
        }

        private void btnPon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

       

#region provere

        private ErrorProvider err = new ErrorProvider();
        private Color colErr = Color.Salmon;
        private Color colOk = Color.White;

        public bool popunjenaPolja()
        {
            if ((tbIme.Text.Length != 0) && (tbPrzk.Text.Length != 0) && (tbSifrak.Text.Length != 0) && (mtbJmbg.Text.Length == 13) && (tbDelat.Text.Length != 0))
            {
                btnSac.Enabled = true;
                return true;
            }
            else
            {
                btnSac.Enabled = false;
                return false;
            }
        }
#region ime
        private void tbIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void tbIme_TextChanged(object sender, EventArgs e)
        {
            if (tbIme.Text.Length != 0)
            {
                tbIme.BackColor = colOk;
                err.Clear();
                popunjenaPolja();
            }
        }

        private void tbIme_Leave(object sender, EventArgs e)
        {
            if (tbIme.Text.Trim().Length == 0)
            {
                tbIme.BackColor = colErr;
                err.SetError(tbIme, "Morate uneti ime klijenta");
                err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                btnSac.Enabled = false;
            }
        }
#endregion

#region prz

        private void tbPrzk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void tbPrzk_TextChanged(object sender, EventArgs e)
        {
            if (tbPrzk.Text.Length != 0)
            {
                tbPrzk.BackColor = colOk;
                err.Clear();
                popunjenaPolja();
            }
        }

        private void tbPrzk_Leave(object sender, EventArgs e)
        {
            if (tbPrzk.Text.Trim().Length == 0)
            {
                tbPrzk.BackColor = colErr;
                err.SetError(tbPrzk, "Morate uneti prezime klijenta");
                err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                btnSac.Enabled = false;
            }
        }
#endregion

#region sifra

        private void tbSifrak_TextChanged(object sender, EventArgs e)
        {
            if (tbSifrak.Text.Length != 0)
            {
                tbSifrak.BackColor = colOk;
                err.Clear();
                popunjenaPolja();
            }
        }

        private void tbSifrak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void tbSifrak_Leave(object sender, EventArgs e)
        {
            if (tbSifrak.Text.Trim().Length == 0)
            {
                tbSifrak.BackColor = colErr;
                err.SetError(tbSifrak, "Morate uneti sifru klijenta(samo cifre)");
                err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                btnSac.Enabled = false;
            }
            
           
        }
           
#endregion

#region jmbg

        private void mtbJmbg_Leave(object sender, EventArgs e)
        {
            if (mtbJmbg.Text.Trim().Length < 13)
            {
                mtbJmbg.BackColor = colErr;
                err.SetError(mtbJmbg, "jmbg mora imati 13 cifara");
                err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                btnSac.Enabled = false;
            }
        }

        private void mtbJmbg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.KeyChar = (char)0;
        }

        private void mtbJmbg_TextChanged(object sender, EventArgs e)
        {
            if (mtbJmbg.Text.Length == 13)
            {
                mtbJmbg.BackColor = colOk;
                err.Clear();
                popunjenaPolja();
            }
        }

#endregion

#region delatnost
        private void tbDelat_TextChanged(object sender, EventArgs e)
        {
            if (tbDelat.Text.Length != 0)
            {
                tbDelat.BackColor = colOk;
                err.Clear();
                popunjenaPolja();
            }
        }


        private void tbDelat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void tbDelat_Leave(object sender, EventArgs e)
        {
            if (tbDelat.Text.Trim().Length == 0)
            {
                tbDelat.BackColor = colErr;
                err.SetError(tbDelat, "Morate uneti delatnost klijenta");
                err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                btnSac.Enabled = false;
            }
        }

#endregion
        
#endregion

    }

}