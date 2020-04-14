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
    public partial class UnosRazdaljine : Form
    {
        public  int razdaljina;
        public UnosRazdaljine()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                razdaljina = int.Parse(textBox1.Text);
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Razdaljina mora biti broj!");
            }
           
        }

      
    }
}
