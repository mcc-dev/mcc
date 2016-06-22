using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

using MinecraftCommandController.Daos;

namespace MinecraftCommandController.Util
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

		static public List<Process> fncFindTargetAll()
		{
			List<Process> lProcess = new List<Process>();
			return lProcess;
		}

		static public Process fncFindTarget()
		{
			bool isFound = false;
			Process process = null;

			foreach (Process p in Process.GetProcesses())
			{
				switch (SettingDao.ReferSettings().ExcuteType)
				{
					case 1:
						if (p.ProcessName == "java" && 0 <= p.MainWindowTitle.IndexOf("Minecraft 1"))
						{
							isFound = true;
						}
						else if (p.ProcessName == "javaw" && 0 <= p.MainWindowTitle.IndexOf("Minecraft 1"))
						{
							isFound = true;
						}
						break;
					case 4:
						if (p.ProcessName == "notepad" && 0 <= p.MainWindowTitle.IndexOf("メモ帳"))
						{
							isFound = true;
						}
						break;
					default:
						break;
				}
				if (isFound)
				{
					process = p;
					break;
				}
			}
			return process;
		}

		static public bool fncActiveTarget()
		{
			Process p = fncFindTarget();
			if (p == null)
			{
				MessageBox.Show("画面が見つかりません。");
				return false;
			}
			Win32API.SetForegroundWindow(p.MainWindowHandle);
			Thread.Sleep(50);
			return true;
		}

		static public void fncChatOpen()
		{
			Win32API.keybd_click(Win32API.VK_ESCAPE);
			Win32API.keybd_click(Win32API.VK_T);
		}

		static public void fncCommandOpen()
		{
			Win32API.keybd_click(Win32API.VK_ESCAPE);
			Win32API.keybd_click(Win32API.VK_DIVIDE);
		}

		static public void fncExecuteCommand(string cmd)
		{
			Clipboard.SetDataObject(cmd);
			switch (SettingDao.ReferSettings().ExcuteType)
			{
				case 1: //クライアント
					fncCommandOpen();
					break;
				case 4: //メモ帳
					break;
				default:
					return;
			}
			Win32API.keybd_paste();
			Win32API.keybd_click(Win32API.VK_RETURN);
		}
	}
}
