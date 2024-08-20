using CwkLogger.Abstractions;
using CwkLogger.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwkLogger.Factories
{
    public static class LoggerFormatterFactory
    {
        public  static DefaultLogFormatter GetRegularFormatter()
        {
            return new DefaultLogFormatter();
        }
        public static ExceptionLogFormatter GetExceptionFormatter()
        {
            return new ExceptionLogFormatter();
        }
    }
}
