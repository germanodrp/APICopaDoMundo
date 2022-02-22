using APICopaDoMundo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Interface
{
    public interface IPaisesRepository
    {
        Task<IEnumerable<Paises>> ObterTodos();
        Task<Paises> ObterPorId(int id);
        Task Adicionar(Paises paises);
        Task Atualizar(Paises paises);
        void Deletar(int id);
    }
}
