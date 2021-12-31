using CharacterDosier.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CharacterDosier.DAL
{
	public class CharacterDbContext : DbContext
	{
		public DbSet<Character> Characters { get; set; }

		public DbSet<PersonalityTraits> PersonalityTraits { get; set; }
		public DbSet<Apperance> Apperances { get; set; }
		public DbSet<CombatAbilities> CombatAbilities { get; set; }
		public DbSet<Health> Healths { get; set; }
		public SpellCasting spellCastings { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Equipment> Equipments{get;set;}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
