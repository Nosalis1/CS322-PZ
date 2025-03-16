using AutoService.Models.Service;
using AutoService.Services;

namespace AutoService.Forms.User.Service
{
    public partial class ServiceInfoForm : Form
    {
        private int serviceID;

        public ServiceInfoForm(int serviceID)
        {
            this.serviceID = serviceID;
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            ServiceModel? service = ServiceService.Instance.Retrieve(serviceID);
            if (service == null)
            {
                this.Close();
                return;
            }
            nameLabel.Text = $"Ime servisa : \n{service.Name}";
            descriptionLabel.Text = "Opis :";
            richTextBox1.Text = service.Description;
            durationLabel.Text = $"Trajanje : {service.Duration.ToString()} min";
            priceLabel.Text = $"Cena : {service.Price.ToString()} rsd";
        }
    }
}
