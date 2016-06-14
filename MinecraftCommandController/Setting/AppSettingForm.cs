using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftCommandController.Setting
{
	public partial class AppSettingForm : Form
	{
		public SettingDataEt settings;

		private Dictionary<string, UserControl> dicSettingPage;
		private PageServer pageServer;

		private void init()
		{
			settings = SettingAction.ReferSettings();
			dicSettingPage = new Dictionary<string, UserControl>();

			//サーバー連携
			pageServer = new PageServer(this);
			//pageServer.Visible = false;
			panel1.Controls.Add(pageServer);
			dicSettingPage.Add("サーバー連携", pageServer);
		}

		public AppSettingForm(SettingDataEt settings)
		{
			InitializeComponent();
			//this.settings = settings;
			init();
		}

		//デザイナーからの半自動生成
		public AppSettingForm() //未使用
		{
			InitializeComponent();
			init();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			pageServer.fncSetData();
			SettingAction.SaveSettings(settings);
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
