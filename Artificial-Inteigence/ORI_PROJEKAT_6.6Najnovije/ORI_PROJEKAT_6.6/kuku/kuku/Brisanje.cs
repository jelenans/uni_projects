using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kuku
{
    public partial class Brisanje : Form
    {
        public Brisanje()
        {
            InitializeComponent();
        }

        public Brisanje(String tekst)
        {
            InitializeComponent();
            lbBrisanje.Text = tekst;
        }

        private void Brisanje_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
