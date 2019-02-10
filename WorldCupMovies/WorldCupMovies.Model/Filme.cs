namespace WorldCupMovies.Model
{
    public class Filme
    {
        public string Id { get; set; }

        public decimal Nota { get; set; }

        public string Titulo { get; set; }

        public int Ano { get; set; }

        public bool Selecionado { get; set; }
    }
}