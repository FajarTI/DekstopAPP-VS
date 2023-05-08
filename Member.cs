using System.Data;

namespace Latihan_DesktopApp
{
    public partial class Member : Form
    {
        private string tableName = "member";

        public Member()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public int id;
        private void viewMembership_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(viewMember.Rows[e.RowIndex].Cells["id"].Value);

            if (viewMember.Columns[e.ColumnIndex] is DataGridViewColumn && viewMember.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex >= 0)
            {
                if (!string.IsNullOrEmpty(viewMember.Rows[e.RowIndex].Cells["deleted_at"].Value.ToString()))
                {
                    MessageBox.Show("Data telah dihapus sebelumnya!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show("Apakah Anda Yakin?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Dictionary<string, object> data = new Dictionary<string, object>();
                    data.Add("deleted_at", DateTime.Now);
                    try
                    {
                        DBHelper.SoftDelete(tableName, data, "id=" + id);
                        MessageBox.Show("Data telah dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        reload();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Data gagal dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            if (viewMember.Columns[e.ColumnIndex] is DataGridViewColumn && viewMember.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex >= 0)
            {
                btnSave.Visible = true;
                btnAdd.Visible = false;

                int membership_id = Convert.ToInt32(viewMember.Rows[e.RowIndex].Cells["membership_id"].Value);
                comboBox1.SelectedValue = membership_id;
                tbName.Text = viewMember.Rows[e.RowIndex].Cells["name"].Value.ToString();
                tbEmail.Text = viewMember.Rows[e.RowIndex].Cells["email"].Value.ToString();
                tbPhone.Text = viewMember.Rows[e.RowIndex].Cells["phone_number"].Value.ToString();
                dtBirth.Value = DateTime.Parse(viewMember.Rows[e.RowIndex].Cells["date_of_birth"].Value.ToString());
                string gender = viewMember.Rows[e.RowIndex].Cells["gender"].Value.ToString();
                if (gender == "Male")
                {
                    radioButton1.Checked = true;
                }
                if (gender == "Female")
                {
                    radioButton2.Checked = true;
                }

            }

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnAdd.Visible = true;
        }

        private void Member_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData(tableName);
            viewMember.DataSource = dt;

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

            viewMember.DataSource = dt;
            viewMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewMember.AllowUserToAddRows = false;
            viewMember.Columns.Add(btnEdit);
            viewMember.Columns.Add(btnDelete);

            FillComboBox();

        }

        private void FillComboBox()
        {
            string membershipTable = "membership";
            string columnName = "name";
            string columnValue = "id";

            DataTable membership = DBHelper.GetData(membershipTable);
            if (membership != null)
            {
                comboBox1.DataSource = membership;
                comboBox1.DisplayMember = columnName;
                comboBox1.ValueMember = columnValue;
            }
        }

        private void reload()
        {
            DataTable dt = DBHelper.GetData(tableName);
            viewMember.DataSource = dt;
        }

        string gender;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string phone = tbPhone.Text;

            int id_membership = (int)comboBox1.SelectedValue;

            if (name == string.Empty && email == string.Empty && phone == string.Empty)
            {
                MessageBox.Show("Silahkan Lengkapi Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            if (radioButton2.Checked)
            {
                gender = "Female";
            }

            if (radioButton1.Checked | radioButton2.Checked)
            {

                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("membership_id", id_membership);
                data.Add("name", name);
                data.Add("email", email);
                data.Add("phone_number", phone);
                data.Add("gender", gender);
                data.Add("date_of_birth", dtBirth.Value);
                int result = DBHelper.Insert(tableName, data);

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
            else
            {
                MessageBox.Show("Silahkan pilih salah satu jenis kelamin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string phone = tbPhone.Text;
            int id_membership = (int)comboBox1.SelectedValue;

            if (name == string.Empty && email == string.Empty && phone == string.Empty)
            {
                MessageBox.Show("Silahkan Lengkapi Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            if (radioButton2.Checked)
            {
                gender = "Female";
            }

            if (radioButton1.Checked | radioButton2.Checked)
            {

                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("membership_id", (int)comboBox1.SelectedValue);
                data.Add("name", tbName.Text);
                data.Add("email", tbEmail.Text);
                data.Add("phone_number", tbPhone.Text);
                data.Add("date_of_birth", dtBirth.Value);
                data.Add("gender", gender);
                data.Add("last_updated_at", DateTime.Now);

                int result = DBHelper.Update(tableName, data, "id=" + id);

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
            else
            {
                MessageBox.Show("Silahkan pilih salah satu jenis kelamin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
