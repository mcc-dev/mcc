using System.Diagnostics;

namespace MinecraftCommandController
{
	public static class AppSession
	{
		public static bool isRunningServer { get; set; } = false;
		public static int iExecutionMode { get; set; } = 0;
		public static int iExecutionType { get; set; } = 1;
		public static bool isSelectedProcess { get; set; } = false;
		public static Process TargetProcess { get; set; } = null;
	}
}
