using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APICopaDoMundo.Contexto.Mappings
{
	public class PotePaisMapping : IEntityTypeConfiguration<PotePais>
	{
		public void Configure(EntityTypeBuilder<PotePais> builder)
		{


			builder.Property(p => p.IdPote);
			builder.Property(p => p.IdPais);


			builder.HasOne(p => p.Potes)
				.WithMany()
				.HasForeignKey(p => p.IdPote);


			builder.HasOne(p => p.Pais)
				.WithMany()
				.HasForeignKey(p => p.IdPais);

			builder.ToTable(name: "POTEPAIS", schema: "COPADOMUNDO");
		}

	}
}
