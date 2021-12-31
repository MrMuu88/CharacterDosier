namespace CharacterDosier.DAL.Models
{
	public class SpellCasting :BaseModel{
		public Ability Ability { get; set; }
		public int SpellSaveDC { get; set; } // 8+ ProficencyBous + AbilityModifier
		public int SpellAttackBonus { get; set; }

		public Character Character { get; set; }
		public int CharacterId { get; internal set; }
	}

}
