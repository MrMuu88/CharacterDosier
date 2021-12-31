using System.Collections.Generic;

namespace CharacterDosier.DAL.Models
{
	public class PersonalityTraits:BaseModel
	{
		public List<string> Traits { get; private set; } = new();
		public List<string> Ideals { get; private set; } = new();
		public List<string> Bonds { get; private set; } = new();
		public List<string> Flaws { get; private set; } = new();
		public Character character { get; set; }
	}
}
