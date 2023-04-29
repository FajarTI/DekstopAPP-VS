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
            viewHourlyrates.DataSource = dt;

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

        private void viewHourlyrates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
