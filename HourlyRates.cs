using System.Data;

namespace Latihan_DesktopApp
{
    public partial class HourlyRates : Form
    {
        string tabelName = "hourlyrates";
        public HourlyRates()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HourlyRates_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData(tabelName);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();

            //Menambahkan button Edit
            btnEdit.HeaderText = "Edit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;

            //Menambahkan button Delete
            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            viewHourlyrates.DataSource = dt;
            viewHourlyrates.Columns.Add(btnEdit);
            viewHourlyrates.Columns.Add(btnDelete);
            viewHourlyrates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewHourlyrates.AllowUserToAddRows = false;

            FillComboBox();
        }

        private void reload()
        {
            DataTable dt = DBHelper.GetData(tabelName);
            viewHourlyrates.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FillComboBox()
        {
            string tableName1 = "membership";
            string tableName2 = "vehicletype";
            string columnName = "name";
            string columnID1 = "id";
            string columnID2 = "id";

            DataTable membership = DBHelper.GetData(tableName1);
            DataTable vehicletype = DBHelper.GetData(tableName2);
            if (membership != null)
            {
                comboBox1.DataSource = membership;
                comboBox1.DisplayMember = columnName;
                comboBox1.ValueMember = columnID1;
            }

            if (vehicletype != null)
            {
                comboBox2.DataSource = vehicletype;
                comboBox2.DisplayMember = columnName;
                comboBox2.ValueMember = columnID2;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

            int id_membership = (int)comboBox1.SelectedValue;
            int id_vehicletype = (int)comboBox2.SelectedValue;

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("membership_id", id_membership);
            data.Add("vehicle_type_id", id_vehicletype);
            data.Add("value", tbValue.Text);

            int result = DBHelper.Insert(tabelName, data);
            if (result > 0)
            {
                MessageBox.Show("Success!");
                reload();
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }
        public int id;
        private void viewHourlyrates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Event jika delete diklik
            id = Convert.ToInt32(viewHourlyrates.Rows[e.RowIndex].Cells["id"].Value);

            if (viewHourlyrates.Columns[e.ColumnIndex] is DataGridViewButtonColumn && viewHourlyrates.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex >= 0)
            {

                groupBox1.Visible = false;// menutup group button

                if (!string.IsNullOrEmpty(viewHourlyrates.Rows[e.RowIndex].Cells["deleted_at"].Value.ToString()))
                {
                    MessageBox.Show("Data telah dihapus sebelumnya!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Apakah Anda Yakin?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Dictionary<string, object> data = new Dictionary<string, object>();
                        data.Add("deleted_at", DateTime.Now);
                        try
                        {
                            DBHelper.SoftDelete(tabelName, data, "id=" + id);
                            MessageBox.Show("Data telah dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            reload();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Data gagal dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }

            //Event jika EDIT diklik
            if (viewHourlyrates.Columns[e.ColumnIndex] is DataGridViewButtonColumn && viewHourlyrates.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex >= 0)
            {
                groupBox1.Visible = true;
                btnSave.Visible = true;
                btnTambah.Visible = false;

                int membership_id = Convert.ToInt32(viewHourlyrates.Rows[e.RowIndex].Cells["membership_id"].Value); // mengambil nilai dari membership_id
                int vehicle_id = Convert.ToInt32(viewHourlyrates.Rows[e.RowIndex].Cells["vehicle_type_id"].Value); // mengambil nilai dari vehicle_id

                comboBox1.SelectedValue = membership_id;
                comboBox2.SelectedValue = vehicle_id;
                tbValue.Text = viewHourlyrates.Rows[e.RowIndex].Cells["value"].Value.ToString();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            btnSave.Visible = false;
            btnTambah.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id_membership = (int)comboBox1.SelectedValue;
            int id_vehicletype = (int)comboBox2.SelectedValue;

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("membership_id", id_membership);
            data.Add("vehicle_type_id", id_vehicletype);
            data.Add("last_updated_at", DateTime.Now);
            data.Add("value", tbValue.Text);

            int result = DBHelper.Update(tabelName, data, "id = " + id);
            if (result > 0)
            {
                MessageBox.Show("Success!");
                reload();
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}
