using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorldCupMovies.Model;
using WorldCupMovies.Services.CompetirService;

namespace WorldCupMovies.ApplicationService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class CampeonatoController : ControllerBase
    {
        public ICompetirService _competirService { get; set; }

        public CampeonatoController(ICompetirService competirService)
        {
            _competirService = competirService;
        }

        [HttpPost]
        public Final Post([FromBody] IList<Filme> filmes)
        {
            return _competirService.Competir(filmes);
        }
    }
}