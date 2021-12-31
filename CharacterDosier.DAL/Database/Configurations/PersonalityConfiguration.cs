using CharacterDosier.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CharacterDosier.DAL.Database.Configurations
{
	public class PersonalityConfiguration : BaseModelConfiguration<Personality> {

		public override void Configure(EntityTypeBuilder<Personality> builder)
		{
			base.Configure(builder);
			builder.Property(pt => pt.Traits).HasConversion(
				 toDb => JsonConvert.SerializeObject(toDb, Formatting.Indented),
				 fromDb => JsonConvert.DeserializeObject<List<string>>(fromDb));

			builder.Property(pt => pt.Bonds).HasConversion(
				 toDb => JsonConvert.SerializeObject(toDb, Formatting.Indented),
				 fromDb => JsonConvert.DeserializeObject<List<string>>(fromDb));

			builder.Property(pt => pt.Flaws).HasConversion(
				 toDb => JsonConvert.SerializeObject(toDb, Formatting.Indented),
				 fromDb => JsonConvert.DeserializeObject<List<string>>(fromDb));

			builder.Property(pt => pt.Ideals).HasConversion(
				 toDb => JsonConvert.SerializeObject(toDb, Formatting.Indented),
				 fromDb => JsonConvert.DeserializeObject<List<string>>(fromDb));
		}
	}
}
