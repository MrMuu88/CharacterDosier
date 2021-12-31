using CharacterDosier.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CharacterDosier.DAL.Database.Configurations
{
	public class BaseModelConfiguration<T> : IEntityTypeConfiguration<T> where T :BaseModel
	{
		public virtual void Configure(EntityTypeBuilder<T> builder)
		{
			builder.HasKey(bm => bm.Id);
		}
	}
}
