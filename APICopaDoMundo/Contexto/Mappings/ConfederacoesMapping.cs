using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APICopaDoMundo.Contexto.Mappings
{
    public class ConfederacoesMapping:IEntityTypeConfiguration<Confederacoes>
	{
		public void Configure(EntityTypeBuilder<Confederacoes> builder)
		{
			builder.HasKey(c => c.Id);

			builder.Property(c => c.Nome);
			builder.Property(c => c.Sigla);


			builder.ToTable(name: "CONFEDERACAO", schema: "COPADOMUNDO");
		}
	}
}
