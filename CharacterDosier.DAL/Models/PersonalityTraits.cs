using System.Collections.Generic;

namespace CharacterDosier.DAL.Models
{
	public partial class Character:BaseModel
	{
		public class PersonalityTraits { 
			public List<string> Traits { get; private set; } = new();
			public List<string> Ideals { get; private set; } = new();
			public List<string> Bonds { get; private set; } = new();
			public List<string> Flaws { get; private set; } = new();
		}
	}

}
