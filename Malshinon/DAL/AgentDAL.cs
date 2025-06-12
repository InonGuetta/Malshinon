using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Malshinon.classes;
using MySql.Data.MySqlClient;

namespace Malshinon.DAL
{
    internal class AgentDAL
    {
        string connStr = "server=localhost;username=root;password=;database=malshinon;";

        //-------------------------------------------------------------------------------------
        public string InsertAgentFromClient(string first_name, string last_name, string secret_code)
        {
                string query = $"INSERT INTO agents(agent_first_name,agent_last_name,agent_secret_code ) " +
                    $"VALUES ('{first_name}','{last_name}','{secret_code}')";

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
        //-------------------------------------------------------------------------------------
        public bool CheckAgentExists(string nameAgent)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                conn.Open();
                string query = "SELECT COUNT(*) FROM agents WHERE agent_first_name = @name";
                MySqlCommand cmd = new MySqlCommand(query,conn);
                cmd.Parameters.AddWithValue("@name", nameAgent);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch 
                {
                    return false;
                }
            }
        }
        //-------------------------------------------------------------------------------------

    }
}
