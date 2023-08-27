using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _405226_Problema_1._6_.Dominio
{
    internal class DBHelper
    {
        private AccesoDatos accesodatos;

        public DBHelper() 
        {
            accesodatos = new AccesoDatos();
        }

        public void cargarCombo(ComboBox combo, string sentencia)
        {
            DataTable tabla = new DataTable();
            tabla = accesodatos.ConsultarTabla(sentencia);
            combo.DataSource = tabla;
            combo.ValueMember= tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = 0;
        }

        public void NumeracionCamiones(Label labelTexto)
        {
            string aux = labelTexto.Text;
            labelTexto.Text = aux + accesodatos.EjecutarComando("SP_PROXIMO_CAMION").ToString();
        }
    }
}
