using System.Data;

/*
 Logika Parking Data : 
    - kolom [license_plate]      -> mereferensikan data dari tabel vehicle (COMBOBOX)
    - kolom [vehicle_id]         -> mereferensikan data dari tabel vehicle (COMBOBOX)
    - kolom [employee_id]        -> mereferensikan data dari tabel employee (COMBOBOX)
    - kolom [hourly_rates_id]    -> mereferensikan data dari tabel hourlyRates (COMBOBOX)
    - kolom [datetime_in]        -> data kapan kendaraan masuk (DATETIME)
    - kolom [datetime_out]       -> data kapan kendaraan keluar (DATETIME)
    - kolom [amount_to_pay]      -> jumlah harga yang harus dibayar sesuai dengan kolom [hourly_rates_id] dihitung perjam (VARCHAR)
 */

namespace Latihan_DesktopApp
{
    public partial class ParkingData : Form
    {
        public ParkingData()
        {
            InitializeComponent();
        }

        private void FillComboBox()
        {
            string tableVehicle = "vehicle";
            string tableEmployee = "employee";
            string tableHourlyRates = "hourlyrates";

            string columnLicense = "license_plate";
            string columnID = "id";

            DataTable dt;
            dt = DBHelper.GetData(tableVehicle);
            if (dt != null)
            {
                cbLicense.DataSource = dt;
                cbLicense.DisplayMember = columnLicense;
                cbLicense.ValueMember = columnLicense;

                cbVehicle.DataSource = dt;
                cbVehicle.DisplayMember = columnID;
                cbVehicle.ValueMember = columnID;
            }

            dt = DBHelper.GetData(tableEmployee);
            if (dt != null)
            {
                cbEmployee.DataSource = dt;
                cbEmployee.DisplayMember = "name";
                cbEmployee.ValueMember = columnID;
            }

            dt = DBHelper.GetData(tableHourlyRates);
            if (dt != null)
            {
                cbHourlyRates.DataSource = dt;
                cbHourlyRates.DisplayMember = "value";
                cbHourlyRates.ValueMember = columnID;
            }
        }

        private void ParkingData_Load(object sender, EventArgs e)
        {
            FillComboBox();

            DataTable dt = DBHelper.GetData("parkingdata");

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Text = "Delete";
            btnDelete.HeaderText = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Text = "Edit";
            btnEdit.HeaderText = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;

            dgparkingData.DataSource = dt;
            dgparkingData.Columns.Add(btnEdit);
            dgparkingData.Columns.Add(btnDelete);
            dgparkingData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgparkingData.AllowUserToAddRows = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnJumlah_Click(object sender, EventArgs e)
        {
            DateTime time_in = dtTimeIn.Value;
            DateTime time_out = dtTimeOut.Value;

            TimeSpan duration = time_out - time_in;
            double totalHours = duration.TotalHours;

            string strPrice = cbHourlyRates.Text; //2000,00
            string strPriceR = strPrice.Replace(",", ""); //200000
            int commaIndex = strPrice.IndexOf(",");
            if (commaIndex != -1)
            {
                strPriceR = strPriceR.Substring(0, commaIndex); // Misalnya, "2000"
            }

            int price = int.Parse(strPriceR);
            double total = totalHours * price;
            int amount = (int)total;
            tbAmount.Text = "Rp. " + amount.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string license_plate = cbLicense.SelectedValue.ToString();
            string vehicle_id = cbVehicle.SelectedValue.ToString();
            string employee_id = cbEmployee.SelectedValue.ToString();
            string hourly_rates_id = cbHourlyRates.SelectedValue.ToString();

            string _amount = tbAmount.Text;
            string strAmount = _amount.Replace("Rp.", "");

            DateTime datetime_in = dtTimeIn.Value;
            DateTime datetime_out = dtTimeOut.Value;

            string amount_to_pay = tbAmount.ToString();

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("license_plate", license_plate);
            data.Add("vehicle_id", vehicle_id);
            data.Add("employee_id", employee_id);
            data.Add("hourly_rates_id", cbHourlyRates.SelectedValue);
            data.Add("datetime_in", datetime_in);
            data.Add("datetime_out", datetime_out);
            data.Add("amount_to_pay", strAmount);

            int result = DBHelper.Insert("parkingdata", data);
            if (result != 0)
            {
                MessageBox.Show("Success");
                RefreshLoad();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void RefreshLoad()
        {
            DataTable dt = DBHelper.GetData("parkingdata");
            dgparkingData.DataSource = dt;
        }

        public int id;
        private void dgparkingData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgparkingData.Rows[e.RowIndex].Cells["id"].Value);

            //edit
            if (dgparkingData.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgparkingData.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex >= 0)
            {
                cbLicense.SelectedValue = dgparkingData.Rows[e.RowIndex].Cells["license_plate"].Value;
                cbVehicle.SelectedValue = dgparkingData.Rows[e.RowIndex].Cells["vehicle_id"].Value;
                cbEmployee.SelectedValue = dgparkingData.Rows[e.RowIndex].Cells["employee_id"].Value;
                cbHourlyRates.SelectedValue = dgparkingData.Rows[e.RowIndex].Cells["hourly_rates_id"].Value;

                dtTimeIn.Value = DateTime.Parse(dgparkingData.Rows[e.RowIndex].Cells["datetime_in"].Value.ToString());
                dtTimeOut.Value = DateTime.Parse(dgparkingData.Rows[e.RowIndex].Cells["datetime_out"].Value.ToString());

                tbAmount.Text = "Rp. " + dgparkingData.Rows[e.RowIndex].Cells["amount_to_pay"].Value.ToString();

                btnSimpanUpdate.Visible = true;
                btnSimpan.Visible = false;
            }
            //delete
            if (dgparkingData.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgparkingData.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex >= 0)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("deleted_at", DateTime.Now);

                DialogResult dr = MessageBox.Show("Ini akan menghapus data sementara!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int result = DBHelper.Update("parkingdata", data, "id = " + id);
                    RefreshLoad();
                }
            }
        }

        private void btnSimpanUpdate_Click(object sender, EventArgs e)
        {
            string license_plate = cbLicense.SelectedValue.ToString();
            string vehicle_id = cbVehicle.SelectedValue.ToString();
            string employee_id = cbEmployee.SelectedValue.ToString();
            string hourly_rates_id = cbHourlyRates.SelectedValue.ToString();

            string _amount = tbAmount.Text;
            string strAmount = _amount.Replace("Rp.", "");

            DateTime datetime_in = dtTimeIn.Value;
            DateTime datetime_out = dtTimeOut.Value;

            string amount_to_pay = tbAmount.ToString();

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("license_plate", license_plate);
            data.Add("vehicle_id", vehicle_id);
            data.Add("employee_id", employee_id);
            data.Add("hourly_rates_id", cbHourlyRates.SelectedValue);
            data.Add("datetime_in", datetime_in);
            data.Add("datetime_out", datetime_out);
            data.Add("amount_to_pay", strAmount);
            data.Add("last_updated_at", DateTime.Now);

            int result = DBHelper.Update("parkingdata", data, "id = " + id);
            if (result != 0)
            {
                MessageBox.Show("Success to Update");
                RefreshLoad();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSimpanUpdate.Visible = false;
            btnSimpan.Visible = true;
        }
    }
}
