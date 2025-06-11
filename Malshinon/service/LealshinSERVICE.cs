using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Malshinon.classes;
using Malshinon.DAL;
using MySql.Data.MySqlClient;

namespace Malshinon.service
{
    internal class LealshinSERVICE
    {
        static string[] to_malsin_status = { "malshin", "reporter", "potential_agent" };
        //void InsertIntelReport()
        //{
        //    Random rnd = new Random();
        //    string secret_code = "";
        //    for (int i = 0; i < 10; i++)
        //    {
        //        char charRandom = (char)rnd.Next(0, 128);
        //        secret_code += charRandom;
        //    }

        //    Console.WriteLine("insert first name");
        //    string first_name  = Console.ReadLine();
        //    Console.WriteLine("insert last name");
        //    string last_name  = Console.ReadLine();
        //    Console.WriteLine("STATUS to reporte press 1 | Defult don't choice anything = malshin ");
        //    // תראה אחר כך איך אתה עושה את זה שזה יהיה אופציינלי 
        //    int choice_anything = Convert.ToInt32(Console.ReadLine());
        //    string malshin_about = Console.ReadLine();




        //    Lealshin lealshin = new Lealshin(
        //        first_name,
        //        last_name,
        //        secret_code,
        //        //to_malsin_status[choice_anything],

        //        // מה הבעיה כאן 
        //        malshin_about,
        //        ); LealshinDAL dal = new LealshinDAL();

        //    dal.addToLealshin(lealshin);

        //    Console.WriteLine("המלשין נוסף בהצלחה למסד הנתונים.");
        //}


  


        //-------------------------------------------------------------------------------------------------------


        //void InsertNewPerson()
        //{

        //}
        //void UpdateReportCount(){

        //{
        //void UpdateMentionCount()
        //{

        //}
        //void CreateAlert()
        //{

        //}

    }
}
