
namespace DashBoar
{
    partial class frm_Setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_tyle = new System.Windows.Forms.ComboBox();
            this.cbb_ngonngu = new System.Windows.Forms.ComboBox();
            this.btn_chonmau = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_maumau = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_lienhe = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.btn_ketthuc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tỷ lệ màng hình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngôn ngữ";
            // 
            // cbb_tyle
            // 
            this.cbb_tyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_tyle.FormattingEnabled = true;
            this.cbb_tyle.Items.AddRange(new object[] {
            "FULL",
            "1600x900"});
            this.cbb_tyle.Location = new System.Drawing.Point(139, 39);
            this.cbb_tyle.Name = "cbb_tyle";
            this.cbb_tyle.Size = new System.Drawing.Size(162, 28);
            this.cbb_tyle.TabIndex = 2;
            // 
            // cbb_ngonngu
            // 
            this.cbb_ngonngu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ngonngu.FormattingEnabled = true;
            this.cbb_ngonngu.Items.AddRange(new object[] {
            "Tiếng Việt",
            "English"});
            this.cbb_ngonngu.Location = new System.Drawing.Point(139, 90);
            this.cbb_ngonngu.Name = "cbb_ngonngu";
            this.cbb_ngonngu.Size = new System.Drawing.Size(162, 28);
            this.cbb_ngonngu.TabIndex = 3;
            // 
            // btn_chonmau
            // 
            this.btn_chonmau.BackColor = System.Drawing.Color.White;
            this.btn_chonmau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chonmau.ForeColor = System.Drawing.Color.Black;
            this.btn_chonmau.Location = new System.Drawing.Point(139, 136);
            this.btn_chonmau.Name = "btn_chonmau";
            this.btn_chonmau.Size = new System.Drawing.Size(101, 37);
            this.btn_chonmau.TabIndex = 4;
            this.btn_chonmau.Text = "Chọn màu";
            this.btn_chonmau.UseVisualStyleBackColor = false;
            this.btn_chonmau.Click += new System.EventHandler(this.btn_chonmau_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Màu nền";
            // 
            // tbx_maumau
            // 
            this.tbx_maumau.Location = new System.Drawing.Point(260, 136);
            this.tbx_maumau.Name = "tbx_maumau";
            this.tbx_maumau.Size = new System.Drawing.Size(41, 37);
            this.tbx_maumau.TabIndex = 6;
            this.tbx_maumau.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_tyle);
            this.groupBox1.Controls.Add(this.tbx_maumau);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_chonmau);
            this.groupBox1.Controls.Add(this.cbb_ngonngu);
            this.groupBox1.Location = new System.Drawing.Point(50, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 186);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_info);
            this.groupBox2.Controls.Add(this.btn_lienhe);
            this.groupBox2.Location = new System.Drawing.Point(50, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhà sản xuất";
            // 
            // btn_lienhe
            // 
            this.btn_lienhe.ForeColor = System.Drawing.Color.Black;
            this.btn_lienhe.Location = new System.Drawing.Point(58, 35);
            this.btn_lienhe.Name = "btn_lienhe";
            this.btn_lienhe.Size = new System.Drawing.Size(75, 49);
            this.btn_lienhe.TabIndex = 0;
            this.btn_lienhe.Text = "Liên hệ";
            this.btn_lienhe.UseVisualStyleBackColor = true;
            // 
            // btn_info
            // 
            this.btn_info.ForeColor = System.Drawing.Color.Black;
            this.btn_info.Location = new System.Drawing.Point(216, 35);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(75, 49);
            this.btn_info.TabIndex = 1;
            this.btn_info.Text = "Info";
            this.btn_info.UseVisualStyleBackColor = true;
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.ForeColor = System.Drawing.Color.Black;
            this.btn_xacnhan.Location = new System.Drawing.Point(410, 188);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(88, 50);
            this.btn_xacnhan.TabIndex = 2;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // btn_ketthuc
            // 
            this.btn_ketthuc.ForeColor = System.Drawing.Color.Black;
            this.btn_ketthuc.Location = new System.Drawing.Point(410, 294);
            this.btn_ketthuc.Name = "btn_ketthuc";
            this.btn_ketthuc.Size = new System.Drawing.Size(88, 50);
            this.btn_ketthuc.TabIndex = 9;
            this.btn_ketthuc.Text = "Kết thúc";
            this.btn_ketthuc.UseVisualStyleBackColor = true;
            this.btn_ketthuc.Click += new System.EventHandler(this.btn_ketthuc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(173, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "SETTING";
            // 
            // frm_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(510, 375);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ketthuc);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_tyle;
        private System.Windows.Forms.ComboBox cbb_ngonngu;
        private System.Windows.Forms.Button btn_chonmau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbx_maumau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_lienhe;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.Button btn_ketthuc;
        private System.Windows.Forms.Label label4;
    }
}