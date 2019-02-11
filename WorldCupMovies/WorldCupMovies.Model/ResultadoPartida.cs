using System.Collections.Generic;

namespace WorldCupMovies.Model
{
    public class ResultadoPartida
    {
        public ResultadoPartida(IList<Partida> partidas)
        {
            _Partida = partidas;
        }

        private readonly IList<Partida> _Partida = new List<Partida>();

        public IList<Partida> Partidas
        {
            get
            {
                return _Partida;
            }
        }
    }
}