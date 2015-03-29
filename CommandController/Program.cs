using System;
using System.Windows.Forms;

namespace CommandController
{
	static class Program
	{
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AppMainForm());

		}
	}
}
