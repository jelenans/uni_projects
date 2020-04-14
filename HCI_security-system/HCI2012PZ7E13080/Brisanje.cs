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
    public partial class Brisanje : Form
    {
        public Brisanje(String id)
        {
            InitializeComponent();
            lbpitanje.Text = "Da li želite da klijenta sa ID brojem " + id + " uklonite sa spiska klijenata?";
        }
       
        private void pitanje_Click(object sender, EventArgs e)
        {

        }

  

        private void Brisanje_Load(object sender, EventArgs e)
        {

        }

        private void btDa_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btNe_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
