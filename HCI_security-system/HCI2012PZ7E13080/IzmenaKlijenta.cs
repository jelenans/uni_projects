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
    public partial class IzmenaKlijenta : Form
    {
        String preId;
        Klijent k;

        public IzmenaKlijenta(String id)
        {
            InitializeComponent();
            preId = id;
            k= spisakKlijenti.Instanca().NadjiKlijenta(id);
            tbIme.Text = k.Ime;
            tbPrz.Text = k.Prezime;
            tbSifra.Text = k.Sifra;
            mtbJMBG.Text = k.Jmbg;
            dtpDat.Value = k.DatUgovora;
            if (k.Pol.Equals("M"))
                rbM.Checked = true;
            else
                rbZ.Checked = true;

            cbKat.Text = k.Kategorija;
            tbDel.Text= k.Delatnost;

            ToolTip tt = new ToolTip();

            tt.ShowAlways = true;

            tt.InitialDelay = 100;
            tt.ReshowDelay = 200;

            tt.SetToolTip(tbIme, "Uneti ime klijenta(samo cifre i slova)");
            tt.SetToolTip(tbPrz, "Uneti prezime klijenta(samo slova)");
            tt.SetToolTip(tbSifra, "Uneti sifru klijenta(samo cifre)");
            tt.SetToolTip(mtbJMBG, "Uneti jmbg klijenta(13 cifara)");
            tt.SetToolTip(dtpDat, "Uneti datum sklapanja ugovora");
            tt.SetToolTip(tbDel, "Uneti delatnost klijenta");
            tt.SetToolTip(cbKat, "Izabrati kategoriju zaposlenog na koju se klijent pretplaćuje");


        }

        private void IzmenaKlijenta_Load(object sender, EventArgs e)
        {

        }

     

        #region provere

        private ErrorProvider err = new ErrorProvider();
        private Color colErr = Color.Salmon;
        private Color colOk = Color.White;

        public bool popunjenaPolja()
        {
            if ((tbIme.Text.Length != 0) && (tbPrz.Text.Length != 0) && (tbSifra.Text.Length != 0) && (mtbJMBG.Text.Length == 13) && (tbDel.Text.Length != 0))
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

        private void tbIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
        #endregion

        #region prz
        private void tbPrz_TextChanged(object sender, EventArgs e)
        {
            if (tbPrz.Text.Length != 0)
            {
                tbPrz.BackColor = colOk;
                err.Clear();
                popunjenaPolja();
            }
        }

        private void tbPrz_Leave(object sender, EventArgs e)
        {
            if (tbPrz.Text.Trim().Length == 0)
            {
                tbPrz.BackColor = colErr;
                err.SetError(tbPrz, "Morate uneti prezime klijenta");
                err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                btnSac.Enabled = false;
            }
        }

        private void tbPrz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
        #endregion

        #region delatnost
        private void tbDel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void tbDel_TextChanged(object sender, EventArgs e)
        {
            if (tbDel.Text.Length != 0)
            {
                tbDel.BackColor = colOk;
                err.Clear();
                popunjenaPolja();
            }
        }

        private void tbDel_Leave(object sender, EventArgs e)
        {
            if (tbDel.Text.Trim().Length == 0)
            {
                tbDel.BackColor = colErr;
                err.SetError(tbDel, "Morate uneti delatnost klijenta");
                err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                btnSac.Enabled = false;
            }
        }
        #endregion
        #region jmbg
        private void mtbJMBG_Leave(object sender, EventArgs e)
        {
            if (mtbJMBG.Text.Trim().Length < 13)
            {
                mtbJMBG.BackColor = colErr;
                err.SetError(mtbJMBG, "jmbg mora imati 13 cifara");
                err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                btnSac.Enabled = false;
            }
        }

        private void mtbJMBG_TextChanged(object sender, EventArgs e)
        {
            if (mtbJMBG.Text.Length == 13)
            {
                mtbJMBG.BackColor = colOk;
                err.Clear();
                popunjenaPolja();
            }
        }


        private void mtbJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.KeyChar = (char)0;
        }
        #endregion
        #endregion

        private void btnPon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSac_Click(object sender, EventArgs e)
        {
             String pol;

            if (rbM.Checked)
                pol = "M";
            else
                pol = "Ž";

            k.Ime = tbIme.Text;
            k.Prezime = tbPrz.Text;
            k.Pol = pol;
            k.Kategorija = cbKat.Text;
            k.DatUgovora = dtpDat.Value;
            k.Jmbg = mtbJMBG.Text;
            k.Delatnost = tbDel.Text;

            this.DialogResult = DialogResult.OK;
        }

        private void btnPon_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
     
    }
    }

