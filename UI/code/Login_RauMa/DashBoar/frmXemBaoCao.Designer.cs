
namespace DashBoar
{
    partial class frmXemBaoCao
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
            this.rptvXBC = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NhanVienDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptvXBC
            // 
            this.rptvXBC.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSNV";
            reportDataSource1.Value = this.NhanVienDTOBindingSource;
            this.rptvXBC.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvXBC.LocalReport.ReportEmbeddedResource = "DashBoar.rptDSNV.rdlc";
            this.rptvXBC.Location = new System.Drawing.Point(0, 0);
            this.rptvXBC.Name = "rptvXBC";
            this.rptvXBC.ServerReport.BearerToken = null;
            this.rptvXBC.Size = new System.Drawing.Size(777, 579);
            this.rptvXBC.TabIndex = 0;
            // 
            // NhanVienDTOBindingSource
            // 
            this.NhanVienDTOBindingSource.DataSource = typeof(DTO.NhanVienDTO);
            // 
            // frmXemBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 579);
            this.Controls.Add(this.rptvXBC);
            this.Name = "frmXemBaoCao";
            this.Text = "frmBaoCao";
            this.Load += new System.EventHandler(this.frmXemBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvXBC;
        private System.Windows.Forms.BindingSource NhanVienDTOBindingSource;
    }
}