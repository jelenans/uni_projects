namespace HCI2012PZ7E13080
{
    partial class Brisanje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brisanje));
            this.lbpitanje = new System.Windows.Forms.Label();
            this.btDa = new System.Windows.Forms.Button();
            this.btNe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbpitanje
            // 
            this.lbpitanje.AutoSize = true;
            this.lbpitanje.Location = new System.Drawing.Point(38, 39);
            this.lbpitanje.Name = "lbpitanje";
            this.lbpitanje.Size = new System.Drawing.Size(35, 13);
            this.lbpitanje.TabIndex = 0;
            this.lbpitanje.Text = "label1";
            // 
            // btDa
            // 
            this.btDa.Location = new System.Drawing.Point(90, 74);
            this.btDa.Name = "btDa";
            this.btDa.Size = new System.Drawing.Size(75, 29);
            this.btDa.TabIndex = 1;
            this.btDa.Text = "&Da";
            this.btDa.UseVisualStyleBackColor = true;
            this.btDa.Click += new System.EventHandler(this.btDa_Click);
            // 
            // btNe
            // 
            this.btNe.Location = new System.Drawing.Point(189, 74);
            this.btNe.Name = "btNe";
            this.btNe.Size = new System.Drawing.Size(75, 29);
            this.btNe.TabIndex = 2;
            this.btNe.Text = "&Ne";
            this.btNe.UseVisualStyleBackColor = true;
            this.btNe.Click += new System.EventHandler(this.btNe_Click);
            // 
            // Brisanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 117);
            this.Controls.Add(this.btNe);
            this.Controls.Add(this.btDa);
            this.Controls.Add(this.lbpitanje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Brisanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Brisanje podataka o klijentu";
            this.Load += new System.EventHandler(this.Brisanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNe;
        private System.Windows.Forms.Button btnDa;
        private System.Windows.Forms.Label pitanje;
        private System.Windows.Forms.Label lbpitanje;
        private System.Windows.Forms.Button btDa;
        private System.Windows.Forms.Button btNe;
    }
}