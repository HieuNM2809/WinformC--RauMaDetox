namespace DashBoar
{
    partial class frmDashboar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboar));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnQLTaiKhoan = new System.Windows.Forms.Button();
            this.pnlmenu1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lbltentaikhoan = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.pnlform = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlmenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.pnlMenu.Controls.Add(this.btnQLTaiKhoan);
            this.pnlMenu.Controls.Add(this.pnlmenu1);
            this.pnlMenu.Controls.Add(this.btnThoat);
            this.pnlMenu.Controls.Add(this.btnCaiDat);
            this.pnlMenu.Controls.Add(this.btnSanPham);
            this.pnlMenu.Controls.Add(this.btnHoaDon);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.Color.White;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(298, 695);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnQLTaiKhoan
            // 
            this.btnQLTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnQLTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnQLTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnQLTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnQLTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnQLTaiKhoan.Image = global::DashBoar.Properties.Resources.QLTaiKhoan;
            this.btnQLTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTaiKhoan.Location = new System.Drawing.Point(0, 225);
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            this.btnQLTaiKhoan.Size = new System.Drawing.Size(298, 60);
            this.btnQLTaiKhoan.TabIndex = 0;
            this.btnQLTaiKhoan.Text = "     Tài Khoản";
            this.btnQLTaiKhoan.UseVisualStyleBackColor = false;
            this.btnQLTaiKhoan.MouseEnter += new System.EventHandler(this.btnQLTaiKhoan_MouseEnter);
            this.btnQLTaiKhoan.MouseLeave += new System.EventHandler(this.btnQLTaiKhoan_MouseLeave);
            // 
            // pnlmenu1
            // 
            this.pnlmenu1.Controls.Add(this.btnMenu);
            this.pnlmenu1.Controls.Add(this.lblChucVu);
            this.pnlmenu1.Controls.Add(this.lblID);
            this.pnlmenu1.Controls.Add(this.lbltentaikhoan);
            this.pnlmenu1.Controls.Add(this.picAvatar);
            this.pnlmenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlmenu1.Location = new System.Drawing.Point(0, 0);
            this.pnlmenu1.Name = "pnlmenu1";
            this.pnlmenu1.Size = new System.Drawing.Size(298, 219);
            this.pnlmenu1.TabIndex = 13;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnMenu.BackgroundImage = global::DashBoar.Properties.Resources.menu1;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(13, 14);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(54, 45);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.Color.White;
            this.lblChucVu.Location = new System.Drawing.Point(150, 150);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(91, 24);
            this.lblChucVu.TabIndex = 11;
            this.lblChucVu.Text = "Chức Vụ";
            this.lblChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(184, 88);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(29, 24);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltentaikhoan
            // 
            this.lbltentaikhoan.AutoSize = true;
            this.lbltentaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltentaikhoan.ForeColor = System.Drawing.Color.White;
            this.lbltentaikhoan.Location = new System.Drawing.Point(124, 118);
            this.lbltentaikhoan.Name = "lbltentaikhoan";
            this.lbltentaikhoan.Size = new System.Drawing.Size(148, 24);
            this.lbltentaikhoan.TabIndex = 9;
            this.lbltentaikhoan.Text = "Tên Tài Khoản";
            this.lbltentaikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Image = global::DashBoar.Properties.Resources.avatar;
            this.picAvatar.Location = new System.Drawing.Point(-1, 88);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(103, 94);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::DashBoar.Properties.Resources.exits;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(0, 641);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(298, 54);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.MouseEnter += new System.EventHandler(this.btnThoat_MouseEnter);
            this.btnThoat.MouseLeave += new System.EventHandler(this.btnThoat_MouseLeave);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.FlatAppearance.BorderSize = 0;
            this.btnCaiDat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCaiDat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.ForeColor = System.Drawing.Color.White;
            this.btnCaiDat.Image = global::DashBoar.Properties.Resources.setting;
            this.btnCaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.Location = new System.Drawing.Point(0, 534);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(298, 60);
            this.btnCaiDat.TabIndex = 7;
            this.btnCaiDat.Text = "Cài Đặt";
            this.btnCaiDat.UseVisualStyleBackColor = false;
            this.btnCaiDat.MouseEnter += new System.EventHandler(this.btnCaiDat_MouseEnter);
            this.btnCaiDat.MouseLeave += new System.EventHandler(this.btnCaiDat_MouseLeave);
            // 
            // btnSanPham
            // 
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSanPham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.Image = global::DashBoar.Properties.Resources.product;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(-1, 433);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(298, 60);
            this.btnSanPham.TabIndex = 6;
            this.btnSanPham.Text = "    Sản Phẩm";
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.MouseEnter += new System.EventHandler(this.btnSanPham_MouseEnter);
            this.btnSanPham.MouseLeave += new System.EventHandler(this.btnSanPham_MouseLeave);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Image = global::DashBoar.Properties.Resources.bill;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(-1, 326);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(298, 60);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = "   Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.MouseEnter += new System.EventHandler(this.btnHoaDon_MouseEnter);
            this.btnHoaDon.MouseLeave += new System.EventHandler(this.btnHoaDon_MouseLeave);
            // 
            // pnlform
            // 
            this.pnlform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlform.ForeColor = System.Drawing.Color.Black;
            this.pnlform.Location = new System.Drawing.Point(298, 0);
            this.pnlform.Name = "pnlform";
            this.pnlform.Size = new System.Drawing.Size(1403, 695);
            this.pnlform.TabIndex = 3;
            // 
            // frmDashboar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 695);
            this.Controls.Add(this.pnlform);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboar";
            this.Text = "Rau Má Detox";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.pnlmenu1.ResumeLayout(false);
            this.pnlmenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Panel pnlform;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lbltentaikhoan;
        private System.Windows.Forms.Panel pnlmenu1;
        private System.Windows.Forms.Button btnQLTaiKhoan;
    }
}

