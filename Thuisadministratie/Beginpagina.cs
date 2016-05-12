using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Thuisadministratie
{
    public partial class Beginpagina : Form
    {
        public Beginpagina()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            


        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Post post = new Post();
            post.ShowDialog();
        }

        private void btnFactuur_Click(object sender, EventArgs e)
        {
            Factuur factuur = new Factuur();
            factuur.ShowDialog();
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            Zoeken zoeken = new Zoeken();
            zoeken.ShowDialog();
        }

        private void btnInstellingen_Click(object sender, EventArgs e)
        {
            Instellingen instellingen = new Instellingen();
            instellingen.ShowDialog();
        }
    }
}
