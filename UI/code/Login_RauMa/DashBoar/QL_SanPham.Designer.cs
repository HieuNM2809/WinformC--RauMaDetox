namespace DashBoar
{
    partial class QL_SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_SanPham));
            this.admin_masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.DTGV_xem = new System.Windows.Forms.DataGridView();
            this.xem_masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xem_tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xem_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xem_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xem_trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xem_mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_xem)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_masp
            // 
            this.admin_masp.HeaderText = "Mã sản phẩm";
            this.admin_masp.MinimumWidth = 6;
            this.admin_masp.Name = "admin_masp";
            this.admin_masp.Width = 125;
            // 
            // admin_loai
            // 
            this.admin_loai.HeaderText = "Loai";
            this.admin_loai.MinimumWidth = 6;
            this.admin_loai.Name = "admin_loai";
            this.admin_loai.Width = 125;
            // 
            // admin_mota
            // 
            this.admin_mota.HeaderText = "Mô tả";
            this.admin_mota.MinimumWidth = 6;
            this.admin_mota.Name = "admin_mota";
            this.admin_mota.Width = 125;
            // 
            // admin_trangthai
            // 
            this.admin_trangthai.HeaderText = "Trạng thái";
            this.admin_trangthai.MinimumWidth = 6;
            this.admin_trangthai.Name = "admin_trangthai";
            this.admin_trangthai.Width = 125;
            // 
            // admin_gia
            // 
            this.admin_gia.HeaderText = "Giá";
            this.admin_gia.MinimumWidth = 6;
            this.admin_gia.Name = "admin_gia";
            this.admin_gia.Width = 125;
            // 
            // admin_tensp
            // 
            this.admin_tensp.HeaderText = "Tên sản phẩm";
            this.admin_tensp.MinimumWidth = 6;
            this.admin_tensp.Name = "admin_tensp";
            this.admin_tensp.Width = 125;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(413, 714);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(130, 60);
            this.btn_them.TabIndex = 101;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(575, 714);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(130, 60);
            this.btn_xoa.TabIndex = 100;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_sua.FlatAppearance.BorderSize = 0;
            this.btn_sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(726, 714);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(130, 60);
            this.btn_sua.TabIndex = 99;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(875, 714);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(130, 60);
            this.btn_thoat.TabIndex = 98;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // DTGV_xem
            // 
            this.DTGV_xem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTGV_xem.BackgroundColor = System.Drawing.Color.White;
            this.DTGV_xem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_xem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xem_masp,
            this.xem_tensp,
            this.xem_gia,
            this.xem_loai,
            this.xem_trangthai,
            this.xem_mota});
            this.DTGV_xem.Location = new System.Drawing.Point(1, 410);
            this.DTGV_xem.Name = "DTGV_xem";
            this.DTGV_xem.RowHeadersVisible = false;
            this.DTGV_xem.RowHeadersWidth = 51;
            this.DTGV_xem.RowTemplate.Height = 24;
            this.DTGV_xem.Size = new System.Drawing.Size(1011, 298);
            this.DTGV_xem.TabIndex = 97;
            // 
            // xem_masp
            // 
            this.xem_masp.HeaderText = "Mã sản phẩm";
            this.xem_masp.MinimumWidth = 6;
            this.xem_masp.Name = "xem_masp";
            // 
            // xem_tensp
            // 
            this.xem_tensp.HeaderText = "Tên sản phẩm";
            this.xem_tensp.MinimumWidth = 6;
            this.xem_tensp.Name = "xem_tensp";
            // 
            // xem_gia
            // 
            this.xem_gia.HeaderText = "Giá";
            this.xem_gia.MinimumWidth = 6;
            this.xem_gia.Name = "xem_gia";
            // 
            // xem_loai
            // 
            this.xem_loai.HeaderText = "Loai";
            this.xem_loai.MinimumWidth = 6;
            this.xem_loai.Name = "xem_loai";
            // 
            // xem_trangthai
            // 
            this.xem_trangthai.HeaderText = "Trạng thái";
            this.xem_trangthai.MinimumWidth = 6;
            this.xem_trangthai.Name = "xem_trangthai";
            // 
            // xem_mota
            // 
            this.xem_mota.HeaderText = "Mô tả";
            this.xem_mota.MinimumWidth = 6;
            this.xem_mota.Name = "xem_mota";
            // 
            // QL_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1017, 790);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.DTGV_xem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "QL_SanPham";
            this.Text = "QL_SanPham";
            this.Load += new System.EventHandler(this.QL_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_xem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_tensp;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView DTGV_xem;
        private System.Windows.Forms.DataGridViewTextBoxColumn xem_masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn xem_tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn xem_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn xem_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn xem_trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn xem_mota;
    }
}