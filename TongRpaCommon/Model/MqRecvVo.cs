using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace TongRpaCommon.Model
{

    public class MqRecvVo
    {
        public MqRecvVo(string json)
        {
            JObject jObject = JObject.Parse(json);
            req_typ = (string)jObject["req_typ"];
            agent_id = (string)jObject["agent_id"];
            exec_req_id = (string)jObject["exec_req_id"];
            req_data = (string)jObject["req_data"];

            
            if (jObject["job_tmout"]!=null)
            {
                int timeout;
                bool castRlt=int.TryParse((string)jObject["job_tmout"], out timeout);
                if (!castRlt) job_tmout = 10;
                else job_tmout = timeout;
            }
        

        }

        public string req_typ { get; set; }
        public string agent_id { get; set; }
        public string exec_req_id { get; set; }
        public string req_data { get; set; }

        public int  job_tmout { get; set; }


    }
}
