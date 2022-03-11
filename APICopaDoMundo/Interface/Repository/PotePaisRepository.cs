using APICopaDoMundo.Contexto;
using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Interface.Repository
{
    public class PotePaisRepository:IPotePaisRepository
    {
        private Context _context = null;

        public PotePaisRepository(Context context)
        {
            _context = context;
        }

        public async Task Adicionar(PotePais potePais)
        {
            await _context.PotePais.AddAsync(potePais);
            await _context.SaveChangesAsync();

        }

        public async Task Atualizar(PotePais potePais)
        {
            _context.PotePais.Update(potePais);
            await _context.SaveChangesAsync();

        }

        public async Task Deletar(int id)
        {
            var entity = await ObterPorId(id);
            _context.PotePais.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<PotePais> ObterPorId(int id)
        {
            return await _context.PotePais.FindAsync(id);
        }

        public async Task<IEnumerable<PotePais>> ObterTodos()
        {
            return await _context.PotePais.AsNoTracking().ToListAsync();
        }
    }
}
