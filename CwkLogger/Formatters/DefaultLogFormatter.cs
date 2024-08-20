using CwkLogger.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwkLogger.Formatters
{
    public class DefaultLogFormatter:AbstractLoggerFormatter
    {
        

        public override string FormatMessage(string message)
        {
            return $"{DateTime.Now.ToShortDateString()} - {message}";
        }
    }
}
