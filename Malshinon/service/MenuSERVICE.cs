using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Malshinon.service
{
    internal class MenuSERVICE
    {
        public void Menu()
        {
            // להדפיס את כל הערכים
            LealshinSERVICE halshana = new LealshinSERVICE();
            halshana.InsertIntelReport();

            // להכניס את כל הערכים
            AgentSERVICE lealshin = new AgentSERVICE();
            lealshin.printDetailsLealshin();



            bool pause = false;
        while(!pause){
            Console.WriteLine("PRESS 1 - insert user name | PRESS 2 - insert user password | PRESS 3 - to pause program");

                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("please enter here you name");
                        string checkName = Console.ReadLine();
                        // איך אני שולח את זה לבדיקה אצל ה SQL
                        // האם אני 
                        break;
                    case 2:
                        Console.WriteLine("please enter here you password");
                        string checkPassword = Console.ReadLine();
                        break;
                    case 3:
                        pause = true;
                        break;
                }
            
            }
        }

}
}
