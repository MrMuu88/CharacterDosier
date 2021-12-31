namespace CharacterDosier.DAL.Models
{
	public class Apperance:BaseModel
	{
		public byte[] Image { get; set; }
		public int Age { get; set; }
		public int Height { get; set; }
		public int Weight { get; set; }
		public string Eyes { get; set; }
		public string Skin { get; set; }
		public string Hail { get; set; }

		public Character Character { get; set; }
		public int CharacterId { get; internal set; }
	}
}
