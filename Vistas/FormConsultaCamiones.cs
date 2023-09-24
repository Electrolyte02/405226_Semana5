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
using _405226_Problema_1._6_.Servicio.Interfaz;
using _405226_Problema_1._6_.Entidades;

namespace _405226_Problema_1._6_.Vistas
{
    public partial class FormConsultaCamiones : Form
    {
        IServicio servicioDatos;
        public FormConsultaCamiones()
        {
            InitializeComponent();
            servicioDatos = new Servicio.Implementacion.Servicio();
            cboEstado.DataSource = servicioDatos.TraerEstadosCamion();
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private List<Camion> CargarTabla()
        {
            List<Camion> lCamiones = new List<Camion>();
            List<Parametro> listParametro = new List<Parametro>();
            if (chkPesoMaximo.Checked)
            {
                if (String.IsNullOrEmpty(txtPesoMaximo.Text))
                {
                    MessageBox.Show("Debe ingresar un peso maximo para Comparar");
                    return lCamiones;
                }
                try
                {
                    Convert.ToInt32(txtPesoMaximo.Text);
                }
                catch
                {
                    MessageBox.Show("Ingrese un peso maximo valido para Comparar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return lCamiones;
                }
                if (rbtMayor.Checked)
                {
                    EstadoCamion auxEstado = (EstadoCamion)cboEstado.SelectedItem;
                    listParametro.Add(new Parametro("@patente", txtPatente.Text));
                    listParametro.Add(new Parametro("@id_estado", auxEstado.IdEstado));
                    listParametro.Add(new Parametro("@peso_max", Convert.ToInt32(txtPesoMaximo.Text)));
                    lCamiones = servicioDatos.TraerCamiones(listParametro,"SP_CONSULTAR_CAMIONES_MAYOR");
                }
                else if (rbtMenor.Checked)
                {
                    EstadoCamion auxEstado = (EstadoCamion)cboEstado.SelectedItem;
                    listParametro.Add(new Parametro("@patente", txtPatente.Text));
                    listParametro.Add(new Parametro("@id_estado", auxEstado.IdEstado));
                    listParametro.Add(new Parametro("@peso_max", Convert.ToInt32(txtPesoMaximo.Text)));
                    lCamiones = servicioDatos.TraerCamiones(listParametro,"SP_CONSULTAR_CAMIONES_MENOR");
                }
            }
            else if (chkPesoMaximo.Checked == false)
            {
                EstadoCamion auxEstado = (EstadoCamion)cboEstado.SelectedItem;
                listParametro.Add(new Parametro("@patente", txtPatente.Text));
                listParametro.Add(new Parametro("@id_estado", auxEstado.IdEstado));
                lCamiones = servicioDatos.TraerCamiones(listParametro, "SP_CONSULTAR_CAMIONES");
            }
            return lCamiones;
        }

        private void chkPesoMaximo_CheckedChanged(object sender, EventArgs e)
        {
            txtPesoMaximo.Enabled = chkPesoMaximo.Checked;
            rbtMayor.Enabled = chkPesoMaximo.Checked;
            rbtMenor.Enabled = chkPesoMaximo.Checked;
        }

        private void dgvConsultaCamion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaCamion.CurrentRow==null)
            {
                MessageBox.Show("Debe Consultar los camiones previamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(dgvConsultaCamion.CurrentCell.ColumnIndex == 4)
            {
                int nro = Convert.ToInt32(dgvConsultaCamion.CurrentRow.Cells["ColumnaId"].Value.ToString());
                new FormConsultarCargasCamiones(nro).ShowDialog();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvConsultaCamion.CurrentRow == null)
            {
                MessageBox.Show("Debe Consultar los camiones previamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Esta seguro que desea borrar el camion? Esta accion no se puede deshacer.","Borrar?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int nro = Convert.ToInt32(dgvConsultaCamion.CurrentRow.Cells["ColumnaId"].Value.ToString());
                if (servicioDatos.BorrarCamion(nro))
                    MessageBox.Show("Camion Borrado Con exito!", "Borrado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("No se pudo borrar ese camion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarDataGridView();
            }
        }

        private void CargarDataGridView()
        {
            List<Camion> lCamiones = CargarTabla();
            dgvConsultaCamion.Rows.Clear();
            foreach (Camion c in lCamiones)
            {
                dgvConsultaCamion.Rows.Add(new object[]
                {
                    c.IdCamion.ToString(),
                    c.Patente.ToString(),
                    c.EstadoCamion.IdEstado.ToString(),
                    c.PesoMaximo.ToString(),
                    "Ver Detalle"
                });
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvConsultaCamion.CurrentRow == null)
            {
                MessageBox.Show("Debe Consultar los camiones previamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int nro = Convert.ToInt32(dgvConsultaCamion.CurrentRow.Cells["ColumnaId"].Value.ToString());
            new FormEditarCamiones(nro).ShowDialog();
        }
    }
}
