using System.Text.Json.Serialization;

namespace lvfucs.Core.Models
{
    public class LunaJson
    {
        [JsonPropertyName("servername")]
        public string ServerName { get; set; } = null!;

        [JsonPropertyName("ipv4")]
        public string IPv4 { get; set; } = null!;

        [JsonPropertyName("ipv6")]
        public string IPv6 { get; set; } = null!;

        [JsonPropertyName("server_uuid")]
        public string ServerUUID { get; set; } = null!;

        [JsonPropertyName("server_type")]
        public string ServerType { get; set; } = null!;

        [JsonPropertyName("squid_creds")]
        public SquidCreds? SquidCreds { get; set; }

        [JsonPropertyName("proxy_peers")]
        public ProxyPeers? ProxyPeers { get; set; }
    }
}
