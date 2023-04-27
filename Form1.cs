using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace Latihan_DesktopApp
{
    public partial class Form1 : Form
    {
        private const string connnection = "server=localhost;database=mandhegsystemparking;uid=root;password=;";

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string hashPass = GetSHA256Hash(password);


            DataTable dt = DBHelper.GetLoginData(username, hashPass);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.username = username;
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Email atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
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
    }
}