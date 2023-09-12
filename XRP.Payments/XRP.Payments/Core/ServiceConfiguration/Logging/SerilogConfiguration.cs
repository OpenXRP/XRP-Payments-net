using Grace.DependencyInjection;
using Serilog;
using System.IO;

namespace XRP.Payments.Core.ServiceConfiguration.Logging
{
    public class SerilogConfiguration
    {
        public static void CreateSerilogger(DependencyInjectionContainer container, string directoryPath = "")
        {
            string logEntriesPath = Path.Combine(directoryPath, "xrp" + ".txt");
            container.Configure(q => q.ExportFactory(() => new LoggerConfiguration()
               .WriteTo.Async((w) => w.File(logEntriesPath, rollingInterval: RollingInterval.Day,
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}"))
               .CreateLogger()).As<ILogger>().Lifestyle.Singleton());
        }
    }
}
