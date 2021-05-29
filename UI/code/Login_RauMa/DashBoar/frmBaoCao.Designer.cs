
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
            "Part time",
            "Full time"});
            this.cbbLoaiNV.Location = new System.Drawing.Point(320, 343);
            this.cbbLoaiNV.Name = "cbbLoaiNV";
            this.cbbLoaiNV.Size = new System.Drawing.Size(111, 28);
            this.cbbLoaiNV.TabIndex = 10;
            // 
            // pnTieuDe
            // 
            this.pnTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTieuDe.Controls.Add(this.picLogo);
            this.pnTieuDe.Controls.Add(this.label3);
            this.pnTieuDe.Location = new System.Drawing.Point(135, 3);
            this.pnTieuDe.Name = "pnTieuDe";
            this.pnTieuDe.Size = new System.Drawing.Size(316, 177);
            this.pnTieuDe.TabIndex = 12;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::DashBoar.Properties.Resources.logoRauMa2;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picLogo.Location = new System.Drawing.Point(17, 16);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(284, 125);
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(91, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "BÁO CÁO";
            // 
            // radDSNV
            // 
            this.radDSNV.AutoSize = true;
            this.radDSNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.radDSNV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDSNV.ForeColor = System.Drawing.Color.White;
            this.radDSNV.Location = new System.Drawing.Point(30, 276);
            this.radDSNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radDSNV.Name = "radDSNV";
            this.radDSNV.Size = new System.Drawing.Size(300, 34);
            this.radDSNV.TabIndex = 13;
            this.radDSNV.Text = "Xem danh sách nhân viên";
            this.radDSNV.UseVisualStyleBackColor = false;
            // 
            // radDSNVTL
            // 
            this.radDSNVTL.AutoSize = true;
            this.radDSNVTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.radDSNVTL.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDSNVTL.ForeColor = System.Drawing.Color.White;
            this.radDSNVTL.Location = new System.Drawing.Point(30, 343);
            this.radDSNVTL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radDSNVTL.Name = "radDSNVTL";
            this.radDSNVTL.Size = new System.Drawing.Size(284, 34);
            this.radDSNVTL.TabIndex = 14;
            this.radDSNVTL.Text = "Xem DSNV theo loại NV";
            this.radDSNVTL.UseVisualStyleBackColor = false;
            // 
            // radDSNVTN
            // 
            this.radDSNVTN.AutoSize = true;
            this.radDSNVTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.radDSNVTN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDSNVTN.ForeColor = System.Drawing.Color.White;
            this.radDSNVTN.Location = new System.Drawing.Point(30, 415);
            this.radDSNVTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radDSNVTN.Name = "radDSNVTN";
            this.radDSNVTN.Size = new System.Drawing.Size(349, 34);
            this.radDSNVTN.TabIndex = 15;
            this.radDSNVTN.Text = "Xem DSNV theo nhóm loại NV";
            this.radDSNVTN.UseVisualStyleBackColor = false;
            // 
            // radTTCT
            // 
            this.radTTCT.AutoSize = true;
            this.radTTCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.radTTCT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTTCT.ForeColor = System.Drawing.Color.White;
            this.radTTCT.Location = new System.Drawing.Point(30, 484);
            this.radTTCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTTCT.Name = "radTTCT";
            this.radTTCT.Size = new System.Drawing.Size(370, 34);
            this.radTTCT.TabIndex = 16;
            this.radTTCT.Text = "Xem thông tin chi tiết nhân viên";
            this.radTTCT.UseVisualStyleBackColor = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.White;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnXacNhan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXacNhan.Location = new System.Drawing.Point(219, 524);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(160, 61);
            this.btnXacNhan.TabIndex = 17;
            this.btnXacNhan.Text = "Xem báo cáo";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoat.Location = new System.Drawing.Point(413, 524);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(166, 61);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DashBoar.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 604);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.radTTCT);
            this.Controls.Add(this.radDSNVTN);
            this.Controls.Add(this.radDSNVTL);
            this.Controls.Add(this.radDSNV);
            this.Controls.Add(this.pnTieuDe);
            this.Controls.Add(this.cbbLoaiNV);
            this.DoubleBuffered = true;
            this.Name = "frmBaoCao";
            this.Text = "frmXemBaoCao";
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