using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace TongRpaCommon.Utils
{
    public static class DeviceUtil
    {
        public static string GetMacAddress()
        {
            string macAddr = "";
            // MAC주소 가져오기
            var netList= NetworkInterface.GetAllNetworkInterfaces();
            for(int i=0;i < netList.Length;i++)
            {
               if(netList[i].OperationalStatus== OperationalStatus.Up)
                {
                    macAddr=netList[i].GetPhysicalAddress().ToString();
                    break;
                }
            }
       
            return macAddr;
        }

        public static string MACformat(string str)
        {   //Mac주소 포맷
            StringBuilder sb = new StringBuilder();
            char[] chrArr = str.ToCharArray();
            for (int i = 0; i < chrArr.Length; i++)
            {
                int n = i + 1;
                if (sb.Length > 0 && n % 2 != 0) sb.Append("-");
                sb.Append(chrArr[i].ToString());
            }
            string mac = sb.ToString();
            return mac;
        }

    }
}
