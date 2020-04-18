using System;
using System.IO;
using Newtonsoft.Json;

namespace SpaceKill_Kill.Configs
{
	internal sealed class TyperConfig : ISBConfig
	{
		public TyperConfig()
		{
			this.TypingDelay = 100;
			this.SendingDelay = 1000;
			this.Name = "";
			this.NamePlacement = 0;
		}
		public void Save()
		{
			File.WriteAllText("Configs\\typerConfig.json", JsonConvert.SerializeObject(this));
		}
		public int TypingDelay;
		public int SendingDelay;
		public string Name;
		public int NamePlacement;
	}
}
