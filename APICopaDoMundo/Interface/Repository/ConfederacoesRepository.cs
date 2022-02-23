using APICopaDoMundo.Contexto;
using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Interface
{
    public class ConfederacoesRepository : IConfederacoesRepository
    {
        private Context _context = null;

        public ConfederacoesRepository(Context context)
        {
            _context = context;
        }

        public async Task Adicionar(Confederacoes confederacoes)
        {
            await _context.Confederacoes.AddAsync(confederacoes);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Confederacoes confederacoes)
        {
             _context.Confederacoes.Update(confederacoes);
            await _context.SaveChangesAsync();
        }

        public async void Deletar(int id)
        {
            var entity = await ObterPorId(id);
            _context.Confederacoes.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Confederacoes> ObterPorId(int id)
        {
            return await _context.Confederacoes.FindAsync(id);
        }

        public async Task<IEnumerable<Confederacoes>> ObterTodos()
        {
            return await _context.Confederacoes.AsNoTracking().ToListAsync();
        }
    }
}
