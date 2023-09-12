namespace _405226_Problema_1._6_.Vistas
{
    partial class FormReporteCantidadTipoCarga
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSTipoCargasCamiones = new _405226_Problema_1._6_.Vistas.Reportes.DSTipoCargasCamiones();
            this.dSTipoCargasCamionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCANTCARGASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_CANT_CARGASTableAdapter = new _405226_Problema_1._6_.Vistas.Reportes.DSTipoCargasCamionesTableAdapters.T_CANT_CARGASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSTipoCargasCamiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTipoCargasCamionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCANTCARGASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tCANTCARGASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_405226_Problema_1._6_.Vistas.Reportes.ReportTipoCargas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(665, 352);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSTipoCargasCamiones
            // 
            this.dSTipoCargasCamiones.DataSetName = "DSTipoCargasCamiones";
            this.dSTipoCargasCamiones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSTipoCargasCamionesBindingSource
            // 
            this.dSTipoCargasCamionesBindingSource.DataSource = this.dSTipoCargasCamiones;
            this.dSTipoCargasCamionesBindingSource.Position = 0;
            // 
            // tCANTCARGASBindingSource
            // 
            this.tCANTCARGASBindingSource.DataMember = "T_CANT_CARGAS";
            this.tCANTCARGASBindingSource.DataSource = this.dSTipoCargasCamiones;
            // 
            // t_CANT_CARGASTableAdapter
            // 
            this.t_CANT_CARGASTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteCantidadTipoCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 370);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteCantidadTipoCarga";
            this.Text = "FormReporteCantidadTipoCarga";
            this.Load += new System.EventHandler(this.FormReporteCantidadTipoCarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSTipoCargasCamiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTipoCargasCamionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCANTCARGASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dSTipoCargasCamionesBindingSource;
        private Reportes.DSTipoCargasCamiones dSTipoCargasCamiones;
        private System.Windows.Forms.BindingSource tCANTCARGASBindingSource;
        private Reportes.DSTipoCargasCamionesTableAdapters.T_CANT_CARGASTableAdapter t_CANT_CARGASTableAdapter;
    }
}