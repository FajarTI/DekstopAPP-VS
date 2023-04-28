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
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add(columnName, tbMembership.Text);
            data.Add(columnCreated,created);

            int rowsAffected = DBHelper.Insert(tableName, data);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Success!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Membershipcs membershipcs = (Membershipcs)this.Owner;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
