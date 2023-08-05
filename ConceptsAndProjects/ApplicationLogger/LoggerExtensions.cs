using Amazon.CloudWatchLogs;
using AWS.Logger;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogger
{
    public static class LoggerExtensions
    {
        public static IServiceCollection AddCustomLogger(this IServiceCollection services, LogProvider loggers, string logFileName = "app.log")
        {
            ILoggerFactory loggerFactory = null;
            switch (loggers)
            {
                case LogProvider.SeriLog:
                    loggerFactory = getSerilogLogFactory(logFileName);
                    break;
                case LogProvider.Log4Net:
                    loggerFactory = getLog4NetLogFactory();
                    break;
                case LogProvider.AWSCloudWatch:
                    loggerFactory = getAWSCloudWatchLogFactory();
                    break;
                default:
                    break;
            }

            services.AddSingleton(loggerFactory);
            services.AddSingleton<ICustomLogger>(provider =>
            {
                var factory = provider.GetRequiredService<ILoggerFactory>();// create a ILoggerfactory object
                var logger = factory.CreateLogger(""); // create Ilogger object
                return new CustomLogger(logger);
            });

            return services;
        }

        private static ILoggerFactory getSerilogLogFactory(string logFileName)
        {
            // Configure Serilog
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(logFileName, rollingInterval: RollingInterval.Day)
                .CreateLogger();

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddSerilog(Log.Logger);
            });

            return loggerFactory;
        }

        private static ILoggerFactory getLog4NetLogFactory()
        {
            Log4NetProviderOptions log4NetProvider = new Log4NetProviderOptions("log4net.config");

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddLog4Net(log4NetProvider);
            });

            return loggerFactory;
        }

        private static ILoggerFactory getAWSCloudWatchLogFactory()
        {
            var awsLogConfig = new AWSLoggerConfig
            {
                Region = "your-aws-region", // Set your AWS region here
                LogGroup = "your-log-group-name" // Set your CloudWatch Log Group name here
            };

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddAWSProvider(awsLogConfig);
            });

            return loggerFactory;
        }
    }
}
