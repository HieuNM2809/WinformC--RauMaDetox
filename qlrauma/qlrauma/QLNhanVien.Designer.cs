
namespace qlrauma
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlDKTK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlDMK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlQLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlTTNV = new System.Windows.Forms.ToolStripMenuItem();
            this.tmslBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_show = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.tsmlQLNV,
            this.tmslBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1127, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmlDKTK,
            this.tsmlDMK});
            this.tàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(102, 27);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // tsmlDKTK
            // 
            this.tsmlDKTK.Name = "tsmlDKTK";
            this.tsmlDKTK.Size = new System.Drawing.Size(237, 28);
            this.tsmlDKTK.Text = "Đăng kí tài khoản";
            this.tsmlDKTK.Click += new System.EventHandler(this.đăngKíTàiKhoảnToolStripMenuItem_Click);
            // 
            // tsmlDMK
            // 
            this.tsmlDMK.Name = "tsmlDMK";
            this.tsmlDMK.Size = new System.Drawing.Size(237, 28);
            this.tsmlDMK.Text = "Đổi mật khẩu";
            this.tsmlDMK.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // tsmlQLNV
            // 
            this.tsmlQLNV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmlTTNV});
            this.tsmlQLNV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmlQLNV.Name = "tsmlQLNV";
            this.tsmlQLNV.Size = new System.Drawing.Size(165, 27);
            this.tsmlQLNV.Text = "Quản lý tài khoản";
            // 
            // tsmlTTNV
            // 
            this.tsmlTTNV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmlTTNV.Name = "tsmlTTNV";
            this.tsmlTTNV.Size = new System.Drawing.Size(254, 28);
            this.tsmlTTNV.Text = "Thông tin nhân viên";
            this.tsmlTTNV.Click += new System.EventHandler(this.thôngTinNhânViênToolStripMenuItem_Click);
            // 
            // tmslBaoCao
            // 
            this.tmslBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tmslBaoCao.Name = "tmslBaoCao";
            this.tmslBaoCao.Size = new System.Drawing.Size(86, 27);
            this.tmslBaoCao.Text = "Báo cáo";
            // 
            // panel_show
            // 
            this.panel_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_show.Location = new System.Drawing.Point(0, 31);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(1127, 805);
            this.panel_show.TabIndex = 1;
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1127, 836);
            this.Controls.Add(this.panel_show);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QLNhanVien";
            this.Text = "QLNhanVien";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmlDKTK;
        private System.Windows.Forms.ToolStripMenuItem tsmlDMK;
        private System.Windows.Forms.ToolStripMenuItem tsmlQLNV;
        private System.Windows.Forms.ToolStripMenuItem tsmlTTNV;
        private System.Windows.Forms.ToolStripMenuItem tmslBaoCao;
        private System.Windows.Forms.Panel panel_show;
    }
}