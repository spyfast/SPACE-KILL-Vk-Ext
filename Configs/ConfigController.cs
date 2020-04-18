using System;
using System.IO;
using Newtonsoft.Json;

namespace SpaceKill_Kill.Configs
{
	internal static class ConfigController
	{
		public static void Load()
		{
			try
			{
				ConfigController.TyperConfig = JsonConvert.DeserializeObject<TyperConfig>(File.ReadAllText("Configs\\typerConfig.json"));
			}
			catch
			{
				ConfigController.TyperConfig = new TyperConfig();
			}
		}
		public static TyperConfig TyperConfig;
	}
}
