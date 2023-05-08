using System.Data;

namespace Latihan_DesktopApp
{
    public partial class Vehicle : Form
    {
        public Vehicle()
        {
            InitializeComponent();
        }

        private void FillComboBox()
        {
            string tableMember = "member";
            string tableVehicleType = "vehicletype";
            string column = "name";
            string columnMember = "id";
            string columnVehicleType = "id";

            //Feild Data Member
            DataTable dtMember = DBHelper.GetData(tableMember);
            if (dtMember != null)
            {
                cbMember.DataSource = dtMember;
                cbMember.DisplayMember = column;
                cbMember.ValueMember = columnMember;
            }

            //Feild Data VehicleType
            DataTable dtVehicleType = DBHelper.GetData(tableVehicleType);
            if (dtMember != null)
            {
                cbVehicleType.DataSource = dtVehicleType;
                cbVehicleType.DisplayMember = column;
                cbVehicleType.ValueMember = columnVehicleType;
            }


        }

        private void RefreshPage()
        {
            DataTable dt = DBHelper.GetData("vehicle");
            dataGridVehicle.DataSource = dt;
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            FillComboBox();

            DataTable dt = DBHelper.GetData("vehicle");

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();

            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            btnEdit.HeaderText = "Edit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;

            dataGridVehicle.DataSource = dt;
            dataGridVehicle.Columns.Add(btnDelete);
            dataGridVehicle.Columns.Add(btnEdit);
            dataGridVehicle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVehicle.AllowUserToAddRows = false;


        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int member_id = (int)cbMember.SelectedValue;
            int vehilceType_id = (int)cbVehicleType.SelectedValue;
            string plate = tbPlate.Text;
            string notes = tbNote.Text;


            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("vehicle_type_id", vehilceType_id);
            data.Add("member_id", member_id);
            data.Add("license_plate", plate);
            data.Add("notes", notes);


            if (plate == string.Empty)
            {
                MessageBox.Show("Masukan Nomer Plat Kendaraan!");
                return;
            }

            int result = DBHelper.Insert("vehicle", data);
            if (result > 0)
            {
                MessageBox.Show("Success");
                RefreshPage();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        public int id;
        private void dataGridVehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridVehicle.Rows[e.RowIndex].Cells["id"].Value);

            //Edit
            if (dataGridVehicle.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dataGridVehicle.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex >= 0)
            {

                cbMember.SelectedValue = dataGridVehicle.Rows[e.RowIndex].Cells["member_id"].Value;
                cbVehicleType.SelectedValue = dataGridVehicle.Rows[e.RowIndex].Cells["vehicle_type_id"].Value;
                tbPlate.Text = dataGridVehicle.Rows[e.RowIndex].Cells["license_plate"].Value.ToString();
                tbNote.Text = dataGridVehicle.Rows[e.RowIndex].Cells["notes"].Value.ToString();
            }

            //Delete
            if (dataGridVehicle.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dataGridVehicle.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex >= 0)
            {
                if (!string.IsNullOrEmpty(dataGridVehicle.Rows[e.RowIndex].Cells["deleted_at"].Value.ToString()))
                {
                    DialogResult d = MessageBox.Show("Ini akan membuat data dihapus secara permanen!, Lanjutkan?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        int r = DBHelper.Delete("vehicle", "id = " + id);
                        if (r != 0)
                        {
                            MessageBox.Show("Deleted Success");
                            RefreshPage();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Failed!");
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }

                DialogResult dr = MessageBox.Show("Tindakan ini hanya akan menghapusnya sementara, Lanjutkan?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    Dictionary<string, object> data = new Dictionary<string, object>();
                    data.Add("deleted_at", DateTime.Now);

                    int result = DBHelper.SoftDelete("vehicle", data, "id=" + id);
                    if (result != 0)
                    {
                        MessageBox.Show("Deleted Success");
                        RefreshPage();
                    }
                    else
                    {
                        MessageBox.Show("Failed!");
                    }
                }
            }

            btnSimpan.Visible = true;
            btnTambah.Visible = false;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            btnSimpan.Visible = false;
            btnTambah.Visible = true;

            tbNote.Text = string.Empty;
            tbPlate.Text = string.Empty;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int member_id = (int)cbMember.SelectedValue;
            int vehilceType_id = (int)cbVehicleType.SelectedValue;
            string plate = tbPlate.Text;
            string notes = tbNote.Text;


            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("vehicle_type_id", vehilceType_id);
            data.Add("member_id", member_id);
            data.Add("license_plate", plate);
            data.Add("notes", notes);
            data.Add("last_updated_at", DateTime.Now);


            if (plate == string.Empty)
            {
                MessageBox.Show("Masukan Nomer Plat Kendaraan!");
                return;
            }

            int result = DBHelper.Update("vehicle", data, "id = " + id);
            if (result > 0)
            {
                MessageBox.Show("Updated Is Success!");
                RefreshPage();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
