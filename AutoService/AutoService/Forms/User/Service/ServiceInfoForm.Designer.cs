namespace AutoService.Forms.User.Service
{
    partial class ServiceInfoForm
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
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            priceLabel = new Label();
            durationLabel = new Label();
            descriptionLabel = new Label();
            nameLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(priceLabel);
            groupBox1.Controls.Add(durationLabel);
            groupBox1.Controls.Add(descriptionLabel);
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(250, 251, 252);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Servis";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(12, 141);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(334, 200);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(12, 374);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(72, 30);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "label4";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(12, 344);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(72, 30);
            durationLabel.TabIndex = 2;
            durationLabel.Text = "label3";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(12, 108);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(72, 30);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "label2";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 48);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(72, 30);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "label1";
            // 
            // ServiceInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 41, 46);
            ClientSize = new Size(358, 450);
            Controls.Add(groupBox1);
            Name = "ServiceInfoForm";
            Text = "Servis Detalji";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label priceLabel;
        private Label durationLabel;
        private Label descriptionLabel;
        private Label nameLabel;
        private RichTextBox richTextBox1;
    }
}