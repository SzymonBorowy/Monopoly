namespace Monopoly
{
    partial class StartForm
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.buttonAutor = new System.Windows.Forms.Button();
            this.buttonWynik = new System.Windows.Forms.Button();
            this.buttonWyjscie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(19, 19);
            this.buttonNowaGra.Margin = new System.Windows.Forms.Padding(10);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(93, 62);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // buttonAutor
            // 
            this.buttonAutor.Location = new System.Drawing.Point(19, 183);
            this.buttonAutor.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAutor.Name = "buttonAutor";
            this.buttonAutor.Size = new System.Drawing.Size(93, 62);
            this.buttonAutor.TabIndex = 2;
            this.buttonAutor.Text = "Autor";
            this.buttonAutor.UseVisualStyleBackColor = true;
            this.buttonAutor.Click += new System.EventHandler(this.buttonAutor_Click);
            // 
            // buttonWynik
            // 
            this.buttonWynik.Location = new System.Drawing.Point(19, 101);
            this.buttonWynik.Margin = new System.Windows.Forms.Padding(10);
            this.buttonWynik.Name = "buttonWynik";
            this.buttonWynik.Size = new System.Drawing.Size(93, 62);
            this.buttonWynik.TabIndex = 3;
            this.buttonWynik.Text = "Wyniki";
            this.buttonWynik.UseVisualStyleBackColor = true;
            this.buttonWynik.Click += new System.EventHandler(this.buttonWynik_Click);
            // 
            // buttonWyjscie
            // 
            this.buttonWyjscie.Location = new System.Drawing.Point(19, 265);
            this.buttonWyjscie.Margin = new System.Windows.Forms.Padding(10);
            this.buttonWyjscie.Name = "buttonWyjscie";
            this.buttonWyjscie.Size = new System.Drawing.Size(93, 62);
            this.buttonWyjscie.TabIndex = 4;
            this.buttonWyjscie.Text = "Wyjście";
            this.buttonWyjscie.UseVisualStyleBackColor = true;
            this.buttonWyjscie.Click += new System.EventHandler(this.buttonWyjscie_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 416);
            this.Controls.Add(this.buttonWyjscie);
            this.Controls.Add(this.buttonWynik);
            this.Controls.Add(this.buttonAutor);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "StartForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.Button buttonAutor;
        private System.Windows.Forms.Button buttonWynik;
        private System.Windows.Forms.Button buttonWyjscie;
    }
}

