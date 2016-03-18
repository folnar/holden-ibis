namespace ibis_R1a
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.picboxHoldenLogo = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShowPWChars = new System.Windows.Forms.CheckBox();
            this.cmdLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxHoldenLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxHoldenLogo
            // 
            this.picboxHoldenLogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxHoldenLogo.Image")));
            this.picboxHoldenLogo.InitialImage = null;
            this.picboxHoldenLogo.Location = new System.Drawing.Point(166, 12);
            this.picboxHoldenLogo.Name = "picboxHoldenLogo";
            this.picboxHoldenLogo.Size = new System.Drawing.Size(375, 131);
            this.picboxHoldenLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxHoldenLogo.TabIndex = 0;
            this.picboxHoldenLogo.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(248, 220);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(272, 30);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(167, 225);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 18);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(172, 274);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 18);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(248, 269);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(272, 30);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPWChars
            // 
            this.chkShowPWChars.AutoSize = true;
            this.chkShowPWChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPWChars.Location = new System.Drawing.Point(248, 305);
            this.chkShowPWChars.Name = "chkShowPWChars";
            this.chkShowPWChars.Size = new System.Drawing.Size(191, 20);
            this.chkShowPWChars.TabIndex = 5;
            this.chkShowPWChars.Text = "Show password characters.";
            this.chkShowPWChars.UseVisualStyleBackColor = true;
            this.chkShowPWChars.CheckedChanged += new System.EventHandler(this.chkShowPWChars_CheckedChanged);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(291, 373);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(148, 46);
            this.cmdLogin.TabIndex = 6;
            this.cmdLogin.Text = "&Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.cmdLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 510);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.chkShowPWChars);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.picboxHoldenLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holden Data System - Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picboxHoldenLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxHoldenLogo;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPWChars;
        private System.Windows.Forms.Button cmdLogin;
    }
}

