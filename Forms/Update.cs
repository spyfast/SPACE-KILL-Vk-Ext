using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace SpaceKill_Kill
{
	public partial class Update : MaterialForm
	{
		public bool Download()
		{
			return is_download;
		}
		public bool Skipped()
		{
			return is_skipped;
		}
		public Update()
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString(url_version);
			string str = webClient.DownloadString(name_program_linck);
			string location = Assembly.GetEntryAssembly().Location;
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(location);
			up_filename = str + ".rar";
			string[] commandLineArgs = Environment.GetCommandLineArgs();

			if (commandLineArgs.Length < 3)
				DoCheckUpdate();
			else
			{
				if (commandLineArgs[1].ToLower() == "/u")
				{
					DoCopeProgram(commandLineArgs[2]);
				}
				if (commandLineArgs[1].ToLower() == "/d")
				{
					DoDeleteOldProgram(commandLineArgs[2]);
				}
			}
		}
		private void Update_Load(object sender, EventArgs e)
		{
		}
		private void DoCheckUpdate()
		{
			string server_version = GetServerVersion();
			if (my_version == server_version)
			{
				is_download = false;
				is_skipped = true;
			}
			else
				DoDownloadUpdate();
		}
		private void DoDownloadUpdate()
		{
			InitializeComponent();
			DownloadFiles();
			is_download = true;
			is_skipped = false;
		}
		private void DownloadFiles()
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
				webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
				webClient.DownloadFileAsync(new Uri(url_program), up_filename);
			}
			catch (Exception ex)
			{
				Error(ex.Message + " " + up_filename);
			}
		}
		private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			progressBar1.Value = e.ProgressPercentage;
		}
		private void Completed(object sender, AsyncCompletedEventArgs e)
		{
			RunProgram(up_filename, "/u \"" + my_filename + "\"");
			Close();
		}
		private void RunProgram(string filename, string keys)
		{
			try
			{
				new Process
				{
					StartInfo = 
					{
						WorkingDirectory = Application.StartupPath,
						FileName = filename,
						Arguments = keys
					}
				}.Start();
			}
			catch (Exception ex)
			{
				Error(ex.Message + " " + filename);
			}
		}
		private void DoCopeProgram(string filename)
		{
			DeleteProgram(filename);
			try
			{
				File.Copy(my_filename, filename);
				RunProgram(filename, "/d \"" + my_filename + "\"");
				is_download = false;
				is_skipped = false;
			}
			catch (Exception ex)
			{
				Error(ex.Message + " " + filename);
			}
		}
		private void DoDeleteOldProgram(string filename)
		{
			DeleteProgram(filename);
			is_download = false;
			is_skipped = true;
		}
		private void DeleteProgram(string filename)
		{
			int num = 10;
			while (--num > 0 && File.Exists(filename))
			{
				try
				{
					File.Delete(filename);
				}
				catch
				{
					Thread.Sleep(200);
				}
			}
		}
		private string GetServerVersion()
		{
			string result;
			try
			{
				WebClient webClient = new WebClient();
				result = webClient.DownloadString(url_version).Trim();
			}
			catch
			{
				result = my_version;
			}
			return result;
		}
		private void Error(string message)
		{
			if (DialogResult.Yes == MessageBox.Show("Проблема..: " + message + "\n\nВозможны проблемы с интернетом.", "Error", 
				MessageBoxButtons.YesNo, MessageBoxIcon.Question))
			{
				is_download = false;
			}
			is_skipped = false;
		}
		public static string my_version = "1.0"; 
		private string url_version = " "; 
		private string name_program_linck = " "; 
        private string url_program = " "; 
        private string my_filename = "";
		private string up_filename;
		private bool is_download;
		private bool is_skipped;
	}
}
