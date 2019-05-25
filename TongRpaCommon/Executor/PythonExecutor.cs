
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace TongRpaCommon.Executor
{
    public static class PythonExecutor
    {

        public static string  RunPythonCmd(string cmd ,int timeout)
        {
            
            string path = AppDomain.CurrentDomain.BaseDirectory+"/tongPython.py";
 
            File.WriteAllText(path, cmd);
  

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Python/python.exe";
            start.Arguments = string.Format("{0} ", path);
            start.ErrorDialog = false;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            

            string result = "";
            using (Process process = Process.Start(start))
            {
                process.WaitForExit(timeout);
                using (StreamReader reader = process.StandardOutput)
                {
                    result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }


            return result;
        }


    }
}
