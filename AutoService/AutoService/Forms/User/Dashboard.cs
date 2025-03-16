using AutoService.Forms.Admin.Reservation;
using AutoService.Forms.User.Service;
using AutoService.Models.Reservation;
using AutoService.Models.Schedule;
using AutoService.Services;

namespace AutoService.Forms.User
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            VisibleChanged += this.OnVisibleChanged;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void OnVisibleChanged(object? sender, EventArgs e)
        {
            if (!this.Visible) return;
            UpdateAll();
            if (UserService.User != null)
            {
                this.usernameLabel.Text = UserService.User.Name;
                this.contactLabel.Text = $"Email : {UserService.User.Email}\nTelefon : {UserService.User.Phone}";
            }
        }

        private void Dashboard_Shown(object sender, EventArgs e) => UpdateAll();

        private void contactUpateButton_Click(object sender, EventArgs e)
        {
            Contact.UserContactForm popup = new Contact.UserContactForm();
            popup.ShowDialog();
            if (UserService.User != null)
            {
                this.usernameLabel.Text = UserService.User.Name;
                this.contactLabel.Text = $"Email : {UserService.User.Email}\nTelefon : {UserService.User.Phone}";
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            UserService.Instance.Logout();
            this.Hide();
            FormControl.LoginForm.Show();
        }

        private void UpdateAll()
        {
            UpdateServicesDataSource();
            UpdateSchedulesDataSource();
            UpdateReservationsDataSource();
        }

        #region Services

        private void UpdateServicesDataSource()
        {
            Dictionary<string, int> services = ServiceService.Instance.RetrieveAllNames();
            servicesListBox.DataSource = null;
            servicesListBox.DataSource = new BindingSource(services.ToList(), null);
            servicesListBox.DisplayMember = "Key";
            servicesListBox.ValueMember = "Value";
        }

        private void servicesRefreshButton_Click(object sender, EventArgs e) => UpdateServicesDataSource();

        private void servicesInfoButton_Click(object sender, EventArgs e)
        {
            if (servicesListBox.SelectedItem != null)
            {
                int serviceID = ((KeyValuePair<string, int>)servicesListBox.SelectedItem).Value;
                ServiceInfoForm popup = new ServiceInfoForm(serviceID);
                popup.ShowDialog();
            }
        }

        #endregion

        #region Schedules

        private void UpdateSchedulesDataSource()
        {
            List<ScheduleModel> schedules = ScheduleService.Instance.RetrieveAllAvailable();
            schedulesView.DataSource = null;
            schedulesView.DataSource = schedules;

            schedulesView.Columns["ID"].HeaderText = "Termin ID";
            schedulesView.Columns["ServiceName"].HeaderText = "Servis";
            schedulesView.Columns["ServicePrice"].HeaderText = "Cena";
            schedulesView.Columns["AvailableDate"].HeaderText = "Datum";
            schedulesView.Columns["AvailableTime"].HeaderText = "Vreme";
            schedulesView.Columns["Status"].HeaderText = "Status";

            if (schedulesView.Columns["Service"] != null)
                schedulesView.Columns.Remove("Service");
            if (schedulesView.Columns["Status"] != null)
                schedulesView.Columns.Remove("Status");
        }

        private void scheduleReserveButton_Click(object sender, EventArgs e)
        {
            if (UserService.User == null) return;
            int userID = UserService.User.ID;

            if (schedulesView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = schedulesView.SelectedRows[0];
                object? item = selectedRow.DataBoundItem;
                if (item == null) return;
                ScheduleModel? selectedSchedule = item as ScheduleModel;
                if (selectedSchedule != null)
                {
                    bool status = ReservationService.Instance.MakeReservation(userID, selectedSchedule.ID);
                    if (status)
                    {
                        MessageBox.Show("Termin uspešno rezervisan!");
                        UpdateSchedulesDataSource();
                        UpdateReservationsDataSource();
                        return;
                    }
                    MessageBox.Show("Nije moguće rezervisati termin!");
                }
            }
        }

        private void schedulesRefreshButton_Click(object sender, EventArgs e) => UpdateSchedulesDataSource();

        #endregion

        #region Reservations

        private void UpdateReservationsDataSource()
        {
            if (UserService.User == null) return;
            int userID = UserService.User.ID;
            List<ReservationModel> reservations = ReservationService.Instance.RetrieveAll(userID);

            reservationsView.DataSource = null;
            reservationsView.DataSource = reservations;

            reservationsView.Columns["ID"].HeaderText = "Rezervacija ID";
            reservationsView.Columns["ServiceName"].HeaderText = "Servis";
            reservationsView.Columns["ServicePrice"].HeaderText = "Cena";
            reservationsView.Columns["AvailableDate"].HeaderText = "Datum";
            reservationsView.Columns["AvailableTime"].HeaderText = "Vreme";

            string[] remove = { "User", "Schedule", "UserName", "Phone", "Email", "Status" };
            foreach (string itemToRemove in remove)
            {
                if (reservationsView.Columns[itemToRemove] != null)
                {
                    reservationsView.Columns.Remove(itemToRemove);
                }
            }
        }

        private void reservationsCancelButton_Click(object sender, EventArgs e)
        {
            if (UserService.User == null) return;
            int userID = UserService.User.ID;

            if (reservationsView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = reservationsView.SelectedRows[0];
                object? item = selectedRow.DataBoundItem;
                if (item == null) return;
                ReservationModel? selectedReservation = item as ReservationModel;
                if (selectedReservation != null)
                {
                    bool status = ReservationService.Instance.CancelReservation(userID, selectedReservation.ID);
                    if (status)
                    {
                        MessageBox.Show("Rezervacija uspešno otkazana!");
                        UpdateSchedulesDataSource();
                        UpdateReservationsDataSource();
                        return;
                    }
                    MessageBox.Show("Nije moguće otkazati rezervaciju!");
                }
            }
        }

        private void reservationsRefreshButton_Click(object sender, EventArgs e) => UpdateReservationsDataSource();

        #endregion
    }
}