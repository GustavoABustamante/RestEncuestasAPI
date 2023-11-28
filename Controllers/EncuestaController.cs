using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestEncuestasAPI.Data.Entities;
using RestEncuestasAPI.Services;

namespace RestEncuestasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncuestaController : ControllerBase
    {
        private readonly IEncuestasService _encuestasService;

        public EncuestaController(IEncuestasService encuestasService)
        {
            this._encuestasService = encuestasService;
        }
        [HttpGet(nameof(GetEncuestas))]
        public async Task<IEnumerable<Encuesta>> GetEncuestas()
        {
            return await _encuestasService.GetEncuestas();
        }

        [HttpPost(nameof(AddEncuesta))]
        public async Task<Encuesta> AddEncuesta(Encuesta encuesta)
        {
            return await _encuestasService.AddEncuesta(encuesta);
        }
    }
}
