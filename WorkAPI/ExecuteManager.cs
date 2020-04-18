using System.Collections.Generic;

namespace SpaceKill_Kill
{
	internal class ExecuteManager
	{
		private string token;

		private List<string> execs;
		public ExecuteManager(string token)
		{
			this.token = token;
			execs = new List<string>();
		}

		public void Add(string command)
		{
			execs.Add(command);
			if (execs.Count == 25)
				ForceExecute();
		}

		public void Execute()
		{
			if (execs.Count != 0)
				ForceExecute();
		}

		private void ForceExecute()
		{
			string text = "code=";
			foreach (string current in execs)
			{
				text += current;
			}
			text += "return 0;";
			VKserver.APIRequest("execute", text, token, "");
			execs.Clear();
		}
	}
}
