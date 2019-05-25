using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace TongRpaCommon.Model
{

    public class User
    {
        public string userNm;

        public User(string json)
        {
            if (json != null && json!="")
            {
                JObject jObject = JObject.Parse(json);
                user_id = (string)jObject["user_id"];
                user_nm = (string)jObject["user_nm"];
                chbot_key = (string)jObject["chbot_key"];
                user_pwd = (string)jObject["user_pwd"];
                user_typ = (string)jObject["user_typ"];
                user_phone = (string)jObject["user_phone"];
                user_email = (string)jObject["user_email"];
                reg_user = (string)jObject["reg_user"];
                reg_dtm = (string)jObject["reg_dtm"];
                upd_dtm = (string)jObject["upd_dtm"];
            }

        }
        public String user_id { get; set; }
        public String user_nm { get; set; }
        public String chbot_key { get; set; }
        public String user_typ { get; set; }
        public String user_pwd { get; set; }
        public String user_phone { get; set; }
        public String user_email { get; set; }
        public String reg_user { get; set; }
        public String reg_dtm { get; set; }
        public String upd_dtm { get; set; }



    }
}
