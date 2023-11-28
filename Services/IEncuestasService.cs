using RestEncuestasAPI.Data.Entities;

namespace RestEncuestasAPI.Services
{
    public interface IEncuestasService
    {
        Task<IEnumerable<Encuesta>> GetEncuestas();
        Task<Encuesta> AddEncuesta(Encuesta request);
    }
}
