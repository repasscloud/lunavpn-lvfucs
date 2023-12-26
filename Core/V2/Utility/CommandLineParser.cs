using lvfucs.Core.V2.Models;

namespace lvfucs.Core.V2.Utility
{
	public class CommandLineParser
	{
		public static CommandLineOptions ParseArguments(string[] args)
		{
			var options = new CommandLineOptions();

			for (int i = 0; i < args.Length; i++)
			{
				switch (args[i])
				{
					case "--save-file":
						if (i + 1 < args.Length) options.SaveFile = args[++i];
						break;
					case "--data-file":
						if (i + 1 < args.Length) options.DataFile = args[++i];
						break;

					case "--api-endpoint":
						if (i + 1 < args.Length) options.ApiEndpoint = args[++i];
						break;

					case "--bearer-token":
                        if (i + 1 < args.Length) options.BearerToken = args[++i];
						break;
				}
			}

			return options;
		}
	}
}

