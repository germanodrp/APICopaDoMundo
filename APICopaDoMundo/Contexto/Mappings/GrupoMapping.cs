using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APICopaDoMundo.Contexto.Mappings
{
	public class GrupoMapping : IEntityTypeConfiguration<Grupo>
	{
		public void Configure(EntityTypeBuilder<Grupo> builder)
		{
			builder.HasKey(g => g.Id);

			builder.Property(g => g.Nome);

			builder.ToTable(name: "GRUPO", schema: "COPADOMUNDO");
		}
	}
}
