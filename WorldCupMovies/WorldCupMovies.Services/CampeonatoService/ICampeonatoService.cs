using System.Collections.Generic;
using WorldCupMovies.Model;

namespace WorldCupMovies.Services.CampeonatoService
{
    public interface ICampeonatoService
    {
        Final Competir(IList<Filme> filmes);
    }
}