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

    public partial class addMembership : Form
    {
        private string tableName = "membership";
        private string columnName = "name";
        private string columnCreated = "created_at";

        DateTime created = DateTime.Now;
        public addMembership()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string isiFields = tbMembership.Text;

            //validasi textbox
            if (isiFields == string.Empty)
            {
                MessageBox.Show("Silahkan isi field terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //pengecek jika data sudah ada
            DataTable existingData = DBHelper.GetData(tableName, "name = '" + isiFields + "'");

            if (existingData.Rows.Count > 0)
            {
                MessageBox.Show("Data already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //menambah data
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add(columnName, isiFields);
            data.Add(columnCreated, created);

            int rowsAffected = DBHelper.Insert(tableName, data);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Success to add!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Membershipcs membershipcs = (Membershipcs)this.Owner;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addMembership_Load(object sender, EventArgs e)
        {

        }
    }
}
