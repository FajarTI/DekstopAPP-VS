using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Timer = System.Windows.Forms.Timer;

namespace Latihan_DesktopApp
{
    public partial class Employee : Form
    {
        private const string connnection = "server=localhost;port=3307;database=mandhegparkingsystem;uid=root;password=;";
        private MySqlCommand cmd;
        private string tabelName = "employee";
        private string gender;


        public Employee()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Employee_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData(tabelName);
            viewEmployee.DataSource = dt;
            viewEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewEmployee.AllowUserToAddRows = false;
            viewEmployee.ReadOnly = true;
        }
        private void reload()
        {
            DataTable dt = DBHelper.GetData(tabelName);
            viewEmployee.DataSource = dt;
            viewEmployee.ReadOnly = true;
            viewEmployee.Refresh();
        }

        //Hash Password SHA256
        private string GetSHA256Hash(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        /**********************************************************************************/
        /******************************** INSERT ******************************************/
        /**********************************************************************************/
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPasswordOld.Text;
            string confirm = txtPassword.Text;
            string phone_number = txtPhone.Text;
            string address = txtAddress.Text;

            string passHash = GetSHA256Hash(password);

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone_number))
            {
                MessageBox.Show("Silahkan Lengkapi Feild !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!password.Equals(confirm))
            {
                MessageBox.Show("Masukan Password Dengan Benar !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Masukan Password Minimal 6 Karakter !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rMale.Checked)
            {
                gender = "Male";
            }
            else if (rFemale.Checked)
            {
                gender = "Female";
            }


            if (rMale.Checked || rFemale.Checked)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("name", name);
                data.Add("email", email);
                data.Add("password", passHash);
                data.Add("phone_number", phone_number);
                data.Add("address", address);
                data.Add("date_of_birth", pickDateBirth.Value.Date);
                data.Add("gender", gender);

                int rowsAffected = DBHelper.Insert("employee", data);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Berhasil Ditambahkan!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reload();
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silahkan pilih salah satu jenis kelamin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        /**********************************************************************************/
        /******************************** UPDATE ******************************************/
        /**********************************************************************************/
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            txtOldPassword.Text = "New Password";

            txtID.Visible = true;
            btnSave.Visible = true;
            btnCari.Visible = true;
            btnDelete.Visible = false;
        }
        private void viewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            txtPasswordOld.Text = string.Empty;
            txtPassword.Text = string.Empty;

            MySqlConnection conn = new MySqlConnection(connnection);
            try
            {
                conn.Open();

                cmd = new MySqlCommand("SELECT * FROM employee WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtName.Text = reader["name"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtAddress.Text = reader["address"].ToString();
                    txtPhone.Text = reader["phone_number"].ToString();
                    string gender = reader["gender"].ToString();

                    if (gender == "Male")
                    {
                        rMale.Checked = true;
                    }
                    else if (gender == "Female")
                    {
                        rFemale.Checked = true;
                    }

                    pickDateBirth.Value = DateTime.Parse(reader["date_of_birth"].ToString()); ;

                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPasswordOld.Text;
            string confirm = txtPassword.Text;
            string phone_number = txtPhone.Text;
            string address = txtAddress.Text;
            string id = "id = " + txtID.Text;

            string passHash = GetSHA256Hash(password);

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone_number))
            {
                MessageBox.Show("Silahkan Lengkapi Feild !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!password.Equals(confirm))
            {
                MessageBox.Show("Masukan Password Dengan Benar !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rMale.Checked)
            {
                gender = "Male";
            }
            else if (rFemale.Checked)
            {
                gender = "Female";
            }


            if (rMale.Checked || rFemale.Checked)
            {
                if (!password.Equals(""))
                {
                    if (password.Length < 6)
                    {
                        MessageBox.Show("Masukan Password Minimal 6 Karakter !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Dictionary<string, object> data = new Dictionary<string, object>();
                    data.Add("name", name);
                    data.Add("email", email);
                    data.Add("password", passHash);
                    data.Add("phone_number", phone_number);
                    data.Add("address", address);
                    data.Add("date_of_birth", pickDateBirth.Value.Date);
                    data.Add("gender", gender);
                    data.Add("last_updated_at", DateTime.Now);

                    int rowsAffected = DBHelper.Update(tabelName, data, id);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Berhasil Diubah!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal diuabh", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (password.Equals(""))
                {
                    Dictionary<string, object> data = new Dictionary<string, object>();
                    data.Add("name", name);
                    data.Add("email", email);
                    data.Add("phone_number", phone_number);
                    data.Add("address", address);
                    data.Add("date_of_birth", pickDateBirth.Value.Date);
                    data.Add("gender", gender);
                    data.Add("last_updated_at", DateTime.Now);

                    int rowsAffected = DBHelper.Update(tabelName, data, id);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Berhasil Diubah!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal diuabh", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silahkan pilih salah satu jenis kelamin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /**********************************************************************************/
        /******************************** DELETE ******************************************/
        /**********************************************************************************/
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            txtID.Visible = true;
            btnSave.Visible = false;
            btnCari.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = "id = " + txtID.Text;

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("deleted_at", DateTime.Now);

            int rowsAffected = DBHelper.Update(tabelName, data, id);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Data berhasil dihapus pada tabel employee.");
                reload();
            }
            else
            {
                MessageBox.Show("Data gagal dihapus pada tabel employee.");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPasswordOld.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;

            if (rFemale.Checked || rMale.Checked)
            {
                rMale.Checked = false;
                rFemale.Checked = false;
            }

            txtID.Visible = false;
            btnCari.Visible = false;
            btnSave.Visible = false;
            btnDelete.Visible = false;
        }
    }
}
