using APICopaDoMundo.Contexto;
using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Interface
{
    public class PotesRepository : IPotesRepository
    {

        private Context _context = null;

        public PotesRepository(Context context)
        {
            _context = context;
        }

        public async Task Adicionar(Potes potes)
        {
            await _context.Potes.AddAsync(potes);
            await _context.SaveChangesAsync();

        }

        public async Task Atualizar(Potes potes)
        {
            _context.Potes.Update(potes);
            await _context.SaveChangesAsync();

        }

        public async Task Deletar(int id)
        {
            var entity = await ObterPorId(id);
            _context.Potes.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Potes> ObterPorId(int id)
        {
            return await _context.Potes.FindAsync(id);
        }

        public async Task<IEnumerable<Potes>> ObterTodos()
        {
            return await _context.Potes.AsNoTracking().ToListAsync();
        }
    }
}
