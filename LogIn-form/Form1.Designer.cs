namespace LogIn_form
{
    partial class YozoLogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YozoLogInForm));
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.labelLogInText = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panelLineUsername = new System.Windows.Forms.Panel();
            this.panelLinePassword = new System.Windows.Forms.Panel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PanelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicLogo
            // 
            this.PicLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(86, 49);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(100, 103);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // labelLogInText
            // 
            this.labelLogInText.AutoSize = true;
            this.labelLogInText.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogInText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLogInText.Location = new System.Drawing.Point(86, 169);
            this.labelLogInText.Name = "labelLogInText";
            this.labelLogInText.Size = new System.Drawing.Size(98, 31);
            this.labelLogInText.TabIndex = 1;
            this.labelLogInText.Text = "Log-In";
            this.labelLogInText.Click += new System.EventHandler(this.logIn_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(20, 227);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(75, 18);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username:";
            // 
            // panelLineUsername
            // 
            this.panelLineUsername.BackColor = System.Drawing.SystemColors.InfoText;
            this.panelLineUsername.Location = new System.Drawing.Point(92, 246);
            this.panelLineUsername.Name = "panelLineUsername";
            this.panelLineUsername.Size = new System.Drawing.Size(150, 1);
            this.panelLineUsername.TabIndex = 3;
            // 
            // panelLinePassword
            // 
            this.panelLinePassword.BackColor = System.Drawing.SystemColors.InfoText;
            this.panelLinePassword.Location = new System.Drawing.Point(92, 276);
            this.panelLinePassword.Name = "panelLinePassword";
            this.panelLinePassword.Size = new System.Drawing.Size(150, 1);
            this.panelLinePassword.TabIndex = 5;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(23, 255);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(72, 18);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password:";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUsername.Location = new System.Drawing.Point(92, 228);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(150, 14);
            this.txtBoxUsername.TabIndex = 6;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPassword.Location = new System.Drawing.Point(93, 260);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(150, 14);
            this.txtBoxPassword.TabIndex = 7;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Location = new System.Drawing.Point(97, 306);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 8;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Location = new System.Drawing.Point(93, 281);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(107, 19);
            this.cbShowPass.TabIndex = 9;
            this.cbShowPass.Text = "Show Password";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.Controls.Add(this.btnClose);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(275, 24);
            this.PanelTitleBar.TabIndex = 10;
            this.PanelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTitleBar_Paint);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(248, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 24);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // YozoLogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.panelLinePassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.panelLineUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelLogInText);
            this.Controls.Add(this.PicLogo);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "YozoLogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "__Yozo-LogIn-Form";
            this.Load += new System.EventHandler(this.YozoLogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PanelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Label labelLogInText;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelLineUsername;
        private System.Windows.Forms.Panel panelLinePassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Button btnClose;
    }
}

