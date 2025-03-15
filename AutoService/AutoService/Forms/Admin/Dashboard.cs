using AutoService.Models.Service;
using AutoService.Services;

namespace AutoService.Forms.Admin
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void UpdateDataSource()
        {
            List<ServiceModel> services = ServiceService.RetrieveAll();
            servicesDataView.DataSource = services;

            servicesDataView.Columns["ID"].HeaderText = "Service ID";
            servicesDataView.Columns["Name"].HeaderText = "Service Name";
            servicesDataView.Columns["Description"].HeaderText = "Service Description";
            servicesDataView.Columns["Duration"].HeaderText = "Duration (min)";
            servicesDataView.Columns["Price"].HeaderText = "Price ($)";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            UpdateDataSource();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Service.ServiceCreateForm popup = new Service.ServiceCreateForm();
            popup.ShowDialog();
            UpdateDataSource();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int selectedCount = servicesDataView.SelectedRows.Count;
            if (selectedCount > 0)
            {
                DataGridViewRow selectedRow = servicesDataView.SelectedRows[0];
                ServiceModel selectedService = (ServiceModel)selectedRow.DataBoundItem;

                Service.ServiceUpdateForm popup = new Service.ServiceUpdateForm(selectedService);
                popup.ShowDialog();

                UpdateDataSource();
                return;
            }
            MessageBox.Show("Nije odabran nijedan servis za ažuriranje!");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedCount = servicesDataView.SelectedRows.Count;
            if (selectedCount > 0)
            {
                for (int i = 0; i < selectedCount; i++)
                {
                    DataGridViewRow selectedRow = servicesDataView.SelectedRows[i];
                    ServiceModel selectedService = (ServiceModel)selectedRow.DataBoundItem;
                    ServiceService.Delete(selectedService.ID);
                }

                if (selectedCount == 1)
                    MessageBox.Show("Odabrani servis uspešno obrisan!");
                else
                    MessageBox.Show("Odabrani servisi uspešno obrisani!");

                UpdateDataSource();
                return;
            }
            MessageBox.Show("Nije odabran nijedan servis za brisanje!");
        }

        private void refreshButton_Click(object sender, EventArgs e) => UpdateDataSource();
    }
}
