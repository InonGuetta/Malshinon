using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace Malshinon.classes
{
    internal class Lealshin
    {
        public string malshin_first_name { get; set; }
        public string malshin_last_name { get; set; }
        public string malshin_secret_code { get; set;}
        //public string malshin_status { get; set; }
        public string malshin_about { get; set; }
        // אין להכניס לקונסטרקטור אלא אך ורק שזה יוגדל ב  1 כל הרצה שעושים 
        // למתודת ההוספה 



        //---------------------------------------------------------------------------------------------------
        public Lealshin(string malshinFirstName,string malshinLastName,string malshinSecretCode, string malshinAbout)
        {
            // למה צריך את זה ?
            this.malshin_first_name = malshinFirstName;
            this.malshin_last_name = malshinLastName;
            this.malshin_secret_code = malshinSecretCode;
            //this.malshin_status = malshinStatus;
            this.malshin_about = malshinAbout;


        }
        //---------------------------------------------------------------------------------------------------

        public void addHalshane()
        {
            // איך אני מקשר בין זה 
            // כלומר תמלא כאן את מה שצריך 
        }
    }
}
