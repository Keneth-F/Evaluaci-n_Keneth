namespace Evaluación_Keneth
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblError = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblPass = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.BtnLogin = new MaterialSkin.Controls.MaterialButton();
            this.TxtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtUser = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.LblError);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.TxtUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 366);
            this.panel1.TabIndex = 0;
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(429, 316);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 24);
            this.LblError.TabIndex = 13;
            this.LblError.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Evaluación_Keneth.Properties.Resources.user;
            this.panel2.Location = new System.Drawing.Point(93, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 228);
            this.panel2.TabIndex = 11;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(393, -3);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1, 383);
            this.materialDivider1.TabIndex = 10;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Depth = 0;
            this.lblPass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPass.Location = new System.Drawing.Point(429, 156);
            this.lblPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(82, 19);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "Contraseña";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(429, 39);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Usuario";
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnLogin.Depth = 0;
            this.BtnLogin.HighEmphasis = true;
            this.BtnLogin.Icon = global::Evaluación_Keneth.Properties.Resources.login;
            this.BtnLogin.Location = new System.Drawing.Point(432, 253);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnLogin.Size = new System.Drawing.Size(119, 36);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "Ingresar";
            this.BtnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnLogin.UseAccentColor = false;
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click_1);
            this.BtnLogin.Leave += new System.EventHandler(this.BtnLogin_Leave);
            // 
            // TxtPassword
            // 
            this.TxtPassword.AnimateReadOnly = false;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Depth = 0;
            this.TxtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPassword.LeadingIcon = null;
            this.TxtPassword.Location = new System.Drawing.Point(432, 178);
            this.TxtPassword.MaxLength = 50;
            this.TxtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPassword.Multiline = false;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Password = true;
            this.TxtPassword.Size = new System.Drawing.Size(261, 50);
            this.TxtPassword.TabIndex = 6;
            this.TxtPassword.Text = "";
            this.TxtPassword.TrailingIcon = null;
            // 
            // TxtUser
            // 
            this.TxtUser.AnimateReadOnly = false;
            this.TxtUser.BackColor = System.Drawing.SystemColors.Window;
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Depth = 0;
            this.TxtUser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtUser.LeadingIcon = null;
            this.TxtUser.Location = new System.Drawing.Point(432, 61);
            this.TxtUser.MaxLength = 50;
            this.TxtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtUser.Multiline = false;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(261, 50);
            this.TxtUser.TabIndex = 5;
            this.TxtUser.Text = "";
            this.TxtUser.TrailingIcon = null;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 433);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblPass;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton BtnLogin;
        private MaterialSkin.Controls.MaterialTextBox TxtPassword;
        private MaterialSkin.Controls.MaterialTextBox TxtUser;
        private System.Windows.Forms.Label LblError;
    }
}