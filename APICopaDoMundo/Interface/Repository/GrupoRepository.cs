using APICopaDoMundo.Contexto;
using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Interface.Repository
{
    public class GrupoRepository : IGrupoRepository
    {

        private Context _context = null;

        public GrupoRepository(Context context)
        {
            _context = context;
        }

        public async Task Adicionar(Grupo grupo)
        {
            await _context.Grupo.AddAsync(grupo);
            await _context.SaveChangesAsync();

        }

        public async Task Atualizar(Grupo grupo)
        {
            _context.Grupo.Update(grupo);
            await _context.SaveChangesAsync();

        }

        public async Task Deletar(int id)
        {
            var entity = await ObterPorId(id);
            _context.Grupo.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Grupo> ObterPorId(int id)
        {
            return await _context.Grupo.FindAsync(id);
        }

        public async Task<IEnumerable<Grupo>> ObterTodos()
        {
            return await _context.Grupo.AsNoTracking().ToListAsync();
        }
    }
}
