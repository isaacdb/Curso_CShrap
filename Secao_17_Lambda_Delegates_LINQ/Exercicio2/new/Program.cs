using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Principal;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Pessoa> list = new List<Pessoa>();
            list.Add(new Pessoa("maria", 03, 20));
            list.Add(new Pessoa("marisa", 5, 15));
            list.Add(new Pessoa("Cleber", 5, 16));
            list.Add(new Pessoa("marta", 5, 15));
            list.Add(new Pessoa("Jose", 8, 60));
            list.Add(new Pessoa("mariaSilva", 03, 20));

            Pessoa pessoaPadrao = new Pessoa("NomePadrao", 99, 25);



            var buscamaria = list.Where(n => n.Nome == "marisal").DefaultIfEmpty(pessoaPadrao).First();// FirstOrDefault(n => n.Nome == "mariassa");

            var buscamaria2 = list.FirstOrDefault(n => n.Nome == "marisal") ?? pessoaPadrao;
            var buscarMarias = list.Where(n => n.Nome.Contains("maria"));

            Console.WriteLine("Primeira maria: " + buscamaria2.Nome);

            Console.WriteLine();

            foreach (Pessoa p in buscarMarias)
            {
                Console.WriteLine("Todas as marias: " + p.Nome);
            }
            Console.WriteLine();

            var buscaIdade = list.Where(i => i.Idade > 15 && i.Idade < 20);

            foreach (Pessoa p in buscaIdade)
            {
                Console.WriteLine("Com idades entre 15 e 20 anos: " + p.Nome);
            }
        }
    }


    class Pessoa
    {
        public string Nome { get; private set; }
        public int Id { get; set; }
        public int Idade { get; private set; }

        public Pessoa()
        {
        }
        public Pessoa(string nome, int id, int idade)
        {
            Nome = nome;
            Id = id;
            Idade = idade;
        }
    }
}
