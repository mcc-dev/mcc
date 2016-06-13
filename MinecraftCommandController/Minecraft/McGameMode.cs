using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using MinecraftCommandController.Util;

namespace MinecraftCommandController.Minecraft
{
	public partial class McGameMode : UserControl
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

		public McGameMode()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string cmd = "gamemode 0";
			TargetWindow.fncActiveTarget(appMainForm.settings);
			TargetWindow.fncExecuteCommand(cmd, appMainForm.settings);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string cmd = "gamemode 1";
			TargetWindow.fncActiveTarget(appMainForm.settings);
			TargetWindow.fncExecuteCommand(cmd, appMainForm.settings);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string cmd = "gamemode 2";
			TargetWindow.fncActiveTarget(appMainForm.settings);
			TargetWindow.fncExecuteCommand(cmd, appMainForm.settings);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string cmd = "gamemode 3";
			TargetWindow.fncActiveTarget(appMainForm.settings);
			TargetWindow.fncExecuteCommand(cmd, appMainForm.settings);
		}
	}
}
