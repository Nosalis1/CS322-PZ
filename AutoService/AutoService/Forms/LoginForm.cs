using AutoService.Models.User;
using AutoService.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registrationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1.LoginForm.Hide();
            Form1.RegistrationForm.Show();
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

            bool status = UserService.Login(credentials);
            if (status)
            {
                Form1.LoginForm.Hide();

                if (UserService.IsAdmin)
                {
                    Form1.AdminDashboardForm.Show();
                    return;
                }

                Form1.UserDashboardForm.Show();
                return;
            }

            MessageBox.Show("Prijava nije uspešna. Pokušajte ponovo!");
        }
    }
}
