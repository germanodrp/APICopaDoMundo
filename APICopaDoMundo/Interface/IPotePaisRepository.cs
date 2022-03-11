using APICopaDoMundo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Interface
{
    public interface IPotePaisRepository
    {
        Task<IEnumerable<PotePais>> ObterTodos();
        Task<PotePais> ObterPorId(int id);
        Task Adicionar(PotePais potePais);
        Task Atualizar(PotePais potePais);
        Task Deletar(int id);
    }
}
