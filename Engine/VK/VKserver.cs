using System;
using System.Threading;

namespace SpaceKill_Kill
{
	internal static class VKserver
	{
		public static string APIRequest(string method, string param, string token, string captcha_data = "")
		{
			if (captcha_data == "")
			{
				param = Uri.EscapeDataString(param);
				param = param.Replace("%3D", "=").Replace("%26", "&");
			}
            
			string text;
            int randomId;
			while (true)
			{
                Random rnd = new Random();
                randomId = rnd.Next(100000, 1000000000);
                text = Network.GET(string.Concat(new string[]
                {
                    "https://api.vk.com/method/",
                    method,
                    "?",
                    param,
                    "&access_token=",
                    token,
                    captcha_data,
                    "&v=5.92",
                    "&random_id=",
                    randomId.ToString()

                }), null);
				if (!text.Contains("\"error_code\":6"))
				{
					break;
				}
				Thread.Sleep(333);
			}
			if (text.Contains("\"error_code\":14"))
			{
				string between = StrWrk.GetBetween(text, "\"captcha_sid\":\"", "\"");
				string url = StrWrk.GetBetween(text, "\"captcha_img\":\"", "\"").Replace("\\", "");
				string str = "";
				if (VkCaptchaWorks.Enabled)
				{
					Log.Push("[captcha]: обработка капчи");
					try
					{
						str = VkCaptchaWorks.Solve(url, between);
					}
					catch (RuCaptchaException ex)
					{
						Log.Push("[Ошибка обработки captcha]: " + ex.Message);
					}
					return APIRequest(method, param, token, "&captcha_sid=" + between + "&captcha_key=" + str);
				}
				Log.Push("[captcha]: изображение поставлено в очередь на ручной ввод");
				str = VkCaptchaWorks.SolveManual(url, between);
				return APIRequest(method, param, token, "&captcha_sid=" + between + "&captcha_key=" + str);
			}
			else
			{
				if (text.Contains("\"error_code\""))
				{
					throw new Exception(StrWrk.GetBetween(text, "\"error_msg\":\"", "\""));
				}
				return text;
			}
		}
	}
}
