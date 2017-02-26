using System.Windows.Forms;

using MinecraftCommandController.Base;

namespace MinecraftCommandController.Minecraft
{
	public partial class McTeleport : MccContentPageBase
	{
		private AppMainForm appMainForm; //メインフォームの参照

		//コンストラクタ
		public McTeleport(AppMainForm form)
		{
			this.appMainForm = form;
			InitializeComponent();
			init();
		}

		//初期処理
		private void init()
		{
		}

		/* ***** 以下、デザイナからの半自動生成 ***** */
		//未使用コンストラクタ
		public McTeleport()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			string from = playerSelect1.fncGetPlayerName();
			string to = playerSelect2.fncGetPlayerName();
			if (from == "")
			{
				MessageBox.Show("「自身」が未入力です。");
				return;
			}
			if (to == "")
			{
				MessageBox.Show("「誰に」が未入力です。");
				return;
			}
			string cmd = "tp " + from + " " + to;
			appMainForm.fncExecuteCommand(cmd);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			string from = playerSelect3.fncGetPlayerName();
			string to = playerSelect1.fncGetPlayerName();
			if (from == "")
			{
				MessageBox.Show("「誰を」が未入力です。");
				return;
			}
			if (to == "")
			{
				MessageBox.Show("「自身」が未入力です。");
				return;
			}
			string cmd = "tp " + from + " " + to;
			appMainForm.fncExecuteCommand(cmd);
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			string from = playerSelect4.fncGetPlayerName();
			string to = playerSelect5.fncGetPlayerName();
			if (from == "")
			{
				MessageBox.Show("「誰を」が未入力です。");
				return;
			}
			if (to == "")
			{
				MessageBox.Show("「誰に」が未入力です。");
				return;
			}
			string cmd = "tp " + from + " " + to;
			appMainForm.fncExecuteCommand(cmd);
		}
	}
}
