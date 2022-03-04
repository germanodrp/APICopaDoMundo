using APICopaDoMundo.Contexto;
using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Interface
{
    public class PaisesRepository : IPaisesRepository
    {

        private Context _context = null;

        public PaisesRepository(Context context)
        {
            _context = context;
        }

        public async Task Adicionar(Paises paises)
        {
            await _context.Paises.AddAsync(paises);
            await _context.SaveChangesAsync();

        }

        public async Task Atualizar(Paises paises)
        {
            _context.Paises.Update(paises);
            await _context.SaveChangesAsync();

        }

        public async Task Deletar(int id)
        {
            var entity = await ObterPorId(id);
            _context.Paises.Remove(entity);
            await _context.Remove();
        }

        public async Task<Paises> ObterPorId(int id)
        {
            return await _context.Paises.FindAsync(id);
        }

        public async Task<IEnumerable<Paises>> ObterTodos()
        {
            return await _context.Paises.AsNoTracking().ToListAsync();
        }
    }
}
