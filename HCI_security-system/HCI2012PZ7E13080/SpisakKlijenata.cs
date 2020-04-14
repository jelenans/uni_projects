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
    public partial class SpisakKlijenata : Form
    {
        public SpisakKlijenata()
        {
            InitializeComponent();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void SpisakKlijenata_Load(object sender, EventArgs e)
        {
            popuniGrid();
            dgvSpisakZap.ClearSelection();
   
           // disableButtons();
        }

        public void popuniGrid() 
        {
            dgvSpisakZap.Rows.Clear();
            int n = spisakKlijenti.Instanca().BrojKlijenata();
            for (int i = 0; i < n; i++)
            {
                String[] podaci = {spisakKlijenti.Instanca().NadjiKlijenta(i).Ime,
                                  spisakKlijenti.Instanca().NadjiKlijenta(i).Prezime, 
                                  spisakKlijenti.Instanca().NadjiKlijenta(i).Sifra,
                                  spisakKlijenti.Instanca().NadjiKlijenta(i).Jmbg,
                                  spisakKlijenti.Instanca().NadjiKlijenta(i).DatUgovora.ToShortDateString(),
                                  spisakKlijenti.Instanca().NadjiKlijenta(i).Delatnost,
                                  spisakKlijenti.Instanca().NadjiKlijenta(i).Pol,
                                  spisakKlijenti.Instanca().NadjiKlijenta(i).Kategorija,
                                 };
                dgvSpisakZap.Rows.Add(podaci);
            }
        }

#region ex_dugmici
/*        private void btnDodati_Click(object sender, EventArgs e)
        {
            DodavanjeKlijenta dk = new DodavanjeKlijenta();
            this.Opacity = .50;
            DialogResult dr = dk.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.popuniGrid();
                // Pocetna.Instanca().popuniTree();
                //this.enableButtons();
                this.Opacity = 1;
            }
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;

        }

        private void btnUkloniti_Click(object sender, EventArgs e)
        {
            if ((dgvSpisakZap.CurrentRow != null) && (dgvSpisakZap.CurrentRow.Cells[2].Value != null))
            {
                String id = dgvSpisakZap.SelectedRows[0].Cells[2].Value.ToString();
                Brisanje p1 = new Brisanje(id);
                DialogResult dr = p1.ShowDialog();
                this.Opacity = .60;
                if (dr == DialogResult.Yes)
                {
                    spisakKlijenti.Instanca().UkloniKlijenta(id);
                    if (spisakKlijenti.Instanca().BrojKlijenata() == 0)
                       //disableButtons();
                    
                   popuniGrid();
                    this.Opacity = 1;
                }
                if (dr == DialogResult.No)
                    this.Opacity = 1;
            }
        }

        private void btnIzmeniti_Click(object sender, EventArgs e)
        {
            if ((dgvSpisakZap.CurrentRow != null) && (dgvSpisakZap.CurrentRow.Cells[2].Value != null))
            {
                String id = dgvSpisakZap.SelectedRows[0].Cells[2].Value.ToString();
                IzmenaKlijenta ik = new IzmenaKlijenta(id);
                this.Opacity = .60;
                DialogResult dr = ik.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    popuniGrid();
                    this.Opacity = 1;
                }
                else if (dr == DialogResult.Cancel)
                    this.Opacity = 1;
            }
        }*/
#endregion
        private void dgvSpisakZap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
