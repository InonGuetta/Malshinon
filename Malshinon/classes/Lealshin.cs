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
        public int malshin_status { get; set; }
        public string malshin_about { get; set; }
        // אין להכניס לקונסטרקטור אלא אך ורק שזה יוגדל ב  1 כל הרצה שעושים 
        // למתודת ההוספה 
        public int malshin_amount_halshana { get; set; }


        public string malshin_content_halshana { get; set; }

        //---------------------------------------------------------------------------------------------------
        public Lealshin(string malshinFirstName,string malshinLastName,string malshinSecretCode,int malshinStatus, string malshinAbout,string malshinContentHalshana)
        {
            // למה צריך את זה ?
            this.malshin_first_name = malshinFirstName;
            this.malshin_last_name = malshinLastName;
            this.malshin_secret_code = malshinSecretCode;
            this.malshin_status = malshinStatus;
            this.malshin_about = malshinAbout;
            this.malshin_content_halshana = malshinContentHalshana;


        }

    }
}
