using System.Text.Json.Serialization;

namespace lvfucs.Core.V2.Models
{
    public class ProxyPeers
    {
        [JsonPropertyName("hostname")]
        public string? Hostname { get; set; }

        [JsonPropertyName("ipv4")]
        public string? IPv4 { get; set; }

        [JsonPropertyName("ipv6")]
        public string? IPv6 { get; set; }

        [JsonPropertyName("peer1_png")]
        public string? Peer1Png { get; set; }

        [JsonPropertyName("peer1_conf")]
        public string? Peer1Conf { get; set; }

        [JsonPropertyName("peer2_png")]
        public string? Peer2Png { get; set; }

        [JsonPropertyName("peer2_conf")]
        public string? Peer2Conf { get; set; }

        [JsonPropertyName("peer3_png")]
        public string? Peer3Png { get; set; }

        [JsonPropertyName("peer3_conf")]
        public string? Peer3Conf { get; set; }

        [JsonPropertyName("peer4_png")]
        public string? Peer4Png { get; set; }

        [JsonPropertyName("peer4_conf")]
        public string? Peer4Conf { get; set; }

        [JsonPropertyName("peer5_png")]
        public string? Peer5Png { get; set; }

        [JsonPropertyName("peer5_conf")]
        public string? Peer5Conf { get; set; }

        [JsonPropertyName("peer6_png")]
        public string? Peer6Png { get; set; }

        [JsonPropertyName("peer6_conf")]
        public string? Peer6Conf { get; set; }

        [JsonPropertyName("peer7_png")]
        public string? Peer7Png { get; set; }

        [JsonPropertyName("peer7_conf")]
        public string? Peer7Conf { get; set; }

        [JsonPropertyName("peer8_png")]
        public string? Peer8Png { get; set; }

        [JsonPropertyName("peer8_conf")]
        public string? Peer8Conf { get; set; }

        [JsonPropertyName("peer9_png")]
        public string? Peer9Png { get; set; }

        [JsonPropertyName("peer9_conf")]
        public string? Peer9Conf { get; set; }

        [JsonPropertyName("peer10_png")]
        public string? Peer10Png { get; set; }

        [JsonPropertyName("peer10_conf")]
        public string? Peer10Conf { get; set; }
    }
}

