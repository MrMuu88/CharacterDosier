using CharacterDosier.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CharacterDosier.DAL.Database.Configurations
{
	public class SpellCastingConfiguration : BaseModelConfiguration<SpellCasting> {
		public override void Configure(EntityTypeBuilder<SpellCasting> builder)
		{
			base.Configure(builder);
			builder.Ignore(sc => sc.Ability);
		}
	}
}
