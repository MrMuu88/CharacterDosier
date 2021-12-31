using CharacterDosier.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CharacterDosier.DAL.Database.Configurations
{

	public class CharacterConfiguration : BaseModelConfiguration<Character>
	{
		public override void Configure(EntityTypeBuilder<Character> builder)
		{
			base.Configure(builder);
			builder.Ignore(ch => ch.Abilities);
			builder.Ignore(ch => ch.Weapons);
			builder.Ignore(ch => ch.Armor);

			builder.Property(ch => ch._Abilities).HasConversion(
				toDb => JsonConvert.SerializeObject(toDb, Formatting.Indented),
				fromDb => JsonConvert.DeserializeObject<Dictionary<Ability, AbilityModel>>(fromDb));

			builder.Property(ch => ch.Proficiencies).HasConversion(
				toDb => JsonConvert.SerializeObject(toDb, Formatting.Indented),
				fromDb => JsonConvert.DeserializeObject<List<string>>(fromDb));
			
			builder.Property(ch => ch.Languages).HasConversion(
				toDb => JsonConvert.SerializeObject(toDb, Formatting.Indented),
				fromDb => JsonConvert.DeserializeObject<List<string>>(fromDb));

			builder.Property(ch => ch.Skills).HasConversion(
				toDb => JsonConvert.SerializeObject(toDb, Formatting.Indented),
				fromDb => JsonConvert.DeserializeObject<List<Skill>>(fromDb));

			builder.Property(ch => ch.Wealth).HasConversion(
				toDb => JsonConvert.SerializeObject(toDb, Formatting.Indented),
				fromDb => JsonConvert.DeserializeObject<Wealth>(fromDb));


			builder.HasOne(ch => ch.Apperance)
				.WithOne(a => a.Character)
				.HasForeignKey<Apperance>(a => a.CharacterId);

			builder.HasOne(ch => ch.Personality)
				.WithOne(pt => pt.Character)
				.HasForeignKey<Personality>(pt => pt.CharacterId);

			builder.HasOne(ch => ch.Combat)
				.WithOne(cmb => cmb.Character)
				.HasForeignKey<CombatAbilities>(cmb => cmb.CharacterId);

			builder.HasOne(ch => ch.Health)
				.WithOne(hp => hp.Character)
				.HasForeignKey<Health>(hp => hp.CharacterId);

			builder.HasOne(ch => ch.Health)
				.WithOne(hp => hp.Character)
				.HasForeignKey<Health>(hp => hp.CharacterId);

			builder.HasOne(ch => ch.SpellCasting)
				.WithOne(sc => sc.Character)
				.HasForeignKey<SpellCasting>(sc => sc.CharacterId);
		}
	}
}
