
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;


namespace TongRpaCommon.Executor
{
    public static class AgentExecutor
    {

        public  static string  Execute(string reqTyp,string cmd, int  timeout)
        {
            string result = "";
            if (reqTyp == "PY")
            {
             
                result = PythonExecutor.RunPythonCmd(cmd,timeout);
            }

            return result;
        }


    }
    
}
