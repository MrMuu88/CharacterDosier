using System;
using System.Collections.Generic;

namespace CharacterDosier.DAL.Models
{
	public partial class Character : BaseModel
	{
		public string Name { get; set; }
		public int Level { get; set; }
		public string Race { get; set; }
		public string Class { get; set; }
		public int Experience { get; set; }
		public string Background { get; set; }
		public string Aligment { get; set; }

		public int Inpiration { get; set; }
		public int Proficency { get; set; }
		public PersonalityTraits Traits { get; set; }
		public Apperance Apperance {get;set;}

		public Combat Combat { get; internal set; } = new();
		public Health Health { get; internal set; } = new();
		public SpellCasting SpellCasting { get; internal set; } = new();

		
		public List<Feature> Features { get; private set; } = new();
		public List<string> Proficiencies { get; private set; } = new();
		public List<string> Languages { get; private set; } = new();

		public IReadOnlyDictionary<Ability, AbilityModel> Abilities { get => abilities; }

		//JSON field in DB
		internal Dictionary<Ability, AbilityModel> abilities = new() {
			{ Ability.Strength, new AbilityModel(Ability.Strength) },
			{ Ability.Dexterity, new AbilityModel(Ability.Dexterity) },
			{ Ability.Constitution, new AbilityModel(Ability.Constitution) },
			{ Ability.Intelligence, new AbilityModel(Ability.Intelligence) },
			{ Ability.Wisdom, new AbilityModel(Ability.Wisdom) },
			{ Ability.Charisma, new AbilityModel(Ability.Charisma) },
			{ Ability.Perception, new AbilityModel(Ability.Perception) }
		};

		public List<Skill> Skills { get; private set; } = new();

		public Wealth Wealth { get; internal set; } = new();

		public List<Equipment> Equipment { get;internal set; } = new();
	}

}
