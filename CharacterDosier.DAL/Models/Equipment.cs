namespace CharacterDosier.DAL.Models
{
	public class Equipment
	{
		public string Name { get; set; }
		public int Weight { get; set; }
		public int Amount { get; set; }
		public Wealth Value { get; set; }
		public Character Character { get; set; }
	}

}
