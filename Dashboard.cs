﻿namespace Latihan_DesktopApp
{
    public partial class Dashboard : Form
    {
        public string username { get; set; }
        public Dashboard()
        {
            InitializeComponent();
            this.ControlBox = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void loadPanel(object form)
        {
            if (this.main.Controls.Count > 0)
                this.main.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.main.Controls.Add(f);
            this.main.Tag = f;
            f.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadPanel(new Employee());
            userInfo.Text = "Hi, " + username;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            loadPanel(new Employee());

        }

        private void userInfo_Click(object sender, EventArgs e)
        {

        }

        private void main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            loadPanel(new Membershipcs());
        }

        private void btnVehicletype_Click(object sender, EventArgs e)
        {
            loadPanel(new VehicleType());
        }

        private void btnHourlyRates_Click(object sender, EventArgs e)
        {
            loadPanel(new HourlyRates());
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            loadPanel(new Member());
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            loadPanel(new Vehicle());
        }

        private void btnParkingData_Click(object sender, EventArgs e)
        {
            loadPanel(new ParkingData());
        }
    }
}
