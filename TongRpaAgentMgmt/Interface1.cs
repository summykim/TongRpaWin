﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongRpaAgentMgmt
{
    public interface IMLSharpPython
    {
        string ExecutePythonScript(string filePythonScript, out string standardError);
    }
}
