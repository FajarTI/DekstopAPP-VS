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
    public partial class updateMembership : Form
    {
        public int IdMembership;
        public updateMembership(int id)
        {
            InitializeComponent();
            IdMembership = id;
        }

        private void updateMembership_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData("membership", "id= " + IdMembership);
            if (dt.Rows.Count > 0)
            {
                tbUpdateMembership.Text = dt.Rows[0]["name"].ToString();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //validasi
            if (tbUpdateMembership.Text == string.Empty)
            {
                MessageBox.Show("Fields tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //jika data sudah ada
            DataTable existingData = DBHelper.GetData("membership", "name = '" + tbUpdateMembership.Text + "'");

            if (existingData.Rows.Count > 0)
            {
                MessageBox.Show("Data already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //update data
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("name", tbUpdateMembership.Text);
            data.Add("last_updated_at", DateTime.Now);
            try
            {
                DBHelper.Update("membership", data, "id = " + IdMembership);
                MessageBox.Show("Data berhasil diupdate!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal berhasil diupdate!", "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
