using AutoService.Models.User;
using AutoService.Services;

namespace AutoService.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.VisibleChanged += OnVisibleChanged;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void OnVisibleChanged(object? sender, EventArgs e)
        {
            if (!this.Visible) return;
            usernameInput.Clear();
            passwordInput.Clear();
            emailInput.Clear();
            phoneInput.Clear();
        }

        private void registrationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormControl.RegistrationForm.Hide();
            FormControl.LoginForm.Location = FormControl.RegistrationForm.Location;
            FormControl.LoginForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            string email = emailInput.Text;
            string phone = phoneInput.Text;

            CredentialsDTO credentials = new CredentialsDTO
            {
                Username = username,
                Password = password,
                Email = email,
                Phone = phone,
            };

            bool status = UserService.Instance.Register(credentials);
            if (status)
            {
                MessageBox.Show("Uspešno ste kreirali nalog!");
                FormControl.RegistrationForm.Hide();
                FormControl.LoginForm.Show();
                return;
            }

            MessageBox.Show("Registracija nije uspešna. Pokušajte ponovo!");
        }
    }
}
