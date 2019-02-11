using System.Collections.Generic;
using System.Linq;
using WorldCupMovies.Model;
using WorldCupMovies.Services.FilmeService;

namespace WorldCupMovies.Services.CompetirService
{
    public class CompetirService : ICompetirService
    {
        private readonly IFilmeService _filmeService;

        public CompetirService(IFilmeService filmeService)
        {
            _filmeService = filmeService;
        }

        public Final Competir(IList<Filme> filmes)
        {
            var participantes = _filmeService.ListarOrdenadoSelecionados(filmes);

            var resultadoPartida = CompetirFaseGrupos(participantes);

            var resultadoUltimaPartida = resultadoPartida.Last().Partidas.Last();

            return new Final(resultadoUltimaPartida.Vencedor, resultadoUltimaPartida.Perdedor);
        }

        private IList<Partida> JogarPartida(IList<Filme> participantes)
        {
            var resultadoJogo = new List<Partida>();

            var partidas = participantes.Count / 2;

            for (var i = 0; i < partidas; i++)
            {
                var j = participantes.Count - (i + 1);

                var vencedor = participantes[i].Nota >= participantes[j].Nota ? participantes[i] : participantes[j];

                var perdedor = vencedor == participantes[i] ? participantes[j] : participantes[i];

                resultadoJogo.Add(new Partida(vencedor, perdedor));
            }

            return resultadoJogo;
        }

        private IEnumerable<ResultadoPartida> CompetirFaseGrupos(IList<Filme> participantes)
        {
            var resultadoPartidas = new List<ResultadoPartida>();

            while (participantes.Count > 1)
            {
                var resultados = JogarPartida(participantes);

                resultadoPartidas.Add(new ResultadoPartida(resultados));

                participantes = resultados.Select(x => x.Vencedor).ToList();
            }

            return resultadoPartidas;
        }
    }
}