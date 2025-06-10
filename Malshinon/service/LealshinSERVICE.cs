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
                //to_malsin_status[0],
                "הוא מלשין רציני"
                ); LealshinDAL dal = new LealshinDAL();

            dal.addToLealshin(lealshin);

            Console.WriteLine("המלשין נוסף בהצלחה למסד הנתונים.");
        }


        void printAll()
        {
            string connStr = "server=localhost;username=root;password=;database=malshinon;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string query = "SELECT * FROM malshinim";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // הועתק במלואו ולא הובן כיאות 
                    int malshin_id = reader.GetInt32("malshin_id");
                    string malshin_first_name = reader.GetString("malshin_first_name");
                    string malshin_last_name = reader.GetString("malshin_last_name");
                    string malshin_secret_code = reader.GetString("malshin_secret_code");
                    string malshin_status = reader["malshin_status"] == DBNull.Value ? "malshin" : reader.GetString("malshin_status");
                    string malshin_about = reader["malshin_about"] == DBNull.Value ? "" : reader.GetString("malshin_about");
                    int malshin_amount_halshana = reader["malshin_amount_halshana"] == DBNull.Value ? 0 : reader.GetInt32("malshin_amount_halshana");
                    DateTime malshin_time_halshana = reader.GetDateTime("malshin_time_halshana");

                    Console.WriteLine($"ID: {malshin_id}, Name: {malshin_first_name} {malshin_last_name}, Code: {malshin_secret_code}, " +
                                      $"Status: {malshin_status}, About: {malshin_about}, Amount: {malshin_amount_halshana}, Time: {malshin_time_halshana}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"err: {e}" );
            }
            finally
            {
                conn.Close(); 
            }


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
