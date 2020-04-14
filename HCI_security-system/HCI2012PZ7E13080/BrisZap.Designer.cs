namespace HCI2012PZ7E13080
{
    partial class BrisZap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrisZap));
            this.btnNe = new System.Windows.Forms.Button();
            this.btnDa = new System.Windows.Forms.Button();
            this.lbpit1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNe
            // 
            this.btnNe.Location = new System.Drawing.Point(177, 62);
            this.btnNe.Name = "btnNe";
            this.btnNe.Size = new System.Drawing.Size(75, 29);
            this.btnNe.TabIndex = 5;
            this.btnNe.Text = "&Ne";
            this.btnNe.UseVisualStyleBackColor = true;
            this.btnNe.Click += new System.EventHandler(this.btnNe_Click);
            // 
            // btnDa
            // 
            this.btnDa.Location = new System.Drawing.Point(78, 62);
            this.btnDa.Name = "btnDa";
            this.btnDa.Size = new System.Drawing.Size(75, 29);
            this.btnDa.TabIndex = 4;
            this.btnDa.Text = "&Da";
            this.btnDa.UseVisualStyleBackColor = true;
            this.btnDa.Click += new System.EventHandler(this.btnDa_Click);
            // 
            // lbpit1
            // 
            this.lbpit1.AutoSize = true;
            this.lbpit1.Location = new System.Drawing.Point(26, 27);
            this.lbpit1.Name = "lbpit1";
            this.lbpit1.Size = new System.Drawing.Size(35, 13);
            this.lbpit1.TabIndex = 3;
            this.lbpit1.Text = "label1";
            // 
            // BrisZap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 115);
            this.Controls.Add(this.btnNe);
            this.Controls.Add(this.btnDa);
            this.Controls.Add(this.lbpit1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrisZap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Brisanje podataka o zaposlenom";
            this.Load += new System.EventHandler(this.BrisZap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNe;
        private System.Windows.Forms.Button btnDa;
        private System.Windows.Forms.Label lbpit1;
    }
}