namespace MinecraftCommandController.Entities
{
	public class SettingEt
	{
		public string MyID { get; set; }
		public string McDir { get; set; }
		public bool UseServer { get; set; } //サーバ連携フラグ
		public string ServerFile { get; set; }
		public string ServerArg { get; set; }
		public string JavaDir { get; set; }
		public int ExcuteType { get; set; } //1:クライアント 2:サーバー
		public bool FlgExcute { get; set; }
		public bool FlgDebug { get; set; } //デバッグモード
		public string HeServer { get; set; }
		public string HeDataBase { get; set; }
		public string HeUser { get; set; }
		public string HePass { get; set; }

		public SettingEt()
		{
			MyID = @"";
			McDir = @"";
			UseServer = false;
			ServerFile = @"";
			ServerArg = @"";
			JavaDir = @"";
			ExcuteType = 1;
			FlgExcute = true;
			FlgDebug = false;
			HeServer = @"";
			HeDataBase = @"";
			HeUser = @"";
			HePass = @"";
		}
	}
}
