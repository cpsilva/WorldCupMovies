using System.Collections.Generic;
using WorldCupMovies.Model;

namespace WorldCupMovies.Domain.FilmeDomain
{
    public interface IFilmeDomain
    {
        IList<Filme> ListarOrdenadoSelecionados(IList<Filme> filmes);
    }
}