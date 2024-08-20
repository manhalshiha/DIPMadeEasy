using CwkLogger.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwkLogger.Targets
{
    public class ConsoleLogger:CwkAbstractLogger
    {
       

        public override void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
