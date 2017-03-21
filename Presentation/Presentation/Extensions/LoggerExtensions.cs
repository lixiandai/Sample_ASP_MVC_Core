using System;
using Sample.Core.Common.Logger;
using Microsoft.Extensions.Logging;


namespace Sample.Core.Presentation.Extensions
{
    public static class LoggerExtensions
    {
        public static void AddLog4Net(this ILoggerFactory loggerFactory, string log4NetConfigFilename, Func<string, bool> sourceFilterLogFunc = null)
        {
            loggerFactory.AddProvider(new Log4NetProvider(log4NetConfigFilename, sourceFilterLogFunc));
        }
    }
}
