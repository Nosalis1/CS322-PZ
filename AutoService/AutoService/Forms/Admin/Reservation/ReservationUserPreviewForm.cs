using AutoService.Models.Reservation;
using AutoService.Services;

namespace AutoService.Forms.Admin.Reservation
{
    public partial class ReservationUserPreviewForm : Form
    {
        private int userID;
        private List<ReservationModel>? reservations = null;

        public ReservationUserPreviewForm(int userID)
        {
            this.userID = userID;
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            UpdateDataObject();
        }

        private void UpdateDataObject()
        {
            reservations = ReservationService.Instance.RetrieveAll(userID);
            if (reservations == null) this.Close();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reservations;
        }
    }
}