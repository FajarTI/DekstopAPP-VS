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
    public partial class UpdateVehilceType : Form
    {
        public int idVehicleType;
        public UpdateVehilceType(int id)
        {
            InitializeComponent();
            this.idVehicleType = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validasi
            if (tbUpdateVehicleType.Text == string.Empty)
            {
                MessageBox.Show("Fields tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //update data
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("name", tbUpdateVehicleType.Text);
            data.Add("last_updated_at", DateTime.Now);
            try
            {
                DBHelper.Update("vehicletype", data, "id = " + idVehicleType);
                MessageBox.Show("Data berhasil diupdate!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal berhasil diupdate!", "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateVehilceType_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData("vehicletype", "id= " + idVehicleType);
            if (dt.Rows.Count > 0)
            {
                tbUpdateVehicleType.Text = dt.Rows[0]["name"].ToString();
            }
        }
    }
}
