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
    public partial class BrisZap : Form
    {
        public BrisZap(String id)
        {
            InitializeComponent();
            lbpit1.Text = "Da li želite da zaposlenog sa ID brojem " + id + " uklonite iz grupe?";
        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void BrisZap_Load(object sender, EventArgs e)
        {

        }
    }
}
