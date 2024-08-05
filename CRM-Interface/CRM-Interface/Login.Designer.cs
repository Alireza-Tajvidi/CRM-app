namespace CRM_Interface
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.csbtnSignUp = new CRM_Interface.Custom_Controls.CustomButton();
            this.csbtnForgotPassword = new CRM_Interface.Custom_Controls.CustomButton();
            this.csbtnLogin = new CRM_Interface.Custom_Controls.CustomButton();
            this.cstxtPassword = new CRM_Interface.Custom_Controls.CustomTextBox();
            this.cstxtUsername = new CRM_Interface.Custom_Controls.CustomTextBox();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.lbLogin.Location = new System.Drawing.Point(189, 75);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(155, 43);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "GİRİŞ YAP";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(216)))), ((int)(((byte)(147)))));
            this.lbUsername.Location = new System.Drawing.Point(203, 219);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(119, 24);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Kullanıcı Adı";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(216)))), ((int)(((byte)(147)))));
            this.lbPassword.Location = new System.Drawing.Point(235, 313);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(52, 24);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Şifre";
            // 
            // csbtnSignUp
            // 
            this.csbtnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(143)))), ((int)(((byte)(241)))));
            this.csbtnSignUp.BackgroundColor1 = System.Drawing.Color.BlueViolet;
            this.csbtnSignUp.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.csbtnSignUp.BorderRadius1 = 15;
            this.csbtnSignUp.BorderSize1 = 0;
            this.csbtnSignUp.FlatAppearance.BorderSize = 0;
            this.csbtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csbtnSignUp.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csbtnSignUp.ForeColor = System.Drawing.Color.White;
            this.csbtnSignUp.ForeColor1 = System.Drawing.Color.White;
            this.csbtnSignUp.Location = new System.Drawing.Point(273, 431);
            this.csbtnSignUp.Name = "csbtnSignUp";
            this.csbtnSignUp.Size = new System.Drawing.Size(107, 29);
            this.csbtnSignUp.TabIndex = 4;
            this.csbtnSignUp.Text = "Üye ol";
            this.csbtnSignUp.UseVisualStyleBackColor = false;
            this.csbtnSignUp.Click += new System.EventHandler(this.csbtnSignUp_Click);
            // 
            // csbtnForgotPassword
            // 
            this.csbtnForgotPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(143)))), ((int)(((byte)(241)))));
            this.csbtnForgotPassword.BackgroundColor1 = System.Drawing.Color.BlueViolet;
            this.csbtnForgotPassword.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.csbtnForgotPassword.BorderRadius1 = 15;
            this.csbtnForgotPassword.BorderSize1 = 0;
            this.csbtnForgotPassword.FlatAppearance.BorderSize = 0;
            this.csbtnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csbtnForgotPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csbtnForgotPassword.ForeColor = System.Drawing.Color.White;
            this.csbtnForgotPassword.ForeColor1 = System.Drawing.Color.White;
            this.csbtnForgotPassword.Location = new System.Drawing.Point(142, 431);
            this.csbtnForgotPassword.Name = "csbtnForgotPassword";
            this.csbtnForgotPassword.Size = new System.Drawing.Size(125, 29);
            this.csbtnForgotPassword.TabIndex = 4;
            this.csbtnForgotPassword.Text = "Şifremi unuttum";
            this.csbtnForgotPassword.UseVisualStyleBackColor = false;
            // 
            // csbtnLogin
            // 
            this.csbtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(88)))), ((int)(((byte)(234)))));
            this.csbtnLogin.BackgroundColor1 = System.Drawing.Color.BlueViolet;
            this.csbtnLogin.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.csbtnLogin.BorderRadius1 = 25;
            this.csbtnLogin.BorderSize1 = 0;
            this.csbtnLogin.FlatAppearance.BorderSize = 0;
            this.csbtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csbtnLogin.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csbtnLogin.ForeColor = System.Drawing.Color.White;
            this.csbtnLogin.ForeColor1 = System.Drawing.Color.White;
            this.csbtnLogin.Location = new System.Drawing.Point(142, 385);
            this.csbtnLogin.Name = "csbtnLogin";
            this.csbtnLogin.Size = new System.Drawing.Size(238, 40);
            this.csbtnLogin.TabIndex = 3;
            this.csbtnLogin.Text = "Gir";
            this.csbtnLogin.UseVisualStyleBackColor = false;
            this.csbtnLogin.Click += new System.EventHandler(this.csbtnLogin_Click);
            // 
            // cstxtPassword
            // 
            this.cstxtPassword.BackColor = System.Drawing.Color.Lavender;
            this.cstxtPassword.BackColor1 = System.Drawing.Color.Lavender;
            this.cstxtPassword.borderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(88)))), ((int)(((byte)(234)))));
            this.cstxtPassword.borderSize1 = 2;
            this.cstxtPassword.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(67)))), ((int)(((byte)(43)))));
            this.cstxtPassword.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstxtPassword.font1 = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstxtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.cstxtPassword.ForeColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(27)))), ((int)(((byte)(216)))));
            this.cstxtPassword.Location = new System.Drawing.Point(115, 272);
            this.cstxtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cstxtPassword.Name = "cstxtPassword";
            this.cstxtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.cstxtPassword.Size = new System.Drawing.Size(306, 36);
            this.cstxtPassword.TabIndex = 2;
            this.cstxtPassword.texts1 = "";
            this.cstxtPassword.Underlined = true;
            // 
            // cstxtUsername
            // 
            this.cstxtUsername.BackColor = System.Drawing.Color.Lavender;
            this.cstxtUsername.BackColor1 = System.Drawing.Color.Lavender;
            this.cstxtUsername.borderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(88)))), ((int)(((byte)(234)))));
            this.cstxtUsername.borderSize1 = 2;
            this.cstxtUsername.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(67)))), ((int)(((byte)(43)))));
            this.cstxtUsername.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstxtUsername.font1 = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstxtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.cstxtUsername.ForeColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(27)))), ((int)(((byte)(216)))));
            this.cstxtUsername.Location = new System.Drawing.Point(115, 178);
            this.cstxtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cstxtUsername.Name = "cstxtUsername";
            this.cstxtUsername.Padding = new System.Windows.Forms.Padding(7);
            this.cstxtUsername.Size = new System.Drawing.Size(306, 36);
            this.cstxtUsername.TabIndex = 2;
            this.cstxtUsername.texts1 = "";
            this.cstxtUsername.Underlined = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(528, 512);
            this.Controls.Add(this.csbtnSignUp);
            this.Controls.Add(this.csbtnForgotPassword);
            this.Controls.Add(this.csbtnLogin);
            this.Controls.Add(this.cstxtPassword);
            this.Controls.Add(this.cstxtUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbLogin);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbUsername;
        private Custom_Controls.CustomTextBox cstxtUsername;
        private System.Windows.Forms.Label lbPassword;
        private Custom_Controls.CustomTextBox cstxtPassword;
        private Custom_Controls.CustomButton csbtnLogin;
        private Custom_Controls.CustomButton csbtnForgotPassword;
        private Custom_Controls.CustomButton csbtnSignUp;
    }
}

