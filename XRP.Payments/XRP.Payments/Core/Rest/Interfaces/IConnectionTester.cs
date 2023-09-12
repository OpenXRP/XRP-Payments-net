using Refit;
using System.Threading.Tasks;
using XRP.Payments.Core.Rest.Models.Responses.Connection;

namespace XRP.Payments.Core.Rest.Interfaces
{
    public interface IConnectionTester
    {
        [Get("/users/{user}")]
        Task<PingResponse> GetUser(string user);
    }
}
