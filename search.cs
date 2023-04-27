using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_DesktopApp
{
    public partial class search : Form
    {
        private const string connnectionString = "server=localhost;database=mandhegsystemparking;uid=root;password=;";
        public search()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
           MySqlConnection conn = new MySqlConnection(connnectionString);
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE id = @id",conn);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Employee employee = new Employee();

                    employee.txtName.Text      = reader["name"].ToString();
                    employee.txtEmail.Text     = reader["email"].ToString();
                    employee.txtAddress.Text   = reader["address"].ToString();
                    employee.txtPhone.Text     = reader["phone_number"].ToString();

                    string gender              = reader["gender"].ToString();

                    if (gender == "Male")
                    {
                        employee.rMale.Checked = true;
                    }else if (gender == "Female")
                    {
                        employee.rFemale.Checked = true;
                    }

                    
                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally { conn.Close(); }
        }
    }
}
