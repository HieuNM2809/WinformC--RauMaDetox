
namespace QLRauma
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.pnlUS = new System.Windows.Forms.Panel();
            this.pnlShape1 = new System.Windows.Forms.Panel();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.pnlPW = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.pnlShape2 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlShape3 = new System.Windows.Forms.Panel();
            this.btnDKTK = new System.Windows.Forms.LinkLabel();
            this.btnSignin = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUS.SuspendLayout();
            this.pnlPW.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUS
            // 
            this.pnlUS.Controls.Add(this.pnlShape1);
            this.pnlUS.Controls.Add(this.pnlUsername);
            this.pnlUS.Controls.Add(this.txtTaiKhoan);
            this.pnlUS.Location = new System.Drawing.Point(3, 155);
            this.pnlUS.Name = "pnlUS";
            this.pnlUS.Size = new System.Drawing.Size(424, 85);
            this.pnlUS.TabIndex = 31;
            // 
            // pnlShape1
            // 
            this.pnlShape1.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlShape1.Location = new System.Drawing.Point(90, 62);
            this.pnlShape1.Name = "pnlShape1";
            this.pnlShape1.Size = new System.Drawing.Size(335, 2);
            this.pnlShape1.TabIndex = 6;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackgroundImage = global::qlrauma.Properties.Resources.user2_2;
            this.pnlUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUsername.Location = new System.Drawing.Point(10, 10);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(55, 62);
            this.pnlUsername.TabIndex = 6;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtTaiKhoan.Location = new System.Drawing.Point(91, 28);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(316, 25);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.Text = "Tài khoản";
            this.txtTaiKhoan.Click += new System.EventHandler(this.txtTaiKhoan_Click);
            this.txtTaiKhoan.Enter += new System.EventHandler(this.txtTaiKhoan_Enter);
            this.txtTaiKhoan.MouseEnter += new System.EventHandler(this.txtTaiKhoan_MouseEnter);
            this.txtTaiKhoan.MouseLeave += new System.EventHandler(this.txttaiKhoan_MouseLeave);
            // 
            // pnlPW
            // 
            this.pnlPW.Controls.Add(this.pnlPassword);
            this.pnlPW.Controls.Add(this.pnlShape2);
            this.pnlPW.Controls.Add(this.txtMatKhau);
            this.pnlPW.Location = new System.Drawing.Point(3, 240);
            this.pnlPW.Name = "pnlPW";
            this.pnlPW.Size = new System.Drawing.Size(425, 73);
            this.pnlPW.TabIndex = 30;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackgroundImage = global::qlrauma.Properties.Resources.lock1;
            this.pnlPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPassword.Location = new System.Drawing.Point(9, 17);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(55, 47);
            this.pnlPassword.TabIndex = 7;
            // 
            // pnlShape2
            // 
            this.pnlShape2.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlShape2.Location = new System.Drawing.Point(90, 52);
            this.pnlShape2.Name = "pnlShape2";
            this.pnlShape2.Size = new System.Drawing.Size(335, 2);
            this.pnlShape2.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtMatKhau.Location = new System.Drawing.Point(90, 29);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '♥';
            this.txtMatKhau.Size = new System.Drawing.Size(316, 25);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.Text = "PASSWORD";
            this.txtMatKhau.Click += new System.EventHandler(this.txtMatKhau_Click);
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.MouseEnter += new System.EventHandler(this.txtMatKhau_MouseEnter);
            this.txtMatKhau.MouseLeave += new System.EventHandler(this.txtMatKhau_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(973, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 46);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlShape3
            // 
            this.pnlShape3.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlShape3.ForeColor = System.Drawing.Color.ForestGreen;
            this.pnlShape3.Location = new System.Drawing.Point(119, 470);
            this.pnlShape3.Name = "pnlShape3";
            this.pnlShape3.Size = new System.Drawing.Size(225, 2);
            this.pnlShape3.TabIndex = 28;
            // 
            // btnDKTK
            // 
            this.btnDKTK.AutoSize = true;
            this.btnDKTK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDKTK.LinkColor = System.Drawing.Color.ForestGreen;
            this.btnDKTK.Location = new System.Drawing.Point(152, 432);
            this.btnDKTK.Name = "btnDKTK";
            this.btnDKTK.Size = new System.Drawing.Size(127, 18);
            this.btnDKTK.TabIndex = 25;
            this.btnDKTK.TabStop = true;
            this.btnDKTK.Text = "Đăng kí Tài Khoản";
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSignin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSignin.FlatAppearance.BorderSize = 0;
            this.btnSignin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSignin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignin.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.White;
            this.btnSignin.Location = new System.Drawing.Point(12, 348);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(428, 59);
            this.btnSignin.TabIndex = 24;
            this.btnSignin.Text = "Đăng nhập";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            this.btnSignin.MouseEnter += new System.EventHandler(this.btnSignin_MouseEnter);
            this.btnSignin.MouseLeave += new System.EventHandler(this.btnSignin_MouseLeave);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::qlrauma.Properties.Resources.logoRauMa2;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(3, 30);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(193, 75);
            this.pnlLogo.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(93, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 2);
            this.panel1.TabIndex = 26;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 502);
            this.Controls.Add(this.pnlUS);
            this.Controls.Add(this.pnlPW);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlShape3);
            this.Controls.Add(this.btnDKTK);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmlogin";
            this.Text = "frmlogin";
            this.pnlUS.ResumeLayout(false);
            this.pnlUS.PerformLayout();
            this.pnlPW.ResumeLayout(false);
            this.pnlPW.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUS;
        private System.Windows.Forms.Panel pnlShape1;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Panel pnlPW;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlShape2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlShape3;
        private System.Windows.Forms.LinkLabel btnDKTK;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel panel1;
    }
}