using PatriarhBot;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SpaceKill_Kill
{
	public class Account : SetAccount
	{
		private void ProcGenerator()
		{
			string text = generatorTarget;
			if (text == "" || MainForm.generatorMessages.Length == 0)
			{
				Log.Push($"[{login}]: Генерация сообщений...");
				text = StrWrk.qSubstr(text, "im?sel=c", false);
				JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
				string input = StrWrk.GetBetween(VKserver.APIRequest("messages.getChat", "chat_id=" + text, token, ""), "\"users\":", "]") + "]";
				List<string> list = javaScriptSerializer.Deserialize<List<string>>(input);
				list.Remove(id);

				if (list.Count == 0)
				{
					Log.Push("[" + login + "]: В чате нет людей");
				}
				else
				{
					Random random = new Random();
					string text2 = list[random.Next(0, list.Count)];
					string text3 = VKserver.APIRequest("users.get", "user_ids=" + text2, token, "");
					text3 = StrWrk.GetBetween(text3, "\"first_name\":\"", "\",");
					string str = string.Format("*id{0} ({1})", text2, text3) + " - " + MainForm.generatorMessages[random.Next(0, MainForm.generatorMessages.Length)];
					VKserver.APIRequest("messages.send", "chat_id=" + text + "&message=" + str, token, "");
				}
			}
		}
		private void WorkUntilStopAsGE()
		{
			while (Working && enabledAsGE)
			{
				try
				{
					ProcGenerator();
				}
				catch (Exception ex)
				{
					Log.Push($"[Поток {login}]: " + ex.Message);
				}
				Thread.Sleep(generatorDelay);
			}
		}

		public void SendVoiceMessage(string dist, string message, string voice, string emotion, string speed)
		{
			Log.Push($"[Поток {login}]: Отправка голосового сообщения в " + dist);
			new WebClient().DownloadFile(string.Format("https://tts.voicetech.yandex.net/generate?text={0}&format=mp3&lang=ru-RU&speaker={1}&emotion={2}&speed={3}&key=9ae121de-59ba-4145-a0cb-bdbdec107297", new object[]
			{
				message,
				voice,
				emotion,
				speed
			}), "temp.mp3");
			string str = Network.HttpUploadFile(StrWrk.GetBetween(VKserver.APIRequest("docs.getUploadServer", "type=audio_message", token, ""), "\"upload_url\":\"", "\"}").Replace("\\/", "/"), "temp.mp3", "file", "audio/MP3");
			string text = VKserver.APIRequest("docs.save", "file=" + StrWrk.GetBetween(str, "\"file\":\"", "\"}"), token, "");
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
			text = StrWrk.GetBetween(text, "\"resplonse\":\"[", "]}");
			UploadResult uploadResult = javaScriptSerializer.Deserialize<UploadResult>(text);

			if (dist.StartsWith("im?sel=c"))
			{
				string arg = StrWrk.qSubstr(dist, "im?sel=c", false);
				VKserver.APIRequest("messages.send", string.Format("chat_id={0}&attachment=doc{1}_{2}", arg, uploadResult.owner_id, uploadResult.id), token, "");
			}
			else
			{
				if (dist.StartsWith("im?sel="))
				{
					string arg2 = StrWrk.qSubstr(dist, "im?sel=", false);
					VKserver.APIRequest("messages.send", string.Format("user_id={0}&attachment=doc{1}_{2}", arg2, uploadResult.owner_id, uploadResult.id), token, "");
				}
				else
				{
					Log.Push(string.Concat(new string[]
					{
						"[Поток ",
						login,
						"]: ",
						dist,
						" - неверный формат"
					}));
				}
			}
		}
		public Account()
		{
		}
		public Account(string login, string password)
		{
			this.login = login;
			this.password = password;
			phrasesTargetsFL = new List<FlooderTarget>();
			picsTargetsFL = new List<FlooderTarget>();
			phTargetsAA = new List<PhrasesTargetAA>();
			chTargets = new List<ChatsTarget>();
			picTargetsAA = new List<string>();
			pictReplyPM = new List<string>();
			pictReplyChats = new List<string>();
			pictReplyCommentWallpost = new List<string>();
			pictReplyCommentPhoto = new List<string>();
			pictReplyCommentVideo = new List<string>();
			pictReplyTopic = new List<string>();
		}

		public int CheckToken()
		{
            token_status = false;
            if (token == null)
            {
                return -1;
            }
            int result;
            try
            {
                VKserver.APIRequest("friends.getRequests", "", token, "");
                token_status = true;
                result = 0;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("could not get application"))
                {
                    result = 1;
                }
                else
                {
                    Log.Push("[Ошибка уровня API]: " + ex.Message);
                    result = 2;
                }
            }
            return result;
        }

		public int GetToken()
		{
			int num;
			int result;
			if (CheckToken() == 0)
			{
				num = 0;
			}
			else
			{
				CookieContainer cc = new CookieContainer();
				string text = Network.GET("https://vk.com/", cc);
				text = StrWrk.GetBetween(text, "action=\"", "\"");
				string url = text;
				text = Network.POST(url, "email=" + login + "&pass=" + password, cc);

				if (!text.Contains("_logout"))
				{
					if (!text.Contains("captcha_img"))
					{
						result = -1;
						return result;
					}
					Log.Push("Капча при получении токена " + login + ", переключитесь на ручной ввод капчи");
					string text2 = StrWrk.qSubstr(text, "captcha.php", false);
					text2 = StrWrk.GetBetween(text2, "sid=", "\"");
					string arg = VkCaptchaWorks.SolveManual("https://m.vk.com/captcha.php?s=0&sid=" + text2, text2);
					text = Network.POST(url, string.Concat(new string[]
					{
						"email=",
						login,
						"&pass=",
						password,
						string.Format("&captcha_sid={0}&captcha_key={1}", text2, arg)
					}), cc);

					if (!text.Contains("_logout"))
					{
						result = -1;
						return result;
					}
				}
				string text3;
				text = Network.GET("https://oauth.vk.com/authorize?client_id=2685278&scope=1073737727&redirect_uri=https://api.vk.com/blank.html&display=page&response_type=token&revoke=1')", out text3, cc); //Вставить ссылку авторизации

				if (text3 == null)
				{
					text = StrWrk.GetBetween(text, "form method=\"post\" action=\"", "\"");
				}
				else
				{
					text = text3;
				}
				Network.GET(text, out text3, cc);

				if (!text3.Contains("access_token="))
				{
					Log.Push($"[{login}]: Ошибка авторизации, включена двуфакторная авторизация?");
					num = -1;
				}
				else
				{
					token = StrWrk.GetBetween(text3, "access_token=", "&");
					token_status = true;
					num = 0;
				}
			}
			result = num;
			return result;
		}
		public void SaveToDisk()
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Account));
			TextWriter textWriter = new StreamWriter("AccsData\\" + login + ".xml");
			xmlSerializer.Serialize(textWriter, this);
			textWriter.Close();
		}
		public void AsyncWorker()
		{
			id = VKserver.APIRequest("users.get", "", token, "");
			id = StrWrk.GetBetween(id, "\"id\":", ",");

			if (enabledAsAA)
				new Task(() => WorkUntilStopAsAA()).Start();

			if (enabledAsFL)
			{
				new Task(() => WorkUntilStopAsFLText()).Start();

				new Task(() => WorkUntilStopAsFLPic()).Start();
			}

			if (enabledAsCH)
			{
				PrepareChatsPics();
				new Task(() => WorkUntilStopAsCH()).Start();
			}

			if (enabledAsGE)
				new Task(() => WorkUntilStopAsGE()).Start();
		}
		private void ProcChats()
		{
			if (chTargets.Count == 0)
			{
				Log.Push($"[{login}]: Обработка чатов...");
				JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
				string text = "";
				foreach (ChatsTarget current in chTargets)
				{
					text = text + current.chatID + ",";
				}
				text = text.Substring(0, text.Length - 1);
				string text2 = StrWrk.qSubstr(VKserver.APIRequest("messages.getChat", "chat_ids=" + text, token, ""), "\"response\":", false);
				text2 = text2.Substring(0, text2.Length - 1);
				List<ChatInfo>.Enumerator enumerator2 = javaScriptSerializer.Deserialize<List<ChatInfo>>(text2).GetEnumerator();
				List<ChatsTarget>.Enumerator enumerator3 = chTargets.GetEnumerator();
				ExecuteManager executeManager = new ExecuteManager(token);
				while (enumerator2.MoveNext() && enumerator3.MoveNext())
				{
					if (enumerator3.Current.setPhoto == "Удалять" && enumerator2.Current.photo_50 != null)
					{
						executeManager.Add("API.messages.deleteChatPhoto({\"chat_id\":" + enumerator3.Current.chatID + "});");
					}

					if (enumerator3.Current.setPhoto != "" && enumerator3.Current.setPhoto != "Удалять" && enumerator3.Current.setPhoto != "Ничего" && (floodPicsCH || enumerator2.Current.photo_50 != enumerator3.Current.ourPic50))
					{
						string text3 = StrWrk.qSubstr(VKserver.APIRequest("messages.setChatPhoto", "file=" + enumerator3.Current.uploadedPhoto, token, ""), "\"response\":", false);
						text3 = text3.Substring(0, text3.Length - 1);
						text3 = StrWrk.qSubstr(text3, "\"chat\":", false);
						text3 = text3.Substring(0, text3.Length - 1);
						ChatInfo chatInfo = javaScriptSerializer.Deserialize<ChatInfo>(text3);
						enumerator3.Current.ourPic50 = chatInfo.photo_50;
					}
					if (enumerator3.Current.capChangeTo != "" && enumerator3.Current.capChangeTo != enumerator2.Current.title)
					{
						executeManager.Add(string.Concat(new string[]
						{
							"API.messages.editChat({\"chat_id\":",
							enumerator3.Current.chatID,
							", \"title\":\"",
							enumerator3.Current.capChangeTo.Replace("\"", "\\\""),
							"\"});"
						}));
					}
				}
				executeManager.Execute();
			}
		}

		public void SetChatsTargets(DataGridViewRowCollection rows)
		{
			chTargets.Clear();
			foreach (object current in ((IEnumerable)rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)current;
				if (dataGridViewRow.Cells[0].Value != null)
				{
					string text = dataGridViewRow.Cells[0].Value.ToString();
					if (text.Contains("im?sel=c"))
					{
						chTargets.Add(new ChatsTarget(
							StrWrk.qSubstr(text, "im?sel=c", false), 
							(dataGridViewRow.Cells[1].Value ?? "").ToString(), 
							(string)(dataGridViewRow.Cells[2].Value ?? "")));
					}
				}
			}
		}
		private void PrepareChatsPics()
		{
			Log.Push($"[Поток {login}]: Загрузка на сервер аватаров бесед");
			Directory.GetFiles("Images");
			foreach (ChatsTarget current in chTargets)
			{
				string text = "Images\\" + current.setPhoto;
				if (text != null && !(text == "Ничего") && !(text == "Удалять"))
				{
					string str;
					if (Path.GetExtension(text) == ".png")
					{
						str = "png";
					}
					else
					{
						if (!(Path.GetExtension(text) == ".jpg") && !(Path.GetExtension(text) == ".jpeg"))
						{
							continue;
						}
						str = "jpeg";
					}
					string text2 = StrWrk.GetBetween(VKserver.APIRequest("photos.getChatUploadServer", "chat_id=" + current.chatID, token, ""), "\"upload_url\":\"", "\"");
					text2 = Network.HttpUploadFile(text2.Replace("\\/", "/"), text, "photo", "image/" + str);
					text2 = StrWrk.GetBetween(text2, "\"response\":\"", "\"");
					current.uploadedPhoto = text2;
				}
			}
		}

		private void WorkUntilStopAsCH()
		{
			while (Working && enabledAsCH)
			{
				try
				{
					ProcChats();
				}
				catch (Exception ex)
				{
					Log.Push("[Поток " + login + "]: " + ex.Message);
				}
				Thread.Sleep(chatsDelay);
			}
		}

		public void ParsePictargets()
		{
			pictReplyPM.Clear();
			pictReplyChats.Clear();
			pictReplyCommentWallpost.Clear();
			pictReplyCommentPhoto.Clear();
			pictReplyCommentVideo.Clear();
			pictReplyTopic.Clear();
			foreach (string current in picTargetsAA)
			{
				if (current.StartsWith("im?sel=c"))
				{
					string chat = StrWrk.qSubstr(current, "im?sel=c", false);
					pictReplyChats.Add(chat);
				}
				else if (current.StartsWith("im?sel="))
				{
					string user = StrWrk.qSubstr(current, "im?sel=", false);
					pictReplyPM.Add(user);
				}
				else
					Log.Push($"[{login}]: \"{current}\" — неверный формат");
			}
		}
		public void SetAAPhrasesTargets(DataGridViewRowCollection rows)
		{
			phTargetsAA.Clear();
			foreach (object current in ((IEnumerable)rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)current;
				if (dataGridViewRow.Cells[1].Value != null)
				{
					phTargetsAA.Add(new PhrasesTargetAA(
						(dataGridViewRow.Cells[0].Value ?? "").ToString(), 
						StrWrk.qSubstr(dataGridViewRow.Cells[1].Value.ToString(), 
						"im?sel=", false)));
				}
			}
		}
		private void ProcAnsMessages()
		{
			long lastCheckAA = 0;
			if (phTargetsAA.Count == 0)
			{
				Log.Push($"[{login}]: Обработка автоответа в лички и чаты...");
				ExecuteManager executeManager = new ExecuteManager(token);
				foreach (Message current in msgs)
				{
					if (current.date >= lastCheckAA)
					{
						foreach (PhrasesTargetAA current2 in phTargetsAA)
						{
							if (current2.id == current.user_id && current.chat_id == null)
							{
								executeManager.Add(string.Concat(new string[]
								{
									"API.messages.send({\"user_id\":",
									current2.id,
									",\"message\":\"",
									current2.name.Replace("\"", "\\\""),
									MainForm.phrases[rnd.Next(0, MainForm.phrases.Length)].Replace("\"", "\\\""),
									"\"});"
								}));
								break;
							}
							bool auto = current2.id.Substring(1) == current.chat_id && new List<string>(current2.name.Split(new char[]
							{
								','
							})).Contains(current.user_id);

							if (auto)
							{
								executeManager.Add(string.Concat(new object[]
								{
									"API.messages.send({\"chat_id\":",
									current2.id.Substring(1),
									",\"message\":\"",
									MainForm.phrases[rnd.Next(0, MainForm.phrases.Length)].Replace("\"", "\\\""),
									"\", \"forward_messages\":\"",
									current.id,
									"\"});"
								}));
								break;
							}
						}
					}
				}
				executeManager.Execute();
			}
		}

		private string GetRandomPhoto()
		{
			return MainForm.images[rnd.Next(0, MainForm.images.Length)];
		}

		private void ProcAnsEverythingWithPics()
		{
			if (picTargetsAA.Count == 0)
			{
				Log.Push($"[{login}]: Обработка автоответа картинками...");
				ExecuteManager executeManager = new ExecuteManager(token);
				foreach (Message current in msgs)
				{
					if (current.read_state == 0)
					{
						if (current.chat_id == null)
						{
							using (List<string>.Enumerator enumerator2 = pictReplyPM.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									string current2 = enumerator2.Current;
									if (current2 == current.user_id)
									{
										executeManager.Add(string.Concat(new string[]
										{
											"API.messages.send({\"user_id\":",
											current2,
											", \"attachment\":\"",
											GetRandomPhoto(),
											"\"});"
										}));
										break;
									}
								}
								continue;
							}
						}
						foreach (string current3 in pictReplyChats)
						{
							if (current3 == current.chat_id)
							{
								executeManager.Add(string.Concat(new string[]
								{
									"API.messages.send({\"chat_id\":",
									current3,
									", \"attachment\":\"",
									GetRandomPhoto(),
									"\"});"
								}));
								break;
							}
						}
					}
				}
			}
		}
		private void WorkUntilStopAsAA()
		{
			while (Working && enabledAsAA)
			{
				try
				{
					JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
					string text = StrWrk.qSubstr(VKserver.APIRequest("messages.get", "count=100", token, ""), "\"items\":", false);
					text = text.Substring(0, text.Length - 2);
					msgs = javaScriptSerializer.Deserialize<List<Message>>(text);
					ProcAnsMessages();
					ProcAnsEverythingWithPics();
				}
				catch (Exception ex)
				{
					Log.Push($"[Поток {login}]: " + ex.Message);
				}
				Thread.Sleep(autoansDelay);
			}
		}

		public void SetFLPhrasesTargets(DataGridViewRowCollection rows)
		{
			phrasesTargetsFL.Clear();
			foreach (object current in ((IEnumerable)rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)current;
				if (dataGridViewRow.Cells[1].Value != null)
				{
					phrasesTargetsFL.Add(new FlooderTarget(
						(dataGridViewRow.Cells[0].Value ?? "").ToString(), 
						dataGridViewRow.Cells[1].Value.ToString()));
				}
			}
		}
		public void SetFLPicsTargets(DataGridViewRowCollection rows)
		{
			picsTargetsFL.Clear();
			foreach (object current in ((IEnumerable)rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)current;
				if (dataGridViewRow.Cells[1].Value != null)
				{
					picsTargetsFL.Add(new FlooderTarget(
						(dataGridViewRow.Cells[0].Value ?? "").ToString(),
						dataGridViewRow.Cells[1].Value.ToString()));
				}
			}
		}

		private void PhraseToRandomDistFL(string msg, int index)
		{
			//int index = rnd.Next(0, phrasesTargetsFL.Count);
			string target = phrasesTargetsFL[index].target;
			if (phrasesTargetsFL[index].name != null)
			{
				msg = phrasesTargetsFL[index].name + msg;
			}
			Log.Push(string.Concat(new string[]
			{
				"[Поток ",
				login,
				"]: постинг \"",
				msg,
				"\" в ",
				target
			}));
			try
			{

				if (target.StartsWith("im?sel=c"))
				{
					string str = StrWrk.qSubstr(target, "im?sel=c", false);
					VKserver.APIRequest("messages.send", "chat_id=" + str + "&message=" + msg, token, "");
				}
				else if (target.StartsWith("im?sel="))
				{
					string str2 = StrWrk.qSubstr(target, "im?sel=", false);
					VKserver.APIRequest("messages.send", "user_id=" + str2 + "&message=" + msg, token, "");
				}
				else
					Log.Push($"[{login}]: \"{target}\" — неверный формат");
			}
			catch (Exception ex)
			{
				Log.Push("[Ошибка уровня API]: " + ex.Message);
			}
		}

		private void PicToRandomDistFL(string pic)
		{
			int index = rnd.Next(0, picsTargetsFL.Count);
			string target = picsTargetsFL[index].target;
			string text = "";
			if (picsTargetsFL[index].name != null)
			{
				text = picsTargetsFL[index].name;
			}
			if (commentPhotos)
			{
				text += ((MainForm.photoComments.Length != 0) ? MainForm.photoComments[rnd.Next(0, MainForm.photoComments.Length)] : "");
			}
			text = text + "&attachment=" + pic;
			Log.Push(string.Concat(new string[]
			{
				"[Поток ",
				login,
				"]: постинг ",
				pic,
				" в ",
				target
			}));
			try
			{
				if (target.StartsWith("im?sel=c"))
				{
					string str = StrWrk.qSubstr(target, "im?sel=c", false);
					VKserver.APIRequest("messages.send", "chat_id=" + str + "&message=" + text, token, "");
				}
				else if (target.StartsWith("im?sel="))
				{
					string str = StrWrk.qSubstr(target, "im?sel=", false);
					VKserver.APIRequest("messages.send", "user_id=" + str + "&message=" + text, token, "");
				}
				else
					Log.Push($"[{login}]: \"{target}\" — неверный формат");
			}
			catch (Exception ex)
			{
				Log.Push("[Ошибка уровня API]: " + ex.Message);
			}
		}

		private void WorkUntilStopAsFLText()
		{
            int targetIndex = 0;
            int randomTargetIndex;
            while (Working && enabledAsFL)
			{
				try
				{
					if (MainForm.phrases.Length != 0 && phrasesTargetsFL.Count > 0)
					{
						string msg = MainForm.phrases[rnd.Next(0, MainForm.phrases.Length)];
                        
						if (floodInOrder)
						{
							msg = MainForm.phrases[fioIterator];
							
                            PhraseToRandomDistFL(msg, targetIndex);
                            targetIndex = targetIndex + 1;
                            if(targetIndex == phrasesTargetsFL.Count)
                            {
                                targetIndex = 0;
                                fioIterator = (fioIterator + 1) % MainForm.phrases.Length;
                            }
                        }
                        else
                        {
                            randomTargetIndex = rnd.Next(0, phrasesTargetsFL.Count);
                            PhraseToRandomDistFL(msg, randomTargetIndex);
                        }
						
					}
				}
				catch (Exception ex)
				{
					Log.Push($"[Поток {login}]: " + ex.Message);
				}
				Thread.Sleep(floodDelayText);
			}
		}

		private void WorkUntilStopAsFLPic()
		{
			while (Working && enabledAsFL)
			{
				try
				{
					if (MainForm.images.Length != 0 && picsTargetsFL.Count > 0)
					{
						PicToRandomDistFL(MainForm.images[rnd.Next(0, MainForm.images.Length)]);
					}
				}
				catch (Exception ex)
				{
					Log.Push($"[Поток {login}]: " + ex.Message);
				}
				Thread.Sleep(floodDelayPic);
			}
		}
	}
}
