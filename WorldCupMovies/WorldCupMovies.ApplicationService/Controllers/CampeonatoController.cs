using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorldCupMovies.Model;
using WorldCupMovies.Services.CampeonatoService;

namespace WorldCupMovies.ApplicationService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class CampeonatoController : ControllerBase
    {
        public ICampeonatoService _campeonatoService { get; set; }

        public CampeonatoController(ICampeonatoService campeonatoService)
        {
            _campeonatoService = campeonatoService;
        }

        [HttpPost]
        public Final Post([FromBody] IList<Filme> filmes)
        {
            return _campeonatoService.Competir(filmes);
        }
    }
}