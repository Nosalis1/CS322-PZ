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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registrationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1.RegistrationForm.Hide();
            Form1.LoginForm.Show();
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

            bool status = UserService.Register(credentials);
            if (status)
            {
                MessageBox.Show("Uspešno ste kreirali nalog!");
                Form1.RegistrationForm.Hide();
                Form1.LoginForm.Show();
                return;
            }

            MessageBox.Show("Registracija nije uspešna. Pokušajte ponovo!");
        }
    }
}
