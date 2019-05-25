using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace TongRpaCommon.Model
{

    public class MqSendHealthVo
    {
        public string res_typ { get; set; }
        public string agent_id { get; set; }
        public string agent_status { get; set; }


        public String toJson()
        {
            JObject jObject = new JObject();
             jObject["res_typ"] = res_typ;
             jObject["agent_id"]= agent_id;
            jObject["agent_status"]=agent_status;
            return jObject.ToString();
        }

    }
}
