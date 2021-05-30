
namespace DashBoar
{
    partial class frmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.cbbLoaiNV = new System.Windows.Forms.ComboBox();
            this.pnTieuDe = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radDSNV = new System.Windows.Forms.RadioButton();
            this.radDSNVTL = new System.Windows.Forms.RadioButton();
            this.radDSNVTN = new System.Windows.Forms.RadioButton();
            this.radTTCT = new System.Windows.Forms.RadioButton();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbLoaiNV
            // 
            this.cbbLoaiNV.FormattingEnabled = true;
            this.cbbLoaiNV.Items.AddRange(new object[] {
            resources.GetString("cbbLoaiNV.Items"),
            resources.GetString("cbbLoaiNV.Items1")});
            resources.ApplyResources(this.cbbLoaiNV, "cbbLoaiNV");
            this.cbbLoaiNV.Name = "cbbLoaiNV";
            // 
            // pnTieuDe
            // 
            resources.ApplyResources(this.pnTieuDe, "pnTieuDe");
            this.pnTieuDe.Controls.Add(this.picLogo);
            this.pnTieuDe.Controls.Add(this.label3);
            this.pnTieuDe.Name = "pnTieuDe";
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::DashBoar.Properties.Resources.logoRauMa2;
            resources.ApplyResources(this.picLogo, "picLogo");
            this.picLogo.Name = "picLogo";
            this.picLogo.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.label3.Name = "label3";
            // 
            // radDSNV
            // 
            resources.ApplyResources(this.radDSNV, "radDSNV");
            this.radDSNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.radDSNV.ForeColor = System.Drawing.Color.White;
            this.radDSNV.Name = "radDSNV";
            this.radDSNV.UseVisualStyleBackColor = false;
            // 
            // radDSNVTL
            // 
            resources.ApplyResources(this.radDSNVTL, "radDSNVTL");
            this.radDSNVTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.radDSNVTL.ForeColor = System.Drawing.Color.White;
            this.radDSNVTL.Name = "radDSNVTL";
            this.radDSNVTL.UseVisualStyleBackColor = false;
            // 
            // radDSNVTN
            // 
            resources.ApplyResources(this.radDSNVTN, "radDSNVTN");
            this.radDSNVTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.radDSNVTN.ForeColor = System.Drawing.Color.White;
            this.radDSNVTN.Name = "radDSNVTN";
            this.radDSNVTN.UseVisualStyleBackColor = false;
            // 
            // radTTCT
            // 
            resources.ApplyResources(this.radTTCT, "radTTCT");
            this.radTTCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.radTTCT.ForeColor = System.Drawing.Color.White;
            this.radTTCT.Name = "radTTCT";
            this.radTTCT.UseVisualStyleBackColor = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.White;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnXacNhan, "btnXacNhan");
            this.btnXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBaoCao
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DashBoar.Properties.Resources.background;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.radTTCT);
            this.Controls.Add(this.radDSNVTN);
            this.Controls.Add(this.radDSNVTL);
            this.Controls.Add(this.radDSNV);
            this.Controls.Add(this.pnTieuDe);
            this.Controls.Add(this.cbbLoaiNV);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCao";
            this.pnTieuDe.ResumeLayout(false);
            this.pnTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbLoaiNV;
        private System.Windows.Forms.Panel pnTieuDe;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radDSNV;
        private System.Windows.Forms.RadioButton radDSNVTL;
        private System.Windows.Forms.RadioButton radDSNVTN;
        private System.Windows.Forms.RadioButton radTTCT;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnThoat;
    }
}