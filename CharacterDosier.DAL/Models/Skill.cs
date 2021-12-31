namespace CharacterDosier.DAL.Models
{
	public class Skill{ 

		public Ability Ability { get; private set; }
		public string Name { get; set; }

		public Skill(Ability ability,string Name)
		{
			this.Name = Name;
		}
	}

}
