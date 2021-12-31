using CharacterDosier.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CharacterDosier.DAL.Database.Configurations
{

	public class CharacterConfiguration : BaseModelConfiguration<Character>
	{
		public override void Configure(EntityTypeBuilder<Character> builder)
		{
			base.Configure(builder);
			builder.Ignore(ch => ch.Abilities);
			builder.Ignore(ch => ch.abilities);
			builder.Ignore(ch => ch.Proficiencies);
			builder.Ignore(ch => ch.Languages);
			builder.Ignore(ch => ch.Skills);
			builder.Ignore(ch => ch.Wealth);
			builder.Ignore(ch => ch.Weapons);
			builder.Ignore(ch => ch.Armor);

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
