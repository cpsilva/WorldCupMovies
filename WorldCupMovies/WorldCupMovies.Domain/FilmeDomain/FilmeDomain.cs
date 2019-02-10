using System.Collections.Generic;
using System.Linq;
using WorldCupMovies.Model;

namespace WorldCupMovies.Domain.FilmeDomain
{
    public class FilmeDomain : IFilmeDomain
    {
        public IList<Filme> ListarOrdenadoSelecionados(IList<Filme> filmes)
        {
            return filmes.Where(filme => filme.Selecionado).OrderBy(filme => filme.Titulo).ToList();
        }
    }
}