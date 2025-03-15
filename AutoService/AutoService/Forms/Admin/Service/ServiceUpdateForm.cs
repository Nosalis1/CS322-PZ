using AutoService.Models.Service;
using AutoService.Services;

namespace AutoService.Forms.Admin.Service
{
    public partial class ServiceUpdateForm : Form
    {
        private int serviceID;

        public ServiceUpdateForm(ServiceModel service)
        {
            serviceID = service.ID;
            InitializeComponent();

            nameInput.Text = service.Name;
            descriptionInput.Text = service.Description;
            durationInput.Text = service.Duration.ToString();
            priceInput.Text = service.Price.ToString();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string description = descriptionInput.Text;
            string durationText = durationInput.Text;
            string priceText = priceInput.Text;

            try
            {
                int duration = int.Parse(durationText);
                double price = double.Parse(priceText);

                ServiceDTO service = new ServiceDTO
                {
                    Name = name,
                    Description = description,
                    Duration = duration,
                    Price = price
                };

                bool status = ServiceService.Update(serviceID, service);
                if (status)
                {
                    MessageBox.Show("Servis uspešno ažuriran!");
                    this.Close();
                    return;
                }
                MessageBox.Show("Greška prilikom ažuriranja servisa!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Greška u podacima!");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) => this.Close();
    }
}
