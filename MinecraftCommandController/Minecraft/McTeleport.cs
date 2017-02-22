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
	}
}
