namespace Monopoly
{
    partial class ZastawPolaForm
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
            this.listBoxPola = new System.Windows.Forms.ListBox();
            this.buttonZastaw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPola
            // 
            this.listBoxPola.FormattingEnabled = true;
            this.listBoxPola.Location = new System.Drawing.Point(12, 12);
            this.listBoxPola.Name = "listBoxPola";
            this.listBoxPola.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxPola.Size = new System.Drawing.Size(188, 238);
            this.listBoxPola.TabIndex = 0;
            this.listBoxPola.SelectedIndexChanged += new System.EventHandler(this.listBoxPola_SelectedIndexChanged);
            // 
            // buttonZastaw
            // 
            this.buttonZastaw.Location = new System.Drawing.Point(206, 227);
            this.buttonZastaw.Name = "buttonZastaw";
            this.buttonZastaw.Size = new System.Drawing.Size(75, 23);
            this.buttonZastaw.TabIndex = 1;
            this.buttonZastaw.Text = "Zastaw";
            this.buttonZastaw.UseVisualStyleBackColor = true;
            this.buttonZastaw.Click += new System.EventHandler(this.buttonZastaw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ZastawPolaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZastaw);
            this.Controls.Add(this.listBoxPola);
            this.Name = "ZastawPolaForm";
            this.Text = "ZastawPolaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPola;
        private System.Windows.Forms.Button buttonZastaw;
        private System.Windows.Forms.Label label1;
    }
}