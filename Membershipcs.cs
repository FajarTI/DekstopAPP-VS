using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*--------------------
 * :::: Ceritanya ::::
 * -------------------
 * 
 * ==============
 * Fitur Insert : 
 * ==============
 * - Ketika tombol insert diklik akan muncul dialog yang akan menerima inputan user dan akan di masukan kedalam database dan ditampilkan kedalam datagridview.
 * - tampilkan pesan ketika data berhasil ditambahkan dan ketika gagal ditambahkan.
 * - Pada dialog input hanya terdapat sebuah teksbox dan button input.
 * 
 * ====================
 * Fitur  Update|Edit :
 * ====================
 * - Pada data yang ditampilkan pada datagrid akan ada tombol tambahan yang berfungsi sebagai action untuk Edit dan Delete
 * - pada saat tombol edit diklik, akan membuka fitur edit tabel pada baris yang dipilih, dan tombol edit berubah fungsi menjadi tombol simpan dan akan kembali jika tombol simpan diklik dan berhasil menyimpan perubahan.
 * - Tampilkan pesan ketika berhasil dan ketika gagal.
 * 
 * =========================
 * Fitur Delete|Softdelete :
 * =========================
 * - fitur ini tidak akan menghapus data secara permanen, hanya saja fitur ini akan melakukan update data dan mengisikan field (datetime) yang merekam kapan data tersebut dihapus.
 * 
 */


namespace Latihan_DesktopApp
{
    public partial class Membershipcs : Form
    {
        private string tableName = "membership";
        public Membershipcs()
        {
            InitializeComponent();
        }


        private void Membershipcs_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData(tableName);

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

            viewMembership.DataSource = dt;
            viewMembership.Columns.Add(btnEdit);
            viewMembership.Columns.Add(btnDelete);
            viewMembership.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewMembership.AllowUserToAddRows = false;

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            new addMembership().ShowDialog(); //membuka form untuk menambahkan data
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData(tableName);
            viewMembership.DataSource = dt;
        }

        private void viewMembership_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(viewMembership.Rows[e.RowIndex].Cells["id"].Value);

            // Fitur Delete | Jika tombol delete diklik
            if (viewMembership.Columns[e.ColumnIndex] is DataGridViewButtonColumn && viewMembership.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex >= 0)
            {
                if (!string.IsNullOrEmpty(viewMembership.Rows[e.RowIndex].Cells["deleted_at"].Value.ToString()))
                {
                    MessageBox.Show("Data telah dihapus sebelumnya!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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

                        }catch (Exception ex)
                        {
                            MessageBox.Show("Data gagal dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }


            //Fitur Update | Jika tombol edit diklik
            if (viewMembership.Columns[e.ColumnIndex] is DataGridViewButtonColumn && viewMembership.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex >= 0)
            {
                if (!string.IsNullOrEmpty(viewMembership.Rows[e.RowIndex].Cells["deleted_at"].Value.ToString()))
                {
                    MessageBox.Show("Data telah dihapus sebelumnya!");
                    return;
                }
                updateMembership updateMembership = new updateMembership(id); //membuka form update dan mengirimkan id dari data yang akan diedit
                DialogResult result = updateMembership.ShowDialog();
            }
        }

    }
}
