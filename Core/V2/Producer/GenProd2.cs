using lvfucs.Core.Utilities.Converter;
using lvfucs.Core.V2.Models;

namespace lvfucs.Core.V2.Producer
{
	public class GenProd2
	{
        /// <summary>
        /// Generates a ProxyPeers object by encoding the specified PNG and CONF files
        /// for each matched peerX in the given directory.
        /// </summary>
        /// <param name="wgPeersIn">The base directory containing peerX folders.</param>
        /// <param name="peerNamesIn">A list of peerX folder names to process.</param>
        /// <param name="hostname">Hostname of the machine</param>
        /// <param name="ipv4">IPv4 address of the machine</param>
        /// <param name="ipv6">IPv6 address of the machine</param>
        /// <returns>ProxyPeers object</returns>
        public static ProxyPeers GenerateProxyPeers(string wgPeersIn, List<string> peerNamesIn, string hostname, string ipv4, string ipv6)
        {
            ProxyPeers proxyPeers = new ProxyPeers();

            // add static values we already have
            proxyPeers.Hostname = hostname;
            proxyPeers.IPv4 = ipv4;
            proxyPeers.IPv6 = ipv6;

            // foreach matched peerX, create the base64 encoded value of the required files
            foreach (var peerX in peerNamesIn)
            {
                // the peerX folder on the server (full path)
                var thisPeer = Path.Join(wgPeersIn, peerX);

                // integer value of the peerX
                var peerInt = int.Parse(peerX.Substring(4));

                // encode the peerX PNG and CONF files
                var b64PNG = Base64Coder.Encode(filePath: Path.Join(thisPeer, $"{peerX}.png"));
                var b64Conf = Base64Coder.Encode(filePath: Path.Join(thisPeer, $"{peerX}.conf"));

                // append to the proxyPeers object in-memory
                switch (peerInt)
                {
                    case 1:
                        proxyPeers.Peer1Png = b64PNG;
                        proxyPeers.Peer1Conf = b64Conf;
                        break;
                    case 2:
                        proxyPeers.Peer2Png = b64PNG;
                        proxyPeers.Peer2Conf = b64Conf;
                        break;
                    case 3:
                        proxyPeers.Peer3Png = b64PNG;
                        proxyPeers.Peer3Conf = b64Conf;
                        break;
                    case 4:
                        proxyPeers.Peer4Png = b64PNG;
                        proxyPeers.Peer4Conf = b64Conf;
                        break;
                    case 5:
                        proxyPeers.Peer5Png = b64PNG;
                        proxyPeers.Peer5Conf = b64Conf;
                        break;
                    case 6:
                        proxyPeers.Peer6Png = b64PNG;
                        proxyPeers.Peer6Conf = b64Conf;
                        break;
                    case 7:
                        proxyPeers.Peer7Png = b64PNG;
                        proxyPeers.Peer7Conf = b64Conf;
                        break;
                    case 8:
                        proxyPeers.Peer8Png = b64PNG;
                        proxyPeers.Peer8Conf = b64Conf;
                        break;
                    case 9:
                        proxyPeers.Peer9Png = b64PNG;
                        proxyPeers.Peer9Conf = b64Conf;
                        break;
                    case 10:
                        proxyPeers.Peer10Png = b64PNG;
                        proxyPeers.Peer10Conf = b64Conf;
                        break;
                    default:
                        Console.WriteLine($"Invalid peerX value: {peerX}");
                        break;
                }
            }

            return proxyPeers;
        }
    }
}

