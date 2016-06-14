using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

using MinecraftCommandController.Setting;

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
				switch (SettingAction.ReferSettings().ExcuteType)
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

		/*
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
		*/

		/*
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
		*/

		/*
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
		*/

		/*
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
		*/

		static public void fncActiveTarget()
		{
			Process p = fncFindTarget();
			if (p == null)
			{
				MessageBox.Show("画面が見つかりません。");
				return;
			}
			Win32API.SetForegroundWindow(p.MainWindowHandle);
			Thread.Sleep(50);
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
			switch (SettingAction.ReferSettings().ExcuteType)
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
