using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace TongRpaCommon.Model
{

    public class MqSendVo
    {
        public string res_typ { get; set; }
        public string agent_id { get; set; }
        public string exec_req_id { get; set; }
        public string agent_status { get; set; }
        public string job_status { get; set; }
        public string rlt_data { get; set; }

        public String toJson()
        {
            JObject jObject = new JObject();
             jObject["res_typ"] = res_typ;
             jObject["agent_id"]= agent_id;
             jObject["exec_req_id"]=exec_req_id;
            jObject["agent_status"]=agent_status;
            jObject["job_status"]=job_status;
            jObject["rlt_data"]=rlt_data;
            return jObject.ToString();
        }

    }
}
