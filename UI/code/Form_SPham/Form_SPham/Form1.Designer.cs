
namespace Form_SPham
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_taikhoan = new System.Windows.Forms.Button();
            this.ptB_avt = new System.Windows.Forms.PictureBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_caidat = new System.Windows.Forms.Button();
            this.btn_hoadon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_logo = new System.Windows.Forms.Button();
            this.dgv_dsSanPham = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_avt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.btn_taikhoan);
            this.panel1.Controls.Add(this.ptB_avt);
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.btn_caidat);
            this.panel1.Controls.Add(this.btn_hoadon);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 648);
            this.panel1.TabIndex = 0;
            // 
            // btn_taikhoan
            // 
            this.btn_taikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_taikhoan.FlatAppearance.BorderSize = 0;
            this.btn_taikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_taikhoan.ForeColor = System.Drawing.Color.White;
            this.btn_taikhoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_taikhoan.Image")));
            this.btn_taikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taikhoan.Location = new System.Drawing.Point(0, 215);
            this.btn_taikhoan.Name = "btn_taikhoan";
            this.btn_taikhoan.Size = new System.Drawing.Size(276, 72);
            this.btn_taikhoan.TabIndex = 19;
            this.btn_taikhoan.Text = "Quản lý tài khoản";
            this.btn_taikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_taikhoan.UseVisualStyleBackColor = false;
            // 
            // ptB_avt
            // 
            this.ptB_avt.BackgroundImage = global::Form_SPham.Properties.Resources.avatar2;
            this.ptB_avt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptB_avt.Location = new System.Drawing.Point(100, 11);
            this.ptB_avt.Name = "ptB_avt";
            this.ptB_avt.Size = new System.Drawing.Size(71, 58);
            this.ptB_avt.TabIndex = 23;
            this.ptB_avt.TabStop = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(0, 534);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(276, 72);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            // 
            // btn_caidat
            // 
            this.btn_caidat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_caidat.FlatAppearance.BorderSize = 0;
            this.btn_caidat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_caidat.ForeColor = System.Drawing.Color.White;
            this.btn_caidat.Image = ((System.Drawing.Image)(resources.GetObject("btn_caidat.Image")));
            this.btn_caidat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_caidat.Location = new System.Drawing.Point(0, 434);
            this.btn_caidat.Name = "btn_caidat";
            this.btn_caidat.Size = new System.Drawing.Size(276, 72);
            this.btn_caidat.TabIndex = 2;
            this.btn_caidat.Text = "Cài đặt";
            this.btn_caidat.UseVisualStyleBackColor = false;
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_hoadon.FlatAppearance.BorderSize = 0;
            this.btn_hoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hoadon.ForeColor = System.Drawing.Color.White;
            this.btn_hoadon.Image = ((System.Drawing.Image)(resources.GetObject("btn_hoadon.Image")));
            this.btn_hoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hoadon.Location = new System.Drawing.Point(0, 315);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Size = new System.Drawing.Size(276, 72);
            this.btn_hoadon.TabIndex = 4;
            this.btn_hoadon.Text = "Quản lý hóa đơn";
            this.btn_hoadon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hoadon.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(39, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 4);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(96, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(630, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Danh sách sẩn phẩm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            this.imageList1.Images.SetKeyName(3, "4.png");
            this.imageList1.Images.SetKeyName(4, "5.png");
            this.imageList1.Images.SetKeyName(5, "6.png");
            this.imageList1.Images.SetKeyName(6, "7.png");
            this.imageList1.Images.SetKeyName(7, "8.png");
            this.imageList1.Images.SetKeyName(8, "9.png");
            this.imageList1.Images.SetKeyName(9, "10.png");
            this.imageList1.Images.SetKeyName(10, "11.png");
            this.imageList1.Images.SetKeyName(11, "thachkhai.png");
            // 
            // tbx_search
            // 
            this.tbx_search.Location = new System.Drawing.Point(282, 237);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(250, 27);
            this.tbx_search.TabIndex = 9;
            this.tbx_search.Text = "Nhập tên hoặc mã sản phẩm";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(538, 237);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(42, 28);
            this.btn_search.TabIndex = 10;
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(1049, 564);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(173, 72);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "  Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_logo
            // 
            this.btn_logo.BackColor = System.Drawing.Color.White;
            this.btn_logo.BackgroundImage = global::Form_SPham.Properties.Resources.logoRauMa21;
            this.btn_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logo.FlatAppearance.BorderSize = 0;
            this.btn_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logo.Location = new System.Drawing.Point(630, 49);
            this.btn_logo.Name = "btn_logo";
            this.btn_logo.Size = new System.Drawing.Size(278, 92);
            this.btn_logo.TabIndex = 18;
            this.btn_logo.UseVisualStyleBackColor = false;
            // 
            // dgv_dsSanPham
            // 
            this.dgv_dsSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsSanPham.Location = new System.Drawing.Point(282, 271);
            this.dgv_dsSanPham.Name = "dgv_dsSanPham";
            this.dgv_dsSanPham.RowHeadersWidth = 51;
            this.dgv_dsSanPham.RowTemplate.Height = 29;
            this.dgv_dsSanPham.Size = new System.Drawing.Size(940, 253);
            this.dgv_dsSanPham.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 648);
            this.Controls.Add(this.dgv_dsSanPham);
            this.Controls.Add(this.btn_logo);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tbx_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_avt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_caidat;
        private System.Windows.Forms.Button btn_hoadon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox tbx_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_logo;
        private System.Windows.Forms.PictureBox ptB_avt;
        private System.Windows.Forms.Button btn_taikhoan;
        private System.Windows.Forms.DataGridView dgv_dsSanPham;
    }
}

