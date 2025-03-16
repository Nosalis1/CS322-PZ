namespace AutoService.Forms.Admin.Service
{
    partial class ServiceCreateForm
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
            nameLabel = new Label();
            nameInput = new TextBox();
            descriptionInput = new TextBox();
            descriptionLabel = new Label();
            durationInput = new TextBox();
            durationLabel = new Label();
            priceInput = new TextBox();
            priceLabel = new Label();
            submitButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(23, 47);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(69, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Ime Servisa:";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(102, 45);
            nameInput.Margin = new Padding(3, 2, 3, 2);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(110, 23);
            nameInput.TabIndex = 1;
            // 
            // descriptionInput
            // 
            descriptionInput.Location = new Point(102, 77);
            descriptionInput.Margin = new Padding(3, 2, 3, 2);
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(110, 23);
            descriptionInput.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(23, 79);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(34, 15);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Opis:";
            // 
            // durationInput
            // 
            durationInput.Location = new Point(102, 112);
            durationInput.Margin = new Padding(3, 2, 3, 2);
            durationInput.Name = "durationInput";
            durationInput.Size = new Size(110, 23);
            durationInput.TabIndex = 5;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(23, 115);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(50, 15);
            durationLabel.TabIndex = 4;
            durationLabel.Text = "Trajanje:";
            // 
            // priceInput
            // 
            priceInput.Location = new Point(102, 146);
            priceInput.Margin = new Padding(3, 2, 3, 2);
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(110, 23);
            priceInput.TabIndex = 7;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(23, 148);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(37, 15);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Cena:";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(23, 193);
            submitButton.Margin = new Padding(3, 2, 3, 2);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(82, 22);
            submitButton.TabIndex = 8;
            submitButton.Text = "Kreiraj";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(129, 193);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(82, 22);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Odustani";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // ServiceCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 261);
            Controls.Add(cancelButton);
            Controls.Add(submitButton);
            Controls.Add(priceInput);
            Controls.Add(priceLabel);
            Controls.Add(durationInput);
            Controls.Add(durationLabel);
            Controls.Add(descriptionInput);
            Controls.Add(descriptionLabel);
            Controls.Add(nameInput);
            Controls.Add(nameLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ServiceCreateForm";
            Text = "Servis kreiranje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameInput;
        private TextBox descriptionInput;
        private Label descriptionLabel;
        private TextBox durationInput;
        private Label durationLabel;
        private TextBox priceInput;
        private Label priceLabel;
        private Button submitButton;
        private Button cancelButton;
    }
}