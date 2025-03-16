using AutoService.Models.User;
using AutoService.Services;

namespace AutoService.Forms.User.Contact
{
    public partial class UserContactForm : Form
    {
        public UserContactForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            if (UserService.User != null)
            {
                emailinput.Text = UserService.User.Email;
                phoneInput.Text = UserService.User.Phone;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (UserService.User == null) return;
            int userID = UserService.User.ID;
            UserDTO userDTO = new UserDTO
            {
                ID = userID,
                Name = UserService.User.Name,
                Email = emailinput.Text,
                Phone = phoneInput.Text,
                Rola = UserService.User.Rola
            };
            bool status = UserService.Instance.Update(userID, userDTO);
            if (status)
            {
                MessageBox.Show("Kontakt uspešno izmenjen!");
                this.Close();
                return;
            }
            MessageBox.Show("Nije moguće izmeniti kontakt!");
        }

        private void cancelButton_Click(object sender, EventArgs e) => this.Close();
    }
}
