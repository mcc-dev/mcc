using MinecraftCommandController.Base;
using MinecraftCommandController.Setting;

namespace MinecraftCommandController.ItemTemplates
{
	public partial class MccSettingPage : MccSettingPageBase
	{
		private AppSettingForm settingForm; //設定フォームの参照

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
		public override void fncSetData()
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
