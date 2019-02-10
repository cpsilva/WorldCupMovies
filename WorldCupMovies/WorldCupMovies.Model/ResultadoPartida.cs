using System.Collections.Generic;

namespace WorldCupMovies.Model
{
    public class ResultadoPartida
    {
        public ResultadoPartida(IList<Partida> partidas)
        {
            Partidas = partidas;
        }

        public IList<Partida> Partidas { get; private set; }
    }
}