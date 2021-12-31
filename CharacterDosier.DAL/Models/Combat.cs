namespace CharacterDosier.DAL.Models
{
	public class Combat :BaseModel {
		public int ArmorClass { get; set; }
		public int Initiative { get; set; }
		public int Speed { get; set; }
	}

}
