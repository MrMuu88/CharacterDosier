namespace CharacterDosier.DAL.Models
{
	public class Health:BaseModel {
		public int MaxHP { get; set; }
		public int CurrentHP { get; set; }
		public int TemporaryHP { get; set; }
		public DiceType DiceType { get; set; }
		public int TotalHitDice {get;set;}
		public int RemainingHitDice {get;set;}
		public int DeathSaves { get; set; }
	}

}
