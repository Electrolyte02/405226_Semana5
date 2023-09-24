using _405226_Problema_1._6_.Dominio;
using _405226_Problema_1._6_.Entidades;
using _405226_Problema_1._6_.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _405226_Problema_1._6_.Vistas.Reportes
{
    public partial class FormEditarCamiones : Form
    {
        IServicio servicioDatos;
        Camion camionEditar;
        public FormEditarCamiones(int nro)
        {
            InitializeComponent();
            servicioDatos = new Servicio.Implementacion.Servicio();
            camionEditar = servicioDatos.TraerCamion(nro);
            servicioDatos.TraerCargas(camionEditar);
        }

        private void FormEditarCamiones_Load(object sender, EventArgs e)
        {
            lblNroCamion.Text += camionEditar.IdCamion.ToString();
            txtPatente.Text = camionEditar.Patente;
            txtPesoMaximo.Enabled = false;
            txtPesoMaximo.Text = camionEditar.PesoMaximo.ToString();
            cboEstado.DataSource = servicioDatos.TraerEstadosCamion();
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCarga.DataSource = servicioDatos.TraerTiposCarga();
            cboTipoCarga.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.SelectedIndex = camionEditar.EstadoCamion.IdEstado - 1;
            txtPesoRestante.Enabled = false;
            foreach (Carga c in camionEditar.ListaCargas)
            {
                dgvCargasCamiones.Rows.Add(new object[] { c.IdCarga, c.Peso, c.TipoCarga.NombreTipo, "Quitar" });
            }
            CalcularPesoRestante();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea Cancelar la edicion?","Cancelar",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboTipoCarga.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar un tipo de carga!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtPesoCarga.Text))
            {
                MessageBox.Show("Debe ingresar el peso de la carga!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Convert.ToInt32(txtPesoCarga.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un peso de carga valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                double pesoMaximo = Convert.ToInt32(txtPesoMaximo.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un maximo valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((Convert.ToDouble(txtPesoCarga.Text) + camionEditar.CalcularTotal()) > Convert.ToDouble(txtPesoMaximo.Text))
            {
                MessageBox.Show("No puede sumarse esa carga ya que supera el maximo del camion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AgregarCarga();
        }

        private void AgregarCarga()
        {
            foreach (DataGridViewRow row in dgvCargasCamiones.Rows)
            {
                if (row.Cells["columnaTipoCarga"].Value.ToString() == (cboTipoCarga.Text))
                {
                    MessageBox.Show("Esa carga ya fue colocada...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            //Creo un objeto de datarowview para dsp pasar al data grid view y casteo el tipo de carga como un item!
            DataRowView item = (DataRowView)cboTipoCarga.SelectedItem;
            int tipoCarga = (int)item.Row.ItemArray[0];
            string textoTipo = (string)item.Row.ItemArray[1];
            double peso = Convert.ToDouble(txtPesoCarga.Text);
            //Creamos una carga y la pasamos al camion
            Carga nCarga = new Carga();
            nCarga.TipoCarga.IdTipoCarga = tipoCarga;
            nCarga.TipoCarga.NombreTipo = textoTipo;
            nCarga.Peso = peso;
            //Agrego la carga al Camion Y ademas al dgv!
            camionEditar.AgregarCarga(nCarga);
            dgvCargasCamiones.Rows.Add(new object[] { nCarga.TipoCarga.IdTipoCarga, nCarga.Peso, nCarga.TipoCarga.NombreTipo, "Quitar" });
            CalcularPesoRestante();
        }

        private void CalcularPesoRestante()
        {
            txtPesoRestante.Enabled = false;
            txtPesoRestante.Text = string.Empty;
            txtPesoRestante.Text = camionEditar.PesoRestante().ToString();
        }

        private void dgvCargasCamiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCargasCamiones.CurrentCell.ColumnIndex == 3)
            {
                camionEditar.QuitarCarga(dgvCargasCamiones.CurrentRow.Index);
                dgvCargasCamiones.Rows.RemoveAt(dgvCargasCamiones.CurrentRow.Index);
                CalcularPesoRestante();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (servicioDatos.ActualizarCamion(camionEditar))
            {
                MessageBox.Show("El camion ha sido editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("El camion no pudo ser editado de manera correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GrabarCamion()
        {
            camionEditar.EstadoCamion = (EstadoCamion)cboEstado.SelectedValue;
            camionEditar.Patente = txtPatente.Text;
        }
    }
}
