using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using TongRpaCommon.Config;
using TongRpaCommon.Model;
using TongRpaCommon.Utils;

namespace TongRpaCommon.ApiService
{
    public static class AgentService
    {
        public static Agent getAgentInfo(string macAddress)
        {

            Agent aginfo = null;

            string url = "http://"+ ConnectionConstants.HostName+":"+ ConnectionConstants.WasPort;
            string apiname = "/searchAgent?";
            string pararm = "agentId=&agentUid=" + macAddress;
            url = url + apiname + pararm;
            String json =HttpUtil.ApiRequestHttp(url, "searchAgent");

            if(json!=null && json != "")
            {
                aginfo = new Agent(json);
            }
            

            return aginfo;
        }

        public static List<Agent> getAgentList(string AgentId, string AentNm)
        {

            List<Agent> agentList = null;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/agentList?";
            string pararm = "searchText=";


            url = url + apiname + pararm;
            String json = HttpUtil.ApiRequestHttp(url, "agentList");
            JArray joArray = JArray.Parse(json);
            if (json != null && json != "")
            {
                agentList = new List<Agent>();
                for (int i = 0; i < joArray.Count; i++)
                {
                    JObject jobj = (JObject)joArray[i];
                    Agent agentinfo = new Agent(jobj.ToString());
                    agentList.Add(agentinfo);
                }

            }


            return agentList;
        }

        public static int insertAgent(Agent agentInfo)
        {

            int result_cnt = 0;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/insertAgent?";
            string param = "agentId=" + agentInfo.agent_id;
            param += "&agentNm=" + agentInfo.agent_nm;
            param += "&agentDesc=" + agentInfo.agent_desc;
            param += "&agentUid=" + agentInfo.agent_uid;
            param += "&agentStatus=" + agentInfo.agent_status;
            param += "&regUser=" + agentInfo.reg_user;
 
            url = url + apiname + param;
            String json = HttpUtil.ApiRequestHttp(url, "insertAgent");

            if (json != null && json != "")
            {
                JObject jobj = JObject.Parse(json);

                result_cnt = (int)jobj["result_cnt"];
            }


            return result_cnt;
        }

        public static int updateAgent(Agent agentInfo)
        {

            int result_cnt = 0;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/updateAgentInfo?";
            string param = "agentId=" + agentInfo.agent_id;
            param += "&agentNm=" + agentInfo.agent_nm;
            param += "&agentDesc=" + agentInfo.agent_desc;
            param += "&agentUid=" + agentInfo.agent_uid;
            param += "&agentStatus=" + agentInfo.agent_status;
            param += "&regUser=" + agentInfo.reg_user;
            url = url + apiname + param;
            String json = HttpUtil.ApiRequestHttp(url, "updateAgentInfo");

            if (json != null && json != "")
            {
                JObject jobj = JObject.Parse(json);

                result_cnt = (int)jobj["result_cnt"];
            }


            return result_cnt;
        }

        public static int deleteAgent(Agent agentInfo)
        {

            int result_cnt = 0;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/deleteAgent?";
            string param = "agentId=" + agentInfo.agent_id;
            url = url + apiname + param;
            String json = HttpUtil.ApiRequestHttp(url, "deleteAgent");

            if (json != null && json != "")
            {
                JObject jobj = JObject.Parse(json);

                result_cnt = (int)jobj["result_cnt"];
            }


            return result_cnt;
        }
    }
}
