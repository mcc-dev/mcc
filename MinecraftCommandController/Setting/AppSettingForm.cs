using System;
using System.Collections.Generic;
using System.Windows.Forms;

using MinecraftCommandController.Base;
using MinecraftCommandController.Daos;
using MinecraftCommandController.Entities;

namespace MinecraftCommandController.Setting
{
	public partial class AppSettingForm : Form
	{
		public SettingEt settings;
		private AppMainForm appMainForm;

		private Dictionary<string, MccSettingPageBase> dicSettingPage;
		private PageServer pageServer;

		private void init()
		{
			settings = SettingDao.ReferSettings();
			dicSettingPage = new Dictionary<string, MccSettingPageBase>();

			//サーバー連携
			pageServer = new PageServer(this);
			//pageServer.Visible = false;
			panel1.Controls.Add(pageServer);
			dicSettingPage.Add("サーバー連携", pageServer);
		}

		public AppSettingForm(AppMainForm form)
		{
			InitializeComponent();
			appMainForm = form;
			init();
		}

		//デザイナーからの半自動生成
		public AppSettingForm() //未使用
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//各ページの設定情報を設定エンティティへ反映
			foreach (var page in dicSettingPage.Values)
			{
				page.fncSetData();
			}
			//pageServer.fncSetData();
			SettingDao.SaveSettings(settings);
			appMainForm.fncApplySettings();
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
