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
    public partial class Pregled : Form
    {
        public Pregled()
        {
            InitializeComponent();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Pregled_Load(object sender, EventArgs e)
        {
            popuniGrid();
            dgvPregledAng.ClearSelection();
        }

        private void popuniGrid()
        {
             dgvPregledAng.Rows.Clear();
          int n = Angazovanja.Instanca().BrojAng();
          for (int i = 0; i < n; i++)
          {
              String[] podaci = {   Angazovanja.Instanca().NadjiAng(i).ImeiprzZaposlenog,
                                    Angazovanja.Instanca().NadjiAng(i).ImeiprzKlijenta,
                                    Angazovanja.Instanca().NadjiAng(i).DatAng.ToShortDateString(),
                                    Angazovanja.Instanca().NadjiAng(i).DatPrekidaAng.ToShortDateString(),
                                    Angazovanja.Instanca().NadjiAng(i).RazlogAng,
                                    Angazovanja.Instanca().NadjiAng(i).Koment,
                               };
              dgvPregledAng.Rows.Add(podaci);
          }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter f = new Filter();
            DialogResult dr = f.ShowDialog();
            this.Opacity = .60;
            if (dr == DialogResult.OK)
            {
                popuniGrid2();
                this.Opacity = 1;
            } else
            if (dr == DialogResult.Cancel)
                    this.Opacity = 1;
        }

        private void popuniGrid2()
        {
            String podatak;
            String podatak2;
            String podatak3;
            String podatak4;
            String podatak5;
            String podatak6;
           // String[][] joj;
            int i = 0;
            //dgvPregledAng.Rows.Clear();
          
                foreach (DataGridViewRow row in this.dgvPregledAng.Rows)
                {
                    podatak = row.Cells[0].Value.ToString();
                    String p = podatak.Trim();
                    podatak2 = row.Cells[1].Value.ToString();
                    String p2 = podatak2.Trim();
                    podatak3 = row.Cells[2].Value.ToString();
                    String p3 = podatak3.Trim();
                    podatak4 = row.Cells[3].Value.ToString();
                    String p4 = podatak4.Trim();
                    podatak5 = row.Cells[4].Value.ToString();
                    String p5 = podatak5.Trim();
                    podatak6 = row.Cells[5].Value.ToString();
                    String p6 = podatak6.Trim();

                      if (!(p.Contains(Filter.vrednost) || p2.Contains(Filter.vrednost)
                          || p3.Contains(Filter.vrednost) || p4.Contains(Filter.vrednost)
                          || p5.Contains(Filter.vrednost) || p6.Contains(Filter.vrednost)))
                    {
                        row.Visible = false;
                        String[] podaci = {   row.Cells[0].Value.ToString(),
                                   row.Cells[1].Value.ToString(),
                                    row.Cells[2].Value.ToString(),
                                    row.Cells[3].Value.ToString(),
                                    row.Cells[4].Value.ToString(),
                                    row.Cells[5].Value.ToString()
                               };
                    }
                        //dgvPregledAng.Rows.Add(podatak);
                }
           

        }
      
    }
}
