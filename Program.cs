using System;
using System.Windows.Forms;

namespace SpaceKill_Kill
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth());
		}
	}
}
