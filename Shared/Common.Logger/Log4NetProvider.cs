using System;
using System.Collections.Concurrent;
using System.IO;
using System.Reflection;
using System.Xml;
using log4net.Config;
using log4net.Repository;
using Microsoft.Extensions.Logging;

namespace Sample.Core.Common.Logger
{
    public class Log4NetProvider : ILoggerProvider
    {
        private ILoggerRepository _loggerRepository;
        private readonly Func<string, bool> _sourceFilterLogFunc;
        private static readonly DoNotLogger _doNotLogger = new DoNotLogger(); 
        private readonly ConcurrentDictionary<string, Log4NetLogger> _loggers = new ConcurrentDictionary<string, Log4NetLogger>();

        public Log4NetProvider(string log4NetConfigFilename, Func<string, bool> sourceFilterLogFunc = null)
        {
            _sourceFilterLogFunc = sourceFilterLogFunc ?? (x => false);
            ParseLog4NetConfigFile(log4NetConfigFilename);
        }

        public ILogger CreateLogger(string name)
        {
            if (_sourceFilterLogFunc(name))
                return _doNotLogger;

            return _loggers.GetOrAdd(name, x => new Log4NetLogger(_loggerRepository.Name,name));
        }

        public void Dispose()
        {
            _loggers.Clear();
        }
   
        private void ParseLog4NetConfigFile(string log4NetConfigFilename)
        {
            var log4NetConfig = new XmlDocument();
            log4NetConfig.Load(File.OpenRead(log4NetConfigFilename));

            _loggerRepository = log4net.LogManager.CreateRepository(Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));

            XmlConfigurator.Configure(_loggerRepository, log4NetConfig["log4net"]);
        }
    }
}