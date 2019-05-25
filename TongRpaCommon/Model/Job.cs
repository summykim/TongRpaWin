using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace TongRpaCommon.Model
{

    public class Job
    {
        public Job(string json)
        {
            if(json!=null && json != "")
            {
                JObject jObject = JObject.Parse(json);
                job_id = (string)jObject["job_id"];
                job_nm = (string)jObject["job_nm"];
                job_desc = (string)jObject["job_desc"];
                job_data = (string)jObject["job_data"];
                job_typ = (string)jObject["job_typ"];
                job_seq = (string)jObject["job_seq"];
                auth_user = (string)jObject["auth_user"];
                reg_user = (string)jObject["reg_user"];
                reg_dtm = (string)jObject["reg_dtm"];
                upd_dtm = (string)jObject["upd_dtm"];
                job_tmout = (string)jObject["job_tmout"];
            }

        }


        public String job_id { get; set; } //job 아이디',
        public String job_nm { get; set; } //job 명',
        public String job_desc { get; set; }//job상세설명',
        public String job_data { get; set; } //job 실행 데이터(스크립트소스, url)',
        public String job_typ { get; set; } //job구분: RST/PY',	
        public String job_seq { get; set; } //사용자별job seq',
        public String auth_user { get; set; } // JOB 소유자
        public String reg_user { get; set; }  // 등록자 
        public String reg_dtm { get; set; } //등록일,
        public String upd_dtm { get; set; }  //업데이트일시

        public String job_tmout { get; set; }  //타임아웃
    }
}
