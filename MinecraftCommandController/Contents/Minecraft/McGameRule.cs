using MinecraftCommandController.Base;
using MinecraftCommandController.Daos;
using MinecraftCommandController.Entities;

namespace MinecraftCommandController.Contents.Minecraft
{
	public partial class McGameRule : MccContentPageBase
	{
		private AppMainForm appMainForm; //メインフォームの参照

		// コンストラクタ
		public McGameRule(AppMainForm form)
		{
			this.appMainForm = form;
			InitializeComponent();
			init();
		}

		// 初期処理
		private void init()
		{
			// エフェクトデータ読込
			GameRuleCollectionEt grc = new GameRuleCollectionEt();
			GameRuleDao dao = new GameRuleDao();
			grc = dao.LoadXml(@".\Resource\gamerules.xml");
		}

		/* ***** 以下、デザイナからの半自動生成 ***** */
		// 未使用コンストラクタ
		public McGameRule()
		{
			InitializeComponent();
		}
	}
}
