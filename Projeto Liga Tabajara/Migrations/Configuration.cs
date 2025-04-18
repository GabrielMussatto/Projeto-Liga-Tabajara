namespace Projeto_Liga_Tabajara.Migrations
{
    using Projeto_Liga_Tabajara.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Projeto_Liga_Tabajara.DataBase.LigaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Projeto_Liga_Tabajara.DataBase.LigaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //ket
            context.Times.AddOrUpdate(t => t.Nome,
               new Time { Nome = "Flamengo", Cidade = "Rio de Janeiro", Estado = "RJ", AnoFundacao = DateTime.Parse("1895-11-15"), Estadio = "Maracanã", CapacidadeEstadio = 78838, CorUniformePrimaria = "Vermelho", CorUniformeSecundaria = "Preto" },
               new Time { Nome = "Palmeiras", Cidade = "São Paulo", Estado = "SP", AnoFundacao = DateTime.Parse("1914-08-26"), Estadio = "Allianz Parque", CapacidadeEstadio = 43003, CorUniformePrimaria = "Verde", CorUniformeSecundaria = "Branco" },
               new Time { Nome = "Atlético Mineiro", Cidade = "Belo Horizonte", Estado = "MG", AnoFundacao = DateTime.Parse("1908-03-25"), Estadio = "Mineirão", CapacidadeEstadio = 62000, CorUniformePrimaria = "Preto", CorUniformeSecundaria = "Branco" },
               new Time { Nome = "Fluminense", Cidade = "Rio de Janeiro", Estado = "RJ", AnoFundacao = DateTime.Parse("1902-07-21"), Estadio = "Maracanã", CapacidadeEstadio = 78838, CorUniformePrimaria = "Verde", CorUniformeSecundaria = "Bordô" },
               new Time { Nome = "Corinthians", Cidade = "São Paulo", Estado = "SP", AnoFundacao = DateTime.Parse("1910-09-01"), Estadio = "Neo Química Arena", CapacidadeEstadio = 49231, CorUniformePrimaria = "Branco", CorUniformeSecundaria = "Preto" },
               new Time { Nome = "São Paulo", Cidade = "São Paulo", Estado = "SP", AnoFundacao = DateTime.Parse("1930-01-25"), Estadio = "Morumbi", CapacidadeEstadio = 67000, CorUniformePrimaria = "Branco", CorUniformeSecundaria = "Vermelho" },
               new Time { Nome = "Botafogo", Cidade = "Rio de Janeiro", Estado = "RJ", AnoFundacao = DateTime.Parse("1904-08-12"), Estadio = "Nilton Santos", CapacidadeEstadio = 46000, CorUniformePrimaria = "Preto", CorUniformeSecundaria = "Branco" },
               new Time { Nome = "Internacional", Cidade = "Porto Alegre", Estado = "RS", AnoFundacao = DateTime.Parse("1909-04-04"), Estadio = "Beira-Rio", CapacidadeEstadio = 50000, CorUniformePrimaria = "Vermelho", CorUniformeSecundaria = "Branco" },
               new Time { Nome = "Cruzeiro", Cidade = "Belo Horizonte", Estado = "MG", AnoFundacao = DateTime.Parse("1921-01-02"), Estadio = "Mineirão", CapacidadeEstadio = 62000, CorUniformePrimaria = "Azul", CorUniformeSecundaria = "Branco" },
               new Time { Nome = "Grêmio", Cidade = "Porto Alegre", Estado = "RS", AnoFundacao = DateTime.Parse("1903-09-15"), Estadio = "Arena do Grêmio", CapacidadeEstadio = 55000, CorUniformePrimaria = "Azul", CorUniformeSecundaria = "Preto" },
               new Time { Nome = "Santos", Cidade = "Santos", Estado = "SP", AnoFundacao = DateTime.Parse("1912-04-14"), Estadio = "Vila Belmiro", CapacidadeEstadio = 16000, CorUniformePrimaria = "Branco", CorUniformeSecundaria = "Preto" },
               new Time { Nome = "Athletico-PR", Cidade = "Curitiba", Estado = "PR", AnoFundacao = DateTime.Parse("1924-03-26"), Estadio = "Arena da Baixada", CapacidadeEstadio = 42800, CorUniformePrimaria = "Vermelho", CorUniformeSecundaria = "Preto" },
               new Time { Nome = "Fortaleza", Cidade = "Fortaleza", Estado = "CE", AnoFundacao = DateTime.Parse("1918-10-18"), Estadio = "Castelão", CapacidadeEstadio = 63000, CorUniformePrimaria = "Azul", CorUniformeSecundaria = "Vermelho" },
               new Time { Nome = "Bahia", Cidade = "Salvador", Estado = "BA", AnoFundacao = DateTime.Parse("1931-01-01"), Estadio = "Fonte Nova", CapacidadeEstadio = 50000, CorUniformePrimaria = "Azul", CorUniformeSecundaria = "Vermelho" },
               new Time { Nome = "Coritiba", Cidade = "Curitiba", Estado = "PR", AnoFundacao = DateTime.Parse("1909-10-12"), Estadio = "Couto Pereira", CapacidadeEstadio = 40400, CorUniformePrimaria = "Verde", CorUniformeSecundaria = "Branco" },
               new Time { Nome = "Goiás", Cidade = "Goiânia", Estado = "GO", AnoFundacao = DateTime.Parse("1943-04-06"), Estadio = "Serra Dourada", CapacidadeEstadio = 50000, CorUniformePrimaria = "Verde", CorUniformeSecundaria = "Branco" },
               new Time { Nome = "Ceará", Cidade = "Fortaleza", Estado = "CE", AnoFundacao = DateTime.Parse("1914-06-02"), Estadio = "Castelão", CapacidadeEstadio = 63000, CorUniformePrimaria = "Preto", CorUniformeSecundaria = "Branco" },
               new Time { Nome = "Vasco", Cidade = "Rio de Janeiro", Estado = "RJ", AnoFundacao = DateTime.Parse("1898-08-21"), Estadio = "São Januário", CapacidadeEstadio = 21044, CorUniformePrimaria = "Preto", CorUniformeSecundaria = "Branco" },
               new Time { Nome = "América-MG", Cidade = "Belo Horizonte", Estado = "MG", AnoFundacao = DateTime.Parse("1912-04-30"), Estadio = "Independência", CapacidadeEstadio = 23000, CorUniformePrimaria = "Verde", CorUniformeSecundaria = "Branco" },
               new Time { Nome = "Sport", Cidade = "Recife", Estado = "PE", AnoFundacao = DateTime.Parse("1905-05-13"), Estadio = "Itaipava Arena Pernambuco", CapacidadeEstadio = 46000, CorUniformePrimaria = "Vermelho", CorUniformeSecundaria = "Preto" }
            );
            context.SaveChanges();

            // 2) CARREGA OS TIMES SALVOS
            var times = context.Times.ToDictionary(t => t.Nome, t => t.Id);

            context.Jogadores.AddOrUpdate(j => new { j.Nome, j.TimeId, j.NumeroCamisa },
                // Flamengo
                new Jogador { Nome = "Diego Alves", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1985-11-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.88f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "César", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1985-04-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Hugo Souza", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("2001-09-27"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.89f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },

                new Jogador { Nome = "Matheuzinho", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1999-05-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 38, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Ramon", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1996-06-04"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Esquerdo, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Filipe Luís", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1985-08-09"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.77f, Peso = 73f, PePreferido = PePreferido.Esquerdo, TimeId = times["Flamengo"] },

                new Jogador { Nome = "Léo Pereira", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-08-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.86f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Pablo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1991-12-20"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.88f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Thuler", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("2000-06-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 24, Altura = 1.91f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Rodrigo Caio", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-08-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 13, Altura = 1.86f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Fabrício Bruno", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-08-26"), Nacionalidade = "Brasileiro", NumeroCamisa = 26, Altura = 1.90f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Ayrton Lucas", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1997-04-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 14, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Flamengo"] },

                new Jogador { Nome = "Victor Hugo", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2004-12-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 35, Altura = 1.80f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "João Gomes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2001-01-13"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.90f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Willian Arão", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1995-09-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 33, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },

                new Jogador { Nome = "Gerson", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1997-05-20"), Nacionalidade = "Brasileiro", NumeroCamisa = 20, Altura = 1.80f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Everton Ribeiro", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1989-10-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.68f, Peso = 58f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Arrascaeta", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-12-01"), Nacionalidade = "Uruguaio", NumeroCamisa = 14, Altura = 1.80f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Vitinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-10-09"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.71f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Diego Ribas", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1985-02-28"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.69f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Michael", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-02-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.69f, Peso = 62f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },

                new Jogador { Nome = "Bruno Henrique", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1989-06-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 27, Altura = 1.78f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Gabriel Barbosa", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-08-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.75f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Pedro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-06-20"), Nacionalidade = "Brasileiro", NumeroCamisa = 21, Altura = 1.94f, Peso = 91f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Marinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1990-12-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.70f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Lázaro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2002-10-25"), Nacionalidade = "Brasileiro", NumeroCamisa = 39, Altura = 1.77f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },

                new Jogador { Nome = "Bukayo Saka", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2001-09-05"), Nacionalidade = "Inglês", NumeroCamisa = 7, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Granit Xhaka", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1992-09-27"), Nacionalidade = "Suíço", NumeroCamisa = 34, Altura = 1.85f, Peso = 78f, PePreferido = PePreferido.Esquerdo, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Kieran Tierney", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1997-06-05"), Nacionalidade = "Escocês", NumeroCamisa = 3, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["Flamengo"] },
                new Jogador { Nome = "Gabriel Martinelli", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2001-06-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.75f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },

                // Palmeiras
                new Jogador { Nome = "Weverton", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1987-11-13"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.86f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Jaílson", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1991-05-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.89f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Vinícius Silvestre", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1999-01-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 34, Altura = 1.85f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },

                new Jogador { Nome = "Rocha", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-12-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 33, Altura = 1.85f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Empereur", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-01-04"), Nacionalidade = "Brasileiro", NumeroCamisa = 46, Altura = 1.86f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Gustavo Gómez", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-05-06"), Nacionalidade = "Paraguaio", NumeroCamisa = 15, Altura = 1.90f, Peso = 87f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Murilo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-03-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.84f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Jaílson (zagueiro)", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-03-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 34, Altura = 1.88f, Peso = 83f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Mayke", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1992-05-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Kim", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("2000-06-09"), Nacionalidade = "Coreano", NumeroCamisa = 40, Altura = 1.77f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Piquerez", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("2001-06-15"), Nacionalidade = "Uruguaio", NumeroCamisa = 6, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Matías Viña", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1997-03-31"), Nacionalidade = "Uruguaio", NumeroCamisa = 7, Altura = 1.73f, Peso = 65f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },

                new Jogador { Nome = "Dudu", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1992-05-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.69f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Raphael Veiga", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-01-19"), Nacionalidade = "Brasileiro", NumeroCamisa = 23, Altura = 1.75f, Peso = 75f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Zé Rafael", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-06-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Eduard Atuesta", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2000-01-15"), Nacionalidade = "Colombiano", NumeroCamisa = 5, Altura = 1.75f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Gabriel Menino", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2000-10-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 25, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Patrick de Paula", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1999-07-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Danilo", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1991-03-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Gustavo Scarpa", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-01-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 14, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Matheus Fernandes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2000-09-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 35, Altura = 1.80f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Lucas Trevisol", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-04-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },

                new Jogador { Nome = "Rony", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1995-05-11"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Luiz Adriano", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1987-04-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.94f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Deyverson", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1991-06-08"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.81f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Rafael Navarro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2001-01-31"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.85f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Gabriel Veron", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2002-05-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.73f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Wesley", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-07-09"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.87f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Miguel Borja", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1993-12-26"), Nacionalidade = "Colombiano", NumeroCamisa = 17, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Nome = "Wesley Moraes", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-01-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 21, Altura = 1.90f, Peso = 87f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },

                // Atlético Mineiro
                new Jogador { Nome = "Everson", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1993-03-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Rafael", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1996-02-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.88f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "João Ricardo", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1988-12-04"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.87f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },

                new Jogador { Nome = "Mariano", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1986-02-23"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.82f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Igor Rabello", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-11-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Natan", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1999-03-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.93f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Gabriel Silva", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1998-05-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Alan Franco", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1999-10-15"), Nacionalidade = "Ecuadoriano", NumeroCamisa = 8, Altura = 1.83f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Guilherme Arana", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1993-06-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.73f, Peso = 69f, PePreferido = PePreferido.Esquerdo, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Júnior Alonso", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-08-31"), Nacionalidade = "Paraguaio", NumeroCamisa = 10, Altura = 1.84f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },

                new Jogador { Nome = "Allan", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1991-01-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Jair", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1991-01-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.83f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Nacho Fernández", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1990-05-12"), Nacionalidade = "Argentino", NumeroCamisa = 13, Altura = 1.70f, Peso = 71f, PePreferido = PePreferido.Esquerdo, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Matías Zaracho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-02-10"), Nacionalidade = "Argentino", NumeroCamisa = 14, Altura = 1.75f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Savinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-03-21"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.76f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Diego Costa", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1988-10-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.69f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },

                new Jogador { Nome = "Ademir", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-10-27"), Nacionalidade = "Brasileiro", NumeroCamisa = 17, Altura = 1.83f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Eduardo Vargas", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1989-11-20"), Nacionalidade = "Chileno", NumeroCamisa = 18, Altura = 1.75f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Keno", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1989-05-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 19, Altura = 1.74f, Peso = 71f, PePreferido = PePreferido.Esquerdo, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Yimmi Chará", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-01-23"), Nacionalidade = "Colombiano", NumeroCamisa = 20, Altura = 1.82f, Peso = 79f, PePreferido = PePreferido.Esquerdo, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Eduardo Sasha", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-05-27"), Nacionalidade = "Brasileiro", NumeroCamisa = 21, Altura = 1.78f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },

                new Jogador { Nome = "Rafael Carioca", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1989-03-31"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Tchê Tchê", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1992-06-08"), Nacionalidade = "Brasileiro", NumeroCamisa = 23, Altura = 1.75f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Borré", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1995-07-15"), Nacionalidade = "Colombiano", NumeroCamisa = 24, Altura = 1.75f, Peso = 69f, PePreferido = PePreferido.Esquerdo, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Diego Tardelli", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1985-05-19"), Nacionalidade = "Brasileiro", NumeroCamisa = 25, Altura = 1.71f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Otávio", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1994-08-13"), Nacionalidade = "Brasileiro", NumeroCamisa = 26, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },

                new Jogador { Nome = "Matheus Fernandes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-07-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 27, Altura = 1.81f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Alan Kardec", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1989-03-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.88f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Alerrandro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2000-06-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Nome = "Giovanni", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-08-25"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },

                // Fluminense
                new Jogador { Nome = "Marcos Felipe", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1996-06-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.89f, Peso = 87f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Gabriel Batista", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1997-08-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.92f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Fábio", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1990-07-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 32, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },

                new Jogador { Nome = "Nino", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1997-06-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 26, Altura = 1.87f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Luccas Claro", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1991-01-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Digão", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1985-11-11"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.95f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Samuel Xavier", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1990-02-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 24, Altura = 1.77f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Igor Julião", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1994-10-13"), Nacionalidade = "Brasileiro", NumeroCamisa = 23, Altura = 1.79f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Marlon", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1991-03-23"), Nacionalidade = "Brasileiro", NumeroCamisa = 20, Altura = 1.92f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Manoel", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1989-04-20"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.87f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Calegari", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("2000-01-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.83f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Wellington Silva", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1988-05-06"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.80f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },

                new Jogador { Nome = "André", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1990-02-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Nenê", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1981-05-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 77, Altura = 1.71f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Danielzinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-04-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Cazares", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-02-03"), Nacionalidade = "Equatoriano", NumeroCamisa = 10, Altura = 1.69f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Wellington", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1990-06-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.84f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Yago", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1997-09-26"), Nacionalidade = "Brasileiro", NumeroCamisa = 18, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "André Trindade", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2002-09-09"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.78f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Gabriel Teixeira", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2001-04-01"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.74f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Crispim", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-08-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 17, Altura = 1.83f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Ganso", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1989-10-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 25, Altura = 1.84f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Marquinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1989-07-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 14, Altura = 1.81f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "João Gomes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2001-10-13"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.74f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },

                new Jogador { Nome = "Fred", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1985-03-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.86f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Yony González", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-08-19"), Nacionalidade = "Colombiano", NumeroCamisa = 19, Altura = 1.83f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Evanilson", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1999-06-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 27, Altura = 1.83f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Luciano", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1984-08-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 17, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Pedrinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1998-11-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 21, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fluminense"] },
                new Jogador { Nome = "Jhon Arias", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-10-07"), Nacionalidade = "Colombiano", NumeroCamisa = 28, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },

                // Corinthians
                new Jogador { Nome = "Cássio", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("06/12/1987"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.90f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Matheus Donelli", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("28/05/2003"), Nacionalidade = "Brasileiro", NumeroCamisa = 31, Altura = 1.90f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Walter", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("13/08/1987"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },

                new Jogador { Nome = "Fagner", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("11/06/1985"), Nacionalidade = "Brasileiro", NumeroCamisa = 23, Altura = 1.74f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Raul Gustavo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("25/02/1999"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.86f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Jemerson", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("20/12/1992"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.91f, Peso = 92f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Gil", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("12/07/1987"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.90f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "João Victor", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("15/06/2002"), Nacionalidade = "Brasileiro", NumeroCamisa = 26, Altura = 1.87f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Bruno Méndez", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("27/11/1998"), Nacionalidade = "Uruguaio", NumeroCamisa = 13, Altura = 1.82f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Lucas Piton", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("22/02/1999"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Esquerdo, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Rafael Ramos", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("29/06/1995"), Nacionalidade = "Portugalês", NumeroCamisa = 5, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },

                new Jogador { Nome = "Maycon", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("15/09/1997"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.78f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Giuliano", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("31/05/1987"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.79f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Renato Augusto", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("08/02/1988"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.73f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Gustavo Mantuan", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("27/04/2001"), Nacionalidade = "Brasileiro", NumeroCamisa = 47, Altura = 1.76f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Adson", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("05/11/2001"), Nacionalidade = "Brasileiro", NumeroCamisa = 37, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Ramiro", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("03/11/1993"), Nacionalidade = "Brasileiro", NumeroCamisa = 48, Altura = 1.85f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Paulinho", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("25/07/1988"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.83f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Du Queiroz", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("06/03/2002"), Nacionalidade = "Brasileiro", NumeroCamisa = 41, Altura = 1.82f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Gabriel Pereira", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("09/12/2001"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.85f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Ángelo Araos", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("23/06/1997"), Nacionalidade = "Chileno", NumeroCamisa = 21, Altura = 1.73f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },

                new Jogador { Nome = "Jô", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("27/03/1987"), Nacionalidade = "Brasileiro", NumeroCamisa = 77, Altura = 1.84f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Roger Guedes", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("22/02/1996"), Nacionalidade = "Brasileiro", NumeroCamisa = 123, Altura = 1.79f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Léo Natel", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("07/11/1997"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.84f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Gustavo Mosquito", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("02/07/1999"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.84f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Mateus Vital", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("29/05/1998"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.79f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Ángel Romero", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("04/07/1992"), Nacionalidade = "Paraguaio", NumeroCamisa = 11, Altura = 1.77f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Clayson", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("07/08/1995"), Nacionalidade = "Brasileiro", NumeroCamisa = 27, Altura = 1.70f, Peso = 64f, PePreferido = PePreferido.Esquerdo, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Roni", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("07/07/2004"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.75f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Corinthians"] },
                new Jogador { Nome = "Yuri Alberto", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("18/03/2002"), Nacionalidade = "Brasileiro", NumeroCamisa = 19, Altura = 1.86f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },

                // São Paulo
                new Jogador { Nome = "Tiago Volpi", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1988-12-19"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Lucas Perri", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1997-04-01"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.89f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Marcelo Carné", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1991-01-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 26, Altura = 1.90f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },

                new Jogador { Nome = "Miranda", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1984-09-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Éder Militão", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1998-01-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Rodrigo Caio", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-08-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.86f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Bruno Alves", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1981-11-27"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.83f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Arboleda", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1991-09-24"), Nacionalidade = "Equatoriano", NumeroCamisa = 6, Altura = 1.87f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },

                new Jogador { Nome = "Daniel Alves", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1983-05-06"), Nacionalidade = "Brasileiro", NumeroCamisa = 13, Altura = 1.72f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Léo", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1982-12-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.81f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },

                new Jogador { Nome = "Jucilei", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1981-09-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.74f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Thiago Mendes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1992-03-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 23, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Tonny Anderson", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1995-03-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 39, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Liziero", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-03-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 20, Altura = 1.79f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Tchê Tchê", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1992-03-31"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.85f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Hernanes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1985-05-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.81f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Igor Gomes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1999-02-21"), Nacionalidade = "Brasileiro", NumeroCamisa = 35, Altura = 1.83f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Hudson", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1988-06-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["São Paulo"] },

                new Jogador { Nome = "Antony", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2000-02-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.72f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Pablo", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1991-09-02"), Nacionalidade = "Argentino", NumeroCamisa = 9, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Everton", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-06-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.78f, Peso = 73f, PePreferido = PePreferido.Esquerdo, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Luciano", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1986-08-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 19, Altura = 1.77f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Diego Souza", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1985-02-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.87f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Calleri", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-02-14"), Nacionalidade = "Argentino", NumeroCamisa = 9, Altura = 1.83f, Peso = 80f, PePreferido = PePreferido.Esquerdo, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Breno Lopes", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-08-27"), Nacionalidade = "Brasileiro", NumeroCamisa = 13, Altura = 1.78f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Rogério Ceni", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1973-09-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Cafu", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1970-06-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Raí", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1965-05-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Müller", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1957-12-31"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Nome = "Careca", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1960-10-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.73f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["São Paulo"] },

                // Botafogo
                new Jogador { Nome = "Gatito Fernández", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1988-04-03"), Nacionalidade = "Paraguaio", NumeroCamisa = 1, Altura = 1.95f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Diego Cavalieri", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1982-03-20"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.86f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Helton Leite", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1988-04-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.90f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },

                new Jogador { Nome = "Joel Carli", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1986-04-05"), Nacionalidade = "Argentino", NumeroCamisa = 4, Altura = 1.92f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Kanu", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1989-01-21"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Marcelo Benevenuto", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-09-04"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Bruno Silva", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1999-03-23"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.81f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },

                new Jogador { Nome = "Luiz Otávio", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1993-08-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.87f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Bruno Nazário", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1995-02-23"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Victor Sá", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1993-11-06"), Nacionalidade = "Angolano", NumeroCamisa = 10, Altura = 1.88f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Olívio", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1996-02-13"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["Botafogo"] },

                new Jogador { Nome = "Cícero", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1989-06-06"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.83f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Chay", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1992-09-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 13, Altura = 1.77f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "André Luís", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-12-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 14, Altura = 1.74f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },

                new Jogador { Nome = "Edson", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1992-10-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Felipe Ferreira", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-11-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.82f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Marcelotes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1997-01-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 17, Altura = 1.76f, Peso = 71f, PePreferido = PePreferido.Esquerdo, TimeId = times["Botafogo"] },

                new Jogador { Nome = "Pedro Raul", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-01-25"), Nacionalidade = "Brasileiro", NumeroCamisa = 18, Altura = 1.87f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Tiquinho Soares", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-06-04"), Nacionalidade = "Brasileiro", NumeroCamisa = 19, Altura = 1.89f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "De Freitas", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1998-03-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 20, Altura = 1.84f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Lucas Fernandes", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-06-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 21, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Mateus Vital", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1998-09-06"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Rafael Navarro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2001-10-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 23, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },

                new Jogador { Nome = "Nilton Santos", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1925-05-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 24, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Garrincha", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1933-10-28"), Nacionalidade = "Brasileiro", NumeroCamisa = 25, Altura = 1.69f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Jairzinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1944-12-25"), Nacionalidade = "Brasileiro", NumeroCamisa = 26, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Túlio Maravilha", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1969-05-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 27, Altura = 1.73f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Paulo Valentim", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1933-01-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Cláudio Adão", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1955-09-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Nome = "Cantarele", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1951-07-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },

                // Internacional
                new Jogador { Nome = "Marcelo Lomba", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1986-10-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Daniel", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1993-03-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.85f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },

                new Jogador { Nome = "Víctor Cuesta", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1988-10-05"), Nacionalidade = "Argentino", NumeroCamisa = 4, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Bruno Méndez", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1998-04-17"), Nacionalidade = "Uruguaio", NumeroCamisa = 2, Altura = 1.84f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Lucas Ribeiro", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1998-05-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.86f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Rodrigo Moledo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1986-08-09"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.88f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Emerson Santos", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-02-06"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Paulo Henrique", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1991-06-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Vitão", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("2000-02-06"), Nacionalidade = "Brasileiro", NumeroCamisa = 26, Altura = 1.90f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Heitor", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1989-12-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 23, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Iago", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1998-11-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.73f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["Internacional"] },

                new Jogador { Nome = "Edenilson", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1991-08-01"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.77f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Rodrigo Dourado", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1994-01-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 18, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Gabriel Boschilia", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-02-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 20, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Nonato", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-09-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.63f, Peso = 62f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Praxedes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2003-02-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.85f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Alan Patrick", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1991-01-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.70f, Peso = 60f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Marcos Guilherme", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-03-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 77, Altura = 1.76f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Kevin", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-12-27"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.79f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Bruno Gomes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2000-06-01"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.75f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Andrés D'Alessandro", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1977-10-15"), Nacionalidade = "Argentino", NumeroCamisa = 15, Altura = 1.70f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },

                new Jogador { Nome = "Yuri Alberto", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1999-03-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.86f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Wanderson", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-07-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 27, Altura = 1.74f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "William Pottker", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-03-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 77, Altura = 1.85f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Nico López", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1993-06-02"), Nacionalidade = "Uruguaio", NumeroCamisa = 10, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Caio Vidal", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-08-23"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.76f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Tiquinho Soares", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-06-04"), Nacionalidade = "Brasileiro", NumeroCamisa = 18, Altura = 1.87f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Paolo Guerrero", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1984-01-01"), Nacionalidade = "Peruano", NumeroCamisa = 9, Altura = 1.84f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Leandro Damião", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1989-03-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.90f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Nome = "Eduardo Sasha", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-06-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 19, Altura = 1.78f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },

                // Cruzeiro
                new Jogador { Nome = "Fábio Jose", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1977-04-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.84f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Rafael Cabral", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1990-04-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.93f, Peso = 92f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Miguel Dias", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1999-09-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },

                new Jogador { Nome = "Murilo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-07-06"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.85f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Lucas Romero", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-06-07"), Nacionalidade = "Paraguaio", NumeroCamisa = 4, Altura = 1.80f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Breno", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1999-12-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 14, Altura = 1.89f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Cacá", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("2001-08-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Léo Ortiz", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-08-04"), Nacionalidade = "Brasileiro", NumeroCamisa = 25, Altura = 1.86f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },

                new Jogador { Nome = "Ronald", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("2000-05-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Ezequiel", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1999-04-10"), Nacionalidade = "Argentino", NumeroCamisa = 22, Altura = 1.84f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Dirceu", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("2002-09-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.76f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Willian Oliveira", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1993-02-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.82f, Peso = 80f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },

                new Jogador { Nome = "Pepê", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1999-01-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.82f, Peso = 77f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Aírton", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2003-02-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.85f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Yago", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1993-04-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },

                new Jogador { Nome = "Ariel Cabral", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1988-11-14"), Nacionalidade = "Argentino", NumeroCamisa = 7, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Aylon", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-08-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.81f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Aloísio", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-10-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.77f, Peso = 73f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },

                new Jogador { Nome = "Gabriel", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-08-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Edu", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1995-12-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 19, Altura = 1.85f, Peso = 80f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Aloísio", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-01-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },

                new Jogador { Nome = "Raniel", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-05-25"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.81f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Marcinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1995-12-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 20, Altura = 1.74f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "David", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1999-10-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 18, Altura = 1.79f, Peso = 76f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Tostão", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1947-01-25"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.73f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Wilson Piazza", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1943-04-25"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.85f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Raul Plassmann", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1944-07-27"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.83f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Nelinho", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1950-07-26"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.79f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Palhinha", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1950-11-04"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Nome = "Dirceu Lopes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1946-02-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },

                // Grêmio
                new Jogador { Nome = "Paulo Victor", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1988-03-01"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Brenno", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1999-02-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.88f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Gabriel Chapecó", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("2001-07-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },

                new Jogador { Nome = "Pedro", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1985-12-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.82f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Kannemann", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1990-12-06"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.87f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "David Braz", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1987-10-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 26, Altura = 1.86f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Ruan", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1998-01-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Vanderson", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("2001-05-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.77f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Rafinha", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1985-07-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 13, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Bruno Cortez", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1989-12-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 21, Altura = 1.71f, Peso = 65f, PePreferido = PePreferido.Esquerdo, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Diogo Barbosa", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1990-05-09"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Geromel", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1985-12-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.82f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Madson", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1991-01-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.77f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },

                new Jogador { Nome = "Matheus Henrique", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1997-11-19"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.83f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Lucas Leiva", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1987-01-09"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.75f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Jean Pyerre", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-05-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.81f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Alisson", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1999-04-26"), Nacionalidade = "Brasileiro", NumeroCamisa = 18, Altura = 1.78f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Darlan", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1999-04-19"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.77f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Bitello", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2001-08-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.74f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Palhinha", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2000-05-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.84f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Lucas Silva", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1993-10-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Thaciano", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1991-03-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 14, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Matheus Sarará", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2000-08-08"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.80f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },

                new Jogador { Nome = "Diego Souza", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1985-03-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.86f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "André", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1995-02-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 35, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Kaio Jorge", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2002-01-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.86f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Robinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1984-01-23"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.72f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Ferreira", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-08-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 21, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Lucca", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1990-05-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.81f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Nome = "Everton Cebolinha", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-11-06"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },

                // Santos
                new Jogador { Nome = "John", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1994-03-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.90f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Vanderlei", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1984-04-01"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.88f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },

                new Jogador { Nome = "Lucas Veríssimo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-06-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Gustavo Henrique", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-12-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.90f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Victor", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-09-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.89f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Felipe Aguilar", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1985-04-26"), Nacionalidade = "Paraguaio", NumeroCamisa = 5, Altura = 1.93f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Luan Peres", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-03-19"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.87f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Nathan", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-03-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 23, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },

                new Jogador { Nome = "Madson", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1988-07-26"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Marcos Leonardo", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("2000-05-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Santos"] },

                new Jogador { Nome = "Gabigol", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1996-08-13"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.75f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Jobson", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1996-03-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.73f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Rodrygo", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2001-01-09"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.74f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Alison", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2003-11-06"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.78f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },

                new Jogador { Nome = "Diego Tardelli", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1985-05-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 19, Altura = 1.79f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Copete", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1987-07-09"), Nacionalidade = "Colombiano", NumeroCamisa = 33, Altura = 1.81f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Jean Mota", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-10-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Santos"] },
                new Jogador { Nome = "Everson Silva", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-08-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 38, Altura = 1.79f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },

                new Jogador { Nome = "Marinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1990-12-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.65f, Peso = 63f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Kaio Jorge", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2002-01-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.89f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Carlos Sánchez", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1984-12-01"), Nacionalidade = "Uruguaio", NumeroCamisa = 14, Altura = 1.63f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Santos"] },
                new Jogador { Nome = "Marcelinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-08-13"), Nacionalidade = "Brasileiro", NumeroCamisa = 24, Altura = 1.88f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Marlon Freitas", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-05-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 18, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },

                new Jogador { Nome = "Pelé", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1940-10-23"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.73f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Pagão", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1934-06-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.72f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Pepe", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1935-02-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.76f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Clodoaldo", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1949-09-23"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.68f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Carlos Alberto Torres", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1944-07-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.72f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Giovanni", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1972-07-04"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Nome = "Robinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1984-01-25"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },

                // Athletico-PR
                new Jogador { Nome = "Santos", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1993-01-26"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.90f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "João Victor", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1998-07-26"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.88f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },

                new Jogador { Nome = "Neto", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1990-07-09"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.90f, Peso = 82f, PePreferido = PePreferido.Esquerdo, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Thiago Heleno", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1988-12-25"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.84f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Abner", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("2000-12-28"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.87f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },

                new Jogador { Nome = "Fabrício Bruno", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-07-21"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.90f, Peso = 87f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Khellven", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("2000-02-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.76f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Abner Vinícius", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("2000-03-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Athletico-PR"] },

                new Jogador { Nome = "Christian", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1998-07-20"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Richard", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1995-12-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.78f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Matheus Galdezani", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1993-10-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.83f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },

                new Jogador { Nome = "Filipe Machado", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-11-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.79f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Deivid", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1999-09-01"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Nikão", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1991-04-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.70f, Peso = 62f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Léo Cittadini", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-06-28"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Hugo Moura", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-11-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 18, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Renan Lodi", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1998-04-08"), Nacionalidade = "Brasileiro", NumeroCamisa = 24, Altura = 1.73f, Peso = 69f, PePreferido = PePreferido.Esquerdo, TimeId = times["Athletico-PR"] },

                new Jogador { Nome = "Niklas", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2003-05-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 17, Altura = 1.82f, Peso = 76f, PePreferido = PePreferido.Esquerdo, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Vitor Roque", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2005-11-28"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.82f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Kadu", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1995-01-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 19, Altura = 1.85f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },

                new Jogador { Nome = "Christian", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1998-07-20"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Matheus Babi", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-08-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.77f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Pablo", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2002-03-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.79f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Alex Mineiro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1975-07-13"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.77f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Paulo Baier", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1974-05-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Dagoberto", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1983-03-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.75f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Kléber", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1982-02-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.85f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Ferreira", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1989-06-11"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.74f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Rodrigo Gral", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1977-05-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.68f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Nome = "Éder Sciola", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1985-05-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 26, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Athletico-PR"] },

                // Fortaleza
                new Jogador { Nome = "Marcelo Boeck", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1984-04-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.85f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Felipe Alves", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1990-06-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.84f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },

                new Jogador { Nome = "Bruno Melo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1991-08-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Marcelo Benevenuto", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-02-25"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.85f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "William Alves", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1988-05-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.87f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Juan Quintero", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1992-11-12"), Nacionalidade = "Colombiano", NumeroCamisa = 6, Altura = 1.86f, Peso = 82f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Gustavo Henrique", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1997-09-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.89f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Delfim", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1995-03-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.84f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Eduardo Brock", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1992-07-20"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.91f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },

                new Jogador { Nome = "Airton", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1990-06-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.79f, Peso = 77f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Yago Pikachu", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1993-03-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.82f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Pablo Dyego", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1993-08-20"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.84f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Gabriel Dias", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1996-05-28"), Nacionalidade = "Brasileiro", NumeroCamisa = 13, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Edson Cariús", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1988-02-20"), Nacionalidade = "Brasileiro", NumeroCamisa = 14, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Grampola", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1990-09-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.81f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },

                new Jogador { Nome = "Lucas Crispim", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1992-02-08"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.77f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Felipe Silva", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-12-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 17, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Marcinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-06-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 18, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Yago", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-04-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 19, Altura = 1.78f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Edinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1987-11-27"), Nacionalidade = "Brasileiro", NumeroCamisa = 20, Altura = 1.79f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Erick", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-04-11"), Nacionalidade = "Brasileiro", NumeroCamisa = 21, Altura = 1.74f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Nathan Lima", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1997-05-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.76f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Moleiro", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-08-09"), Nacionalidade = "Brasileiro", NumeroCamisa = 23, Altura = 1.73f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },

                new Jogador { Nome = "Quintero", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1986-07-23"), Nacionalidade = "Colombiano", NumeroCamisa = 24, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Sassá", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1994-08-26"), Nacionalidade = "Brasileiro", NumeroCamisa = 25, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Jô Santos", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-05-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 26, Altura = 1.84f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Tomas Pochettino", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1994-02-14"), Nacionalidade = "Argentino", NumeroCamisa = 27, Altura = 1.75f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Emanuel Cecilio", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1993-03-09"), Nacionalidade = "Paraguaio", NumeroCamisa = 28, Altura = 1.82f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "José Gonçalves", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1975-05-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Nome = "Carlos Eduardo", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1991-06-04"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.81f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },

                // Bahia
                new Jogador { Nome = "Matheus Teixeira", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1998-06-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.92f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Douglas Friedrich", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1988-09-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },

                new Jogador { Nome = "Lucas Fonseca", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1985-02-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Wesley Matos", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1990-03-23"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.84f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "João Victor", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-11-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 14, Altura = 1.88f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },

                new Jogador { Nome = "Vinícius Machado", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1998-04-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Bahia"] },
                new Jogador { Nome = "Régis", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1989-01-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.72f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Patrick de Lucca", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1994-08-31"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Anderson Talisca", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-02-01"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.92f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Rodriguinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1990-02-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.72f, Peso = 67f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },

                new Jogador { Nome = "Thiago", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-07-25"), Nacionalidade = "Brasileiro", NumeroCamisa = 20, Altura = 1.75f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Gregor", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1989-12-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 21, Altura = 1.78f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Everton Ribeiro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1989-04-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.71f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Gilberto", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1980-02-13"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.82f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Lucas Mugni", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-10-30"), Nacionalidade = "Argentino", NumeroCamisa = 11, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },

                new Jogador { Nome = "Allan", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1994-10-11"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Pires", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1992-01-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 17, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Wesley", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1988-05-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Bahia"] },
                new Jogador { Nome = "Matheus Sales", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1997-01-04"), Nacionalidade = "Brasileiro", NumeroCamisa = 23, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },

                new Jogador { Nome = "Renê", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1992-04-08"), Nacionalidade = "Brasileiro", NumeroCamisa = 25, Altura = 1.74f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Bahia"] },
                new Jogador { Nome = "Elias Manoel", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2001-10-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.88f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Kayser", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("2000-12-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 33, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Bobô", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1962-09-04"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.72f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Charles Fabian", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1961-12-23"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.67f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Marcelo Ramos", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1973-12-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.84f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Fahel", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1981-05-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.83f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Zé Carlos", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1962-08-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Marco Antônio", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1960-04-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "Almir", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1953-10-26"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Nome = "André Bahia", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1983-02-08"), Nacionalidade = "Brasileiro", NumeroCamisa = 33, Altura = 1.90f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },

                // Coritiba
                new Jogador { Nome = "Wilson", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1989-05-28"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.93f, Peso = 87f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Rafael", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1998-01-19"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.88f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },

                new Jogador { Nome = "Jordi Becker", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-02-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Sabino", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-07-31"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.86f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Henrique Petry", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1997-11-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.88f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Bruno Silva", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1997-08-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.84f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },

                new Jogador { Nome = "Luiz Henrique", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1997-09-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.76f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Lucas Bocão", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1998-03-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 31, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Igor", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1999-04-01"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Yuri", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1995-02-23"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.73f, Peso = 69f, PePreferido = PePreferido.Esquerdo, TimeId = times["Coritiba"] },

                new Jogador { Nome = "Fellipe Bastos", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1990-01-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Matheus Galdezani", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1994-07-19"), Nacionalidade = "Brasileiro", NumeroCamisa = 18, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Patrick Breyer", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1997-03-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.79f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Nathan", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1997-05-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 25, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Willian Farias", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1989-04-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },

                new Jogador { Nome = "Thomas", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2000-05-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Matheus Oliveira", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-02-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 23, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Pavez", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1988-06-11"), Nacionalidade = "Chileno", NumeroCamisa = 30, Altura = 1.76f, Peso = 73f, PePreferido = PePreferido.Esquerdo, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Matheus França", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2003-12-01"), Nacionalidade = "Brasileiro", NumeroCamisa = 20, Altura = 1.70f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Iago Silva", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-04-01"), Nacionalidade = "Brasileiro", NumeroCamisa = 24, Altura = 1.91f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },

                new Jogador { Nome = "Elias Manoel", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1999-09-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Robson", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1990-07-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.82f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Vitinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1999-09-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 19, Altura = 1.69f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Léo Gamalho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1986-06-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 17, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Igor Paixão", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2000-10-08"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Washington", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-12-08"), Nacionalidade = "Brasileiro", NumeroCamisa = 21, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },

                new Jogador { Nome = "Dirceu Krüger", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1945-09-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.70f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Jairo", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1946-11-06"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Narciso", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1953-12-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Nome = "Paulo Rink", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1965-06-28"), Nacionalidade = "Alemão", NumeroCamisa = 7, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },

                // Goiás
                new Jogador { Nome = "Tadeu", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1987-02-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Ricardo", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1991-06-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Ramon", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1992-09-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.90f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Gabriel Paulista", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1989-11-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.95f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Ernandes", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1990-03-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.79f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Goiás"] },
                new Jogador { Nome = "Patrick", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1995-05-21"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Moisés", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1988-07-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Goiás"] },
                new Jogador { Nome = "Luiz Fernando", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-02-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.76f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Hyoran", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-09-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 20, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Bruno Rodrigues", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-12-01"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Alef Manga", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1998-05-08"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.82f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Fabrício Daniel", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2000-02-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 19, Altura = 1.81f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Goiás"] },
                new Jogador { Nome = "Pedro Raul", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-07-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.87f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },

                new Jogador { Nome = "Dayverson", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("2000-08-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.75f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Caio Vinicius", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1998-01-20"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Goiás"] },
                new Jogador { Nome = "Marlon", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1997-04-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.88f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Marcão", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1990-06-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 14, Altura = 1.89f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Ricardo Nascimento", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1999-03-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 18, Altura = 1.77f, Peso = 73f, PePreferido = PePreferido.Esquerdo, TimeId = times["Goiás"] },
                new Jogador { Nome = "Vinícius Lopes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2001-11-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 17, Altura = 1.74f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },

                new Jogador { Nome = "Messias", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1993-08-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 23, Altura = 1.83f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Luiz Fernando", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1998-12-04"), Nacionalidade = "Brasileiro", NumeroCamisa = 21, Altura = 1.79f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Rhodolfo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1986-01-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 34, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Felipe Gedoz", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-06-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.78f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Paulo Baier", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1974-04-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Euller", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1964-10-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Edson Bastos", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1977-07-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Mauro Ovelha", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1957-05-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Bruno Mineiro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1983-08-13"), Nacionalidade = "Brasileiro", NumeroCamisa = 19, Altura = 1.85f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Lúcio Flávio", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1975-02-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.72f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Nome = "Jonas", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1983-04-06"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.84f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },

                // Ceará
                new Jogador { Nome = "Fernando Henrique", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1990-02-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.88f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Jefferson Silva", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1992-05-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.86f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "João Vitor", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-08-20"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.90f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Igor Freitas", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-11-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Nome = "Pedro Henrique", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-07-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.87f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Lucas Lima", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1996-01-25"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Nome = "Gustavo Souza", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1997-04-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.79f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Matheus Pereira", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1995-09-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.82f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Felipe Gomes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1992-12-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.80f, Peso = 78f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Nome = "Diego Costa", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1991-06-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.74f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Rafael Santos", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-03-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.76f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Nome = "André Felipe", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-10-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.81f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Bruno Menezes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-01-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 14, Altura = 1.73f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Vitor Hugo", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1990-11-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.84f, Peso = 83f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Nome = "Gabriel Silva", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1993-02-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.83f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Samuel Lima", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-07-21"), Nacionalidade = "Brasileiro", NumeroCamisa = 17, Altura = 1.75f, Peso = 73f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Nome = "Carlos Alberto", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-09-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 19, Altura = 1.79f, Peso = 89f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Luiz Henrique", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-05-27"), Nacionalidade = "Brasileiro", NumeroCamisa = 20, Altura = 1.77f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Nome = "Rafael Moura", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1987-08-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 18, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Diego Alves", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-11-25"), Nacionalidade = "Brasileiro", NumeroCamisa = 21, Altura = 1.82f, Peso = 82f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Nome = "Marcelo Costa", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1991-04-08"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.85f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Antonio Marcos", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-10-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 23, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Nome = "Thiago Rodrigues", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1994-12-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 24, Altura = 1.88f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Vinicius Oliveira", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1995-03-23"), Nacionalidade = "Brasileiro", NumeroCamisa = 25, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Nome = "Ricardo Nunes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1990-06-11"), Nacionalidade = "Brasileiro", NumeroCamisa = 26, Altura = 1.79f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Felipe Martins", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1992-09-19"), Nacionalidade = "Brasileiro", NumeroCamisa = 27, Altura = 1.78f, Peso = 78f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Nome = "Marcelo Henrique", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-07-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.81f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Wallace Pereira", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1993-01-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.86f, Peso = 87f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Nome = "Pedro Lucas", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-05-09"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.81f, Peso = 81f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Nome = "Rafael Lima", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1991-02-28"), Nacionalidade = "Brasileiro", NumeroCamisa = 31, Altura = 1.79f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },

                // Vasco
                new Jogador { Nome = "Fernando Miguel", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1985-11-24"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.88f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Jordy Gaspar", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1992-02-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Paulo Victor", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1988-03-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.88f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },

                new Jogador { Nome = "Leandro Castán", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1985-01-27"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.83f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Ricardo Graça", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1997-10-25"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.89f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Sabino", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-03-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.88f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Luiz Gustavo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-05-20"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Marcos Felipe", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-06-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.87f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Nino", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1997-06-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.87f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Zeca", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1994-09-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.86f, Peso = 80f, PePreferido = PePreferido.Esquerdo, TimeId = times["Vasco"] },

                new Jogador { Nome = "Andrey Santos", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2004-02-04"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.77f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Bruno Gomes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2001-10-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.76f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Jean Lucas", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-02-28"), Nacionalidade = "Brasileiro", NumeroCamisa = 13, Altura = 1.78f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Germán ", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-07-02"), Nacionalidade = "Argentino", NumeroCamisa = 14, Altura = 1.72f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Marquinhos", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-02-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.70f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Edimar", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1986-06-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.74f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Vasco"] },
                new Jogador { Nome = "Calebe", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2000-01-13"), Nacionalidade = "Brasileiro", NumeroCamisa = 17, Altura = 1.80f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Filipe", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-10-31"), Nacionalidade = "Brasileiro", NumeroCamisa = 18, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Diego Pituca", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1992-10-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 19, Altura = 1.76f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Andersinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1989-05-30"), Nacionalidade = "Paraguaio", NumeroCamisa = 20, Altura = 1.72f, Peso = 66f, PePreferido = PePreferido.Esquerdo, TimeId = times["Vasco"] },
                new Jogador { Nome = "Matías Galarza", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2002-11-19"), Nacionalidade = "Argentino", NumeroCamisa = 21, Altura = 1.77f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },

                new Jogador { Nome = "Talles Magno", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2002-06-26"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.76f, Peso = 66f, PePreferido = PePreferido.Esquerdo, TimeId = times["Vasco"] },
                new Jogador { Nome = "Gerundio", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-07-02"), Nacionalidade = "Argentino", NumeroCamisa = 23, Altura = 1.72f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Ribamar", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-10-09"), Nacionalidade = "Brasileiro", NumeroCamisa = 24, Altura = 1.77f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Gabriel Pec", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-03-09"), Nacionalidade = "Brasileiro", NumeroCamisa = 25, Altura = 1.88f, Peso = 82f, PePreferido = PePreferido.Esquerdo, TimeId = times["Vasco"] },
                new Jogador { Nome = "Vinícius", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2001-07-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 26, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Anderson Conceição", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2002-06-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 27, Altura = 1.79f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Roberto Dinamite", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1954-04-13"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.63f, Peso = 59f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Romário", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1966-01-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.67f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Nome = "Edmundo", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1971-04-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.81f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },

                // América-MG
                new Jogador { Nome = "Matheus Cavichioli", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1986-04-04"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Gabriel Mesquita", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1998-07-09"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.88f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "João Ricardo", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1986-09-29"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.89f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },

                new Jogador { Nome = "Cacá", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("2001-05-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.88f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Marlon", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-09-02"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Jemerson", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1992-12-08"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.87f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Gabriel Paulista", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1987-11-26"), Nacionalidade = "Brasileiro", NumeroCamisa = 26, Altura = 1.90f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Diego Cardoso", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1992-02-19"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.84f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },

                new Jogador { Nome = "Patrick", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1993-04-21"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.76f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Lucas Kal", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("2000-10-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 13, Altura = 1.78f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["América-MG"] },
                new Jogador { Nome = "Nino Paraíba", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1986-02-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 14, Altura = 1.75f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },

                new Jogador { Nome = "Juninho Valoura", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1986-02-26"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Alan Franco", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1996-04-25"), Nacionalidade = "Equatoriano", NumeroCamisa = 16, Altura = 1.72f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Cazares", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1992-08-03"), Nacionalidade = "Equatoriano", NumeroCamisa = 8, Altura = 1.74f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["América-MG"] },

                new Jogador { Nome = "Ademir", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-06-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Nathan Silva", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1997-04-27"), Nacionalidade = "Brasileiro", NumeroCamisa = 20, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Rodrigo Pinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1991-08-27"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.79f, Peso = 75f, PePreferido = PePreferido.Esquerdo, TimeId = times["América-MG"] },

                new Jogador { Nome = "Jonathan Cafú", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1991-01-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Edigar Junio", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1987-01-01"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.73f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["América-MG"] },
                new Jogador { Nome = "Valdívia", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-04-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.81f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Cicero", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1979-06-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 14, Altura = 1.78f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Bruno Nazário", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-01-19"), Nacionalidade = "Brasileiro", NumeroCamisa = 17, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Anderson Conceição", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1989-11-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.88f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Dadá Maravilha", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1943-01-19"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.74f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Reinaldo", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1954-01-11"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.75f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Éder Aleixo", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1957-05-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.72f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["América-MG"] },
                new Jogador { Nome = "Washington Coração Valente", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1975-01-01"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.78f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Dicá", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1953-05-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.68f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Cláudio Taffarel", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1966-05-08"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.80f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Nome = "Toninho Cerezo", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1955-04-21"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.74f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },

                // Sport
                new Jogador { Nome = "Ivan Silva", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1995-10-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 1, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Saulo Santos", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1992-05-16"), Nacionalidade = "Brasileiro", NumeroCamisa = 12, Altura = 1.90f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Felipe Costa", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1998-07-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 22, Altura = 1.85f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },

                // Defensores
                new Jogador { Nome = "Patric Souza", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1990-12-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 2, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Natan Oliveira", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1997-11-10"), Nacionalidade = "Brasileiro", NumeroCamisa = 3, Altura = 1.90f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Derlan Ferreira", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1992-03-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 4, Altura = 1.84f, Peso = 82f, PePreferido = PePreferido.Esquerdo, TimeId = times["Sport"] },
                new Jogador { Nome = "Michel Macedo", Posicao = Posicao.Lateraldireito, DataNascimento = DateTime.Parse("1990-04-21"), Nacionalidade = "Brasileiro", NumeroCamisa = 13, Altura = 1.80f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Ronaldo Lima", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1988-09-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 5, Altura = 1.92f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Jefferson Ramos", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-02-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 6, Altura = 1.87f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Jonathan Alves", Posicao = Posicao.Lateralesquerdo, DataNascimento = DateTime.Parse("1994-08-19"), Nacionalidade = "Brasileiro", NumeroCamisa = 16, Altura = 1.84f, Peso = 83f, PePreferido = PePreferido.Esquerdo, TimeId = times["Sport"] },
                new Jogador { Nome = "Carlos Eduardo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-06-11"), Nacionalidade = "Brasileiro", NumeroCamisa = 14, Altura = 1.86f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },

                // Meio-campistas
                new Jogador { Nome = "André Cruz", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1991-07-07"), Nacionalidade = "Brasileiro", NumeroCamisa = 8, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Lucas Gomes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-12-01"), Nacionalidade = "Brasileiro", NumeroCamisa = 20, Altura = 1.82f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Guilherme Santos", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-03-20"), Nacionalidade = "Brasileiro", NumeroCamisa = 10, Altura = 1.76f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Diego Souza", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1985-03-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 30, Altura = 1.86f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Matheus Oliveira", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1997-05-14"), Nacionalidade = "Brasileiro", NumeroCamisa = 15, Altura = 1.78f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Fernando Henrique", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1990-10-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 18, Altura = 1.80f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Rafael Andrade", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1995-09-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 17, Altura = 1.79f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Thiago Carvalho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-04-22"), Nacionalidade = "Brasileiro", NumeroCamisa = 19, Altura = 1.81f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Bruno Silva", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1992-08-25"), Nacionalidade = "Brasileiro", NumeroCamisa = 23, Altura = 1.74f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Sport"] },
                new Jogador { Nome = "Gustavo Mendes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1993-02-05"), Nacionalidade = "Brasileiro", NumeroCamisa = 27, Altura = 1.77f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },

                // Atacantes
                new Jogador { Nome = "Hernane Brocador", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1985-05-18"), Nacionalidade = "Brasileiro", NumeroCamisa = 9, Altura = 1.86f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Mikael Santos", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1995-03-26"), Nacionalidade = "Brasileiro", NumeroCamisa = 11, Altura = 1.82f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Rodrigo Ribeiro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1994-11-11"), Nacionalidade = "Brasileiro", NumeroCamisa = 21, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Lucas Lima", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1998-08-12"), Nacionalidade = "Brasileiro", NumeroCamisa = 29, Altura = 1.68f, Peso = 65f, PePreferido = PePreferido.Esquerdo, TimeId = times["Sport"] },
                new Jogador { Nome = "André Lima", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-06-30"), Nacionalidade = "Brasileiro", NumeroCamisa = 7, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Rafael Martins", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1990-12-15"), Nacionalidade = "Brasileiro", NumeroCamisa = 33, Altura = 1.89f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Joelinton Silva", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-01-03"), Nacionalidade = "Brasileiro", NumeroCamisa = 24, Altura = 1.88f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Eduardo Souza", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1993-07-17"), Nacionalidade = "Brasileiro", NumeroCamisa = 28, Altura = 1.80f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Nome = "Vinícius Pereira", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-09-28"), Nacionalidade = "Brasileiro", NumeroCamisa = 31, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] }
            );
            context.SaveChanges();

            context.ComissoesTecnicas.AddOrUpdate(c => new { c.Nome, c.TimeId },
                // Flamengo 
                new ComissaoTecnica { Nome = "Filipin Luis", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1962-02-13"), TimeId = times["Flamengo"] },
                new ComissaoTecnica { Nome = "Cleber Xavier", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1974-04-20"), TimeId = times["Flamengo"] },
                new ComissaoTecnica { Nome = "Carlos Fortes", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1970-06-15"), TimeId = times["Flamengo"] },
                new ComissaoTecnica { Nome = "Jorge Santos", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1975-09-05"), TimeId = times["Flamengo"] },
                new ComissaoTecnica { Nome = "Mariana Silva", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1980-03-22"), TimeId = times["Flamengo"] },
                new ComissaoTecnica { Nome = "Patrícia Souza", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1982-07-18"), TimeId = times["Flamengo"] },

                // Palmeiras 
                new ComissaoTecnica { Nome = "Abel Ferreira", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1974-02-22"), TimeId = times["Palmeiras"] },
                new ComissaoTecnica { Nome = "Flávio Luiz", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1970-05-10"), TimeId = times["Palmeiras"] },
                new ComissaoTecnica { Nome = "Ricardo Mical", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1980-08-15"), TimeId = times["Palmeiras"] },
                new ComissaoTecnica { Nome = "Sérgio Valentim", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1975-03-05"), TimeId = times["Palmeiras"] },
                new ComissaoTecnica { Nome = "Carolina Lima", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1985-11-30"), TimeId = times["Palmeiras"] },
                new ComissaoTecnica { Nome = "João Oliveira", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1982-07-12"), TimeId = times["Palmeiras"] },

                // Atlético Mineiro
                new ComissaoTecnica { Nome = "Cuca", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1963-06-07"), TimeId = times["Atlético Mineiro"] },
                new ComissaoTecnica { Nome = "Eudes Pedro", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1970-01-15"), TimeId = times["Atlético Mineiro"] },
                new ComissaoTecnica { Nome = "Wesley Oliveira", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-02-20"), TimeId = times["Atlético Mineiro"] },
                new ComissaoTecnica { Nome = "Rogério Contreira", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1978-11-10"), TimeId = times["Atlético Mineiro"] },
                new ComissaoTecnica { Nome = "Marina Santos", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1982-08-05"), TimeId = times["Atlético Mineiro"] },
                new ComissaoTecnica { Nome = "Ricardo Silva", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1980-03-22"), TimeId = times["Atlético Mineiro"] },

                // Fluminense
                new ComissaoTecnica { Nome = "Renato Gaúcho", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1974-02-22"), TimeId = times["Fluminense"] },
                new ComissaoTecnica { Nome = "Thiago Luiz", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1970-05-10"), TimeId = times["Fluminense"] },
                new ComissaoTecnica { Nome = "Mical", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1980-08-15"), TimeId = times["Fluminense"] },
                new ComissaoTecnica { Nome = "Valentim", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1975-03-05"), TimeId = times["Fluminense"] },
                new ComissaoTecnica { Nome = "Lima", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1985-11-30"), TimeId = times["Fluminense"] },
                new ComissaoTecnica { Nome = "João", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1982-07-12"), TimeId = times["Fluminense"] },

                // Corinthians
                new ComissaoTecnica { Nome = "Ramón Diaz", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1974-02-22"), TimeId = times["Corinthians"] },
                new ComissaoTecnica { Nome = "Roger Luiz", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1970-05-10"), TimeId = times["Corinthians"] },
                new ComissaoTecnica { Nome = "Ricardo", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1980-08-15"), TimeId = times["Corinthians"] },
                new ComissaoTecnica { Nome = "Sérgio", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1975-03-05"), TimeId = times["Corinthians"] },
                new ComissaoTecnica { Nome = "Carol Lima", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1985-11-30"), TimeId = times["Corinthians"] },
                new ComissaoTecnica { Nome = "Pedro Oliveira", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1982-07-12"), TimeId = times["Corinthians"] },

                // São Paulo
                new ComissaoTecnica { Nome = "Luiz Zubeldia", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1962-10-26"), TimeId = times["São Paulo"] },
                new ComissaoTecnica { Nome = "Cícero Souza", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1974-07-03"), TimeId = times["São Paulo"] },
                new ComissaoTecnica { Nome = "Rafael Santana", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-04-30"), TimeId = times["São Paulo"] },
                new ComissaoTecnica { Nome = "Rogério Schumann", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1969-08-05"), TimeId = times["São Paulo"] },
                new ComissaoTecnica { Nome = "Juliana Paiva", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1986-02-14"), TimeId = times["São Paulo"] },
                new ComissaoTecnica { Nome = "Marcos Oliveira", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1978-11-22"), TimeId = times["São Paulo"] },

                // Botafogo
                new ComissaoTecnica { Nome = "Abel Braga", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1952-02-01"), TimeId = times["Botafogo"] },
                new ComissaoTecnica { Nome = "Flávio Tenius", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1965-05-20"), TimeId = times["Botafogo"] },
                new ComissaoTecnica { Nome = "Márcio Tropari", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-08-12"), TimeId = times["Botafogo"] },
                new ComissaoTecnica { Nome = "Rafael Tyça", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1980-03-15"), TimeId = times["Botafogo"] },
                new ComissaoTecnica { Nome = "Camila Fisiola", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1982-11-30"), TimeId = times["Botafogo"] },
                new ComissaoTecnica { Nome = "Pedro Fisioter", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1978-07-12"), TimeId = times["Botafogo"] },

                // Internacional
                new ComissaoTecnica { Nome = "Mano Menezes", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1962-07-07"), TimeId = times["Internacional"] },
                new ComissaoTecnica { Nome = "Wesley Carvalho", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1975-09-12"), TimeId = times["Internacional"] },
                new ComissaoTecnica { Nome = "Alex Oliveira", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1980-03-20"), TimeId = times["Internacional"] },
                new ComissaoTecnica { Nome = "Ivan Medina", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1978-11-05"), TimeId = times["Internacional"] },
                new ComissaoTecnica { Nome = "Camila Souza", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1985-06-15"), TimeId = times["Internacional"] },
                new ComissaoTecnica { Nome = "Juliana Castro", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1982-02-28"), TimeId = times["Internacional"] },

                // Cruzeiro
                new ComissaoTecnica { Nome = "Leonardo Jardim", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1957-02-25"), TimeId = times["Cruzeiro"] },
                new ComissaoTecnica { Nome = "Fábio Braz", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1974-07-14"), TimeId = times["Cruzeiro"] },
                new ComissaoTecnica { Nome = "Eduardo Ferreira", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1980-11-02"), TimeId = times["Cruzeiro"] },
                new ComissaoTecnica { Nome = "Rafael Meneses", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1978-05-30"), TimeId = times["Cruzeiro"] },
                new ComissaoTecnica { Nome = "Juliana Santos", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1985-09-18"), TimeId = times["Cruzeiro"] },
                new ComissaoTecnica { Nome = "Marcos Lima", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1982-03-11"), TimeId = times["Cruzeiro"] },

                // Grêmio
                new ComissaoTecnica { Nome = "Renato Portaluppi", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1962-02-13"), TimeId = times["Grêmio"] },
                new ComissaoTecnica { Nome = "Paulo Turra", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1973-01-19"), TimeId = times["Grêmio"] },
                new ComissaoTecnica { Nome = "Cláudio Mix", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1970-09-15"), TimeId = times["Grêmio"] },
                new ComissaoTecnica { Nome = "Anderson Martins", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1975-11-11"), TimeId = times["Grêmio"] },
                new ComissaoTecnica { Nome = "Juliana Rocha", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1988-07-22"), TimeId = times["Grêmio"] },
                new ComissaoTecnica { Nome = "Roberto Souza", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1982-12-05"), TimeId = times["Grêmio"] },

                // Santos
                new ComissaoTecnica { Nome = "Paulo José", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1972-12-01"), TimeId = times["Santos"] },
                new ComissaoTecnica { Nome = "Ricardo Abraham", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1978-04-10"), TimeId = times["Santos"] },
                new ComissaoTecnica { Nome = "Bruno Barra", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1982-09-05"), TimeId = times["Santos"] },
                new ComissaoTecnica { Nome = "Rafael Freire", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1979-02-20"), TimeId = times["Santos"] },
                new ComissaoTecnica { Nome = "Maria Santos", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1986-07-15"), TimeId = times["Santos"] },
                new ComissaoTecnica { Nome = "Pedro Carvalho", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1983-11-03"), TimeId = times["Santos"] },

                // Athletico-PR
                new ComissaoTecnica { Nome = "Luiz Felipe Scolari", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1948-11-09"), TimeId = times["Athletico-PR"] },
                new ComissaoTecnica { Nome = "Guilherme Macuglia", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1963-05-28"), TimeId = times["Athletico-PR"] },
                new ComissaoTecnica { Nome = "Fernando Raposo", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-02-14"), TimeId = times["Athletico-PR"] },
                new ComissaoTecnica { Nome = "João Pegoraro", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1972-08-16"), TimeId = times["Athletico-PR"] },
                new ComissaoTecnica { Nome = "Renata Silva", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1980-06-05"), TimeId = times["Athletico-PR"] },
                new ComissaoTecnica { Nome = "Carlos Meira", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1984-09-20"), TimeId = times["Athletico-PR"] },

                // Fortaleza
                new ComissaoTecnica { Nome = "Leandro Zago", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1981-03-30"), TimeId = times["Fortaleza"] },
                new ComissaoTecnica { Nome = "Diogo Ygor", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1978-07-15"), TimeId = times["Fortaleza"] },
                new ComissaoTecnica { Nome = "Marcel Costa", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-05-12"), TimeId = times["Fortaleza"] },
                new ComissaoTecnica { Nome = "Fábio Moura", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1980-12-01"), TimeId = times["Fortaleza"] },
                new ComissaoTecnica { Nome = "Gabriela Lima", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1984-10-25"), TimeId = times["Fortaleza"] },
                new ComissaoTecnica { Nome = "Rafael Lima", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1979-06-08"), TimeId = times["Fortaleza"] },

                // Bahia
                new ComissaoTecnica { Nome = "Enderson Moreira", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1966-04-17"), TimeId = times["Bahia"] },
                new ComissaoTecnica { Nome = "Alberto Carlos", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1972-09-14"), TimeId = times["Bahia"] },
                new ComissaoTecnica { Nome = "Roberto Silva", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-02-28"), TimeId = times["Bahia"] },
                new ComissaoTecnica { Nome = "Fabio Santos", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1978-07-03"), TimeId = times["Bahia"] },
                new ComissaoTecnica { Nome = "Carol Mendes", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1985-11-12"), TimeId = times["Bahia"] },
                new ComissaoTecnica { Nome = "Juliana Souza", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1983-08-24"), TimeId = times["Bahia"] },

                 // Coritiba
                new ComissaoTecnica { Nome = "Gustavo", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1979-09-07"), TimeId = times["Coritiba"] },
                new ComissaoTecnica { Nome = "João Paulo", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1981-11-12"), TimeId = times["Coritiba"] },
                new ComissaoTecnica { Nome = "Marcos Souza", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1978-04-22"), TimeId = times["Coritiba"] },
                new ComissaoTecnica { Nome = "Felipe Gomes", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1983-02-15"), TimeId = times["Coritiba"] },
                new ComissaoTecnica { Nome = "Ana Beatriz", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1987-06-30"), TimeId = times["Coritiba"] },
                new ComissaoTecnica { Nome = "Rafael Silva", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1985-12-05"), TimeId = times["Coritiba"] },

                // Goiás
                new ComissaoTecnica { Nome = "Gustavo Morínigo", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1977-08-20"), TimeId = times["Goiás"] },
                new ComissaoTecnica { Nome = "Carlos Eduardo", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1980-04-15"), TimeId = times["Goiás"] },
                new ComissaoTecnica { Nome = "Rafael Santos", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-12-10"), TimeId = times["Goiás"] },
                new ComissaoTecnica { Nome = "Maurício Gomes", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1982-03-05"), TimeId = times["Goiás"] },
                new ComissaoTecnica { Nome = "Beatriz Oliveira", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1985-11-30"), TimeId = times["Goiás"] },
                new ComissaoTecnica { Nome = "Lucas Ferreira", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1988-07-12"), TimeId = times["Goiás"] },

                // Ceará
                new ComissaoTecnica { Nome = "Dorival Júnior", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1962-04-25"), TimeId = times["Ceará"] },
                new ComissaoTecnica { Nome = "Marcos Valadares", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1972-03-15"), TimeId = times["Ceará"] },
                new ComissaoTecnica { Nome = "Bruno Quintella", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-07-08"), TimeId = times["Ceará"] },
                new ComissaoTecnica { Nome = "Rafael Lopes", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1978-12-10"), TimeId = times["Ceará"] },
                new ComissaoTecnica { Nome = "Carla Gomes", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1983-05-21"), TimeId = times["Ceará"] },
                new ComissaoTecnica { Nome = "Paulo Henrique", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1980-09-01"), TimeId = times["Ceará"] },

                // Vasco
                new ComissaoTecnica { Nome = "Jorge Jesus", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1954-07-24"), TimeId = times["Vasco"] },
                new ComissaoTecnica { Nome = "Zé Teodoro", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1963-09-16"), TimeId = times["Vasco"] },
                new ComissaoTecnica { Nome = "Andrey Lopes", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-02-12"), TimeId = times["Vasco"] },
                new ComissaoTecnica { Nome = "Helton Leite", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1988-08-17"), TimeId = times["Vasco"] },
                new ComissaoTecnica { Nome = "Fernanda Rocha", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1982-11-05"), TimeId = times["Vasco"] },
                new ComissaoTecnica { Nome = "Ricardo Santos", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1979-04-20"), TimeId = times["Vasco"] },

                // América-MG
                new ComissaoTecnica { Nome = "Paulo Gustavo", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1970-05-10"), TimeId = times["América-MG"] },
                new ComissaoTecnica { Nome = "Marcelo Costa", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1975-08-12"), TimeId = times["América-MG"] },
                new ComissaoTecnica { Nome = "Eduardo Santos", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1980-03-20"), TimeId = times["América-MG"] },
                new ComissaoTecnica { Nome = "Jefferson Ribeiro", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1982-11-30"), TimeId = times["América-MG"] },
                new ComissaoTecnica { Nome = "Aline Ferreira", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1985-07-15"), TimeId = times["América-MG"] },
                new ComissaoTecnica { Nome = "Rodrigo Lima", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1978-02-28"), TimeId = times["América-MG"] },

                // Sport
                new ComissaoTecnica { Nome = "Vanderlei Luxemburgo", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1952-05-10"), TimeId = times["Sport"] },
                new ComissaoTecnica { Nome = "Ailton Silva", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1968-04-01"), TimeId = times["Sport"] },
                new ComissaoTecnica { Nome = "Tiago Santos", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-07-20"), TimeId = times["Sport"] },
                new ComissaoTecnica { Nome = "Bruno Santos", Cargo = Cargo.TreinadorGoleiros, DataNascimento = DateTime.Parse("1978-06-15"), TimeId = times["Sport"] },
                new ComissaoTecnica { Nome = "Marina Sousa", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1982-09-10"), TimeId = times["Sport"] },
                new ComissaoTecnica { Nome = "Rafael Cardoso", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1987-12-05"), TimeId = times["Sport"] }
            );
            context.SaveChanges();
        }
    }
}
