namespace AutoService.Forms.User
{
    partial class Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            controlGroup = new GroupBox();
            contactUpateButton = new Button();
            contactLabel = new Label();
            usernameLabel = new Label();
            logoutButton = new Button();
            servicesGroup = new GroupBox();
            servicesInfoButton = new Button();
            servicesRefreshButton = new Button();
            servicesListBox = new ListBox();
            reservationsGroup = new GroupBox();
            reservationsCancelButton = new Button();
            reservationsRefreshButton = new Button();
            reservationsView = new DataGridView();
            schedulesGroup = new GroupBox();
            scheduleReserveButton = new Button();
            schedulesRefreshButton = new Button();
            schedulesView = new DataGridView();
            controlGroup.SuspendLayout();
            servicesGroup.SuspendLayout();
            reservationsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservationsView).BeginInit();
            schedulesGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)schedulesView).BeginInit();
            SuspendLayout();
            // 
            // controlGroup
            // 
            controlGroup.Controls.Add(contactUpateButton);
            controlGroup.Controls.Add(contactLabel);
            controlGroup.Controls.Add(usernameLabel);
            controlGroup.Controls.Add(logoutButton);
            controlGroup.Dock = DockStyle.Bottom;
            controlGroup.Location = new Point(0, 488);
            controlGroup.Name = "controlGroup";
            controlGroup.Size = new Size(784, 73);
            controlGroup.TabIndex = 0;
            controlGroup.TabStop = false;
            // 
            // contactUpateButton
            // 
            contactUpateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            contactUpateButton.Location = new Point(474, 22);
            contactUpateButton.Name = "contactUpateButton";
            contactUpateButton.Size = new Size(149, 33);
            contactUpateButton.TabIndex = 4;
            contactUpateButton.Text = "Izmeni kontakt";
            contactUpateButton.UseVisualStyleBackColor = true;
            contactUpateButton.Click += contactUpateButton_Click;
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.ForeColor = Color.White;
            contactLabel.Location = new Point(258, 19);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(38, 15);
            contactLabel.TabIndex = 3;
            contactLabel.Text = "label1";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(6, 19);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(66, 30);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "label1";
            // 
            // logoutButton
            // 
            logoutButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            logoutButton.Location = new Point(629, 22);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(149, 33);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Odjavi se";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // servicesGroup
            // 
            servicesGroup.Controls.Add(servicesInfoButton);
            servicesGroup.Controls.Add(servicesRefreshButton);
            servicesGroup.Controls.Add(servicesListBox);
            servicesGroup.Dock = DockStyle.Right;
            servicesGroup.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            servicesGroup.ForeColor = Color.FromArgb(250, 251, 252);
            servicesGroup.Location = new Point(539, 0);
            servicesGroup.Name = "servicesGroup";
            servicesGroup.Size = new Size(245, 488);
            servicesGroup.TabIndex = 1;
            servicesGroup.TabStop = false;
            servicesGroup.Text = "Servisi";
            // 
            // servicesInfoButton
            // 
            servicesInfoButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            servicesInfoButton.ForeColor = SystemColors.ControlText;
            servicesInfoButton.Location = new Point(6, 443);
            servicesInfoButton.Name = "servicesInfoButton";
            servicesInfoButton.Size = new Size(233, 33);
            servicesInfoButton.TabIndex = 3;
            servicesInfoButton.Text = "Detalji";
            servicesInfoButton.UseVisualStyleBackColor = true;
            servicesInfoButton.Click += servicesInfoButton_Click;
            // 
            // servicesRefreshButton
            // 
            servicesRefreshButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            servicesRefreshButton.ForeColor = SystemColors.ControlText;
            servicesRefreshButton.Location = new Point(6, 404);
            servicesRefreshButton.Name = "servicesRefreshButton";
            servicesRefreshButton.Size = new Size(233, 33);
            servicesRefreshButton.TabIndex = 2;
            servicesRefreshButton.Text = "Osveži";
            servicesRefreshButton.UseVisualStyleBackColor = true;
            servicesRefreshButton.Click += servicesRefreshButton_Click;
            // 
            // servicesListBox
            // 
            servicesListBox.BackColor = Color.FromArgb(43, 49, 55);
            servicesListBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            servicesListBox.ForeColor = Color.FromArgb(250, 251, 252);
            servicesListBox.FormattingEnabled = true;
            servicesListBox.ItemHeight = 25;
            servicesListBox.Items.AddRange(new object[] { "Jedan", "Dva", "Tri" });
            servicesListBox.Location = new Point(6, 34);
            servicesListBox.Name = "servicesListBox";
            servicesListBox.Size = new Size(233, 354);
            servicesListBox.TabIndex = 0;
            // 
            // reservationsGroup
            // 
            reservationsGroup.Controls.Add(reservationsCancelButton);
            reservationsGroup.Controls.Add(reservationsRefreshButton);
            reservationsGroup.Controls.Add(reservationsView);
            reservationsGroup.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            reservationsGroup.ForeColor = Color.FromArgb(250, 251, 252);
            reservationsGroup.Location = new Point(6, 244);
            reservationsGroup.Name = "reservationsGroup";
            reservationsGroup.Size = new Size(527, 244);
            reservationsGroup.TabIndex = 2;
            reservationsGroup.TabStop = false;
            reservationsGroup.Text = "Moje Rezervacije";
            // 
            // reservationsCancelButton
            // 
            reservationsCancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reservationsCancelButton.ForeColor = SystemColors.ControlText;
            reservationsCancelButton.Location = new Point(217, 205);
            reservationsCancelButton.Name = "reservationsCancelButton";
            reservationsCancelButton.Size = new Size(149, 33);
            reservationsCancelButton.TabIndex = 5;
            reservationsCancelButton.Text = "Otkaži rezervaciju";
            reservationsCancelButton.UseVisualStyleBackColor = true;
            reservationsCancelButton.Click += reservationsCancelButton_Click;
            // 
            // reservationsRefreshButton
            // 
            reservationsRefreshButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reservationsRefreshButton.ForeColor = SystemColors.ControlText;
            reservationsRefreshButton.Location = new Point(372, 205);
            reservationsRefreshButton.Name = "reservationsRefreshButton";
            reservationsRefreshButton.Size = new Size(149, 33);
            reservationsRefreshButton.TabIndex = 4;
            reservationsRefreshButton.Text = "Osveži";
            reservationsRefreshButton.UseVisualStyleBackColor = true;
            reservationsRefreshButton.Click += reservationsRefreshButton_Click;
            // 
            // reservationsView
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            reservationsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            reservationsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(250, 251, 252);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            reservationsView.DefaultCellStyle = dataGridViewCellStyle2;
            reservationsView.Dock = DockStyle.Top;
            reservationsView.Location = new Point(3, 31);
            reservationsView.Name = "reservationsView";
            reservationsView.ReadOnly = true;
            reservationsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservationsView.Size = new Size(521, 169);
            reservationsView.TabIndex = 1;
            // 
            // schedulesGroup
            // 
            schedulesGroup.Controls.Add(scheduleReserveButton);
            schedulesGroup.Controls.Add(schedulesRefreshButton);
            schedulesGroup.Controls.Add(schedulesView);
            schedulesGroup.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            schedulesGroup.ForeColor = Color.FromArgb(250, 251, 252);
            schedulesGroup.Location = new Point(6, 0);
            schedulesGroup.Name = "schedulesGroup";
            schedulesGroup.Size = new Size(527, 247);
            schedulesGroup.TabIndex = 3;
            schedulesGroup.TabStop = false;
            schedulesGroup.Text = "Dostupni termini";
            // 
            // scheduleReserveButton
            // 
            scheduleReserveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            scheduleReserveButton.ForeColor = SystemColors.ControlText;
            scheduleReserveButton.Location = new Point(217, 205);
            scheduleReserveButton.Name = "scheduleReserveButton";
            scheduleReserveButton.Size = new Size(149, 33);
            scheduleReserveButton.TabIndex = 3;
            scheduleReserveButton.Text = "Rezerviši";
            scheduleReserveButton.UseVisualStyleBackColor = true;
            scheduleReserveButton.Click += scheduleReserveButton_Click;
            // 
            // schedulesRefreshButton
            // 
            schedulesRefreshButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            schedulesRefreshButton.ForeColor = SystemColors.ControlText;
            schedulesRefreshButton.Location = new Point(372, 205);
            schedulesRefreshButton.Name = "schedulesRefreshButton";
            schedulesRefreshButton.Size = new Size(149, 33);
            schedulesRefreshButton.TabIndex = 2;
            schedulesRefreshButton.Text = "Osveži";
            schedulesRefreshButton.UseVisualStyleBackColor = true;
            schedulesRefreshButton.Click += schedulesRefreshButton_Click;
            // 
            // schedulesView
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            schedulesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            schedulesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(250, 251, 252);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            schedulesView.DefaultCellStyle = dataGridViewCellStyle4;
            schedulesView.Dock = DockStyle.Top;
            schedulesView.Location = new Point(3, 31);
            schedulesView.Name = "schedulesView";
            schedulesView.ReadOnly = true;
            schedulesView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            schedulesView.Size = new Size(521, 169);
            schedulesView.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 41, 46);
            ClientSize = new Size(784, 561);
            Controls.Add(schedulesGroup);
            Controls.Add(reservationsGroup);
            Controls.Add(servicesGroup);
            Controls.Add(controlGroup);
            Name = "Dashboard";
            Text = "Početna";
            Shown += Dashboard_Shown;
            controlGroup.ResumeLayout(false);
            controlGroup.PerformLayout();
            servicesGroup.ResumeLayout(false);
            reservationsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)reservationsView).EndInit();
            schedulesGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)schedulesView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox controlGroup;
        private Button logoutButton;
        private GroupBox servicesGroup;
        private Button servicesInfoButton;
        private Button servicesRefreshButton;
        private ListBox servicesListBox;
        private GroupBox reservationsGroup;
        private GroupBox schedulesGroup;
        private Button scheduleReserveButton;
        private Button schedulesRefreshButton;
        private DataGridView schedulesView;
        private DataGridView reservationsView;
        private Button reservationsCancelButton;
        private Button reservationsRefreshButton;
        private Label usernameLabel;
        private Label contactLabel;
        private Button contactUpateButton;
    }
}