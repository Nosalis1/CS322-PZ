using AutoService.Models.User;
using AutoService.Services;

namespace AutoService.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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
            this.usernameInput.Clear();
            this.passwordInput.Clear();
        }

        private void registrationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormControl.LoginForm.Hide();
            FormControl.RegistrationForm.Location = FormControl.LoginForm.Location;
            FormControl.RegistrationForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            CredentialsDTO credentials = new CredentialsDTO
            {
                Username = username,
                Password = password
            };

            bool status = UserService.Instance.Login(credentials);
            if (status)
            {
                FormControl.LoginForm.Hide();

                if (UserService.IsAdmin)
                {
                    FormControl.AdminDashboardForm.Show();
                    return;
                }

                FormControl.UserDashboardForm.Show();
                return;
            }

            MessageBox.Show("Prijava nije uspešna. Pokušajte ponovo!");
        }
    }
}
