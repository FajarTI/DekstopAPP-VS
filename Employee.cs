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

namespace Latihan_DesktopApp
{
    public partial class Employee : Form
    {
        private const string connnection = "server=localhost;database=mandhegsystemparking;uid=root;password=;";
        private MySqlCommand cmd;
        public Employee()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void Employee_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connnection))
                {
                    conn.Open();

                    string query = "SELECT id,name,email,phone_number,address,date_birth,gender,created_at,last_updated_at,deleted_at FROM employee ORDER BY id DESC";
                    cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(dt);
                    viewEmployee.DataSource = dt;
                    viewEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    viewEmployee.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void reload()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connnection))
            {
                conn.Open();

                string query = "SELECT id,name,email,phone_number,address,date_birth,gender,created_at,last_updated_at,deleted_at FROM employee ORDER BY id DESC";
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(dt);
                viewEmployee.DataSource = dt;
                viewEmployee.Refresh();
            }
        }

        string gender;

        //Insert Method
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;
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
            {

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
                data.Add("date_birth", pickDateBirth.Value.Date);
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

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            new search().Show();
        }
        private void viewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
