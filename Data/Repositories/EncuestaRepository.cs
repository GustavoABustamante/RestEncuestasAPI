using Microsoft.EntityFrameworkCore;
using RestEncuestasAPI.Data.Entities;
using System.Data;

namespace RestEncuestasAPI.Data.Repositories
{
    public class EncuestaRepository : IEncuestaRepository
    {
        private readonly EncuestaContext _context;

        public EncuestaRepository(EncuestaContext context)
        {
            _context = context;
        }

        public async Task<Encuesta> AddAsync(Encuesta encuesta)
        {
            encuesta.Id = Guid.NewGuid().ToString();

            var existeEncuesta = (await GetAsync()).Where(d => d.Id == encuesta.Id).FirstOrDefault();

            if (existeEncuesta is not null)
            {
                throw new DataException($"Añadir docente: La encuesta con el id: {encuesta.Id} ya existe.");
            }

            var result = await _context.Encuestas.AddAsync(encuesta);

            await _context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<IEnumerable<Encuesta>> GetAsync()
        {
            return await _context.Encuestas
            .ToListAsync();
        }
    }
}
