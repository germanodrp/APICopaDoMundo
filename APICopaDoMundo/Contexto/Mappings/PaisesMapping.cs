using Microsoft.EntityFrameworkCore.Metadata.Builders;
using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;


namespace APICopaDoMundo.Contexto.Mappings

{
    public class PaisesMapping: IEntityTypeConfiguration<Paises>
	{
		public void Configure(EntityTypeBuilder<Paises> builder)
		{
			builder.HasKey(p => p.Id);

			builder.Property(c => c.Nome);
			builder.Property(c => c.IdConfederacao);
			builder.Property(c => c.RankingFifa);
			builder.Property(c => c.Sede);

			builder.HasOne(p => p.Confederacoes)
				.WithMany()
				.HasForeignKey(p => p.IdConfederacao);
		
			builder.ToTable(name: "PAISES", schema: "COPADOMUNDO");
		}



		

		
	}
}
