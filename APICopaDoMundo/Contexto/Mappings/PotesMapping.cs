using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APICopaDoMundo.Contexto.Mappings
{
    public class PotesMapping: IEntityTypeConfiguration<Potes>
	{
		public void Configure(EntityTypeBuilder<Potes> builder)
		{
			builder.HasKey(p => p.IdPote);

			builder.Property(c => c.Descricao);


			builder.ToTable(name: "POTE", schema: "COPADOMUNDO");
		}
	}
}
