using System;

namespace CharacterDosier.DAL.Models
{
	public class AbilityModel {
		public Ability Type { get; internal set; }
		public int Value { get; set; }
		public int Modifier { get => (int)Math.Floor((decimal) (Value - 10) / 2); }
		public bool HasSavingThrow { get; set; }

		internal AbilityModel(Ability type,int value = 10,bool hasSaving=false)
		{
			Type = type;
			Value = value;
			HasSavingThrow = hasSaving;
		}
	}

}
