using APICopaDoMundo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Interface
{
    public interface IParticipantesGrupoRepository
    {
        Task<IEnumerable<ParticipantesGrupo>> ObterTodos();
        Task<ParticipantesGrupo> ObterPorId(int id);
        Task Adicionar(ParticipantesGrupo participantesGrupo);
        Task Atualizar(ParticipantesGrupo participantesGrupo);
        Task Deletar(int id);
    }
}
