using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MinecraftCommandController.ItemTemplates
{
	public partial class MccContentPage : UserControl
	{
		private AppMainForm appMainForm; //メインフォームの参照

		//コンストラクタ
		public MccContentPage(AppMainForm form)
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
		public MccContentPage()
		{
			InitializeComponent();
		}
	}
}
