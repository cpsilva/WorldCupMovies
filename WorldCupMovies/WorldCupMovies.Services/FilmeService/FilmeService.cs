using System.Collections.Generic;
using System.Linq;
using WorldCupMovies.Model;

namespace WorldCupMovies.Services.FilmeService
{
    public class FilmeService : IFilmeService
    {
        public IList<Filme> ListarOrdenadoSelecionados(IList<Filme> filmes)
        {
            return filmes.Where(filme => filme.Selecionado).OrderBy(filme => filme.Titulo).ToList();
        }
    }
}