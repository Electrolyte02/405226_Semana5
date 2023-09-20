using _405226_Problema_1._6_.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _405226_Problema_1._6_.Presentacion;
using _405226_Problema_1._6_.Vistas.Reportes;

namespace _405226_Problema_1._6_.Vistas
{
    public partial class FormConsultaCamiones : Form
    {
        DBHelper gestor;
        public FormConsultaCamiones()
        {
            InitializeComponent();
            gestor = new DBHelper();
            gestor.cargarCombo(cboEstado, "SP_CONSULTAR_ESTADOS");
            txtPesoMaximo.Enabled = false;
            rbtMayor.Enabled = false;
            rbtMenor.Enabled = false;
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Regresar?","Regresar",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
                this.Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private DataTable CargarTabla()
        {
            DataTable tabla = new DataTable();
            List<Parametro> listParametro = new List<Parametro>();
            if (chkPesoMaximo.Checked)
            {
                if (String.IsNullOrEmpty(txtPesoMaximo.Text))
                {
                    MessageBox.Show("Debe ingresar un peso maximo para Comparar");
                    return tabla;
                }
                try
                {
                    Convert.ToInt32(txtPesoMaximo.Text);
                }
                catch
                {
                    MessageBox.Show("Ingrese un peso maximo valido para Comparar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return tabla;
                }
                if (rbtMayor.Checked)
                {
                    listParametro.Add(new Parametro("@patente", txtPatente.Text));
                    listParametro.Add(new Parametro("@id_estado", cboEstado.SelectedValue));
                    listParametro.Add(new Parametro("@peso_max", Convert.ToInt32(txtPesoMaximo.Text)));
                    tabla = gestor.ConsultarCamiones("SP_CONSULTAR_CAMIONES_MAYOR", listParametro);
                }
                else if (rbtMenor.Checked)
                {
                    listParametro.Add(new Parametro("@patente", txtPatente.Text));
                    listParametro.Add(new Parametro("@id_estado", cboEstado.SelectedValue));
                    listParametro.Add(new Parametro("@peso_max", Convert.ToInt32(txtPesoMaximo.Text)));
                    tabla = gestor.ConsultarCamiones("SP_CONSULTAR_CAMIONES_MENOR", listParametro);
                }
            }
            else if (chkPesoMaximo.Checked == false)
            {
                listParametro.Add(new Parametro("@patente", txtPatente.Text));
                listParametro.Add(new Parametro("@id_estado", cboEstado.SelectedValue));
                tabla = gestor.ConsultarCamiones("SP_CONSULTAR_CAMIONES", listParametro);
            }
            return tabla;
        }

        private void chkPesoMaximo_CheckedChanged(object sender, EventArgs e)
        {
            txtPesoMaximo.Enabled = chkPesoMaximo.Checked;
            rbtMayor.Enabled = chkPesoMaximo.Checked;
            rbtMenor.Enabled = chkPesoMaximo.Checked;
        }

        private void dgvConsultaCamion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvConsultaCamion.CurrentCell.ColumnIndex == 4)
            {
                int nro = Convert.ToInt32(dgvConsultaCamion.CurrentRow.Cells["ColumnaId"].Value.ToString());
                new FormConsultarCargasCamiones(nro).ShowDialog();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea borrar el camion? Esta accion no se puede deshacer.","Borrar?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int nro = Convert.ToInt32(dgvConsultaCamion.CurrentRow.Cells["ColumnaId"].Value.ToString());
                if (gestor.BorrarCamion(nro) >= 1)
                    MessageBox.Show("Camion Borrado Con exito!", "Borrado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("No se pudo borrar ese camion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarDataGridView();
            }
        }

        private void CargarDataGridView()
        {
            DataTable tabla = CargarTabla();
            dgvConsultaCamion.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                dgvConsultaCamion.Rows.Add(new object[]
                {
                    fila["id_camion"].ToString(),
                    fila["patente"].ToString(),
                    fila["estado"].ToString(),
                    fila["peso_maximo"].ToString(),
                    "Ver Detalle"
                });
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int nro = Convert.ToInt32(dgvConsultaCamion.CurrentRow.Cells["ColumnaId"].Value.ToString());
            new FormEditarCamiones(nro).ShowDialog();
        }
    }
}
