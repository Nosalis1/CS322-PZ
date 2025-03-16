namespace AutoService.Forms
{
    partial class LoginForm
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
            usernameLabel = new Label();
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            loginButton = new Button();
            passwordLabel = new Label();
            registrationLabel = new LinkLabel();
            loginGroup = new GroupBox();
            loginGroup.SuspendLayout();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            usernameLabel.ForeColor = Color.FromArgb(250, 251, 252);
            usernameLabel.Location = new Point(47, 90);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(103, 17);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Korisničko ime:";
            // 
            // usernameInput
            // 
            usernameInput.BackColor = Color.FromArgb(43, 49, 55);
            usernameInput.ForeColor = Color.FromArgb(250, 251, 252);
            usernameInput.Location = new Point(157, 90);
            usernameInput.Margin = new Padding(3, 2, 3, 2);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(213, 35);
            usernameInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            passwordInput.BackColor = Color.FromArgb(43, 49, 55);
            passwordInput.ForeColor = Color.FromArgb(250, 251, 252);
            passwordInput.Location = new Point(157, 130);
            passwordInput.Margin = new Padding(3, 2, 3, 2);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(213, 35);
            passwordInput.TabIndex = 2;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(45, 186, 78);
            loginButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.FromArgb(36, 41, 46);
            loginButton.Location = new Point(179, 178);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(158, 32);
            loginButton.TabIndex = 3;
            loginButton.Text = "Ulogujte se";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            passwordLabel.ForeColor = Color.FromArgb(250, 251, 252);
            passwordLabel.Location = new Point(87, 133);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(59, 17);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Lozinka:";
            // 
            // registrationLabel
            // 
            registrationLabel.ActiveLinkColor = Color.FromArgb(250, 251, 252);
            registrationLabel.AutoSize = true;
            registrationLabel.LinkColor = Color.FromArgb(45, 186, 78);
            registrationLabel.Location = new Point(52, 267);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(297, 30);
            registrationLabel.TabIndex = 5;
            registrationLabel.TabStop = true;
            registrationLabel.Text = "Nemate profil? Registrujte se";
            registrationLabel.TextAlign = ContentAlignment.MiddleCenter;
            registrationLabel.LinkClicked += registrationLabel_LinkClicked;
            // 
            // loginGroup
            // 
            loginGroup.Controls.Add(usernameLabel);
            loginGroup.Controls.Add(registrationLabel);
            loginGroup.Controls.Add(usernameInput);
            loginGroup.Controls.Add(passwordLabel);
            loginGroup.Controls.Add(passwordInput);
            loginGroup.Controls.Add(loginButton);
            loginGroup.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginGroup.ForeColor = Color.FromArgb(250, 251, 252);
            loginGroup.Location = new Point(192, 130);
            loginGroup.Name = "loginGroup";
            loginGroup.Size = new Size(400, 300);
            loginGroup.TabIndex = 6;
            loginGroup.TabStop = false;
            loginGroup.Text = "Prijava";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 41, 46);
            ClientSize = new Size(784, 561);
            Controls.Add(loginGroup);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "Prijava";
            loginGroup.ResumeLayout(false);
            loginGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label usernameLabel;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private Button loginButton;
        private Label passwordLabel;
        private LinkLabel registrationLabel;
        private GroupBox loginGroup;
    }
}