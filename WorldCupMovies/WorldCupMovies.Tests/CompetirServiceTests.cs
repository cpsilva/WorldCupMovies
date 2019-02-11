using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WorldCupMovies.Model;
using WorldCupMovies.Services.CampeonatoService;
using WorldCupMovies.Services.FilmeService;

namespace WorldCupMovies.Tests
{
    [TestClass]
    public class CompetirServiceTests
    {
        private ICampeonatoService CampeonatoService { get; }

        public CompetirServiceTests()
        {
            var services = new ServiceCollection();

            services.AddScoped<IFilmeService, FilmeService>();
            services.AddScoped<ICampeonatoService, CampeonatoService>();
            CampeonatoService = services.BuildServiceProvider().GetRequiredService<ICampeonatoService>();
        }

        [TestMethod]
        public void DeveSerValidoAoReceberOitoItens()
        {
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

            var resultado = CampeonatoService.Competir(filmes);

            Assert.IsTrue(resultado.Campeao.Nota == 8.8M);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Lista de filmes possui um valor diferente de 8")]
        public void DeveSerInvalidoAoReceberUmaListaDiferenteDeOitoItens()
        {
            var filmes = new List<Filme>
            {
                new Filme { Ano = 2018, Id = "tt3606756", Nota = 8.5M, Titulo = "Os Incríveis 2", Selecionado = true },
                new Filme { Ano = 2018, Id = "tt4881806", Nota = 6.7M, Titulo = "Jurassic World: Reino Ameaçado", Selecionado = true },
                new Filme { Ano = 2018, Id = "tt5164214", Nota = 6.3M, Titulo = "Oito Mulheres e um Segredo", Selecionado = true },
                new Filme { Ano = 2018, Id = "tt7784604", Nota = 7.8M, Titulo = "Hereditário", Selecionado = true },
            };

            var resultado = CampeonatoService.Competir(filmes);
        }
    }
}