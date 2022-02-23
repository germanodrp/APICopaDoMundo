using APICopaDoMundo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Interface
{
    public interface IPotesRepository
    {
        Task<IEnumerable<Potes>> ObterTodos();
        Task<Potes> ObterPorId(int id);
        Task Adicionar(Potes potes);
        Task Atualizar(Potes potes);
        void Deletar(int id);
    }
}
