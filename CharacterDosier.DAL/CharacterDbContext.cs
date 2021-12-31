using CharacterDosier.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CharacterDosier.DAL
{
	public class CharacterDbContext : DbContext
	{
		public DbSet<Character> Characters { get; set; }

		public DbSet<Personality> PersonalityTraits { get; set; }
		public DbSet<Apperance> Apperances { get; set; }
		public DbSet<CombatAbilities> CombatAbilities { get; set; }
		public DbSet<Health> Healths { get; set; }
		public DbSet<SpellCasting> spellCastings { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Equipment> Equipments{get;set;}

		public CharacterDbContext():base()
		{
		}

		public CharacterDbContext(DbContextOptions<CharacterDbContext> options):base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(CharacterDbContext).Assembly);

		}
	}
}
