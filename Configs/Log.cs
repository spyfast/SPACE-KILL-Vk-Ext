using System;
using System.Collections.Generic;

namespace SpaceKill_Kill
{
    internal static class Log
    {

        public static Queue<string> toPush = new Queue<string>();

        public static bool enabled = true;
        public static void Push(string s)
        {
            if (!enabled)
                toPush.Enqueue($"[{DateTime.Now.ToShortTimeString()}]:" + " " + s);
        }
	}
}
