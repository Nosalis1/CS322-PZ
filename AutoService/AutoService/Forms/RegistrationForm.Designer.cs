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
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(175, 135);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(116, 20);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Korisničko ime:";
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(297, 132);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(234, 27);
            usernameInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(297, 168);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(234, 27);
            passwordInput.TabIndex = 2;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.CornflowerBlue;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(297, 267);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(127, 43);
            loginButton.TabIndex = 3;
            loginButton.Text = "Registrujte se";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(175, 171);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(66, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Lozinka:";
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.Location = new Point(297, 326);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(200, 20);
            registrationLabel.TabIndex = 5;
            registrationLabel.TabStop = true;
            registrationLabel.Text = "Već imate profil? Ulogujte se";
            registrationLabel.LinkClicked += registrationLabel_LinkClicked;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(175, 204);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(51, 20);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // emailInput
            // 
            emailInput.Location = new Point(297, 201);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(234, 27);
            emailInput.TabIndex = 6;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneLabel.Location = new Point(175, 237);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(65, 20);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Telefon:";
            // 
            // phoneInput
            // 
            phoneInput.Location = new Point(297, 234);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(234, 27);
            phoneInput.TabIndex = 8;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(phoneLabel);
            Controls.Add(phoneInput);
            Controls.Add(emailLabel);
            Controls.Add(emailInput);
            Controls.Add(registrationLabel);
            Controls.Add(passwordLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(usernameLabel);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
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
    }
}