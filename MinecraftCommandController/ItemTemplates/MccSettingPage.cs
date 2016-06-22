using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using MinecraftCommandController.Entities;
using MinecraftCommandController.Setting;

namespace MinecraftCommandController.ItemTemplates
{
	public partial class MccSettingPage : UserControl
	{
		private AppSettingForm settingForm; //設定フォームの参照
		private SettingEt settings; //設定エンティティ

		//コンストラクタ
		public MccSettingPage(AppSettingForm form)
		{
			this.settingForm = form;
			InitializeComponent();
			init();
		}

		//初期処理
		private void init()
		{
		}

		//入力内容を設定エンティティに反映
		public void fncSetData()
		{
		}

		/* ***** 以下、デザイナからの半自動生成 ***** */
		//未使用コンストラクタ
		public MccSettingPage()
		{
			InitializeComponent();
		}
	}
}
