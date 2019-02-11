using System.Collections.Generic;
using WorldCupMovies.Model;

namespace WorldCupMovies.Services.FilmeService
{
    public interface IFilmeService
    {
        IList<Filme> ListarOrdenadoSelecionados(IList<Filme> filmes);
    }
}