using System;
using System.Collections.Generic;
using System.Windows.Forms;

using MinecraftCommandController.Base;
using MinecraftCommandController.Contents.Minecraft;
using MinecraftCommandController.Contents.Skript;
using MinecraftCommandController.Daos;
using MinecraftCommandController.Entities;
using MinecraftCommandController.Setting;
using MinecraftCommandController.Util;

namespace MinecraftCommandController
{
	public partial class AppMainForm : Form
	{
		public SettingEt settings;
		private McGameMode mcGameMode;
		private McTeleport mcTeleport;
		private McEffect mcEffect;
		private McGameRule mcGameRule;
		private SkList skList;
		private Dictionary<string, Dictionary<string, MccContentPageBase>> dicTools;
		private Dictionary<string, MccContentPageBase> dicMinecraft;
		private Dictionary<string, MccContentPageBase> dicSkript;
		//private Dictionary<string, MccContentPageBase> dicHawkEye;
		private string sSelectedTool;

		public AppSettingForm settingForm;
		public ServerConsoleForm serverConsoleForm;
		public ClientSettingForm clientSettingForm;

		private void init()
		{
			//設定のロード
			settings = SettingDao.LoadSettings();

			dicTools = new Dictionary<string, Dictionary<string, MccContentPageBase>>();

			dicMinecraft = new Dictionary<string, MccContentPageBase>();
			dicSkript = new Dictionary<string, MccContentPageBase>();
			//dicHawkEye = new Dictionary<string, MccContentPageBase>();

			dicTools.Add("Minecraft", dicMinecraft);
			dicTools.Add("Skript", dicSkript);
			//dicTools.Add("HawkEye", dicHawkEye);

			//Minecraft.McGameMode
			mcGameMode = new McGameMode(this);
			mcGameMode.Visible = false;
			panel2.Controls.Add(mcGameMode);
			dicMinecraft.Add("プレイヤー", mcGameMode);
			//Minecraft.McTeleport
			mcTeleport = new McTeleport(this);
			mcTeleport.Visible = false;
			panel2.Controls.Add(mcTeleport);
			dicMinecraft.Add("テレポート", mcTeleport);
			//Minecraft.McEffect
			mcEffect = new McEffect(this);
			mcEffect.Visible = false;
			panel2.Controls.Add(mcEffect);
			dicMinecraft.Add("エフェクト", mcEffect);
			//Minecraft.McGameRule
			mcGameRule = new McGameRule(this);
			mcGameRule.Visible = false;
			panel2.Controls.Add(mcGameRule);
			dicMinecraft.Add("ゲームルール", mcGameRule);

			//Skript.McList
			skList = new SkList(this);
			skList.Visible = false;
			panel2.Controls.Add(skList);
			dicSkript.Add("ファイル一覧", skList);

			settingForm = new AppSettingForm(this);
			serverConsoleForm = new ServerConsoleForm(this);
			clientSettingForm = new ClientSettingForm(this);

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
			toolStripMenuItem7.Enabled = (AppSession.isRunningServer) ? true : false;
			if (!AppSession.isRunningServer && toolStripMenuItem7.Checked)
			{
				toolStripMenuItem6.Checked = true;
				toolStripMenuItem7.Checked = false;
			}

		}

		//コマンド実行
		public void fncExecuteCommand(string cmd)
		{
			if (AppSession.isRunningServer && AppSession.iExecutionMode == 1)
			{
				serverConsoleForm.fncExecuteCommand(cmd);
			}
			else {
				if (AppSession.isSelectedProcess)
				{
					// ウィンドウ指定
					if (TargetWindow.fncActiveTarget(AppSession.TargetProcess))
					{
						TargetWindow.fncExecuteCommand(cmd);
					}
				}
				else
				{
					// ウィンドウ自動検索
					if (TargetWindow.fncActiveTarget())
					{
						TargetWindow.fncExecuteCommand(cmd);
					}
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
			settingForm.StartPosition = FormStartPosition.CenterParent;
			settingForm.ShowDialog();
		}

		private void AppMainForm_Load(object sender, EventArgs e)
		{
			//init();
		}

		private void AppMainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			//サーバーが起動中の場合
			if (AppSession.isRunningServer)
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
			serverConsoleForm.StartPosition = FormStartPosition.Manual;
			serverConsoleForm.Left = this.Left + this.Width;
			serverConsoleForm.Top = this.Top;
			serverConsoleForm.Show();
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			toolStripMenuItem6.Checked = true;
			toolStripMenuItem7.Checked = false;
			AppSession.iExecutionMode = 0;
		}

		private void toolStripMenuItem7_Click(object sender, EventArgs e)
		{
			toolStripMenuItem6.Checked = false;
			toolStripMenuItem7.Checked = true;
			AppSession.iExecutionMode = 1;
		}

		private void toolStripMenuItem10_Click(object sender, EventArgs e)
		{
			clientSettingForm.StartPosition = FormStartPosition.CenterParent;
			clientSettingForm.ShowDialog();
		}
	}
}
