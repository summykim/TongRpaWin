using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using TongRpaCommon.Config;
using TongRpaCommon.Model;
using TongRpaCommon.Utils;

namespace TongRpaCommon.ApiService
{
    public static class UserService
    {
        public static User Login(string UserId, string userPwd)
        {

            User userinfo = null;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/AdminUserLogin?";
            string pararm = "userId=" + UserId ;
            pararm += "&userPwd=" + userPwd;
            url = url + apiname + pararm;
             String json =HttpUtil.ApiRequestHttp(url, "AdminUserLogin");
            if (json != null)
            {
                JObject jobj = JObject.Parse(json);
                JObject resultobj = (JObject)jobj["result"];
                if (resultobj != null)
                {
                    userinfo = new User(resultobj.ToString());
                }
            }



            return userinfo;
        }


        public static User getUserInfo(string UserId,string chbotKey)
        {

            User userinfo = null;

           string url = "http://"+ ConnectionConstants.HostName+":"+ ConnectionConstants.WasPort;
            string apiname = "/searchUser?";
            string pararm = "userId="+ UserId+"&chbotKey= " + chbotKey;
            url = url + apiname + pararm;
            String json = HttpUtil.ApiRequestHttp(url, "searchUser");

            if (json!=null && json != "")
            {
                userinfo = new User(json);
            }
            

            return userinfo;
        }

        public static List<User> getUserList(string UserId , string UserNm)
        {

            List<User> userList  = null;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/userList?";
            string pararm = "userId=" + UserId;
            pararm = "userNm=" + UserNm;

            url = url + apiname + pararm;
             String json =HttpUtil.ApiRequestHttp(url, "userList");
            JArray joArray = JArray.Parse(json);
            if (json != null && json != "")
            {
                 userList =new  List<User>();
                for (int i=0; i< joArray.Count; i++)
                {
                    JObject  jobj=(JObject)joArray[i];
                    User userinfo = new User(jobj.ToString());
                    userList.Add(userinfo);
                }
                
            }


            return userList;
        }

        public static int  InsertUser(User userInfo)
        {

            int result_cnt = 0;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/insertUser?";
            string pararm = "userId=" + userInfo.user_id;
                  pararm += "&userNm=" + userInfo.user_nm;
                pararm += "&chbotKey=" + userInfo.chbot_key;
                pararm += "&userPhone=" + userInfo.user_phone;
                pararm += "&userEmail=" + userInfo.user_email;
                pararm += "&userTyp=" + userInfo.user_typ;
                pararm += "&regUser=" + userInfo.reg_user;
            url = url + apiname + pararm;
             String json =HttpUtil.ApiRequestHttp(url, "insertUser");

            if (json != null && json != "")
            {
                JObject jobj = JObject.Parse(json);

                result_cnt = (int)jobj["result_cnt"];
            }


            return result_cnt;
        }

        public static int updateUser(User userInfo)
        {

            int result_cnt = 0;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/updateUser?";
            string pararm = "userId=" + userInfo.user_id;
            pararm += "&userNm=" + userInfo.user_nm;
            pararm += "&chbotKey=" + userInfo.chbot_key;
            pararm += "&userPhone=" + userInfo.user_phone;
            pararm += "&userEmail=" + userInfo.user_email;
            pararm += "&userTyp=" + userInfo.user_typ;
            pararm += "&regUser=" + userInfo.reg_user;
            url = url + apiname + pararm;
             String json =HttpUtil.ApiRequestHttp(url, "updateUser");

            if (json != null && json != "")
            {
                JObject jobj = JObject.Parse(json);

                result_cnt = (int)jobj["result_cnt"];
            }


            return result_cnt;
        }

        public static int deleteUser(User userInfo)
        {

            int result_cnt = 0;

            string url = "http://" + ConnectionConstants.HostName + ":" + ConnectionConstants.WasPort;
            string apiname = "/deleteUser?";
            string pararm = "userId=" + userInfo.user_id;
            url = url + apiname + pararm;
             String json =HttpUtil.ApiRequestHttp(url, "deleteUser");

            if (json != null && json != "")
            {
                JObject jobj = JObject.Parse(json);

                result_cnt = (int)jobj["result_cnt"];
            }


            return result_cnt;
        }
    }
}
