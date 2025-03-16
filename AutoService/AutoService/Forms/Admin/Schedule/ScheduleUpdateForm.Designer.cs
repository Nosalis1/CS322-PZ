namespace AutoService.Forms.Admin.Schedule
{
    partial class ScheduleUpdateForm
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
            cancelButton = new Button();
            submitButton = new Button();
            statusInput = new TextBox();
            statusLabel = new Label();
            timeLabel = new Label();
            timePicker = new DateTimePicker();
            dateLabel = new Label();
            datePicker = new DateTimePicker();
            serviceLabel = new Label();
            serviceComboBox = new ComboBox();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(162, 193);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 19;
            cancelButton.Text = "Odustani";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(48, 193);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 18;
            submitButton.Text = "Ažuriraj";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // statusInput
            // 
            statusInput.Location = new Point(76, 147);
            statusInput.Name = "statusInput";
            statusInput.Size = new Size(200, 23);
            statusInput.TabIndex = 17;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(8, 147);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 15);
            statusLabel.TabIndex = 16;
            statusLabel.Text = "Status";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(8, 113);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(41, 15);
            timeLabel.TabIndex = 15;
            timeLabel.Text = "Vreme";
            // 
            // timePicker
            // 
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(76, 113);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(200, 23);
            timePicker.TabIndex = 14;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(8, 79);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(43, 15);
            dateLabel.TabIndex = 13;
            dateLabel.Text = "Datum";
            // 
            // datePicker
            // 
            datePicker.Location = new Point(76, 79);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 12;
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Location = new Point(8, 45);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new Size(37, 15);
            serviceLabel.TabIndex = 11;
            serviceLabel.Text = "Servis";
            // 
            // serviceComboBox
            // 
            serviceComboBox.FormattingEnabled = true;
            serviceComboBox.Location = new Point(76, 45);
            serviceComboBox.Name = "serviceComboBox";
            serviceComboBox.Size = new Size(121, 23);
            serviceComboBox.TabIndex = 10;
            // 
            // ScheduleUpdateForm
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
            Name = "ScheduleUpdateForm";
            Text = "Termin ažuriranje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button submitButton;
        private TextBox statusInput;
        private Label statusLabel;
        private Label timeLabel;
        private DateTimePicker timePicker;
        private Label dateLabel;
        private DateTimePicker datePicker;
        private Label serviceLabel;
        private ComboBox serviceComboBox;
    }
}