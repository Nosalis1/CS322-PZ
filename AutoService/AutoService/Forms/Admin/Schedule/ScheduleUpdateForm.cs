using AutoService.Models.Schedule;
using AutoService.Services;

namespace AutoService.Forms.Admin.Schedule
{
    public partial class ScheduleUpdateForm : Form
    {
        Dictionary<string, int> services;

        private int scheduleID;
        private int serviceID;

        public ScheduleUpdateForm(ScheduleModel schedule)
        {
            InitializeComponent();

            scheduleID = schedule.ID;

            if (schedule.Service == null)
                throw new Exception();

            serviceID = schedule.Service.ID;

            services = ServiceService.Instance.RetrieveAllNames();
            var serviceList = services.ToList();

            serviceComboBox.DataSource = new BindingSource(serviceList, null);
            serviceComboBox.DisplayMember = "Key";
            serviceComboBox.ValueMember = "Value";

            int selectedIndex = serviceList.FindIndex(pair => pair.Value == serviceID);
            if (selectedIndex != -1)
                serviceComboBox.SelectedIndex = selectedIndex;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (serviceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Molimo Vas izaberite Servis!");
                return;
            }
            int serviceID = ((KeyValuePair<string, int>)serviceComboBox.SelectedItem).Value;
            var date = datePicker.Value.Date;
            var time = datePicker.Value.TimeOfDay;
            string statusText = statusInput.Text;

            ScheduleDTO schedule = new ScheduleDTO
            {
                ServiceID = serviceID,
                AvailableDate = date,
                AvailableTime = time,
                Status = statusText
            };

            bool status = ScheduleService.Instance.Update(scheduleID, schedule);
            if (status)
            {
                MessageBox.Show("Termin uspešno ažuriran!");
                this.Close();
                return;
            }
            MessageBox.Show("Greška prilikom ažuriranja termina!");
        }

        private void cancelButton_Click(object sender, EventArgs e) => this.Close();
    }
}
