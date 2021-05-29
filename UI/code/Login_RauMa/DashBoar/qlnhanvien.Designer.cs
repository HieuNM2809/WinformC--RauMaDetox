
namespace DashBoar
{
    partial class QLNhanVien
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
            this.mnsQL_NhanVien = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlDKTK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlDMK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlQLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlTTNV = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_show = new System.Windows.Forms.Panel();
            this.mnsQL_NhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsQL_NhanVien
            // 
            this.mnsQL_NhanVien.BackColor = System.Drawing.Color.Transparent;
            this.mnsQL_NhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mnsQL_NhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsQL_NhanVien.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnsQL_NhanVien.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnsQL_NhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.tsmlQLNV});
            this.mnsQL_NhanVien.Location = new System.Drawing.Point(0, 0);
            this.mnsQL_NhanVien.Name = "mnsQL_NhanVien";
            this.mnsQL_NhanVien.Size = new System.Drawing.Size(1288, 36);
            this.mnsQL_NhanVien.TabIndex = 0;
            this.mnsQL_NhanVien.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmlDKTK,
            this.tsmlDMK});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(121, 32);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // tsmlDKTK
            // 
            this.tsmlDKTK.Enabled = false;
            this.tsmlDKTK.Name = "tsmlDKTK";
            this.tsmlDKTK.Size = new System.Drawing.Size(282, 36);
            this.tsmlDKTK.Text = "Đăng kí tài khoản";
            this.tsmlDKTK.Click += new System.EventHandler(this.đăngKíTàiKhoảnToolStripMenuItem_Click);
            // 
            // tsmlDMK
            // 
            this.tsmlDMK.Name = "tsmlDMK";
            this.tsmlDMK.Size = new System.Drawing.Size(282, 36);
            this.tsmlDMK.Text = "Đổi mật khẩu";
            this.tsmlDMK.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // tsmlQLNV
            // 
            this.tsmlQLNV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmlTTNV});
            this.tsmlQLNV.Enabled = false;
            this.tsmlQLNV.Name = "tsmlQLNV";
            this.tsmlQLNV.Size = new System.Drawing.Size(195, 32);
            this.tsmlQLNV.Text = "Quản lí nhân viên";
            // 
            // tsmlTTNV
            // 
            this.tsmlTTNV.Name = "tsmlTTNV";
            this.tsmlTTNV.Size = new System.Drawing.Size(305, 36);
            this.tsmlTTNV.Text = "Thông tin nhân viên";
            this.tsmlTTNV.Click += new System.EventHandler(this.thôngTinNhânViênToolStripMenuItem_Click);
            // 
            // panel_show
            // 
            this.panel_show.Location = new System.Drawing.Point(12, 39);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(1255, 991);
            this.panel_show.TabIndex = 1;
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1288, 1042);
            this.Controls.Add(this.panel_show);
            this.Controls.Add(this.mnsQL_NhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnsQL_NhanVien;
            this.Name = "QLNhanVien";
            this.Text = "QLNhanVien";
            this.Load += new System.EventHandler(this.QLNhanVien_Load);
            this.mnsQL_NhanVien.ResumeLayout(false);
            this.mnsQL_NhanVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsQL_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmlDKTK;
        private System.Windows.Forms.ToolStripMenuItem tsmlDMK;
        private System.Windows.Forms.ToolStripMenuItem tsmlQLNV;
        private System.Windows.Forms.ToolStripMenuItem tsmlTTNV;
        private System.Windows.Forms.Panel panel_show;
    }
}