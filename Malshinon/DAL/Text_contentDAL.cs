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

        // הקוד לא פעיל כרגע
        
        
        public string InsertHalshanaToContentClient(int text_content_id, int malshinim_id, int accused_id, string content_report)
        {
            string query = $"INSERT INTO text_content (text_content_id,malshinim_id,accused_id,content_report ) " +
                $"VALUES  ('{text_content_id}','{malshinim_id}','{accused_id}','{content_report}');";
            return query;
        }


    }
}

