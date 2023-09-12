using Newtonsoft.Json;

namespace XRP.Payments.Core.Rest.Models.Requests.Connection
{
    public class PingRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("command")]
        public string CommandName { get; set; }
    }
}
