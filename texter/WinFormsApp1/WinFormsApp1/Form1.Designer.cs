
namespace WinFormsApp1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Rau má đại dương trắng", 1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Rau má đại dương thơ mộng", 2);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Chỉ là rau má", 3);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Rau má bọt biển", 0);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Kiệt anh thạch", 4);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Hồng thạch lâu", 5);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lv_danhsachmon = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ptbx_anhto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.lbl_tenmon = new System.Windows.Forms.Label();
            this.lbl_msp = new System.Windows.Forms.Label();
            this.lbl_gia = new System.Windows.Forms.Label();
            this.lbl_mota = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_lsp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_trangthai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbx_anhto)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_danhsachmon
            // 
            this.lv_danhsachmon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lv_danhsachmon.BackColor = System.Drawing.Color.SeaGreen;
            this.lv_danhsachmon.HideSelection = false;
            this.lv_danhsachmon.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lv_danhsachmon.LargeImageList = this.imageList1;
            this.lv_danhsachmon.Location = new System.Drawing.Point(60, 9);
            this.lv_danhsachmon.Name = "lv_danhsachmon";
            this.lv_danhsachmon.Size = new System.Drawing.Size(187, 448);
            this.lv_danhsachmon.SmallImageList = this.imageList1;
            this.lv_danhsachmon.TabIndex = 0;
            this.lv_danhsachmon.UseCompatibleStateImageBehavior = false;
            this.lv_danhsachmon.SelectedIndexChanged += new System.EventHandler(this.lv_danhsachmon_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "raumadau.PNG");
            this.imageList1.Images.SetKeyName(1, "raumadauxanh.PNG");
            this.imageList1.Images.SetKeyName(2, "raumakhoaimon.PNG");
            this.imageList1.Images.SetKeyName(3, "raumanguyenchat.PNG");
            this.imageList1.Images.SetKeyName(4, "tahchanhkiet.png");
            this.imageList1.Images.SetKeyName(5, "thachkhai.png");
            // 
            // ptbx_anhto
            // 
            this.ptbx_anhto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbx_anhto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbx_anhto.Location = new System.Drawing.Point(505, 9);
            this.ptbx_anhto.Name = "ptbx_anhto";
            this.ptbx_anhto.Size = new System.Drawing.Size(181, 160);
            this.ptbx_anhto.TabIndex = 1;
            this.ptbx_anhto.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(320, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên món:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(320, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(320, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(320, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã sản phẩm:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(642, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Loại sản phẩm:";
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sua.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_sua.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(775, 393);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(155, 64);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xoa.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_xoa.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(520, 393);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(155, 64);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_them.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(285, 393);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(136, 64);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lbl_tenmon
            // 
            this.lbl_tenmon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tenmon.AutoSize = true;
            this.lbl_tenmon.Location = new System.Drawing.Point(407, 218);
            this.lbl_tenmon.Name = "lbl_tenmon";
            this.lbl_tenmon.Size = new System.Drawing.Size(111, 20);
            this.lbl_tenmon.TabIndex = 11;
            this.lbl_tenmon.Text = "_________________";
            // 
            // lbl_msp
            // 
            this.lbl_msp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_msp.AutoSize = true;
            this.lbl_msp.Location = new System.Drawing.Point(427, 252);
            this.lbl_msp.Name = "lbl_msp";
            this.lbl_msp.Size = new System.Drawing.Size(87, 20);
            this.lbl_msp.TabIndex = 12;
            this.lbl_msp.Text = "_____________";
            // 
            // lbl_gia
            // 
            this.lbl_gia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_gia.AutoSize = true;
            this.lbl_gia.Location = new System.Drawing.Point(361, 288);
            this.lbl_gia.Name = "lbl_gia";
            this.lbl_gia.Size = new System.Drawing.Size(153, 20);
            this.lbl_gia.TabIndex = 13;
            this.lbl_gia.Text = "________________________";
            // 
            // lbl_mota
            // 
            this.lbl_mota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_mota.AutoSize = true;
            this.lbl_mota.Location = new System.Drawing.Point(378, 325);
            this.lbl_mota.Name = "lbl_mota";
            this.lbl_mota.Size = new System.Drawing.Size(135, 20);
            this.lbl_mota.TabIndex = 14;
            this.lbl_mota.Text = "_____________________";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.BackgroundImage = global::WinFormsApp1.Properties.Resources.lui;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(427, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 59);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackgroundImage = global::WinFormsApp1.Properties.Resources.next;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(712, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 59);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbl_lsp
            // 
            this.lbl_lsp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_lsp.AutoSize = true;
            this.lbl_lsp.Location = new System.Drawing.Point(756, 218);
            this.lbl_lsp.Name = "lbl_lsp";
            this.lbl_lsp.Size = new System.Drawing.Size(75, 20);
            this.lbl_lsp.TabIndex = 17;
            this.lbl_lsp.Text = "___________";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(642, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Trạng thái:";
            // 
            // lbl_trangthai
            // 
            this.lbl_trangthai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_trangthai.AutoSize = true;
            this.lbl_trangthai.Location = new System.Drawing.Point(726, 251);
            this.lbl_trangthai.Name = "lbl_trangthai";
            this.lbl_trangthai.Size = new System.Drawing.Size(111, 20);
            this.lbl_trangthai.TabIndex = 19;
            this.lbl_trangthai.Text = "_________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 480);
            this.Controls.Add(this.lbl_trangthai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_lsp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_mota);
            this.Controls.Add(this.lbl_gia);
            this.Controls.Add(this.lbl_msp);
            this.Controls.Add(this.lbl_tenmon);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbx_anhto);
            this.Controls.Add(this.lv_danhsachmon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbx_anhto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_danhsachmon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox ptbx_anhto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lbl_tenmon;
        private System.Windows.Forms.Label lbl_msp;
        private System.Windows.Forms.Label lbl_gia;
        private System.Windows.Forms.Label lbl_mota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_lsp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_trangthai;
    }
}

