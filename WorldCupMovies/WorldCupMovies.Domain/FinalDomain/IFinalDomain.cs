using System.Collections.Generic;
using WorldCupMovies.Model;

namespace WorldCupMovies.Domain.FinalDomain
{
    public interface IFinalDomain
    {
        Final Campeonato(IList<Filme> filmes);
    }
}