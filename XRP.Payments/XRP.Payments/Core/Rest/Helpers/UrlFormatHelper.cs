using XRP.Payments.Core.Constants;
using XRP.Payments.Core.Enums;

namespace XRP.Payments.Core.Rest.Helpers
{
    internal static class UrlFormatHelper
    {
        public static string GetBaseUrlForEnv(BlockchainEnvironments env)
        {
            string baseAddress = "";
            if (env == BlockchainEnvironments.DevNet)
            {
                baseAddress = XRPChainBaseUrls.DEVNET;
            }
            if (env == BlockchainEnvironments.Testnet)
            {
                baseAddress = XRPChainBaseUrls.TESTNET;
            }
            if (env == BlockchainEnvironments.AMMDevnet)
            {
                baseAddress = XRPChainBaseUrls.AMMDEVNET;
            }
            if (env == BlockchainEnvironments.HooksV3_TestNet)
            {
                baseAddress = XRPChainBaseUrls.HOOKSV3_TESTNET;
            }
            if (env == BlockchainEnvironments.Sidechain_Devnet)
            {
                baseAddress = XRPChainBaseUrls.SIDECHAIN_DEVNET;
            }
            if (env == BlockchainEnvironments.Mainnet)
            {
                baseAddress = XRPChainBaseUrls.MAIN_NET;
            }

            return baseAddress;
        }
    }
}
