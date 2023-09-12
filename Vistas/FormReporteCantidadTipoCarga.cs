using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _405226_Problema_1._6_.Vistas
{
    public partial class FormReporteCantidadTipoCarga : Form
    {
        public FormReporteCantidadTipoCarga()
        {
            InitializeComponent();
        }

        private void FormReporteCantidadTipoCarga_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSTipoCargasCamiones.T_CANT_CARGAS' Puede moverla o quitarla según sea necesario.
            this.t_CANT_CARGASTableAdapter.Fill(this.dSTipoCargasCamiones.T_CANT_CARGAS);

            this.reportViewer1.RefreshReport();
        }
    }
}
