using APICopaDoMundo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Interface
{
    public interface IGrupoRepository
    {
        Task<IEnumerable<Grupo>> ObterTodos();
        Task<Grupo> ObterPorId(int id);
        Task Adicionar(Grupo grupo);
        Task Atualizar(Grupo grupo);
        Task Deletar(int id);
    }
}
