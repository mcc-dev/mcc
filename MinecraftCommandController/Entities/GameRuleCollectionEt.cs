using System.Collections.Generic;

namespace MinecraftCommandController.Entities
{
	public class GameRuleCollectionEt
	{
		public List<GameRuleEt> list { get; set; }

		public GameRuleCollectionEt()
		{
		}

		public GameRuleCollectionEt(List<GameRuleEt> list)
		{
			this.list = list;
		}
	}
}
