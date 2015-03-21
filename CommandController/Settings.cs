using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandController
{
	public class Settings
	{
		public string MyID { get; set; }
		public string McDir { get; set; }
		public bool UseServer { get; set; } //サーバ連携フラグ
		public int ExcuteType { get; set; } //1:クライアント 2:サーバー
		public bool FlgExcute { get; set; }
		public ArrayList UserList {get; set;} //ユーザーリスト
		public bool FlgDebug { get; set; } //デバッグモード
		public string HeServer { get; set; }
		public string HeDataBase { get; set; }
		public string HeUser { get; set; }
		public string HePass { get; set; }


		public Settings()
		{
			MyID = @"";
			McDir = @"";
			UseServer = false;
			ExcuteType = 1;
			FlgExcute = true;
			UserList = new ArrayList();
			FlgDebug = false;
			HeServer = @"";
			HeDataBase = @"";
			HeUser = @"";
			HePass = @"";
		}
	}
}
