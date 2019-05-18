using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace MqAgent
{
    class PythonExecutor
    {

        public  string  RunPythonCmd(string cmd)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "python";
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


        public string  DoPython(string scriptCode)
        {

            int a = 1;
            int b = 2;
            string result = "";
            Microsoft.Scripting.Hosting.ScriptEngine py = Python.CreateEngine(); // allow us to run ironpython programs
            Microsoft.Scripting.Hosting.ScriptScope s = py.CreateScope(); // you need this to get the variables
            py.Execute("x = " + a + "+" + b, s); // this is your python program

            result = s.GetVariable("x");
            Console.WriteLine(result); // get the variable from the python program

            return result;

        }

    }
}
