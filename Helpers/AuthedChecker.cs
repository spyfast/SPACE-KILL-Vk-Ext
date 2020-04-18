using System;
using System.IO;
using System.Security.Cryptography;

public class AuthedChecker
{
	public bool CheckFiles()
	{
		string b = "da5404d098b1fc3f40d8e473e9676656";
		string b2 = "77ff6f4da066fd54ec20777fbd9154fa";
		if (CalculateMD5Checksum(string.Format("{0}\\Authed.dll", Environment.CurrentDirectory)) == b)
		{

		}
		return CalculateMD5Checksum(string.Format("{0}\\jose-jwt.dll", Environment.CurrentDirectory)) == b2;
	}
	private string CalculateMD5Checksum(string _file)
	{
		string result;
		using (MD5 mD = MD5.Create())
		{
			using (FileStream fileStream = File.OpenRead(_file))
			{
				byte[] value = mD.ComputeHash(fileStream);
				result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
			}
		}
		return result;
	}
}
