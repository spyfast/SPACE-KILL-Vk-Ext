using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace SpaceKill_Kill
{
	public class CaptchaClient
	{
		public CaptchaClient(string host, string api_key)
		{
			this.api_key = api_key;
			this.host = host;
			if (errors == null)
			{
				errors = new Dictionary<string, string>();
				errors.Add("CAPCHA_NOT_READY", "Капча в работе, ещё не расшифрована, необходимо повтороить запрос через несколько секунд.");
				errors.Add("ERROR_WRONG_ID_FORMAT", "Неверный формат ID капчи. ID должен содержать только цифры.");
				errors.Add("ERROR_WRONG_CAPTCHA_ID", "Неверное значение ID капчи.");
				errors.Add("ERROR_CAPTCHA_UNSOLVABLE", "Капчу не смогли разгадать 3 разных работника. Средства за эту капчу не списываются.");
				errors.Add("ERROR_WRONG_USER_KEY", "Неверный формат параметра key, должно быть 32 символа.");
				errors.Add("ERROR_KEY_DOES_NOT_EXIST", "Использован несуществующий key.");
				errors.Add("ERROR_ZERO_BALANCE", "Баланс Вашего аккаунта нулевой.");
				errors.Add("ERROR_NO_SLOT_AVAILABLE", "Текущая ставка распознования выше, чем максимально установленная в настройках Вашего аккаунта.");
				errors.Add("ERROR_ZERO_CAPTCHA_FILESIZE", "Размер капчи меньше 100 Байт.");
				errors.Add("ERROR_TOO_BIG_CAPTCHA_FILESIZE", "Размер капчи более 100 КБайт.");
				errors.Add("ERROR_WRONG_FILE_EXTENSION", "Ваша капча имеет неверное расширение, допустимые расширения jpg,jpeg,gif,png.");
				errors.Add("ERROR_IMAGE_TYPE_NOT_SUPPORTED", "Сервер не может определить тип файла капчи.");
				errors.Add("ERROR_IP_NOT_ALLOWED", "В Вашем аккаунте настроено ограничения по IP с которых можно делать запросы. И IP, с которого пришёл данный запрос не входит в список разрешённых.");
			}
		}

		public string GetCaptcha(string captchaId)
		{
			string url = string.Format("{0}/res.php?key={1}&action=get&id={2}", this.host, this.api_key, captchaId);
			return MakeGetRequest(url);
		}

		public string UploadCaptchaFile(string fileName)
		{
			return UploadCaptchaFile(fileName, null);
		}
		public string UploadCaptchaFile(string fileName, CaptchaConfig config)
		{
			string requestUriString = string.Format("{0}/in.php", this.host);
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("key", this.api_key);
			bool flag = config != null;
			bool flag2 = flag;
			if (flag2)
			{
				nameValueCollection.Add(config.GetParameters());
			}
			string str = "---------------------------" + DateTime.Now.Ticks.ToString("x");
			byte[] bytes = Encoding.ASCII.GetBytes("\r\n--" + str + "\r\n");
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			httpWebRequest.ContentType = "multipart/form-data; boundary=" + str;
			httpWebRequest.Method = "POST";
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
			Stream requestStream = httpWebRequest.GetRequestStream();
			string format = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
			foreach (object current in nameValueCollection.Keys)
			{
				string text = (string)current;
				requestStream.Write(bytes, 0, bytes.Length);
				string s = string.Format(format, text, nameValueCollection[text]);
				byte[] bytes2 = Encoding.UTF8.GetBytes(s);
				requestStream.Write(bytes2, 0, bytes2.Length);
			}
			requestStream.Write(bytes, 0, bytes.Length);
			string s2 = string.Format("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n", "file", fileName, "image/jpeg");
			byte[] bytes3 = Encoding.UTF8.GetBytes(s2);
			requestStream.Write(bytes3, 0, bytes3.Length);
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			byte[] array = new byte[4096];
			int count;
			while ((count = fileStream.Read(array, 0, array.Length)) != 0)
			{
				requestStream.Write(array, 0, count);
			}
			fileStream.Close();
			byte[] bytes4 = Encoding.ASCII.GetBytes("\r\n--" + str + "--\r\n");
			requestStream.Write(bytes4, 0, bytes4.Length);
			requestStream.Close();
			string result;
			using (WebResponse response = httpWebRequest.GetResponse())
			{
				StreamReader streamReader = new StreamReader(response.GetResponseStream());
				result = this.ParseAnswer(streamReader.ReadToEnd());
			}
			return result;
		}

		public decimal GetBalance()
		{
			string url = string.Format("{0}/res.php?key={1}&action=getbalance", this.host, this.api_key);
			return decimal.Parse(this.MakeGetRequest(url), CultureInfo.InvariantCulture.NumberFormat);
		}

		private string MakeGetRequest(string url)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.Method = "GET";
			string serviceAnswer = "";
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				serviceAnswer = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
			}
			return ParseAnswer(serviceAnswer);
		}
		private string ParseAnswer(string serviceAnswer)
		{
			if (errors.Keys.Contains(serviceAnswer))
			{
				throw new RuCaptchaException(string.Format("{0} ({1})", errors[serviceAnswer], serviceAnswer));
			}
			string result;
			if (serviceAnswer.StartsWith("OK|"))
			{
				result = serviceAnswer.Substring(3);
			}
			else
			{
				result = serviceAnswer;
			}
			return result;
		}

		private readonly string api_key;

		private readonly string host = "http://rucaptcha.com";

		private static Dictionary<string, string> errors;
	}
}
