namespace _405226_Problema_1._6_.Vistas
{
    partial class FormConsultarCargasCamiones
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblPesoMaximo = new System.Windows.Forms.Label();
            this.txtPesoMaximo = new System.Windows.Forms.TextBox();
            this.lblKilosPesoMaximo = new System.Windows.Forms.Label();
            this.lblTipoCarga = new System.Windows.Forms.Label();
            this.cboTipoCarga = new System.Windows.Forms.ComboBox();
            this.lblPesoCarga = new System.Windows.Forms.Label();
            this.txtPesoCarga = new System.Windows.Forms.TextBox();
            this.lblKilosPesoCarga = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvCargas = new System.Windows.Forms.DataGridView();
            this.ColumnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTipoCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblPesoRestante = new System.Windows.Forms.Label();
            this.txtPesoRestante = new System.Windows.Forms.TextBox();
            this.lblKilosPesoRestante = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNroCamion
            // 
            this.lblNroCamion.AutoSize = true;
            this.lblNroCamion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblNroCamion.Location = new System.Drawing.Point(112, 10);
            this.lblNroCamion.Name = "lblNroCamion";
            this.lblNroCamion.Size = new System.Drawing.Size(96, 22);
            this.lblNroCamion.TabIndex = 41;
            this.lblNroCamion.Text = "Camion N°";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(59, 55);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(47, 13);
            this.lblPatente.TabIndex = 42;
            this.lblPatente.Text = "Patente:";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(116, 52);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(280, 20);
            this.txtPatente.TabIndex = 43;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(63, 97);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 44;
            this.lblEstado.Text = "Estado:";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(116, 94);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(167, 21);
            this.cboEstado.TabIndex = 45;
            // 
            // lblPesoMaximo
            // 
            this.lblPesoMaximo.AutoSize = true;
            this.lblPesoMaximo.Location = new System.Drawing.Point(33, 133);
            this.lblPesoMaximo.Name = "lblPesoMaximo";
            this.lblPesoMaximo.Size = new System.Drawing.Size(73, 13);
            this.lblPesoMaximo.TabIndex = 46;
            this.lblPesoMaximo.Text = "Peso Maximo:";
            // 
            // txtPesoMaximo
            // 
            this.txtPesoMaximo.Location = new System.Drawing.Point(116, 133);
            this.txtPesoMaximo.Name = "txtPesoMaximo";
            this.txtPesoMaximo.Size = new System.Drawing.Size(167, 20);
            this.txtPesoMaximo.TabIndex = 47;
            // 
            // lblKilosPesoMaximo
            // 
            this.lblKilosPesoMaximo.AutoSize = true;
            this.lblKilosPesoMaximo.Location = new System.Drawing.Point(289, 136);
            this.lblKilosPesoMaximo.Name = "lblKilosPesoMaximo";
            this.lblKilosPesoMaximo.Size = new System.Drawing.Size(22, 13);
            this.lblKilosPesoMaximo.TabIndex = 48;
            this.lblKilosPesoMaximo.Text = "KG";
            // 
            // lblTipoCarga
            // 
            this.lblTipoCarga.AutoSize = true;
            this.lblTipoCarga.Location = new System.Drawing.Point(24, 183);
            this.lblTipoCarga.Name = "lblTipoCarga";
            this.lblTipoCarga.Size = new System.Drawing.Size(62, 13);
            this.lblTipoCarga.TabIndex = 49;
            this.lblTipoCarga.Text = "Tipo Carga:";
            // 
            // cboTipoCarga
            // 
            this.cboTipoCarga.FormattingEnabled = true;
            this.cboTipoCarga.Location = new System.Drawing.Point(92, 180);
            this.cboTipoCarga.Name = "cboTipoCarga";
            this.cboTipoCarga.Size = new System.Drawing.Size(203, 21);
            this.cboTipoCarga.TabIndex = 50;
            // 
            // lblPesoCarga
            // 
            this.lblPesoCarga.AutoSize = true;
            this.lblPesoCarga.Location = new System.Drawing.Point(301, 183);
            this.lblPesoCarga.Name = "lblPesoCarga";
            this.lblPesoCarga.Size = new System.Drawing.Size(34, 13);
            this.lblPesoCarga.TabIndex = 51;
            this.lblPesoCarga.Text = "Peso:";
            // 
            // txtPesoCarga
            // 
            this.txtPesoCarga.Location = new System.Drawing.Point(341, 181);
            this.txtPesoCarga.Name = "txtPesoCarga";
            this.txtPesoCarga.Size = new System.Drawing.Size(187, 20);
            this.txtPesoCarga.TabIndex = 52;
            // 
            // lblKilosPesoCarga
            // 
            this.lblKilosPesoCarga.AutoSize = true;
            this.lblKilosPesoCarga.Location = new System.Drawing.Point(535, 183);
            this.lblKilosPesoCarga.Name = "lblKilosPesoCarga";
            this.lblKilosPesoCarga.Size = new System.Drawing.Size(22, 13);
            this.lblKilosPesoCarga.TabIndex = 53;
            this.lblKilosPesoCarga.Text = "KG";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(563, 178);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 54;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvCargas
            // 
            this.dgvCargas.AllowUserToAddRows = false;
            this.dgvCargas.AllowUserToDeleteRows = false;
            this.dgvCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaId,
            this.ColumnaPeso,
            this.ColumnaTipoCarga,
            this.ColumnaAcciones});
            this.dgvCargas.Location = new System.Drawing.Point(36, 222);
            this.dgvCargas.Name = "dgvCargas";
            this.dgvCargas.ReadOnly = true;
            this.dgvCargas.Size = new System.Drawing.Size(573, 222);
            this.dgvCargas.TabIndex = 55;
            this.dgvCargas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargas_CellContentClick);
            // 
            // ColumnaId
            // 
            this.ColumnaId.HeaderText = "";
            this.ColumnaId.Name = "ColumnaId";
            this.ColumnaId.ReadOnly = true;
            this.ColumnaId.Visible = false;
            this.ColumnaId.Width = 140;
            // 
            // ColumnaPeso
            // 
            this.ColumnaPeso.HeaderText = "Peso";
            this.ColumnaPeso.Name = "ColumnaPeso";
            this.ColumnaPeso.ReadOnly = true;
            this.ColumnaPeso.Width = 180;
            // 
            // ColumnaTipoCarga
            // 
            this.ColumnaTipoCarga.HeaderText = "Tipo de Carga";
            this.ColumnaTipoCarga.Name = "ColumnaTipoCarga";
            this.ColumnaTipoCarga.ReadOnly = true;
            this.ColumnaTipoCarga.Width = 177;
            // 
            // ColumnaAcciones
            // 
            this.ColumnaAcciones.HeaderText = "Acciones";
            this.ColumnaAcciones.Name = "ColumnaAcciones";
            this.ColumnaAcciones.ReadOnly = true;
            this.ColumnaAcciones.Width = 170;
            // 
            // lblPesoRestante
            // 
            this.lblPesoRestante.AutoSize = true;
            this.lblPesoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPesoRestante.Location = new System.Drawing.Point(351, 448);
            this.lblPesoRestante.Name = "lblPesoRestante";
            this.lblPesoRestante.Size = new System.Drawing.Size(119, 20);
            this.lblPesoRestante.TabIndex = 56;
            this.lblPesoRestante.Text = "Peso Restante:";
            // 
            // txtPesoRestante
            // 
            this.txtPesoRestante.Location = new System.Drawing.Point(476, 450);
            this.txtPesoRestante.Name = "txtPesoRestante";
            this.txtPesoRestante.Size = new System.Drawing.Size(133, 20);
            this.txtPesoRestante.TabIndex = 57;
            // 
            // lblKilosPesoRestante
            // 
            this.lblKilosPesoRestante.AutoSize = true;
            this.lblKilosPesoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblKilosPesoRestante.Location = new System.Drawing.Point(615, 448);
            this.lblKilosPesoRestante.Name = "lblKilosPesoRestante";
            this.lblKilosPesoRestante.Size = new System.Drawing.Size(32, 20);
            this.lblKilosPesoRestante.TabIndex = 58;
            this.lblKilosPesoRestante.Text = "KG";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(259, 484);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(137, 23);
            this.btnRegresar.TabIndex = 60;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FormConsultarCargasCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 510);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblKilosPesoRestante);
            this.Controls.Add(this.txtPesoRestante);
            this.Controls.Add(this.lblPesoRestante);
            this.Controls.Add(this.dgvCargas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblKilosPesoCarga);
            this.Controls.Add(this.txtPesoCarga);
            this.Controls.Add(this.lblPesoCarga);
            this.Controls.Add(this.cboTipoCarga);
            this.Controls.Add(this.lblTipoCarga);
            this.Controls.Add(this.lblKilosPesoMaximo);
            this.Controls.Add(this.txtPesoMaximo);
            this.Controls.Add(this.lblPesoMaximo);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblNroCamion);
            this.Name = "FormConsultarCargasCamiones";
            this.Text = "FrmEditarCargasCamiones";
            this.Load += new System.EventHandler(this.FormEditarCargasCamiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNroCamion;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblPesoMaximo;
        private System.Windows.Forms.TextBox txtPesoMaximo;
        private System.Windows.Forms.Label lblKilosPesoMaximo;
        private System.Windows.Forms.Label lblTipoCarga;
        private System.Windows.Forms.ComboBox cboTipoCarga;
        private System.Windows.Forms.Label lblPesoCarga;
        private System.Windows.Forms.TextBox txtPesoCarga;
        private System.Windows.Forms.Label lblKilosPesoCarga;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvCargas;
        private System.Windows.Forms.Label lblPesoRestante;
        private System.Windows.Forms.TextBox txtPesoRestante;
        private System.Windows.Forms.Label lblKilosPesoRestante;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTipoCarga;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnaAcciones;
    }
}