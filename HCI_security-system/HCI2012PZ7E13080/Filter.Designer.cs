namespace HCI2012PZ7E13080
{
    partial class Filter
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
            this.lbVred = new System.Windows.Forms.Label();
            this.tbVred = new System.Windows.Forms.TextBox();
            this.btnPotvrda = new System.Windows.Forms.Button();
            this.btnOdustati = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbVred
            // 
            this.lbVred.AutoSize = true;
            this.lbVred.Location = new System.Drawing.Point(21, 19);
            this.lbVred.Name = "lbVred";
            this.lbVred.Size = new System.Drawing.Size(62, 13);
            this.lbVred.TabIndex = 1;
            this.lbVred.Text = "vrednost za";
            // 
            // tbVred
            // 
            this.tbVred.Location = new System.Drawing.Point(97, 25);
            this.tbVred.Name = "tbVred";
            this.tbVred.Size = new System.Drawing.Size(163, 20);
            this.tbVred.TabIndex = 2;
            // 
            // btnPotvrda
            // 
            this.btnPotvrda.Location = new System.Drawing.Point(55, 73);
            this.btnPotvrda.Name = "btnPotvrda";
            this.btnPotvrda.Size = new System.Drawing.Size(80, 30);
            this.btnPotvrda.TabIndex = 3;
            this.btnPotvrda.Text = "Potvrditi";
            this.btnPotvrda.UseVisualStyleBackColor = true;
            this.btnPotvrda.Click += new System.EventHandler(this.btnPotvrda_Click);
            // 
            // btnOdustati
            // 
            this.btnOdustati.Location = new System.Drawing.Point(152, 73);
            this.btnOdustati.Name = "btnOdustati";
            this.btnOdustati.Size = new System.Drawing.Size(80, 30);
            this.btnOdustati.TabIndex = 4;
            this.btnOdustati.Text = "Odustati";
            this.btnOdustati.UseVisualStyleBackColor = true;
            this.btnOdustati.Click += new System.EventHandler(this.btnOdustati_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "pretraživanje:";
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdustati);
            this.Controls.Add(this.btnPotvrda);
            this.Controls.Add(this.tbVred);
            this.Controls.Add(this.lbVred);
            this.MaximizeBox = false;
            this.Name = "Filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filter";
            this.Load += new System.EventHandler(this.Filter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVred;
        private System.Windows.Forms.TextBox tbVred;
        private System.Windows.Forms.Button btnPotvrda;
        private System.Windows.Forms.Button btnOdustati;
        private System.Windows.Forms.Label label1;
    }
}