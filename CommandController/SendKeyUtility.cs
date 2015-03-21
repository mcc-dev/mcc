using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CommandController
{
	public static class SendKeyUtility
	{
		//非同期で送信する
		public static void SendKeyAsync(string keys)
		{
			//Thread t = new Thread(new ThreadStart(SendEnterAfterSleep(keys)));
			Thread t = new Thread(new ParameterizedThreadStart(SendEnterAfterSleep));
			t.Start(keys);
		}
		//keysを送信する
		public static void SendEnterAfterSleep(object o)
		{
			// キャストが必要
			string keys = (string)o;
			SendKeys.SendWait(keys);
		}
	}
}
