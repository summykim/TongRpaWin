using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace TongRpaCommon.Model
{

    public class Agent
    {
        public Agent(string json)
        {
            if (json != null && json != "")
            {
                JObject jObject = JObject.Parse(json);
                agent_id = (string)jObject["agent_id"];
                agent_nm = (string)jObject["agent_nm"];
                agent_desc = (string)jObject["agent_desc"];
                agent_uid = (string)jObject["agent_uid"];
                agent_status = (string)jObject["agent_status"];
                reg_user = (string)jObject["reg_user"];
                reg_dtm = (string)jObject["reg_dtm"];
                upd_dtm = (string)jObject["upd_dtm"];
            }

        }

        public string agent_id { get; set; }
        public string agent_nm { get; set; }
        public string agent_desc { get; set; }
        public string agent_uid { get; set; }
        public string agent_status { get; set; }
        public string reg_user { get; set; }
        public string reg_dtm { get; set; }
        public string upd_dtm { get; set; }


    }
}
