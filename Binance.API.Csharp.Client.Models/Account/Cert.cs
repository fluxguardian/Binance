using Newtonsoft.Json;

namespace Binance.API.Csharp.Client.Models.Account
{
    public class Cert
    {
        [JsonProperty("public")]
        public string Public { get; set; }
        [JsonProperty("private")]
        public string Private { get; set; }
    }
}
