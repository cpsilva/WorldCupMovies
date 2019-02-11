using System.Collections.Generic;
using WorldCupMovies.Model;

namespace WorldCupMovies.Services.CompetirService
{
    public interface ICompetirService
    {
        Final Competir(IList<Filme> filmes);
    }
}