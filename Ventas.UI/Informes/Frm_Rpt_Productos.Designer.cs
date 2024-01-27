namespace Ventas.UI.Informes
{
    partial class Frm_Rpt_Productos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.articulosTableAdapter1 = new Ventas.UI.dbsistemaventasDataSetTableAdapters.articulosTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbsistemaventasDataSet = new Ventas.UI.dbsistemaventasDataSet();
            this.dbsistemaventasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spProductosTableAdapter1 = new Ventas.UI.Informes.DsVentasTableAdapters.spProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbsistemaventasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsistemaventasDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // articulosTableAdapter1
            // 
            this.articulosTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.dbsistemaventasDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ventas.UI.Informes.InformeProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(52, 47);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(652, 360);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dbsistemaventasDataSet
            // 
            this.dbsistemaventasDataSet.DataSetName = "dbsistemaventasDataSet";
            this.dbsistemaventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbsistemaventasDataSetBindingSource
            // 
            this.dbsistemaventasDataSetBindingSource.DataSource = this.dbsistemaventasDataSet;
            this.dbsistemaventasDataSetBindingSource.Position = 0;
            // 
            // spProductosTableAdapter1
            // 
            this.spProductosTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_Rpt_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Productos";
            this.Text = "Frm_Rpt_Productos";
            this.Load += new System.EventHandler(this.Frm_Rpt_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbsistemaventasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsistemaventasDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dbsistemaventasDataSetTableAdapters.articulosTableAdapter articulosTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dbsistemaventasDataSetBindingSource;
        private dbsistemaventasDataSet dbsistemaventasDataSet;
        private DsVentasTableAdapters.spProductosTableAdapter spProductosTableAdapter1;
    }
}