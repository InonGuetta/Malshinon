using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Malshinon.classes
{
    internal class Agent
    {
        string malshin_first_name { get; set; }
        string agent_last_name { get; set; }
        int agent_secret_code { get; set; }
        //---------------------------------------------------------------------------------------------------
        public Agent(string malshinFirstName,string agentLastName, int agentSecretCode)
        {
            this.malshin_first_name = malshinFirstName;
            this.agent_last_name = agentLastName;
            this.agent_secret_code = agentSecretCode;
        }
    }


}
