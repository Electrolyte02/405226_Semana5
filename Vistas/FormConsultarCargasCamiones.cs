using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _405226_Problema_1._6_.Dominio;
using _405226_Problema_1._6_.Entidades;
using _405226_Problema_1._6_.Presentacion;
using _405226_Problema_1._6_.Vistas;

namespace _405226_Problema_1._6_.Vistas
{
    public partial class FormConsultarCargasCamiones : Form
    {
        DBHelper servicioDatos;
        Camion camionEditar;
        public FormConsultarCargasCamiones(int nro)
        {
            InitializeComponent();
            servicioDatos = new DBHelper();
            camionEditar = servicioDatos.TraerCamion(nro);
            servicioDatos.TraerCargas(camionEditar);
        }

        private void FormEditarCargasCamiones_Load(object sender,EventArgs e)
        {
            lblNroCamion.Text += camionEditar.IdCamion.ToString();
            txtPatente.Text = camionEditar.Patente;
            txtPesoMaximo.Enabled = false;
            txtPesoMaximo.Text = camionEditar.PesoMaximo.ToString();
            servicioDatos.cargarCombo(cboEstado, "SP_CONSULTAR_ESTADOS");
            servicioDatos.cargarCombo(cboTipoCarga, "SP_CONSULTAR_TIPOS_CARGA");
            cboEstado.SelectedIndex = camionEditar.EstadoCamion-1;
            txtPesoRestante.Enabled = false;
            foreach(Carga c in camionEditar.ListaCargas)
            {
                switch (c.TipoCarga)
                {
                    case 1:
                        dgvCargas.Rows.Add(new object[] { c.IdCarga, c.Peso, "Packing", "Quitar" });
                        break;
                    case 2:
                        dgvCargas.Rows.Add(new object[] { c.IdCarga, c.Peso, "Cajas", "Quitar" });
                        break;
                    case 3:
                        dgvCargas.Rows.Add(new object[] { c.IdCarga, c.Peso, "Bidones", "Quitar" });
                        break;
                }
            }
            CalcularPesoRestante();
            cboEstado.Enabled = false;
            cboTipoCarga.Enabled = false;
            txtPatente.Enabled = false;
            txtPesoCarga.Enabled = false;
            btnAgregar.Enabled = false;
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
            foreach (DataGridViewRow row in dgvCargas.Rows)
            {
                if (row.Cells["columnaID"].Value == (cboTipoCarga.SelectedValue))
                {
                    MessageBox.Show("Este producto ya fue presupuestado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            nCarga.TipoCarga = tipoCarga;
            nCarga.Peso = peso;
            //Agrego la carga al Camion Y ademas al dgv!
            camionEditar.AgregarCarga(nCarga);
            dgvCargas.Rows.Add(new object[] { nCarga.TipoCarga, nCarga.Peso, textoTipo, "Quitar" });
            CalcularPesoRestante();
        }


        private void CalcularPesoRestante()
        {
            txtPesoRestante.Enabled = false;
            txtPesoRestante.Text = string.Empty;
            txtPesoRestante.Text = camionEditar.PesoRestante().ToString();
        }

        private void dgvCargas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Regresar?","Regresar",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
                this.Dispose();
        }
    }
}
