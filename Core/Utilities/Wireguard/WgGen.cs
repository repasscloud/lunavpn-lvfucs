using System.Text.Json;
using lvfucs.Core.Models;
using lvfucs.Helper;

namespace lvfucs.Core.Utilities.Wireguard
{
    public class WgGen
    {
        public static async Task<int> PeerData(string jsonFile)
        {
            try
            {
                // delete jsonFile if exists
                if (File.Exists(jsonFile))
                {
                    try {
                        File.Delete(jsonFile);
                        Logger.WriteLog(message: $"Deleted file {jsonFile}", type: "Debug");
                    }
                    catch (Exception ex)
                    {
                        Logger.WriteLog(message: $"Unable to access/create {jsonFile}, Error: {ex.Message}", type: "Error");
                        Environment.Exit(1);
                    }
                }

                // create a new instance of LunaJson
                LunaJson lunaJson = new();

                // create a new instance of ProxyPeers
                ProxyPeers proxyPeers = new();

                // Specify the wg-config directory path
                string directoryPath = "/app/wg/config";

                // Get a list of directories that match the pattern "peerX"
                List<string> peerDirectories = Directory.GetDirectories(directoryPath)
                    .Where(dir => Path.GetFileName(dir).StartsWith("peer"))
                    .ToList();

                // iterate the list
                foreach (string directory in peerDirectories)
                {
                    // Output the names of the peer directories to log
                    Logger.WriteLog(message: $"Found peer: {directoryPath}{directory}", type: "Debug");

                    // Extract the numeric part from the directory name
                    if (int.TryParse(Path.GetFileName(directory).Substring("peer".Length), out int peerNumber))
                    {
                        switch (peerNumber)
                        {
                            case 1:
                                // Code for X = 1
                                string mainBody1 = $"Mapped peer{peerNumber} with X={peerNumber}";
                                Logger.WriteLog(message: mainBody1, type: "Debug");
                                // read the contents of peerX
                                proxyPeers.Peer1Conf = File.ReadAllText(Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.conf"));
                                proxyPeers.Peer1Png = Png2B64(filePath: Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.png"));
                                break;
                            case 2:
                                // Code for X = 2
                                string mainBody2 = $"Mapped peer{peerNumber} with X={peerNumber}";
                                Logger.WriteLog(message: mainBody2, type: "Debug");
                                // read the contents of peerX
                                proxyPeers.Peer2Conf = File.ReadAllText(Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.conf"));
                                proxyPeers.Peer2Png = Png2B64(filePath: Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.png"));
                                break;
                            case 3:
                                // Code for X = 3
                                string mainBody3 = $"Mapped peer{peerNumber} with X={peerNumber}";
                                Logger.WriteLog(message: mainBody3, type: "Debug");
                                // read the contents of peerX
                                proxyPeers.Peer3Conf = File.ReadAllText(Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.conf"));
                                proxyPeers.Peer3Png = Png2B64(filePath: Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.png"));
                                break;
                            case 4:
                                // Code for X = 4
                                string mainBody4 = $"Mapped peer{peerNumber} with X={peerNumber}";
                                Logger.WriteLog(message: mainBody4, type: "Debug");
                                // read the contents of peerX
                                proxyPeers.Peer4Conf = File.ReadAllText(Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.conf"));
                                proxyPeers.Peer4Png = Png2B64(filePath: Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.png"));
                                break;
                            case 5:
                                // Code for X = 5
                                string mainBody5 = $"Mapped peer{peerNumber} with X={peerNumber}";
                                Logger.WriteLog(message: mainBody5, type: "Debug");
                                // read the contents of peerX
                                proxyPeers.Peer5Conf = File.ReadAllText(Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.conf"));
                                proxyPeers.Peer5Png = Png2B64(filePath: Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.png"));
                                break;
                            case 6:
                                // Code for X = 6
                                string mainBody6 = $"Mapped peer{peerNumber} with X={peerNumber}";
                                Logger.WriteLog(message: mainBody6, type: "Debug");
                                // read the contents of peerX
                                proxyPeers.Peer6Conf = File.ReadAllText(Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.conf"));
                                proxyPeers.Peer6Png = Png2B64(filePath: Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.png"));
                                break;
                            case 7:
                                // Code for X = 7
                                string mainBody7 = $"Mapped peer{peerNumber} with X={peerNumber}";
                                Logger.WriteLog(message: mainBody7, type: "Debug");
                                // read the contents of peerX
                                proxyPeers.Peer7Conf = File.ReadAllText(Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.conf"));
                                proxyPeers.Peer7Png = Png2B64(filePath: Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.png"));
                                break;
                            case 8:
                                // Code for X = 8
                                string mainBody8 = $"Mapped peer{peerNumber} with X={peerNumber}";
                                Logger.WriteLog(message: mainBody8, type: "Debug");
                                // read the contents of peerX
                                proxyPeers.Peer8Conf = File.ReadAllText(Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.conf"));
                                proxyPeers.Peer8Png = Png2B64(filePath: Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.png"));
                                break;
                            case 9:
                                // Code for X = 9
                                string mainBody9 = $"Mapped peer{peerNumber} with X={peerNumber}";
                                Logger.WriteLog(message: mainBody9, type: "Debug");
                                // read the contents of peerX
                                proxyPeers.Peer9Conf = File.ReadAllText(Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.conf"));
                                proxyPeers.Peer9Png = Png2B64(filePath: Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.png"));
                                break;
                            case 10:
                                // Code for X = 10
                                string mainBody10 = $"Mapped peer{peerNumber} with X={peerNumber}";
                                Logger.WriteLog(message: mainBody10, type: "Debug");
                                // read the contents of peerX
                                proxyPeers.Peer10Conf = File.ReadAllText(Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.conf"));
                                proxyPeers.Peer10Png = Png2B64(filePath: Path.Combine(directoryPath, $"peer{peerNumber}", $"peer{peerNumber}.png"));
                                break;
                            default:
                                // Code for other cases (if any)
                                Logger.WriteLog(message: $"Unknown peer{peerNumber}", type: "Error");
                                break;
                        }
                    }
                }

                Logger.WriteLog(message: "Foreach loop complete", type: "Debug");

                // append proxyPeers to lunaJson object
                lunaJson.ProxyPeers = proxyPeers;
                Logger.WriteLog(message: "proxyPeers updated", type: "Debug");


                // get server type
                string serverType = "/app/lunavpn/server.type";
                if (File.Exists(serverType))
                {
                    lunaJson.ServerType = File.ReadAllText(serverType);
                    Logger.WriteLog(message: "server.type captured", type: "Debug");
                }
                else
                {
                    lunaJson.ServerType = "UNKNOWN";
                    Logger.WriteLog(message: $"Unable to find '{serverType}'", type: "Error");
                }

                // get server UUID
                string serverUUID = "/app/lunavpn/server.uuid";
                if (File.Exists(serverUUID))
                {
                    lunaJson.ServerUUID = File.ReadAllText(serverUUID);
                    Logger.WriteLog(message: "server.uuid captured", type: "Debug");
                }
                else
                {
                    lunaJson.ServerUUID = "UNKNOWN";
                    Logger.WriteLog(message: $"Unable to find '{serverUUID}'", type: "Error");
                }

                // get IPv4 and IPv6 addresses
                lunaJson.IPv4 = await GetPublicIPv4Async();
                lunaJson.IPv6 = await GetPublicIPv6Async();
                Logger.WriteLog(message: $"IPv4: {lunaJson.IPv4}", type: "Debug");
                Logger.WriteLog(message: $"IPv6: {lunaJson.IPv6}", type: "Debug");

                // write output to data.json file
                WriteToJsonFile(lunaJson: lunaJson, filePath: jsonFile);
                Logger.WriteLog(message: $"Wrote lunaJson to {jsonFile}", type: "Debug");
                return 0; // Return 0 on success
            }
            catch (Exception ex)
            {
                Logger.WriteLog(message: $"An unexpected error occurred: {ex.Message}", type: "Error");
                return 1; // Return 1 on error
            }
            
        }
    
        private static string Png2B64(string filePath)
        {
            try
            {
                // Read the PNG file into a byte array
                byte[] imageBytes = File.ReadAllBytes(filePath);

                // Convert the byte array to a base64 string
                string base64String = Convert.ToBase64String(imageBytes);

                return base64String;
            }
            catch (IOException e)
            {
                // Handle IO exceptions, e.g., if the file does not exist
                Logger.WriteLog(message: $"Error reading the file: {e.Message}", type: "Error");
                return string.Empty;
            }
        }
    
        private static async Task<string> GetPublicIPv4Async()
        {
            return await GetPublicIpAddressAsync("https://api.ipify.org?format=json", "ip");
        }

        private static async Task<string> GetPublicIPv6Async()
        {
            return await GetPublicIpAddressAsync("https://api6.ipify.org?format=json", "ip");
        }

        // private static string GetPublicIPv6()
        // {
        //     return GetPublicIpAddress("https://api6.ipify.org?format=json", "ip");
        // }

        // private static string GetPublicIPv4()
        // {
        //     return GetPublicIpAddress("https://api.ipify.org?format=json", "ip");
        // }


        private static async Task<string> GetPublicIpAddressAsync(string apiUrl, string ipAddressField)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string response = await httpClient.GetStringAsync(apiUrl);
                    using (JsonDocument jsonDocument = JsonDocument.Parse(response))
                    {
                        JsonElement root = jsonDocument.RootElement;
                        return root.TryGetProperty(ipAddressField, out JsonElement ipElement) ? ipElement.ToString() : "NODATA";
                    }
                }
                catch (Exception e)
                {
                    Logger.WriteLog(message: $"Unable to get IP address Error: {e.Message}", type: "Error");
                    return "NODATA";
                }
            }
        }

        // private static string GetPublicIpAddress(string apiUrl, string ipAddressField)
        // {
        //     using (HttpClient httpClient = new HttpClient())
        //     {
        //         try
        //         {
        //             string response = httpClient.GetStringAsync(apiUrl).Result;

        //             using (JsonDocument jsonDocument = JsonDocument.Parse(response))
        //             {
        //                 JsonElement root = jsonDocument.RootElement;
        //                 return root.TryGetProperty(ipAddressField, out JsonElement ipElement) ? ipElement.ToString() : "NODATA";
        //             }
        //         }
        //         catch (Exception e)
        //         {
        //             Logger.WriteLog(message: $"Unable to get IP address. Error: {e.Message}", type: "Error");
        //             return "NODATA";
        //         }
        //     }
        // }

        static void WriteToJsonFile(LunaJson lunaJson, string filePath)
        {
            try
            {
                // Serialize the LunaJson object to a JSON-formatted string
                string jsonString = JsonSerializer.Serialize(lunaJson, new JsonSerializerOptions { WriteIndented = true });

                // Write the JSON string to the specified file
                File.WriteAllText(filePath, jsonString);

                Logger.WriteLog(message: $"Object written to {filePath} successfully.", type: "Debug");
            }
            catch (Exception e)
            {
                Logger.WriteLog(message: $" Unable to write {filePath}, Error: {e.Message}", type: "Error");
            }
        }
    }
}

