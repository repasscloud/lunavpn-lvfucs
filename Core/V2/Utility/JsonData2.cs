﻿using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using lvfucs.Core.V2.Models;
using lvfucs.Core.V2.Producer;

namespace lvfucs.Core.V2.Utility
{
	public class JsonData2
	{
		public static async Task GenerateJsonAsync(string outPath)
		{
            // variables we need
            string serverType = "/app/lunavpn/server.type";
            string? serverApp = File.Exists(serverType) ? File.ReadAllText(serverType) : null;

            switch (serverApp?.ToLower())
			{
				case "wg":
                    // remove if existing file
                    if (File.Exists(outPath))
						File.Delete(outPath);

					// get hostname
                    string hostname = Dns.GetHostName();

                    // Get public IPv4 address
                    string publicIP;
                    using (var udpClient = new UdpClient())
                    {
                        udpClient.Connect(IPAddress.Parse("8.8.8.8"), 53);
                        var localEndPoint = (IPEndPoint)udpClient.Client.LocalEndPoint!;
                        publicIP = localEndPoint.Address.ToString();
                    }

                    // Get public IPv6 address
                    string publicIPv6;
                    using (var udpClient = new UdpClient(AddressFamily.InterNetworkV6)) // Use InterNetworkV6 for IPv6
                    {
                        udpClient.Connect(IPAddress.Parse("2001:4860:4860::8888"), 53); // Use an IPv6 DNS server (e.g., Google's DNS)
                        var localEndPoint = (IPEndPoint)udpClient.Client.LocalEndPoint!;
                        publicIPv6 = localEndPoint.Address.ToString();
                    }

                    // wg
                    string wgPeers = "/app/wg/config";
                    if (Directory.Exists(wgPeers))
                    {
                        List<string> peerNames = new List<string>();

                        // iterate over the contents of the directory wgPeers
                        foreach (var entry in Directory.EnumerateDirectories(wgPeers))
                        {
                            // check if the directory meets naming convention
                            if (Directory.Exists(entry))
                            {
                                string folderName = Path.GetFileName(entry);

                                // check if the folder name matches the convention "peerX"
                                if (folderName.Length > 4 && folderName.StartsWith("peer"))
                                {
                                    string remainingDigits = folderName.Substring(4);

                                    // check if the remaining part is a valid integer
                                    if (remainingDigits.All(char.IsDigit))
                                    {
                                        peerNames.Add(folderName);
                                    }
                                }
                            }
                        }

                        // map the proxyPeers values
                        ProxyPeers proxyPeers = GenProd2.GenerateProxyPeers(wgPeersIn: wgPeers, peerNamesIn: peerNames, hostname: hostname, ipv4: publicIP, ipv6: publicIPv6);

                        // Create JsonSerializerOptions with the desired behavior
                        var options = new JsonSerializerOptions
                        {
                            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                        };

                        // Serialize your object using the customized options
                        File.WriteAllText(outPath, JsonSerializer.Serialize(proxyPeers, options));

                        // send to the API
                        using (var httpClient = new HttpClient())
                        {
                            // Create and configure an HTTP request
                            var httpRequest = new HttpRequestMessage(HttpMethod.Post, "https://a661-58-110-79-78.ngrok-free.app/api/WgPeer");

                            // Add the Bearer token to the request header
                            httpRequest.Headers.Add("Authorization", "Bearer woGDRkcBp+fnjaiuohGXOWcqKSokvUoLgnEtL+z3fEaNI7cpzc9mLykwftXB6tOD");

                            // Configure the JSON serializer to ignore null values
                            var jsonOptions = new JsonSerializerOptions
                            {
                                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, // Exclude properties with null values
                                WriteIndented = true // For pretty-printing the JSON
                            };

                            // Serialize the proxyPeers object to JSON with null values ignored
                            var jsonPayload = JsonSerializer.Serialize(proxyPeers, jsonOptions);

                            // Set the JSON payload as the request content
                            httpRequest.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                            // Send the HTTP request and get the response
                            var response = await httpClient.SendAsync(httpRequest);

                            // Check and handle the response as needed
                            if (response.IsSuccessStatusCode)
                            {
                                // Handle a successful response
                                var responseContent = await response.Content.ReadAsStringAsync();
                                Console.WriteLine("HTTP Request Successful. Response: " + responseContent);
                            }
                            else
                            {
                                // Handle an unsuccessful response
                                Console.WriteLine("HTTP Request Failed. Status Code: " + (int)response.StatusCode);
                            }
                        }
                    }
                    break;

				default:
					break;
			}
		}
	}
}

