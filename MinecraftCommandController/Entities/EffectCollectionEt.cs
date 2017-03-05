using System.Collections.Generic;

namespace MinecraftCommandController.Entities
{
	public class EffectCollectionEt
	{
		public List<EffectEt> list { get; set; }

		public EffectCollectionEt()
		{
		}

		public EffectCollectionEt(List<EffectEt> list)
		{
			this.list = list;
		}
	}
}
