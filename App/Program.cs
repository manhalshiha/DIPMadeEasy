using IoC;
using IoC.Abstractions;

ILogger? logger = ServiceFactory.GetLogger();
logger?.LogMessage("Program executed successfully");
logger?.LogException("An exception occurred");