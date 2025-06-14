using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace Malshinon.DAL
{
    internal class AccusedDAL
    {
        string connStr = "server=localhost;username=root;password=;database=malshinon;";

        //-------------------------------------------------------------------------------------
        public string InsertHalshanaFromClientToAccused(string molshan)
        {
            molshan += " Not_Insert_Last_Name";
            string[] the_molshan = molshan.Split(' ','-');

            string query = $"INSERT INTO accused (accused_first_name,accused_last_name ) " +
                $"VALUES  ('{the_molshan[0]}', '{the_molshan[1]}');";
            return query;
        }
        //-------------------------------------------------------------------------------------
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
    }
}
