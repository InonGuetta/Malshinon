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
        //-------------------------------------------------------------------------------------------------------
        public string First_Name()
        {
      
            Console.WriteLine("please insert your first_name: ");
            return Console.ReadLine();
            
  
        }
        //================================================================
        public string Last_Name()
        {
            Console.WriteLine("please insert your last_name: ");
            return Console.ReadLine();
        }
        //================================================================
        public string Secret_Code()
        {
            Random rnd = new Random();
            string secret_code = "";
            for (int i = 0; i < 11; i++)
            {
                char charRandom = (char)rnd.Next(0, 128);
                secret_code += charRandom;
            }
            return secret_code;

        }
        //================================================================

        public string Malshin_About()
        {
            Console.WriteLine("about how you wan't Lehalsin yamaniak");
            return Console.ReadLine();
        }


        //-------------------------------------------------------------------------------------------------------
        public void InsertButNameNotFound(string checkName)
        {
            string last_name = Last_Name();
            string secret_code = Secret_Code();
            string malshin_about = Malshin_About();
            LealshinDAL to_halshana = new LealshinDAL();
            string query = to_halshana.InsertHalshanaFromClient(checkName, last_name, secret_code, malshin_about);
            to_halshana.PushSql(query);
        }
        //-------------------------------------------------------------------------------------------------------
        // עדיין לא בשימוש
        public void InsertButSecretCodeNotFound()
        {
            string first_name = First_Name();
            string last_name = Last_Name();
            string secret_code = Secret_Code();
            string malshin_about = Malshin_About();
            LealshinDAL to_halshana = new LealshinDAL();
            string query = to_halshana.InsertHalshanaFromClient(first_name , last_name, secret_code, malshin_about);
            to_halshana.PushSql(query);
        }
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
