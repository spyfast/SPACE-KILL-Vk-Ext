using System;
using System.Text;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Net;
using System.Management;
using System.IO;

namespace SpaceKill_Kill
{
    public partial class Auth : MaterialForm
    {
        public Auth()
        {
            InitializeComponent();
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.DeepOrange400, Accent.DeepOrange400, TextShade.WHITE);

        }
        private string text = String.Empty;

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                MessageBox.Show("Укажите, пожалуйста, username", "OBS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                String password = "log=admin&pas=admin";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("");
                request.UserAgent = "Mozilla/5.0";
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                byte[] EncodedPostParams = Encoding.ASCII.GetBytes(password);
                request.ContentLength = EncodedPostParams.Length;
                request.GetRequestStream().Write(EncodedPostParams, 0, EncodedPostParams.Length);
                request.GetRequestStream().Close();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string html = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("windows-1251")).ReadToEnd();
                string[] stringSeparators = new string[] { "\n" };
                string[] result = html.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

                string PolucheniiNomer = "";

                foreach (string stroka in result)
                {
                    if (stroka.IndexOf(textBox2.Text) != -1)
                    {
                        string[] NashaStroka = stroka.ToString().Split((Convert.ToChar(":")));

                        string reLoL0 = (Crypt(NashaStroka[1].ToString()));
                        PolucheniiNomer = reLoL0.ToString();

                    }
                }

                if (PolucheniiNomer == "")
                {
                    MessageBox.Show("Упс, данного пользователя не существует в базе данных, для активации аккаунта обратитесь к администраторам :(", "Space Kill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    string HoldingAdress = "";
                    try
                    {
                        string drive = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
                        ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\"");
                        disk.Get();
                        string diskLetter = (disk["VolumeSerialNumber"].ToString());
                        HoldingAdress = diskLetter;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Возникла критическая ошибка, автозакрытие приложения 0х01", "Space Kill", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                    string hwid = PolucheniiNomer.Substring(0, 8);
                    if (HoldingAdress == hwid)
                    {


                        MessageBox.Show("Вы вошли как: " + textBox2.Text, "Space Kill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainForm f = new MainForm();
                        f.Show();
                        Hide();
                    }
                }
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            try
            {
                string drive = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
                ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\"");
                disk.Get();
                string diskLetter = (disk["VolumeSerialNumber"].ToString());
                string lol1 = (Crypt(diskLetter.ToString()));
                HWID.Text = lol1;

            }
            catch (Exception)
            {
                HWID.Text = "Error to generate SYS code!";
            }
        }
            private string Crypt(string text)
            {
                string rtnStr = string.Empty;
                foreach (char c in text)
                {
                    rtnStr += (char)((int)c ^ 1);
                }
                return rtnStr;
            }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HWID.Text);
            MessageBox.Show("HWID скопирован в буфер обмена!", "ISB", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}