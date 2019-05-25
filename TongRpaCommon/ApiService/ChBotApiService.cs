using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using TongRpaCommon.Config;
using TongRpaCommon.Model;
using TongRpaCommon.Utils;

namespace TongRpaCommon.ApiService
{
    public static class ChBotApiService
    {
        
        /*   사용자 인증    */
        public static bool checkUser(string chbotKey)
        {


            bool result = false;
           string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/checkUser?";
            string pararm = "chbotKey=" + chbotKey;
            url = url + apiname + pararm;
             String json =HttpUtil.ApiRequestHttp(url, "checkUser");

            if (json != null && json != "")
            {
               JObject  Info = JObject.Parse(json);
                result= (bool)Info["result"];
            }


            return result;
        }
        /* 사용자  챗봇키 정보  업데이트  */
        public static bool userSignUp(string chbotKey,string  userEmail)
        {


            bool result = false;
            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/userSignUp?";
            string pararm = "chbotKey=" + chbotKey + "&userEmail="+ userEmail;
            url = url + apiname + pararm;
             String json =HttpUtil.ApiRequestHttp(url, "userSignUp");

            if (json != null && json != "")
            {
                JObject Info = JObject.Parse(json);
                result = (bool)Info["result"];
            }


            return result;
        }
        /* Job검색 요청  */
        public static List<Job> searchJobList(string chbotKey)
        {

            List<Job> jobList = null;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/searchJobList?";
            string pararm = "chbotKey=" + chbotKey ;
            url = url + apiname + pararm;
             String json =HttpUtil.ApiRequestHttp(url, "searchJobList");

            if (json != null && json != "")
            {
                JObject Info = JObject.Parse(json);
                string  result = (string)Info["result"];
                if (result=="success")
                {
                    JArray joArray = JArray.Parse(Info["jobList"].ToString());

                    jobList = new List<Job>();
                    for (int i = 0; i < joArray.Count; i++)
                    {
                        JObject jobj = (JObject)joArray[i];
                        Job jobInfo = new Job(jobj.ToString());
                        jobList.Add(jobInfo);
                    }
                }
            }


            return jobList;
        }


        /* Job실행 요청  */
        public static string  jobExecReq(string jobId)
        {


            string resultCheckUrl = "";
            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/jobExecReq?";
            string pararm = "jobId=" + jobId ;
            url = url + apiname + pararm;
             String json =HttpUtil.ApiRequestHttp(url, "jobExecReq");

            if (json != null && json != "")
            {
                JObject Info = JObject.Parse(json);
                bool result = (bool)Info["result"];
                if (result)
                {
                    resultCheckUrl= (String)Info["resultCheckUrl"];
                    resultCheckUrl= "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort+ resultCheckUrl;
                }
            }


            return resultCheckUrl;
        }
    }
}
