using CharacterDosier.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CharacterDosier.DAL.Database.Configurations
{
	public class PersonalityConfiguration : BaseModelConfiguration<Personality> {

		public override void Configure(EntityTypeBuilder<Personality> builder)
		{
			base.Configure(builder);
			builder.Ignore(pt => pt.Traits);
			builder.Ignore(pt => pt.Bonds);
			builder.Ignore(pt => pt.Flaws);
			builder.Ignore(pt => pt.Ideals);
		}
	}
}
