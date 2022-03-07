using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APICopaDoMundo.Contexto.Mappings
{
    public class ParticipantesGrupoMapping : IEntityTypeConfiguration<ParticipantesGrupo>
	{
		public void Configure(EntityTypeBuilder<ParticipantesGrupo> builder)
		{

			builder.Property(p => p.Id);
			builder.Property(p => p.IdGrupo);


			builder.ToTable(name: "PARTICIPANTESGRUPO", schema: "COPADOMUNDO");
		}
	}
}
