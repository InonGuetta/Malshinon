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
            string[] digits = {
                "a","b","c","d","e","f","g","h","i","j","k","l","m",
                "n","o","p","q","r","s","t","u","v","w","x","y","z",
                "A","B","C","D","E","F","G","H","I","J","K","L","M",
                "N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
                "0","1","2","3","4","5","6","7","8","9"
            };
            Random rnd = new Random();
            string secret_code = "";
            for (int i = 0; i < 10; i++)
            {
                int indexDigitsRandom = rnd.Next(0, digits.Length);
                string insert = digits[indexDigitsRandom];
                secret_code += insert;
            }
            return secret_code;

        }
        //================================================================
        public string Malshin_About()
        {
            Console.WriteLine("about how you wan't Lehalsin yamaniak");
            return Console.ReadLine();
        }
        //================================================================
        public string contentHalshana()
        {
            Console.WriteLine("please insert here content halshana");
            //AccusedDAL accusedDAL = new AccusedDAL();
            return Console.ReadLine();
        }

        //-------------------------------------------------------------------------------------------------------
        public void InsertButNameNotFound(string checkName)
        {
            string last_name = Last_Name();
            string secret_code = Secret_Code();
            string malshin_about = Malshin_About();
            //---
            LealshinDAL to_halshana = new LealshinDAL();
            AccusedDAL accusedDAL = new AccusedDAL();
            Text_contentDAL text_ContentDAL = new Text_contentDAL();


            string query = to_halshana.InsertHalshanaFromClient(checkName, last_name, secret_code, malshin_about);
            to_halshana.PushSql(query);


            string content_halshana = contentHalshana();
            string queryContentToHalshana = text_ContentDAL.InsertHalshanaToContentClient(content_halshana);

            // האם כשאני ישנה את הפונקצייה 
            // לכך שהיא תחזיר VOID 
            // הפונקצייה InsertHalshanaFromClientToAccused 
            // עדיין תעבוד 
            string queryToAccused = accusedDAL.InsertHalshanaFromClientToAccused(malshin_about);
            accusedDAL.PushSql(queryToAccused);

            Console.WriteLine("You have successfully added to the system and the password assigned to you is");
            Console.WriteLine($"your password i'ts: {secret_code} \n");



        }


        //-------------------------------------------------------------------------------------------------------


        //  חטיבת הקוד הראשונה לטיפול 
        //
        // כאשר מוזן ערך הלשנה ומעודכן בטבלת malshinim 
        // היא אוטמטית מוזנת גם לערכים של טבלת ואז יש לנו את הערכים של טבלת accused מה שיוצר אצלה את את הערך accused_id
        // malshinim_id וגם של accused_id



        // חטיבת קוד השנייה לטיפול לטיפול
        //
        // אני מעוניין כי החלק קוד כאן יקבל וישמור את הערכים הבאים  
        // הערך malshin_id של טבלת malshinim
        // הערך accused_id של טבלת accused 









        //public void InsertButSecretCodeNotFound()
        //{
        //    string first_name = First_Name();
        //    string last_name = Last_Name();
        //    string secret_code = Secret_Code();
        //    string malshin_about = Malshin_About();
        //    LealshinDAL to_halshana = new LealshinDAL();
        //    string query = to_halshana.InsertHalshanaFromClient(first_name , last_name, secret_code, malshin_about);
        //    to_halshana.PushSql(query);
        //}
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
