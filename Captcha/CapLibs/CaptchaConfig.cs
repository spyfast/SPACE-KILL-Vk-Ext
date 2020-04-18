using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace SpaceKill_Kill
{
	public class CaptchaConfig
	{
		public Dictionary<string, string> Parameters
		{
			get
			{
				return parameters;
			}
		}
		public NameValueCollection GetParameters()
		{
			NameValueCollection nameValueCollection = new NameValueCollection();
			foreach (KeyValuePair<string, string> current in parameters)
			{
				nameValueCollection.Add(current.Key, current.Value);
			}
			return nameValueCollection;
		}

		public CaptchaConfig()
		{
			parameters = new Dictionary<string, string>();
		}

		public CaptchaConfig SetIsPhrase(bool value)
		{
			parameters["phrase"] = (value ? "1" : "0");
			return this;
		}

		public CaptchaConfig SetRegisterSensitive(bool value)
		{
			parameters["regsense"] = (value ? "1" : "0");
			return this;
		}
		public CaptchaConfig SetNeedCalc(bool value)
		{
			parameters["calc"] = (value ? "1" : "0");
			return this;
		}
		public CaptchaConfig SetCharType(CaptchaCharTypeEnum value)
		{
			if (value == CaptchaCharTypeEnum.Default)
			{
				parameters.Remove("numeric");
			}
			else
			{
				Dictionary<string, string> dictionary = parameters;
				string key = "numeric";
				int num = (int)value;
				dictionary[key] = num.ToString();
			}
			return this;
		}

		public CaptchaConfig SetMinLen(int? minLen)
		{
			if (minLen.HasValue)
			{
				if (minLen.Value < 1 || minLen > 20)
				{
					throw new ArgumentOutOfRangeException("minLen", minLen.Value, "Количество знаков в отчете может быть в диапазоне от 1 до 20 символов.");
				}
				parameters["min_len"] = minLen.Value.ToString();
			}
			else
			{
				parameters.Remove("min_len");
			}
			return this;
		}

		public CaptchaConfig SetMaxLen(int? maxLen)
		{
			if (maxLen.HasValue)
			{
				if (maxLen.Value < 1 || maxLen > 20)
				{
					throw new ArgumentOutOfRangeException("maxLen", maxLen.Value, "Количество знаков в отчете может быть в диапазоне от 1 до 20 символов.");
				}
				parameters["max_len"] = maxLen.Value.ToString();
			}
			else
			{
				parameters.Remove("max_len");
			}
			return this;
		}

		public CaptchaConfig SetLanguage(CaptchaLanguageEnum lang)
		{
			if (lang == CaptchaLanguageEnum.Default)
			{
				parameters.Remove("language");
			}
			else
			{
				Dictionary<string, string> dictionary = parameters;
				string key = "language";
				int num = (int)lang;
				dictionary[key] = num.ToString();
			}
			return this;
		}

		public CaptchaConfig SetSoftId(string softId)
		{
			parameters["soft_id"] = softId;
			return this;
		}

		private Dictionary<string, string> parameters;
	}
}
