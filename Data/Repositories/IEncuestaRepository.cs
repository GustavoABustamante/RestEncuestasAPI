using RestEncuestasAPI.Data.Entities;

namespace RestEncuestasAPI.Data.Repositories
{
    public interface IEncuestaRepository
    {
        Task<IEnumerable<Encuesta>> GetAsync();
        public Task<Encuesta> AddAsync(Encuesta encuesta);
    }
}
