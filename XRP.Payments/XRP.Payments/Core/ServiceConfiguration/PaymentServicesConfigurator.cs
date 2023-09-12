using Grace.DependencyInjection;
using XRP.Payments.Core.Services;

namespace XRP.Payments.Core.ServiceConfiguration
{
    public class PaymentServicesConfigurator
    {
        public static void InitializeServices(DependencyInjectionContainer container)
        {
            container.Configure(c =>
            {
                c.Export<ChecksPaymentsService>().Lifestyle.Singleton();
                c.Export<CrossCurrencySwapService>().Lifestyle.Singleton();
                c.Export<DirectXRPPaymentsService>().Lifestyle.Singleton();
                c.Export<EscrowService>().Lifestyle.Singleton();
                c.Export<PartialPaymentsService>().Lifestyle.Singleton();
                c.Export<PaymentChannelsService>().Lifestyle.Singleton();
                c.Export<StreamingService>().Lifestyle.Singleton();
            });
        }
    }
}
