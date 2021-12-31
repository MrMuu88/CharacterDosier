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
			modelBuilder.Entity<Character>().Ignore(ch => ch.Abilities);
			modelBuilder.Entity<Character>().Ignore(ch => ch.abilities);
			modelBuilder.Entity<Character>().Ignore(ch => ch.Proficiencies);
			modelBuilder.Entity<Character>().Ignore(ch => ch.Languages);
			modelBuilder.Entity<Character>().Ignore(ch => ch.Skills);
			modelBuilder.Entity<Character>().Ignore(ch => ch.Wealth);
			modelBuilder.Entity<Character>().Ignore(ch => ch.Weapons);
			modelBuilder.Entity<Character>().Ignore(ch => ch.Armor);

			modelBuilder.Entity<Character>()
				.HasOne(ch => ch.Apperance)
				.WithOne(a => a.Character)
				.HasForeignKey<Apperance>(a=> a.CharacterId);
			modelBuilder.Entity<Character>()
				.HasOne(ch => ch.Personality)
				.WithOne(pt => pt.Character)
				.HasForeignKey<Personality>(pt=> pt.CharacterId);
			modelBuilder.Entity<Character>()
				.HasOne(ch => ch.Combat)
				.WithOne(cmb => cmb.Character)
				.HasForeignKey<CombatAbilities>(cmb=> cmb.CharacterId);
			modelBuilder.Entity<Character>()
				.HasOne(ch => ch.Health)
				.WithOne(hp => hp.Character)
				.HasForeignKey<Health>(hp=> hp.CharacterId);
			modelBuilder.Entity<Character>()
				.HasOne(ch => ch.Health)
				.WithOne(hp => hp.Character)
				.HasForeignKey<Health>(hp=> hp.CharacterId);
			modelBuilder.Entity<Character>()
				.HasOne(ch => ch.SpellCasting)
				.WithOne(sc => sc.Character)
				.HasForeignKey<SpellCasting>(sc=> sc.CharacterId);

			modelBuilder.Entity<Personality>().Ignore(pt => pt.Traits);
			modelBuilder.Entity<Personality>().Ignore(pt => pt.Bonds);
			modelBuilder.Entity<Personality>().Ignore(pt => pt.Flaws);
			modelBuilder.Entity<Personality>().Ignore(pt => pt.Ideals);

			modelBuilder.Entity<SpellCasting>().Ignore(sc => sc.Ability);

		}
	}
}
