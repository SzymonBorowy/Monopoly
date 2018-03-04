using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            Gracze gra = new Gracze();
            gra.Show();
        }

        private void buttonWynik_Click(object sender, EventArgs e)
        {
            MessageBox.Show("wynik");
        }

        private void buttonAutor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor");
        }

        private void buttonWyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
