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
        public void addToAgent(Agent agent)
        {
            string query = "INSERT INTO agents(agent_first_name,agent_last_name,agent_secret_code ) " +
                "VALUES (@agent_first_name,@agent_last_name,@agent_secret_code)";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = new MySqlCommand(query,conn);
                cmd.Parameters.AddWithValue(@"agent_first_name", agent.agent_first_name);
                cmd.Parameters.AddWithValue(@"agent_last_name", agent.agent_last_name);
                cmd.Parameters.AddWithValue(@"agent_secret_code", agent.agent_secret_code);
            
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
