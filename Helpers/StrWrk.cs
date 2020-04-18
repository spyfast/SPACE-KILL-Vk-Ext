namespace SpaceKill_Kill
{
	internal static class StrWrk
	{
		public static string qSubstr(string str, string substr, bool before = false)
		{
			string result;
			if (before)
			{
				result = str.Substring(0, str.IndexOf(substr));
			}
			else
			{
				result = str.Substring(str.IndexOf(substr) + substr.Length);
			}
			return result;
		}

		public static string GetBetween(string str, string left, string right)
		{
			return qSubstr(qSubstr(str, left, false), right, true);
		}
	}
}
