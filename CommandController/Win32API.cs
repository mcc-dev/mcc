using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;

namespace CommandController
{
	public static class Win32API
	{
		//ウィンドウをアクティブにする
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		//キーボードイベント
		[DllImport("user32.dll")]
		public static extern uint keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

		public const int KEYEVENTF_KEYDOWN = 0x0; // キーを押す
		public const int KEYEVENTF_KEYUP = 0x2; // キーを離す

		public const int VK_RETURN = 0x0D; //Enter
		public const int VK_CONTROL = 0x11; //Control
		public const int VK_MENU = 0x12; //Alt
		public const int VK_ESCAPE = 0x1B; //Esc
		public const int VK_SPACE = 0x20; //Space
		public const int VK_A = 0x41;
		public const int VK_C = 0x43;
		public const int VK_E = 0x45;
		public const int VK_P = 0x50;
		public const int VK_V = 0x56;
		public const int VK_X = 0x58;
		public const int VK_DIVIDE = 0xBF;

		public static void keybd_click(int key)
		{
			keybd_event((byte)key, 0, KEYEVENTF_KEYDOWN, (UIntPtr)0);
			Thread.Sleep(50);
			keybd_event((byte)key, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
			Thread.Sleep(50);
		}

		public static void keybd_paste()
		{
			keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYDOWN, (UIntPtr)0);
			Thread.Sleep(50);
			keybd_event(VK_V, 0, KEYEVENTF_KEYDOWN, (UIntPtr)0);
			Thread.Sleep(50);
			keybd_event(VK_V, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
			Thread.Sleep(50);
			keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
			Thread.Sleep(50);
		}

		public static void keybd_paste_cmd()
		{
			keybd_event(VK_MENU, 0, KEYEVENTF_KEYDOWN, (UIntPtr)0);
			Thread.Sleep(200);
			keybd_event(VK_SPACE, 0, KEYEVENTF_KEYDOWN, (UIntPtr)0);
			Thread.Sleep(200);
			keybd_event(VK_SPACE, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
			Thread.Sleep(200);
			keybd_event(VK_MENU, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
			Thread.Sleep(200);
			keybd_click(VK_E);
			keybd_click(VK_P);
		}
	}
}
