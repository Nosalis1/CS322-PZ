namespace AutoService.Forms
{
    partial class RegistrationForm
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
            emailLabel = new Label();
            emailInput = new TextBox();
            phoneLabel = new Label();
            phoneInput = new TextBox();
            registrationGroup = new GroupBox();
            registrationGroup.SuspendLayout();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            usernameLabel.ForeColor = Color.FromArgb(250, 251, 252);
            usernameLabel.Location = new Point(43, 53);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(103, 17);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Korisničko ime:";
            // 
            // usernameInput
            // 
            usernameInput.BackColor = Color.FromArgb(43, 49, 55);
            usernameInput.ForeColor = Color.FromArgb(250, 251, 252);
            usernameInput.Location = new Point(153, 50);
            usernameInput.Margin = new Padding(3, 2, 3, 2);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(205, 35);
            usernameInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            passwordInput.BackColor = Color.FromArgb(43, 49, 55);
            passwordInput.ForeColor = Color.FromArgb(250, 251, 252);
            passwordInput.Location = new Point(153, 90);
            passwordInput.Margin = new Padding(3, 2, 3, 2);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(205, 35);
            passwordInput.TabIndex = 2;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(45, 186, 78);
            loginButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            loginButton.ForeColor = Color.FromArgb(36, 41, 46);
            loginButton.Location = new Point(176, 218);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(158, 32);
            loginButton.TabIndex = 3;
            loginButton.Text = "Registrujte se";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            passwordLabel.ForeColor = Color.FromArgb(250, 251, 252);
            passwordLabel.Location = new Point(83, 93);
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
            registrationLabel.Location = new Point(53, 267);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(294, 30);
            registrationLabel.TabIndex = 5;
            registrationLabel.TabStop = true;
            registrationLabel.Text = "Već imate profil? Ulogujte se";
            registrationLabel.TextAlign = ContentAlignment.MiddleCenter;
            registrationLabel.LinkClicked += registrationLabel_LinkClicked;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            emailLabel.ForeColor = Color.FromArgb(250, 251, 252);
            emailLabel.Location = new Point(96, 133);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 17);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // emailInput
            // 
            emailInput.BackColor = Color.FromArgb(43, 49, 55);
            emailInput.ForeColor = Color.FromArgb(250, 251, 252);
            emailInput.Location = new Point(153, 130);
            emailInput.Margin = new Padding(3, 2, 3, 2);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(205, 35);
            emailInput.TabIndex = 6;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            phoneLabel.ForeColor = Color.FromArgb(250, 251, 252);
            phoneLabel.Location = new Point(83, 173);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(58, 17);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Telefon:";
            // 
            // phoneInput
            // 
            phoneInput.BackColor = Color.FromArgb(43, 49, 55);
            phoneInput.ForeColor = Color.FromArgb(250, 251, 252);
            phoneInput.Location = new Point(153, 170);
            phoneInput.Margin = new Padding(3, 2, 3, 2);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(205, 35);
            phoneInput.TabIndex = 8;
            // 
            // registrationGroup
            // 
            registrationGroup.Controls.Add(usernameInput);
            registrationGroup.Controls.Add(phoneLabel);
            registrationGroup.Controls.Add(usernameLabel);
            registrationGroup.Controls.Add(phoneInput);
            registrationGroup.Controls.Add(passwordInput);
            registrationGroup.Controls.Add(emailLabel);
            registrationGroup.Controls.Add(loginButton);
            registrationGroup.Controls.Add(emailInput);
            registrationGroup.Controls.Add(passwordLabel);
            registrationGroup.Controls.Add(registrationLabel);
            registrationGroup.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrationGroup.ForeColor = Color.FromArgb(250, 251, 252);
            registrationGroup.Location = new Point(192, 130);
            registrationGroup.Name = "registrationGroup";
            registrationGroup.Size = new Size(400, 300);
            registrationGroup.TabIndex = 10;
            registrationGroup.TabStop = false;
            registrationGroup.Text = "Registracija";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 41, 46);
            ClientSize = new Size(784, 561);
            Controls.Add(registrationGroup);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistrationForm";
            Text = "Registracija";
            registrationGroup.ResumeLayout(false);
            registrationGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label usernameLabel;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private Button loginButton;
        private Label passwordLabel;
        private LinkLabel registrationLabel;
        private Label emailLabel;
        private TextBox emailInput;
        private Label phoneLabel;
        private TextBox phoneInput;
        private GroupBox registrationGroup;
    }
}