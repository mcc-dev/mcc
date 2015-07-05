using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CommandController
{
	public partial class AppMainForm : Form
	{
		//保存先のファイル名
		public String fileName = @"settings.config";
		public Settings appSettings = new Settings();

		//データ
		public AppData appData = new AppData();

		//ユーザIDオートコンプリート
		public AutoCompleteStringCollection autoCompList;

		//マウスクリック
		const int WM_LBUTTONDOWN = 0x0201;
		const int WM_LBUTTONUP = 0x0202;

		//キーボード情報
		const int KEYEVENTF_KEYDOWN = 0x0;		  // キーを押す
		const int KEYEVENTF_KEYUP = 0x2;			// キーを離す
		const int VK_SHIFT = 0x10;				  // SHIFTキー
		const int VK_MENU = 0x12;				   // ALTキー

		//マウスイベント
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
		static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

		//キーボードイベント
		[DllImport("user32.dll")]
		public static extern uint keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

		public AppMainForm()
		{
			LoadSettings();
			InitializeComponent();
			fncInit();
		}

		private void fncInit()
		{
			appData.LoadAll();
			autoCompList = new AutoCompleteStringCollection();
			//ユーザー名をオートコンプリートに追加
			foreach (string user in appData.user.UserList)
			{
				if (!String.IsNullOrEmpty(user) && !autoCompList.Contains(user))
				{
					this.autoCompList.Add(user);
				}
			}
		}

		public void fncAddUser(string user)
		{
			if (!String.IsNullOrEmpty(user) && !this.autoCompList.Contains(user))
			{
				this.autoCompList.Add(user);
				//this.appSettings.UserList.Add(user);
				this.appData.user.UserList.Add(user);
			}
		}

		public void SaveSettings()
		{
			//＜XMLファイルに書き込む＞
			//XmlSerializerオブジェクトを作成
			//書き込むオブジェクトの型を指定する
			XmlSerializer serializer1 = new XmlSerializer(typeof(Settings));
			//ファイルを開く（UTF-8 BOM無し）
			StreamWriter sw = new StreamWriter(fileName, false, new UTF8Encoding(false));
			//シリアル化し、XMLファイルに保存する
			serializer1.Serialize(sw, appSettings);
			//閉じる
			sw.Close();
		}

		public void LoadSettings()
		{
			if (!File.Exists(fileName))
			{
				return;
			}
			//＜XMLファイルから読み込む＞
			//XmlSerializerオブジェクトの作成
			XmlSerializer serializer2 = new XmlSerializer(typeof(Settings));
			//ファイルを開く
			StreamReader sr = new StreamReader(fileName, new UTF8Encoding(false));
			//XMLファイルから読み込み、逆シリアル化する
			appSettings = (Settings)serializer2.Deserialize(sr);
			//閉じる
			sr.Close();
		}

		public String fncGetEnd()
		{
			if (appSettings.FlgExcute)
			{
				//return "{ENTER}";
				Win32API.keybd_event(Win32API.VK_RETURN, 0, Win32API.KEYEVENTF_KEYDOWN, (UIntPtr)0);
				Win32API.keybd_event(Win32API.VK_RETURN, 0, Win32API.KEYEVENTF_KEYUP, (UIntPtr)0);
			}
			return "";
		}

		public void fncExecuteCommand(String cmd)
		{
			if (appSettings.ExcuteType == 1)
			{
				//cmd = "/" + cmd;
				Clipboard.SetDataObject(cmd);
				if (TargetWindow.fncFindMinecraft())
				{
					TargetWindow.fncChatOpen();
					//SendKeys.Send("^v" + fncGetEnd());
					Win32API.keybd_paste();
					if (appSettings.FlgExcute)
					{
						Win32API.keybd_click(Win32API.VK_RETURN);
					}
				}
			}
			else if (appSettings.ExcuteType == 2)
			{
				Clipboard.SetDataObject(cmd);
				if (TargetWindow.fncFindMinecraftServer())
				{
					//コマンド実行
					SendKeys.Send(cmd + fncGetEnd());
					//Win32API.keybd_paste_cmd();
				}
			}
			else if (appSettings.ExcuteType == 3)
			{
				Clipboard.SetDataObject(cmd);
				if (TargetWindow.fncFindBukkitGUI())
				{
					//マウスポインタの位置を取得する
					//X座標を取得する
					int x = Cursor.Position.X;
					//Y座標を取得する
					int y = Cursor.Position.Y;

					//Generalタブをクリック
					Cursor.Position = new Point(TargetWindow.winRect.left + 30, TargetWindow.winRect.top + 40);
					mouse_event(WM_LBUTTONDOWN, 0, 0, 0, 0);
					mouse_event(WM_LBUTTONUP, 0, 0, 0, 0);

					//テキストボックスにフォーカス合わせる
					SendKeys.SendWait("{TAB 7}");

					//コマンド実行
					SendKeys.SendWait("^V" + fncGetEnd());

					//マウスポインタの位置を元に戻す
					Cursor.Position = new Point(x, y);
				}
			}
			else if (appSettings.ExcuteType == 4)
			{
				//cmd = "/" + cmd;
				Clipboard.SetDataObject(cmd);
				if (TargetWindow.fncFindNotepad())
				{
					//SendKeys.Send("^V" + fncGetEnd());
					Win32API.keybd_paste();
					if (appSettings.FlgExcute)
					{
						Win32API.keybd_click(Win32API.VK_RETURN);
					}
				}
			}
			//Clipboard.Clear();
		}

		//終了時のイベント
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			//データ保存
			appData.SaveAll();
			//設定の保存
			SaveSettings();
		}

		private void appMenuFrame1_Load(object sender, EventArgs e)
		{
			appMenuFrame1.fncSetRefForm(this);
		}

		private void mcGameMode1_Load(object sender, EventArgs e)
		{
			mcGameMode1.fncSetRefForm(this);
		}

		private void mcTeleport1_Load(object sender, EventArgs e)
		{
			mcTeleport1.fncSetRefForm(this);
		}

		private void mcEnchant1_Load(object sender, EventArgs e)
		{
			mcEnchant1.fncSetRefForm(this);
		}

		private void skList1_Load(object sender, EventArgs e)
		{
			skList1.fncSetRefForm(this);
		}

		private void skTosochu1_Load(object sender, EventArgs e)
		{
			skTosochu1.fncSetRefForm(this);
		}

		private void mcEffect1_Load(object sender, EventArgs e)
		{
			mcEffect1.fncSetRefForm(this);
		}

		private void heCommand1_Load(object sender, EventArgs e)
		{
			heCommand1.fncSetRefForm(this);
		}

		private void heDataBase1_Load(object sender, EventArgs e)
		{
			heDataBase1.fncSetRefForm(this);
		}

		private void mcSign1_Load(object sender, EventArgs e)
		{
			mcSign1.fncSetRefForm(this);
		}

		private void dmHttp1_Load(object sender, EventArgs e)
		{
			dmHttp1.fncSetRefForm(this);
		}

		private void saCommand1_Load(object sender, EventArgs e)
		{
			saCommand1.fncSetRefForm(this);
		}

		private void mvWorldList1_Load(object sender, EventArgs e)
		{
			mvWorldList1.fncSetRefForm(this);
		}

	}
}
