using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorldCupMovies.Domain.FinalDomain;
using WorldCupMovies.Model;

namespace WorldCupMovies.ApplicationService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class CampeonatoController : ControllerBase
    {
        public IFinalDomain _finalDomain { get; set; }

        public CampeonatoController(IFinalDomain finalDomain)
        {
            _finalDomain = finalDomain;
        }

        [HttpPost]
        public Final Post([FromBody] IList<Filme> filmes)
        {
            return _finalDomain.Campeonato(filmes);
        }
    }
}