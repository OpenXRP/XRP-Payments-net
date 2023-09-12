using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XRP.Payments.Core.Rest.Models.Responses.Connection
{
    public class ConnectionError
    {
    }

    public class PingResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("type")]
        public string Response { get; set; }
    }
}
