using AutoMapper;
using RestEncuestasAPI.Data.Entities;
using RestEncuestasAPI.Data.Repositories;
using System.Data;

namespace RestEncuestasAPI.Services
{
    public class EncuestasService : IEncuestasService
    {
        private readonly ILogger<EncuestasService> _logger;
        private readonly IMapper _mapper;
        private readonly IEncuestaRepository _encuestaRepository;
        public EncuestasService(
        ILogger<EncuestasService> logger,
        IMapper mapper,
        IEncuestaRepository encuestaRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _encuestaRepository = encuestaRepository;
        }

        public async Task<Encuesta> AddEncuesta(Encuesta request)
        {
            _logger.LogInformation("Microservicios encuestas: Adding encuesta...");
            var newEncuesta = request;


            if (newEncuesta.Id is null)
            {
                throw new Exception("Please provide Encuesta Id.");
            }

            if (newEncuesta.Nombre is null)
            {
                throw new Exception("Please provide Nombre Encuesta.");
            }

            try
            {
                var encuesta = await _encuestaRepository.AddAsync(_mapper.Map<Encuesta>(newEncuesta));

                return encuesta;
            }
            catch (DataException e)
            {
                throw new Exception(e.Message);
            }
            catch (Exception)
            {
                throw new Exception("Unknown error.");
            }
        }

        public async Task<IEnumerable<Encuesta>> GetEncuestas()
        {
            _logger.LogInformation("Microservicios docentes: Getting encuestas...");
            var docentes = await _encuestaRepository.GetAsync();

            if (docentes is null)
            {
                throw new Exception($"No se encontraron docentes.");
            }

            return docentes;
        }
    }
}
