namespace MinecraftCommandController.Entities
{
	public class GameRuleEt
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public int Type { get; set; }
		public string Default { get; set; }

		public GameRuleEt()
		{
			Name = "";
			Description = "";
			Type = 0;
			Default = "";
		}
	}
}
