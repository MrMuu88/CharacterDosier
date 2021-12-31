using System.Collections.Generic;

namespace CharacterDosier.DAL.Models
{
	public class Personality:BaseModel
	{
		public List<string> Traits { get; private set; } = new();
		public List<string> Ideals { get; private set; } = new();
		public List<string> Bonds { get; private set; } = new();
		public List<string> Flaws { get; private set; } = new();
		public Character Character { get; set; }
		public int CharacterId { get; internal set; }
	}
}
