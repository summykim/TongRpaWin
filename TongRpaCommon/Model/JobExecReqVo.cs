using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace TongRpaCommon.Model
{

    public class JobExecReqVo
    {
        public JobExecReqVo(string json)
        {
            if(json!=null && json != "")
            {
                JObject jObject = JObject.Parse(json);
                exec_req_id = (string)jObject["exec_req_id"];
                agent_id = (string)jObject["agent_id"];
                job_id = (string)jObject["job_id"];
                job_status = (string)jObject["job_status"];
                agent_status = (string)jObject["agent_status"];
                rlt_data = (string)jObject["rlt_data"];
                reg_user = (string)jObject["reg_user"];
                reg_dtm = (string)jObject["reg_dtm"];
                upd_dtm = (string)jObject["upd_dtm"];
                rlt_status = (string)jObject["rlt_status"];
            }

        }


        public String exec_req_id { get; set; } 
        public String agent_id { get; set; } 
        public String job_id { get; set; }
        public String job_status { get; set; } 
        public String agent_status { get; set; }
        public String rlt_data { get; set; } 

        public String reg_user { get; set; } 
        public String reg_dtm { get; set; } //등록일,
        public String upd_dtm { get; set; }  //업데이트일시

        public String rlt_status { get; set; }  
    }
}
