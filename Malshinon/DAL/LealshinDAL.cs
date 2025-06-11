using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Malshinon.classes;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using Org.BouncyCastle.Asn1.Cms;


namespace Malshinon.DAL
{
    internal class LealshinDAL
    {
        string connStr = "server=localhost;username=root;password=;database=malshinon;";

    // -----------------------------------------------------------------------------------------------------------------------     
        public string InsertHalshanaFromClient(string first_name,string last_name, string secret_code,string malshin_about) 
        {
            string query = $"INSERT INTO malshinim (malshin_first_name,malshin_last_name,malshin_secret_code,malshin_about ) " +
                $"VALUES  ('{first_name}','{last_name}','{secret_code}','{malshin_about}');";
            return query;
        } 

        public void PushSql(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"err: {e}");
                }
            }
        }
        // -----------------------------------------------------------------------------------------------------------------------     
        public bool CheckUserExists(string username)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT COUNT(*) FROM malshinim WHERE malshin_first_name = @name";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", username);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch
                {
                    return false;
                }
            }
        }
        // -----------------------------------------------------------------------------------------------------------------------     
        public int GetMalshinIdByName(string first_name)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT malshin_id FROM malshinim WHERE malshin_first_name = @name LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query,conn);
                // מה זה עושה 01
                cmd.Parameters.AddWithValue("@name",first_name);   
                // מה זה עושה 02
                object result = cmd.ExecuteScalar();
                return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : -1;
            }
        }
        // -----------------------------------------------------------------------------------------------------------------------     
        // לא עובד 
        //public void InsertIntelReport(int malshinId, string content)
        //{
        //    using (MySqlConnection conn = new MySqlConnection(connStr))
        //    {
        //        conn.Open();
        //        string query = "INSERT INTO intel_reports (malshin_id, report_content) VALUES (@id, @content)";
        //        MySqlCommand cmd = new MySqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@id", malshinId);
        //        cmd.Parameters.AddWithValue("@content", content);
        //        cmd.ExecuteNonQuery();
        //    }
        //}


    }
}
