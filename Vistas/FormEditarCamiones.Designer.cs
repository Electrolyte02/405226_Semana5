namespace _405226_Problema_1._6_.Vistas.Reportes
{
    partial class FormEditarCamiones
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
            this.lblNroCamion = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtPesoMaximo = new System.Windows.Forms.TextBox();
            this.lblPesoMaximoCamion = new System.Windows.Forms.Label();
            this.txtPesoRestante = new System.Windows.Forms.TextBox();
            this.lblPesoRestante = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblKilosPesoMaximo = new System.Windows.Forms.Label();
            this.dgvCargasCamiones = new System.Windows.Forms.DataGridView();
            this.cboTipoCarga = new System.Windows.Forms.ComboBox();
            this.lblTipoCarga = new System.Windows.Forms.Label();
            this.lblKilosPesoCarga = new System.Windows.Forms.Label();
            this.txtPesoCarga = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblKilosPesoRestante = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.columnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTipoCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasCamiones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNroCamion
            // 
            this.lblNroCamion.AutoSize = true;
            this.lblNroCamion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblNroCamion.Location = new System.Drawing.Point(44, 13);
            this.lblNroCamion.Name = "lblNroCamion";
            this.lblNroCamion.Size = new System.Drawing.Size(96, 22);
            this.lblNroCamion.TabIndex = 0;
            this.lblNroCamion.Text = "Camion N°";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(41, 64);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 1;
            this.lblPatente.Text = "Patente";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(88, 61);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(236, 20);
            this.txtPatente.TabIndex = 2;
            // 
            // txtPesoMaximo
            // 
            this.txtPesoMaximo.Location = new System.Drawing.Point(88, 144);
            this.txtPesoMaximo.Name = "txtPesoMaximo";
            this.txtPesoMaximo.Size = new System.Drawing.Size(162, 20);
            this.txtPesoMaximo.TabIndex = 4;
            // 
            // lblPesoMaximoCamion
            // 
            this.lblPesoMaximoCamion.AutoSize = true;
            this.lblPesoMaximoCamion.Location = new System.Drawing.Point(15, 148);
            this.lblPesoMaximoCamion.Name = "lblPesoMaximoCamion";
            this.lblPesoMaximoCamion.Size = new System.Drawing.Size(70, 13);
            this.lblPesoMaximoCamion.TabIndex = 3;
            this.lblPesoMaximoCamion.Text = "Peso Maximo";
            // 
            // txtPesoRestante
            // 
            this.txtPesoRestante.Location = new System.Drawing.Point(454, 409);
            this.txtPesoRestante.Name = "txtPesoRestante";
            this.txtPesoRestante.Size = new System.Drawing.Size(112, 20);
            this.txtPesoRestante.TabIndex = 6;
            // 
            // lblPesoRestante
            // 
            this.lblPesoRestante.AutoSize = true;
            this.lblPesoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPesoRestante.Location = new System.Drawing.Point(337, 409);
            this.lblPesoRestante.Name = "lblPesoRestante";
            this.lblPesoRestante.Size = new System.Drawing.Size(123, 20);
            this.lblPesoRestante.TabIndex = 5;
            this.lblPesoRestante.Text = "Peso Restante: ";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(45, 108);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(88, 104);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(162, 21);
            this.cboEstado.TabIndex = 8;
            // 
            // lblKilosPesoMaximo
            // 
            this.lblKilosPesoMaximo.AutoSize = true;
            this.lblKilosPesoMaximo.Location = new System.Drawing.Point(256, 148);
            this.lblKilosPesoMaximo.Name = "lblKilosPesoMaximo";
            this.lblKilosPesoMaximo.Size = new System.Drawing.Size(22, 13);
            this.lblKilosPesoMaximo.TabIndex = 9;
            this.lblKilosPesoMaximo.Text = "KG";
            // 
            // dgvCargasCamiones
            // 
            this.dgvCargasCamiones.AllowUserToAddRows = false;
            this.dgvCargasCamiones.AllowUserToDeleteRows = false;
            this.dgvCargasCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargasCamiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaID,
            this.columnaPeso,
            this.columnaTipoCarga,
            this.columnaAcciones});
            this.dgvCargasCamiones.Location = new System.Drawing.Point(35, 215);
            this.dgvCargasCamiones.Name = "dgvCargasCamiones";
            this.dgvCargasCamiones.ReadOnly = true;
            this.dgvCargasCamiones.Size = new System.Drawing.Size(548, 184);
            this.dgvCargasCamiones.TabIndex = 10;
            this.dgvCargasCamiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargasCamiones_CellContentClick);
            // 
            // cboTipoCarga
            // 
            this.cboTipoCarga.FormattingEnabled = true;
            this.cboTipoCarga.Location = new System.Drawing.Point(75, 188);
            this.cboTipoCarga.Name = "cboTipoCarga";
            this.cboTipoCarga.Size = new System.Drawing.Size(162, 21);
            this.cboTipoCarga.TabIndex = 12;
            // 
            // lblTipoCarga
            // 
            this.lblTipoCarga.AutoSize = true;
            this.lblTipoCarga.Location = new System.Drawing.Point(7, 191);
            this.lblTipoCarga.Name = "lblTipoCarga";
            this.lblTipoCarga.Size = new System.Drawing.Size(62, 13);
            this.lblTipoCarga.TabIndex = 11;
            this.lblTipoCarga.Text = "Tipo Carga:";
            // 
            // lblKilosPesoCarga
            // 
            this.lblKilosPesoCarga.AutoSize = true;
            this.lblKilosPesoCarga.Location = new System.Drawing.Point(467, 192);
            this.lblKilosPesoCarga.Name = "lblKilosPesoCarga";
            this.lblKilosPesoCarga.Size = new System.Drawing.Size(22, 13);
            this.lblKilosPesoCarga.TabIndex = 15;
            this.lblKilosPesoCarga.Text = "KG";
            // 
            // txtPesoCarga
            // 
            this.txtPesoCarga.Location = new System.Drawing.Point(299, 188);
            this.txtPesoCarga.Name = "txtPesoCarga";
            this.txtPesoCarga.Size = new System.Drawing.Size(162, 20);
            this.txtPesoCarga.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Peso:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(508, 188);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblKilosPesoRestante
            // 
            this.lblKilosPesoRestante.AutoSize = true;
            this.lblKilosPesoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblKilosPesoRestante.Location = new System.Drawing.Point(572, 407);
            this.lblKilosPesoRestante.Name = "lblKilosPesoRestante";
            this.lblKilosPesoRestante.Size = new System.Drawing.Size(32, 20);
            this.lblKilosPesoRestante.TabIndex = 17;
            this.lblKilosPesoRestante.Text = "KG";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(118, 440);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(132, 23);
            this.btnConfirmar.TabIndex = 18;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(370, 444);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // columnaID
            // 
            this.columnaID.HeaderText = "";
            this.columnaID.Name = "columnaID";
            this.columnaID.ReadOnly = true;
            this.columnaID.Visible = false;
            // 
            // columnaPeso
            // 
            this.columnaPeso.HeaderText = "Peso";
            this.columnaPeso.Name = "columnaPeso";
            this.columnaPeso.ReadOnly = true;
            this.columnaPeso.Width = 163;
            // 
            // columnaTipoCarga
            // 
            this.columnaTipoCarga.HeaderText = "Tipo Carga";
            this.columnaTipoCarga.Name = "columnaTipoCarga";
            this.columnaTipoCarga.ReadOnly = true;
            this.columnaTipoCarga.Width = 176;
            // 
            // columnaAcciones
            // 
            this.columnaAcciones.HeaderText = "Acciones";
            this.columnaAcciones.Name = "columnaAcciones";
            this.columnaAcciones.ReadOnly = true;
            this.columnaAcciones.Width = 165;
            // 
            // FormEditarCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 475);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblKilosPesoRestante);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblKilosPesoCarga);
            this.Controls.Add(this.txtPesoCarga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboTipoCarga);
            this.Controls.Add(this.lblTipoCarga);
            this.Controls.Add(this.dgvCargasCamiones);
            this.Controls.Add(this.lblKilosPesoMaximo);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtPesoRestante);
            this.Controls.Add(this.lblPesoRestante);
            this.Controls.Add(this.txtPesoMaximo);
            this.Controls.Add(this.lblPesoMaximoCamion);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblNroCamion);
            this.Name = "FormEditarCamiones";
            this.Text = "FormEditarCamiones";
            this.Load += new System.EventHandler(this.FormEditarCamiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargasCamiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroCamion;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtPesoMaximo;
        private System.Windows.Forms.Label lblPesoMaximoCamion;
        private System.Windows.Forms.TextBox txtPesoRestante;
        private System.Windows.Forms.Label lblPesoRestante;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblKilosPesoMaximo;
        private System.Windows.Forms.DataGridView dgvCargasCamiones;
        private System.Windows.Forms.ComboBox cboTipoCarga;
        private System.Windows.Forms.Label lblTipoCarga;
        private System.Windows.Forms.Label lblKilosPesoCarga;
        private System.Windows.Forms.TextBox txtPesoCarga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblKilosPesoRestante;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTipoCarga;
        private System.Windows.Forms.DataGridViewButtonColumn columnaAcciones;
    }
}