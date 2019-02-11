namespace WorldCupMovies.Model
{
    public class Partida
    {
        public Partida(Filme vencedor, Filme perdedor)
        {
            Vencedor = vencedor;
            Perdedor = perdedor;
        }

        public Filme Vencedor { get; private set; }

        public Filme Perdedor { get; private set; }
    }
}