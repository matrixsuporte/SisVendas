namespace SisVendas.Migrations
{
    using SisVendas.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SisVendas.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SisVendas.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            List<Genero> generos = new List<Genero>()
            {
                new Genero() { Nome = "Administra��o" },
                new Genero() { Nome = "Agropecu�ria" },
                new Genero() { Nome = "Artes" },
                new Genero() { Nome = "Autoajuda" },
                new Genero() { Nome = "Ci�ncias Biol�gicas" },
                new Genero() { Nome = "Ci�ncias Exatas" },
                new Genero() { Nome = "Ci�ncias Humanas e Sociais" },
                new Genero() { Nome = "Cursos e Idiomas" },
                new Genero() { Nome = "Did�ticos" },
                new Genero() { Nome = "Direito" },
                new Genero() { Nome = "Economia" },
                new Genero() { Nome = "Engenharia e Tecnologia" },
                new Genero() { Nome = "Gastronomia" },
                new Genero() { Nome = "Geografia e Historia" },
                new Genero() { Nome = "Inform�tica" },
                new Genero() { Nome = "Lingu�stica" },
                new Genero() { Nome = "Literatura Nacional" },
                new Genero() { Nome = "Medicina" },
                new Genero() { Nome = "Religi�o" },
                new Genero() { Nome = "Turismo" },
            };

            generos.ForEach(g => context.Generos.Add(g));

            List<Livro> livros = new List<Livro>()
            {
                new Livro() {
                            Titulo = "O Poder do H�bito - Por Que Fazemos o Que Fazemos na Vida e Nos Neg�cios",
                            Autor = "Duhigg, Charles",
                            AnoEdicao = 2012,
                            Valor = 40.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Administra��o")
                },
                new Livro() {
                            Titulo = "Os Segredos da Mente Milion�ria - Aprenda a Enriquecer Mudando seus Conceitos Sobre o Dinheiro",
                            Autor = "Eker, T. Harv",
                            AnoEdicao = 1992,
                            Valor = 22.40m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Administra��o")
                },
                new Livro() {
                            Titulo = "Adestramento Inteligente",
                            Autor = "Rossi, Alexandre",
                            AnoEdicao = 2015,
                            Valor = 20.80m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Agropecu�ria")
                },
                new Livro() {
                            Titulo = "Aves Florestais do Brasil",
                            Autor = "Bini, Etson",
                            AnoEdicao = 2014,
                            Valor = 89.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Agropecu�ria")
                },
                new Livro() {
                            Titulo = "Guerra Civil",
                            Autor = "McNiven, Steve; MILLAR, MARK",
                            AnoEdicao = 2010,
                            Valor = 48m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Artes")
                },
                new Livro() {
                            Titulo = "Batman - A Morte da Fam�lia",
                            Autor = "Capullo, Greg; Snyder, Scott",
                            AnoEdicao = 2016,
                            Valor = 60.80m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Artes")
                },
                new Livro() {
                            Titulo = "Manual de Sobreviv�ncia do Adolescente",
                            Autor = "Loures, Camila",
                            AnoEdicao = 2016,
                            Valor = 19.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Autoajuda")
                },
                new Livro() {
                            Titulo = "O Mapa da Felicidade - As Coordenadas Para Curar A Sua Vida e Nunca Mais Olhar Para Tr�s",
                            Autor = "Capelas, Helo�sa",
                            AnoEdicao = 2014,
                            Valor = 23.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Autoajuda")
                },
                new Livro() {
                            Titulo = "A Origem Das Esp�cies - Edi��o Ilustrada",
                            Autor = "Darwin, Charles",
                            AnoEdicao = 2014,
                            Valor = 71.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ci�ncias Biol�gicas")
                },
                new Livro() {
                            Titulo = "A Sexta Extin��o - Uma Hist�ria N�o Natural",
                            Autor = "Kolbert, Elizabeth",
                            AnoEdicao = 2015,
                            Valor = 17.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ci�ncias Biol�gicas")
                },
                new Livro() {
                            Titulo = "Racioc�nio L�gico Facilitado",
                            Autor = "Villar, Bruno",
                            AnoEdicao = 2016,
                            Valor = 134.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ci�ncias Exatas")
                },
                new Livro() {
                            Titulo = "C�lculo",
                            Autor = "Stewart, James",
                            AnoEdicao = 2015,
                            Valor = 143.20m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ci�ncias Exatas")
                },
                new Livro() {
                            Titulo = "Uma Breve Hist�ria da Humanidad",
                            Autor = "Harari, Yuval Noah",
                            AnoEdicao = 2015,
                            Valor = 47.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ci�ncias Humanas e Sociais")
                },
                new Livro() {
                            Titulo = "O Pr�ncipe - Obra Completa",
                            Autor = "Maquiavel, Nicolau",
                            AnoEdicao = 2007,
                            Valor = 17.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ci�ncias Humanas e Sociais")
                },
                new Livro() {
                            Titulo = "English Grammar In Use With Answers",
                            Autor = "Murphy, Raymond",
                            AnoEdicao = 2012,
                            Valor = 173.50m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Cursos e Idiomas")
                },
                new Livro() {
                            Titulo = "Gram�tica Y Pr�ctica de Espa�ol",
                            Autor = "Fanjul, AdrIan",
                            AnoEdicao = 2014,
                            Valor = 82.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Cursos e Idiomas")
                },
                new Livro() {
                            Titulo = "Nov�ssima Gram�tica da L�ngua Portuguesa",
                            Autor = "Cegalla, Domingos Paschoal",
                            AnoEdicao = 2009,
                            Valor = 82.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Did�ticos")
                },
                new Livro() {
                            Titulo = "Qu�mica - Vol. �nico",
                            Autor = "Usberco, Joao; Salvador, Edgard",
                            AnoEdicao = 2013,
                            Valor = 194.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Did�ticos")
                },
                new Livro() {
                            Titulo = "Direito Processual Civil Esquematizado",
                            Autor = "Gon�alves, Marcus Vinicius Rios; (Coord.), Pedro Lenza",
                            AnoEdicao = 2016,
                            Valor = 163.20m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Direito")
                },
                new Livro() {
                            Titulo = "Direito Administrativo",
                            Autor = "Pietro, Maria Sylvia Zanella Di",
                            AnoEdicao = 2016,
                            Valor = 108.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Direito")
                },
                new Livro() {
                            Titulo = "O Capital - No S�culo XXI",
                            Autor = "Piketty, Thomas",
                            AnoEdicao = 2014,
                            Valor = 34.20m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Economia")
                },
                new Livro() {
                            Titulo = "Fundamentos de Economia",
                            Autor = "Vasconcellos, Marco Antonio S.; Garcia, Manuel E.",
                            AnoEdicao = 2014,
                            Valor = 68.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Economia")
                },
                new Livro() {
                            Titulo = "Manual Do Mundo",
                            Autor = "Alfredo Luis Mateus; Ibere Thenorio",
                            AnoEdicao = 2014,
                            Valor = 39.70m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Engenharia e Tecnologia")
                },
                new Livro() {
                            Titulo = "Ci�ncia Engenharia de Materiais -Uma Introdu��o",
                            Autor = "Callister Jr., William D.",
                            AnoEdicao = 2012,
                            Valor = 223.80m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Engenharia e Tecnologia")
                },
                new Livro() {
                            Titulo = "Bela Cozinha - As Receitas",
                            Autor = "Gil , Bela",
                            AnoEdicao = 2014,
                            Valor = 29.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Gastronomia")
                },
                new Livro() {
                            Titulo = "Por Uma Vida Mais Doce",
                            Autor = "Noce, Danielle",
                            AnoEdicao = 2014,
                            Valor = 79.80m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Gastronomia")
                },
                new Livro() {
                            Titulo = "1808",
                            Autor = "Gomes, Laurentino",
                            AnoEdicao = 2014,
                            Valor = 31.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Geografia e Historia")
                },
                new Livro() {
                            Titulo = "A Hist�ria do Mundo Para Quem Tem Pressa -Mais de 5000 Anos de Hist�ria Resumidos Em 200 P�ginas",
                            Autor = "Marriot, Emma",
                            AnoEdicao = 2015,
                            Valor = 22.60m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Geografia e Historia")
                },
                new Livro() {
                            Titulo = "Redes de Computadores",
                            Autor = "Tanenbaum, Andrew S.; J.Wetherall, David",
                            AnoEdicao = 2011,
                            Valor = 166.40m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Inform�tica")
                },
                new Livro() {
                            Titulo = "L�gica de Programa��o - Conhecendo Algoritmos e Criando Programas",
                            Autor = "Sim�o , Daniel Hayashida; Reis , Wellington Jos� Dos",
                            AnoEdicao = 2015,
                            Valor = 26.40m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Inform�tica")
                },
                new Livro() {
                            Titulo = "M�dia Training - Como Usar A M�dia A Seu Favor",
                            Autor = "Barbeiro, Herodoto",
                            AnoEdicao = 2015,
                            Valor = 25.30m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Lingu�stica")
                },
                new Livro() {
                            Titulo = "Anatomia de Um Julgamento - Ifig�nia Em Forest Hills",
                            Autor = "Malcolm, Janet",
                            AnoEdicao = 2012,
                            Valor = 22.40m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Lingu�stica")
                },
                new Livro() {
                            Titulo = "Tratado de Medicina Interna Veterin�ria - Doen�as do C�o e do Gato",
                            Autor = "Ettinger, Stephen J.; Feldman, Edward C.",
                            AnoEdicao = 2004,
                            Valor = 1309.50m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Medicina")
                },
                new Livro() {
                            Titulo = "Cl�nica Veterin�ria - Um Tratado de Doen�as dos Bovinos, Ovinos, Su�nos, Caprinos e Equinos",
                            Autor = "Outros; Blood, Douglas C.; Radostits, Otto M.",
                            AnoEdicao = 2002,
                            Valor = 1080.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Medicina")
                },
                new Livro() {
                            Titulo = "Quarto de Guerra - A Ora��o � Uma Arma Poderosa na Batalha Espiritual",
                            Autor = "Fabry, Chris",
                            AnoEdicao = 2015,
                            Valor = 25.50m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Religi�o")
                },
                new Livro() {
                            Titulo = "Cristianismo Puro e Simples",
                            Autor = "Lewis, C. S.",
                            AnoEdicao = 2009,
                            Valor = 36.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Religi�o")
                },
                new Livro() {
                            Titulo = "N�o Conta L� Em Casa",
                            Autor = "Fran, Andr�",
                            AnoEdicao = 2013,
                            Valor = 56.60m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Turismo")
                },
                new Livro() {
                            Titulo = "O Melhor Guia de Nova York",
                            Autor = "Andrade, Pedro",
                            AnoEdicao = 2013,
                            Valor = 29.30m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Turismo")
                }
            };

            livros.ForEach(l => context.Livros.Add(l));

            context.SaveChanges();
        }
    }
}
