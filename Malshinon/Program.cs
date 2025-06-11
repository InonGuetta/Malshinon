using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Malshinon.DAL;
using Malshinon.service;

namespace Malshinon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //LealshinSERVICE halshana = new LealshinSERVICE();
            //halshana.InsertIntelReport();
            //------------------------------------------------
            //מדפיס את כולם 
            AgentSERVICE lealshin = new AgentSERVICE();
            lealshin.printDetailsLealshin();
        }
    }
}
