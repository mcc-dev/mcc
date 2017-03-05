using System.Collections.Generic;

namespace MinecraftCommandController.Entities
{
	public class PlayerCollectionEt
	{
		public List<PlayerEt> list { get; set; }

		public PlayerCollectionEt()
		{
		}

		public PlayerCollectionEt(List<PlayerEt> list)
		{
			this.list = list;
		}
	}
}
