using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin.Controls;
using SpaceKill_Kill.Configs;

namespace SpaceKill_Kill
{
	public partial class TyperForm : MaterialForm
	{
		public TyperForm()
		{
			InitializeComponent();
			button_launch.ForeColor = ForeColor;
			_messages = new List<string>();
			try
			{
				_messages = new List<string>(File.ReadAllLines("typerTexts.txt", Encoding.GetEncoding("windows-1251")));
			}
			catch
			{

			}

			if (_messages.Count == 0)
			{
				button_launch.Enabled = false;
			}
			label_textsCount.Text = _messages.Count.ToString();
			numericUpDown_sendingDelay.Value = ConfigController.TyperConfig.SendingDelay;
			numericUpDown_typingDelay.Value = ConfigController.TyperConfig.TypingDelay;
			textBox_name.Text = ConfigController.TyperConfig.Name;
			comboBox_placement.SelectedIndex = ConfigController.TyperConfig.NamePlacement;
			RegisterHotKey(Handle, 0, 1, Keys.T.GetHashCode());
		}

		[DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

		[DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
		private void Work()
		{
			Random random = new Random();
			Thread.Sleep(5000);
			while (true)
			{
				string text = _nameBefore + _messages[random.Next(0, _messages.Count)] + _nameAfter;
				for (int i = 0; i < text.Length; i++)
				{
					char c = text[i];
					if (c == '\n')
					{
						SendKeys.SendWait("^{ENTER}");
					}
					else
					{
						if (!char.IsControl(c))
						{
							if (char.IsWhiteSpace(c))
							{
								SendKeys.SendWait(" ");
							}
							else
							{
								SendKeys.SendWait("{" + c.ToString() + "}");
							}
						}
					}
					Thread.Sleep((int)numericUpDown_typingDelay.Value);
				}
				SendKeys.SendWait("{ENTER}");
				Thread.Sleep((int)numericUpDown_sendingDelay.Value);
			}
		}

		private void button_launch_Click(object sender, EventArgs e)
		{
			_active = !_active;
			bool active = _active;
			if (active)
			{
				button_launch.Text = "Стоп (Alt+T)";
				_nameBefore = (_nameAfter = "");
				switch (comboBox_placement.SelectedIndex)
				{
				case 0:
					_nameBefore = textBox_name.Text;
					break;
				case 1:
					_nameAfter = textBox_name.Text;
					break;
				case 2:
				{
					if (textBox_name.Text.Contains(":"))
					{
						_nameBefore = textBox_name.Text.Split(new char[]
						{
							':'
						})[0];
						_nameAfter = textBox_name.Text.Split(new char[]
						{
							':'
						})[1];
					}
					else
					{
						_nameAfter = (_nameBefore = textBox_name.Text);
					}
					break;
				}
				}
				_workingThread = new Thread(new ThreadStart(Work))
				{
					IsBackground = true
				};
				_workingThread.Start();
			}
			else
			{
				button_launch.Text = "Старт (Alt+T)";
				Thread expr_153 = _workingThread;
				if (expr_153 != null)
				{
					expr_153.Abort();
				}
			}
		}

		private void numericUpDown_sendingDelay_ValueChanged(object sender, EventArgs e)
		{
			ConfigController.TyperConfig.SendingDelay = (int)numericUpDown_sendingDelay.Value;
			ConfigController.TyperConfig.Save();
		}

		private void numericUpDown_typingDelay_ValueChanged(object sender, EventArgs e)
		{
			ConfigController.TyperConfig.TypingDelay = (int)numericUpDown_typingDelay.Value;
			ConfigController.TyperConfig.Save();
		}

		private void textBox_name_Click(object sender, EventArgs e)
		{
			ConfigController.TyperConfig.Name = textBox_name.Text;
			ConfigController.TyperConfig.Save();
		}

		private readonly List<string> _messages;

		private bool _active;

		private Thread _workingThread;

		private string _nameBefore;

		private string _nameAfter;
	}
}
