using APICopaDoMundo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Interface
{
    public interface IConfederacoesRepository
    {
        Task<IEnumerable<Confederacoes>> ObterTodos();
        Task<Confederacoes> ObterPorId(int id);
        Task Adicionar(Confederacoes confederacoes);
        Task Atualizar(Confederacoes confederacoes);
        Task Deletar(int id);
    }
}
