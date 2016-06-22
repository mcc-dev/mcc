﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MinecraftCommandController.Daos;
using MinecraftCommandController.Entities;
using MinecraftCommandController.Setting;
using MinecraftCommandController.Util;

namespace MinecraftCommandController
{
	public partial class AppMainForm : Form
	{
		public SettingEt settings;
		private Minecraft.McGameMode mcGameMode;
		//private Minecraft.McServerConsole mcServerConsole;
		private Skript.SkList skList;
		private Dictionary<string, Dictionary<string, UserControl>> dicTools;
		private Dictionary<string, UserControl> dicMinecraft;
		private Dictionary<string, UserControl> dicSkript;
		private Dictionary<string, UserControl> dicHawkEye;
		private string sSelectedTool;
		public bool bRunningServer = false;
		public int iExecutionMode = 0;

		public AppSettingForm settingForm;
		public ServerConsoleForm serverConsoleForm;

		private void init()
		{
			//設定のロード
			settings = SettingDao.LoadSettings();

			dicTools = new Dictionary<string, Dictionary<string, UserControl>>();

			dicMinecraft = new Dictionary<string, UserControl>();
			dicSkript = new Dictionary<string, UserControl>();
			dicHawkEye = new Dictionary<string, UserControl>();

			dicTools.Add("Minecraft", dicMinecraft);
			dicTools.Add("Skript", dicSkript);
			dicTools.Add("HawkEye", dicHawkEye);

			//Minecraft.McGameMode
			mcGameMode = new Minecraft.McGameMode(this);
			mcGameMode.Visible = false;
			panel2.Controls.Add(mcGameMode);
			dicMinecraft.Add("プレイヤー", mcGameMode);

			//Minecraft.McServerConsole
			//mcServerConsole = new Minecraft.McServerConsole(this);
			//mcServerConsole.Visible = false;
			//panel2.Controls.Add(mcServerConsole);
			//dicMinecraft.Add("サーバー", mcServerConsole);

			//Skript.McList
			skList = new Skript.SkList(this);
			skList.Visible = false;
			panel2.Controls.Add(skList);
			dicSkript.Add("ファイル一覧", skList);

			settingForm = new AppSettingForm(this);
			serverConsoleForm = new ServerConsoleForm(this);

			if (settings.UseServer)
			{
				toolStripMenuItem8.Enabled = true;
			}
		}

		//ツール切り替え
		private void fncChangeTool(ToolStripButton tool)
		{
			listBox1.Items.Clear();
			sSelectedTool = tool.Text;

			if (dicTools.ContainsKey(tool.Text))
			{
				foreach (string key in dicTools[tool.Text].Keys)
				{
					listBox1.Items.Add(key);
				}
			}

			fncChangeContent();
		}

		//コンテンツ切り替え
		private void fncChangeContent()
		{
			//表示されているコントロールを非表示に
			foreach (var tool in dicTools.Values)
			{
				foreach (var content in tool.Values)
				{
					content.Visible = false;
				}
			}

			if (sSelectedTool == null)
			{
				return;
			}

			//選択されてなければそのまま終了
			if (listBox1.SelectedItem == null)
			{
				return;
			}

			//選択されたコントロールを表示させる
			if (dicTools.ContainsKey(sSelectedTool))
			{
				if (dicTools[sSelectedTool].ContainsKey(listBox1.SelectedItem.ToString()))
				{
					dicTools[sSelectedTool][listBox1.SelectedItem.ToString()].Visible = true;
				}
			}
		}

		//設定反映
		public void fncApplySettings()
		{
			toolStripMenuItem8.Enabled = (settings.UseServer) ? true : false;
			toolStripMenuItem7.Enabled = (bRunningServer) ? true : false;
			if (!bRunningServer && toolStripMenuItem7.Checked)
			{
				toolStripMenuItem6.Checked = true;
				toolStripMenuItem7.Checked = false;
			}

		}

		//コマンド実行
		public void fncExecuteCommand(string cmd)
		{
			if (bRunningServer)
			{
				serverConsoleForm.fncExecuteCommand(cmd);
			}
			else {
				if (TargetWindow.fncActiveTarget())
				{
					TargetWindow.fncExecuteCommand(cmd);
				}
			}
		}

		//デザイナーからの半自動生成
		public AppMainForm()
		{
			InitializeComponent();
			init();
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			//AppSettingForm form = new AppSettingForm();
			settingForm.ShowDialog();
		}

		private void AppMainForm_Load(object sender, EventArgs e)
		{
			//init();
		}

		private void AppMainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			//サーバーが起動中の場合
			if (bRunningServer)
			{
				if (e.CloseReason == CloseReason.UserClosing)
				{
					// × ボタンをキャンセル
					e.Cancel = true;
					MessageBox.Show("終了する前にサーバーを停止する必要があります。");
					serverConsoleForm.Show();
				}
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			fncChangeContent();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			fncChangeTool((ToolStripButton)sender);
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			fncChangeTool((ToolStripButton)sender);
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			fncChangeTool((ToolStripButton)sender);
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			serverConsoleForm.Show();
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			toolStripMenuItem6.Checked = true;
			toolStripMenuItem7.Checked = false;
			iExecutionMode = 0;
		}

		private void toolStripMenuItem7_Click(object sender, EventArgs e)
		{
			toolStripMenuItem6.Checked = false;
			toolStripMenuItem7.Checked = true;
			iExecutionMode = 1;
		}
	}
}