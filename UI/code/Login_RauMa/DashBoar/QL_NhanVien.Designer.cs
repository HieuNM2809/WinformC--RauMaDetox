
namespace DashBoar
{
    partial class QL_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_NhanVien));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MemuItemDangKiTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemThongTinNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.ChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_show = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.ChucNang});
            this.menuStrip1.Location = new System.Drawing.Point(48, 82);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MemuItemDangKiTaiKhoan,
            this.MenuItemDoiMatKhau});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // MemuItemDangKiTaiKhoan
            // 
            this.MemuItemDangKiTaiKhoan.Name = "MemuItemDangKiTaiKhoan";
            this.MemuItemDangKiTaiKhoan.Size = new System.Drawing.Size(270, 34);
            this.MemuItemDangKiTaiKhoan.Text = "Đăng kí tài khoản";
            this.MemuItemDangKiTaiKhoan.Click += new System.EventHandler(this.đăngKíTàiKhoảnToolStripMenuItem_Click);
            // 
            // MenuItemDoiMatKhau
            // 
            this.MenuItemDoiMatKhau.Name = "MenuItemDoiMatKhau";
            this.MenuItemDoiMatKhau.Size = new System.Drawing.Size(270, 34);
            this.MenuItemDoiMatKhau.Text = "Đổi mật khẩu";
            this.MenuItemDoiMatKhau.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem1_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemThongTinNhanVien});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // MenuItemThongTinNhanVien
            // 
            this.MenuItemThongTinNhanVien.Name = "MenuItemThongTinNhanVien";
            this.MenuItemThongTinNhanVien.Size = new System.Drawing.Size(271, 34);
            this.MenuItemThongTinNhanVien.Text = "Thông tin nhân viên";
            this.MenuItemThongTinNhanVien.Click += new System.EventHandler(this.thôngTinNhânViênToolStripMenuItem_Click);
            // 
            // ChucNang
            // 
            this.ChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoToolStripMenuItem});
            this.ChucNang.Name = "ChucNang";
            this.ChucNang.Size = new System.Drawing.Size(113, 29);
            this.ChucNang.Text = "Chức năng";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // panel_show
            // 
            this.panel_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_show.Location = new System.Drawing.Point(162, 165);
            this.panel_show.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(1136, 591);
            this.panel_show.TabIndex = 19;
            // 
            // QL_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1320, 828);
            this.Controls.Add(this.panel_show);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QL_NhanVien";
            this.Text = "QL_NhanVien";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MemuItemDangKiTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemThongTinNhanVien;
        private System.Windows.Forms.ToolStripMenuItem ChucNang;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.Panel panel_show;
    }
}