using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Malshinon.DAL
{
    internal class Text_contentDAL
    {
        string connStr = "server=localhost;username=root;password=;database=malshinon;";
        // -----------------------------------------------------------------------------------------------------------------------
        
        public int Malshinim_Id()
        {

            int malshinim_id = 1;  
            return malshinim_id;
        }
        //================================================================
        public int Accused_Id()
        {
            int accused_id = 2;
            return accused_id;
        }


        // -----------------------------------------------------------------------------------------------------------------------

        // הקוד לא פעיל כרגע
        public string InsertHalshanaToContentClient(string content_report)
        {
            int malshinim_id = Malshinim_Id();
            int accused_id = Accused_Id();
            string query = $"INSERT INTO text_content (malshinim_id,accused_id,content_report ) " +
                $"VALUES  ('{malshinim_id}','{accused_id}','{content_report}');";
            PushSql(query);
            return "";
        }

        // -----------------------------------------------------------------------------------------------------------------------
        public void PushSql(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"err: {e}");
                }
            }
        }


    }
}

