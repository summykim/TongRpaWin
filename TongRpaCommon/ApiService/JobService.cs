using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using TongRpaCommon.Config;
using TongRpaCommon.Model;
using TongRpaCommon.Utils;

namespace TongRpaCommon.ApiService
{
    public static class JobService
    {
        public static Job getJobInfo(string jobId)
        {

            Job jobInfo = null;

           string url = "http://"+ ConnectionConstants.HostName+":"+ ConnectionConstants.WasPort;
            string apiname = "/searchJob?";
            string pararm = "jobId=" + jobId;
            url = url + apiname + pararm;
             String json =HttpUtil.ApiRequestHttp(url, "searchJob");

            if(json!=null && json != "")
            {
                jobInfo = new Job(json);
            }
            

            return jobInfo;
        }

        public static List<Job> getJobList(string authUser, string searchText,string jobId)
        {

            List<Job> jobList = null;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/jobList?";
            string param = "searchText=" + searchText;
            param += "&authUser=" + authUser;
            param += "&jobId=" + jobId;

            url = url + apiname + param;

            String json = HttpUtil.ApiRequestHttp(url, "jobList");
            JArray joArray = JArray.Parse(json);
            if (json != null && json != "")
            {
                jobList = new List<Job>();
                for (int i = 0; i < joArray.Count; i++)
                {
                    JObject jobj = (JObject)joArray[i];
                    Job  jobInfo = new Job(jobj.ToString());
                    jobList.Add(jobInfo);
                }

            }
            return jobList;
        }


        public static int InsertJob(Job jobInfo)
        {

            int result_cnt = 0;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/insertJob?";
            string param = "jobId=" + jobInfo.job_id;
            param += "&jobNm=" + jobInfo.job_nm;
            param += "&jobDesc=" + jobInfo.job_desc;
            param += "&jobTyp=" + jobInfo.job_typ;
            param += "&jobData=" + jobInfo.job_data;
            param += "&jobTmout=" + jobInfo.job_tmout;
            param += "&authUser=" + jobInfo.auth_user;
            param += "&regUser=" + jobInfo.reg_user;
            url = url + apiname + param;
            String json = HttpUtil.ApiRequestHttp(url, "insertJob");

            if (json != null && json != "")
            {
                JObject jobj = JObject.Parse(json);

                result_cnt = (int)jobj["result_cnt"];
            }


            return result_cnt;
        }

        public static int updateJob(Job jobInfo)
        {

            int result_cnt = 0;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/updateJobInfo?";
            string param = "jobId=" + jobInfo.job_id;
            param += "&jobNm=" + jobInfo.job_nm;
            param += "&jobDesc=" + jobInfo.job_desc;
            param += "&jobTyp=" + jobInfo.job_typ;
            param += "&jobData=" + jobInfo.job_data;
            param += "&jobTmout=" + jobInfo.job_tmout;
            param += "&authUser=" + jobInfo.auth_user;
            param += "&regUser=" + jobInfo.reg_user;
            url = url + apiname + param;
            String json = HttpUtil.ApiRequestHttp(url, "updateJobInfo");

            if (json != null && json != "")
            {
                JObject jobj = JObject.Parse(json);

                result_cnt = (int)jobj["result_cnt"];
            }


            return result_cnt;
        }

        public static int deleteJob(Job jobInfo)
        {

            int result_cnt = 0;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/deleteJob?";
            string param = "jobId=" + jobInfo.job_id;
            url = url + apiname + param;
            String json = HttpUtil.ApiRequestHttp(url, "deleteJob");

            if (json != null && json != "")
            {
                JObject jobj = JObject.Parse(json);

                result_cnt = (int)jobj["result_cnt"];
            }


            return result_cnt;
        }

    }
}
