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
    public partial class Filter : Form
    {
        public static String vrednost;
        public static String kriterijum;
        public Filter()
        {
            InitializeComponent();
        }

        private void Filter_Load(object sender, EventArgs e)
        {
            //cbKrit.Text = "ime i prezime zaposlenog";
        }
    
        private void btnOdustati_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
                vrednost = tbVred.Text;
               // kriterijum = cbKrit.Text;
   
            this.DialogResult = DialogResult.OK;

        }

   


    }
}
