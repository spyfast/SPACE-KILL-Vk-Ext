using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;

namespace SpaceKill_Kill
{
	internal static class VkCaptchaWorks
	{
		public static void SetKeyAndProv(CaptchaWorksProvder prov, string key)
		{
			if (prov == CaptchaWorksProvder.rucaptcha)
			{
				RCC = new CaptchaClient("https://rucaptcha.com", key);
			}
			else
			{
				RCC = new CaptchaClient("https://anti-captcha.com", key);
			}
		}
		public static string GetBalance()
		{
			string result;
			if (RCC != null)
			{
				result = RCC.GetBalance().ToString();
			}
			else
			{
				result = "?";
			}
			return result;
		}

		public static string Solve(string url, string id)
		{
			new WebClient().DownloadFile(url, id + ".png");
			string captchaId = "";
			try
			{
				captchaId = RCC.UploadCaptchaFile(id + ".png");
			}
			finally
			{
				File.Delete(id + ".png");
			}
			string text = null;
			while (string.IsNullOrEmpty(text))
			{
				Thread.Sleep(1000);
				try
				{
					text = RCC.GetCaptcha(captchaId);
				}
				catch (Exception ex)
				{
					if (!ex.Message.Contains("CAPCHA_NOT_READY"))
					{
						Log.Push("[Ошибка обработки captcha]: " + ex.Message);
					}
				}
			}
			Log.Push("[captcha]: распознавание завершено");
			return text;
		}

		public static void RegisterManual(string key, string ans)
		{
			answs.Add(key, ans);
		}

		public static string SolveManual(string url, string id)
		{
			new WebClient().DownloadFile(url, id + ".png");
			toSolve.Enqueue(id);
			while (!answs.ContainsKey(id))
			{
				Thread.Sleep(1000);
			}
			string result = answs[id];
			answs.Remove(id);
			return result;
		}

		private static CaptchaClient RCC = null;

		public static bool Enabled = false;

		public static Queue<string> toSolve = new Queue<string>();

		private static Dictionary<string, string> answs = new Dictionary<string, string>();
	}
}
