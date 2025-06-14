using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Malshinon.DAL;

namespace Malshinon.service
{
    internal class MenuSERVICE
    {
        public void Menu()
        {






        bool pause = false;
        while(!pause){
            Console.WriteLine("PRESS 1 - insert user name to halshana | PRESS 2 - insert user password to halshana | PRESS 3 - to show all data malshinim" +
                " | PRESS 4 - to add agent | PRESS 9 - to pause program" );

                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("please enter here you name");
                        string checkName = Console.ReadLine();
                        LealshinDAL lealshinDAL = new LealshinDAL();
                        bool foundName = lealshinDAL.CheckUserExists(checkName);
                        if (foundName)
                        {
                            Console.WriteLine("you found in system  \n");

                        }
                        else
                        {
                            LealshinSERVICE halshana = new LealshinSERVICE();

                            
                            Console.WriteLine("you NOT found in system but you insert you right now  and inserted you name");
                            Console.WriteLine("We will now create a new informant card.");
                            halshana.InsertButNameNotFound(checkName);
                            
                        }
                        Console.WriteLine("please insert here Content of halshana");
                        LealshinSERVICE lealshinSERVICE = new LealshinSERVICE();

                        break;
                    case 2:
                        Console.WriteLine("please enter here you password");
                        string checkPassword = Console.ReadLine();
                        //LealshinDAL lealshinDAL = new LealshinDAL();
                        break;
                    case 3:
                        Console.WriteLine("for show all data you need to be AGENT please enter here you name");
                        string checkname = Console.ReadLine();
                        AgentDAL agentDAL = new AgentDAL();
                        bool foundAgent = agentDAL.CheckAgentExists(checkname);
                        if (foundAgent)
                        {
                            Console.WriteLine("THE TABLE OF MALSHINIM");
                            AgentSERVICE lealshin = new AgentSERVICE();
                            lealshin.printDetailsLealshin();
                        }
                        else
                        {
                            Console.WriteLine("We are sorry but you cannot access the information.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Insert details for new agent");
                        string creat_agent = Console.ReadLine();
                        AgentSERVICE create_agent = new AgentSERVICE();
                        create_agent.createNewAgent(creat_agent);
                        break;
                    case 9:
                        pause = true;
                        break;
                }
            }
        }

}
}
