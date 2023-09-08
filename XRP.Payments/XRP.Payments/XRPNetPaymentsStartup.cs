using Grace.DependencyInjection;

namespace XRP.Payments
{
    public class XRPNetPaymentsStartup
    {
        private static readonly DependencyInjectionContainer Container = new DependencyInjectionContainer();
        public static void InitializeKernel(int httpClientTimeoutSeconds = 120)
        {
        }

        public static T GetService<T>()
        {
            return Container.Locate<T>();
        }
    }
}
