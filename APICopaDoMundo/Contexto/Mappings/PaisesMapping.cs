using Microsoft.EntityFrameworkCore.Metadata.Builders;
using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APICopaDoMundo.Contexto.Mappings

{
    public class PaisesMapping: IEntityTypeConfiguration<Paises>
	{
		public void Configure(EntityTypeBuilder<Paises> builder)
		{
			builder.HasKey(p => p.Id);

			builder.Property(c => c.Nome);
			builder.Property(c => c.IdConfederacoes);
			builder.Property(c => c.RankingFifa);
			builder.Property(c => c.Sede);

			builder.ToTable(name: "PAISES", schema: "COPADOMUNDO");
		}

		public void Configure(EntityTypeBuilder<Confederacoes> builder)
		{
			builder.HasKey(c => c.Id);

			builder.Property(c => c.Nome);
			builder.Property(c => c.Sigla);


			builder.ToTable(name: "CONFEDERACAO", schema: "COPADOMUNDO");
		}

		public void Configure(EntityTypeBuilder<Potes> builder)
		{
			builder.HasKey(p => p.IdPote);

			builder.Property(c => c.Descricao);
			

			builder.ToTable(name: "POTE", schema: "COPADOMUNDO");
		}

		
	}
}
