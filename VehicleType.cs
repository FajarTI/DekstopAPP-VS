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
    public partial class VehicleType : Form
    {
        private string tableName = "vehicletype";
        public VehicleType()
        {
            InitializeComponent();
        }

        private void viewMembership_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(viewVehicleType.Rows[e.RowIndex].Cells["id"].Value);

            // Fitur Delete | Jika tombol delete diklik
            if (viewVehicleType.Columns[e.ColumnIndex] is DataGridViewButtonColumn && viewVehicleType.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex >= 0)
            {
                if (!string.IsNullOrEmpty(viewVehicleType.Rows[e.RowIndex].Cells["deleted_at"].Value.ToString()))
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
                            DBHelper.SoftDelete(tableName, data, "id=" + id);
                            MessageBox.Show("Data telah dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Data gagal dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }


            //Fitur Update | Jika tombol edit diklik
            if (viewVehicleType.Columns[e.ColumnIndex] is DataGridViewButtonColumn && viewVehicleType.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex >= 0)
            {
                if (!string.IsNullOrEmpty(viewVehicleType.Rows[e.RowIndex].Cells["deleted_at"].Value.ToString()))
                {
                    MessageBox.Show("Data telah dihapus sebelumnya!");
                    return;
                }
                UpdateVehilceType updateVehilceType = new UpdateVehilceType(id); //membuka form update dan mengirimkan id dari data yang akan diedit
                DialogResult result = updateVehilceType.ShowDialog();
            }
        }

        private void VehicleType_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData("vehicletype");
            viewVehicleType.DataSource = dt;

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

            viewVehicleType.DataSource = dt;
            viewVehicleType.Columns.Add(btnEdit);
            viewVehicleType.Columns.Add(btnDelete);
            viewVehicleType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewVehicleType.AllowUserToAddRows = false;

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            new addVehicleType().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData(tableName);
            viewVehicleType.DataSource = dt;
        }
    }
}
