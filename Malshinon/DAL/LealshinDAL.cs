using System;
using System.Collections.Generic;
using System.Linq;
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
        //-------------------------------------------------------------------------------------
        // לבין זה 
        public void addToLealshin(Lealshin lealshin)
        {
            // שים לב כי זה צריך להיות מחוץ ל using
            string query = "INSERT INTO malshinim(malshin_first_name,malshin_last_name,malshin_secret_code,malshin_status,malshin_about)" +
                "VALUES (@malshin_first_name,@malshin_last_name,@malshin_secret_code,@malshin_status,@malshin_about)";

            using(MySqlConnection conn = new MySqlConnection(connStr)){
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query,conn);
                cmd.Parameters.AddWithValue(@"malshin_first_name", lealshin.malshin_first_name);
                cmd.Parameters.AddWithValue(@"malshin_last_name", lealshin.malshin_last_name);
                cmd.Parameters.AddWithValue(@"malshin_secret_code", lealshin.malshin_secret_code);
                //cmd.Parameters.AddWithValue(@"malshin_status", lealshin.malshin_status);
                cmd.Parameters.AddWithValue(@"malshin_about", lealshin.malshin_about);




                cmd.ExecuteNonQuery();
            }

        }
        //-------------------------------------------------------------------------------------


    }
}
