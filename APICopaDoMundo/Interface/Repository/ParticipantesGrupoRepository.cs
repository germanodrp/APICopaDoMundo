

using APICopaDoMundo.Contexto;
using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Interface.Repository
{
    public class ParticipantesGrupoRepository: IParticipantesGrupoRepository
    {
        private Context _context = null;

        public ParticipantesGrupoRepository(Context context)
        {
            _context = context;
        }

        public async Task Adicionar(ParticipantesGrupo participantesGrupo)
        {
            await _context.ParticipantesGrupos.AddAsync(participantesGrupo);
            await _context.SaveChangesAsync();

        }

        public async Task Atualizar(ParticipantesGrupo participantesGrupo)
        {
            _context.ParticipantesGrupos.Update(participantesGrupo);
            await _context.SaveChangesAsync();

        }

        public async Task Deletar(int id)
        {
            var entity = await ObterPorId(id);
             _context.ParticipantesGrupos.Remove(entity);
        }

        public async Task<ParticipantesGrupo> ObterPorId(int id)
        {
            return await _context.ParticipantesGrupos.FindAsync(id);
        }

        public async Task<IEnumerable<ParticipantesGrupo>> ObterTodos()
        {
            return await _context.ParticipantesGrupos.AsNoTracking().ToListAsync();
        }
    }
}

