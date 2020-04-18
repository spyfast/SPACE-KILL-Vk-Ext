using SpaceKill_Kill;
using System;
using System.Collections.Generic;

namespace PatriarhBot
{
    public class SetAccount
    {
		public string masterAccount;

		public bool enabledAsRE;

		public int remoteDelay;

		public string generatorTarget;

		public bool enabledAsGE;

		public int generatorDelay;

		[NonSerialized]
		public static bool Working;

		[NonSerialized]
		public Random rnd = new Random();

		[NonSerialized]
		public bool token_status;

		public string login;

		public string password;

		public string token;

		public string id;

		public List<ChatsTarget> chTargets;

		public bool enabledAsCH;

		public bool floodPicsCH;

		public int chatsDelay;

		public List<PhrasesTargetAA> phTargetsAA;

		public List<string> picTargetsAA;

		public List<string> pictReplyPM;

		public List<string> pictReplyChats;

		public List<string> pictReplyCommentWallpost;

		public List<string> pictReplyCommentPhoto;

		public List<string> pictReplyCommentVideo;

		public List<string> pictReplyTopic;

		public int autoansDelay;

		public bool enabledAsAA;

		public List<Message> msgs;


		public List<FlooderTarget> phrasesTargetsFL;

		public List<FlooderTarget> picsTargetsFL;

		public int floodDelayText;

		public int floodDelayPic;

		public bool enabledAsFL;

		public bool floodInOrder;

		public bool commentPhotos = true;

		public int fioIterator;
	}
}
