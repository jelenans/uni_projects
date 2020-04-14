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
    public partial class Pregled_zaposlenih : Form
    {
        public Pregled_zaposlenih()
        {
            InitializeComponent();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Pregled_zaposlenih_Load(object sender, EventArgs e)
        {
            popuniGrid();
            dgvPregledZap.ClearSelection();
        }

        public void popuniGrid()
        {
            dgvPregledZap.Rows.Clear();
            int n = spisakZaposleni.Instanca().BrojZap1();
            if (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    String[] podaci = {spisakZaposleni.Instanca().NadjiZap1(i).Ime,
                                  spisakZaposleni.Instanca().NadjiZap1(i).Prezime, 
                                  spisakZaposleni.Instanca().NadjiZap1(i).Sifra,
                                  spisakZaposleni.Instanca().NadjiZap1(i).Jmbg,
                                  spisakZaposleni.Instanca().NadjiZap1(i).DatZaposl.ToShortDateString(),
                                  spisakZaposleni.Instanca().NadjiZap1(i).Dozvola,
                                  spisakZaposleni.Instanca().NadjiZap1(i).Kategorija,
                                  spisakZaposleni.Instanca().NadjiZap1(i).Komentar
                                 };
                    dgvPregledZap.Rows.Add(podaci);
                }
            }
            int n2 = spisakZaposleni.Instanca().BrojZap2();
            if (n2 != 0)
            {
                for (int i = 0; i < n2; i++)
                {
                    String[] podaci = {spisakZaposleni.Instanca().NadjiZap2(i).Ime,
                                  spisakZaposleni.Instanca().NadjiZap2(i).Prezime, 
                                  spisakZaposleni.Instanca().NadjiZap2(i).Sifra,
                                  spisakZaposleni.Instanca().NadjiZap2(i).Jmbg,
                                  spisakZaposleni.Instanca().NadjiZap2(i).DatZaposl.ToShortDateString(),
                                  spisakZaposleni.Instanca().NadjiZap2(i).Dozvola,
                                  spisakZaposleni.Instanca().NadjiZap2(i).Kategorija,
                                  spisakZaposleni.Instanca().NadjiZap2(i).Komentar,
                                 };
                    dgvPregledZap.Rows.Add(podaci);
                }
            }
            
                int n3 = spisakZaposleni.Instanca().BrojZap3();
                if (n3 != 0)
                {
                for (int i = 0; i < n3; i++)
                {
                    String[] podaci = {spisakZaposleni.Instanca().NadjiZap3(i).Ime,
                                  spisakZaposleni.Instanca().NadjiZap3(i).Prezime, 
                                  spisakZaposleni.Instanca().NadjiZap3(i).Sifra,
                                  spisakZaposleni.Instanca().NadjiZap3(i).Jmbg,
                                  spisakZaposleni.Instanca().NadjiZap3(i).DatZaposl.ToShortDateString(),
                                  spisakZaposleni.Instanca().NadjiZap3(i).Dozvola,
                                  spisakZaposleni.Instanca().NadjiZap3(i).Kategorija,
                                  spisakZaposleni.Instanca().NadjiZap3(i).Komentar,
                                 };
                    dgvPregledZap.Rows.Add(podaci);
                }
            }
            int n4 = spisakZaposleni.Instanca().BrojZap4();
            if (n4 != 0)
            {
                for (int i = 0; i < n4; i++)
                {
                    String[] podaci = {spisakZaposleni.Instanca().NadjiZap4(i).Ime,
                                  spisakZaposleni.Instanca().NadjiZap4(i).Prezime, 
                                  spisakZaposleni.Instanca().NadjiZap4(i).Sifra,
                                  spisakZaposleni.Instanca().NadjiZap4(i).Jmbg,
                                  spisakZaposleni.Instanca().NadjiZap4(i).DatZaposl.ToShortDateString(),
                                  spisakZaposleni.Instanca().NadjiZap4(i).Dozvola,
                                  spisakZaposleni.Instanca().NadjiZap4(i).Kategorija,
                                  spisakZaposleni.Instanca().NadjiZap4(i).Komentar,
                                 };
                    dgvPregledZap.Rows.Add(podaci);
                }
            }

            int n5 = spisakZaposleni.Instanca().BrojZap5();
            if (n5 != 0)
            {
                for (int i = 0; i < n5; i++)
                {
                    String[] podaci = {spisakZaposleni.Instanca().NadjiZap5(i).Ime,
                                  spisakZaposleni.Instanca().NadjiZap5(i).Prezime, 
                                  spisakZaposleni.Instanca().NadjiZap5(i).Sifra,
                                  spisakZaposleni.Instanca().NadjiZap5(i).Jmbg,
                                  spisakZaposleni.Instanca().NadjiZap5(i).DatZaposl.ToShortDateString(),
                                  spisakZaposleni.Instanca().NadjiZap5(i).Dozvola,
                                  spisakZaposleni.Instanca().NadjiZap5(i).Kategorija,
                                  spisakZaposleni.Instanca().NadjiZap5(i).Komentar,
                                 };
                    dgvPregledZap.Rows.Add(podaci);
                }
            }
        }

        private void dgvPregledZap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
