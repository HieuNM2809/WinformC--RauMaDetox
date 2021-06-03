
namespace QLRauma
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radDSNV = new System.Windows.Forms.RadioButton();
            this.radDSNVTN = new System.Windows.Forms.RadioButton();
            this.cbbLoaiNV = new System.Windows.Forms.ComboBox();
            this.radDSNVTL = new System.Windows.Forms.RadioButton();
            this.radTTCT = new System.Windows.Forms.RadioButton();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLRauma.Properties.Resources.menu1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(131, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(204, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "BÁO CÁO";
            // 
            // radDSNV
            // 
            this.radDSNV.AutoSize = true;
            this.radDSNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.radDSNV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radDSNV.ForeColor = System.Drawing.Color.White;
            this.radDSNV.Location = new System.Drawing.Point(21, 188);
            this.radDSNV.Name = "radDSNV";
            this.radDSNV.Size = new System.Drawing.Size(257, 29);
            this.radDSNV.TabIndex = 2;
            this.radDSNV.TabStop = true;
            this.radDSNV.Text = "Xem danh sách nhân viên";
            this.radDSNV.UseVisualStyleBackColor = false;
            // 
            // radDSNVTN
            // 
            this.radDSNVTN.AutoSize = true;
            this.radDSNVTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.radDSNVTN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radDSNVTN.ForeColor = System.Drawing.Color.White;
            this.radDSNVTN.Location = new System.Drawing.Point(21, 290);
            this.radDSNVTN.Margin = new System.Windows.Forms.Padding(4);
            this.radDSNVTN.Name = "radDSNVTN";
            this.radDSNVTN.Size = new System.Drawing.Size(302, 29);
            this.radDSNVTN.TabIndex = 8;
            this.radDSNVTN.TabStop = true;
            this.radDSNVTN.Text = "Xem DSNV theo nhóm loại NV";
            this.radDSNVTN.UseVisualStyleBackColor = false;
            // 
            // cbbLoaiNV
            // 
            this.cbbLoaiNV.FormattingEnabled = true;
            this.cbbLoaiNV.Items.AddRange(new object[] {
            "Part time",
            "Full time"});
            this.cbbLoaiNV.Location = new System.Drawing.Point(273, 241);
            this.cbbLoaiNV.Name = "cbbLoaiNV";
            this.cbbLoaiNV.Size = new System.Drawing.Size(121, 28);
            this.cbbLoaiNV.TabIndex = 7;
            // 
            // radDSNVTL
            // 
            this.radDSNVTL.AutoSize = true;
            this.radDSNVTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.radDSNVTL.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radDSNVTL.ForeColor = System.Drawing.Color.White;
            this.radDSNVTL.Location = new System.Drawing.Point(21, 242);
            this.radDSNVTL.Margin = new System.Windows.Forms.Padding(4);
            this.radDSNVTL.Name = "radDSNVTL";
            this.radDSNVTL.Size = new System.Drawing.Size(245, 29);
            this.radDSNVTL.TabIndex = 6;
            this.radDSNVTL.TabStop = true;
            this.radDSNVTL.Text = "Xem DSNV theo loại NV";
            this.radDSNVTL.UseVisualStyleBackColor = false;
            // 
            // radTTCT
            // 
            this.radTTCT.AutoSize = true;
            this.radTTCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.radTTCT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radTTCT.ForeColor = System.Drawing.Color.White;
            this.radTTCT.Location = new System.Drawing.Point(21, 341);
            this.radTTCT.Margin = new System.Windows.Forms.Padding(4);
            this.radTTCT.Name = "radTTCT";
            this.radTTCT.Size = new System.Drawing.Size(316, 29);
            this.radTTCT.TabIndex = 9;
            this.radTTCT.TabStop = true;
            this.radTTCT.Text = "Xem thông tin chi tiết nhân viên";
            this.radTTCT.UseVisualStyleBackColor = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.White;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnXacNhan.Location = new System.Drawing.Point(195, 377);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(142, 49);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xem báo cáo";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThoat.Location = new System.Drawing.Point(353, 377);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(142, 49);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::QLRauma.Properties.Resources.avatar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 436);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.radTTCT);
            this.Controls.Add(this.radDSNVTN);
            this.Controls.Add(this.cbbLoaiNV);
            this.Controls.Add(this.radDSNVTL);
            this.Controls.Add(this.radDSNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radDSNV;
        private System.Windows.Forms.RadioButton radDSNVTN;
        private System.Windows.Forms.ComboBox cbbLoaiNV;
        private System.Windows.Forms.RadioButton radDSNVTL;
        private System.Windows.Forms.RadioButton radTTCT;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnThoat;
    }
}