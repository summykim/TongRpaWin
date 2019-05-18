using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace TongAgentUtil
{
    public static class AgentExecutor
    {

        public static  string  RunPythonCmd(string cmd)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:\\Users\\summy\\AppData\\Local\\Programs\\Python\\Python37-32\\Python.exe";
            start.Arguments = string.Format("{0} ", cmd);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            string result = "";
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }


            return result;
        }


        public static string DoPython(string scriptCode)
        {

            string result = "";
            Microsoft.Scripting.Hosting.ScriptEngine py = Python.CreateEngine(); // allow us to run ironpython programs
            Microsoft.Scripting.Hosting.ScriptScope s = py.CreateScope(); // you need this to get the variables
            //py.Execute(scriptCode, s); // this is your python program
            string FileName = "C:\\Users\\summy\\AppData\\Local\\Programs\\Python\\Python37-32\\test.py";
            py.ExecuteFile(FileName, s);

            result = s.ToString();
            Console.WriteLine(result); // get the variable from the python program

            return result;

        }

    }
}
