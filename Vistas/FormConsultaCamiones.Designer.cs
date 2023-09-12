namespace _405226_Problema_1._6_.Vistas
{
    partial class FormConsultaCamiones
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
            this.lblCamiones = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.dgvConsultaCamion = new System.Windows.Forms.DataGridView();
            this.ColumnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPesoMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblPesoMaximo = new System.Windows.Forms.Label();
            this.txtPesoMaximo = new System.Windows.Forms.TextBox();
            this.rbtMayor = new System.Windows.Forms.RadioButton();
            this.rbtMenor = new System.Windows.Forms.RadioButton();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.chkPesoMaximo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCamion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCamiones
            // 
            this.lblCamiones.AutoSize = true;
            this.lblCamiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblCamiones.Location = new System.Drawing.Point(233, 9);
            this.lblCamiones.Name = "lblCamiones";
            this.lblCamiones.Size = new System.Drawing.Size(90, 22);
            this.lblCamiones.TabIndex = 0;
            this.lblCamiones.Text = "Camiones";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(129, 49);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(47, 13);
            this.lblPatente.TabIndex = 1;
            this.lblPatente.Text = "Patente:";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(183, 46);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(229, 20);
            this.txtPatente.TabIndex = 2;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(133, 83);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado:";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(183, 83);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(229, 21);
            this.cboEstado.TabIndex = 4;
            // 
            // dgvConsultaCamion
            // 
            this.dgvConsultaCamion.AllowUserToAddRows = false;
            this.dgvConsultaCamion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCamion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaId,
            this.ColumnaPatente,
            this.ColumnaEstado,
            this.ColumnaPesoMaximo,
            this.ColumnaAcciones});
            this.dgvConsultaCamion.Location = new System.Drawing.Point(33, 193);
            this.dgvConsultaCamion.Name = "dgvConsultaCamion";
            this.dgvConsultaCamion.Size = new System.Drawing.Size(544, 150);
            this.dgvConsultaCamion.TabIndex = 5;
            this.dgvConsultaCamion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaCamion_CellContentClick);
            // 
            // ColumnaId
            // 
            this.ColumnaId.HeaderText = "";
            this.ColumnaId.Name = "ColumnaId";
            this.ColumnaId.Visible = false;
            // 
            // ColumnaPatente
            // 
            this.ColumnaPatente.HeaderText = "Patente";
            this.ColumnaPatente.Name = "ColumnaPatente";
            this.ColumnaPatente.Width = 140;
            // 
            // ColumnaEstado
            // 
            this.ColumnaEstado.HeaderText = "Estado";
            this.ColumnaEstado.Name = "ColumnaEstado";
            this.ColumnaEstado.Width = 140;
            // 
            // ColumnaPesoMaximo
            // 
            this.ColumnaPesoMaximo.HeaderText = "Peso Maximo";
            this.ColumnaPesoMaximo.Name = "ColumnaPesoMaximo";
            this.ColumnaPesoMaximo.Width = 105;
            // 
            // ColumnaAcciones
            // 
            this.ColumnaAcciones.HeaderText = "Acciones";
            this.ColumnaAcciones.Name = "ColumnaAcciones";
            this.ColumnaAcciones.Width = 115;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(477, 164);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblPesoMaximo
            // 
            this.lblPesoMaximo.AutoSize = true;
            this.lblPesoMaximo.Location = new System.Drawing.Point(103, 119);
            this.lblPesoMaximo.Name = "lblPesoMaximo";
            this.lblPesoMaximo.Size = new System.Drawing.Size(73, 13);
            this.lblPesoMaximo.TabIndex = 7;
            this.lblPesoMaximo.Text = "Peso Maximo:";
            // 
            // txtPesoMaximo
            // 
            this.txtPesoMaximo.Location = new System.Drawing.Point(183, 116);
            this.txtPesoMaximo.Name = "txtPesoMaximo";
            this.txtPesoMaximo.Size = new System.Drawing.Size(229, 20);
            this.txtPesoMaximo.TabIndex = 8;
            // 
            // rbtMayor
            // 
            this.rbtMayor.AutoSize = true;
            this.rbtMayor.Location = new System.Drawing.Point(183, 167);
            this.rbtMayor.Name = "rbtMayor";
            this.rbtMayor.Size = new System.Drawing.Size(63, 17);
            this.rbtMayor.TabIndex = 9;
            this.rbtMayor.TabStop = true;
            this.rbtMayor.Text = "Mayor a";
            this.rbtMayor.UseVisualStyleBackColor = true;
            // 
            // rbtMenor
            // 
            this.rbtMenor.AutoSize = true;
            this.rbtMenor.Location = new System.Drawing.Point(348, 167);
            this.rbtMenor.Name = "rbtMenor";
            this.rbtMenor.Size = new System.Drawing.Size(64, 17);
            this.rbtMenor.TabIndex = 10;
            this.rbtMenor.TabStop = true;
            this.rbtMenor.Text = "Menor a";
            this.rbtMenor.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(477, 350);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 23);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // chkPesoMaximo
            // 
            this.chkPesoMaximo.AutoSize = true;
            this.chkPesoMaximo.Location = new System.Drawing.Point(183, 143);
            this.chkPesoMaximo.Name = "chkPesoMaximo";
            this.chkPesoMaximo.Size = new System.Drawing.Size(160, 17);
            this.chkPesoMaximo.TabIndex = 12;
            this.chkPesoMaximo.Text = "Chequear por peso maximo?";
            this.chkPesoMaximo.UseVisualStyleBackColor = true;
            this.chkPesoMaximo.CheckedChanged += new System.EventHandler(this.chkPesoMaximo_CheckedChanged);
            // 
            // FormConsultaCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 382);
            this.Controls.Add(this.chkPesoMaximo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.rbtMenor);
            this.Controls.Add(this.rbtMayor);
            this.Controls.Add(this.txtPesoMaximo);
            this.Controls.Add(this.lblPesoMaximo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsultaCamion);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblCamiones);
            this.Name = "FormConsultaCamiones";
            this.Text = "FormConsultaCamiones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCamion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCamiones;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.DataGridView dgvConsultaCamion;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblPesoMaximo;
        private System.Windows.Forms.TextBox txtPesoMaximo;
        private System.Windows.Forms.RadioButton rbtMayor;
        private System.Windows.Forms.RadioButton rbtMenor;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPesoMaximo;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnaAcciones;
        private System.Windows.Forms.CheckBox chkPesoMaximo;
    }
}