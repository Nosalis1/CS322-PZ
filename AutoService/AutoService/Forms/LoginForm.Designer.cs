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
            loginButton.Location = new Point(297, 206);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(127, 43);
            loginButton.TabIndex = 3;
            loginButton.Text = "Ulogujte se";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(182, 171);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(66, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Lozinka:";
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.Location = new Point(297, 265);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(202, 20);
            registrationLabel.TabIndex = 5;
            registrationLabel.TabStop = true;
            registrationLabel.Text = "Nemate profil? Registrujte se";
            registrationLabel.LinkClicked += registrationLabel_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registrationLabel);
            Controls.Add(passwordLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(usernameLabel);
            Name = "LoginForm";
            Text = "LoginForm";
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
    }
}