using System.Collections.Generic;
using System.Linq;
using WorldCupMovies.Domain.FilmeDomain;
using WorldCupMovies.Model;

namespace WorldCupMovies.Domain.FinalDomain
{
    public class FinalDomain : IFinalDomain
    {
        public IFilmeDomain _filmeDomain { get; set; }

        public FinalDomain(IFilmeDomain filmeDomain)
        {
            _filmeDomain = filmeDomain;
        }

        public Final Campeonato(IList<Filme> filmes)
        {
            var participantes = _filmeDomain.ListarOrdenadoSelecionados(filmes);

            var resultadoPartida = FaseGrupos(participantes);

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

        private IEnumerable<ResultadoPartida> FaseGrupos(IList<Filme> participantes)
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