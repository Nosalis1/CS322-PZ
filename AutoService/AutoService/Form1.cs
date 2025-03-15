using AutoService.Forms;

namespace AutoService
{
    public partial class Form1 : Form
    {
        public static Form LoginForm = new LoginForm();
        public static Form RegistrationForm = new RegistrationForm();

        public static Form AdminDashboardForm = new Forms.Admin.Dashboard();
        public static Form UserDashboardForm = new Forms.User.Dashboard();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide(); // This not working ?? 
            LoginForm.Show();
        }
    }
}
