namespace SpaceKill_Kill
{
	public class ChatsTarget
	{
		public string chatID;

		public string capChangeTo;

		public string setPhoto;

		public string uploadedPhoto;

		public string ourPic50 = "";
		public ChatsTarget()
		{

		}

		public ChatsTarget(string chatID, string capChangeTo, string setPhoto)
		{
			this.chatID = chatID;
			this.capChangeTo = capChangeTo;
			this.setPhoto = setPhoto;
		}
	}
}
