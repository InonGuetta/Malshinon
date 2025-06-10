using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                //cmd.Parameters.AddWithValue(@"agent_first_name", agent.agent_first_name);
            
            }
        }
        
    }
}
