using System;
using CallWall.Web;

namespace CallWall.Logging
{
    public sealed class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger(Type loggedType)
        {
            return new Log4NetLogger(loggedType);
            //return new ConsoleLogger();
        }
    }
}