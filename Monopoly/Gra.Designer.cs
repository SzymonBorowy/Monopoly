namespace Monopoly
{
    partial class Gra
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRzucKostka = new System.Windows.Forms.Button();
            this.labelNazwaGracza = new System.Windows.Forms.Label();
            this.labelGotowka = new System.Windows.Forms.Label();
            this.listBoxWlasnosci = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKupPole = new System.Windows.Forms.Button();
            this.buttonKoniecTury = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(19, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 800);
            this.panel1.TabIndex = 0;
            // 
            // buttonRzucKostka
            // 
            this.buttonRzucKostka.Location = new System.Drawing.Point(856, 218);
            this.buttonRzucKostka.Name = "buttonRzucKostka";
            this.buttonRzucKostka.Size = new System.Drawing.Size(111, 32);
            this.buttonRzucKostka.TabIndex = 0;
            this.buttonRzucKostka.Text = "Rzuć Kostkami";
            this.buttonRzucKostka.UseVisualStyleBackColor = true;
            this.buttonRzucKostka.Click += new System.EventHandler(this.buttonRzucKostka_Click);
            // 
            // labelNazwaGracza
            // 
            this.labelNazwaGracza.AutoSize = true;
            this.labelNazwaGracza.Location = new System.Drawing.Point(853, 19);
            this.labelNazwaGracza.Name = "labelNazwaGracza";
            this.labelNazwaGracza.Size = new System.Drawing.Size(71, 13);
            this.labelNazwaGracza.TabIndex = 1;
            this.labelNazwaGracza.Text = "Ruch gracza:";
            // 
            // labelGotowka
            // 
            this.labelGotowka.AutoSize = true;
            this.labelGotowka.Location = new System.Drawing.Point(853, 47);
            this.labelGotowka.Name = "labelGotowka";
            this.labelGotowka.Size = new System.Drawing.Size(53, 13);
            this.labelGotowka.TabIndex = 2;
            this.labelGotowka.Text = "Gotówka:";
            // 
            // listBoxWlasnosci
            // 
            this.listBoxWlasnosci.FormattingEnabled = true;
            this.listBoxWlasnosci.Location = new System.Drawing.Point(856, 76);
            this.listBoxWlasnosci.Name = "listBoxWlasnosci";
            this.listBoxWlasnosci.Size = new System.Drawing.Size(120, 108);
            this.listBoxWlasnosci.TabIndex = 3;
            this.listBoxWlasnosci.SelectedIndexChanged += new System.EventHandler(this.listBoxWlasnosci_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(853, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "OPERACJE";
            // 
            // buttonKupPole
            // 
            this.buttonKupPole.Location = new System.Drawing.Point(856, 256);
            this.buttonKupPole.Name = "buttonKupPole";
            this.buttonKupPole.Size = new System.Drawing.Size(111, 32);
            this.buttonKupPole.TabIndex = 5;
            this.buttonKupPole.Text = "Kup pole";
            this.buttonKupPole.UseVisualStyleBackColor = true;
            this.buttonKupPole.Click += new System.EventHandler(this.buttonKupPole_Click);
            // 
            // buttonKoniecTury
            // 
            this.buttonKoniecTury.Location = new System.Drawing.Point(856, 294);
            this.buttonKoniecTury.Name = "buttonKoniecTury";
            this.buttonKoniecTury.Size = new System.Drawing.Size(111, 32);
            this.buttonKoniecTury.TabIndex = 6;
            this.buttonKoniecTury.Text = "Koniec tury";
            this.buttonKoniecTury.UseVisualStyleBackColor = true;
            this.buttonKoniecTury.Click += new System.EventHandler(this.buttonKoniecTury_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1009, 147);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 366);
            this.textBox1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1009, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Gra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 1000);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonKoniecTury);
            this.Controls.Add(this.buttonKupPole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxWlasnosci);
            this.Controls.Add(this.labelGotowka);
            this.Controls.Add(this.labelNazwaGracza);
            this.Controls.Add(this.buttonRzucKostka);
            this.Controls.Add(this.panel1);
            this.Name = "Gra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRzucKostka;
        private System.Windows.Forms.Label labelNazwaGracza;
        private System.Windows.Forms.Label labelGotowka;
        private System.Windows.Forms.ListBox listBoxWlasnosci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKupPole;
        private System.Windows.Forms.Button buttonKoniecTury;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}