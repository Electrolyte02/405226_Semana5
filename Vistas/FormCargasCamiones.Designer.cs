namespace _405226_Problema_1._6_.Presentacion
{
    partial class FormCargasCamiones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCamionesNro = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.dgvCargas = new System.Windows.Forms.DataGridView();
            this.lblTipoCarga = new System.Windows.Forms.Label();
            this.cboTipoCarga = new System.Windows.Forms.ComboBox();
            this.lblPesoCarga = new System.Windows.Forms.Label();
            this.txtPesoCarga = new System.Windows.Forms.TextBox();
            this.lblPesoMaximo = new System.Windows.Forms.Label();
            this.txtPesoMaximo = new System.Windows.Forms.TextBox();
            this.lblKilosMaximos = new System.Windows.Forms.Label();
            this.lblKilosCarga = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPesoRestante = new System.Windows.Forms.Label();
            this.txtPesoRestante = new System.Windows.Forms.TextBox();
            this.columnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTipoCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblKilosRestantes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCamionesNro
            // 
            this.lblCamionesNro.AutoSize = true;
            this.lblCamionesNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblCamionesNro.Location = new System.Drawing.Point(110, 19);
            this.lblCamionesNro.Name = "lblCamionesNro";
            this.lblCamionesNro.Size = new System.Drawing.Size(96, 22);
            this.lblCamionesNro.TabIndex = 0;
            this.lblCamionesNro.Text = "Camion N°";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(58, 63);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(50, 13);
            this.lblPatente.TabIndex = 1;
            this.lblPatente.Text = "Patente :";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(114, 60);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(281, 20);
            this.txtPatente.TabIndex = 2;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(65, 105);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado ";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(114, 102);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(173, 21);
            this.cboEstado.TabIndex = 4;
            // 
            // dgvCargas
            // 
            this.dgvCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaID,
            this.columnaPeso,
            this.columnaTipoCarga,
            this.columnaAcciones});
            this.dgvCargas.Location = new System.Drawing.Point(38, 220);
            this.dgvCargas.Name = "dgvCargas";
            this.dgvCargas.Size = new System.Drawing.Size(551, 150);
            this.dgvCargas.TabIndex = 5;
            // 
            // lblTipoCarga
            // 
            this.lblTipoCarga.AutoSize = true;
            this.lblTipoCarga.Location = new System.Drawing.Point(12, 195);
            this.lblTipoCarga.Name = "lblTipoCarga";
            this.lblTipoCarga.Size = new System.Drawing.Size(62, 13);
            this.lblTipoCarga.TabIndex = 6;
            this.lblTipoCarga.Text = "Tipo Carga:";
            // 
            // cboTipoCarga
            // 
            this.cboTipoCarga.FormattingEnabled = true;
            this.cboTipoCarga.Location = new System.Drawing.Point(80, 193);
            this.cboTipoCarga.Name = "cboTipoCarga";
            this.cboTipoCarga.Size = new System.Drawing.Size(173, 21);
            this.cboTipoCarga.TabIndex = 7;
            // 
            // lblPesoCarga
            // 
            this.lblPesoCarga.AutoSize = true;
            this.lblPesoCarga.Location = new System.Drawing.Point(279, 195);
            this.lblPesoCarga.Name = "lblPesoCarga";
            this.lblPesoCarga.Size = new System.Drawing.Size(34, 13);
            this.lblPesoCarga.TabIndex = 8;
            this.lblPesoCarga.Text = "Peso:";
            // 
            // txtPesoCarga
            // 
            this.txtPesoCarga.Location = new System.Drawing.Point(319, 192);
            this.txtPesoCarga.Name = "txtPesoCarga";
            this.txtPesoCarga.Size = new System.Drawing.Size(161, 20);
            this.txtPesoCarga.TabIndex = 9;
            // 
            // lblPesoMaximo
            // 
            this.lblPesoMaximo.AutoSize = true;
            this.lblPesoMaximo.Location = new System.Drawing.Point(35, 143);
            this.lblPesoMaximo.Name = "lblPesoMaximo";
            this.lblPesoMaximo.Size = new System.Drawing.Size(73, 13);
            this.lblPesoMaximo.TabIndex = 10;
            this.lblPesoMaximo.Text = "Peso Maximo:";
            // 
            // txtPesoMaximo
            // 
            this.txtPesoMaximo.Location = new System.Drawing.Point(114, 140);
            this.txtPesoMaximo.Name = "txtPesoMaximo";
            this.txtPesoMaximo.Size = new System.Drawing.Size(173, 20);
            this.txtPesoMaximo.TabIndex = 11;
            // 
            // lblKilosMaximos
            // 
            this.lblKilosMaximos.AutoSize = true;
            this.lblKilosMaximos.Location = new System.Drawing.Point(293, 143);
            this.lblKilosMaximos.Name = "lblKilosMaximos";
            this.lblKilosMaximos.Size = new System.Drawing.Size(22, 13);
            this.lblKilosMaximos.TabIndex = 12;
            this.lblKilosMaximos.Text = "KG";
            // 
            // lblKilosCarga
            // 
            this.lblKilosCarga.AutoSize = true;
            this.lblKilosCarga.Location = new System.Drawing.Point(486, 195);
            this.lblKilosCarga.Name = "lblKilosCarga";
            this.lblKilosCarga.Size = new System.Drawing.Size(22, 13);
            this.lblKilosCarga.TabIndex = 13;
            this.lblKilosCarga.Text = "KG";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(514, 189);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(178, 432);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(123, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(342, 432);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblPesoRestante
            // 
            this.lblPesoRestante.AutoSize = true;
            this.lblPesoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPesoRestante.Location = new System.Drawing.Point(329, 386);
            this.lblPesoRestante.Name = "lblPesoRestante";
            this.lblPesoRestante.Size = new System.Drawing.Size(105, 17);
            this.lblPesoRestante.TabIndex = 17;
            this.lblPesoRestante.Text = "Peso Restante:";
            // 
            // txtPesoRestante
            // 
            this.txtPesoRestante.Location = new System.Drawing.Point(440, 386);
            this.txtPesoRestante.Name = "txtPesoRestante";
            this.txtPesoRestante.Size = new System.Drawing.Size(118, 20);
            this.txtPesoRestante.TabIndex = 18;
            // 
            // columnaID
            // 
            this.columnaID.HeaderText = "";
            this.columnaID.Name = "columnaID";
            this.columnaID.Visible = false;
            // 
            // columnaPeso
            // 
            this.columnaPeso.HeaderText = "Peso";
            this.columnaPeso.Name = "columnaPeso";
            // 
            // columnaTipoCarga
            // 
            this.columnaTipoCarga.HeaderText = "Tipo de Carga";
            this.columnaTipoCarga.Name = "columnaTipoCarga";
            // 
            // columnaAcciones
            // 
            this.columnaAcciones.HeaderText = "Acciones";
            this.columnaAcciones.Name = "columnaAcciones";
            // 
            // lblKilosRestantes
            // 
            this.lblKilosRestantes.AutoSize = true;
            this.lblKilosRestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKilosRestantes.Location = new System.Drawing.Point(561, 387);
            this.lblKilosRestantes.Name = "lblKilosRestantes";
            this.lblKilosRestantes.Size = new System.Drawing.Size(28, 17);
            this.lblKilosRestantes.TabIndex = 19;
            this.lblKilosRestantes.Text = "KG";
            // 
            // FormCargasCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 467);
            this.Controls.Add(this.lblKilosRestantes);
            this.Controls.Add(this.txtPesoRestante);
            this.Controls.Add(this.lblPesoRestante);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblKilosCarga);
            this.Controls.Add(this.lblKilosMaximos);
            this.Controls.Add(this.txtPesoMaximo);
            this.Controls.Add(this.lblPesoMaximo);
            this.Controls.Add(this.txtPesoCarga);
            this.Controls.Add(this.lblPesoCarga);
            this.Controls.Add(this.cboTipoCarga);
            this.Controls.Add(this.lblTipoCarga);
            this.Controls.Add(this.dgvCargas);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblCamionesNro);
            this.Name = "FormCargasCamiones";
            this.Text = "FormCargasCamiones";
            this.Load += new System.EventHandler(this.FormCargasCamiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCamionesNro;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.DataGridView dgvCargas;
        private System.Windows.Forms.Label lblTipoCarga;
        private System.Windows.Forms.ComboBox cboTipoCarga;
        private System.Windows.Forms.Label lblPesoCarga;
        private System.Windows.Forms.TextBox txtPesoCarga;
        private System.Windows.Forms.Label lblPesoMaximo;
        private System.Windows.Forms.TextBox txtPesoMaximo;
        private System.Windows.Forms.Label lblKilosMaximos;
        private System.Windows.Forms.Label lblKilosCarga;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPesoRestante;
        private System.Windows.Forms.TextBox txtPesoRestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTipoCarga;
        private System.Windows.Forms.DataGridViewButtonColumn columnaAcciones;
        private System.Windows.Forms.Label lblKilosRestantes;
    }
}