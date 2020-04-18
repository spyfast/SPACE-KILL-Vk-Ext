using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace SpaceKill_Kill
{
	internal static class Network
	{
		public static string GET(string link, CookieContainer cc = null)
		{
			string result;
			while (true)
			{
				try
				{
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
					if (cc != null)
					{
						httpWebRequest.CookieContainer = cc;
					}
					result = new StreamReader(httpWebRequest.GetResponse().GetResponseStream()).ReadToEnd();
				}
				catch (Exception ex)
				{
					Log.Push("[Ошибка уровня сети, повтор попытки]: " + ex.Message);
					Thread.Sleep(2000);
					continue;
				}
				break;
			}
			return result;
		}

		public static string GET(string link, out string Location, CookieContainer cc = null)
		{
			string result;
			while (true)
			{
				try
				{
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
					if (cc != null)
					{
						httpWebRequest.CookieContainer = cc;
					}
					httpWebRequest.AllowAutoRedirect = false;
					HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					Location = httpWebResponse.Headers.Get("location");
					result = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
				}
				catch (Exception ex)
				{
					Log.Push("[Ошибка уровня сети, повтор попытки]: " + ex.Message);
					Thread.Sleep(2000);
					continue;
				}
				break;
			}
			return result;
		}

		public static string POST(string url, string Data, CookieContainer cc = null)
		{
			string result;
			while (true)
			{
				try
				{
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
					httpWebRequest.Method = "POST";
					if (cc != null)
					{
						httpWebRequest.CookieContainer = cc;
					}
					httpWebRequest.Timeout = 100000;
					httpWebRequest.AllowAutoRedirect = true;
					httpWebRequest.ContentType = "application/x-www-form-urlencoded";
					httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.61 Safari/537.36";
					byte[] bytes = Encoding.UTF8.GetBytes(Data);
					httpWebRequest.ContentLength = (long)bytes.Length;
					Stream requestStream = httpWebRequest.GetRequestStream();
					requestStream.Write(bytes, 0, bytes.Length);
					requestStream.Close();
					TextReader textReader = new StreamReader(httpWebRequest.GetResponse().GetResponseStream(), Encoding.UTF8);
					bool flag3 = cc != null;
					bool flag4 = flag3;
					if (flag4)
					{
						cc = httpWebRequest.CookieContainer;
					}
					result = textReader.ReadToEnd();
				}
				catch (Exception ex)
				{
					Log.Push("[Ошибка уровня сети, повтор попытки]: " + ex.Message);
					Thread.Sleep(2000);
					continue;
				}
				break;
			}
			return result;
		}

		public static string HttpUploadFile(string url, string file, string paramName, string contentType)
		{
			Log.Push(string.Format("Загрузка {0} -> {1}", file, url));
			string str = "---------------------------" + DateTime.Now.Ticks.ToString("x");
			byte[] bytes = Encoding.ASCII.GetBytes("\r\n--" + str + "\r\n");
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.ContentType = "multipart/form-data; boundary=" + str;
			httpWebRequest.Method = "POST";
			httpWebRequest.KeepAlive = true;
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.61 Safari/537.36";
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			string s = string.Format("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n", paramName, file, contentType);
			byte[] bytes2 = Encoding.UTF8.GetBytes(s);
			requestStream.Write(bytes2, 0, bytes2.Length);
			FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
			byte[] array = new byte[4096];
			int count;
			while ((count = fileStream.Read(array, 0, array.Length)) != 0)
			{
				requestStream.Write(array, 0, count);
			}
			fileStream.Close();
			byte[] bytes3 = Encoding.ASCII.GetBytes("\r\n--" + str + "--\r\n");
			requestStream.Write(bytes3, 0, bytes3.Length);
			requestStream.Close();
			WebResponse webResponse = null;
			string result;
			try
			{
				webResponse = httpWebRequest.GetResponse();
				result = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
			}
			catch (Exception ex)
			{
				Log.Push("Ошибка загрузки файла: " + ex.Message);
				if (webResponse != null)
				{
					webResponse.Close();
					webResponse = null;
				}
				webResponse = httpWebRequest.GetResponse();
				result = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
			}
			finally
			{
				httpWebRequest = null;
			}
			return result;
		}
	}
}
