using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WorldCupMovies.DependencyInjection;
using WorldCupMovies.Model;
using WorldCupMovies.Services.CompetirService;

namespace WorldCupMovies.Tests
{
    [TestClass]
    public class CompetirServiceTests
    {
        [TestMethod]
        public void Competir()
        {
            Container.RegisterServices();

            ICompetirService competirService = Container.GetService<ICompetirService>();

            var filmes = new List<Filme>
            {
                new Filme { Ano = 2018, Id = "tt3606756", Nota = 8.5M, Titulo = "Os Incríveis 2", Selecionado = true },
                new Filme { Ano = 2018, Id = "tt4881806", Nota = 6.7M, Titulo = "Jurassic World: Reino Ameaçado", Selecionado = true },
                new Filme { Ano = 2018, Id = "tt5164214", Nota = 6.3M, Titulo = "Oito Mulheres e um Segredo", Selecionado = true },
                new Filme { Ano = 2018, Id = "tt7784604", Nota = 7.8M, Titulo = "Hereditário", Selecionado = true },
                new Filme { Ano = 2018, Id = "tt4154756", Nota = 8.8M, Titulo = "Vingadores: Guerra Infinita", Selecionado = true },
                new Filme { Ano = 2018, Id = "tt5463162", Nota = 8.1M, Titulo = "Deadpool 2", Selecionado = true },
                new Filme { Ano = 2018, Id = "tt3778644", Nota = 7.2M, Titulo = "Han Solo: Uma História Star Wars", Selecionado = true },
                new Filme { Ano = 2018, Id = "tt3501632", Nota = 7.9M, Titulo = "Thor: Ragnarok", Selecionado = true }
            };

            var resultado = competirService.Competir(filmes);

            Assert.IsTrue(resultado.Campeao.Nota == 8.8M);
            Assert.IsTrue(resultado.Vice.Nota == 8.5M);
        }
    }
}