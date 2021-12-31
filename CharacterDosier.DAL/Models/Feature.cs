namespace CharacterDosier.DAL.Models
{
	public class Feature:BaseModel
	{
		public string Name { get; set; }
		public string Description { get; set; }

		public Character Character { get; set; }
	}

}
