namespace CharacterDosier.DAL.Models
{
	public class Weapon :Equipment
	{
		public int AttackBonus { get; set; }
		public DiceType DiceType { get; set; }
		public int Damage { get; set; } // amount of dices
		public string DamageType { get; set; } // should be an enum
	}

}
