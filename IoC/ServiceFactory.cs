
using CwkLogger;
using CwkLogger.Targets;
using IoC.Abstractions;

namespace IoC
{
    public static class ServiceFactory
    {
        public static ILogger GetLogger()
        {
            var consoleLogger = new ConsoleLogger();
            return new LoggerManager(consoleLogger);
        }

    }
}
