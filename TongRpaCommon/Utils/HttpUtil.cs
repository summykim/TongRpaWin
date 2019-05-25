using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TongRpaCommon.Utils
{
    public static class HttpUtil
    {

        public static string RequestHttp(string url)
        {
            string result = null;

            Console.WriteLine("url : " + url);

            try
            {
                
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                request.Timeout = 5000; request.ReadWriteTimeout = 30000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                result = reader.ReadToEnd();
                stream.Close();
                response.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }
        public static string ApiRequestHttp(string Url,string Apiname)
        {
            string result = null;

            Console.WriteLine("Url : " + Url);

            try
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);

                //API 인증용 헤더추가  base64인코딩 ( API명 +  현재시간 )

                string curDtm = DateTime.Now.ToString("yyyyMMddHHmmss");


                string Authorization = Apiname + "|" + curDtm;



                byte[] bytes = Encoding.Unicode.GetBytes(Authorization);

                // 바이트들을 Base64로 변환
                string base64Authorization = Convert.ToBase64String(bytes);

                request.Headers.Add("Authorization", base64Authorization);

                request.Timeout = 5000; request.ReadWriteTimeout = 30000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                result = reader.ReadToEnd();
                stream.Close();
                response.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }


    }
}
