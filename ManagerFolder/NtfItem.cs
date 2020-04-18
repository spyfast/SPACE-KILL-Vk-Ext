using System;

namespace SpaceKill_Kill
{
	public class NtfItem
	{
		private static int unixTimestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

		public string type;

		public string date;

		public NtfParent parent;

		public NtfFeedback feedback;
		public DateTime time
		{
			get
			{
				return new DateTime(long.Parse(this.date) + (long)NtfItem.unixTimestamp);
			}
		}
	}
}
