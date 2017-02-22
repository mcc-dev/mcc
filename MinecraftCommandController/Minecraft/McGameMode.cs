using System;
using System.Windows.Forms;

using MinecraftCommandController.Base;

namespace MinecraftCommandController.Minecraft
{
	public partial class McGameMode : MccContentPageBase
	{
		private AppMainForm appMainForm;

		public McGameMode(AppMainForm form)
		{
			this.appMainForm = form;
			InitializeComponent();
			init();
		}

		private void init()
		{
		}

		private bool fncTargetIsEmpty(string player)
		{
			if (player == "")
			{
				MessageBox.Show("対象IDを指定してください。");
				return true;
			}
			else
			{
				return false;
			}
		}

		public McGameMode()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string player = playerSelect1.fncGetPlayerName();
			if (fncTargetIsEmpty(player))
			{
				return;
			}
			string cmd = "gamemode 0 " + player;
			appMainForm.fncExecuteCommand(cmd);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string player = playerSelect1.fncGetPlayerName();
			if (fncTargetIsEmpty(player))
			{
				return;
			}
			string cmd = "gamemode 1 " + player;
			appMainForm.fncExecuteCommand(cmd);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string player = playerSelect1.fncGetPlayerName();
			if (fncTargetIsEmpty(player))
			{
				return;
			}
			string cmd = "gamemode 2 " + player;
			appMainForm.fncExecuteCommand(cmd);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string player = playerSelect1.fncGetPlayerName();
			if (fncTargetIsEmpty(player))
			{
				return;
			}
			string cmd = "gamemode 3 " + player;
			appMainForm.fncExecuteCommand(cmd);
		}
	}
}
