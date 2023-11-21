using System.Text;
using lvfucs.Core.Models;
using lvfucs.Core.Utilities.Converter;

namespace lvfucs.Core.Utilities.Producer
{
    public class GenProd
    {
        /// <summary>
        /// Generates a ProxyPeers object by encoding the specified PNG and CONF files
        /// for each matched peerX in the given directory.
        /// </summary>
        /// <param name="wgPeersIn">The base directory containing peerX folders.</param>
        /// <param name="peerNamesIn">A list of peerX folder names to process.</param>
        /// <returns>A ProxyPeers object with encoded PNG and CONF files.</returns>
        public static ProxyPeers GenerateProxyPeers(string wgPeersIn, List<string> peerNamesIn)
        {
            ProxyPeers proxyPeers = new ProxyPeers();

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

        /// <summary>
        /// Reads Squid credentials from the specified file path and creates a SquidCreds object.
        /// </summary>
        /// <param name="squidCredsFilePathIn">The file path containing Squid credentials.</param>
        /// <returns>A SquidCreds object with the parsed credentials.</returns>
        public static SquidCreds ReadSquidCredentials(string squidCredsFilePathIn)
        {
            SquidCreds squidCreds = new SquidCreds();

            if (File.Exists(squidCredsFilePathIn))
            {
                try
                {
                    using (StreamReader fileStream = new StreamReader(squidCredsFilePathIn))
                    {
                        string? fileContent = fileStream.ReadLine();
                        if (fileContent != null)
                        {
                            string[] credentials = fileContent.Split(':');
                            squidCreds.SquidUser = credentials.Length > 0 ? credentials[0] : string.Empty;
                            squidCreds.SquidPass = credentials.Length > 1 ? credentials[1] : string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading {squidCredsFilePathIn}: {ex.Message}");
                }
            }

            return squidCreds;
        }

        /// <summary>
        /// Populates a given list of words with a predefined set of dictionary words.
        /// </summary>
        /// <param name="words">The list of words to be populated.</param>
        private static void GenerateDictionary(List<string> words)
        {
            words.Add("apple");
            words.Add("banana");
            words.Add("orange");
            words.Add("chocolate");
            words.Add("elephant");
            words.Add("giraffe");
            words.Add("sunflower");
            words.Add("mountain");
            words.Add("ocean");
            words.Add("coffee");
            words.Add("rainbow");
            words.Add("butterfly");
            words.Add("guitar");
            words.Add("diamond");
            words.Add("firefly");
            words.Add("waterfall");
            words.Add("whisper");
            words.Add("harmony");
            words.Add("serenity");
            words.Add("laughter");
            words.Add("puzzle");
            words.Add("sunset");
            words.Add("umbrella");
            words.Add("vibrant");
            words.Add("silhouette");
            words.Add("lighthouse");
            words.Add("illusion");
            words.Add("tranquil");
            words.Add("whimsical");
            words.Add("enchanted");
            words.Add("celestial");
            words.Add("harmonious");
            words.Add("effervescent");
            words.Add("mystical");
            words.Add("nostalgic");
            words.Add("ephemeral");
            words.Add("lullaby");
            words.Add("radiance");
            words.Add("sapphire");
            words.Add("paradoxer");
            words.Add("divineress");
            words.Add("spheges");
            words.Add("longitudes");
            words.Add("snootier");
            words.Add("blushless");
            words.Add("reactivate");
            words.Add("prelatish");
            words.Add("crownets");
            words.Add("prealtar");
            words.Add("sheepherding");
            words.Add("insight");
            words.Add("corruptest");
            words.Add("crookedness");
            words.Add("magisterial");
            words.Add("isomenthone");
            words.Add("ammonical");
            words.Add("hellishness");
            words.Add("iwflower");
            words.Add("ovigerous");
            words.Add("autonoetic");
            words.Add("nonmanual");
            words.Add("unseparably");
            words.Add("damasks");
            words.Add("unmeedful");
            words.Add("outstank");
            words.Add("eleomargaric");
            words.Add("reflections");
            words.Add("idocrase");
            words.Add("domiciliar");
            words.Add("warkloom");
            words.Add("snipjack");
            words.Add("graphic");
            words.Add("composer");
            words.Add("moratorium");
            words.Add("transoceanic");
            words.Add("asynergia");
            words.Add("cytotaxonomy");
            words.Add("minibusses");
            words.Add("smellier");
            words.Add("floodlighted");
            words.Add("preplace");
            words.Add("ayatollahs");
            words.Add("saveable");
            words.Add("unsketchable");
            words.Add("rampish");
            words.Add("analogue");
            words.Add("flyaway");
            words.Add("downfeed");
            words.Add("janders");
            words.Add("moaning");
            words.Add("bandoleered");
            words.Add("nephridium");
            words.Add("castlery");
            words.Add("deammonation");
            words.Add("regreen");
            words.Add("cephalopod");
            words.Add("triquetrum");
            words.Add("humeral");
            words.Add("phaenomenism");
            words.Add("chalcone");
            words.Add("clerkery");
            words.Add("sapanwood");
            words.Add("bandeaux");
            words.Add("elementality");
            words.Add("disarrange");
            words.Add("undergarnish");
            words.Add("venomization");
            words.Add("ytterbic");
            words.Add("unchristened");
            words.Add("renvois");
            words.Add("overempired");
            words.Add("sawmill");
            words.Add("subsplenial");
            words.Add("behemoth");
            words.Add("redamaged");
            words.Add("sojourned");
            words.Add("gushier");
            words.Add("disagio");
            words.Add("premenacing");
            words.Add("farcical");
            words.Add("aortolith");
            words.Add("pilulist");
            words.Add("altitudinous");
            words.Add("exterminated");
            words.Add("feminities");
            words.Add("hydroforming");
            words.Add("disdeify");
            words.Add("taxables");
            words.Add("atheticize");
            words.Add("proteolysis");
            words.Add("canines");
            words.Add("potfuls");
            words.Add("brevicaudate");
            words.Add("visiters");
            words.Add("sacking");
            words.Add("wonderers");
            words.Add("praepositor");
            words.Add("cauliflower");
            words.Add("reverences");
            words.Add("fructokinase");
            words.Add("evections");
            words.Add("heartwoods");
            words.Add("spithame");
            words.Add("coalsheds");
            words.Add("shmears");
            words.Add("iodizing");
            words.Add("chorionic");
            words.Add("histologic");
            words.Add("czarinas");
            words.Add("ochrocarpous");
            words.Add("polyadic");
            words.Add("bromoaurates");
            words.Add("readdressing");
            words.Add("savingness");
            words.Add("circumfer");
            words.Add("toilfully");
            words.Add("monocable");
            words.Add("abaxile");
            words.Add("subcrenate");
        }

        /// <summary>
        /// C# random generator
        /// </summary>
        private static readonly Random random = new Random();

        /// <summary>
        /// Generates a random username by combining two words from a predefined dictionary,
        /// capitalizing the first letter of the first word, and appending a random digit to the second word.
        /// </summary>
        /// <returns>A randomly generated username.</returns>
        public static string GenerateUsername()
        {
            // Create a list to store dictionary words
            List<string> words = new List<string>();

            // Populate the list with dictionary words
            GenerateDictionary(words);

            // Randomly select two words from the dictionary
            string word1 = words[random.Next(words.Count)];
            string word2 = words[random.Next(words.Count)];

            // Capitalize the first letter of the first word
            word1 = char.ToUpper(word1[0]) + word1.Substring(1);

            // Append a random digit to the second word
            word2 += random.Next(10);

            // Combine the words to form the username
            string username = $"{word1}-{word2}";
            return username;
        }

        /// <summary>
        /// Generates a random password consisting of 14 characters chosen from a predefined character set.
        /// </summary>
        /// <returns>A randomly generated password.</returns>
        public static string GeneratePassword()
        {
            // Character set for the password
            const string charset = "ABCDEFGHKMNPQRSTWXYZabcdefghjkmnpqrstwxyz23456789";

            // StringBuilder to build the password
            StringBuilder password = new StringBuilder();

            // Random object for generating random indices
            Random random = new Random();

            // Generate a 14-character alphanumeric password
            for (int i = 0; i < 14; ++i)
            {
                password.Append(charset[random.Next(charset.Length)]);
            }

            return password.ToString();
        }

        /// <summary>
        /// Checks if the input string consists of alphanumeric characters and hyphens only.
        /// </summary>
        /// <param name="input">The input string to be checked.</param>
        /// <returns>True if the input is composed of alphanumeric characters and hyphens only; otherwise, false.</returns>
        public static bool IsSafeInput(string input)
        {
            return input.All(c => char.IsLetterOrDigit(c) || c == '-');
        }

    }
}

