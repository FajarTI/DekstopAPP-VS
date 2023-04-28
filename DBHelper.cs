using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace Latihan_DesktopApp
{
    public class DBHelper
    {
        private const string connnectionString = "server=localhost;port=3307;database=mandhegparkingsystem;uid=root;password=;";

        //Helper Insert
        public static int Insert(string tableName, Dictionary<string, object> data)
        {
            int rowsAffected = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connnectionString))
                {
                    conn.Open();

                    StringBuilder sbColumns = new StringBuilder();
                    StringBuilder sbValues = new StringBuilder();

                    foreach (KeyValuePair<string, object> pair in data)
                    {
                        sbColumns.AppendFormat("{0}, ", pair.Key);
                        sbValues.AppendFormat("@{0}, ", pair.Key);
                    }

                    sbColumns.Remove(sbColumns.Length - 2, 2);
                    sbValues.Remove(sbValues.Length - 2, 2);

                    string query = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", tableName, sbColumns, sbValues);

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        foreach (KeyValuePair<string, object> pair in data)
                        {
                            cmd.Parameters.AddWithValue("@" + pair.Key, pair.Value);
                        }

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rowsAffected;
        }


        //Helper Update
        public static int Update(string tableName, Dictionary<string, object> data, string condition)
        {
            int rowsAffected = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connnectionString))
                {
                    conn.Open();

                    StringBuilder sb = new StringBuilder();

                    foreach (KeyValuePair<string, object> pair in data)
                    {
                        sb.AppendFormat("{0}=@{0}, ", pair.Key);
                    }

                    sb.Remove(sb.Length - 2, 2);

                    string query = string.Format("UPDATE {0} SET {1} WHERE {2}", tableName, sb, condition);

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        foreach (KeyValuePair<string, object> pair in data)
                        {
                            cmd.Parameters.AddWithValue("@" + pair.Key, pair.Value);
                        }

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rowsAffected;
        }

        //Helper Delete
        public static int Delete(string tableName, string condition)
        {
            int rowsAffected = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connnectionString))
                {
                    conn.Open();

                    string query = string.Format("DELETE FROM {0} WHERE {1}", tableName, condition);

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rowsAffected;
        }

        //Helper SoftDelete - Hapus Sementara
        public static int SoftDelete(string tableName, Dictionary<string, object> data, string condition)
        {
            int rowsAffected = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connnectionString))
                {
                    conn.Open();

                    StringBuilder sb = new StringBuilder();

                    foreach (KeyValuePair<string, object> pair in data)
                    {
                        sb.AppendFormat("{0}=@{0}, ", pair.Key);
                    }

                    sb.Remove(sb.Length - 2, 2);

                    string query = string.Format("UPDATE {0} SET {1} WHERE {2}", tableName, sb, condition);

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        foreach (KeyValuePair<string, object> pair in data)
                        {
                            cmd.Parameters.AddWithValue("@" + pair.Key, pair.Value);
                        }

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rowsAffected;
        }

        //Helper GetData
        public static DataTable GetData(string tableName, string condition = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connnectionString))
                {
                    conn.Open();

                    string query = string.Format("SELECT * FROM {0}", tableName);
                    if (!string.IsNullOrEmpty(condition))
                    {
                        query += string.Format(" WHERE {0}", condition);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        //Helper Login
        public static DataTable GetLoginData(string username, string password)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connnectionString))
                {
                    conn.Open();

                    string query = string.Format("SELECT * FROM employee WHERE name=@username AND password=@password");

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

    }
}
