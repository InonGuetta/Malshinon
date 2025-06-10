using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Malshinon.classes;
using Malshinon.DAL;

namespace Malshinon.service
{
    internal class ManageGeneral
    {
        static string[] to_malsin_status = { "malshin", "reporter", "potential_agent" };


        public static void Run()
        {
            Random rnd = new Random();
            string secret_code = "";
            for(int i = 0;i< 10;i++){
                char charRandom = (char)rnd.Next(0, 128);
                secret_code += charRandom;
            }

            Lealshin lealshin = new Lealshin(
                "inon",
                "guetta",
                secret_code,
                // למה הוא חייב לקבל ערך
                // למה הוא לא יכול לקבל לא לקבל את הערך הזה הרי כבר מוגדר לי בטבלת SQL 
                // ככזה שיש לו ערך ברירת מחדל הווי אומר שהוא יכול לא לקבל שום ערך 
                to_malsin_status[0],
                "הוא מלשין רציני",
                "הלשין על 3 אנשים"
            ); LealshinDAL dal = new LealshinDAL();

            dal.addToLealshin(lealshin);

            Console.WriteLine("המלשין נוסף בהצלחה למסד הנתונים.");
        }
        //void GetPersonByName()
        //{

        //}
        //void GetPersonBySecretCode()
        //{

        //}
        //void InsertNewPerson()
        //{

        //}
        //void InsertIntelReport()
        //{

        //}
        //void UpdateReportCount()
        //{

        //}
        //void UpdateMentionCount()
        //{

        //}
        //void GetReporterStats()
        //{

        //}
        //void GetTargetStats()
        //{

        //}
        //void CreateAlert()
        //{

        //}
        //void GetAlerts()
        //{

        //}
    }
}
