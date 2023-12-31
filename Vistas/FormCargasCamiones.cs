﻿using _405226_Problema_1._6_.Dominio;
using _405226_Problema_1._6_.Entidades;
using _405226_Problema_1._6_.Servicio.Implementacion;
using _405226_Problema_1._6_.Servicio.Interfaz;
using System;
using System.Data;
using System.Windows.Forms;

namespace _405226_Problema_1._6_.Presentacion
{
    public partial class FormCargasCamiones : Form
    {
        IServicio servicioDatos;
        Camion nuevoCamion;
        bool primerCarga;
        int iterar;
        public FormCargasCamiones()
        {
            InitializeComponent();
            servicioDatos = new Servicio.Implementacion.Servicio();
            nuevoCamion = new Camion();
            primerCarga = true;
            iterar = 1;
        }

        private void FormCargasCamiones_Load(object sender, EventArgs e)
        {
            lblCamionesNro.Text += servicioDatos.ObtenerNroProxCamion().ToString();
            cboEstado.DataSource = servicioDatos.TraerEstadosCamion();
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCarga.DataSource = servicioDatos.TraerTiposCarga();
            cboTipoCarga.DropDownStyle = ComboBoxStyle.DropDownList;
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
                if (row.Cells["columnaTipoCarga"].Value.ToString()==(cboTipoCarga.Text))
                {
                    MessageBox.Show("Esa carga ya fue colocada...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            //Creo un objeto de datarowview para dsp pasar al data grid view y casteo el tipo de carga como un item!
            TipoCarga item = (TipoCarga)cboTipoCarga.SelectedItem;
            double peso = Convert.ToDouble(txtPesoCarga.Text);
            //Creamos una carga y la pasamos al camion
            Carga nCarga = new Carga(iterar,peso, item);
            iterar++;
            //Agrego la carga al Camion Y ademas al dgv!
            nuevoCamion.AgregarCarga(nCarga);
            dgvCargas.Rows.Add(new object[] {nCarga.TipoCarga,nCarga.Peso,nCarga.TipoCarga.ToString(),"Quitar" });
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
            nuevoCamion.EstadoCamion = (EstadoCamion)cboEstado.SelectedValue;
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

        private void dgvCargas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCargas.CurrentCell.ColumnIndex == 3)
            {
                nuevoCamion.QuitarCarga(dgvCargas.CurrentRow.Index);
                dgvCargas.Rows.RemoveAt(dgvCargas.CurrentRow.Index);
                CalcularPesoRestante();
            }
        }
    }
}
