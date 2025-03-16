namespace AutoService.Forms.User.Contact
{
    partial class UserContactForm
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
            label1 = new Label();
            emailinput = new TextBox();
            phoneInput = new TextBox();
            label2 = new Label();
            submitButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 69);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 0;
            label1.Text = "Email : ";
            // 
            // emailinput
            // 
            emailinput.Font = new Font("Segoe UI", 11.25F);
            emailinput.Location = new Point(120, 67);
            emailinput.Name = "emailinput";
            emailinput.Size = new Size(147, 27);
            emailinput.TabIndex = 1;
            // 
            // phoneInput
            // 
            phoneInput.Font = new Font("Segoe UI", 11.25F);
            phoneInput.Location = new Point(120, 112);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(147, 27);
            phoneInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 114);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 2;
            label2.Text = "Telefon : ";
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            submitButton.ForeColor = SystemColors.ControlText;
            submitButton.Location = new Point(15, 170);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(149, 33);
            submitButton.TabIndex = 4;
            submitButton.Text = "Sačuvaj";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cancelButton.ForeColor = SystemColors.ControlText;
            cancelButton.Location = new Point(170, 170);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(149, 33);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Odustani";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // UserContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 41, 46);
            ClientSize = new Size(331, 252);
            Controls.Add(cancelButton);
            Controls.Add(submitButton);
            Controls.Add(phoneInput);
            Controls.Add(label2);
            Controls.Add(emailinput);
            Controls.Add(label1);
            Name = "UserContactForm";
            Text = "Kontakt izmena";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox emailinput;
        private TextBox phoneInput;
        private Label label2;
        private Button submitButton;
        private Button cancelButton;
    }
}