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
            nameLabel.Location = new Point(15, 64);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(87, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Ime Servisa:";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(105, 61);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(125, 27);
            nameInput.TabIndex = 1;
            // 
            // descriptionInput
            // 
            descriptionInput.Location = new Point(105, 104);
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(125, 27);
            descriptionInput.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(15, 107);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(42, 20);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Opis:";
            // 
            // durationInput
            // 
            durationInput.Location = new Point(105, 151);
            durationInput.Name = "durationInput";
            durationInput.Size = new Size(125, 27);
            durationInput.TabIndex = 5;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(15, 154);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(64, 20);
            durationLabel.TabIndex = 4;
            durationLabel.Text = "Trajanje:";
            // 
            // priceInput
            // 
            priceInput.Location = new Point(105, 196);
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(125, 27);
            priceInput.TabIndex = 7;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(15, 199);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(45, 20);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Cena:";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(15, 259);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 8;
            submitButton.Text = "Kreiraj";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(136, 259);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Odustani";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // ServiceCreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 352);
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
            Name = "ServiceCreateForm";
            Text = "ServiceCreateForm";
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