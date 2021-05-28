
namespace DashBoar
{
    partial class FrmThemQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemQuyen));
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txtMaQuyen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtLoaiQuyen = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btn_loaisp_them = new System.Windows.Forms.Button();
            this.btn_loaisp_nhaplai = new System.Windows.Forms.Button();
            this.btn_loaisp_huy = new System.Windows.Forms.Button();
            this.btn_loaisp_sua = new System.Windows.Forms.Button();
            this.btn_loaisp_xoa = new System.Windows.Forms.Button();
            this.dgvQuyen = new System.Windows.Forms.DataGridView();
            this.clMaQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoaiQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtMaQuyen);
            this.groupBox12.Controls.Add(this.label2);
            this.groupBox12.Controls.Add(this.label24);
            this.groupBox12.Controls.Add(this.txtLoaiQuyen);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.ForeColor = System.Drawing.Color.White;
            this.groupBox12.Location = new System.Drawing.Point(23, 23);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox12.Size = new System.Drawing.Size(1200, 372);
            this.groupBox12.TabIndex = 126;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Thông tin chi tiết";
            // 
            // txtMaQuyen
            // 
            this.txtMaQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaQuyen.ForeColor = System.Drawing.Color.Black;
            this.txtMaQuyen.Location = new System.Drawing.Point(500, 74);
            this.txtMaQuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaQuyen.Name = "txtMaQuyen";
            this.txtMaQuyen.Size = new System.Drawing.Size(304, 39);
            this.txtMaQuyen.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(269, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 32);
            this.label2.TabIndex = 108;
            this.label2.Text = "Loại Quyền:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(268, 81);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(156, 32);
            this.label24.TabIndex = 113;
            this.label24.Text = "Mã quyền:";
            // 
            // txtLoaiQuyen
            // 
            this.txtLoaiQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiQuyen.ForeColor = System.Drawing.Color.Black;
            this.txtLoaiQuyen.Location = new System.Drawing.Point(500, 157);
            this.txtLoaiQuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoaiQuyen.Name = "txtLoaiQuyen";
            this.txtLoaiQuyen.Size = new System.Drawing.Size(304, 39);
            this.txtLoaiQuyen.TabIndex = 116;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.btn_loaisp_them);
            this.groupBox13.Controls.Add(this.btn_loaisp_nhaplai);
            this.groupBox13.Controls.Add(this.btn_loaisp_huy);
            this.groupBox13.Controls.Add(this.btn_loaisp_sua);
            this.groupBox13.Controls.Add(this.btn_loaisp_xoa);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.ForeColor = System.Drawing.Color.White;
            this.groupBox13.Location = new System.Drawing.Point(23, 412);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox13.Size = new System.Drawing.Size(1200, 167);
            this.groupBox13.TabIndex = 127;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Công cụ";
            // 
            // btn_loaisp_them
            // 
            this.btn_loaisp_them.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_loaisp_them.FlatAppearance.BorderSize = 0;
            this.btn_loaisp_them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_loaisp_them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_loaisp_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loaisp_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loaisp_them.ForeColor = System.Drawing.Color.White;
            this.btn_loaisp_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_loaisp_them.Image")));
            this.btn_loaisp_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loaisp_them.Location = new System.Drawing.Point(125, 61);
            this.btn_loaisp_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_loaisp_them.Name = "btn_loaisp_them";
            this.btn_loaisp_them.Size = new System.Drawing.Size(177, 75);
            this.btn_loaisp_them.TabIndex = 133;
            this.btn_loaisp_them.Text = "Thêm";
            this.btn_loaisp_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_loaisp_them.UseVisualStyleBackColor = false;
            // 
            // btn_loaisp_nhaplai
            // 
            this.btn_loaisp_nhaplai.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_loaisp_nhaplai.FlatAppearance.BorderSize = 0;
            this.btn_loaisp_nhaplai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_loaisp_nhaplai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_loaisp_nhaplai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loaisp_nhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loaisp_nhaplai.ForeColor = System.Drawing.Color.White;
            this.btn_loaisp_nhaplai.Image = global::DashBoar.Properties.Resources.loop2;
            this.btn_loaisp_nhaplai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loaisp_nhaplai.Location = new System.Drawing.Point(818, 65);
            this.btn_loaisp_nhaplai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_loaisp_nhaplai.Name = "btn_loaisp_nhaplai";
            this.btn_loaisp_nhaplai.Size = new System.Drawing.Size(182, 75);
            this.btn_loaisp_nhaplai.TabIndex = 132;
            this.btn_loaisp_nhaplai.Text = "Nhập lại";
            this.btn_loaisp_nhaplai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_loaisp_nhaplai.UseVisualStyleBackColor = false;
            // 
            // btn_loaisp_huy
            // 
            this.btn_loaisp_huy.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_loaisp_huy.FlatAppearance.BorderSize = 0;
            this.btn_loaisp_huy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_loaisp_huy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_loaisp_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loaisp_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loaisp_huy.ForeColor = System.Drawing.Color.White;
            this.btn_loaisp_huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_loaisp_huy.Image")));
            this.btn_loaisp_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loaisp_huy.Location = new System.Drawing.Point(1048, 65);
            this.btn_loaisp_huy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_loaisp_huy.Name = "btn_loaisp_huy";
            this.btn_loaisp_huy.Size = new System.Drawing.Size(146, 75);
            this.btn_loaisp_huy.TabIndex = 129;
            this.btn_loaisp_huy.Text = "Hủy";
            this.btn_loaisp_huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_loaisp_huy.UseVisualStyleBackColor = false;
            // 
            // btn_loaisp_sua
            // 
            this.btn_loaisp_sua.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_loaisp_sua.FlatAppearance.BorderSize = 0;
            this.btn_loaisp_sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_loaisp_sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_loaisp_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loaisp_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loaisp_sua.ForeColor = System.Drawing.Color.White;
            this.btn_loaisp_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_loaisp_sua.Image")));
            this.btn_loaisp_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loaisp_sua.Location = new System.Drawing.Point(621, 65);
            this.btn_loaisp_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_loaisp_sua.Name = "btn_loaisp_sua";
            this.btn_loaisp_sua.Size = new System.Drawing.Size(146, 75);
            this.btn_loaisp_sua.TabIndex = 130;
            this.btn_loaisp_sua.Text = "Sửa";
            this.btn_loaisp_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_loaisp_sua.UseVisualStyleBackColor = false;
            // 
            // btn_loaisp_xoa
            // 
            this.btn_loaisp_xoa.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_loaisp_xoa.FlatAppearance.BorderSize = 0;
            this.btn_loaisp_xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_loaisp_xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_loaisp_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loaisp_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loaisp_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_loaisp_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_loaisp_xoa.Image")));
            this.btn_loaisp_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loaisp_xoa.Location = new System.Drawing.Point(390, 65);
            this.btn_loaisp_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_loaisp_xoa.Name = "btn_loaisp_xoa";
            this.btn_loaisp_xoa.Size = new System.Drawing.Size(146, 75);
            this.btn_loaisp_xoa.TabIndex = 131;
            this.btn_loaisp_xoa.Text = "Xóa";
            this.btn_loaisp_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_loaisp_xoa.UseVisualStyleBackColor = false;
            // 
            // dgvQuyen
            // 
            this.dgvQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaQuyen,
            this.clLoaiQuyen});
            this.dgvQuyen.Location = new System.Drawing.Point(0, 612);
            this.dgvQuyen.Name = "dgvQuyen";
            this.dgvQuyen.RowHeadersWidth = 62;
            this.dgvQuyen.RowTemplate.Height = 28;
            this.dgvQuyen.Size = new System.Drawing.Size(1254, 240);
            this.dgvQuyen.TabIndex = 128;
            // 
            // clMaQuyen
            // 
            this.clMaQuyen.HeaderText = "Mã quyền";
            this.clMaQuyen.MinimumWidth = 8;
            this.clMaQuyen.Name = "clMaQuyen";
            // 
            // clLoaiQuyen
            // 
            this.clLoaiQuyen.HeaderText = "Loại quyền";
            this.clLoaiQuyen.MinimumWidth = 8;
            this.clLoaiQuyen.Name = "clLoaiQuyen";
            // 
            // FrmThemQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1254, 852);
            this.Controls.Add(this.dgvQuyen);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThemQuyen";
            this.Text = "FrmThemQuyen";
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox txtMaQuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtLoaiQuyen;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button btn_loaisp_them;
        private System.Windows.Forms.Button btn_loaisp_nhaplai;
        private System.Windows.Forms.Button btn_loaisp_huy;
        private System.Windows.Forms.Button btn_loaisp_sua;
        private System.Windows.Forms.Button btn_loaisp_xoa;
        private System.Windows.Forms.DataGridView dgvQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaiQuyen;
    }
}