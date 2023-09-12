using Grace.DependencyInjection;
using System.IO;
using XRP.Payments.Core.Enums;
using XRP.Payments.Core.Exceptions;
using XRP.Payments.Core.ServiceConfiguration;
using XRP.Payments.Core.ServiceConfiguration.Logging;

namespace XRP.Payments
{
    public class XRPNetPaymentsStartup
    {
        private static readonly DependencyInjectionContainer Container = new DependencyInjectionContainer();
        public static void InitializeKernel(BlockchainEnvironments environmentTarget, bool performDiagnostic = false, string loggingDirectoryPath = "")
        {
            PaymentServicesConfigurator.InitializeServices(Container);
            GraceHttpModules.InitializeHttpServices(Container, environmentTarget);

            if (performDiagnostic)
            {
                if (string.IsNullOrWhiteSpace(loggingDirectoryPath))
                {
                    throw new InvalidDiagnosticsDirectoryException("Directory path is not valid for running diagnostics on the XRP Library");
                }

                if (!Directory.Exists(loggingDirectoryPath))
                {
                    Directory.CreateDirectory(loggingDirectoryPath);
                }

                SerilogConfiguration.CreateSerilogger(Container, loggingDirectoryPath);
            }
        }

        public static T GetService<T>()
        {
            return Container.Locate<T>();
        }
    }

}
