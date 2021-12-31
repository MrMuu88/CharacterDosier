namespace CharacterDosier.DAL.Models
{
	public class Skill{ 

		public AbilityModel Ability { get; private set; }
		public string Name { get; set; }
		public int Modifier { get => Ability.Modifier; }

		public Skill(AbilityModel ability,string Name)
		{
			Ability = ability;
			this.Name = Name;
		}
	}

}
