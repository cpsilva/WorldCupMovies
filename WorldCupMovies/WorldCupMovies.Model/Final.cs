namespace WorldCupMovies.Model
{
    public sealed class Final
    {
        public Final(Filme campeao, Filme vice)
        {
            Campeao = campeao;
            Vice = vice;
        }

        public Filme Campeao { get; private set; }

        public Filme Vice { get; private set; }
    }
}