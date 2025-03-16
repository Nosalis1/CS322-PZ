using AutoService.Forms.Admin.Reservation;
using AutoService.Models.Reservation;
using AutoService.Models.Schedule;
using AutoService.Models.Service;
using AutoService.Models.User;
using AutoService.Services;

namespace AutoService.Forms.Admin
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            controlTabs.Selecting += ControlTabs_Selecting;
            schedulesDataView.CellFormatting += schedulesDataView_CellFormatting;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void ControlTabs_Selecting(object? sender, TabControlCancelEventArgs e) => UpdateAll();

        private void Dashboard_Shown(object sender, EventArgs e) => UpdateAll();

        private void UpdateAll()
        {
            UpdateServicesDataSource();
            UpdateSchedulesDataSource();
            UpdateReservationsDataSource();
            UpdateUsersDataSource();

            nameLabel.Text = $"Ime : {UserService.User?.Name}";
            emailLabel.Text = $"Email : {UserService.User?.Email}";
            phoneLabel.Text = $"Kontakt Telefon : {UserService.User?.Phone}";
        }

        #region Services

        private void UpdateServicesDataSource()
        {
            List<ServiceModel> services = ServiceService.Instance.RetrieveAll();
            servicesDataView.DataSource = null;
            servicesDataView.DataSource = services;

            {
                servicesDataView.Columns["ID"].HeaderText = "Servis ID";
                servicesDataView.Columns["Name"].HeaderText = "Ime";
                servicesDataView.Columns["Description"].HeaderText = "Opis";
                servicesDataView.Columns["Duration"].HeaderText = "Trajanje (min)";
                servicesDataView.Columns["Price"].HeaderText = "Cena";
            }
        }

        private void serviceCreateButton_Click(object sender, EventArgs e)
        {
            Service.ServiceCreateForm popup = new Service.ServiceCreateForm();
            popup.ShowDialog();
            UpdateServicesDataSource();
        }

        private void serviceUpdateButton_Click(object sender, EventArgs e)
        {
            int selectedCount = servicesDataView.SelectedRows.Count;
            if (selectedCount > 0)
            {
                DataGridViewRow selectedRow = servicesDataView.SelectedRows[0];
                ServiceModel selectedService = (ServiceModel)selectedRow.DataBoundItem;

                Service.ServiceUpdateForm popup = new Service.ServiceUpdateForm(selectedService);
                popup.ShowDialog();

                UpdateServicesDataSource();
                return;
            }
            MessageBox.Show("Nije odabran nijedan servis za ažuriranje!");
        }

        private void serviceDeleteButton_Click(object sender, EventArgs e)
        {
            int selectedCount = servicesDataView.SelectedRows.Count;
            if (selectedCount > 0)
            {
                for (int i = 0; i < selectedCount; i++)
                {
                    DataGridViewRow selectedRow = servicesDataView.SelectedRows[i];
                    ServiceModel selectedService = (ServiceModel)selectedRow.DataBoundItem;
                    ServiceService.Instance.Delete(selectedService.ID);
                }

                if (selectedCount == 1)
                    MessageBox.Show("Odabrani servis uspešno obrisan!");
                else
                    MessageBox.Show("Odabrani servisi uspešno obrisani!");

                UpdateServicesDataSource();
                return;
            }
            MessageBox.Show("Nije odabran nijedan servis za brisanje!");
        }

        private void serviceRefreshButton_Click(object sender, EventArgs e) => UpdateServicesDataSource();

        #endregion

        #region Schedules

        private void UpdateSchedulesDataSource()
        {
            List<ScheduleModel> schedules = ScheduleService.Instance.RetrieveAll();
            schedulesDataView.DataSource = null;
            schedulesDataView.DataSource = schedules;

            {
            schedulesDataView.Columns["ID"].HeaderText = "Termin ID";
            schedulesDataView.Columns["ServiceName"].HeaderText = "Servis";
            schedulesDataView.Columns["ServicePrice"].HeaderText = "Cena";
            schedulesDataView.Columns["AvailableDate"].HeaderText = "Datum";
            schedulesDataView.Columns["AvailableTime"].HeaderText = "Vreme";
            schedulesDataView.Columns["Status"].HeaderText = "Status";

            if (schedulesDataView.Columns["Service"] != null)
                schedulesDataView.Columns.Remove("Service");
            }
        }

        private void scheduleCreateButton_Click(object sender, EventArgs e)
        {
            Schedule.ScheduleCreateForm popup = new Schedule.ScheduleCreateForm();
            popup.ShowDialog();
            UpdateSchedulesDataSource();
        }

        private void scheduleUpdateButton_Click(object sender, EventArgs e)
        {
            int selectedCount = schedulesDataView.SelectedRows.Count;
            if (selectedCount > 0)
            {
                DataGridViewRow selectedRow = schedulesDataView.SelectedRows[0];
                ScheduleModel selectedSchedule = (ScheduleModel)selectedRow.DataBoundItem;

                Schedule.ScheduleUpdateForm popup = new Schedule.ScheduleUpdateForm(selectedSchedule);
                popup.ShowDialog();

                UpdateSchedulesDataSource();
                return;
            }
            MessageBox.Show("Nije odabran nijedan termin za ažuriranje!");
        }

        private void scheduleDeleteButton_Click(object sender, EventArgs e)
        {
            int selectedCount = schedulesDataView.SelectedRows.Count;
            if (selectedCount > 0)
            {
                for (int i = 0; i < selectedCount; i++)
                {
                    DataGridViewRow selectedRow = schedulesDataView.SelectedRows[i];
                    ScheduleModel selectedSchedule = (ScheduleModel)selectedRow.DataBoundItem;
                    ScheduleService.Instance.Delete(selectedSchedule.ID);
                }

                if (selectedCount == 1)
                    MessageBox.Show("Odabrani termin uspešno obrisan!");
                else
                    MessageBox.Show("Odabrani termini uspešno obrisani!");

                UpdateSchedulesDataSource();
                return;
            }
            MessageBox.Show("Nije odabran nijedan termin za brisanje!");
        }

        private void scheduleRefreshButton_Click(object sender, EventArgs e) => UpdateSchedulesDataSource();

        #endregion

        #region Reservations

        private void UpdateReservationsDataSource()
        {
            List<ReservationModel> reservations = ReservationService.Instance.RetrieveAll();
            reservationsDataView.DataSource = null;
            reservationsDataView.DataSource = reservations;

            reservationsDataView.Columns["ID"].HeaderText = "Rezervacija ID";
            reservationsDataView.Columns["UserName"].HeaderText = "Korisnik";
            reservationsDataView.Columns["Phone"].HeaderText = "Telefon";
            reservationsDataView.Columns["ServiceName"].HeaderText = "Servis";
            reservationsDataView.Columns["ServicePrice"].HeaderText = "Cena";
            reservationsDataView.Columns["AvailableDate"].HeaderText = "Datum";
            reservationsDataView.Columns["AvailableTime"].HeaderText = "Vreme";

            if (reservationsDataView.Columns["User"] != null)
                reservationsDataView.Columns.Remove("User");
            if (reservationsDataView.Columns["Schedule"] != null)
                reservationsDataView.Columns.Remove("Schedule");
        }

        private void reservationDeleteButton_Click(object sender, EventArgs e)
        {
            int selectedCount = reservationsDataView.SelectedRows.Count;
            if (selectedCount > 0)
            {
                for (int i = 0; i < selectedCount; i++)
                {
                    DataGridViewRow selectedRow = reservationsDataView.SelectedRows[i];
                    ReservationModel selectedReservation = (ReservationModel)selectedRow.DataBoundItem;
                    ReservationService.Instance.Delete(selectedReservation.ID);
                }

                if (selectedCount == 1)
                    MessageBox.Show("Odabrana rezervacija uspešno obrisana!");
                else
                    MessageBox.Show("Odabrane rezervacije uspešno obrisane!");

                UpdateReservationsDataSource();
                return;
            }
            MessageBox.Show("Nije odabrana nijedna rezervacija za brisanje!");
        }

        private void reservationRefreshButton_Click(object sender, EventArgs e) => UpdateReservationsDataSource();

        #endregion

        #region Users

        private void UpdateUsersDataSource()
        {
            List<UserDTO> users = UserService.Instance.RetrieveAll();
            usersDataView.DataSource = null;
            usersDataView.DataSource = users;
        }

        private void usersRefreshButton_Click(object sender, EventArgs e) => UpdateUsersDataSource();

        private void usersReservationsButton_Click(object sender, EventArgs e)
        {
            if (usersDataView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = usersDataView.SelectedRows[0];
                object? item = row.DataBoundItem;
                if (item != null)
                {
                    UserDTO? selected = item as UserDTO;
                    if (selected != null)
                    {
                        ReservationUserPreviewForm popup = new ReservationUserPreviewForm(selected.ID);
                        popup.ShowDialog();
                    }
                }
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            UserService.Instance.Logout();
            this.Hide();

            FormControl.LoginForm.Show();
        }

        #endregion

        private void schedulesDataView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (schedulesDataView.Columns[e.ColumnIndex].Name == "Status")
            {
                string? status = e.Value?.ToString();

                if (!string.IsNullOrEmpty(status))
                {
                    DataGridViewRow row = schedulesDataView.Rows[e.RowIndex];

                    switch (status)
                    {
                        case "Available":
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        case "Reserved":
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                            break;
                        case "In Progress":
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            break;
                        default:
                            row.DefaultCellStyle.BackColor = Color.White;
                            break;
                    }
                }
            }
        }
    }
}
