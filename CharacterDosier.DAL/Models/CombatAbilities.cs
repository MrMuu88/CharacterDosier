namespace CharacterDosier.DAL.Models
{
	public class CombatAbilities :BaseModel {
		public int ArmorClass { get; set; }
		public int Initiative { get; set; }
		public int Speed { get; set; }
		public Character Character { get; set; }
		public int CharacterId { get; internal set; }
	}

}
