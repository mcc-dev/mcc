using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CommandController
{
	static class TargetWindow
	{
		//ウィンドウの大きさ
		[StructLayout(LayoutKind.Sequential)]
		public struct RECT
		{
			public int left;
			public int top;
			public int right;
			public int bottom;
		}
		static public RECT winRect = new RECT();

		//ウィンドウの大きさを取得する
		[DllImport("user32.dll")]
		private static extern int GetWindowRect(IntPtr hwnd, ref  RECT lpRect);

		static public Boolean fncFindMinecraft()
		{
			bool isFound = false;
			//javaのプロセスを列挙する
			foreach (Process p in Process.GetProcesses())
			{
				if (p.ProcessName == "javaw" && 0 <= p.MainWindowTitle.IndexOf("Minecraft 1"))
				{
					isFound = true;
				}
				else if (p.ProcessName == "java" && 0 <= p.MainWindowTitle.IndexOf("Minecraft 1"))
				{
					isFound = true;
				}
				if (isFound)
				{
					//ウィンドウをアクティブにする
					//Microsoft.VisualBasic.Interaction.AppActivate(p.Id);
					Win32API.SetForegroundWindow(p.MainWindowHandle);
					Thread.Sleep(50);
					return true;
				}
			}
			//Console.WriteLine("not found");
			MessageBox.Show("クライアントウィンドウが見つかりません。");
			return false;
		}

		static public Boolean fncFindMinecraftServer()
		{
			bool isFound = false;
			//プロセスを列挙する
			foreach (Process p in Process.GetProcesses())
			{
				if (p.ProcessName == "cmd" && 0 <= p.MainWindowTitle.IndexOf("Minecraft 1"))
				{
					isFound = true;
				}
				if (isFound)
				{
					//ウィンドウをアクティブにする
					//Microsoft.VisualBasic.Interaction.AppActivate(p.Id);
					Win32API.SetForegroundWindow(p.MainWindowHandle);
					Thread.Sleep(50);
					return true;
				}
			}
			Console.WriteLine("not found");
			MessageBox.Show("サーバーウィンドウが見つかりません。");
			return false;
		}

		static public Boolean fncFindBukkitGUI()
		{
			bool isFound = false;
			//プロセスを列挙する
			foreach (Process p in Process.GetProcesses())
			{
				if (p.ProcessName == "BukkitGUI" && 0 <= p.MainWindowTitle.IndexOf("BukkitGUI"))
				{
					isFound = true;
				}
				if (isFound)
				{
					//ウィンドウをアクティブにする
					//Microsoft.VisualBasic.Interaction.AppActivate(p.Id);
					Win32API.SetForegroundWindow(p.MainWindowHandle);
					//ウィンドウの大きさを取得
					GetWindowRect(p.MainWindowHandle, ref winRect);

					Thread.Sleep(50);
					return true;
				}
			}
			//Console.WriteLine("not found");
			MessageBox.Show("BukkitGUIが見つかりません。"); 
			return false;
		}

		static public Boolean fncFindNotepad()
		{
			bool isFound = false;
			//メモ帳探す
			foreach (Process p in Process.GetProcesses())
			{
				if (p.ProcessName == "notepad" && 0 <= p.MainWindowTitle.IndexOf("メモ帳"))
				{
					isFound = true;
				}
				if (isFound)
				{
					//ウィンドウをアクティブにする
					//Microsoft.VisualBasic.Interaction.AppActivate(p.Id);
					Win32API.SetForegroundWindow(p.MainWindowHandle);
					Thread.Sleep(50);
					return true;
				}
			}
			//Console.WriteLine("not found");
			MessageBox.Show("メモ帳が見つかりません。"); 
			return false;
		}

		static public void fncChatOpen()
		{
			//SendKeys.Send("{ESC}");
			Win32API.keybd_click(Win32API.VK_ESCAPE);

			//SendKeys.Send("/");
			Win32API.keybd_click(Win32API.VK_DIVIDE);
		}
	}
}
