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
            controlTabs = new TabControl();
            servicesTabPage = new TabPage();
            servicesDataView = new DataGridView();
            schedulesTabPage = new TabPage();
            reservationsTabPage = new TabPage();
            profileTabPage = new TabPage();
            createButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            refreshButton = new Button();
            controlTabs.SuspendLayout();
            servicesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicesDataView).BeginInit();
            SuspendLayout();
            // 
            // controlTabs
            // 
            controlTabs.Controls.Add(servicesTabPage);
            controlTabs.Controls.Add(schedulesTabPage);
            controlTabs.Controls.Add(reservationsTabPage);
            controlTabs.Controls.Add(profileTabPage);
            controlTabs.Location = new Point(12, 12);
            controlTabs.Name = "controlTabs";
            controlTabs.SelectedIndex = 0;
            controlTabs.Size = new Size(1217, 606);
            controlTabs.TabIndex = 0;
            // 
            // servicesTabPage
            // 
            servicesTabPage.BackColor = Color.Gainsboro;
            servicesTabPage.Controls.Add(refreshButton);
            servicesTabPage.Controls.Add(deleteButton);
            servicesTabPage.Controls.Add(updateButton);
            servicesTabPage.Controls.Add(createButton);
            servicesTabPage.Controls.Add(servicesDataView);
            servicesTabPage.Location = new Point(4, 29);
            servicesTabPage.Name = "servicesTabPage";
            servicesTabPage.Padding = new Padding(3);
            servicesTabPage.Size = new Size(1209, 573);
            servicesTabPage.TabIndex = 0;
            servicesTabPage.Text = "Services";
            // 
            // servicesDataView
            // 
            servicesDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicesDataView.Location = new Point(6, 6);
            servicesDataView.Name = "servicesDataView";
            servicesDataView.RowHeadersWidth = 51;
            servicesDataView.Size = new Size(1021, 561);
            servicesDataView.TabIndex = 0;
            // 
            // schedulesTabPage
            // 
            schedulesTabPage.BackColor = Color.Gainsboro;
            schedulesTabPage.Location = new Point(4, 29);
            schedulesTabPage.Name = "schedulesTabPage";
            schedulesTabPage.Padding = new Padding(3);
            schedulesTabPage.Size = new Size(768, 393);
            schedulesTabPage.TabIndex = 1;
            schedulesTabPage.Text = "Schedules";
            // 
            // reservationsTabPage
            // 
            reservationsTabPage.BackColor = Color.Gainsboro;
            reservationsTabPage.Location = new Point(4, 29);
            reservationsTabPage.Name = "reservationsTabPage";
            reservationsTabPage.Size = new Size(768, 393);
            reservationsTabPage.TabIndex = 2;
            reservationsTabPage.Text = "Reservations";
            // 
            // profileTabPage
            // 
            profileTabPage.BackColor = Color.Gainsboro;
            profileTabPage.Location = new Point(4, 29);
            profileTabPage.Name = "profileTabPage";
            profileTabPage.Size = new Size(768, 393);
            profileTabPage.TabIndex = 3;
            profileTabPage.Text = "Profile";
            // 
            // createButton
            // 
            createButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            createButton.Location = new Point(1033, 6);
            createButton.Name = "createButton";
            createButton.Size = new Size(170, 44);
            createButton.TabIndex = 1;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            updateButton.Location = new Point(1033, 56);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(170, 44);
            updateButton.TabIndex = 2;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteButton.Location = new Point(1033, 106);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(170, 44);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            refreshButton.Location = new Point(1033, 156);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(170, 44);
            refreshButton.TabIndex = 4;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 630);
            Controls.Add(controlTabs);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            controlTabs.ResumeLayout(false);
            servicesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)servicesDataView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl controlTabs;
        private TabPage servicesTabPage;
        private TabPage schedulesTabPage;
        private TabPage reservationsTabPage;
        private DataGridView servicesDataView;
        private TabPage profileTabPage;
        private Button refreshButton;
        private Button deleteButton;
        private Button updateButton;
        private Button createButton;
    }
}