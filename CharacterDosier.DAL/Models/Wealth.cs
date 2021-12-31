namespace CharacterDosier.DAL.Models
{
	public class Wealth:BaseModel
	{
		public int Platinum { get; set; }
		public int Elerium { get; set; }
		public int Gold { get; set; }
		public int Silver { get; set; }
		public int Copper { get; set; }
	}

}
