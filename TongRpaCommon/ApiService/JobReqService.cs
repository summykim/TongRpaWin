using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using TongRpaCommon.Config;
using TongRpaCommon.Model;
using TongRpaCommon.Utils;

namespace TongRpaCommon.ApiService
{
    public static class JobReqService
    {
        public static JobExecReqVo getJobReqInfo(string jobExecReqId)
        {

            JobExecReqVo Info = null;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/searchjobExecReq?";
            string pararm = "jobExecReqId=" + jobExecReqId;
            url = url + apiname + pararm;
             String json =HttpUtil.ApiRequestHttp(url, "searchjobExecReq");

            if (json != null && json != "")
            {
                Info = new JobExecReqVo(json);
            }


            return Info;
        }

        public static List<JobExecReqVo> jobExecReqList(string agentId, string jobId, string jobExecReqId, string jobStatus)
        {

            List<JobExecReqVo> jobList = null;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/jobExecReqList?";
            string param = "agentId=" + agentId;
            param += "&jobId=" + jobId;
            param += "&jobExecReqId=" + jobExecReqId;
            param += "&jobStatus=" + jobStatus;
            url = url + apiname + param;

             String json =HttpUtil.ApiRequestHttp(url, "jobExecReqList");
            JArray joArray = JArray.Parse(json);
            if (json != null && json != "")
            {
                jobList = new List<JobExecReqVo>();
                for (int i = 0; i < joArray.Count; i++)
                {
                    JObject jobj = (JObject)joArray[i];
                    JobExecReqVo jobInfo = new JobExecReqVo(jobj.ToString());
                    jobList.Add(jobInfo);
                }

            }
            return jobList;
        }

    }
}
