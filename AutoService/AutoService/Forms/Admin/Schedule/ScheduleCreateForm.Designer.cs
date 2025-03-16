namespace AutoService.Forms.Admin.Schedule
{
    partial class ScheduleCreateForm
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
            serviceComboBox = new ComboBox();
            serviceLabel = new Label();
            datePicker = new DateTimePicker();
            dateLabel = new Label();
            timeLabel = new Label();
            timePicker = new DateTimePicker();
            statusLabel = new Label();
            statusInput = new TextBox();
            submitButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // serviceComboBox
            // 
            serviceComboBox.FormattingEnabled = true;
            serviceComboBox.Location = new Point(76, 46);
            serviceComboBox.Name = "serviceComboBox";
            serviceComboBox.Size = new Size(121, 23);
            serviceComboBox.TabIndex = 0;
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Location = new Point(8, 46);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new Size(37, 15);
            serviceLabel.TabIndex = 1;
            serviceLabel.Text = "Servis";
            // 
            // datePicker
            // 
            datePicker.Location = new Point(76, 80);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 2;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(8, 80);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(43, 15);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Datum";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(8, 114);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(41, 15);
            timeLabel.TabIndex = 5;
            timeLabel.Text = "Vreme";
            // 
            // timePicker
            // 
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(76, 114);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(200, 23);
            timePicker.TabIndex = 4;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(8, 148);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 15);
            statusLabel.TabIndex = 6;
            statusLabel.Text = "Status";
            // 
            // statusInput
            // 
            statusInput.Location = new Point(76, 148);
            statusInput.Name = "statusInput";
            statusInput.Size = new Size(200, 23);
            statusInput.TabIndex = 7;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(48, 194);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 8;
            submitButton.Text = "Kreiraj";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(162, 194);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Odustani";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // ScheduleCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(cancelButton);
            Controls.Add(submitButton);
            Controls.Add(statusInput);
            Controls.Add(statusLabel);
            Controls.Add(timeLabel);
            Controls.Add(timePicker);
            Controls.Add(dateLabel);
            Controls.Add(datePicker);
            Controls.Add(serviceLabel);
            Controls.Add(serviceComboBox);
            Name = "ScheduleCreateForm";
            Text = "Termin kreiranje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox serviceComboBox;
        private Label serviceLabel;
        private DateTimePicker datePicker;
        private Label dateLabel;
        private Label timeLabel;
        private DateTimePicker timePicker;
        private Label statusLabel;
        private TextBox statusInput;
        private Button submitButton;
        private Button cancelButton;
    }
}