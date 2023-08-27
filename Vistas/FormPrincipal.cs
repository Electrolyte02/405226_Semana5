using _405226_Problema_1._6_.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _405226_Problema_1._6_
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cargasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCargasCamiones().ShowDialog();
        }
    }
}
