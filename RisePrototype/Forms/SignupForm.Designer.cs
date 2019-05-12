namespace RisePrototype
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.btnLogin = new CustomControllers.GradientButton();
            this.txtUser = new CustomControllers.MaterialTextInput();
            this.txtPass = new CustomControllers.MaterialTextInput();
            this.txtConfirmPass = new CustomControllers.MaterialTextInput();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.Image = global::RisePrototype.Properties.Resources.minimize;
            this.minimize.Location = new System.Drawing.Point(312, -2);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(36, 31);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 8;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // close
            // 
            this.close.Image = global::RisePrototype.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(346, -2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(36, 31);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 7;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.Close_Click);
            this.close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.ButtonText = "Cadastrar";
            this.btnLogin.Color0 = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.btnLogin.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.GradientAngle = 0F;
            this.btnLogin.Location = new System.Drawing.Point(54, 443);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(272, 51);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BackgroundColor = System.Drawing.Color.White;
            this.txtUser.DefaultIcon = ((System.Drawing.Image)(resources.GetObject("txtUser.DefaultIcon")));
            this.txtUser.DefaultInputColor = System.Drawing.Color.Black;
            this.txtUser.DefaultLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.txtUser.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.txtUser.HighlightedColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.txtUser.HighlightedIcon = global::RisePrototype.Properties.Resources.user_filled;
            this.txtUser.Hint = "Username";
            this.txtUser.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.txtUser.Icon = ((System.Drawing.Image)(resources.GetObject("txtUser.Icon")));
            this.txtUser.InputText = "Username";
            this.txtUser.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.txtUser.Location = new System.Drawing.Point(54, 275);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordCharacter = '\0';
            this.txtUser.Size = new System.Drawing.Size(272, 38);
            this.txtUser.TabIndex = 10;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.BackgroundColor = System.Drawing.Color.White;
            this.txtPass.DefaultIcon = ((System.Drawing.Image)(resources.GetObject("txtPass.DefaultIcon")));
            this.txtPass.DefaultInputColor = System.Drawing.Color.Black;
            this.txtPass.DefaultLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.txtPass.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.txtPass.HighlightedColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.txtPass.HighlightedIcon = global::RisePrototype.Properties.Resources.lock_filled;
            this.txtPass.Hint = "Username";
            this.txtPass.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.txtPass.Icon = ((System.Drawing.Image)(resources.GetObject("txtPass.Icon")));
            this.txtPass.InputText = "Username";
            this.txtPass.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.txtPass.Location = new System.Drawing.Point(54, 319);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordCharacter = '*';
            this.txtPass.Size = new System.Drawing.Size(272, 38);
            this.txtPass.TabIndex = 11;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.White;
            this.txtConfirmPass.BackgroundColor = System.Drawing.Color.White;
            this.txtConfirmPass.DefaultIcon = ((System.Drawing.Image)(resources.GetObject("txtConfirmPass.DefaultIcon")));
            this.txtConfirmPass.DefaultInputColor = System.Drawing.Color.Black;
            this.txtConfirmPass.DefaultLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.txtConfirmPass.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.txtConfirmPass.HighlightedColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(67)))), ((int)(((byte)(63)))));
            this.txtConfirmPass.HighlightedIcon = global::RisePrototype.Properties.Resources.lock_filled;
            this.txtConfirmPass.Hint = "Username";
            this.txtConfirmPass.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.txtConfirmPass.Icon = ((System.Drawing.Image)(resources.GetObject("txtConfirmPass.Icon")));
            this.txtConfirmPass.InputText = "Username";
            this.txtConfirmPass.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.txtConfirmPass.Location = new System.Drawing.Point(54, 363);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordCharacter = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(272, 38);
            this.txtConfirmPass.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.label1.Location = new System.Drawing.Point(162, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cancel";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Please don\'t forget your password; Seriously Don\'t.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RisePrototype.Properties.Resources.Dark_ery;
            this.pictureBox1.Location = new System.Drawing.Point(12, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Lato Hairline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(54, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 117);
            this.label4.TabIndex = 17;
            this.label4.Text = "We\'re looking for new employees. So, if you\'re interested in working, and receive" +
    " absolutely nothing in return, this is the right place for you!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(109, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Welcome To";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 550);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignupForm";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Signup_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
        private CustomControllers.GradientButton btnLogin;
        private CustomControllers.MaterialTextInput txtUser;
        private CustomControllers.MaterialTextInput txtPass;
        private CustomControllers.MaterialTextInput txtConfirmPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}