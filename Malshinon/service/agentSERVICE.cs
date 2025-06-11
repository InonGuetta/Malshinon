using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Digests;
using ZstdSharp.Unsafe;

namespace Malshinon.service
{
    internal class AgentSERVICE
    {
        string connStr = "server=localhost;username=root;password=;database=malshinon;";
        public void printDetailsLealshin()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string query = "SELECT * FROM malshinim";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"| {"ID",-5} | {"First Name",-12} | {"Last Name",-12} | {"Code",-15} | {"Status",-15} | {"About",-20} | {"Time",-19} | ");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

                while (reader.Read())
                {
                    int malshin_id = reader.GetInt32("malshin_id");
                    string malshin_first_name = reader.GetString("malshin_first_name");
                    string malshin_last_name = reader.GetString("malshin_last_name");
                    string malshin_secret_code = reader.GetString("malshin_secret_code");
                    string malshin_status = reader["malshin_status"] == DBNull.Value ? "malshin" : reader.GetString("malshin_status");
                    string malshin_about = reader["malshin_about"] == DBNull.Value ? "" : reader.GetString("malshin_about");
                    DateTime malshin_time_halshana = reader.GetDateTime("malshin_time_halshana");

                    Console.WriteLine($"| {malshin_id,-5} | {malshin_first_name,-12} | {malshin_last_name,-12} | {malshin_secret_code,-15} | {malshin_status,-15} | {malshin_about,-20} | {malshin_time_halshana,-10} | ");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"err: {e}");
            }
            finally
            {
                conn.Close();
            }
        }
        //-------------------------------------------------------------------------------------------------------------------


        public void GetPersonByName()
        {
            Console.WriteLine("please enter the name to search: ");
            string search_name = Console.ReadLine();

            bool found = false;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM malshinim WHERE malshin_first_name = @name";
                    MySqlCommand cmd = new MySqlCommand(query,conn);
                    cmd.Parameters.AddWithValue("@name", search_name);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        Console.WriteLine($"the name {search_name} exsit");
                        found = true;
                        //search_name אני מעוניין שהשאילתה הזאת תוציא את כל הנתונים על האדם 
                        string query_singal = "SELECT * FROM accused WHERE accused_first_name , accused_last_name = @name";
                    }
                    else
                    {
                        Console.WriteLine($"the name {search_name} not exsit");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"err: {e}");
                }
            }
        }
        //-------------------------------------------------------------------------------------------------------------------


        //void GetPersonBySecretCode(){
        //{

        //}

        //void GetReporterStats()
        //{

        //}
        //void GetTargetStats()
        //{

        //}

        //void GetAlerts()
        //{

        //}
    }
}
    