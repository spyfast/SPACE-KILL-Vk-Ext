using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using MaterialSkin.Controls;

namespace SpaceKill_Kill
{
	public partial class MainForm : MaterialForm
	{
		public string asd;
		private static NotifyIcon ni;
		public List<Account> accounts;
		public static string[] phrases;
		public static string[] images;
		public static string[] photoComments;
		public static string[] generatorMessages;
		private string currManId;

		public MainForm()
		{
			accounts = new List<Account>();
			InitializeComponent();

		}
		private void Form1_Shown(object sender, EventArgs e)
		{

			ListControl emotionVO = EmotionVO;
			int i = VoiceVO.SelectedIndex = 0;
			emotionVO.SelectedIndex = i;
			turnOffOn.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			notifyIcon1.Icon = SystemIcons.Application;
			ni = notifyIcon1;
			CreateFileIfNotExist("accs.txt");
			CreateFileIfNotExist("lastApiKey.txt");
			CreateFileIfNotExist("phrases.txt");
			CreateFileIfNotExist("typerTexts.txt");
			CreateFileIfNotExist("photoComments.txt");
			CreateFileIfNotExist("generatorMessages.txt");
			CreateFileIfNotExist("images.txt");

			if (!Directory.Exists("AccsData"))
				Directory.CreateDirectory("AccsData");

			if (!Directory.Exists("Images"))
				Directory.CreateDirectory("Images");

			string[] files = Directory.GetFiles("Images");
			DataGridViewComboBoxColumn dataGridViewComboBoxColumn = (DataGridViewComboBoxColumn)chatsGrid.Columns[2];
			string[] array = files;
			for (int j = 0; j < array.Length; j++)
			{
				string path = array[j];
				dataGridViewComboBoxColumn.Items.Add(Path.GetFileName(path));
			}
			phrases = File.ReadAllLines("phrases.txt", Encoding.GetEncoding("windows-1251"));
			images = File.ReadAllLines("images.txt");
			photoComments = File.ReadAllLines("photoComments.txt", Encoding.GetEncoding("windows-1251"));
			generatorMessages = File.ReadAllLines("generatorMessages.txt", Encoding.GetEncoding("windows-1251"));
			Log.Push(string.Format($"В /images {files.Length} файлов"));
			Log.Push(string.Format($"В phrases.txt {phrases.Length} строк"));
			Log.Push(string.Format($"В images.txt {images.Length} строк"));
			Log.Push(string.Format($"В photoComments.txt {photoComments.Length} строк"));
			Log.Push(string.Format($"В generatorMessages.txt {generatorMessages.Length} строк"));
			Regex regex = new Regex("photo[0-9]+_[0-9]+");
			for (int k = 0; k < images.Length; k++)
			{
				Match match = regex.Match(images[k]);

				if (!match.Success)
				{
					Log.Push(string.Format($"Ошибка при обработке \"{images[k]}\""));
					images[k] = "";
				}
				else
				{
					images[k] = match.Value;
				}
			}
			string[] array2 = File.ReadAllText("lastApiKey.txt").Split(new char[]
			{
				':'
			});

			if (array2[0] != "" && array2.Length == 3)
			{
				if (array2[0] == "0")
				{
					VkCaptchaWorks.Enabled = false;
					rb_CaptManual.Checked = true;
				}
				else
				{
					if (array2[0] == "1")
					{
						VkCaptchaWorks.SetKeyAndProv(CaptchaWorksProvder.rucaptcha, array2[1]);
						rb_CaptRucaptcha.Checked = true;
						ApiKeyTextBox.Text = array2[1];
					}
					else
					{
						VkCaptchaWorks.SetKeyAndProv(CaptchaWorksProvder.antiCaptcha, array2[2]);
						rb_CaptAnticaptcha.Checked = true;
						ApiKeyTextBox.Text = array2[2];
					}
				}
			}
			else
			{
				File.WriteAllText("lastApiKey.txt", "1:" + array2[0] + ":");
				VkCaptchaWorks.SetKeyAndProv(CaptchaWorksProvder.rucaptcha, array2[0]);
				ApiKeyTextBox.Text = array2[0];
				rb_CaptRucaptcha.Checked = true;
			}
			string[] array3 = File.ReadAllLines("accs.txt", Encoding.GetEncoding("windows-1251"));
			string text = "";
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Account));
			string[] array4 = array3;
			for (i = 0; i < array4.Length; i++)
			{
				string[] array5 = array4[i].Split(new char[]
				{
					':'
				});

				if (array5.Length != 2)
				{
					Log.Push("Ошибка загрузки аккаунта из accs.txt - неверный формат");
				}
				else
				{
					Account account;
					if (!File.Exists("AccsData\\" + array5[0] + ".xml"))
					{
						account = new Account(array5[0], array5[1]);
					}
					else
					{
						FileStream fileStream = new FileStream("AccsData\\" + array5[0] + ".xml", FileMode.Open);
						XmlReader xmlReader = XmlReader.Create(fileStream);
						account = (Account)xmlSerializer.Deserialize(xmlReader);
						fileStream.Close();
					}
					account.password = array5[1];
					switch (account.CheckToken())
					{
						case -1:
							text = "Не создан";
							break;
						case 0:
							text = "Ок";
							break;
						case 1:
							text = "Неверен";
							break;
						case 2:
							text = "Неизв. ошибка";
							break;
					}
					foreach (ChatsTarget current in account.chTargets)
					{
						if (!File.Exists("Images\\" + current.setPhoto))
						{
							current.setPhoto = "Ничего";
						}
					}
					accounts.Add(account);
					accsTable.Rows.Add(new object[]
					{
						account.login,
						account.password,
						text
					});
					CurrAccComboBox.Items.Add(account.login);
				}
			}

			if (CurrAccComboBox.Items.Count != 0)
			{
				CurrAccComboBox.SelectedIndex = 0;
				materialCombobox1_SelectedIndexChanged(null, null);
			}
			CaptAns.Visible = (ManualCaptBox.Visible = (CaptPic.Visible = !VkCaptchaWorks.Enabled));
			ApiKeyTextBox.Visible = (saveCaptcha.Visible = (button1.Visible = VkCaptchaWorks.Enabled));
		}
		private void CreateFileIfNotExist(string filename)
		{
			if (!File.Exists(filename))
			{
				File.Create(filename).Close();
			}
		}
		private void LogTimer_Tick(object sender, EventArgs e)
		{
			while (Log.toPush.Count != 0)
			{
				richTextBox1.Text = Log.toPush.Dequeue() + "\n" + richTextBox1.Text;
			}

			if (enableAutoTurnOff.Checked && Account.Working && turnOffOn.Value <= DateTime.Now)
			{
				materialRaisedButton1_Click_6(null, null);
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				CurrBalance.Text = VkCaptchaWorks.GetBalance();
			}
			catch (Exception ex)
			{
				Log.Push("[Ошибка запроса баланса]: " + ex.Message);
			}
		}
		private void ManualCaptTimer_Tick(object sender, EventArgs e)
		{
			if (CaptPic.Image == null && VkCaptchaWorks.toSolve.Count != 0)
			{
				currManId = VkCaptchaWorks.toSolve.Dequeue();
				FileStream fileStream = new FileStream(currManId + ".png", FileMode.Open);
				CaptPic.Image = Image.FromStream(fileStream);
				fileStream.Close();
				File.Delete(currManId + ".png");
			}
		}
		private void commentPhotos_CheckedChanged(object sender, EventArgs e)
		{
			accounts[CurrAccComboBox.SelectedIndex].commentPhotos = commentPhotos.Checked;
		}
		private void SendVO_Click(object sender, EventArgs e)
		{
			int cs = CurrAccComboBox.SelectedIndex;
			string txt = MessageVO.Text;
			string speaker = VoiceVO.SelectedItem.ToString();
			string emotion = EmotionVO.SelectedItem.ToString();
			string speed = ((double)SpeedVO.Value * 0.01).ToString();
			new Task(delegate
			{
				accounts[cs].SendVoiceMessage(TargetVO.Text, txt, speaker, emotion, speed);
			}).Start();
		}
		private void LogEnabled_CheckedChanged(object sender, EventArgs e)
		{
			Log.enabled = !LogEnabled.Checked;
			LogTimer.Enabled = !LogEnabled.Checked;
		}
		public static void NotifyInTray(string msg)
		{
			ni.BalloonTipText = msg;
			ni.ShowBalloonTip(5000);
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			WebRequest webRequest = WebRequest.Create("http://checkip.dyndns.org");
			string text;
			using (StreamReader streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
			{
				text = streamReader.ReadToEnd();
			}
			string[] array = text.Split(new char[]
			{
				':'
			});
			string text2 = array[1].Substring(1);
			string[] array2 = text2.Split(new char[]
			{
				'<'
			});
		}
		private void materialRaisedButton1_Click_1(object sender, EventArgs e)
		{
			new Task(delegate
			{
				int num = 0;
				foreach (Account acc in accounts)
				{
					accsTable.Rows[num].Cells[2].Value = "...";
					int token = acc.GetToken();
					if (token != -1)
					{
						if (token == 0)
						{
							accsTable.Rows[num].Cells[2].Value = "Ок";

						}
					}
					else
					{
						accsTable.Rows[num].Cells[2].Value = "Ошибка авторизации";
					}
					num++;
				}
				using (List<Account>.Enumerator enumerator = accounts.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.SaveToDisk();
					}
				}
			}).Start();
		}
		private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			Log.enabled = !LogEnabled.Checked;
			LogTimer.Enabled = !LogEnabled.Checked;
		}
		private void materialCombobox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CurrAccComboBox.SelectedIndex != -1)
			{
				var Chats = accounts[CurrAccComboBox.SelectedIndex].chTargets;
				var Autoans = accounts[CurrAccComboBox.SelectedIndex].phTargetsAA;
				var Flooder = accounts[CurrAccComboBox.SelectedIndex].phrasesTargetsFL;
				var FloodPics = accounts[CurrAccComboBox.SelectedIndex].picsTargetsFL;

				numericDelayCH.Value = ((accounts[CurrAccComboBox.SelectedIndex].chatsDelay < 333)
					? 333 : accounts[CurrAccComboBox.SelectedIndex].chatsDelay);
				numericDelayAA.Value = ((accounts[CurrAccComboBox.SelectedIndex].autoansDelay < 333)
					? 333 : accounts[CurrAccComboBox.SelectedIndex].autoansDelay);
				numericDelayTextFL.Value = ((accounts[CurrAccComboBox.SelectedIndex].floodDelayText < 333)
					? 333 : accounts[CurrAccComboBox.SelectedIndex].floodDelayText);
				numericDelayPicFL.Value = ((accounts[CurrAccComboBox.SelectedIndex].floodDelayPic < 333)
					? 333 : accounts[CurrAccComboBox.SelectedIndex].floodDelayPic);
				numericDelayGE.Value = ((accounts[CurrAccComboBox.SelectedIndex].generatorDelay < 333)
					? 333 : accounts[CurrAccComboBox.SelectedIndex].generatorDelay);
				numericDelayRE.Value = ((accounts[CurrAccComboBox.SelectedIndex].remoteDelay < 333)
					? 333 : accounts[CurrAccComboBox.SelectedIndex].remoteDelay);

				chatsGrid.Rows.Clear();
				targetsGridAA.Rows.Clear();
				targetsGridFLText.Rows.Clear();
				targetsGridFLPic.Rows.Clear();
				for (int i = 0; i < Chats.Count; i++)
					chatsGrid.Rows.Add(
						"im?sel=c" + accounts[CurrAccComboBox.SelectedIndex].chTargets[i].chatID,
						Chats[i].capChangeTo,
						Chats[i].setPhoto);

				for (int j = 0; j < Autoans.Count; j++)
				{
					targetsGridAA.Rows.Add(
						Autoans[j].name,
						"im?sel=" + accounts[CurrAccComboBox.SelectedIndex].phTargetsAA[j].id);
				}

				for (int k = 0; k < Flooder.Count; k++)
				{
					targetsGridFLText.Rows.Add(
						Flooder[k].name,
						Flooder[k].target);
				}
				for (int l = 0; l < FloodPics.Count; l++)
				{
					targetsGridFLPic.Rows.Add(
						FloodPics[l].name,
						FloodPics[l].target);
				}

				TargetGE.Text = accounts[CurrAccComboBox.SelectedIndex].generatorTarget;
				MasterRE.Text = accounts[CurrAccComboBox.SelectedIndex].masterAccount;
				AccEnabledCH.Checked = accounts[CurrAccComboBox.SelectedIndex].enabledAsCH;
				FloodPicsCH.Checked = accounts[CurrAccComboBox.SelectedIndex].floodPicsCH;
				AccEnabledAA.Checked = accounts[CurrAccComboBox.SelectedIndex].enabledAsAA;
				AccEnabledFL.Checked = accounts[CurrAccComboBox.SelectedIndex].enabledAsFL;
				floodInOrder.Checked = accounts[CurrAccComboBox.SelectedIndex].floodInOrder;
				commentPhotos.Checked = accounts[CurrAccComboBox.SelectedIndex].commentPhotos;
				AccEnabledGE.Checked = accounts[CurrAccComboBox.SelectedIndex].enabledAsGE;
				AccEnabledRE.Checked = accounts[CurrAccComboBox.SelectedIndex].enabledAsRE;
			}
		}
		private void materialCheckBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			accounts[CurrAccComboBox.SelectedIndex].commentPhotos = commentPhotos.Checked;
		}
		private void materialRaisedButton1_Click_2(object sender, EventArgs e)
		{
			int cs = CurrAccComboBox.SelectedIndex;
			string txt = MessageVO.Text;
			string speaker = VoiceVO.SelectedItem.ToString();
			string emotion = EmotionVO.SelectedItem.ToString();
			string speed = ((double)SpeedVO.Value * 0.01).ToString();
			new Task(delegate
			{
				accounts[cs].SendVoiceMessage(TargetVO.Text, txt, speaker, emotion, speed);
			}).Start();
		}
		private void materialRaisedButton1_Click_3(object sender, EventArgs e)
		{
			if (ApiKeyTextBox.Text.Trim() != "")
			{
				string[] array = File.ReadAllText("lastApiKey.txt").Split(new char[]
				{
					':'
				});

				if (array.Length != 3)
				{
					array = new string[]
					{
						"1",
						array[0],
						""
					};
				}

				if (rb_CaptRucaptcha.Checked)
				{
					VkCaptchaWorks.SetKeyAndProv(CaptchaWorksProvder.rucaptcha, ApiKeyTextBox.Text.Trim());
					array[0] = "1";
					array[1] = ApiKeyTextBox.Text.Trim();
				}
				else
				{
					VkCaptchaWorks.SetKeyAndProv(CaptchaWorksProvder.antiCaptcha, ApiKeyTextBox.Text.Trim());
					array[0] = "2";
					array[2] = ApiKeyTextBox.Text.Trim();
				}
				File.WriteAllText("lastApiKey.txt", string.Concat(new string[]
				{
					array[0],
					":",
					array[1],
					":",
					array[2]
				}));

				VkCaptchaWorks.Enabled = !rb_CaptManual.Checked;
				CaptAns.Visible = (ManualCaptBox.Visible = (CaptPic.Visible = !VkCaptchaWorks.Enabled));
				label8.Visible = (CurrBalance.Visible = (ApiKeyTextBox.Visible = (saveCaptcha.Visible = (button1.Visible = VkCaptchaWorks.Enabled))));
			}
		}
		private void materialRaisedButton1_Click_4(object sender, EventArgs e)
		{
			if (ManualCaptBox.Text == "" || currManId == null)
			{
				VkCaptchaWorks.RegisterManual(currManId, ManualCaptBox.Text);
				CaptPic.Image.Dispose();
				CaptPic.Image = null;
				currManId = null;
				ManualCaptBox.Clear();
			}
		}
		private void materialRaisedButton1_Click_5(object sender, EventArgs e)
		{
			try
			{
				CurrBalance.Text = VkCaptchaWorks.GetBalance();
			}
			catch (Exception ex)
			{
				Log.Push("[Ошибка запроса баланса]: " + ex.Message);
			}
		}
		private void materialRaisedButton1_Click_6(object sender, EventArgs e)
		{
			try
			{
				accounts[CurrAccComboBox.SelectedIndex].floodInOrder = floodInOrder.Checked;
				if (Account.Working)
				{
					Account.Working = false;
					MainRun.Text = "Запустить все включенные задачи";
				}
				else
				{
					MainRun.Text = "Выключить все включенные задачи";
					Account.Working = true;
					foreach (Account current in accounts)
					{
						if (current.enabledAsAA || current.enabledAsFL || current.enabledAsCH || current.enabledAsGE || current.enabledAsRE)
						{
							if (current.token_status)
							{
								current.AsyncWorker();
							}
							else
							{
								Log.Push("[" + current.login + "]: запуск невозможен, неверный token");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Log.Push("[Ошибка запуска]: " + ex.Message);
			}
		}

		private void materialRaisedButton1_Click_7(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void materialRaisedButton2_Click_2(object sender, EventArgs e)
		{
			if (CurrAccComboBox.SelectedIndex != -1)
			{
				Account account = accounts[CurrAccComboBox.SelectedIndex];
				account.floodDelayText = (int)numericDelayTextFL.Value;
				account.floodDelayPic = (int)numericDelayPicFL.Value;
				account.SetFLPhrasesTargets(targetsGridFLText.Rows);
				account.enabledAsFL = AccEnabledFL.Checked;
				account.SaveToDisk();
			}
		}

		private void materialRaisedButton3_Click_2(object sender, EventArgs e)
		{
			if (CurrAccComboBox.SelectedIndex != -1)
			{
				Account account = accounts[CurrAccComboBox.SelectedIndex];
				account.floodDelayPic = (int)numericDelayPicFL.Value;
				account.SetFLPhrasesTargets(targetsGridFLText.Rows);
				account.SetFLPicsTargets(targetsGridFLPic.Rows);
				account.enabledAsFL = AccEnabledFL.Checked;
				account.commentPhotos = commentPhotos.Checked;
				account.SaveToDisk();
			}
		}

		private void materialRaisedButton4_Click(object sender, EventArgs e)
		{
			if (CurrAccComboBox.SelectedIndex != -1)
			{
				Account account = accounts[CurrAccComboBox.SelectedIndex];
				account.chatsDelay = (int)numericDelayCH.Value;
				account.SetChatsTargets(chatsGrid.Rows);
				account.enabledAsCH = AccEnabledCH.Checked;
				account.floodPicsCH = FloodPicsCH.Checked;
				account.SaveToDisk();
			}
		}

		private void materialRaisedButton5_Click(object sender, EventArgs e)
		{
			if (CurrAccComboBox.SelectedIndex == -1)
			{
				Account account = accounts[CurrAccComboBox.SelectedIndex];
				account.autoansDelay = (int)numericDelayAA.Value;
				account.SetAAPhrasesTargets(targetsGridAA.Rows);
				account.ParsePictargets();
				account.enabledAsAA = AccEnabledAA.Checked;
				account.SaveToDisk();
			}
		}

		private void materialRaisedButton6_Click(object sender, EventArgs e)
		{
			if (CurrAccComboBox.SelectedIndex == -1)
			{
				Account account = accounts[CurrAccComboBox.SelectedIndex];
				account.generatorDelay = (int)numericDelayGE.Value;
				account.generatorTarget = TargetGE.Text;
				account.enabledAsGE = AccEnabledGE.Checked;
				account.SaveToDisk();
			}
		}

		private void materialRaisedButton7_Click(object sender, EventArgs e)
		{
			if (CurrAccComboBox.SelectedIndex == -1)
			{
				Account account = accounts[CurrAccComboBox.SelectedIndex];
				account.remoteDelay = (int)numericDelayRE.Value;
				account.masterAccount = MasterRE.Text;
				account.enabledAsRE = AccEnabledRE.Checked;
				account.SaveToDisk();
			}
		}
	}
}
