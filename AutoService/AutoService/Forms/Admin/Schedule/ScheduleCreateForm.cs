using AutoService.Models.Schedule;
using AutoService.Services;

namespace AutoService.Forms.Admin.Schedule
{
    public partial class ScheduleCreateForm : Form
    {
        Dictionary<string, int> services;

        public ScheduleCreateForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            services = ServiceService.Instance.RetrieveAllNames();

            serviceComboBox.DataSource = new BindingSource(services.ToList(), null);
            serviceComboBox.DisplayMember = "Key";
            serviceComboBox.ValueMember = "Value";
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

            ScheduleDTO shcedule = new ScheduleDTO
            {
                ServiceID = serviceID,
                AvailableDate = date,
                AvailableTime = time,
                Status = statusText
            };

            bool status = ScheduleService.Instance.Create(shcedule);
            if (status)
            {
                MessageBox.Show("Termin uspešno kreiran!");
                this.Close();
                return;
            }
            MessageBox.Show("Greška prilikom kreiranja termina!");
        }

        private void cancelButton_Click(object sender, EventArgs e) => this.Close();
    }
}
