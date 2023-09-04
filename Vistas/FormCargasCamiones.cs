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
        bool primerCarga;
        public FormCargasCamiones()
        {
            InitializeComponent();
            servicioDatos = new DBHelper();
            nuevoCamion = new Camion();
            primerCarga = true;
        }

        private void FormCargasCamiones_Load(object sender, EventArgs e)
        {
            servicioDatos.NumeracionCamiones(lblCamionesNro);
            servicioDatos.cargarCombo(cboEstado, "SP_CONSULTAR_ESTADOS");
            servicioDatos.cargarCombo(cboTipoCarga, "SP_CONSULTAR_TIPOS_CARGA");
            txtPesoRestante.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboTipoCarga.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar un tipo de carga!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
            catch(Exception)
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

            if (primerCarga == true)
            {
                if (MessageBox.Show("Una vez agregada la primera carga no podra cambiar el peso maximo del camion!", "Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    nuevoCamion.PesoMaximo = Convert.ToInt32(txtPesoMaximo.Text);
                    txtPesoMaximo.Enabled = false;
                    primerCarga = false;
                }
            }
            if ((Convert.ToDouble(txtPesoCarga.Text)+nuevoCamion.CalcularTotal())> Convert.ToDouble(txtPesoMaximo.Text))
            {
                MessageBox.Show("No puede sumarse esa carga ya que supera el maximo del camion!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            AgregarCarga();
        }

        private void AgregarCarga()
        {
            foreach (DataGridViewRow row in dgvCargas.Rows)
            {
                if (row.Cells["columnaID"].Value.ToString() == (cboTipoCarga.Text))
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
            Carga nCarga = new Carga(peso, tipoCarga);
            //Agrego la carga al Camion Y ademas al dgv!
            nuevoCamion.AgregarCarga(nCarga);
            dgvCargas.Rows.Add(new object[] {nCarga.TipoCarga,nCarga.Peso,textoTipo,"Quitar" });
            CalcularPesoRestante();
        }

        private void CalcularPesoRestante()
        {
            txtPesoRestante.Enabled = false;
            txtPesoRestante.Text = string.Empty;
            txtPesoRestante.Text = nuevoCamion.PesoRestante().ToString();
        }

        private void GrabarCamion()
        {
            nuevoCamion.EstadoCamion = (int)cboEstado.SelectedValue;
            nuevoCamion.Patente = txtPatente.Text;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea cancelar el camion y su respectiva carga?","Cancelar",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GrabarCamion();
            if (servicioDatos.ConfirmarCamion(nuevoCamion))
            {
                MessageBox.Show("El camion ha sido cargado correctamente", "Exito", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("El camion no pudo ser cargado de manera correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
