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

        public void LoadDataGrid()
        {
            DataTable dt = DBHelper.GetData(tableName);
            viewMembership.DataSource = dt;
            viewMembership.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewMembership.AllowUserToAddRows = false;
        }

        private void Membershipcs_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData(tableName);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();

            btnEdit.HeaderText = "Edit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;

            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            viewMembership.DataSource = dt;
            viewMembership.Columns.Add(btnEdit);
            viewMembership.Columns.Add(btnDelete);
            viewMembership.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewMembership.AllowUserToAddRows = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            new addMembership().ShowDialog();
        }
    }
}
