
using CwkLogger.Abstractions;
using CwkLogger.Factories;
using CwkLogger.Formatters;
using CwkLogger.Targets;
using IoC.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CwkLogger
{
    public class LoggerManager:ILogger
    {
        private readonly CwkAbstractLogger _Logger;

        public LoggerManager(CwkAbstractLogger logger)
        {
            this._Logger = logger;
        }
        /// <summary>
        /// this implementation for ILogger , View Exception message 
        /// </summary>
        /// <param name="message">Exception you want to view it over console
        public void LogException(string message)
        {
            var formatted = LoggerFormatterFactory.GetExceptionFormatter().FormatMessage(message);
            _Logger?.Log(formatted);
        }
        /// <summary>
        /// This implementation for ILogger , use it to view default message 
        /// </summary>
        /// <param name="message">Message you want to view it over console</param>
        public void LogMessage(string message)
        {
            var formatted = LoggerFormatterFactory.GetRegularFormatter().FormatMessage(message);
            _Logger?.Log(formatted);
        }

        /// <summary>
        /// View exception message by console 
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="formatter">ExceptionLogFormatter object</param>
        public void LogMessage(string message, ExceptionLogFormatter formatter)
        {
            var formatted = formatter.FormatMessage(message);
            _Logger?.Log(formatted);
        }
        /// <summary>
        /// View default message by console 
        /// </summary>
        /// <param name="message">Default message</param>
        /// <param name="formatter">DefaultLogFormatter object</param>
        public void LogMessage(string message,DefaultLogFormatter formatter)
        {
            var formatted = formatter.FormatMessage(message);
            _Logger.Log(formatted);
        }
        
    }
}
