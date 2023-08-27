using _405226_Problema_1._6_.Dominio;
using _405226_Problema_1._6_.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _405226_Problema_1._6_.Presentacion
{
    public partial class FormCargasCamiones : Form
    {
        DBHelper servicioDatos;
        Camion nuevoCamion;
        public FormCargasCamiones()
        {
            InitializeComponent();
            servicioDatos = new DBHelper();
            nuevoCamion = new Camion();
        }

        private void FormCargasCamiones_Load(object sender, EventArgs e)
        {
            servicioDatos.NumeracionCamiones(lblCamionesNro);
            servicioDatos.cargarCombo(cboEstado, "SP_CONSULTAR_ESTADOS");
            servicioDatos.cargarCombo(cboTipoCarga, "SP_CONSULTAR_TIPOS_CARGA");
            txtPesoRestante.Enabled = false;
        }
    }
}
