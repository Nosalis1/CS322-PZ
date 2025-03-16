namespace AutoService.Forms.Admin
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
            controlTabs = new TabControl();
            servicesTabPage = new TabPage();
            serviceRefreshButton = new Button();
            serviceDeleteButton = new Button();
            serviceUpdateButton = new Button();
            serviceCreateButton = new Button();
            servicesDataView = new DataGridView();
            schedulesTabPage = new TabPage();
            scheduleRefreshButton = new Button();
            scheduleDeleteButton = new Button();
            scheduleUpdateButton = new Button();
            scheduleCreateButton = new Button();
            schedulesDataView = new DataGridView();
            reservationsTabPage = new TabPage();
            reservationRefreshButton = new Button();
            reservationDeleteButton = new Button();
            reservationsDataView = new DataGridView();
            profileTabPage = new TabPage();
            usersBox = new GroupBox();
            usersReservationsButton = new Button();
            usersDataView = new DataGridView();
            usersRefreshButton = new Button();
            profileGroup = new GroupBox();
            nameLabel = new Label();
            logoutButton = new Button();
            phoneLabel = new Label();
            emailLabel = new Label();
            controlTabs.SuspendLayout();
            servicesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicesDataView).BeginInit();
            schedulesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)schedulesDataView).BeginInit();
            reservationsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservationsDataView).BeginInit();
            profileTabPage.SuspendLayout();
            usersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataView).BeginInit();
            profileGroup.SuspendLayout();
            SuspendLayout();
            // 
            // controlTabs
            // 
            controlTabs.Controls.Add(servicesTabPage);
            controlTabs.Controls.Add(schedulesTabPage);
            controlTabs.Controls.Add(reservationsTabPage);
            controlTabs.Controls.Add(profileTabPage);
            controlTabs.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            controlTabs.Location = new Point(10, 10);
            controlTabs.Margin = new Padding(3, 2, 3, 2);
            controlTabs.Name = "controlTabs";
            controlTabs.SelectedIndex = 0;
            controlTabs.Size = new Size(765, 545);
            controlTabs.TabIndex = 0;
            // 
            // servicesTabPage
            // 
            servicesTabPage.BackColor = Color.FromArgb(43, 49, 55);
            servicesTabPage.Controls.Add(serviceRefreshButton);
            servicesTabPage.Controls.Add(serviceDeleteButton);
            servicesTabPage.Controls.Add(serviceUpdateButton);
            servicesTabPage.Controls.Add(serviceCreateButton);
            servicesTabPage.Controls.Add(servicesDataView);
            servicesTabPage.Location = new Point(4, 26);
            servicesTabPage.Margin = new Padding(3, 2, 3, 2);
            servicesTabPage.Name = "servicesTabPage";
            servicesTabPage.Padding = new Padding(3, 2, 3, 2);
            servicesTabPage.Size = new Size(757, 515);
            servicesTabPage.TabIndex = 0;
            servicesTabPage.Text = "Servisi";
            // 
            // serviceRefreshButton
            // 
            serviceRefreshButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            serviceRefreshButton.Location = new Point(597, 297);
            serviceRefreshButton.Margin = new Padding(3, 2, 3, 2);
            serviceRefreshButton.Name = "serviceRefreshButton";
            serviceRefreshButton.Size = new Size(149, 33);
            serviceRefreshButton.TabIndex = 4;
            serviceRefreshButton.Text = "Osveži";
            serviceRefreshButton.UseVisualStyleBackColor = true;
            serviceRefreshButton.Click += serviceRefreshButton_Click;
            // 
            // serviceDeleteButton
            // 
            serviceDeleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            serviceDeleteButton.Location = new Point(597, 260);
            serviceDeleteButton.Margin = new Padding(3, 2, 3, 2);
            serviceDeleteButton.Name = "serviceDeleteButton";
            serviceDeleteButton.Size = new Size(149, 33);
            serviceDeleteButton.TabIndex = 3;
            serviceDeleteButton.Text = "Obriši";
            serviceDeleteButton.UseVisualStyleBackColor = true;
            serviceDeleteButton.Click += serviceDeleteButton_Click;
            // 
            // serviceUpdateButton
            // 
            serviceUpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            serviceUpdateButton.Location = new Point(597, 222);
            serviceUpdateButton.Margin = new Padding(3, 2, 3, 2);
            serviceUpdateButton.Name = "serviceUpdateButton";
            serviceUpdateButton.Size = new Size(149, 33);
            serviceUpdateButton.TabIndex = 2;
            serviceUpdateButton.Text = "Ažuriraj";
            serviceUpdateButton.UseVisualStyleBackColor = true;
            serviceUpdateButton.Click += serviceUpdateButton_Click;
            // 
            // serviceCreateButton
            // 
            serviceCreateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            serviceCreateButton.Location = new Point(597, 184);
            serviceCreateButton.Margin = new Padding(3, 2, 3, 2);
            serviceCreateButton.Name = "serviceCreateButton";
            serviceCreateButton.Size = new Size(149, 33);
            serviceCreateButton.TabIndex = 1;
            serviceCreateButton.Text = "Dodaj";
            serviceCreateButton.UseVisualStyleBackColor = true;
            serviceCreateButton.Click += serviceCreateButton_Click;
            // 
            // servicesDataView
            // 
            servicesDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicesDataView.Dock = DockStyle.Left;
            servicesDataView.Location = new Point(3, 2);
            servicesDataView.Margin = new Padding(3, 2, 3, 2);
            servicesDataView.Name = "servicesDataView";
            servicesDataView.ReadOnly = true;
            servicesDataView.RowHeadersWidth = 51;
            servicesDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            servicesDataView.ShowCellErrors = false;
            servicesDataView.Size = new Size(588, 511);
            servicesDataView.TabIndex = 0;
            // 
            // schedulesTabPage
            // 
            schedulesTabPage.BackColor = Color.FromArgb(43, 49, 55);
            schedulesTabPage.Controls.Add(scheduleRefreshButton);
            schedulesTabPage.Controls.Add(scheduleDeleteButton);
            schedulesTabPage.Controls.Add(scheduleUpdateButton);
            schedulesTabPage.Controls.Add(scheduleCreateButton);
            schedulesTabPage.Controls.Add(schedulesDataView);
            schedulesTabPage.Location = new Point(4, 26);
            schedulesTabPage.Margin = new Padding(3, 2, 3, 2);
            schedulesTabPage.Name = "schedulesTabPage";
            schedulesTabPage.Padding = new Padding(3, 2, 3, 2);
            schedulesTabPage.Size = new Size(757, 515);
            schedulesTabPage.TabIndex = 1;
            schedulesTabPage.Text = "Termini";
            // 
            // scheduleRefreshButton
            // 
            scheduleRefreshButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            scheduleRefreshButton.Location = new Point(597, 297);
            scheduleRefreshButton.Margin = new Padding(3, 2, 3, 2);
            scheduleRefreshButton.Name = "scheduleRefreshButton";
            scheduleRefreshButton.Size = new Size(149, 33);
            scheduleRefreshButton.TabIndex = 8;
            scheduleRefreshButton.Text = "Osveži";
            scheduleRefreshButton.UseVisualStyleBackColor = true;
            scheduleRefreshButton.Click += scheduleRefreshButton_Click;
            // 
            // scheduleDeleteButton
            // 
            scheduleDeleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            scheduleDeleteButton.Location = new Point(597, 260);
            scheduleDeleteButton.Margin = new Padding(3, 2, 3, 2);
            scheduleDeleteButton.Name = "scheduleDeleteButton";
            scheduleDeleteButton.Size = new Size(149, 33);
            scheduleDeleteButton.TabIndex = 7;
            scheduleDeleteButton.Text = "Obriši";
            scheduleDeleteButton.UseVisualStyleBackColor = true;
            scheduleDeleteButton.Click += scheduleDeleteButton_Click;
            // 
            // scheduleUpdateButton
            // 
            scheduleUpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            scheduleUpdateButton.Location = new Point(597, 222);
            scheduleUpdateButton.Margin = new Padding(3, 2, 3, 2);
            scheduleUpdateButton.Name = "scheduleUpdateButton";
            scheduleUpdateButton.Size = new Size(149, 33);
            scheduleUpdateButton.TabIndex = 6;
            scheduleUpdateButton.Text = "Ažuriraj";
            scheduleUpdateButton.UseVisualStyleBackColor = true;
            scheduleUpdateButton.Click += scheduleUpdateButton_Click;
            // 
            // scheduleCreateButton
            // 
            scheduleCreateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            scheduleCreateButton.Location = new Point(597, 184);
            scheduleCreateButton.Margin = new Padding(3, 2, 3, 2);
            scheduleCreateButton.Name = "scheduleCreateButton";
            scheduleCreateButton.Size = new Size(149, 33);
            scheduleCreateButton.TabIndex = 5;
            scheduleCreateButton.Text = "Dodaj";
            scheduleCreateButton.UseVisualStyleBackColor = true;
            scheduleCreateButton.Click += scheduleCreateButton_Click;
            // 
            // schedulesDataView
            // 
            schedulesDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            schedulesDataView.Dock = DockStyle.Left;
            schedulesDataView.Location = new Point(3, 2);
            schedulesDataView.Name = "schedulesDataView";
            schedulesDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            schedulesDataView.ShowCellErrors = false;
            schedulesDataView.Size = new Size(588, 511);
            schedulesDataView.TabIndex = 0;
            // 
            // reservationsTabPage
            // 
            reservationsTabPage.BackColor = Color.FromArgb(43, 49, 55);
            reservationsTabPage.Controls.Add(reservationRefreshButton);
            reservationsTabPage.Controls.Add(reservationDeleteButton);
            reservationsTabPage.Controls.Add(reservationsDataView);
            reservationsTabPage.Location = new Point(4, 26);
            reservationsTabPage.Margin = new Padding(3, 2, 3, 2);
            reservationsTabPage.Name = "reservationsTabPage";
            reservationsTabPage.Size = new Size(757, 515);
            reservationsTabPage.TabIndex = 2;
            reservationsTabPage.Text = "Rezervacije";
            // 
            // reservationRefreshButton
            // 
            reservationRefreshButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reservationRefreshButton.Location = new Point(605, 469);
            reservationRefreshButton.Margin = new Padding(3, 2, 3, 2);
            reservationRefreshButton.Name = "reservationRefreshButton";
            reservationRefreshButton.Size = new Size(149, 33);
            reservationRefreshButton.TabIndex = 7;
            reservationRefreshButton.Text = "Osveži";
            reservationRefreshButton.UseVisualStyleBackColor = true;
            reservationRefreshButton.Click += reservationRefreshButton_Click;
            // 
            // reservationDeleteButton
            // 
            reservationDeleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reservationDeleteButton.Location = new Point(3, 469);
            reservationDeleteButton.Margin = new Padding(3, 2, 3, 2);
            reservationDeleteButton.Name = "reservationDeleteButton";
            reservationDeleteButton.Size = new Size(149, 33);
            reservationDeleteButton.TabIndex = 6;
            reservationDeleteButton.Text = "Otkaži Rezervaciju";
            reservationDeleteButton.UseVisualStyleBackColor = true;
            reservationDeleteButton.Click += reservationDeleteButton_Click;
            // 
            // reservationsDataView
            // 
            reservationsDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservationsDataView.Location = new Point(3, 2);
            reservationsDataView.Name = "reservationsDataView";
            reservationsDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservationsDataView.ShowCellErrors = false;
            reservationsDataView.Size = new Size(751, 462);
            reservationsDataView.TabIndex = 1;
            // 
            // profileTabPage
            // 
            profileTabPage.BackColor = Color.FromArgb(43, 49, 55);
            profileTabPage.Controls.Add(usersBox);
            profileTabPage.Controls.Add(profileGroup);
            profileTabPage.Location = new Point(4, 26);
            profileTabPage.Margin = new Padding(3, 2, 3, 2);
            profileTabPage.Name = "profileTabPage";
            profileTabPage.Size = new Size(757, 515);
            profileTabPage.TabIndex = 3;
            profileTabPage.Text = "Profil";
            // 
            // usersBox
            // 
            usersBox.Controls.Add(usersReservationsButton);
            usersBox.Controls.Add(usersDataView);
            usersBox.Controls.Add(usersRefreshButton);
            usersBox.Dock = DockStyle.Right;
            usersBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            usersBox.ForeColor = Color.FromArgb(250, 251, 252);
            usersBox.Location = new Point(303, 0);
            usersBox.Name = "usersBox";
            usersBox.Size = new Size(454, 515);
            usersBox.TabIndex = 14;
            usersBox.TabStop = false;
            usersBox.Text = "Korisnici";
            // 
            // usersReservationsButton
            // 
            usersReservationsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            usersReservationsButton.ForeColor = SystemColors.ControlText;
            usersReservationsButton.Location = new Point(75, 477);
            usersReservationsButton.Margin = new Padding(3, 2, 3, 2);
            usersReservationsButton.Name = "usersReservationsButton";
            usersReservationsButton.Size = new Size(149, 33);
            usersReservationsButton.TabIndex = 8;
            usersReservationsButton.Text = "Pregledaj rezervacije";
            usersReservationsButton.UseVisualStyleBackColor = true;
            usersReservationsButton.Click += usersReservationsButton_Click;
            // 
            // usersDataView
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            usersDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            usersDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(250, 251, 252);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            usersDataView.DefaultCellStyle = dataGridViewCellStyle2;
            usersDataView.Location = new Point(6, 34);
            usersDataView.Name = "usersDataView";
            usersDataView.ReadOnly = true;
            usersDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersDataView.Size = new Size(442, 438);
            usersDataView.TabIndex = 2;
            // 
            // usersRefreshButton
            // 
            usersRefreshButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            usersRefreshButton.ForeColor = SystemColors.ControlText;
            usersRefreshButton.Location = new Point(230, 477);
            usersRefreshButton.Margin = new Padding(3, 2, 3, 2);
            usersRefreshButton.Name = "usersRefreshButton";
            usersRefreshButton.Size = new Size(149, 33);
            usersRefreshButton.TabIndex = 7;
            usersRefreshButton.Text = "Osveži";
            usersRefreshButton.UseVisualStyleBackColor = true;
            usersRefreshButton.Click += usersRefreshButton_Click;
            // 
            // profileGroup
            // 
            profileGroup.Controls.Add(nameLabel);
            profileGroup.Controls.Add(logoutButton);
            profileGroup.Controls.Add(phoneLabel);
            profileGroup.Controls.Add(emailLabel);
            profileGroup.Dock = DockStyle.Left;
            profileGroup.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            profileGroup.ForeColor = Color.FromArgb(250, 251, 252);
            profileGroup.Location = new Point(0, 0);
            profileGroup.Name = "profileGroup";
            profileGroup.Size = new Size(297, 515);
            profileGroup.TabIndex = 13;
            profileGroup.TabStop = false;
            profileGroup.Text = "Korisnik";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 14.25F);
            nameLabel.Location = new Point(24, 52);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(57, 25);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Ime : ";
            // 
            // logoutButton
            // 
            logoutButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            logoutButton.ForeColor = SystemColors.ControlText;
            logoutButton.Location = new Point(74, 477);
            logoutButton.Margin = new Padding(3, 2, 3, 2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(149, 33);
            logoutButton.TabIndex = 8;
            logoutButton.Text = "Odjavi se";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 14.25F);
            phoneLabel.Location = new Point(24, 102);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(156, 25);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "Kontakt Telefon : ";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 14.25F);
            emailLabel.Location = new Point(24, 77);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(72, 25);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email : ";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 41, 46);
            ClientSize = new Size(784, 561);
            Controls.Add(controlTabs);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dashboard";
            Text = "Početna";
            Shown += Dashboard_Shown;
            controlTabs.ResumeLayout(false);
            servicesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)servicesDataView).EndInit();
            schedulesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)schedulesDataView).EndInit();
            reservationsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)reservationsDataView).EndInit();
            profileTabPage.ResumeLayout(false);
            usersBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)usersDataView).EndInit();
            profileGroup.ResumeLayout(false);
            profileGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl controlTabs;
        private TabPage servicesTabPage;
        private TabPage schedulesTabPage;
        private TabPage reservationsTabPage;
        private DataGridView servicesDataView;
        private TabPage profileTabPage;
        private Button serviceRefreshButton;
        private Button serviceDeleteButton;
        private Button serviceUpdateButton;
        private Button serviceCreateButton;
        private DataGridView schedulesDataView;
        private Button scheduleRefreshButton;
        private Button scheduleDeleteButton;
        private Button scheduleUpdateButton;
        private Button scheduleCreateButton;
        private Button reservationDeleteButton;
        private DataGridView reservationsDataView;
        private Button reservationRefreshButton;
        private DataGridView usersDataView;
        private Button usersRefreshButton;
        private Button logoutButton;
        private Label emailLabel;
        private Label nameLabel;
        private Label phoneLabel;
        private GroupBox profileGroup;
        private GroupBox usersBox;
        private Button usersReservationsButton;
    }
}