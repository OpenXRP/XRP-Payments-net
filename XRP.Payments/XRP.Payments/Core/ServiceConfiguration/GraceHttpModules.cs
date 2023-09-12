using Grace.DependencyInjection;
using Refit;
using XRP.Payments.Core.Enums;
using XRP.Payments.Core.Rest.Helpers;
using XRP.Payments.Core.Rest.Interfaces;

namespace XRP.Payments.Core.ServiceConfiguration
{
    public class GraceHttpModules
    {
        public static void InitializeHttpServices(DependencyInjectionContainer container, BlockchainEnvironments env)
        {
            container.Configure(c =>
            {
                string baseAddress = UrlFormatHelper.GetBaseUrlForEnv(env);

                // Register all the API Services
                c.ExportFactory(() => RestService.For<IConnectionTester>(baseAddress)).As<IConnectionTester>().Lifestyle.Singleton();
            });
        }
    }
}
