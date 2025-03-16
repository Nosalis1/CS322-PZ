using AutoService.Forms;

namespace AutoService
{
    public partial class FormControl
    {
        public static Form LoginForm = new LoginForm();
        public static Form RegistrationForm = new RegistrationForm();

        public static Form AdminDashboardForm = new Forms.Admin.Dashboard();
        public static Form UserDashboardForm = new Forms.User.Dashboard();

        public static void CloseAll()
        {
            UserDashboardForm.Close();
            AdminDashboardForm.Close();

            RegistrationForm.Close();
            LoginForm.Close();
        }
    }
}
