using System;
using System.Collections.Generic;
using System.Linq;
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
            // להדפיס את כל הערכים


            // להכניס את כל הערכים
            //AgentSERVICE lealshin = new AgentSERVICE();
            //lealshin.printDetailsLealshin();



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
                        // תשאל שאלות מנחות שאתה חושב שאתה צריך לדעת ותתחשב בתמונה המצורפת
                        LealshinDAL lealshinDAL = new LealshinDAL();
                        bool found = lealshinDAL.CheckUserExists(checkName);
                        if (found)
                        {
                            //Console.WriteLine("you found in system");
                            //LealshinSERVICE lealshinSERVICE = new LealshinSERVICE();
                            //// אני מעונין שאם השם קיים אזי הוא 
                            //// יצור תחתיו תלונה חדשה נתונה הטבלת db בתמונה המצורפת
                            //// תתחשב בכל הגורמיים הרלוונטים ותסביר למה מה שאתה נותן הוא באמת כן עובד 
                            //Console.WriteLine("User found in system.");
                            //int id = lealshinDAL.GetMalshinIdByName(checkName);
                            //Console.WriteLine("Enter your intel report:");
                            //string report = Console.ReadLine();
                            //lealshinDAL.InsertIntelReport(id, report);
                            //Console.WriteLine("Report added successfully.");


                        }
                        else
                        {
                            LealshinSERVICE halshana = new LealshinSERVICE();
                            Console.WriteLine("you NOT found in system but you insert you right now  and inserted you name");
                            Console.WriteLine("We will now create a new informant card.");
                            halshana.InsertButNameNotFound(checkName);
                        }

                        break;
                    case 2:
                        Console.WriteLine("please enter here you password");
                        string checkPassword = Console.ReadLine();

                        //LealshinDAL lealshinDAL = new LealshinDAL();

                        break;
                    case 3:
                        pause = true;
                        break;
                }
            
            }
        }

}
}
