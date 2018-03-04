namespace Monopoly
{
    partial class BudujForma
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
            this.buttonBudujBlok = new System.Windows.Forms.Button();
            this.buttonBudujHotel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonWykup = new System.Windows.Forms.Button();
            this.buttonZastaw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBudujBlok
            // 
            this.buttonBudujBlok.Location = new System.Drawing.Point(12, 177);
            this.buttonBudujBlok.Name = "buttonBudujBlok";
            this.buttonBudujBlok.Size = new System.Drawing.Size(75, 23);
            this.buttonBudujBlok.TabIndex = 0;
            this.buttonBudujBlok.Text = "Buduj blok";
            this.buttonBudujBlok.UseVisualStyleBackColor = true;
            this.buttonBudujBlok.Click += new System.EventHandler(this.buttonBudujBlok_Click);
            // 
            // buttonBudujHotel
            // 
            this.buttonBudujHotel.Location = new System.Drawing.Point(93, 177);
            this.buttonBudujHotel.Name = "buttonBudujHotel";
            this.buttonBudujHotel.Size = new System.Drawing.Size(75, 23);
            this.buttonBudujHotel.TabIndex = 1;
            this.buttonBudujHotel.Text = "Buduj hotel";
            this.buttonBudujHotel.UseVisualStyleBackColor = true;
            this.buttonBudujHotel.Click += new System.EventHandler(this.buttonBudujHotel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // buttonWykup
            // 
            this.buttonWykup.Enabled = false;
            this.buttonWykup.Location = new System.Drawing.Point(12, 235);
            this.buttonWykup.Name = "buttonWykup";
            this.buttonWykup.Size = new System.Drawing.Size(156, 23);
            this.buttonWykup.TabIndex = 3;
            this.buttonWykup.Text = "Wykup";
            this.buttonWykup.UseVisualStyleBackColor = true;
            this.buttonWykup.Click += new System.EventHandler(this.buttonWykup_Click);
            // 
            // buttonZastaw
            // 
            this.buttonZastaw.Location = new System.Drawing.Point(12, 206);
            this.buttonZastaw.Name = "buttonZastaw";
            this.buttonZastaw.Size = new System.Drawing.Size(156, 23);
            this.buttonZastaw.TabIndex = 4;
            this.buttonZastaw.Text = "Zastaw ";
            this.buttonZastaw.UseVisualStyleBackColor = true;
            this.buttonZastaw.Click += new System.EventHandler(this.buttonZastaw_Click);
            // 
            // BudujForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonZastaw);
            this.Controls.Add(this.buttonWykup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBudujHotel);
            this.Controls.Add(this.buttonBudujBlok);
            this.Name = "BudujForma";
            this.Text = "BudujForma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BudujForma_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBudujBlok;
        private System.Windows.Forms.Button buttonBudujHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonWykup;
        private System.Windows.Forms.Button buttonZastaw;
    }
}