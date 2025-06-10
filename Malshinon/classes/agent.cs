using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Malshinon
{
    internal class Agent
    {
        public string agent_first_name { get; set; }
        public string agent_last_name { get; set; }
        public int agent_secret_code { get; set; }
        //---------------------------------------------------------------------------------------------------
        public Agent(string malshinFirstName,string agentLastName, int agentSecretCode)
        {
            this.agent_first_name = malshinFirstName;
            this.agent_last_name = agentLastName;
            this.agent_secret_code = agentSecretCode;
        }
    }


}
