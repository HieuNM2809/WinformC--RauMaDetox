namespace DashBoar
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
            this.pnlUS = new System.Windows.Forms.Panel();
            this.pnlShape1 = new System.Windows.Forms.Panel();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlPW = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.pnlShape2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lnkCreateAnAccount = new System.Windows.Forms.LinkLabel();
            this.pnlShape3 = new System.Windows.Forms.Panel();
            this.lnkForGotYourPassword = new System.Windows.Forms.LinkLabel();
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
            this.pnlUS.Controls.Add(this.txtUsername);
            this.pnlUS.Location = new System.Drawing.Point(3, 131);
            this.pnlUS.Name = "pnlUS";
            this.pnlUS.Size = new System.Drawing.Size(424, 85);
            this.pnlUS.TabIndex = 23;
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
            this.pnlUsername.BackgroundImage = global::DashBoar.Properties.Resources.user2_2;
            this.pnlUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUsername.Location = new System.Drawing.Point(10, 10);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(55, 62);
            this.pnlUsername.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtUsername.Location = new System.Drawing.Point(91, 28);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(316, 25);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "USERNAME";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.MouseEnter += new System.EventHandler(this.txtUsername_MouseEnter);
            this.txtUsername.MouseLeave += new System.EventHandler(this.txtUsername_MouseLeave);
            // 
            // pnlPW
            // 
            this.pnlPW.Controls.Add(this.pnlPassword);
            this.pnlPW.Controls.Add(this.pnlShape2);
            this.pnlPW.Controls.Add(this.txtPassword);
            this.pnlPW.Location = new System.Drawing.Point(3, 216);
            this.pnlPW.Name = "pnlPW";
            this.pnlPW.Size = new System.Drawing.Size(425, 73);
            this.pnlPW.TabIndex = 22;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackgroundImage = global::DashBoar.Properties.Resources.lock1;
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
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtPassword.Location = new System.Drawing.Point(90, 29);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '♥';
            this.txtPassword.Size = new System.Drawing.Size(316, 25);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "PASSWORD";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.MouseEnter += new System.EventHandler(this.txtPassword_MouseEnter);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(973, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 46);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lnkCreateAnAccount
            // 
            this.lnkCreateAnAccount.AutoSize = true;
            this.lnkCreateAnAccount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCreateAnAccount.LinkColor = System.Drawing.Color.ForestGreen;
            this.lnkCreateAnAccount.Location = new System.Drawing.Point(161, 464);
            this.lnkCreateAnAccount.Name = "lnkCreateAnAccount";
            this.lnkCreateAnAccount.Size = new System.Drawing.Size(129, 18);
            this.lnkCreateAnAccount.TabIndex = 20;
            this.lnkCreateAnAccount.TabStop = true;
            this.lnkCreateAnAccount.Text = "Create an Account";
            // 
            // pnlShape3
            // 
            this.pnlShape3.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlShape3.ForeColor = System.Drawing.Color.ForestGreen;
            this.pnlShape3.Location = new System.Drawing.Point(119, 446);
            this.pnlShape3.Name = "pnlShape3";
            this.pnlShape3.Size = new System.Drawing.Size(225, 2);
            this.pnlShape3.TabIndex = 19;
            // 
            // lnkForGotYourPassword
            // 
            this.lnkForGotYourPassword.AutoSize = true;
            this.lnkForGotYourPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkForGotYourPassword.LinkColor = System.Drawing.Color.ForestGreen;
            this.lnkForGotYourPassword.Location = new System.Drawing.Point(152, 408);
            this.lnkForGotYourPassword.Name = "lnkForGotYourPassword";
            this.lnkForGotYourPassword.Size = new System.Drawing.Size(150, 18);
            this.lnkForGotYourPassword.TabIndex = 18;
            this.lnkForGotYourPassword.TabStop = true;
            this.lnkForGotYourPassword.Text = "Forgot your pasword?";
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
            this.btnSignin.Location = new System.Drawing.Point(12, 324);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(428, 59);
            this.btnSignin.TabIndex = 17;
            this.btnSignin.Text = "SIGN IN";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            this.btnSignin.MouseEnter += new System.EventHandler(this.btnSignin_MouseEnter);
            this.btnSignin.MouseLeave += new System.EventHandler(this.btnSignin_MouseLeave);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::DashBoar.Properties.Resources.logoRauMa21;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(3, 6);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(193, 75);
            this.pnlLogo.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(93, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 2);
            this.panel1.TabIndex = 15;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DashBoar.Properties.Resources.panel1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 502);
            this.Controls.Add(this.pnlUS);
            this.Controls.Add(this.pnlPW);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lnkCreateAnAccount);
            this.Controls.Add(this.pnlShape3);
            this.Controls.Add(this.lnkForGotYourPassword);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
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
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlPW;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlShape2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lnkCreateAnAccount;
        private System.Windows.Forms.Panel pnlShape3;
        private System.Windows.Forms.LinkLabel lnkForGotYourPassword;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel panel1;
    }
}